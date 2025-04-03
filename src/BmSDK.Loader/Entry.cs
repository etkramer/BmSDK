using System.Diagnostics;
using System.Reflection;
using BmSDK.Framework;

namespace BmSDK.Loader;

static class Entry
{
    delegate void DllMainDelegate();

    static GameFunctions.ProcessEventDelegate? _ProcessEventDetourBase = null;
    static GameFunctions.AddObjectDelegate? _AddObjectDetourBase = null;
    static GameFunctions.ObjectDtorDelegate? _ObjectDtorDetourBase = null;

    static List<ManagedPlugin> _pluginInstances = [];

    public static void DllMain()
    {
        Debug.WriteLine($"Hello from BmSDK.Loader");

        // Perform static init (before engine load)
        StaticInit.StaticInitClasses();

        // Prepare for assembly loading
        AppDomain.CurrentDomain.AssemblyResolve += (sender, e) =>
        {
            // Try to see if we already have this assembly loaded
            return AppDomain
                .CurrentDomain.GetAssemblies()
                .ToList()
                .FirstOrDefault(asm => asm.GetName().ToString() == e.Name);
        };

        // Find plugins
        // var pluginsDir = Path.Combine(Environment.CurrentDirectory, "plugins");
        // foreach (var pluginDir in Directory.GetDirectories(pluginsDir))
        // {
        //     // Locate/load plugin assembly
        //     var pluginName = Path.GetFileName(pluginDir);
        //     var pluginPath = Path.Combine(pluginDir, $"{pluginName}.dll");
        //     var pluginAssembly = Assembly.LoadFile(pluginPath);

        //     var pluginType = pluginAssembly
        //         .GetTypes()
        //         .Where(type => type.IsAssignableTo(typeof(ManagedPlugin)))
        //         .FirstOrDefault();

        //     if (pluginType is null)
        //     {
        //         Debug.WriteLine($"No {nameof(ManagedPlugin)} instance found in {pluginName}");
        //         continue;
        //     }
        //     else
        //     {
        //         // Instantiate plugin type
        //         var pluginInstance = Guard.NotNull(
        //             Activator.CreateInstance(pluginType) as ManagedPlugin,
        //             $"Failed to instantiate plugin {pluginName}"
        //         );

        //         Debug.WriteLine($"Loaded plugin {pluginName}");
        //         _pluginInstances.Add(pluginInstance);
        //     }
        // }

        // Create function detours
        // _ProcessEventDetourBase = DetourUtil.NewDetour<GameFunctions.ProcessEventDelegate>(
        //     GameInfo.FuncOffsets.ProcessEvent,
        //     ProcessEventDetour
        // );
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

    static bool HasGameStarted = false;
    static bool HasGameInited = false;

    // Detour for UObject::ProcessEvent()
    public static unsafe void ProcessEventDetour(
        IntPtr self,
        IntPtr Function,
        IntPtr Parms,
        IntPtr UnusedResult
    )
    {
        var funcObj = MarshalUtil.MarshalToManaged<Function>(&Function);
        var selfObj = MarshalUtil.MarshalToManaged<GameObject>(&self);

        var funcNameForGameInit = "Engine.GameInfo:InitGame";
        var funcNameForGameStart = "Engine.PlayerController:ServerUpdateLevelVisibility";

        // Perform game load logic
        if (!HasGameInited && funcObj.GetPathName() == funcNameForGameInit)
        {
            // Call OnInit() for plugins
            _pluginInstances.ForEach(plugin => plugin.OnInit());
            HasGameInited = true;
        }

        // Perform game start logic
        if (!HasGameStarted && funcObj.GetPathName() == funcNameForGameStart)
        {
            // Call OnStart() for plugins
            _pluginInstances.ForEach(plugin => plugin.OnStart());
            HasGameStarted = true;
        }

        // Do we have any 'before' mixins?
        if (
            MixinManager.TryGetMixinMethods(
                selfObj,
                funcObj,
                MixinOrder.Before,
                out var mixinMethods
            )
        )
        {
            foreach (var mixinMethod in mixinMethods)
            {
                // Call mixin method
                // TODO: Marshal rest of parameters
                var mixinParams = new object[] { selfObj };
                var mixinResult = mixinMethod.Invoke(null, mixinParams);

                // Check if we need to stop the original function from executing
                if (mixinResult is bool result && !result)
                {
                    return;
                }
            }
        }

        // Call base impl
        _ProcessEventDetourBase!.Invoke(self, Function, Parms, UnusedResult);

        // Do we have any 'after' mixins?
        if (MixinManager.TryGetMixinMethods(selfObj, funcObj, MixinOrder.After, out mixinMethods))
        {
            foreach (var mixinMethod in mixinMethods)
            {
                // Call mixin method
                // TODO: Marshal rest of parameters
                var mixinParams = new object[] { selfObj };
                var mixinResult = mixinMethod.Invoke(null, mixinParams);

                // Check if we need to stop the original function from executing
                if (mixinResult is bool result && !result)
                {
                    return;
                }
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

    // Detour for UObject::~UObject()
    public static void ObjectDtorDetour(IntPtr self)
    {
        // Call base impl
        _ObjectDtorDetourBase!.Invoke(self);

        // Destroy this object's managed instance
        MarshalUtil.DestroyManagedWrapper(self);
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
}
