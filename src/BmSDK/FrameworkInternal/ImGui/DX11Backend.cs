using Hexa.NET.ImGui;
using Hexa.NET.ImGui.Backends.Win32;
using Silk.NET.Direct3D11;
using Silk.NET.DXGI;
using ImGuiImplD3D11 = Hexa.NET.ImGui.Backends.D3D11.ImGuiImplD3D11;
using HexaD3D11Device = Hexa.NET.ImGui.Backends.D3D11.ID3D11Device;
using HexaD3D11Context = Hexa.NET.ImGui.Backends.D3D11.ID3D11DeviceContext;

namespace BmSDK.Framework;

internal static class DX11Backend
{
    [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
    private static extern nint LoadLibraryW(string lpLibFileName);

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
    private static extern nint GetProcAddress(nint hModule, string lpProcName);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private unsafe delegate int CreateDXGIFactoryDelegate(nint riid, nint* ppFactory);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private unsafe delegate int CreateSwapChainDelegate(
        nint pThis,
        nint pDevice,
        nint pDesc,
        nint* ppSwapChain
    );

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private delegate int PresentDelegate(nint swapChain, uint syncInterval, uint flags);

    private static CreateDXGIFactoryDelegate? s_originalCreateDXGIFactory;
    private static CreateDXGIFactoryDelegate? s_originalCreateDXGIFactory1;
    private static CreateSwapChainDelegate? s_originalCreateSwapChain;
    private static PresentDelegate? s_originalPresent;
    private static bool s_renderInitialized;
    private static nint s_device;
    private static nint s_context;

    internal static unsafe void TryInstall()
    {
        try
        {
            var dxgi = LoadLibraryW("dxgi.dll");
            if (dxgi == 0)
            {
                return;
            }

            var createFactory = GetProcAddress(dxgi, "CreateDXGIFactory");
            if (createFactory != 0)
            {
                s_originalCreateDXGIFactory = DetourUtil.NewDetour<CreateDXGIFactoryDelegate>(
                    createFactory,
                    CreateDXGIFactoryHook,
                    false
                );
            }

            var createFactory1 = GetProcAddress(dxgi, "CreateDXGIFactory1");
            if (createFactory1 != 0)
            {
                s_originalCreateDXGIFactory1 = DetourUtil.NewDetour<CreateDXGIFactoryDelegate>(
                    createFactory1,
                    CreateDXGIFactory1Hook,
                    false
                );
            }
        }
        catch
        {
            // DXGI not available
        }
    }

    private static unsafe int CreateDXGIFactoryHook(nint riid, nint* ppFactory)
    {
        var hr = s_originalCreateDXGIFactory!(riid, ppFactory);
        if (hr >= 0 && ppFactory != null && *ppFactory != 0)
        {
            HookCreateSwapChain(*ppFactory);
        }

        return hr;
    }

    private static unsafe int CreateDXGIFactory1Hook(nint riid, nint* ppFactory)
    {
        var hr = s_originalCreateDXGIFactory1!(riid, ppFactory);
        if (hr >= 0 && ppFactory != null && *ppFactory != 0)
        {
            HookCreateSwapChain(*ppFactory);
        }

        return hr;
    }

    private static unsafe void HookCreateSwapChain(nint factoryPtr)
    {
        if (s_originalCreateSwapChain != null)
        {
            return;
        }

        try
        {
            var factory = (IDXGIFactory*)factoryPtr;
            var createSwapChainAddr = (nint)factory->LpVtbl[10];

            s_originalCreateSwapChain = DetourUtil.NewDetour<CreateSwapChainDelegate>(
                createSwapChainAddr,
                CreateSwapChainHook,
                false
            );
        }
        catch
        {
            // Hook installation failed
        }
    }

    private static unsafe int CreateSwapChainHook(
        nint pThis,
        nint pDevice,
        nint pDesc,
        nint* ppSwapChain
    )
    {
        var hr = s_originalCreateSwapChain!(pThis, pDevice, pDesc, ppSwapChain);

        if (hr >= 0 && ppSwapChain != null && *ppSwapChain != 0 && s_originalPresent == null)
        {
            try
            {
                var swapChain = (IDXGISwapChain*)*ppSwapChain;
                var presentAddr = (nint)swapChain->LpVtbl[8];

                s_originalPresent = DetourUtil.NewDetour<PresentDelegate>(
                    presentAddr,
                    PresentHook,
                    false
                );
            }
            catch
            {
                // Hook installation failed
            }
        }

        return hr;
    }

    private static int PresentHook(nint swapChainPtr, uint syncInterval, uint flags)
    {
        try
        {
            if (!s_renderInitialized)
            {
                InitializeForSwapChain(swapChainPtr);
            }

            if (s_renderInitialized)
            {
                RenderFrame(swapChainPtr);
            }
        }
        catch
        {
            // Don't crash the game
        }

        return s_originalPresent!(swapChainPtr, syncInterval, flags);
    }

    private static unsafe void InitializeForSwapChain(nint swapChainPtr)
    {
        var swapChain = (IDXGISwapChain*)swapChainPtr;

        var iid = ID3D11Device.Guid;
        void* dev;
        var hr = swapChain->GetDevice(&iid, &dev);
        if (hr < 0)
        {
            return;
        }

        var device = (ID3D11Device*)dev;
        ID3D11DeviceContext* ctx;
        device->GetImmediateContext(&ctx);

        SwapChainDesc desc;
        swapChain->GetDesc(&desc);

        if (desc.OutputWindow == 0 || !ImGuiController.TryInitialize())
        {
            ctx->Release();
            device->Release();
            return;
        }

        s_device = (nint)device;
        s_context = (nint)ctx;
        ImGuiController.Hwnd = desc.OutputWindow;

        var context = ImGui.GetCurrentContext();

        ImGuiImplWin32.SetCurrentContext(context);
        ImGuiImplWin32.Init((void*)desc.OutputWindow);

        ImGuiImplD3D11.SetCurrentContext(context);
        ImGuiImplD3D11.Init(
            (HexaD3D11Device*)(nint)device,
            (HexaD3D11Context*)(nint)ctx
        );
        ImGuiImplD3D11.CreateDeviceObjects();

        s_renderInitialized = true;
    }

    private static unsafe void RenderFrame(nint swapChainPtr)
    {
        lock (ImGuiController.RenderLock)
        {
            var drawData = ImGui.GetDrawData();
            if (!drawData.Valid || drawData.CmdListsCount == 0)
            {
                return;
            }

            var swapChain = (IDXGISwapChain*)swapChainPtr;
            var device = (ID3D11Device*)s_device;
            var ctx = (ID3D11DeviceContext*)s_context;

            var texIid = ID3D11Texture2D.Guid;
            void* backBuf;
            var hr = swapChain->GetBuffer(0, &texIid, &backBuf);
            if (hr < 0)
            {
                return;
            }

            ID3D11RenderTargetView* rtv;
            var result = device->CreateRenderTargetView((ID3D11Resource*)backBuf, null, &rtv);
            ((ID3D11Texture2D*)backBuf)->Release();
            if (result < 0)
            {
                return;
            }

            ctx->OMSetRenderTargets(1, &rtv, null);
            ImGuiImplD3D11.RenderDrawData(drawData);
            rtv->Release();
        }
    }
}
