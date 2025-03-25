using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using BmSDK.Engine;
using BmSDK.Framework;

namespace BmSDK.Loader;

static class Entry
{
    delegate void DllMainDelegate();

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ProcessEventDelegate(
        IntPtr self,
        IntPtr Function,
        IntPtr Parms,
        IntPtr UnusedResult
    );

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

        // Perform static init (before engine load)
        StaticInit.StaticInitClasses();

        // Create function detours
        _ProcessEventDetourBase = DetourUtil.NewDetour<ProcessEventDelegate>(
            GameOffsets.FuncOffsets.ProcessEvent,
            ProcessEventDetour
        );
        _AddObjectDetourBase = DetourUtil.NewDetour<AddObjectDelegate>(
            GameOffsets.FuncOffsets.AddObject,
            AddObjectDetour
        );
        _ObjectDtorDetourBase = DetourUtil.NewDetour<ObjectDtorDelegate>(
            GameOffsets.FuncOffsets.ObjectDtor,
            ObjectDtorDetour
        );

        // End with a newline
        Debug.Write("\n");
    }

    static bool IsFirstTick = true;

    // Detour for UObject::ProcessEvent()
    public static void ProcessEventDetour(
        IntPtr self,
        IntPtr Function,
        IntPtr Parms,
        IntPtr UnusedResult
    )
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

        // Test StaticClass(), StaticFindObject()
        Debug.WriteLine($"Class::StaticClass(): {Class.StaticClass()}");
        Debug.WriteLine($"Actor::StaticClass(): {Actor.StaticClass()}");

        // Test ConstructObject()
        var newObj = new MacroReachSpec(null, "SomeMacroReachSpec");
        Debug.WriteLine($"New object: {newObj}");

        // Basic memory access tests
        unsafe
        {
            // Get table addresses
            var GNames = new TArray<IntPtr>(MemUtil.GetIntPointer(GameOffsets.GlobalFields.GNames));
            var GObjects = new TArray<BaseObject>(
                MemUtil.GetIntPointer(GameOffsets.GlobalFields.GObjObjects)
            );

            // Test memory access
            Debug.Write("\n");
            Debug.WriteLine($"GNames: Num {GNames.Num}, Max {GNames.Max}");
            Debug.WriteLine($"GObjects: Num {GObjects.Num}, Max {GObjects.Max}");

            // Test object access
            foreach (var obj in GObjects.OfType<Actor>().Take(10))
            {
                Debug.Write("\n");
                Debug.WriteLine($"Name: {obj.Name}");
                Debug.WriteLine($"Class: {obj.Class.Name} ({obj.GetType().Name})");
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

        unsafe
        {
            var classPtr = *(IntPtr*)(self + GameOffsets.ObjectMembers.Object__Class).ToPointer();
            var classIndexPtr = classPtr + GameOffsets.ObjectMembers.Object__ObjectInternalInteger;

            // Not clear yet why this happens, but maybe we don't need to worry about it.
            var classIndex = *(int*)classIndexPtr.ToPointer();
            if (classIndex < 1)
            {
                MarshalUtil.CreateManagedWrapper(self, typeof(Class));
                return;
            }

            // Match native classes to managed types
            var classPath = GetClassPath(self);

            // Wrap this object in a managed instance
            var managedType = StaticInit.GetManagedTypeForClassPath(classPath);
            MarshalUtil.CreateManagedWrapper(self, managedType);
        }
    }

    static unsafe string GetClassPath(IntPtr obj)
    {
        // Fetch class name.
        var classPtr = *(IntPtr*)(obj + GameOffsets.ObjectMembers.Object__Class).ToPointer();
        var className = *(FName*)(classPtr + GameOffsets.ObjectMembers.Object__Name).ToPointer();

        // Fetch outer name.
        var classOuterPtr = *(IntPtr*)
            (classPtr + GameOffsets.ObjectMembers.Object__Outer).ToPointer();
        var classOuterName = *(FName*)
            (classOuterPtr + GameOffsets.ObjectMembers.Object__Name).ToPointer();

        return $"{classOuterName}.{className}";
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
