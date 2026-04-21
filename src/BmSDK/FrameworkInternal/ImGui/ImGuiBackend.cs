using Hexa.NET.ImGui;
using Hexa.NET.ImGui.Backends.Win32;
using Windows.Win32;

namespace BmSDK.Framework;

internal static class ImGuiBackend
{
    public static void Init()
    {
        DX9Backend.TryInstall();
        DX11Backend.TryInstall();
    }

    public static unsafe bool WndProc(nint hWnd, uint msg, nuint wParam, nint lParam)
    {
        if (!ImGuiController.IsInitialized)
        {
            return false;
        }

        ImGuiImplWin32.WndProcHandler(hWnd, msg, wParam, lParam);

        var io = ImGui.GetIO();
        if (io.WantCaptureMouse && IsMouseMessage(msg))
        {
            return true;
        }

        if (io.WantCaptureKeyboard && IsKeyMessage(msg))
        {
            return true;
        }

        return false;
    }

    private static bool IsMouseMessage(uint msg) =>
        msg
            is PInvoke.WM_MOUSEMOVE
                or PInvoke.WM_LBUTTONDOWN
                or PInvoke.WM_LBUTTONUP
                or PInvoke.WM_RBUTTONDOWN
                or PInvoke.WM_RBUTTONUP
                or PInvoke.WM_MBUTTONDOWN
                or PInvoke.WM_MBUTTONUP
                or PInvoke.WM_MOUSEWHEEL;

    private static bool IsKeyMessage(uint msg) =>
        msg
            is PInvoke.WM_KEYDOWN
                or PInvoke.WM_KEYUP
                or PInvoke.WM_CHAR
                or PInvoke.WM_SYSKEYDOWN
                or PInvoke.WM_SYSKEYUP;
}
