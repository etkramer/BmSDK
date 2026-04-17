using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;
using Windows.Win32;
using Windows.Win32.Foundation;

namespace BmSDK.DevMode;

internal static class DX11Backend
{
    [DllImport("d3d11.dll")]
    private static extern unsafe int D3D11CreateDeviceAndSwapChain(
        nint pAdapter, int driverType, nint software, uint flags,
        nint pFeatureLevels, uint featureLevels, uint sdkVersion,
        DxgiSwapChainDesc* pSwapChainDesc,
        nint* ppSwapChain, nint* ppDevice, int* pFeatureLevel, nint* ppImmediateContext);

    [DllImport("D3DCompiler_47.dll")]
    private static extern unsafe int D3DCompile(
        byte* pSrcData, nuint srcDataSize, byte* pSourceName,
        nint pDefines, nint pInclude,
        byte* pEntrypoint, byte* pTarget,
        uint flags1, uint flags2, nint* ppCode, nint* ppErrorMsgs);

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern nint CreateWindowExW(
        uint exStyle, string className, string windowName, uint style,
        int x, int y, int w, int h, nint parent, nint menu, nint instance, nint param);

    [DllImport("user32.dll")]
    private static extern int DestroyWindow(nint hWnd);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
    private static extern nint GetModuleHandleW(string? moduleName);

    [DllImport("user32.dll")]
    private static extern int GetClientRect(nint hWnd, out RawRect rect);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private delegate int PresentDelegate(nint swapChain, uint syncInterval, uint flags);

    private static PresentDelegate? s_originalPresent;
    private static bool s_renderInitialized;
    private static nint s_device;
    private static nint s_context;
    private static nint s_hwnd;

    // Rendering resources
    private static nint s_vertexShader;
    private static nint s_pixelShader;
    private static nint s_inputLayout;
    private static nint s_constantBuffer;
    private static nint s_blendState;
    private static nint s_rasterizerState;
    private static nint s_depthStencilState;
    private static nint s_fontTextureSRV;
    private static nint s_fontSampler;
    private static nint s_vertexBuffer;
    private static nint s_indexBuffer;
    private static int s_vertexBufferSize;
    private static int s_indexBufferSize;

    // COM GUIDs
    private static Guid IID_ID3D11Device = new("db6f6ddb-ac77-4e88-8253-819df9bbf140");
    private static Guid IID_ID3D11Texture2D = new("6f15aaf2-d208-4e89-9ab4-489535d34f9c");

    internal static unsafe void TryInstall()
    {
        try
        {
            var tmpHwnd = CreateWindowExW(
                0, "STATIC", "BmSDK_DX11_Dummy", 0x80000000,
                0, 0, 1, 1, 0, 0, GetModuleHandleW(null), 0);

            var scd = new DxgiSwapChainDesc
            {
                BufferCount = 1,
                BufferDesc_Width = 1,
                BufferDesc_Height = 1,
                BufferDesc_Format = 28, // DXGI_FORMAT_R8G8B8A8_UNORM
                BufferUsage = 0x20, // DXGI_USAGE_RENDER_TARGET_OUTPUT
                OutputWindow = tmpHwnd,
                SampleDesc_Count = 1,
                Windowed = 1,
                SwapEffect = 0, // DXGI_SWAP_EFFECT_DISCARD
            };

            nint swapChain, device, ctx;
            int featureLevel;
            var hr = D3D11CreateDeviceAndSwapChain(
                0, 1, 0, 0, 0, 0, 7, &scd,
                &swapChain, &device, &featureLevel, &ctx);

            if (hr < 0)
            {
                DestroyWindow(tmpHwnd);
                return;
            }

            var swapChainVt = *(void***)swapChain;
            var presentAddr = (nint)swapChainVt[8];

            Release(ctx);
            Release(device);
            Release(swapChain);
            DestroyWindow(tmpHwnd);

            s_originalPresent = DetourHelper.CreateDetour<PresentDelegate>(presentAddr, PresentHook);
        }
        catch
        {
            // D3D11 not available
        }
    }

