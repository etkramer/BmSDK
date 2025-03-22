using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BmSDK;
using BmSDK.Engine;
using BmSDK.Framework;

namespace BmSDK.Loader;

static class Entry
{
    delegate void DllMainDelegate();

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ProcessEventDelegate(IntPtr self, IntPtr Function, IntPtr Parms, IntPtr UnusedResult);

    static ProcessEventDelegate? _ProcessEventDetourBase = null;

    public static void DllMain()
    {
        Debug.WriteLine($"Hello from BmSDK.Loader");

        // Create function detours
        _ProcessEventDetourBase = DetourUtil.NewDetour<ProcessEventDelegate>(0x1A7040, ProcessEventDetour);

        // End with a newline
        Debug.Write("\n");
    }

    static bool IsFirstTick = true;

    // Detour for UObject::ProcessEvent()
    public static void ProcessEventDetour(IntPtr self, IntPtr Function, IntPtr Parms, IntPtr UnusedResult)
    {
        // Call base impl
        _ProcessEventDetourBase!.Invoke(self, Function, Parms, UnusedResult);

        if (!IsFirstTick)
        {
            return;
        }
        else
        {
            IsFirstTick = false;
        }

        // Basic memory access tests
        unsafe
        {
            // Get table addresses
            var GNames = new TArray<IntPtr>(MemUtil.GetIntPointer(0x2231BB4));
            var GObjects = new TArray<IntPtr>(MemUtil.GetIntPointer(0x2231BE4));

            // Test memory access
            Debug.Write("\n");
            Debug.WriteLine($"GNames: Num {GNames.Num}, Max {GNames.Max}");
            Debug.WriteLine($"GObjects: Num {GObjects.Num}, Max {GObjects.Max}");

            // Test UObject access
            for (var i = 0; i < 10; i++)
            {
                var obj = new TestObject(((IntPtr*)GObjects.DataPtr)[i]);

                try
                {
                    Debug.Write("\n");
                    Debug.WriteLine($"Name: {obj.Name2}");
                    Debug.WriteLine($"ObjectInternalInteger: {obj.ObjectInternalInteger}");
                    Debug.WriteLine($"ObjectFlags: {obj.ObjectFlags}");
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.GetType().Name);
                }
            }
        }
    }
}

unsafe class TestObject : UObject
{
    // Wrap props with more accurate types
    public string Name2 => this.GetPropertyValue<FName>(32).ToString();

    public TestObject(IntPtr ptr)
    {
        this.Ptr = ptr;
    }
}

struct FName
{
    public int Index;
    public int Number;

    public override unsafe readonly string ToString()
    {
        var GNames = (FNameEntry***)MemUtil.GetPointer<byte>(0x2231BB4);
        var GNamesData = *GNames;
        return Guard.NotNull(Marshal.PtrToStringAnsi((IntPtr)GNamesData[Index]->AnsiName));
    }
}

unsafe struct FNameEntry
{
    public EObjectFlags Flags;
    public int Index;
    public FNameEntry* HashNext;
    public fixed byte AnsiName[128];
}