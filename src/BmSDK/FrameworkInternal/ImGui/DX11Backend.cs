using System.Numerics;
using System.Text;
using ImGuiNET;
using Silk.NET.Core.Native;
using Silk.NET.Direct3D11;
using Silk.NET.DXGI;
using Silk.NET.Maths;

namespace BmSDK.Framework;

internal static class DX11Backend
{
    [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
    private static extern nint LoadLibraryW(string lpLibFileName);

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
    private static extern nint GetProcAddress(nint hModule, string lpProcName);

    [DllImport("D3DCompiler_47.dll")]
    private static extern unsafe int D3DCompile(
        byte* pSrcData,
        nuint srcDataSize,
        byte* pSourceName,
        nint pDefines,
        nint pInclude,
        byte* pEntrypoint,
        byte* pTarget,
        uint flags1,
        uint flags2,
        ID3D10Blob** ppCode,
        ID3D10Blob** ppErrorMsgs
    );

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
        s_hwnd = desc.OutputWindow;
        ImGuiController.Hwnd = s_hwnd;

        if (!CreateDeviceObjects())
        {
            s_device = 0;
            s_context = 0;
            s_hwnd = 0;
            ctx->Release();
            device->Release();
            return;
        }

        s_renderInitialized = true;
    }

    private static unsafe bool CreateDeviceObjects()
    {
        var device = (ID3D11Device*)s_device;

        // Compile vertex shader
        var vsSrc = Encoding.ASCII.GetBytes(VertexShaderHLSL);
        var vsEntry = "main\0"u8.ToArray();
        var vsTarget = "vs_4_0\0"u8.ToArray();
        ID3D10Blob* vsBlob;

        fixed (
            byte* pSrc = vsSrc,
                pEntry = vsEntry,
                pTarget = vsTarget
        )
        {
            ID3D10Blob* errBlob;
            var hr = D3DCompile(
                pSrc,
                (nuint)vsSrc.Length,
                null,
                0,
                0,
                pEntry,
                pTarget,
                0,
                0,
                &vsBlob,
                &errBlob
            );
            if (errBlob != null)
            {
                errBlob->Release();
            }

            if (hr < 0)
            {
                return false;
            }
        }

        var vsData = vsBlob->GetBufferPointer();
        var vsSize = vsBlob->GetBufferSize();

        ID3D11VertexShader* vs;
        var result = device->CreateVertexShader(vsData, vsSize, null, &vs);
        if (result < 0)
        {
            vsBlob->Release();
            return false;
        }

        s_vertexShader = (nint)vs;

        // Create input layout
        fixed (byte* semanticPos = SilkMarshal.StringToMemory("POSITION"))
        fixed (byte* semanticTex = SilkMarshal.StringToMemory("TEXCOORD"))
        fixed (byte* semanticCol = SilkMarshal.StringToMemory("COLOR"))
        {
            var layoutDesc = stackalloc InputElementDesc[3];
            layoutDesc[0] = new InputElementDesc
            {
                SemanticName = semanticPos,
                Format = Format.FormatR32G32Float,
                AlignedByteOffset = 0,
            };
            layoutDesc[1] = new InputElementDesc
            {
                SemanticName = semanticTex,
                Format = Format.FormatR32G32Float,
                AlignedByteOffset = 8,
            };
            layoutDesc[2] = new InputElementDesc
            {
                SemanticName = semanticCol,
                Format = Format.FormatR8G8B8A8Unorm,
                AlignedByteOffset = 16,
            };

            ID3D11InputLayout* il;
            result = device->CreateInputLayout(layoutDesc, 3, vsData, vsSize, &il);
            vsBlob->Release();
            if (result < 0)
            {
                return false;
            }

            s_inputLayout = (nint)il;
        }

        // Compile pixel shader
        var psSrc = Encoding.ASCII.GetBytes(PixelShaderHLSL);
        var psEntry = "main\0"u8.ToArray();
        var psTarget = "ps_4_0\0"u8.ToArray();
        ID3D10Blob* psBlob;

        fixed (
            byte* pSrc = psSrc,
                pEntry = psEntry,
                pTarget = psTarget
        )
        {
            ID3D10Blob* errBlob;
            var hr = D3DCompile(
                pSrc,
                (nuint)psSrc.Length,
                null,
                0,
                0,
                pEntry,
                pTarget,
                0,
                0,
                &psBlob,
                &errBlob
            );
            if (errBlob != null)
            {
                errBlob->Release();
            }

            if (hr < 0)
            {
                return false;
            }
        }

        ID3D11PixelShader* ps;
        result = device->CreatePixelShader(
            psBlob->GetBufferPointer(),
            psBlob->GetBufferSize(),
            null,
            &ps
        );
        psBlob->Release();
        if (result < 0)
        {
            return false;
        }

        s_pixelShader = (nint)ps;

        // Create constant buffer
        var cbDesc = new BufferDesc
        {
            ByteWidth = 64,
            Usage = Usage.Dynamic,
            BindFlags = (uint)BindFlag.ConstantBuffer,
            CPUAccessFlags = (uint)CpuAccessFlag.Write,
        };
        ID3D11Buffer* cb;
        result = device->CreateBuffer(&cbDesc, null, &cb);
        if (result < 0)
        {
            return false;
        }

        s_constantBuffer = (nint)cb;

        // Create blend state
        var blendDesc = new BlendDesc();
        blendDesc.RenderTarget[0] = new RenderTargetBlendDesc
        {
            BlendEnable = 1,
            SrcBlend = Blend.SrcAlpha,
            DestBlend = Blend.InvSrcAlpha,
            BlendOp = BlendOp.Add,
            SrcBlendAlpha = Blend.One,
            DestBlendAlpha = Blend.InvSrcAlpha,
            BlendOpAlpha = BlendOp.Add,
            RenderTargetWriteMask = 0xF,
        };
        ID3D11BlendState* bs;
        result = device->CreateBlendState(&blendDesc, &bs);
        if (result < 0)
        {
            return false;
        }

        s_blendState = (nint)bs;

        // Create rasterizer state
        var rastDesc = new RasterizerDesc
        {
            FillMode = FillMode.Solid,
            CullMode = CullMode.None,
            ScissorEnable = 1,
            DepthClipEnable = 1,
        };
        ID3D11RasterizerState* rs;
        result = device->CreateRasterizerState(&rastDesc, &rs);
        if (result < 0)
        {
            return false;
        }

        s_rasterizerState = (nint)rs;

        // Create depth stencil state
        var dsDesc = new DepthStencilDesc
        {
            DepthEnable = 0,
            DepthWriteMask = DepthWriteMask.All,
            DepthFunc = ComparisonFunc.Always,
            StencilEnable = 0,
        };
        ID3D11DepthStencilState* ds;
        result = device->CreateDepthStencilState(&dsDesc, &ds);
        if (result < 0)
        {
            return false;
        }

        s_depthStencilState = (nint)ds;

        CreateFontTexture();

        return true;
    }