    private static int PresentHook(nint swapChain, uint syncInterval, uint flags)
    {
        try
        {
            if (!s_renderInitialized)
            {
                InitializeForSwapChain(swapChain);
            }

            if (s_renderInitialized)
            {
                RenderFrame(swapChain);
            }
        }
        catch
        {
            // Don't crash the game
        }

        return s_originalPresent!(swapChain, syncInterval, flags);
    }

    private static unsafe void InitializeForSwapChain(nint swapChain)
    {
        var scVt = *(void***)swapChain;

        // IDXGISwapChain::GetDevice → ID3D11Device
        fixed (Guid* iid = &IID_ID3D11Device)
        {
            nint dev;
            var hr = ((delegate* unmanaged[Stdcall]<nint, Guid*, nint*, int>)scVt[7])(swapChain, iid, &dev);
            if (hr < 0)
            {
                return;
            }
            s_device = dev;
        }

        // ID3D11Device::GetImmediateContext
        var devVt = *(void***)s_device;
        nint ctx;
        ((delegate* unmanaged[Stdcall]<nint, nint*, void>)devVt[40])(s_device, &ctx);
        s_context = ctx;

        // Get HWND from swap chain desc
        var desc = new DxgiSwapChainDesc();
        ((delegate* unmanaged[Stdcall]<nint, DxgiSwapChainDesc*, int>)scVt[12])(swapChain, &desc);
        s_hwnd = desc.OutputWindow;

        if (s_hwnd == 0)
        {
            return;
        }

        if (!ImGuiController.TryInitialize())
        {
            return;
        }

        if (!CreateDeviceObjects())
        {
            return;
        }

        s_renderInitialized = true;
    }

