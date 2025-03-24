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

        // Create function detours
        _ProcessEventDetourBase = DetourUtil.NewDetour<ProcessEventDelegate>(
            GameInfo.FuncOffsets.ProcessEvent,
            ProcessEventDetour
        );
        _AddObjectDetourBase = DetourUtil.NewDetour<AddObjectDelegate>(
            GameInfo.FuncOffsets.AddObject,
            AddObjectDetour
        );
        _ObjectDtorDetourBase = DetourUtil.NewDetour<ObjectDtorDelegate>(
            GameInfo.FuncOffsets.ObjectDtor,
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

        // Basic memory access tests
        unsafe
        {
            // Get table addresses
            var GNames = new TArray<IntPtr>(MemUtil.GetIntPointer(GameInfo.GlobalOffsets.GNames));
            var GObjects = new TArray<BaseObject>(
                MemUtil.GetIntPointer(GameInfo.GlobalOffsets.GObjObjects)
            );

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

                // obj.GetPackageName(out var packageName);
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
            var classPtr = *(IntPtr*)(self + GameInfo.MemberOffsets.Object__Class).ToPointer();
            var classIndexPtr = classPtr + GameInfo.MemberOffsets.Object__ObjectInternalInteger;

            // Not clear yet why this happens, but maybe we don't need to worry about it.
            var classIndex = *(int*)classIndexPtr.ToPointer();
            if (classIndex < 1)
            {
                MarshalUtil.CreateManagedWrapper(self, typeof(Class));
                return;
            }

            // var actor = new Actor();

            // Match native classes to managed types
            var classPath = GetClassPath(self);
            var managedType = classPath switch
            {
                // "Core.Object" => typeof(BaseObject),
                "Core.Function" => typeof(Function),
                "Core.Class" => typeof(Class),
                "Core.Package" => typeof(Package),
                "Engine.Actor" => typeof(Actor),

                // TODO: AutoInitializeRegistrants()
                // TODO: CDOs exist, so we need to be able to create instances of abstract classes like Object and Actor.

                _ => typeof(BaseObject),
            };

            // Wrap this object in a managed instance
            MarshalUtil.CreateManagedWrapper(self, managedType);
        }
    }

    static unsafe string GetClassPath(IntPtr obj)
    {
        // Fetch class name.
        var classPtr = *(IntPtr*)(obj + GameInfo.MemberOffsets.Object__Class).ToPointer();
        var className = *(FName*)(classPtr + GameInfo.MemberOffsets.Object__Name).ToPointer();

        // Try to add class outer/package name to path.
        var classOuterPtr = *(IntPtr*)(classPtr + GameInfo.MemberOffsets.Object__Outer).ToPointer();
        if (classOuterPtr == 0)
        {
            return className.ToString();
        }
        else
        {
            var classOuterName = *(FName*)
                (classOuterPtr + GameInfo.MemberOffsets.Object__Name).ToPointer();

            return $"{classOuterName}.{className}";
        }
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
