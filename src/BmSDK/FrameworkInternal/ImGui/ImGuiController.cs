using System.Numerics;
using ImGuiNET;
using Windows.Win32;
using Windows.Win32.Foundation;

namespace BmSDK.Framework;

internal static class ImGuiController
{
    private static nint s_context;
    internal static readonly object RenderLock = new();

    public static bool IsInitialized { get; private set; }
    public static nint Hwnd;
    public static Action? OnGUI;

    internal static void SetContext()
    {
        ImGui.SetCurrentContext(s_context);
    }

    public static bool TryInitialize()
    {
        if (IsInitialized)
        {
            return false;
        }

        s_context = ImGui.CreateContext();
        ImGui.SetCurrentContext(s_context);

        var io = ImGui.GetIO();
        io.Fonts.AddFontFromFileTTF("C:\\Fonts\\segui.ttf", 24f);
        io.ConfigFlags |= ImGuiConfigFlags.DpiEnableScaleFonts;
        io.ConfigFlags |= ImGuiConfigFlags.DpiEnableScaleViewports;

        IsInitialized = true;
        return true;
    }

    public static void Tick()
    {
        if (!IsInitialized || Hwnd == 0)
        {
            return;
        }

        PInvoke.GetClientRect(new HWND(Hwnd), out var clientRect);
        var width = clientRect.right - clientRect.left;
        var height = clientRect.bottom - clientRect.top;
        if (width <= 0 || height <= 0)
        {
            return;
        }

        ImGui.SetCurrentContext(s_context);

        var io = ImGui.GetIO();
        io.DisplaySize = new Vector2(width, height);
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