    private static unsafe bool CreateDeviceObjects()
    {
        var devVt = *(void***)s_device;

        // Compile vertex shader
        var vsSrc = Encoding.ASCII.GetBytes(VertexShaderHLSL);
        var vsEntry = "main\0"u8.ToArray();
        var vsTarget = "vs_4_0\0"u8.ToArray();
        nint vsBlob;

        fixed (byte* pSrc = vsSrc, pEntry = vsEntry, pTarget = vsTarget)
        {
            nint errBlob;
            var hr = D3DCompile(pSrc, (nuint)vsSrc.Length, null, 0, 0, pEntry, pTarget, 0, 0, &vsBlob, &errBlob);
            if (errBlob != 0)
            {
                Release(errBlob);
            }
            if (hr < 0)
            {
                return false;
            }
        }

        var vsBlobVt = *(void***)vsBlob;
        var vsData = ((delegate* unmanaged[Stdcall]<nint, nint>)vsBlobVt[3])(vsBlob);
        var vsSize = ((delegate* unmanaged[Stdcall]<nint, nuint>)vsBlobVt[4])(vsBlob);

        // ID3D11Device::CreateVertexShader (vtable 12)
        nint vs;
        var result = ((delegate* unmanaged[Stdcall]<nint, nint, nuint, nint, nint*, int>)devVt[12])(
            s_device, vsData, vsSize, 0, &vs);
        if (result < 0)
        {
            Release(vsBlob);
            return false;
        }
        s_vertexShader = vs;

        // Create input layout (vtable 11)
        var layoutDesc = stackalloc InputElementDesc[3];
        var semanticPos = stackalloc byte[] { (byte)'P', (byte)'O', (byte)'S', (byte)'I', (byte)'T', (byte)'I', (byte)'O', (byte)'N', 0 };
        var semanticTex = stackalloc byte[] { (byte)'T', (byte)'E', (byte)'X', (byte)'C', (byte)'O', (byte)'O', (byte)'R', (byte)'D', 0 };
        var semanticCol = stackalloc byte[] { (byte)'C', (byte)'O', (byte)'L', (byte)'O', (byte)'R', 0 };

        layoutDesc[0] = new InputElementDesc { SemanticName = (nint)semanticPos, Format = 16, AlignedByteOffset = 0 };  // R32G32_FLOAT
        layoutDesc[1] = new InputElementDesc { SemanticName = (nint)semanticTex, Format = 16, AlignedByteOffset = 8 };  // R32G32_FLOAT
        layoutDesc[2] = new InputElementDesc { SemanticName = (nint)semanticCol, Format = 28, AlignedByteOffset = 16 }; // R8G8B8A8_UNORM

        nint il;
        result = ((delegate* unmanaged[Stdcall]<nint, InputElementDesc*, uint, nint, nuint, nint*, int>)devVt[11])(
            s_device, layoutDesc, 3, vsData, vsSize, &il);
        Release(vsBlob);
        if (result < 0)
        {
            return false;
        }
        s_inputLayout = il;

        // Compile pixel shader
        var psSrc = Encoding.ASCII.GetBytes(PixelShaderHLSL);
        var psEntry = "main\0"u8.ToArray();
        var psTarget = "ps_4_0\0"u8.ToArray();
        nint psBlob;

        fixed (byte* pSrc = psSrc, pEntry = psEntry, pTarget = psTarget)
        {
            nint errBlob;
            var hr = D3DCompile(pSrc, (nuint)psSrc.Length, null, 0, 0, pEntry, pTarget, 0, 0, &psBlob, &errBlob);
            if (errBlob != 0)
            {
                Release(errBlob);
            }
            if (hr < 0)
            {
                return false;
            }
        }

        var psBlobVt = *(void***)psBlob;
        var psData = ((delegate* unmanaged[Stdcall]<nint, nint>)psBlobVt[3])(psBlob);
        var psSize = ((delegate* unmanaged[Stdcall]<nint, nuint>)psBlobVt[4])(psBlob);

        // ID3D11Device::CreatePixelShader (vtable 15)
        nint ps;
        result = ((delegate* unmanaged[Stdcall]<nint, nint, nuint, nint, nint*, int>)devVt[15])(
            s_device, psData, psSize, 0, &ps);
        Release(psBlob);
        if (result < 0)
        {
            return false;
        }
        s_pixelShader = ps;

        // Create constant buffer (vtable 3)
        var cbDesc = new BufferDesc { ByteWidth = 64, Usage = 1, BindFlags = 4 }; // DYNAMIC, CONSTANT_BUFFER
        nint cb;
        result = ((delegate* unmanaged[Stdcall]<nint, BufferDesc*, nint, nint*, int>)devVt[3])(
            s_device, &cbDesc, 0, &cb);
        if (result < 0)
        {
            return false;
        }
        s_constantBuffer = cb;

        // Create blend state (vtable 20)
        var blendDesc = new BlendDesc();
        blendDesc.RenderTarget0_BlendEnable = 1;
        blendDesc.RenderTarget0_SrcBlend = 5;       // D3D11_BLEND_SRC_ALPHA
        blendDesc.RenderTarget0_DestBlend = 6;      // D3D11_BLEND_INV_SRC_ALPHA
        blendDesc.RenderTarget0_BlendOp = 1;        // D3D11_BLEND_OP_ADD
        blendDesc.RenderTarget0_SrcBlendAlpha = 1;  // D3D11_BLEND_ONE
        blendDesc.RenderTarget0_DestBlendAlpha = 6;  // D3D11_BLEND_INV_SRC_ALPHA
        blendDesc.RenderTarget0_BlendOpAlpha = 1;   // D3D11_BLEND_OP_ADD
        blendDesc.RenderTarget0_WriteMask = 0xF;    // ALL
        nint bs;
        result = ((delegate* unmanaged[Stdcall]<nint, BlendDesc*, nint*, int>)devVt[20])(s_device, &blendDesc, &bs);
        if (result < 0)
        {
            return false;
        }
        s_blendState = bs;

        // Create rasterizer state (vtable 22)
        var rastDesc = new RasterizerDesc
        {
            FillMode = 3,  // D3D11_FILL_SOLID
            CullMode = 1,  // D3D11_CULL_NONE
            ScissorEnable = 1,
            DepthClipEnable = 1,
        };
        nint rs;
        result = ((delegate* unmanaged[Stdcall]<nint, RasterizerDesc*, nint*, int>)devVt[22])(s_device, &rastDesc, &rs);
        if (result < 0)
        {
            return false;
        }
        s_rasterizerState = rs;

        // Create depth stencil state (vtable 21)
        var dsDesc = new DepthStencilDesc
        {
            DepthEnable = 0,
            DepthWriteMask = 1, // D3D11_DEPTH_WRITE_MASK_ALL
            DepthFunc = 4,      // D3D11_COMPARISON_ALWAYS
            StencilEnable = 0,
        };
        nint ds;
        result = ((delegate* unmanaged[Stdcall]<nint, DepthStencilDesc*, nint*, int>)devVt[21])(s_device, &dsDesc, &ds);
        if (result < 0)
        {
            return false;
        }
        s_depthStencilState = ds;

        // Create font texture
        CreateFontTexture();

        return true;
    }

