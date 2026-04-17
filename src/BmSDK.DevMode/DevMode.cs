namespace BmSDK.DevMode;

public static class DevMode
{
    internal static bool IsVisible { get; private set; }

    public static void Init()
    {
        DX9Backend.TryInstall();
        DX11Backend.TryInstall();
    }

    public static bool WndProc(nint hWnd, uint msg, nuint wParam, nint lParam)
    {
        return ImGuiInput.ProcessMessage(hWnd, msg, wParam, lParam);
    }

    internal static void Toggle()
    {
        IsVisible = !IsVisible;
    }
}