    private static unsafe void CreateFontTexture()
    {
        var device = (ID3D11Device*)s_device;
        var io = ImGui.GetIO();
        io.Fonts.GetTexDataAsRGBA32(
            out nint pixels,
            out var width,
            out var height,
            out var bytesPerPixel
        );

        var texDesc = new Texture2DDesc
        {
            Width = (uint)width,
            Height = (uint)height,
            MipLevels = 1,
            ArraySize = 1,
            Format = Format.FormatR8G8B8A8Unorm,
            SampleDesc = new SampleDesc(1, 0),
            Usage = Usage.Default,
            BindFlags = (uint)BindFlag.ShaderResource,
        };
        var initData = new SubresourceData
        {
            PSysMem = (void*)pixels,
            SysMemPitch = (uint)(width * 4),
        };

        ID3D11Texture2D* texture;
        var hr = device->CreateTexture2D(&texDesc, &initData, &texture);
        if (hr < 0)
        {
            return;
        }

        var srvDesc = new ShaderResourceViewDesc
        {
            Format = Format.FormatR8G8B8A8Unorm,
            ViewDimension = D3DSrvDimension.D3DSrvDimensionTexture2D,
            Anonymous = new ShaderResourceViewDescUnion
            {
                Texture2D = { MostDetailedMip = 0, MipLevels = 1 },
            },
        };
        ID3D11ShaderResourceView* srv;
        hr = device->CreateShaderResourceView((ID3D11Resource*)texture, &srvDesc, &srv);
        texture->Release();
        if (hr < 0)
        {
            return;
        }

        s_fontTextureSRV = (nint)srv;

        var sampDesc = new SamplerDesc
        {
            Filter = Filter.MinMagMipLinear,
            AddressU = TextureAddressMode.Border,
            AddressV = TextureAddressMode.Border,
            AddressW = TextureAddressMode.Border,
            ComparisonFunc = ComparisonFunc.Always,
        };
        ID3D11SamplerState* sampler;
        hr = device->CreateSamplerState(&sampDesc, &sampler);
        if (hr < 0)
        {
            return;
        }

        s_fontSampler = (nint)sampler;

        io.Fonts.SetTexID((nint)srv);
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

            // Get back buffer and create RTV
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

            EnsureBuffers(drawData);

            // Update constant buffer with projection matrix
            var L = drawData.DisplayPos.X;
            var R = drawData.DisplayPos.X + drawData.DisplaySize.X;
            var T = drawData.DisplayPos.Y;
            var B = drawData.DisplayPos.Y + drawData.DisplaySize.Y;

            var mvp = stackalloc float[16];
            mvp[0] = 2.0f / (R - L);
            mvp[1] = 0;
            mvp[2] = 0;
            mvp[3] = 0;
            mvp[4] = 0;
            mvp[5] = 2.0f / (T - B);
            mvp[6] = 0;
            mvp[7] = 0;
            mvp[8] = 0;
            mvp[9] = 0;
            mvp[10] = 0.5f;
            mvp[11] = 0;
            mvp[12] = (R + L) / (L - R);
            mvp[13] = (T + B) / (B - T);
            mvp[14] = 0.5f;
            mvp[15] = 1.0f;

            MappedSubresource mapped;
            result = ctx->Map((ID3D11Resource*)s_constantBuffer, 0, Map.WriteDiscard, 0, &mapped);
            if (result >= 0)
            {
                Buffer.MemoryCopy(mvp, mapped.PData, 64, 64);
                ctx->Unmap((ID3D11Resource*)s_constantBuffer, 0);
            }

            // Upload vertex data
            MappedSubresource vtxMapped;
            result = ctx->Map((ID3D11Resource*)s_vertexBuffer, 0, Map.WriteDiscard, 0, &vtxMapped);
            if (result >= 0)
            {
                var totalVtxBytes = drawData.TotalVtxCount * sizeof(ImDrawVert);
                var dst = (byte*)vtxMapped.PData;
                for (var n = 0; n < drawData.CmdListsCount; n++)
                {
                    var cmdList = drawData.CmdLists[n];
                    Buffer.MemoryCopy(
                        (void*)cmdList.VtxBuffer.Data,
                        dst,
                        totalVtxBytes,
                        cmdList.VtxBuffer.Size * sizeof(ImDrawVert)
                    );
                    dst += cmdList.VtxBuffer.Size * sizeof(ImDrawVert);
                }

                ctx->Unmap((ID3D11Resource*)s_vertexBuffer, 0);
            }

            // Upload index data
            MappedSubresource idxMapped;
            result = ctx->Map((ID3D11Resource*)s_indexBuffer, 0, Map.WriteDiscard, 0, &idxMapped);
            if (result >= 0)
            {
                var totalIdxBytes = drawData.TotalIdxCount * sizeof(ushort);
                var dst = (byte*)idxMapped.PData;
                for (var n = 0; n < drawData.CmdListsCount; n++)
                {
                    var cmdList = drawData.CmdLists[n];
                    Buffer.MemoryCopy(
                        (void*)cmdList.IdxBuffer.Data,
                        dst,
                        totalIdxBytes,
                        cmdList.IdxBuffer.Size * sizeof(ushort)
                    );
                    dst += cmdList.IdxBuffer.Size * sizeof(ushort);
                }

                ctx->Unmap((ID3D11Resource*)s_indexBuffer, 0);
            }

            // Set pipeline state
            SetupRenderState(ctx, rtv, drawData);

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

                    var scissor = new Box2D<int>(
                        new Vector2D<int>(
                            (int)(cmd.ClipRect.X - clipOff.X),
                            (int)(cmd.ClipRect.Y - clipOff.Y)
                        ),
                        new Vector2D<int>(
                            (int)(cmd.ClipRect.Z - clipOff.X),
                            (int)(cmd.ClipRect.W - clipOff.Y)
                        )
                    );
                    ctx->RSSetScissorRects(1, &scissor);

                    var texSrv = (ID3D11ShaderResourceView*)cmd.TextureId;
                    ctx->PSSetShaderResources(0, 1, &texSrv);

                    ctx->DrawIndexed(
                        cmd.ElemCount,
                        (uint)(cmd.IdxOffset + idxOffset),
                        (int)(cmd.VtxOffset + vtxOffset)
                    );
                }