    private static unsafe void CreateFontTexture()
    {
        var io = ImGui.GetIO();
        io.Fonts.GetTexDataAsRGBA32(out nint pixels, out var width, out var height, out var bytesPerPixel);

        var devVt = *(void***)s_device;

        // Create texture (vtable 5)
        var texDesc = new Texture2DDesc
        {
            Width = (uint)width,
            Height = (uint)height,
            MipLevels = 1,
            ArraySize = 1,
            Format = 28, // DXGI_FORMAT_R8G8B8A8_UNORM
            SampleDesc_Count = 1,
            Usage = 0,   // DEFAULT
            BindFlags = 8, // SHADER_RESOURCE
        };
        var initData = new SubresourceData { pSysMem = pixels, SysMemPitch = (uint)(width * 4) };

        nint texture;
        var hr = ((delegate* unmanaged[Stdcall]<nint, Texture2DDesc*, SubresourceData*, nint*, int>)devVt[5])(
            s_device, &texDesc, &initData, &texture);
        if (hr < 0)
        {
            return;
        }

        // Create SRV (vtable 7)
        var srvDesc = new ShaderResourceViewDesc
        {
            Format = 28,
            ViewDimension = 4, // D3D11_SRV_DIMENSION_TEXTURE2D
            MostDetailedMip = 0,
            MipLevels = 1,
        };
        nint srv;
        hr = ((delegate* unmanaged[Stdcall]<nint, nint, ShaderResourceViewDesc*, nint*, int>)devVt[7])(
            s_device, texture, &srvDesc, &srv);
        Release(texture);
        if (hr < 0)
        {
            return;
        }
        s_fontTextureSRV = srv;

        // Create sampler (vtable 23)
        var sampDesc = new SamplerDesc
        {
            Filter = 21, // D3D11_FILTER_MIN_MAG_MIP_LINEAR
            AddressU = 4, AddressV = 4, AddressW = 4, // CLAMP
            ComparisonFunc = 8, // ALWAYS
        };
        nint sampler;
        hr = ((delegate* unmanaged[Stdcall]<nint, SamplerDesc*, nint*, int>)devVt[23])(s_device, &sampDesc, &sampler);
        if (hr < 0)
        {
            return;
        }
        s_fontSampler = sampler;

        io.Fonts.SetTexID(srv);
    }

