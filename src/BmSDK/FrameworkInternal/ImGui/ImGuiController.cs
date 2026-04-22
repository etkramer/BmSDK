using System.Numerics;
using Hexa.NET.ImGui;
using Hexa.NET.ImGuizmo;

namespace BmSDK.Framework;

internal static class ImGuiController
{
    private static ImGuiContextPtr s_context;
    internal static readonly object RenderLock = new();

    public static bool IsInitialized { get; private set; }
    public static nint Hwnd;
    public static Action? OnGUI;

    public static unsafe bool TryInitialize()
    {
        if (IsInitialized)
        {
            return false;
        }

        // Preload cimgui.dll
        var sdkPath = Path.Combine(FileUtils.GetBinariesPath(), "sdk");
        var runtimesPath = Path.Combine(sdkPath, "runtimes", "win-x86", "native");
        NativeLibrary.Load(Path.Combine(runtimesPath, "cimgui.dll"));
        NativeLibrary.Load(Path.Combine(runtimesPath, "cimguizmo.dll"));
        NativeLibrary.Load(Path.Combine(runtimesPath, "ImGuiImpl.dll"));

        // Create context
        s_context = ImGui.CreateContext();
        ImGui.SetCurrentContext(s_context);
        ImGuizmo.SetImGuiContext(s_context);

        {
            // Setup ImGuizmo style
            var gizmoStyle = ImGuizmo.GetStyle();
            gizmoStyle.Colors[(int)ImGuizmoColor.DirectionX] = new Vector4(1.0f, 0.2f, 0.32f, 1);
            gizmoStyle.Colors[(int)ImGuizmoColor.DirectionY] = new Vector4(0.55f, 0.86f, 0, 1);
            gizmoStyle.Colors[(int)ImGuizmoColor.DirectionZ] = new Vector4(0.16f, 0.57f, 1, 1);

            gizmoStyle.Colors[(int)ImGuizmoColor.PlaneX] = gizmoStyle.Colors[(int)ImGuizmoColor.DirectionX];
            gizmoStyle.Colors[(int)ImGuizmoColor.PlaneX].W = 0.5f;
            gizmoStyle.Colors[(int)ImGuizmoColor.PlaneY] = gizmoStyle.Colors[(int)ImGuizmoColor.DirectionY];
            gizmoStyle.Colors[(int)ImGuizmoColor.PlaneY].W = 0.5f;
            gizmoStyle.Colors[(int)ImGuizmoColor.PlaneZ] = gizmoStyle.Colors[(int)ImGuizmoColor.DirectionZ];
            gizmoStyle.Colors[(int)ImGuizmoColor.PlaneZ].W = 0.5f;

            ImGuizmo.AllowAxisFlip(false);
            ImGuizmo.SetAxisLimit(0);
        }

        var io = ImGui.GetIO();
        var style = ImGui.GetStyle();

        // Disable background transparency
        style.Colors[(int)ImGuiCol.WindowBg].W = 1;
        style.Colors[(int)ImGuiCol.TitleBg].W = 1;
        style.Colors[(int)ImGuiCol.TitleBgCollapsed] = style.Colors[(int)ImGuiCol.TitleBg];
        style.Colors[(int)ImGuiCol.TitleBg] = style.Colors[(int)ImGuiCol.TitleBgActive];

        // Load fonts
        var fontScale = 1.5f;
        var fontConfig = ImGui.ImFontConfig();
        fontConfig.OversampleH = 3;
        fontConfig.OversampleV = 3;

        io.Fonts.Handle->AddFontFromFileTTF(
            "C:\\Windows\\Fonts\\consola.ttf",
            14f * fontScale,
            fontConfig
        );
        style.ScaleAllSizes(fontScale);

        fontConfig.Destroy();

        IsInitialized = true;
        return true;
    }

    public static void Tick()
    {
        if (!IsInitialized || Hwnd == 0)
        {
            return;
        }

        var gameViewportClient = Game.GetGameViewportClient();
        gameViewportClient.GetViewportSize(out var viewportSize);

        if (viewportSize.X <= 0 || viewportSize.Y <= 0)
        {
            return;
        }

        var io = ImGui.GetIO();
        io.DisplaySize = viewportSize;
        io.DeltaTime = MathF.Max(Game.GetDeltaTime(), 0.001f);

        lock (RenderLock)
        {
            ImGui.NewFrame();

            ImGuizmo.BeginFrame();
            ImGuizmo.SetOrthographic(false);
            ImGuizmo.SetDrawlist(ImGui.GetBackgroundDrawList());
            ImGuizmo.SetRect(0, 0, io.DisplaySize.X, io.DisplaySize.Y);

            try
            {
                OnGUI?.Invoke();
            }
            catch (Exception ex)
            {
                Debug.LogError(ex.ToString());
            }

            ImGui.EndFrame();
            ImGui.Render();
        }
    }
}
