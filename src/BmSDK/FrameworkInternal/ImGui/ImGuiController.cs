using ImGuiNET;
using Windows.Win32;

namespace BmSDK.Framework;

internal static class ImGuiController
{
    private static nint s_context;
    internal static readonly object RenderLock = new();

    public static bool IsInitialized { get; private set; }
    public static nint Hwnd;
    public static Action? OnGUI;

    public static bool TryInitialize()
    {
        if (IsInitialized)
        {
            return false;
        }

        // Create context
        s_context = ImGui.CreateContext();
        ImGui.SetCurrentContext(s_context);

        var io = ImGui.GetIO();
        var style = ImGui.GetStyle();

        // Disable background transparency
        style.Colors[(int)ImGuiCol.WindowBg].W = 1;

        // Load fonts
        var fontScale = 1.5f;
        unsafe
        {
            var fontConfig = ImGuiNative.ImFontConfig_ImFontConfig();
            fontConfig->OversampleH = 3;
            fontConfig->OversampleV = 3;

            // Load built-in Windows font
            io.Fonts.AddFontFromFileTTF(
                "C:\\Windows\\Fonts\\consola.ttf",
                14f * fontScale,
                fontConfig
            );
            style.ScaleAllSizes(fontScale);

            ImGuiNative.ImFontConfig_destroy(fontConfig);
        }

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
        io.DeltaTime = Game.GetDeltaTime();

        lock (RenderLock)
        {
            ImGui.NewFrame();
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