    private static unsafe void RenderFrame(nint swapChain)
    {
        RawRect clientRect;
        GetClientRect(s_hwnd, out clientRect);
        var width = clientRect.Right - clientRect.Left;
        var height = clientRect.Bottom - clientRect.Top;

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

        var scVt = *(void***)swapChain;
        var devVt = *(void***)s_device;
        var ctxVt = *(void***)s_context;

        // Get back buffer and create RTV
        nint backBuffer;
        fixed (Guid* iid = &IID_ID3D11Texture2D)
        {
            var hr = ((delegate* unmanaged[Stdcall]<nint, uint, Guid*, nint*, int>)scVt[9])(swapChain, 0, iid, &backBuffer);
            if (hr < 0)
            {
                return;
            }
        }

        nint rtv;
        var result = ((delegate* unmanaged[Stdcall]<nint, nint, nint, nint*, int>)devVt[9])(s_device, backBuffer, 0, &rtv);
        Release(backBuffer);
        if (result < 0)
        {
            return;
        }

        // Ensure vertex/index buffers are large enough
        EnsureBuffers(drawData);

        // Update constant buffer with projection matrix
        var L = drawData.DisplayPos.X;
        var R = drawData.DisplayPos.X + drawData.DisplaySize.X;
        var T = drawData.DisplayPos.Y;
        var B = drawData.DisplayPos.Y + drawData.DisplaySize.Y;

        var mvp = stackalloc float[16];
        mvp[0] = 2.0f / (R - L); mvp[1] = 0; mvp[2] = 0; mvp[3] = 0;
        mvp[4] = 0; mvp[5] = 2.0f / (T - B); mvp[6] = 0; mvp[7] = 0;
        mvp[8] = 0; mvp[9] = 0; mvp[10] = 0.5f; mvp[11] = 0;
        mvp[12] = (R + L) / (L - R); mvp[13] = (T + B) / (B - T); mvp[14] = 0.5f; mvp[15] = 1.0f;

        MappedSubresource mapped;
        result = ((delegate* unmanaged[Stdcall]<nint, nint, uint, int, uint, MappedSubresource*, int>)ctxVt[14])(
            s_context, s_constantBuffer, 0, 4, 0, &mapped);
        if (result >= 0)
        {
            Buffer.MemoryCopy(mvp, (void*)mapped.pData, 64, 64);
            ((delegate* unmanaged[Stdcall]<nint, nint, uint, void>)ctxVt[15])(s_context, s_constantBuffer, 0);
        }

        // Upload vertex data
        var vtxMapped = new MappedSubresource();
        result = ((delegate* unmanaged[Stdcall]<nint, nint, uint, int, uint, MappedSubresource*, int>)ctxVt[14])(
            s_context, s_vertexBuffer, 0, 4, 0, &vtxMapped);
        if (result >= 0)
        {
            var totalVtxBytes = drawData.TotalVtxCount * sizeof(ImDrawVert);
            var dst = (byte*)vtxMapped.pData;
            for (var n = 0; n < drawData.CmdListsCount; n++)
            {
                var cmdList = drawData.CmdLists[n];
                Buffer.MemoryCopy(
                    (void*)cmdList.VtxBuffer.Data, dst,
                    totalVtxBytes, cmdList.VtxBuffer.Size * sizeof(ImDrawVert));
                dst += cmdList.VtxBuffer.Size * sizeof(ImDrawVert);
            }
            ((delegate* unmanaged[Stdcall]<nint, nint, uint, void>)ctxVt[15])(s_context, s_vertexBuffer, 0);
        }

        // Upload index data
        var idxMapped = new MappedSubresource();
        result = ((delegate* unmanaged[Stdcall]<nint, nint, uint, int, uint, MappedSubresource*, int>)ctxVt[14])(
            s_context, s_indexBuffer, 0, 4, 0, &idxMapped);
        if (result >= 0)
        {
            var totalIdxBytes = drawData.TotalIdxCount * sizeof(ushort);
            var dst = (byte*)idxMapped.pData;
            for (var n = 0; n < drawData.CmdListsCount; n++)
            {
                var cmdList = drawData.CmdLists[n];
                Buffer.MemoryCopy(
                    (void*)cmdList.IdxBuffer.Data, dst,
                    totalIdxBytes, cmdList.IdxBuffer.Size * sizeof(ushort));
                dst += cmdList.IdxBuffer.Size * sizeof(ushort);
            }
            ((delegate* unmanaged[Stdcall]<nint, nint, uint, void>)ctxVt[15])(s_context, s_indexBuffer, 0);
        }

        // Set pipeline state
        SetupRenderState(ctxVt, rtv, drawData);

        // Draw
        var vtxOffset = 0;
        var idxOffset = 0;
        var clipOff = drawData.DisplayPos;

        for (var n = 0; n < drawData.CmdListsCount; n++)
        {
            var cmdList = drawData.CmdLists[n];
            for (var cmdIdx = 0; cmdIdx < cmdList.CmdBuffer.Size; cmdIdx++)
            {
                var cmd = cmdList.CmdBuffer[cmdIdx];
                if (cmd.UserCallback != 0)
                {
                    continue;
                }

                var scissor = new RawRect
                {
                    Left = (int)(cmd.ClipRect.X - clipOff.X),
                    Top = (int)(cmd.ClipRect.Y - clipOff.Y),
                    Right = (int)(cmd.ClipRect.Z - clipOff.X),
                    Bottom = (int)(cmd.ClipRect.W - clipOff.Y),
                };
                ((delegate* unmanaged[Stdcall]<nint, uint, RawRect*, void>)ctxVt[45])(s_context, 1, &scissor);

                var texSrv = cmd.TextureId;
                ((delegate* unmanaged[Stdcall]<nint, uint, uint, nint*, void>)ctxVt[8])(s_context, 0, 1, &texSrv);

                // DrawIndexed (vtable 12)
                ((delegate* unmanaged[Stdcall]<nint, uint, uint, int, void>)ctxVt[12])(
                    s_context, cmd.ElemCount, (uint)(cmd.IdxOffset + idxOffset), (int)(cmd.VtxOffset + vtxOffset));
            }

            vtxOffset += cmdList.VtxBuffer.Size;
            idxOffset += cmdList.IdxBuffer.Size;
        }

        Release(rtv);
    }

