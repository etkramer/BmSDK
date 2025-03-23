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
        _ProcessEventDetourBase = DetourUtil.NewDetour<ProcessEventDelegate>(GameInfo.FuncOffsets.ProcessEvent, ProcessEventDetour);

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

        unsafe
        {
            var selfObj = MarshalUtil.MarshalToManaged<Class>(&self);
            var funcObj = MarshalUtil.MarshalToManaged<Function>(&Function);
            Debug.WriteLine($"\nProcessEvent: {funcObj.Name} on {selfObj.Name}");
        }

        // Basic memory access tests
        unsafe
        {
            // Get table addresses
            var GNames = new TArray<IntPtr>(MemUtil.GetIntPointer(GameInfo.GlobalOffsets.GNames));
            var GObjects = new TArray<Class>(MemUtil.GetIntPointer(GameInfo.GlobalOffsets.GObjObjects));

            // Test memory access
            Debug.Write("\n");
            Debug.WriteLine($"GNames: Num {GNames.Num}, Max {GNames.Max}");
            Debug.WriteLine($"GObjects: Num {GObjects.Num}, Max {GObjects.Max}");

            // Test object access
            foreach (var obj in GObjects.Take(10))
            {
                Debug.Write("\n");
                Debug.WriteLine($"Name: {obj.Name}");
                Debug.WriteLine($"Class: {obj.Class.Name}");
                Debug.WriteLine($"ObjectInternalInteger: {obj.ObjectInternalInteger}");
                Debug.WriteLine($"ObjectFlags: {obj.ObjectFlags}");
            }
        }
    }
}
