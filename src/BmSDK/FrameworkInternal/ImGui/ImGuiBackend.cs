namespace BmSDK.Framework;

internal static class ImGuiBackend
{
    public static void Init()
    {
        DX9Backend.TryInstall();
        DX11Backend.TryInstall();
    }

    public static bool WndProc(nint hWnd, uint msg, nuint wParam, nint lParam)
    {
        return ImGuiInput.ProcessMessage(hWnd, msg, wParam, lParam);
    }
}