    private static unsafe void SetupRenderState(void** ctxVt, nint rtv, ImDrawDataPtr drawData)
    {
        // IA
        var stride = (uint)sizeof(ImDrawVert);
        uint offset = 0;
        var vb = s_vertexBuffer;
        ((delegate* unmanaged[Stdcall]<nint, uint, uint, nint*, uint*, uint*, void>)ctxVt[18])(
            s_context, 0, 1, &vb, &stride, &offset);
        ((delegate* unmanaged[Stdcall]<nint, nint, int, uint, void>)ctxVt[19])(
            s_context, s_indexBuffer, 57, 0); // DXGI_FORMAT_R16_UINT
        ((delegate* unmanaged[Stdcall]<nint, nint, void>)ctxVt[17])(s_context, s_inputLayout);
        ((delegate* unmanaged[Stdcall]<nint, int, void>)ctxVt[24])(s_context, 4); // TRIANGLELIST

        // VS
        ((delegate* unmanaged[Stdcall]<nint, nint, nint, uint, void>)ctxVt[11])(s_context, s_vertexShader, 0, 0);
        var cb = s_constantBuffer;
        ((delegate* unmanaged[Stdcall]<nint, uint, uint, nint*, void>)ctxVt[7])(s_context, 0, 1, &cb);

        // PS
        ((delegate* unmanaged[Stdcall]<nint, nint, nint, uint, void>)ctxVt[9])(s_context, s_pixelShader, 0, 0);
        var sampler = s_fontSampler;
        ((delegate* unmanaged[Stdcall]<nint, uint, uint, nint*, void>)ctxVt[10])(s_context, 0, 1, &sampler);

        // OM
        var blendFactor = stackalloc float[4];
        ((delegate* unmanaged[Stdcall]<nint, nint, float*, uint, void>)ctxVt[35])(s_context, s_blendState, blendFactor, 0xFFFFFFFF);
        ((delegate* unmanaged[Stdcall]<nint, nint, uint, void>)ctxVt[36])(s_context, s_depthStencilState, 0);
        ((delegate* unmanaged[Stdcall]<nint, uint, nint*, nint, void>)ctxVt[33])(s_context, 1, &rtv, 0);

        // RS
        ((delegate* unmanaged[Stdcall]<nint, nint, void>)ctxVt[43])(s_context, s_rasterizerState);

        var vp = new Viewport
        {
            Width = drawData.DisplaySize.X,
            Height = drawData.DisplaySize.Y,
            MinDepth = 0,
            MaxDepth = 1,
        };
        ((delegate* unmanaged[Stdcall]<nint, uint, Viewport*, void>)ctxVt[44])(s_context, 1, &vp);
    }

