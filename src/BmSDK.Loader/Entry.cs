using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using BmSDK.Framework;

namespace BmSDK.Loader;

static class Entry
{
    delegate void DllMainDelegate();

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ProcessEventDelegate(IntPtr self, IntPtr Function, IntPtr Parms, IntPtr UnusedResult);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void AddObjectDelegate(IntPtr self, int InIndex);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ObjectDtorDelegate(IntPtr self);

    static ProcessEventDelegate? _ProcessEventDetourBase = null;
    static AddObjectDelegate? _AddObjectDetourBase = null;
    static ObjectDtorDelegate? _ObjectDtorDetourBase = null;

    static readonly List<(Assembly, IManagedPlugin)> _plugins = new();

    public static void DllMain()
    {
        Debug.WriteLine($"Hello from BmSDK.Loader");

        // Create function detours
        _ProcessEventDetourBase = DetourUtil.NewDetour<ProcessEventDelegate>(GameInfo.FuncOffsets.ProcessEvent, ProcessEventDetour);
        _AddObjectDetourBase = DetourUtil.NewDetour<AddObjectDelegate>(GameInfo.FuncOffsets.AddObject, AddObjectDetour);
        _ObjectDtorDetourBase = DetourUtil.NewDetour<ObjectDtorDelegate>(GameInfo.FuncOffsets.ObjectDtor, ObjectDtorDetour);

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
            var selfObj = MarshalUtil.MarshalToManaged<BaseObject>(&self);
            var funcObj = MarshalUtil.MarshalToManaged<BaseObject>(&Function);
            Debug.WriteLine($"\nProcessEvent: {funcObj.Name} on {selfObj.Name}");
        }

        // Basic memory access tests
        unsafe
        {
            // Get table addresses
            var GNames = new TArray<IntPtr>(MemUtil.GetIntPointer(GameInfo.GlobalOffsets.GNames));
            var GObjects = new TArray<BaseObject>(MemUtil.GetIntPointer(GameInfo.GlobalOffsets.GObjObjects));

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

    // Detour for UObject::AddObject()
    public static void AddObjectDetour(IntPtr self, int InIndex)
    {
        // Call base impl
        _AddObjectDetourBase!.Invoke(self, InIndex);

        // Wrap this object in a managed instance
        // TODO: We want to check UObject.Class to get the actual matching type.
        var managedType = typeof(Class);
        MarshalUtil.CreateManagedWrapper(self, managedType);
    }

    // Detour for UObject::~UObject()
    public static void ObjectDtorDetour(IntPtr self)
    {
        // Call base impl
        _ObjectDtorDetourBase!.Invoke(self);

        // Wrap this object in a managed instance
        // TODO: We want to check UObject.Class to get the actual matching type.
        MarshalUtil.DestroyManagedWrapper(self);
    }
}
