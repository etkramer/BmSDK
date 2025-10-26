global using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using BmSDK.BmGame;
using BmSDK.Engine;
using BmSDK.Framework;
using MoreLinq;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK.Framework;

internal static class Loader
{
    delegate void DllMainDelegate();

    static GameFunctions.ProcessInternalDelegate? _ProcessInternalDetourBase = null;
    static GameFunctions.AddObjectDelegate? _AddObjectDetourBase = null;
    static GameFunctions.ConditionalDestroyDelegate? _ConditionalDestroyDetourBase = null;

    /// <summary>
    /// Main .NET entry point, called from BmSDK.Host.
    /// </summary>
    public static void GuardedDllMain()
    {
        Debug.PushSender("Loader");
        RunGuarded(DllMain);
        Debug.PopSender();
    }

    private static void DllMain()
    {
        // Environment.CurrentDirectory gets unreliable once we start
        // running code in detours, so let's store it early.
        FileUtils.Init();

        // Perform static init (before engine load)
        StaticInit.StaticInitClasses();

        // Find/load scripts
        if (!ScriptManager.LoadScripts())
        {
            // We don't have any valid scripts, just abort here.
            return;
        }

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

    private static void OnGameInit()
    {
        // Do we have the generator present?
        if (GeneratorBridge.IsGeneratorPresent)
        {
            var packageDir = Path.Combine(FileUtils.GetGamePath(), "CookedPCConsole");

            // Load packages containing classes we'll want at generation time.
            foreach (var packagePath in Directory.EnumerateFiles(packageDir, "*.upk"))
            {
                var packageName = Path.GetFileNameWithoutExtension(packagePath);

                // Skip common packages we know are always loaded.
                if (
                    packageName.Equals("Core", StringComparison.OrdinalIgnoreCase)
                    || packageName.Equals("Engine", StringComparison.OrdinalIgnoreCase)
                    || packageName.Equals("BmGame", StringComparison.OrdinalIgnoreCase)
                    || packageName.StartsWith("OnlineSubsystem", StringComparison.OrdinalIgnoreCase)
                )
                {
                    continue;
                }

                // In most cases, don't load SeekFree packages as these won't contain classes.
                if (
                    !packageName.StartsWith("Playable_", StringComparison.OrdinalIgnoreCase)
                    && packageName.EndsWith("_SF", StringComparison.OrdinalIgnoreCase)
                )
                {
                    continue;
                }

                // Don't load these package types as these won't contain classes.
                if (
                    packageName.Contains("_Static", StringComparison.OrdinalIgnoreCase)
                    || packageName.Contains("_FX", StringComparison.OrdinalIgnoreCase)
                    || packageName.Contains("_Lights", StringComparison.OrdinalIgnoreCase)
                    || packageName.Contains("_CLights", StringComparison.OrdinalIgnoreCase)
                    || packageName.Contains("_Audio", StringComparison.OrdinalIgnoreCase)
                    || packageName.Contains("_LOD", StringComparison.OrdinalIgnoreCase)
                    || packageName.Contains("_Px", StringComparison.OrdinalIgnoreCase)
                    || packageName.Contains("ShaderCache", StringComparison.OrdinalIgnoreCase)
                    || packageName.StartsWith("Anim_", StringComparison.OrdinalIgnoreCase)
                    || packageName.StartsWith("Bio_", StringComparison.OrdinalIgnoreCase)
                    || packageName.StartsWith("CS_", StringComparison.OrdinalIgnoreCase)
                    || packageName.StartsWith("CV_", StringComparison.OrdinalIgnoreCase)
                    || packageName.StartsWith("Dlg-", StringComparison.OrdinalIgnoreCase)
                    || packageName.StartsWith("LH-", StringComparison.OrdinalIgnoreCase)
                    || packageName.StartsWith("WwSpch-", StringComparison.OrdinalIgnoreCase)
                    || packageName.StartsWith("Tape", StringComparison.OrdinalIgnoreCase)
                    || packageName.StartsWith("Synopsis", StringComparison.OrdinalIgnoreCase)
                    || packageName.StartsWith("Gallery", StringComparison.OrdinalIgnoreCase)
                )
                {
                    continue;
                }

                Debug.Log($"Loading {packageName}");

                // Load whole package into memory.
                Game.LoadPackage(packageName);
            }
        }

        // Call Main() for scripts
        ScriptManager.Scripts.ForEach(script =>
        {
            Debug.PushSender(script.Name);
            script.Main();
            Debug.PopSender();
        });
    }

    static bool HasGameStarted = false;
    static bool HasGameInited = false;

    static Function? lastFuncForRedirects = null;

    // Detour for UObject::ProcessInternal()
    private static unsafe void ProcessInternalDetour(IntPtr self, IntPtr Stack, IntPtr Result)
    {
        RunGuarded(() =>
        {
            IntPtr selfPtr = self;
            FFrame* stackPtr = (FFrame*)Stack.ToPointer();

            var selfObj = MarshalUtil.ToManaged<GameObject>(&selfPtr);
            var funcObj = MarshalUtil.ToManaged<Function>(&stackPtr->Node);

            var funcName = funcObj.GetPathName();
            var funcNameForInit = "Engine.GameInfo:InitGame";
            var funcNameForTick = "BmGame.RGameInfo:Tick";
            var funcNameForEnterMenu = "GFxUI.GFxMoviePlayer:Init";
            var funcNameForEnterGame = "BmGame.RPlayerController:ClientReady";

            // Notify scripts of game init
            if (!HasGameInited && funcName == funcNameForInit)
            {
                OnGameInit();
                HasGameInited = true;
            }

            // Notify scripts of game start
            if (!HasGameStarted && funcName == funcNameForEnterMenu)
            {
                // Call OnEnterMenu() for scripts
                ScriptManager.Scripts.ForEach(script =>
                {
                    Debug.PushSender(script.Name);
                    script.OnEnterMenu();
                    Debug.PopSender();
                });

                HasGameStarted = true;
            }

            // Notify scripts of game begin play
            if (funcName == funcNameForEnterGame)
            {
                // Call OnEnterGame() for scripts
                ScriptManager.Scripts.ForEach(script =>
                {
                    Debug.PushSender(script.Name);
                    script.OnEnterGame();
                    Debug.PopSender();
                });
            }

            // Notify scripts of game tick
            if (funcName == funcNameForTick)
            {
                // Tick framework stuff
                InputManager.Tick(ScriptManager.Scripts);
                GameWindow.Tick();

                // Call OnTick() for scripts
                ScriptManager.Scripts.ForEach(script =>
                {
                    Debug.PushSender(script.Name);
                    script.OnTick();
                    Debug.PopSender();
                });

                // Call OnTick() for script components
                if (Actor.AllScriptComponents.Count > 0)
                {
                    foreach (var scriptComponent in Actor.AllScriptComponents.ToArray())
                    {
                        Debug.PushSender(scriptComponent.GetType().Name);
                        scriptComponent.OnTick();
                        Debug.PopSender();
                    }
                }
            }

            // Don't run the same redirector twice in a row - in that case, we assume the user is attempting to call the base implementation.
            // Obviously this will have side effects, but it *should* be good enough for now as the cases where it breaks should be extremely rare.
            // TODO: Instead of falling back to the base impl, we can support multiple redirectors on the same function by having subsequent calls fall back to the next redirector instead (until we run out).
            bool shouldIgnoreRedirects = lastFuncForRedirects == funcObj;
            lastFuncForRedirects = funcObj;

            // Do we have any redirections to run?
            if (
                !shouldIgnoreRedirects
                && RedirectManager.TryGetRedirector(selfObj, funcObj, out var redirectorInfo)
            )
            {
                var redirectMethod = redirectorInfo.RedirectMethod;
                var redirectTarget = redirectorInfo.RedirectTarget;

                // Gather (expected) managed types using the redirector, noting the artificial 'self' param.
                var argTypes = redirectMethod
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

                var result = redirectMethod.Invoke(redirectTarget, args.ToArray());

                if (result != null && redirectMethod.ReturnType != null)
                {
                    // Marshal result back (if non-void).
                    var returnType = redirectMethod.ReturnType;
                    MarshalUtil.ToUnmanaged(result, Result, redirectMethod.ReturnType);
                }
            }
            else
            {
                // Call base impl. Redirected implementations are expected to reach this by calling "themselves" a second time.
                _ProcessInternalDetourBase!.Invoke(self, Stack, Result);
            }
        });
    }

    // Detour for UObject::AddObject()
    private static unsafe void AddObjectDetour(IntPtr self, int InIndex)
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
    private static void ConditionalDestroyDetour(IntPtr self)
    {
        // Destroy this object's managed instance
        RunGuarded(() => MarshalUtil.DestroyManagedWrapper(self));

        // Call base impl
        _ConditionalDestroyDetourBase!.Invoke(self);
    }

    private static unsafe string GetClassPath(IntPtr obj)
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

    private static void RunGuarded(Action action)
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
