using BmSDK.Framework;

namespace BmSDK;

public struct FName
{
    public static readonly FName None = new(0);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    delegate void InitDelegate(
        IntPtr self,
        IntPtr InName,
        int InNumber,
        int FindType,
        int bSplitName
    );

    static InitDelegate? _Init = null;

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
        // Create delegate on first use
        _Init ??= Marshal.GetDelegateForFunctionPointer<InitDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.NameInit)
        );

        // Get TCHAR* from string
        fixed (char* namePtr = Name)
        fixed (FName* thisPtr = &this)
        {
            // Call native func
            _Init((IntPtr)thisPtr, (IntPtr)namePtr, 0, 1, 0);
        }
    }

    public override readonly unsafe string ToString()
    {
        var GNames = (FNameEntry***)MemUtil.GetPointer<byte>(GameInfo.GlobalOffsets.GNames);
        var GNamesData = *GNames;
        return Guard.NotNull(Marshal.PtrToStringAnsi((IntPtr)GNamesData[Index]->AnsiName));
    }

    unsafe struct FNameEntry
    {
        public EObjectFlags Flags;
        public int Index;
        public FNameEntry* HashNext;
        public fixed byte AnsiName[128];
    }
}
