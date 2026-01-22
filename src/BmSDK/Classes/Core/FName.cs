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

#if BATMAN2
        return Guard.NotNull(Marshal.PtrToStringUni((IntPtr)GNamesData[Index]->UniName));
#elif BATMAN3
        return Guard.NotNull(Marshal.PtrToStringAnsi((IntPtr)GNamesData[Index]->UniName));
#endif
    }

#pragma warning disable CS0649
    unsafe struct FNameEntry
    {
#if BATMAN2
        public ulong Flags;
#elif BATMAN3
        public int Flags;
#endif
        public int Index;
        public FNameEntry* HashNext;
        public fixed char UniName[128];
    }
#pragma warning restore CS0649
}
