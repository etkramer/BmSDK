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
    public FName(int index)
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

        // BM4: Names are sometimes stored as pointers instead of inline text.
        string? str = null;
        if ((nameEntry->Index & 0x2) != 0)
        {
            str = Guard.NotNull(Marshal.PtrToStringAnsi(nameEntry->AnsiNamePtr));
        }
        else
        {
            str = Guard.NotNull(Marshal.PtrToStringAnsi((IntPtr)nameEntry->AnsiName));
        }

        return Number == 0 ? str : $"{str}_{Number - 1}";
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
