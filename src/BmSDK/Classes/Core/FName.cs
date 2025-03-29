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
    public unsafe FName(int Index)
    {
        this.Index = Index;
        Number = 0;
    }

    /// <summary>
    /// Creates a new FName for the given string, reusing existing names where possible.
    /// </summary>
    public unsafe FName(string Name)
    {
        // Get TCHAR* from string
        fixed (char* namePtr = Name)
        fixed (FName* thisPtr = &this)
        {
            // Call native func
            GameFunctions.NameInit((IntPtr)thisPtr, (IntPtr)namePtr, 0, 1, 0);
        }
    }

    public static implicit operator FName(string name) => new(name);

    public override unsafe string ToString()
    {
        var GNames = (FNameEntry***)MemUtil.GetPointer<byte>(GameInfo.GlobalOffsets.GNames);
        var GNamesData = *GNames;
        return Guard.NotNull(Marshal.PtrToStringAnsi((IntPtr)GNamesData[Index]->AnsiName));
    }

#pragma warning disable CS0649
    unsafe struct FNameEntry
    {
        public EObjectFlags Flags;
        public int Index;
        public FNameEntry* HashNext;
        public fixed byte AnsiName[128];
    }
#pragma warning restore CS0649
}
