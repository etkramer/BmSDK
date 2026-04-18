using System.Numerics;
using ImGuiNET;
using Silk.NET.Direct3D9;
using Silk.NET.Maths;

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
    private static nint s_fontTexture;
    private static nint s_hwnd;

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
                RenderFrame(devicePtr);
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

        s_hwnd = cp.HFocusWindow;
        if (s_hwnd == 0)
        {
            return;
        }

        ImGuiController.Hwnd = s_hwnd;

        if (!ImGuiController.TryInitialize())
        {
            return;
        }

        CreateFontTexture(device);
        s_renderInitialized = true;
    }

    private static unsafe void CreateFontTexture(IDirect3DDevice9* device)
    {
        var io = ImGui.GetIO();
        io.Fonts.GetTexDataAsRGBA32(
            out nint pixels,
            out var width,
            out var height,
            out var bytesPerPixel
        );

        IDirect3DTexture9* texture;
        var hr = device->CreateTexture(
            (uint)width,
            (uint)height,
            1,
            0x200,
            Format.A8R8G8B8,
            Pool.Default,
            &texture,
            null
        );

        if (hr < 0)
        {
            hr = device->CreateTexture(
                (uint)width,
                (uint)height,
                1,
                0,
                Format.A8R8G8B8,
                Pool.Managed,
                &texture,
                null
            );
        }

        if (hr < 0 || texture == null)
        {
            return;
        }

        LockedRect lockedRect;
        hr = texture->LockRect(0, &lockedRect, null, 0);

        if (hr >= 0)
        {
            var src = (byte*)pixels;
            var dst = (byte*)lockedRect.PBits;

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    var si = (y * width + x) * 4;
                    var di = y * lockedRect.Pitch + x * 4;
                    // RGBA -> BGRA
                    dst[di + 0] = src[si + 2];
                    dst[di + 1] = src[si + 1];
                    dst[di + 2] = src[si + 0];
                    dst[di + 3] = src[si + 3];
                }
            }

            texture->UnlockRect(0);
        }

        s_fontTexture = (nint)texture;
        io.Fonts.SetTexID((nint)texture);
    }

    private static unsafe void RenderFrame(nint devicePtr)
    {
        lock (ImGuiController.RenderLock)
        {
            var drawData = ImGui.GetDrawData();
            if (!drawData.Valid || drawData.CmdListsCount == 0)
            {
                return;
            }

            var device = (IDirect3DDevice9*)devicePtr;
            SetupRenderState(device, drawData);

            for (var n = 0; n < drawData.CmdListsCount; n++)
            {
                RenderDrawList(device, drawData.CmdLists[n]);
            }
        }
    }

    private static unsafe void SetupRenderState(IDirect3DDevice9* device, ImDrawDataPtr drawData)
    {
        device->SetVertexShader((IDirect3DVertexShader9*)null);
        device->SetPixelShader((IDirect3DPixelShader9*)null);

        device->SetRenderState(Renderstatetype.Cullmode, (uint)Cull.None);
        device->SetRenderState(Renderstatetype.Zenable, 0);
        device->SetRenderState(Renderstatetype.Lighting, 0);
        device->SetRenderState(Renderstatetype.Alphablendenable, 1);
        device->SetRenderState(Renderstatetype.Alphatestenable, 0);
        device->SetRenderState(Renderstatetype.Blendop, (uint)Blendop.Add);
        device->SetRenderState(Renderstatetype.Srcblend, (uint)Blend.Srcalpha);
        device->SetRenderState(Renderstatetype.Destblend, (uint)Blend.Invsrcalpha);
        device->SetRenderState(Renderstatetype.Scissortestenable, 1);
        device->SetRenderState(Renderstatetype.Shademode, 2);
        device->SetRenderState(Renderstatetype.Fogenable, 0);
        device->SetRenderState(Renderstatetype.Colorwriteenable, 0xF);
        device->SetRenderState(Renderstatetype.Separatealphablendenable, 0);
        device->SetRenderState(Renderstatetype.Stencilenable, 0);

        device->SetTextureStageState(0, Texturestagestatetype.Colorop, 4);
        device->SetTextureStageState(0, Texturestagestatetype.Colorarg1, 2);
        device->SetTextureStageState(0, Texturestagestatetype.Colorarg2, 0);
        device->SetTextureStageState(0, Texturestagestatetype.Alphaop, 4);
        device->SetTextureStageState(0, Texturestagestatetype.Alphaarg1, 2);
        device->SetTextureStageState(0, Texturestagestatetype.Alphaarg2, 0);
        device->SetTextureStageState(1, Texturestagestatetype.Colorop, 1);
        device->SetTextureStageState(1, Texturestagestatetype.Alphaop, 1);

        device->SetSamplerState(0, Samplerstatetype.Minfilter, 2);
        device->SetSamplerState(0, Samplerstatetype.Magfilter, 2);
        device->SetSamplerState(0, Samplerstatetype.Mipfilter, 0);

        device->SetFVF(0x142);

        var L = drawData.DisplayPos.X;
        var R = drawData.DisplayPos.X + drawData.DisplaySize.X;
        var T = drawData.DisplayPos.Y;
        var B = drawData.DisplayPos.Y + drawData.DisplaySize.Y;

        var identity = Matrix4x4.Identity;
        device->SetTransform((Transformstatetype)256, in identity);
        device->SetTransform(Transformstatetype.View, in identity);

        var proj = new Matrix4x4
        {
            M11 = 2.0f / (R - L),
            M22 = 2.0f / (T - B),
            M33 = 0.5f,
            M41 = (L + R) / (L - R),
            M42 = (T + B) / (B - T),
            M43 = 0.5f,
            M44 = 1.0f,
        };
        device->SetTransform(Transformstatetype.Projection, in proj);
    }

    private static unsafe void RenderDrawList(IDirect3DDevice9* device, ImDrawListPtr cmdList)
    {
        var vtxCount = cmdList.VtxBuffer.Size;

        var vtxDst = stackalloc CustomVertex[vtxCount];
        var vtxSrc = (ImDrawVert*)cmdList.VtxBuffer.Data;

        for (var i = 0; i < vtxCount; i++)
        {
            vtxDst[i].X = vtxSrc[i].pos.X;
            vtxDst[i].Y = vtxSrc[i].pos.Y;
            vtxDst[i].Z = 0;
            var c = vtxSrc[i].col;
            vtxDst[i].Color = (c & 0xFF00FF00) | ((c & 0xFF0000) >> 16) | ((c & 0xFF) << 16);
            vtxDst[i].U = vtxSrc[i].uv.X;
            vtxDst[i].V = vtxSrc[i].uv.Y;
        }

        var idxData = (ushort*)cmdList.IdxBuffer.Data;

        for (var cmdIdx = 0; cmdIdx < cmdList.CmdBuffer.Size; cmdIdx++)
        {
            var cmd = cmdList.CmdBuffer[cmdIdx];

            if (cmd.UserCallback != 0)
            {
                continue;
            }

            var scissor = new Box2D<int>(
                new Vector2D<int>((int)cmd.ClipRect.X, (int)cmd.ClipRect.Y),
                new Vector2D<int>((int)cmd.ClipRect.Z, (int)cmd.ClipRect.W)
            );
            device->SetScissorRect(&scissor);
            device->SetTexture(0, (IDirect3DBaseTexture9*)cmd.TextureId);

            device->DrawIndexedPrimitiveUP(
                Primitivetype.Trianglelist,
                cmd.VtxOffset,
                (uint)vtxCount - cmd.VtxOffset,
                cmd.ElemCount / 3,
                idxData + cmd.IdxOffset,
                Format.Index16,
                vtxDst,
                (uint)sizeof(CustomVertex)
            );
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct CustomVertex
    {
        public float X,
            Y,
            Z;
        public uint Color;
        public float U,
            V;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct ImDrawVert
    {
        public System.Numerics.Vector2 pos;
        public System.Numerics.Vector2 uv;
        public uint col;
    }
}
