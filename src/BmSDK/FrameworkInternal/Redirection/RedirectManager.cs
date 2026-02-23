using System.Reflection;
using MoreLinq;

namespace BmSDK.Framework.Redirection;

/// <summary>
/// A class managing the registered detours of all mods.
/// It stores the registered <see cref="GlobalRedirectManager"/> and <see cref="LocalRedirectManager"/>.
/// </summary>
static class RedirectManager
{
    public static readonly GlobalRedirectManager Global = new(GenericRedirSearchFlags);
    public static readonly LocalRedirectManager Local = new(GenericRedirSearchFlags);

    const BindingFlags GenericRedirSearchFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic;

    /// <summary>
    /// A unique set of all function paths that have been redirected.
    /// This is used to set up UFunction objects for redirection.
    /// </summary>
    static readonly HashSet<string> s_redirectFuncs = [];

    /// <summary>
    /// Stack of UFunction objects storing the currently running redirect targets.
    /// Used to avoid infinite recursion and allow multiple redirects.
    /// </summary>
    static readonly Stack<RedirectCall> s_redirectCalls = [];

    /// <summary>
    /// Queues a function path to be configured for redirections after
    /// the UFunction object is created. This should be run during mod initialization.
    /// </summary>
    public static void QueueConfigureFunction(string funcPath) => s_redirectFuncs.Add(funcPath);

    /// <summary>
    /// Configures the given UFunction object for redirects if it has been queued.
    /// This should be run after UFunction serialization.
    /// </summary>
    /// <returns>True, if the function had been registered for redirection;
    /// false, otherwise</returns>
    public static bool TryConfiureFunction(Function func)
    {
        if (s_redirectFuncs.Contains(func.GetPathName()))
        {
            ConfigureFunction(func);
            return true;
        }

        return false;
    }

    /// <summary>
    /// Configures any given UFunction for redirects. Should only be run, when sure that
    /// the function is actually redirected and after the function has been serialized.
    /// </summary>
    public static void ConfigureFunction(Function func)
        => func.FunctionFlags |= Function.EFunctionFlags.FUNC_Defined;

    /// <summary>
    /// Configures every registered UFunction object for redirection.
    /// This should be called after all redirects have been registered on mod reload.
    /// </summary>
    public static void ConfigureAllRedirectedFunctions() =>
        s_redirectFuncs
            .Select(Game.FindObject<Function>)
            .OfType<Function>()
            .ForEach(ConfigureFunction);

    /// <summary>
    /// Executes the redirects from the UObject::ProcessInternal() context.
    /// This is done by queuing the local redirects first and then the global ones.
    /// After the initial setup, the next redirect is dequeued on re-entry.
    /// </summary>
    /// <returns>True, if any redirector was found and executed; false if not.
    /// As a consequence, the original should be called if false is returned.</returns>
    /// <see cref="Loader.ProcessInternalDetour(nint, nint, nint)"/>
    public static unsafe bool ExecuteRedirector(GameObject selfObj, Function funcObj, string funcPath, FFrame* stackPtr, IntPtr Result)
    {
        // Prevent infinite recursion: if top of stack is the function object, treat as reentry
        if (s_redirectCalls.TryPeek(out var lastCall))
        {
            if (lastCall.TargetObj == selfObj && lastCall.TargetFunc == funcObj)
            {
                var redir = lastCall.NextRedirect();
                if (redir != null)
                {
                    redir.Run(selfObj, funcObj, stackPtr, Result);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // Get redirects applicable to current function
        var redirs = AquireRedirects(selfObj, funcPath);
        if (redirs.Length == 0)
        {
            return false;
        }

        // Push this func to mark it as being actively redirected during this invocation
        var newCall = new RedirectCall(selfObj, funcObj, redirs);
        s_redirectCalls.Push(newCall);

        try
        {
            newCall.NextRedirect()!.Run(selfObj, funcObj, stackPtr, Result);
        }
        finally
        {
            // Pop the function off the stack when the invocation is over
            s_redirectCalls.Pop();
        }

        return true;
    }

    /// <summary>
    /// Creates a collection of all redirects that apply to a specific object and method.
    /// </summary>
    /// <returns>Collection of all local redirects first,
    /// then all the global redirects.</returns>
    static IGenericRedirect[] AquireRedirects(GameObject selfObj, string funcPath)
        => Local.GetRedirectors(selfObj, funcPath)
            .Cast<IGenericRedirect>()
            .Concat(Global.GetRedirectors(selfObj, funcPath))
            .ToArray();

    /// <summary>
    /// Clears the backing redirector dictionaries, therefore, uninstalling all redirects.
    /// </summary>
    public static void UnregisterAll()
    {
        Global.UnregisterAll();
        Local.UnregisterAll();
        s_redirectFuncs.Clear();
    }
}