    private static unsafe void EnsureBuffers(ImDrawDataPtr drawData)
    {
        var devVt = *(void***)s_device;

        if (s_vertexBuffer == 0 || s_vertexBufferSize < drawData.TotalVtxCount)
        {
            if (s_vertexBuffer != 0)
            {
                Release(s_vertexBuffer);
            }
            s_vertexBufferSize = drawData.TotalVtxCount + 5000;
            var desc = new BufferDesc
            {
                ByteWidth = (uint)(s_vertexBufferSize * sizeof(ImDrawVert)),
                Usage = 2, // DYNAMIC
                BindFlags = 1, // VERTEX_BUFFER
                CPUAccessFlags = 0x10000, // WRITE
            };
            nint buf;
            ((delegate* unmanaged[Stdcall]<nint, BufferDesc*, nint, nint*, int>)devVt[3])(s_device, &desc, 0, &buf);
            s_vertexBuffer = buf;
        }

        if (s_indexBuffer == 0 || s_indexBufferSize < drawData.TotalIdxCount)
        {
            if (s_indexBuffer != 0)
            {
                Release(s_indexBuffer);
            }
            s_indexBufferSize = drawData.TotalIdxCount + 10000;
            var desc = new BufferDesc
            {
                ByteWidth = (uint)(s_indexBufferSize * sizeof(ushort)),
                Usage = 2,
                BindFlags = 2, // INDEX_BUFFER
                CPUAccessFlags = 0x10000,
            };
            nint buf;
            ((delegate* unmanaged[Stdcall]<nint, BufferDesc*, nint, nint*, int>)devVt[3])(s_device, &desc, 0, &buf);
            s_indexBuffer = buf;
        }
    }

    private static unsafe void Release(nint comObj)
    {
        if (comObj != 0)
        {
            ((delegate* unmanaged[Stdcall]<nint, uint>)(*(void***)comObj)[2])(comObj);
        }
    }

    // Shader source
    private const string VertexShaderHLSL = """
        cbuffer vertexBuffer : register(b0) { float4x4 ProjectionMatrix; };
        struct VS_INPUT { float2 pos : POSITION; float2 uv : TEXCOORD0; float4 col : COLOR0; };
        struct PS_INPUT { float4 pos : SV_POSITION; float4 col : COLOR0; float2 uv : TEXCOORD0; };
        PS_INPUT main(VS_INPUT input)
        {
            PS_INPUT output;
            output.pos = mul(ProjectionMatrix, float4(input.pos.xy, 0.f, 1.f));
            output.col = input.col;
            output.uv = input.uv;
            return output;
        }
        """;

    private const string PixelShaderHLSL = """
        struct PS_INPUT { float4 pos : SV_POSITION; float4 col : COLOR0; float2 uv : TEXCOORD0; };
        SamplerState sampler0 : register(s0);
        Texture2D texture0 : register(t0);
        float4 main(PS_INPUT input) : SV_Target
        {
            return input.col * texture0.Sample(sampler0, input.uv);
        }
        """;

    // Interop structs

