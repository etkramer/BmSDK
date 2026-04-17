using System.Runtime.InteropServices;
using ImGuiNET;
using Windows.Win32;
using Windows.Win32.Foundation;

namespace BmSDK.DevMode;

internal static class DX9Backend
{
    [DllImport("d3d9.dll")]
    private static extern nint Direct3DCreate9(uint SDKVersion);

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern nint CreateWindowExW(
        uint exStyle, string className, string windowName, uint style,
        int x, int y, int w, int h, nint parent, nint menu, nint instance, nint param);

    [DllImport("user32.dll")]
    private static extern int DestroyWindow(nint hWnd);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
    private static extern nint GetModuleHandleW(string? moduleName);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private delegate int EndSceneDelegate(nint device);

    private static EndSceneDelegate? s_originalEndScene;
    private static bool s_renderInitialized;
    private static nint s_fontTexture;
    private static nint s_hwnd;

    internal static unsafe void TryInstall()
    {
        try
        {
            var d3d9 = Direct3DCreate9(32);
            if (d3d9 == 0)
            {
                return;
            }

            var tmpHwnd = CreateWindowExW(
                0, "STATIC", "BmSDK_DX9_Dummy", 0x80000000,
                0, 0, 1, 1, 0, 0, GetModuleHandleW(null), 0);

            var pp = new D3DPRESENT_PARAMETERS
            {
                Windowed = 1,
                SwapEffect = 1,
                BackBufferFormat = 0,
            };

            nint device;
            var d3d9Vt = *(void***)d3d9;
            var hr = ((delegate* unmanaged[Stdcall]<nint, uint, int, nint, uint, D3DPRESENT_PARAMETERS*, nint*, int>)
                d3d9Vt[16])(d3d9, 0, 4, tmpHwnd, 0x20, &pp, &device);

            if (hr < 0 || device == 0)
            {
                Release(d3d9);
                DestroyWindow(tmpHwnd);
                return;
            }

            var deviceVt = *(void***)device;
            var endSceneAddr = (nint)deviceVt[42];

            Release(device);
            Release(d3d9);
            DestroyWindow(tmpHwnd);

            s_originalEndScene = DetourHelper.CreateDetour<EndSceneDelegate>(endSceneAddr, EndSceneHook);
        }
        catch
        {
            // D3D9 not available
        }
    }

    private static int EndSceneHook(nint device)
    {
        try
        {
            if (!s_renderInitialized)
            {
                InitializeForDevice(device);
            }

            if (s_renderInitialized)
            {
                RenderFrame(device);
            }
        }
        catch
        {
            // Don't crash the game
        }

        return s_originalEndScene!(device);
    }

    private static unsafe void InitializeForDevice(nint device)
    {
        var vt = *(void***)device;

        var cp = new D3DDEVICE_CREATION_PARAMETERS();
        var hr = ((delegate* unmanaged[Stdcall]<nint, D3DDEVICE_CREATION_PARAMETERS*, int>)vt[9])(device, &cp);
        if (hr < 0)
        {
            return;
        }

        s_hwnd = cp.hFocusWindow;
        if (s_hwnd == 0)
        {
            return;
        }

        if (!ImGuiController.TryInitialize())
        {
            return;
        }

        CreateFontTexture(device);
        s_renderInitialized = true;
    }

    private static unsafe void CreateFontTexture(nint device)
    {
        var io = ImGui.GetIO();
        io.Fonts.GetTexDataAsRGBA32(out nint pixels, out var width, out var height, out var bytesPerPixel);

        var vt = *(void***)device;
        nint texture;
        var hr = ((delegate* unmanaged[Stdcall]<nint, uint, uint, uint, uint, int, int, nint*, nint, int>)vt[23])(
            device, (uint)width, (uint)height, 1, 0x200, 21, 0, &texture, 0);

        if (hr < 0)
        {
            // Fallback: try D3DPOOL_MANAGED without DYNAMIC usage
            hr = ((delegate* unmanaged[Stdcall]<nint, uint, uint, uint, uint, int, int, nint*, nint, int>)vt[23])(
                device, (uint)width, (uint)height, 1, 0, 21, 1, &texture, 0);
        }

        if (hr < 0 || texture == 0)
        {
            return;
        }

        var texVt = *(void***)texture;
        D3DLOCKED_RECT lockedRect;
        hr = ((delegate* unmanaged[Stdcall]<nint, uint, D3DLOCKED_RECT*, nint, uint, int>)texVt[19])(
            texture, 0, &lockedRect, 0, 0);

        if (hr >= 0)
        {
            var src = (byte*)pixels;
            var dst = (byte*)lockedRect.pBits;

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    var si = (y * width + x) * 4;
                    var di = y * lockedRect.Pitch + x * 4;
                    // RGBA → BGRA (D3DFMT_A8R8G8B8 stores as BGRA in memory)
                    dst[di + 0] = src[si + 2];
                    dst[di + 1] = src[si + 1];
                    dst[di + 2] = src[si + 0];
                    dst[di + 3] = src[si + 3];
                }
            }