                vtxOffset += cmdList.VtxBuffer.Size;
                idxOffset += cmdList.IdxBuffer.Size;
            }

            rtv->Release();
        }
    }

    private static unsafe void SetupRenderState(
        ID3D11DeviceContext* ctx,
        ID3D11RenderTargetView* rtv,
        ImDrawDataPtr drawData
    )
    {
        // IA
        var stride = (uint)sizeof(ImDrawVert);
        uint offset = 0;
        var vb = (ID3D11Buffer*)s_vertexBuffer;
        ctx->IASetVertexBuffers(0, 1, &vb, &stride, &offset);
        ctx->IASetIndexBuffer((ID3D11Buffer*)s_indexBuffer, Format.FormatR16Uint, 0);
        ctx->IASetInputLayout((ID3D11InputLayout*)s_inputLayout);
        ctx->IASetPrimitiveTopology(D3DPrimitiveTopology.D3DPrimitiveTopologyTrianglelist);

        // VS
        ctx->VSSetShader((ID3D11VertexShader*)s_vertexShader, null, 0);
        var cb = (ID3D11Buffer*)s_constantBuffer;
        ctx->VSSetConstantBuffers(0, 1, &cb);

        // PS
        ctx->PSSetShader((ID3D11PixelShader*)s_pixelShader, null, 0);
        var sampler = (ID3D11SamplerState*)s_fontSampler;
        ctx->PSSetSamplers(0, 1, &sampler);

        // OM
        var blendFactor = stackalloc float[4];
        ctx->OMSetBlendState((ID3D11BlendState*)s_blendState, blendFactor, 0xFFFFFFFF);
        ctx->OMSetDepthStencilState((ID3D11DepthStencilState*)s_depthStencilState, 0);
        ctx->OMSetRenderTargets(1, &rtv, null);

        // RS
        ctx->RSSetState((ID3D11RasterizerState*)s_rasterizerState);

        var vp = new Viewport
        {
            Width = drawData.DisplaySize.X,
            Height = drawData.DisplaySize.Y,
            MaxDepth = 1,
        };
        ctx->RSSetViewports(1, &vp);
    }

    private static unsafe void EnsureBuffers(ImDrawDataPtr drawData)
    {
        var device = (ID3D11Device*)s_device;

        if (s_vertexBuffer == 0 || s_vertexBufferSize < drawData.TotalVtxCount)
        {
            if (s_vertexBuffer != 0)
            {
                ((ID3D11Buffer*)s_vertexBuffer)->Release();
            }

            s_vertexBufferSize = drawData.TotalVtxCount + 5000;
            var desc = new BufferDesc
            {
                ByteWidth = (uint)(s_vertexBufferSize * sizeof(ImDrawVert)),
                Usage = Usage.Dynamic,
                BindFlags = (uint)BindFlag.VertexBuffer,
                CPUAccessFlags = (uint)CpuAccessFlag.Write,
            };
            ID3D11Buffer* buf;
            device->CreateBuffer(&desc, null, &buf);
            s_vertexBuffer = (nint)buf;
        }

        if (s_indexBuffer == 0 || s_indexBufferSize < drawData.TotalIdxCount)
        {
            if (s_indexBuffer != 0)
            {
                ((ID3D11Buffer*)s_indexBuffer)->Release();
            }

            s_indexBufferSize = drawData.TotalIdxCount + 10000;
            var desc = new BufferDesc
            {
                ByteWidth = (uint)(s_indexBufferSize * sizeof(ushort)),
                Usage = Usage.Dynamic,
                BindFlags = (uint)BindFlag.IndexBuffer,
                CPUAccessFlags = (uint)CpuAccessFlag.Write,
            };
            ID3D11Buffer* buf;
            device->CreateBuffer(&desc, null, &buf);
            s_indexBuffer = (nint)buf;
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

    [StructLayout(LayoutKind.Sequential)]
    private struct ImDrawVert
    {
        public Vector2 pos;
        public Vector2 uv;
        public uint col;
    }
}
