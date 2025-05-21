using System.Reflection;
using BmSDK.Framework;

namespace BmSDK;

static class Loader
{
    delegate void DllMainDelegate();

    static GameFunctions.ProcessEventDelegate? _ProcessEventDetourBase = null;
    static GameFunctions.AddObjectDelegate? _AddObjectDetourBase = null;
    static GameFunctions.ConditionalDestroyDelegate? _ConditionalDestroyDetourBase = null;

    static readonly List<GameMod> s_modInstances = [];

    public static void GuardedDllMain()
    {
        Debug.PushSender("Loader");
        RunGuarded(DllMain);
        Debug.PopSender();
    }

    public static void DllMain()
    {
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

        // Find mods (note we're relative to the host asi)
        var modsDir = Path.Combine(Environment.CurrentDirectory, "..", "mods");
        if (Directory.Exists(modsDir))
        {
            foreach (var modDir in Directory.GetDirectories(modsDir))
            {
                // Load mod assembly
                var modName = Path.GetFileName(modDir);
                var modPath = Path.Combine(modDir, $"{modName}.dll");
                var modAssembly = Assembly.LoadFile(modPath);

                // Locate mod instance type
                var modType = modAssembly
                    .GetTypes()
                    .Where(type => type.IsAssignableTo(typeof(GameMod)))
                    .FirstOrDefault();

                if (modType is null)
                {
                    Debug.Log($"No {nameof(GameMod)} type found in {modName}");
                    continue;
                }
                else
                {
                    // Instantiate mod type
                    var modInstance = Guard.NotNull(
                        Activator.CreateInstance(modType) as GameMod,
                        $"Failed to instantiate mod {modName}"
                    );

                    s_modInstances.Add(modInstance);
                }
            }
        }

        // Report successful load
        Debug.Log($"Loaded {s_modInstances.Count} mod(s)");

        // Create function detours
        _ProcessEventDetourBase = DetourUtil.NewDetour<GameFunctions.ProcessEventDelegate>(
            GameInfo.FuncOffsets.ProcessEvent,
            ProcessEventDetour
        );
        _AddObjectDetourBase = DetourUtil.NewDetour<GameFunctions.AddObjectDelegate>(
            GameInfo.FuncOffsets.AddObject,
            AddObjectDetour
        );
        _ConditionalDestroyDetourBase =
            DetourUtil.NewDetour<GameFunctions.ConditionalDestroyDelegate>(
                GameInfo.FuncOffsets.ConditionalDestroy,
                ConditionalDestroyDetour
            );
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
        RunGuarded(() =>
        {
            IntPtr funcPtr = Function;
            IntPtr selfPtr = self;

            var funcObj = MarshalUtil.ToManaged<Function>(&funcPtr);
            var selfObj = MarshalUtil.ToManaged<GameObject>(&selfPtr);

            var funcNameForGameInit = "Engine.GameInfo:InitGame";
            var funcNameForGameStart = "Engine.PlayerController:ServerUpdateLevelVisibility";

            // Perform game load logic
            if (!HasGameInited && funcObj.GetPathName() == funcNameForGameInit)
            {
                // Call OnInit() for mods
                s_modInstances.ForEach(mod =>
                {
                    Debug.PushSender(mod.GetType().Name);
                    mod.OnInit();
                    Debug.PopSender();
                });

                HasGameInited = true;
            }

            // Perform game start logic
            if (!HasGameStarted && funcObj.GetPathName() == funcNameForGameStart)
            {
                // Call OnStart() for mods
                s_modInstances.ForEach(mod =>
                {
                    Debug.PushSender(mod.GetType().Name);
                    mod.OnStart();
                    Debug.PopSender();
                });

                HasGameStarted = true;
            }
        });

        // Call base impl
        _ProcessEventDetourBase!.Invoke(self, Function, Parms, UnusedResult);
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
    public static void ConditionalDestroyDetour(IntPtr self)
    {
        // Call base impl
        _ConditionalDestroyDetourBase!.Invoke(self);

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

    static void RunGuarded(Action action)
    {
        try
        {
            action();
        }
        catch (Exception ex)
        {
            Debug.Log(ex);
            throw;
        }
    }
}
