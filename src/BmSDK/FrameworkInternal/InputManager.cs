namespace BmSDK.Framework;

internal static class InputManager
{
    static readonly bool[] s_keyStates = new bool[255];
    static readonly bool[] s_keyStatesPrev = new bool[255];

    public static void Tick(IEnumerable<GameMod> mods)
    {
        // Check for any new key presses.
        for (var i = 0; i < 255; i++)
        {
            if (s_keyStates[i] && !s_keyStatesPrev[i])
            {
                // Let mods know about the key press.
                foreach (var mod in mods)
                {
                    Debug.PushSender(mod.GetType().Name);
                    mod.OnKeyDown((Keys)i);
                    Debug.PopSender();
                }
            }
        }

        // Update previous key states.
        s_keyStates.CopyTo(s_keyStatesPrev, 0);
    }

    internal static void OnKeyDown(Keys key)
    {
        if (IsValidKey(key))
        {
            s_keyStates[(byte)key] = true;
        }
    }

    internal static void OnKeyUp(Keys key)
    {
        if (IsValidKey(key))
        {
            s_keyStates[(byte)key] = false;
        }
    }

    static bool IsValidKey(Keys key)
    {
        return (int)key >= 0 && (int)key <= 255;
    }
}
