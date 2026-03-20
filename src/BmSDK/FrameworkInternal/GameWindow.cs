using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.UI.WindowsAndMessaging;

namespace BmSDK.Framework;

internal static class GameWindow
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "FindWindowW")]
    private static extern HWND FindWindow(string? lpClassName, string? lpWindowName);

    private static HWND s_gameHwnd = default;
    private static WNDPROC? s_wndProc;
    private static WNDPROC? s_wndProcBase;

    private static LRESULT CustomWndProc(HWND hWnd, uint msg, WPARAM wParam, LPARAM lParam)
    {
        switch (msg)
        {
            case PInvoke.WM_KEYUP:
                InputManager.OnKeyUp((Keys)wParam.Value);
                break;
            case PInvoke.WM_KEYDOWN:
                InputManager.OnKeyDown((Keys)wParam.Value);
                break;
        }

        return PInvoke.CallWindowProc(s_wndProcBase, hWnd, msg, wParam, lParam);
    }

    internal static void Tick()
    {
        // Do we know which window is ours?
        if (s_gameHwnd == default)
        {
            // If not, keep trying to find it.
            if (TryFindGameWindow(out s_gameHwnd))
            {
                // Subclass the window procedure
                s_wndProc = CustomWndProc;
                var originalWndProc = PInvoke.SetWindowLong(
                    s_gameHwnd,
                    WINDOW_LONG_PTR_INDEX.GWL_WNDPROC,
                    (int)Marshal.GetFunctionPointerForDelegate(s_wndProc)
                );

                s_wndProcBase = Marshal.GetDelegateForFunctionPointer<WNDPROC>(originalWndProc);
            }
        }
    }

    private static bool TryFindGameWindow(out HWND result)
    {
        result = FindWindow("LaunchUnrealUWindowsClient", null);
        return result != default;
    }
}
