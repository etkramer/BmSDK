using Hexa.NET.ImGui;
using Hexa.NET.ImGui.Backends.Win32;
using Silk.NET.Direct3D9;
using ImGuiImplD3D9 = Hexa.NET.ImGui.Backends.D3D9.ImGuiImplD3D9;
using HexaD3D9Device = Hexa.NET.ImGui.Backends.D3D9.IDirect3DDevice9;

namespace BmSDK.Framework;

internal static class DX9Backend
{
    [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
    private static extern nint LoadLibraryW(string lpLibFileName);

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
    private static extern nint GetProcAddress(nint hModule, string lpProcName);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private delegate nint Direct3DCreate9Delegate(uint sdkVersion);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private unsafe delegate int D3D9CreateDeviceDelegate(
        nint pThis,
        uint adapter,
        int deviceType,
        nint hFocusWindow,
        uint behaviorFlags,
        nint pPresentationParameters,
        nint* ppReturnedDeviceInterface
    );

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private delegate int EndSceneDelegate(nint device);

    private static Direct3DCreate9Delegate? s_originalDirect3DCreate9;
    private static D3D9CreateDeviceDelegate? s_originalCreateDevice;
    private static EndSceneDelegate? s_originalEndScene;
    private static bool s_renderInitialized;

    internal static unsafe void TryInstall()
    {
        try
        {
            var d3d9 = LoadLibraryW("d3d9.dll");
            if (d3d9 == 0)
            {
                return;
            }

            var createAddr = GetProcAddress(d3d9, "Direct3DCreate9");
            if (createAddr == 0)
            {
                return;
            }

            s_originalDirect3DCreate9 = DetourUtil.NewDetour<Direct3DCreate9Delegate>(
                createAddr,
                Direct3DCreate9Hook,
                false
            );
        }
        catch
        {
            // D3D9 not available
        }
    }

    private static unsafe nint Direct3DCreate9Hook(uint sdkVersion)
    {
        var result = s_originalDirect3DCreate9!(sdkVersion);

        if (result != 0 && s_originalCreateDevice == null)
        {
            try
            {
                var d3d9 = (IDirect3D9*)result;
                var createDeviceAddr = (nint)d3d9->LpVtbl[16];

                s_originalCreateDevice = DetourUtil.NewDetour<D3D9CreateDeviceDelegate>(
                    createDeviceAddr,
                    D3D9CreateDeviceHook,
                    false
                );
            }
            catch
            {
                // Hook installation failed
            }
        }

        return result;
    }

    private static unsafe int D3D9CreateDeviceHook(
        nint pThis,
        uint adapter,
        int deviceType,
        nint hFocusWindow,
        uint behaviorFlags,
        nint pPresentationParameters,
        nint* ppReturnedDeviceInterface
    )
    {
        var hr = s_originalCreateDevice!(
            pThis,
            adapter,
            deviceType,
            hFocusWindow,
            behaviorFlags,
            pPresentationParameters,
            ppReturnedDeviceInterface
        );

        if (
            hr >= 0
            && ppReturnedDeviceInterface != null
            && *ppReturnedDeviceInterface != 0
            && s_originalEndScene == null
        )
        {
            try
            {
                var device = (IDirect3DDevice9*)*ppReturnedDeviceInterface;
                var endSceneAddr = (nint)device->LpVtbl[42];

                s_originalEndScene = DetourUtil.NewDetour<EndSceneDelegate>(
                    endSceneAddr,
                    EndSceneHook,
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

    private static int EndSceneHook(nint devicePtr)
    {
        try
        {
            if (!s_renderInitialized)
            {
                InitializeForDevice(devicePtr);
            }

            if (s_renderInitialized)
            {
                RenderFrame();
            }
        }
        catch
        {
            // Don't crash the game
        }

        return s_originalEndScene!(devicePtr);
    }

    private static unsafe void InitializeForDevice(nint devicePtr)
    {
        var device = (IDirect3DDevice9*)devicePtr;

        DeviceCreationParameters cp;
        var hr = device->GetCreationParameters(&cp);
        if (hr < 0)
        {
            return;
        }

        var hwnd = cp.HFocusWindow;
        if (hwnd == 0)
        {
            return;
        }

        ImGuiController.Hwnd = hwnd;

        if (!ImGuiController.TryInitialize())
        {
            return;
        }

        var context = ImGui.GetCurrentContext();

        ImGuiImplWin32.SetCurrentContext(context);
        ImGuiImplWin32.Init((void*)hwnd);

        ImGuiImplD3D9.SetCurrentContext(context);
        ImGuiImplD3D9.Init((HexaD3D9Device*)(nint)device);
        ImGuiImplD3D9.CreateDeviceObjects();

        s_renderInitialized = true;
    }

    private static void RenderFrame()
    {
        lock (ImGuiController.RenderLock)
        {
            var drawData = ImGui.GetDrawData();
            if (!drawData.Valid || drawData.CmdListsCount == 0)
            {
                return;
            }

            ImGuiImplD3D9.RenderDrawData(drawData);
        }
    }
}
