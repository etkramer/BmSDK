using System.Numerics;
using ImGuiNET;

namespace BmSDK.DevMode;

internal static class ImGuiInput
{
    private const uint WM_MOUSEMOVE = 0x0200;
    private const uint WM_LBUTTONDOWN = 0x0201;
    private const uint WM_LBUTTONUP = 0x0202;
    private const uint WM_RBUTTONDOWN = 0x0204;
    private const uint WM_RBUTTONUP = 0x0205;
    private const uint WM_MBUTTONDOWN = 0x0207;
    private const uint WM_MBUTTONUP = 0x0208;
    private const uint WM_MOUSEWHEEL = 0x020A;
    private const uint WM_KEYDOWN = 0x0100;
    private const uint WM_KEYUP = 0x0101;
    private const uint WM_CHAR = 0x0102;
    private const uint WM_SYSKEYDOWN = 0x0104;
    private const uint WM_SYSKEYUP = 0x0105;
    private const int VK_HOME = 0x24;

    internal static bool ProcessMessage(nint hWnd, uint msg, nuint wParam, nint lParam)
    {
        if (msg == WM_KEYDOWN && (int)wParam == VK_HOME)
        {
            DevMode.Toggle();
        }

        if (!DevMode.IsVisible || !ImGuiController.IsInitialized)
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
            case WM_MOUSEMOVE:
            {
                float x = (short)(lParam & 0xFFFF);
                float y = (short)((lParam >> 16) & 0xFFFF);
                io.AddMousePosEvent(x, y);
                break;
            }
            case WM_LBUTTONDOWN:
                io.AddMouseButtonEvent(0, true);
                break;
            case WM_LBUTTONUP:
                io.AddMouseButtonEvent(0, false);
                break;
            case WM_RBUTTONDOWN:
                io.AddMouseButtonEvent(1, true);
                break;
            case WM_RBUTTONUP:
                io.AddMouseButtonEvent(1, false);
                break;
            case WM_MBUTTONDOWN:
                io.AddMouseButtonEvent(2, true);
                break;
            case WM_MBUTTONUP:
                io.AddMouseButtonEvent(2, false);
                break;
            case WM_MOUSEWHEEL:
            {
                var wheel = (short)((nuint)wParam >> 16) / 120.0f;
                io.AddMouseWheelEvent(0, wheel);
                break;
            }
            case WM_KEYDOWN:
            case WM_SYSKEYDOWN:
            {
                var key = VkToImGuiKey((int)wParam);
                if (key != ImGuiKey.None)
                {
                    io.AddKeyEvent(key, true);
                }
                break;
            }
            case WM_KEYUP:
            case WM_SYSKEYUP:
            {
                var key = VkToImGuiKey((int)wParam);
                if (key != ImGuiKey.None)
                {
                    io.AddKeyEvent(key, false);
                }
                break;
            }
            case WM_CHAR:
            {
                io.AddInputCharacter((uint)wParam);
                break;
            }
        }
    }

    private static bool IsMouseMessage(uint msg) =>
        msg is WM_MOUSEMOVE or WM_LBUTTONDOWN or WM_LBUTTONUP
            or WM_RBUTTONDOWN or WM_RBUTTONUP
            or WM_MBUTTONDOWN or WM_MBUTTONUP or WM_MOUSEWHEEL;

    private static bool IsKeyMessage(uint msg) =>
        msg is WM_KEYDOWN or WM_KEYUP or WM_CHAR or WM_SYSKEYDOWN or WM_SYSKEYUP;

    private static ImGuiKey VkToImGuiKey(int vk) => vk switch
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