    [StructLayout(LayoutKind.Sequential)]
    private struct ImDrawVert
    {
        public Vector2 pos;
        public Vector2 uv;
        public uint col;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct DxgiSwapChainDesc
    {
        public uint BufferDesc_Width, BufferDesc_Height;
        public uint BufferDesc_RefreshRate_Num, BufferDesc_RefreshRate_Den;
        public int BufferDesc_Format;
        public int BufferDesc_ScanlineOrdering, BufferDesc_Scaling;
        public uint SampleDesc_Count, SampleDesc_Quality;
        public uint BufferUsage;
        public uint BufferCount;
        public nint OutputWindow;
        public int Windowed;
        public int SwapEffect;
        public uint Flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct BufferDesc
    {
        public uint ByteWidth;
        public int Usage;
        public uint BindFlags, CPUAccessFlags, MiscFlags, StructureByteStride;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct Texture2DDesc
    {
        public uint Width, Height, MipLevels, ArraySize;
        public int Format;
        public uint SampleDesc_Count, SampleDesc_Quality;
        public int Usage;
        public uint BindFlags, CPUAccessFlags, MiscFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct SubresourceData
    {
        public nint pSysMem;
        public uint SysMemPitch, SysMemSlicePitch;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct MappedSubresource
    {
        public nint pData;
        public uint RowPitch, DepthPitch;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct ShaderResourceViewDesc
    {
        public int Format;
        public int ViewDimension;
        public uint MostDetailedMip;
        public uint MipLevels;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct SamplerDesc
    {
        public int Filter;
        public int AddressU, AddressV, AddressW;
        public float MipLODBias;
        public uint MaxAnisotropy;
        public int ComparisonFunc;
        public float BorderColor0, BorderColor1, BorderColor2, BorderColor3;
        public float MinLOD, MaxLOD;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct BlendDesc
    {
        public int AlphaToCoverageEnable;
        public int IndependentBlendEnable;
        public int RenderTarget0_BlendEnable;
        public int RenderTarget0_SrcBlend;
        public int RenderTarget0_DestBlend;
        public int RenderTarget0_BlendOp;
        public int RenderTarget0_SrcBlendAlpha;
        public int RenderTarget0_DestBlendAlpha;
        public int RenderTarget0_BlendOpAlpha;
        public byte RenderTarget0_WriteMask;
        private byte _pad0, _pad1, _pad2;
        // Remaining 7 render targets (zeroed)
        private long _rt1a, _rt1b, _rt2a, _rt2b, _rt3a, _rt3b, _rt4a, _rt4b;
        private long _rt5a, _rt5b, _rt6a, _rt6b, _rt7a, _rt7b;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct RasterizerDesc
    {
        public int FillMode, CullMode;
        public int FrontCounterClockwise, DepthBias;
        public float DepthBiasClamp, SlopeScaledDepthBias;
        public int DepthClipEnable, ScissorEnable;
        public int MultisampleEnable, AntialiasedLineEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct DepthStencilDesc
    {
        public int DepthEnable;
        public int DepthWriteMask;
        public int DepthFunc;
        public int StencilEnable;
        public byte StencilReadMask, StencilWriteMask;
        private byte _pad0, _pad1;
        // Front face stencil op
        public int FrontStencilFailOp, FrontStencilDepthFailOp, FrontStencilPassOp, FrontStencilFunc;
        // Back face stencil op
        public int BackStencilFailOp, BackStencilDepthFailOp, BackStencilPassOp, BackStencilFunc;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct InputElementDesc
    {
        public nint SemanticName;
        public uint SemanticIndex;
        public int Format;
        public uint InputSlot;
        public uint AlignedByteOffset;
        public int InputSlotClass;
        public uint InstanceDataStepRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct Viewport
    {
        public float TopLeftX, TopLeftY, Width, Height, MinDepth, MaxDepth;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct RawRect
    {
        public int Left, Top, Right, Bottom;
    }
}
