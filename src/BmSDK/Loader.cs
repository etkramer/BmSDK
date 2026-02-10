global using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using BmSDK.Engine;
using BmSDK.Framework.Redirection;
using MoreLinq;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK.Framework;

static class Loader
{
    const string InitFuncName = "Engine.GameInfo:InitGame";
    const string EnterMenuFuncName = "GFxUI.GFxMoviePlayer:Init";
    const string EnterGameFuncName = "BmGame.RPlayerController:ClientReady";
    const string PostBeginPlayFuncName = ":PostBeginPlay";
    const string TickFuncName = "BmGame.RGameInfo:Tick";

    static GameFunctions.EngineTickDelegate? _EngineTickDetourBase = null;
    static GameFunctions.ProcessInternalDelegate? _ProcessInternalDetourBase = null;
    static GameFunctions.ConditionalDestroyDelegate? _ConditionalDestroyDetourBase = null;

    /// <summary>
    /// Main .NET entry point, called from BmSDK.Host.
    /// This is done when FEngineLoop::PreInit() is executed.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void GuardedDllMain()
        => Debug.RunWithSender("Loader", () => RunGuarded(DllMain));

    static void DllMain()
    {
        EngineSynchronizationContext.InitOnThread();

        // Environment.CurrentDirectory gets unreliable once we start
        // running code in detours, so let's store it early.
        FileUtils.Init();

        // Perform static init (before engine load)
        StaticInit.StaticInitClasses();

        // Find/load scripts
        ScriptManager.Init();

        // Create function detours
        _ProcessInternalDetourBase =
            DetourUtil.NewDetour<GameFunctions.ProcessInternalDelegate>(
                GameInfo.FuncOffsets.ProcessInternal,
                ProcessInternalDetour);

        _EngineTickDetourBase =
            DetourUtil.NewDetour<GameFunctions.EngineTickDelegate>(
                GameInfo.FuncOffsets.EngineTick,
                EngineTickDetour);

        _ConditionalDestroyDetourBase =
            DetourUtil.NewDetour<GameFunctions.ConditionalDestroyDelegate>(
                GameInfo.FuncOffsets.ConditionalDestroy,
                ConditionalDestroyDetour);
    }

    static IntPtr EngineTickDetour(IntPtr self)
    {
        // Run the scheduled callbacks
        EngineSynchronizationContext.Instance.ExecutePending();
        return _EngineTickDetourBase!.Invoke(self);
    }

    static bool s_hasGameStarted = false;
    static bool s_hasGameInited = false;

    // Detour for UObject::ProcessInternal()
    static unsafe void ProcessInternalDetour(IntPtr self, IntPtr Stack, IntPtr Result)
    {
        RunGuarded(() =>
        {
            IntPtr selfPtr = self;
            FFrame* stackPtr = (FFrame*)Stack.ToPointer();
            var selfObj = MarshalUtil.ToManaged<GameObject>(&selfPtr);
            var funcObj = MarshalUtil.ToManaged<Function>(&stackPtr->Node);
            var funcName = funcObj.GetPathName();

            // Notify scripts of game init
            if (!s_hasGameInited && funcName == InitFuncName)
            {
                ScriptManager.Scripts.ForEach(script => Debug.RunWithSender(script.Name, script.Main));
                s_hasGameInited = true;
            }

            // Notify scripts of game start
            if (!s_hasGameStarted && funcName == EnterMenuFuncName)
            {
                ScriptManager.Scripts.ForEach(script => Debug.RunWithSender(script.Name, script.OnEnterMenu));
                s_hasGameStarted = true;
            }

            // Notify scripts of game begin play
            if (funcName == EnterGameFuncName)
            {
                ScriptManager.Scripts.ForEach(script => Debug.RunWithSender(script.Name, script.OnEnterGame));
            }

            // Auto-attach script components to newly spawned actors
            if (ScriptComponentManager.HasAutoAttachTypes())
            {
                if (funcName.EndsWith(PostBeginPlayFuncName) && selfObj is Actor actor)
                {
                    ScriptComponentManager.TryAutoAttachComponents(actor);
                }
            }

            // Notify scripts of game tick
            if (funcName == TickFuncName)
            {
                // Tick framework stuff
                InputManager.Tick();
                GameWindow.Tick();

                // Call OnTick() for scripts
                ScriptManager.Scripts.ForEach(script => Debug.RunWithSender(script.Name, script.OnTick));

                // Call OnTick() for script components
                if (Actor.AllScriptComponents.Count > 0)
                {
                    foreach (var scriptComponent in Actor.AllScriptComponents)
                    {
                        Debug.RunWithSender(
                            scriptComponent.GetType().Name,
                            scriptComponent.OnTick);
                    }
                }
            }

            // Run redirect and skip base implementation if applicable to this function
            if (RedirectManager.ExecuteRedirector(selfObj, funcObj, stackPtr, Result))
            {
                return;
            }

            // Call base impl. Redirected implementations are expected to reach this by calling "themselves" a second time.
            _ProcessInternalDetourBase!.Invoke(self, Stack, Result);
        });
    }

    // Detour for UObject::ConditionalDestroy()
    static void ConditionalDestroyDetour(IntPtr self)
    {
        // Destroy this object's managed instance
        RunGuarded(() => MarshalUtil.DestroyManagedWrapper(self));

        // Call base impl
        _ConditionalDestroyDetourBase!.Invoke(self);
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
