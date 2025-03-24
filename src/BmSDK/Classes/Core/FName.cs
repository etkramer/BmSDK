using BmSDK.Framework;

namespace BmSDK;

// Disable CS0649
#pragma warning disable CS0649

public struct FName
{
    public int Index;
    public int Number;

    public FName(string str)
    {
        // TODO
        throw new NotImplementedException();
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
