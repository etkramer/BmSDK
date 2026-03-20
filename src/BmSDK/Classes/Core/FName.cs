using BmSDK.Framework;

namespace BmSDK;

public struct FName
{
    public static readonly FName None = new(0);

    public int Index;
    public int Number;

    /// <summary>
    /// Creates a new FName with the given index.
    /// </summary>
    public unsafe FName(int index)
    {
        Index = index;
        Number = 0;
    }

    /// <summary>
    /// Creates a new FName for the given string, reusing existing names where possible.
    /// </summary>
    public unsafe FName(string? name)
    {
        if (name is null)
        {
            Index = None.Index;
            Number = None.Number;
            return;
        }

        // Get TCHAR* from string
        fixed (char* namePtr = name)
        fixed (FName* thisPtr = &this)
        {
            // Call native func
            GameFunctions.NameInit((IntPtr)thisPtr, (IntPtr)namePtr, 0, 1, 0);
        }
    }

    public static implicit operator FName(string? str) => new(str);

    public static implicit operator string(FName name) => name.ToString();

    public override unsafe string ToString()
    {
        var GNames = (FNameEntry***)MemUtil.GetPointer<byte>(GameInfo.GlobalOffsets.GNames);
        var GNamesData = *GNames;

        var nameEntry = GNamesData[Index];

        // Mirrored in FName.h

        // Sometimes this struct stores a pointer to a string, instead of having it inline.
        // It's not clear how to check this properly yet, so we implement a heuristic
        // to try and detect pointers.

        // Short inline names (e.g. "HUD\0") can look like valid pointers when
        // read as 8 bytes. Check for valid name chars followed by a null first.
        var shortInline = false;
        for (var i = 0; i < 8; i++)
        {
            var c = Convert.ToChar(nameEntry->AnsiName[i]);
            if (c == '\0')
            {
                shortInline = i > 0;
                break;
            }

            if (!char.IsAsciiLetterOrDigit(c) && c != '_')
            {
                break;
            }
        }

        if (!shortInline)
        {
            if ((nameEntry->AnsiNamePtr > 0x10000) && ((nameEntry->AnsiNamePtr >> 48) == 0))
            {
                return Guard.NotNull(Marshal.PtrToStringAnsi(nameEntry->AnsiNamePtr));
            }
        }

        return Guard.NotNull(Marshal.PtrToStringAnsi((IntPtr)nameEntry->AnsiName));
    }

#pragma warning disable CS0649
    [StructLayout(LayoutKind.Explicit)]
    private unsafe struct FNameEntry
    {
        [FieldOffset(0)]
        public int Index;

        [FieldOffset(4)]
        public int HashNext;

        [FieldOffset(8)]
        public short NameLen;

        [FieldOffset(10)]
        public short Pad;

        [FieldOffset(12)]
        public fixed byte AnsiName[128];

        [FieldOffset(12)]
        public IntPtr AnsiNamePtr;
    }
#pragma warning restore CS0649
}
