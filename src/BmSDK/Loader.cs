global using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using BmSDK.BmGame;
using BmSDK.Framework;
using MoreLinq;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK;

static class Loader
{
    delegate void DllMainDelegate();

    static GameFunctions.ProcessEventDelegate? _ProcessEventDetourBase = null;
    static GameFunctions.CallFunctionDelegate? _CallFunctionDetourBase = null;
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
        _ProcessEventDetourBase = DetourUtil.NewDetour<GameFunctions.ProcessEventDelegate>(
            GameInfo.FuncOffsets.ProcessEvent,
            ProcessEventDetour
        );
        _CallFunctionDetourBase = DetourUtil.NewDetour<GameFunctions.CallFunctionDelegate>(
            GameInfo.FuncOffsets.CallFunction,
            CallFunctionDetour
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

    // Detour for UObject::CallFunction()
    public static unsafe void CallFunctionDetour(
        IntPtr self,
        IntPtr Stack,
        IntPtr Result,
        IntPtr Function
    )
    {
        // TODO: Mixins

        // Call base impl
        _CallFunctionDetourBase!.Invoke(self, Stack, Result, Function);
    }

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

            var funcObj = MarshalUtil.ToManaged<UFunction>(&funcPtr);
            var selfObj = MarshalUtil.ToManaged<UObject>(&selfPtr);

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
        });

        // Call base impl
        _ProcessEventDetourBase!.Invoke(self, Function, Parms, UnusedResult);
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
                MarshalUtil.CreateManagedWrapper(self, typeof(UClass));
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
