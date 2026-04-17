using System.Diagnostics;
using System.Numerics;
using ImGuiNET;

namespace BmSDK.DevMode;

internal static class ImGuiController
{
    private static bool s_initialized;
    private static nint s_context;
    private static readonly Stopwatch s_stopwatch = Stopwatch.StartNew();

    internal static bool IsInitialized => s_initialized;

    internal static bool TryInitialize()
    {
        if (s_initialized)
        {
            return false;
        }

        s_context = ImGui.CreateContext();
        ImGui.SetCurrentContext(s_context);

        var io = ImGui.GetIO();
        io.ConfigFlags |= ImGuiConfigFlags.NavEnableKeyboard;

        s_initialized = true;
        return true;
    }

    internal static void NewFrame(int width, int height)
    {
        ImGui.SetCurrentContext(s_context);

        var io = ImGui.GetIO();
        io.DisplaySize = new Vector2(width, height);
        var elapsed = (float)s_stopwatch.Elapsed.TotalSeconds;
        s_stopwatch.Restart();
        io.DeltaTime = elapsed > 0 ? elapsed : 1.0f / 60.0f;

        ImGui.NewFrame();

        if (DevMode.IsVisible)
        {
            ImGui.ShowDemoWindow();
        }

        ImGui.EndFrame();
        ImGui.Render();
    }
}