            ((delegate* unmanaged[Stdcall]<nint, uint, int>)texVt[20])(texture, 0);
        }

        s_fontTexture = texture;
        io.Fonts.SetTexID(texture);
    }

    private static unsafe void RenderFrame(nint device)
    {
        var vt = *(void***)device;

        Windows.Win32.Foundation.RECT clientRect;
        PInvoke.GetClientRect(new HWND(s_hwnd), out clientRect);
        var width = clientRect.right - clientRect.left;
        var height = clientRect.bottom - clientRect.top;

        if (width <= 0 || height <= 0)
        {
            return;
        }

        ImGuiController.NewFrame(width, height);

        var drawData = ImGui.GetDrawData();
        if (!drawData.Valid || drawData.CmdListsCount == 0)
        {
            return;
        }

        // Create state block to save/restore device state
        nint stateBlock;
        var hr = ((delegate* unmanaged[Stdcall]<nint, int, nint*, int>)vt[59])(device, 1, &stateBlock);
        if (hr < 0)
        {
            return;
        }

        SetupRenderState(device, vt, drawData);

        for (var n = 0; n < drawData.CmdListsCount; n++)
        {
            RenderDrawList(device, vt, drawData.CmdLists[n]);
        }

        // Restore state
        var sbVt = *(void***)stateBlock;
        ((delegate* unmanaged[Stdcall]<nint, int>)sbVt[5])(stateBlock);
        ((delegate* unmanaged[Stdcall]<nint, uint>)sbVt[2])(stateBlock);
    }

    private static unsafe void SetupRenderState(nint device, void** vt, ImDrawDataPtr drawData)
    {
        var setRS = (delegate* unmanaged[Stdcall]<nint, int, uint, int>)vt[57];
        var setTSS = (delegate* unmanaged[Stdcall]<nint, uint, int, uint, int>)vt[67];
        var setSS = (delegate* unmanaged[Stdcall]<nint, uint, int, uint, int>)vt[69];

        // Disable shaders
        ((delegate* unmanaged[Stdcall]<nint, nint, int>)vt[92])(device, 0);
        ((delegate* unmanaged[Stdcall]<nint, nint, int>)vt[107])(device, 0);

        // Render states
        setRS(device, 22, 1);    // D3DRS_CULLMODE = D3DCULL_NONE
        setRS(device, 7, 0);     // D3DRS_ZENABLE = FALSE
        setRS(device, 137, 0);   // D3DRS_LIGHTING = FALSE
        setRS(device, 27, 1);    // D3DRS_ALPHABLENDENABLE = TRUE
        setRS(device, 15, 0);    // D3DRS_ALPHATESTENABLE = FALSE
        setRS(device, 171, 1);   // D3DRS_BLENDOP = D3DBLENDOP_ADD
        setRS(device, 19, 5);    // D3DRS_SRCBLEND = D3DBLEND_SRCALPHA
        setRS(device, 20, 6);    // D3DRS_DESTBLEND = D3DBLEND_INVSRCALPHA
        setRS(device, 174, 1);   // D3DRS_SCISSORTESTENABLE = TRUE
        setRS(device, 9, 2);     // D3DRS_SHADEMODE = D3DSHADE_GOURAUD
        setRS(device, 28, 0);    // D3DRS_FOGENABLE = FALSE
        setRS(device, 168, 0xF); // D3DRS_COLORWRITEENABLE = ALL
        setRS(device, 206, 0);   // D3DRS_SEPARATEALPHABLENDENABLE = FALSE
        setRS(device, 52, 0);    // D3DRS_STENCILENABLE = FALSE

        // Texture stage states
        setTSS(device, 0, 1, 4);  // Stage 0, COLOROP = MODULATE
        setTSS(device, 0, 2, 2);  // Stage 0, COLORARG1 = TEXTURE
        setTSS(device, 0, 3, 0);  // Stage 0, COLORARG2 = DIFFUSE
        setTSS(device, 0, 4, 4);  // Stage 0, ALPHAOP = MODULATE
        setTSS(device, 0, 5, 2);  // Stage 0, ALPHAARG1 = TEXTURE
        setTSS(device, 0, 6, 0);  // Stage 0, ALPHAARG2 = DIFFUSE
        setTSS(device, 1, 1, 1);  // Stage 1, COLOROP = DISABLE
        setTSS(device, 1, 4, 1);  // Stage 1, ALPHAOP = DISABLE

        // Sampler states
        setSS(device, 0, 5, 2);   // MINFILTER = LINEAR
        setSS(device, 0, 6, 2);   // MAGFILTER = LINEAR
        setSS(device, 0, 7, 0);   // MIPFILTER = NONE

        // FVF: XYZ + DIFFUSE + TEX1
        ((delegate* unmanaged[Stdcall]<nint, uint, int>)vt[89])(device, 0x142);

        // Projection matrix (orthographic)
        var L = drawData.DisplayPos.X;
        var R = drawData.DisplayPos.X + drawData.DisplaySize.X;
        var T = drawData.DisplayPos.Y;
        var B = drawData.DisplayPos.Y + drawData.DisplaySize.Y;

        var setTransform = (delegate* unmanaged[Stdcall]<nint, int, D3DMATRIX*, int>)vt[44];
        var identity = new D3DMATRIX { _11 = 1, _22 = 1, _33 = 1, _44 = 1 };
        setTransform(device, 256, &identity);  // D3DTS_WORLD
        setTransform(device, 2, &identity);    // D3DTS_VIEW

        var proj = new D3DMATRIX
        {
            _11 = 2.0f / (R - L),
            _22 = 2.0f / (T - B),
            _33 = 0.5f,
            _41 = (L + R) / (L - R),
            _42 = (T + B) / (B - T),
            _43 = 0.5f,
            _44 = 1.0f,
        };
        setTransform(device, 3, &proj);        // D3DTS_PROJECTION
    }

    private static unsafe void RenderDrawList(nint device, void** vt, ImDrawListPtr cmdList)
    {
        // Convert ImGui vertices to D3D9 format (need to swap R/B in color and add Z)
        var vtxCount = cmdList.VtxBuffer.Size;
        var idxCount = cmdList.IdxBuffer.Size;

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

        var setTexture = (delegate* unmanaged[Stdcall]<nint, uint, nint, int>)vt[65];
        var setScissorRect = (delegate* unmanaged[Stdcall]<nint, D3DRect*, int>)vt[75];
        var drawIndexedPrimUP = (delegate* unmanaged[Stdcall]<nint, int, uint, uint, uint, void*, int, void*, int, int>)vt[84];

        var idxData = (ushort*)cmdList.IdxBuffer.Data;

        for (var cmdIdx = 0; cmdIdx < cmdList.CmdBuffer.Size; cmdIdx++)
        {
            var cmd = cmdList.CmdBuffer[cmdIdx];

            if (cmd.UserCallback != 0)
            {
                continue;
            }

            var scissor = new D3DRect
            {
                left = (int)cmd.ClipRect.X,
                top = (int)cmd.ClipRect.Y,
                right = (int)cmd.ClipRect.Z,
                bottom = (int)cmd.ClipRect.W,
            };
            setScissorRect(device, &scissor);
            setTexture(device, 0, cmd.TextureId);

            drawIndexedPrimUP(
                device,
                4,
                cmd.VtxOffset,
                (uint)vtxCount - cmd.VtxOffset,
                cmd.ElemCount / 3,
                idxData + cmd.IdxOffset,
                101,
                vtxDst,
                sizeof(CustomVertex));
        }
    }

    private static unsafe void Release(nint comObj)
    {
        ((delegate* unmanaged[Stdcall]<nint, uint>)(*(void***)comObj)[2])(comObj);
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct CustomVertex
    {
        public float X, Y, Z;
        public uint Color;
        public float U, V;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct ImDrawVert
    {
        public System.Numerics.Vector2 pos;
        public System.Numerics.Vector2 uv;
        public uint col;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct D3DPRESENT_PARAMETERS
    {
        public uint BackBufferWidth, BackBufferHeight;
        public int BackBufferFormat;
        public uint BackBufferCount;
        public int MultiSampleType;
        public uint MultiSampleQuality;
        public int SwapEffect;
        public nint hDeviceWindow;
        public int Windowed;
        public int EnableAutoDepthStencil;
        public int AutoDepthStencilFormat;
        public uint Flags;
        public uint FullScreen_RefreshRateInHz;
        public uint PresentationInterval;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct D3DDEVICE_CREATION_PARAMETERS
    {
        public uint AdapterOrdinal;
        public int DeviceType;
        public nint hFocusWindow;
        public uint BehaviorFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct D3DLOCKED_RECT
    {
        public int Pitch;
        public nint pBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct D3DMATRIX
    {
        public float _11, _12, _13, _14;
        public float _21, _22, _23, _24;
        public float _31, _32, _33, _34;
        public float _41, _42, _43, _44;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct D3DRect
    {
        public int left, top, right, bottom;
    }
}
