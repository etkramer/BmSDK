using ImGuiNET;
using Windows.Win32;

namespace BmSDK.Framework;

internal static class ImGuiInput
{
    internal static bool ProcessMessage(nint hWnd, uint msg, nuint wParam, nint lParam)
    {
        if (!ImGuiController.IsInitialized)
        {
            return false;
        }

        ForwardToImGui(msg, wParam, lParam);

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

    private static void ForwardToImGui(uint msg, nuint wParam, nint lParam)
    {
        var io = ImGui.GetIO();

        switch (msg)
        {
            case PInvoke.WM_MOUSEMOVE:
            {
                var x = (short)(lParam & 0xFFFF);
                var y = (short)((lParam >> 16) & 0xFFFF);
                io.AddMousePosEvent(x, y);
                break;
            }
            case PInvoke.WM_LBUTTONDOWN:
                io.AddMouseButtonEvent(0, true);
                break;
            case PInvoke.WM_LBUTTONUP:
                io.AddMouseButtonEvent(0, false);
                break;
            case PInvoke.WM_RBUTTONDOWN:
                io.AddMouseButtonEvent(1, true);
                break;
            case PInvoke.WM_RBUTTONUP:
                io.AddMouseButtonEvent(1, false);
                break;
            case PInvoke.WM_MBUTTONDOWN:
                io.AddMouseButtonEvent(2, true);
                break;
            case PInvoke.WM_MBUTTONUP:
                io.AddMouseButtonEvent(2, false);
                break;
            case PInvoke.WM_MOUSEWHEEL:
            {
                var wheel = (short)(wParam >> 16) / 120.0f;
                io.AddMouseWheelEvent(0, wheel);
                break;
            }
            case PInvoke.WM_KEYDOWN:
            case PInvoke.WM_SYSKEYDOWN:
            {
                var key = VkToImGuiKey((int)wParam);
                if (key != ImGuiKey.None)
                {
                    io.AddKeyEvent(key, true);
                }

                break;
            }
            case PInvoke.WM_KEYUP:
            case PInvoke.WM_SYSKEYUP:
            {
                var key = VkToImGuiKey((int)wParam);
                if (key != ImGuiKey.None)
                {
                    io.AddKeyEvent(key, false);
                }

                break;
            }
            case PInvoke.WM_CHAR:
            {
                io.AddInputCharacter((uint)wParam);
                break;
            }
        }
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

    private static ImGuiKey VkToImGuiKey(int vk) =>
        vk switch
        {
            0x08 => ImGuiKey.Backspace,
            0x09 => ImGuiKey.Tab,
            0x0D => ImGuiKey.Enter,
            0x10 => ImGuiKey.LeftShift,
            0x11 => ImGuiKey.LeftCtrl,
            0x12 => ImGuiKey.LeftAlt,
            0x13 => ImGuiKey.Pause,
            0x14 => ImGuiKey.CapsLock,
            0x1B => ImGuiKey.Escape,
            0x20 => ImGuiKey.Space,
            0x21 => ImGuiKey.PageUp,
            0x22 => ImGuiKey.PageDown,
            0x23 => ImGuiKey.End,
            0x24 => ImGuiKey.Home,
            0x25 => ImGuiKey.LeftArrow,
            0x26 => ImGuiKey.UpArrow,
            0x27 => ImGuiKey.RightArrow,
            0x28 => ImGuiKey.DownArrow,
            0x2D => ImGuiKey.Insert,
            0x2E => ImGuiKey.Delete,
            >= 0x30 and <= 0x39 => ImGuiKey._0 + (vk - 0x30),
            >= 0x41 and <= 0x5A => ImGuiKey.A + (vk - 0x41),
            >= 0x60 and <= 0x69 => ImGuiKey.Keypad0 + (vk - 0x60),
            0x6A => ImGuiKey.KeypadMultiply,
            0x6B => ImGuiKey.KeypadAdd,
            0x6D => ImGuiKey.KeypadSubtract,
            0x6E => ImGuiKey.KeypadDecimal,
            0x6F => ImGuiKey.KeypadDivide,
            >= 0x70 and <= 0x7B => ImGuiKey.F1 + (vk - 0x70),
            0x90 => ImGuiKey.NumLock,
            0x91 => ImGuiKey.ScrollLock,
            0xA0 => ImGuiKey.LeftShift,
            0xA1 => ImGuiKey.RightShift,
            0xA2 => ImGuiKey.LeftCtrl,
            0xA3 => ImGuiKey.RightCtrl,
            0xA4 => ImGuiKey.LeftAlt,
            0xA5 => ImGuiKey.RightAlt,
            0xBA => ImGuiKey.Semicolon,
            0xBB => ImGuiKey.Equal,
            0xBC => ImGuiKey.Comma,
            0xBD => ImGuiKey.Minus,
            0xBE => ImGuiKey.Period,
            0xBF => ImGuiKey.Slash,
            0xC0 => ImGuiKey.GraveAccent,
            0xDB => ImGuiKey.LeftBracket,
            0xDC => ImGuiKey.Backslash,
            0xDD => ImGuiKey.RightBracket,
            0xDE => ImGuiKey.Apostrophe,
            _ => ImGuiKey.None,
        };
}
