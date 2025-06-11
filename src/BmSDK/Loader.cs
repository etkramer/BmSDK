global using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using BmSDK.BmGame;
using BmSDK.Framework;
using MoreLinq;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK.Framework;

static class Loader
{
    delegate void DllMainDelegate();

    static GameFunctions.ProcessInternalDelegate? _ProcessInternalDetourBase = null;
    static GameFunctions.AddObjectDelegate? _AddObjectDetourBase = null;
    static GameFunctions.ConditionalDestroyDelegate? _ConditionalDestroyDetourBase = null;

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

        // Find/load mods
        ModManager.Init();

        // Create function detours
        _ProcessInternalDetourBase = DetourUtil.NewDetour<GameFunctions.ProcessInternalDelegate>(
            GameInfo.FuncOffsets.ProcessInternal,
            ProcessInternalDetour
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

    static Function? lastFuncForMixins = null;

    // Detour for UObject::ProcessInternal()
    public static unsafe void ProcessInternalDetour(IntPtr self, IntPtr Stack, IntPtr Result)
    {
        RunGuarded(() =>
        {
            IntPtr selfPtr = self;
            FFrame* stackPtr = (FFrame*)Stack.ToPointer();

            var selfObj = MarshalUtil.ToManaged<GameObject>(&selfPtr);
            var funcObj = MarshalUtil.ToManaged<Function>(&stackPtr->Node);

            var funcName = funcObj.GetPathName();
            var funcNameForGameInit = "Engine.GameInfo:InitGame";
            var funcNameForGameStart = "Engine.PlayerController:ServerUpdateLevelVisibility";
            var funcNameForGameTick = "BmGame.RGameInfo:Tick";
            var funcNameForGameBeginPlay = "BmGame.RPlayerController:ClientReady";

            // Notify mods of game init
            if (!HasGameInited && funcName == funcNameForGameInit)
            {
                // Call OnInit() for mods
                ModManager.Mods.ForEach(mod =>
                {
                    Debug.PushSender(mod.GetType().Name);
                    mod.OnInit();
                    Debug.PopSender();
                });

                HasGameInited = true;
            }

            // Notify mods of game start
            if (!HasGameStarted && funcName == funcNameForGameStart)
            {
                // Call OnStart() for mods
                ModManager.Mods.ForEach(mod =>
                {
                    Debug.PushSender(mod.GetType().Name);
                    mod.OnEnterMenu();
                    Debug.PopSender();
                });

                HasGameStarted = true;
            }

            // Notify mods of game begin play
            if (funcName == funcNameForGameBeginPlay)
            {
                // Call OnBeginPlay() for mods
                ModManager.Mods.ForEach(mod =>
                {
                    Debug.PushSender(mod.GetType().Name);
                    mod.OnEnterGame();
                    Debug.PopSender();
                });
            }

            // Notify mods of game tick
            if (funcName == funcNameForGameTick)
            {
                // Tick framework stuff
                InputManager.Tick(ModManager.Mods);
                GameWindow.Tick();

                // Call OnTick() for mods
                ModManager.Mods.ForEach(mod =>
                {
                    Debug.PushSender(mod.GetType().Name);
                    mod.OnTick();
                    Debug.PopSender();
                });
            }

            // Don't run the same mixin twice in a row - in that case, we assume the user is attempting to call the base implementation.
            // Obviously this will have side effects, but it *should* be good enough for now as the cases where it breaks should be extremely rare.
            // TODO: Instead of falling back to the base impl, we can support multiple mixins on the same function by having subsequent calls fall back to the next mixin instead (until we run out).
            bool shouldIgnoreMixins = lastFuncForMixins == funcObj;
            lastFuncForMixins = funcObj;

            // Do we have any mixins to run?
            if (
                !shouldIgnoreMixins
                && MixinManager.TryGetMixinMethod(selfObj, funcObj, out var mixinMethod)
            )
            {
                // Gather (expected) managed types using the mixin impl, noting the artificial 'self' param.
                var argTypes = mixinMethod
                    .GetParameters()
                    .Select(p => p.ParameterType)
                    .Skip(funcObj.IsStatic ? 0 : 1)
                    .ToArray();

                // Marshal args, add self as first arg if needed.
                var args = stackPtr->ParamsToManaged(argTypes).ToList();
                if (!funcObj.IsStatic)
                {
                    args.Insert(0, selfObj);
                }

                var result = mixinMethod.Invoke(null, args.ToArray());

                if (result != null)
                {
                    // TODO: Marshal result back for non-void functions.
                }
            }
            else
            {
                // Call base impl. Mixin implementations are expected to reach this by calling "themselves" a second time.
                _ProcessInternalDetourBase!.Invoke(self, Stack, Result);
            }
        });
    }

    // Detour for UObject::AddObject()
    public static unsafe void AddObjectDetour(IntPtr self, int InIndex)
    {
        // Call base impl
        _AddObjectDetourBase!.Invoke(self, InIndex);

        RunGuarded(() =>
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
        });
    }

    // Detour for UObject::ConditionalDestroy()
    public static void ConditionalDestroyDetour(IntPtr self)
    {
        // Destroy this object's managed instance
        RunGuarded(() => MarshalUtil.DestroyManagedWrapper(self));

        // Call base impl
        _ConditionalDestroyDetourBase!.Invoke(self);
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
            // Just abort, because otherwise UE3 will crash anyway but print
            // its more-or-less useless DBGHELP messages.
            Debug.LogError(ex.ToString());
            Environment.Exit(1);
        }
    }
}
