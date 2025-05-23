using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.UI.WindowsAndMessaging;

namespace BmSDK.Framework;

public static class GameWindow
{
    static HWND gameHwnd = default;
    static WNDPROC? s_wndProc;
    static WNDPROC? s_wndProcBase;

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
        if (gameHwnd == default)
        {
            // If not, keep trying to find it.
            if (TryFindGameWindow(out gameHwnd))
            {
                // Just found it!
                Debug.Log($"Found game window: {gameHwnd}");

                // Subclass the window procedure
                s_wndProc = CustomWndProc;
                var originalWndProc = PInvoke.SetWindowLong(
                    gameHwnd,
                    WINDOW_LONG_PTR_INDEX.GWL_WNDPROC,
                    (int)Marshal.GetFunctionPointerForDelegate(s_wndProc)
                );

                s_wndProcBase = Marshal.GetDelegateForFunctionPointer<WNDPROC>(originalWndProc);
            }
        }
    }

    private static bool TryFindGameWindow(out HWND result)
    {
        var foundHwnd = default(HWND);
        var processId = Environment.ProcessId;

        // Enumerate all windows in existence until one belongs to us.
        PInvoke.EnumWindows(
            (hwnd, lParam) =>
            {
                uint winProcId = 0;
                unsafe
                {
                    _ = PInvoke.GetWindowThreadProcessId(hwnd, &winProcId);
                }

                if (winProcId == processId && PInvoke.IsWindowVisible(hwnd))
                {
                    foundHwnd = hwnd;
                    return false;
                }

                return true;
            },
            0
        );

        // Just found it!
        if (foundHwnd != default)
        {
            result = foundHwnd;
            return true;
        }
        else
        {
            result = default;
            return false;
        }
    }
}
