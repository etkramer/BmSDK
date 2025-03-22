using System.Runtime.InteropServices;
using System;
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

    public override unsafe readonly string ToString()
    {
        var GNames = (FNameEntry***)MemUtil.GetPointer<byte>(0x2231BB4);
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