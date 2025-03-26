using System.Diagnostics;
using BmSDK.BmScript;
using BmSDK.Engine;
using BmSDK.Framework;

namespace BmSDK.Loader;

static class Entry
{
    delegate void DllMainDelegate();

    static GameFunctions.ProcessEventDelegate? _ProcessEventDetourBase = null;
    static GameFunctions.AddObjectDelegate? _AddObjectDetourBase = null;
    static GameFunctions.ObjectDtorDelegate? _ObjectDtorDetourBase = null;

    public static void DllMain()
    {
        Debug.WriteLine($"Hello from BmSDK.Loader");

        // Perform static init (before engine load)
        StaticInit.StaticInitClasses();

        // Create function detours
        _ProcessEventDetourBase = DetourUtil.NewDetour<GameFunctions.ProcessEventDelegate>(
            GameInfo.FuncOffsets.ProcessEvent,
            ProcessEventDetour
        );
        _AddObjectDetourBase = DetourUtil.NewDetour<GameFunctions.AddObjectDelegate>(
            GameInfo.FuncOffsets.AddObject,
            AddObjectDetour
        );
        _ObjectDtorDetourBase = DetourUtil.NewDetour<GameFunctions.ObjectDtorDelegate>(
            GameInfo.FuncOffsets.ObjectDtor,
            ObjectDtorDetour
        );

        // End with a newline
        Debug.Write("\n");
    }

    static void OnGameStart()
    {
        // Test script functions
        Debug.WriteLine($"1 + 2 = {GameObject.Add_IntInt(1, 2)}");

        // Test StaticClass()
        Debug.WriteLine($"Class::StaticClass(): {Class.StaticClass()}");
        Debug.WriteLine($"Actor::StaticClass(): {Actor.StaticClass()}");

        // Test ConstructObject()
        var newObj = new MacroReachSpec(null, "SomeMacroReachSpec");
        Debug.WriteLine($"New object: {newObj}");

        // Test FindObjects(), actor properties
        var meshActor = GameObject.FindObjects<RCinematicBatman>().Last();
        var meshComponent = meshActor.Components.OfType<SkeletalMeshComponent>().ElementAt(0);
        Debug.WriteLine($"Found actor {meshActor}");
        Debug.WriteLine($"Found component {meshComponent}");

        // Test object methods
        meshComponent.SetHidden(true);

        // Test dynamic object loading
        var jokerMesh = GameObject.DynamicLoadObject(
            "Joker.Mesh.Combat_joker",
            SkeletalMesh.StaticClass()
        );
        Debug.WriteLine($"Loaded mesh {jokerMesh}");

        // TODO: Prop offsets are wrong
        // Debug.WriteLine($"MeshComponent should have size {MeshComponent.StaticClass().PropertiesSize}");
        // Debug.WriteLine(meshComponent.SkeletalMesh?.GetPathName());
    }

    static bool HasGameStarted = false;

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

        unsafe
        {
            var funcObj = MarshalUtil.MarshalToManaged<Function>(&Function);
            var funcNameForGameStart = "Engine.PlayerController:ServerUpdateLevelVisibility";

            // Perform game start logic
            if (!HasGameStarted && funcObj.GetPathName() == funcNameForGameStart)
            {
                OnGameStart();
                HasGameStarted = true;
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
        var classPtr = *(IntPtr*)(obj + GameInfo.MemberOffsets.Object__Class).ToPointer();
        var className = *(FName*)(classPtr + GameInfo.MemberOffsets.Object__Name).ToPointer();

        // Fetch outer name.
        var classOuterPtr = *(IntPtr*)(classPtr + GameInfo.MemberOffsets.Object__Outer).ToPointer();
        var classOuterName = *(FName*)
            (classOuterPtr + GameInfo.MemberOffsets.Object__Name).ToPointer();

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
