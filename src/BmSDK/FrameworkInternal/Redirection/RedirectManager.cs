using System.Reflection;

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
    /// Stack of UFunction objects storing the currently running redirect targets.
    /// <see cref="ExecuteRedirector(GameObject, Function, string, FFrame*, nint)"/> pushes a
    /// function on entry and pops it on exit and if the same function is found at the
    /// top of the stack, a reentry is detected and the redirect is prevented.
    /// This avoids infinite recursion.
    /// </summary>
    static readonly Stack<RedirectCall> s_redirectCalls = [];

    /// <summary>
    /// Executes the redirects from the UObject::ProcessInternal() context.
    /// It first searches for a local redirect for the given function and executes it.
    /// If there is none, the function searches for a global redirect for the given target function and executes it.
    /// If there is no local or global redirect, we return false. 
    /// </summary>
    /// <returns>True, if any redirector (local or global) was found; false if not.
    /// As a consequence, the original is called from Loader if false is returned.</returns>
    public static unsafe bool ExecuteRedirector(GameObject selfObj, Function funcObj, string funcPath, FFrame* stackPtr, IntPtr Result)
    {
        // Prevent infinite recursion: if top of stack is the function object, treat as reentry
        if (s_redirectCalls.TryPeek(out var lastCall))
        {
            if (lastCall.TargetObj == selfObj && lastCall.TargetFunc == funcObj)
            {
                if (lastCall.Redirs.TryDequeue(out var redir))
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
        if (!redirs.Any())
        {
            return false;
        }

        // Push this func to mark it as being actively redirected during this invocation
        var redirsQueue = new Queue<IGenericRedirect>(redirs);
        s_redirectCalls.Push(new RedirectCall(selfObj, funcObj, redirsQueue));

        try
        {
            redirsQueue.Dequeue().Run(selfObj, funcObj, stackPtr, Result);
        }
        finally
        {
            // Pop the function off the stack when the invocation is over
            s_redirectCalls.Pop();
        }

        return true;
    }

    static IEnumerable<IGenericRedirect> AquireRedirects(GameObject selfObj, string funcPath)
        => Local.GetRedirectors(selfObj, funcPath)
            .Cast<IGenericRedirect>()
            .Concat(Global.GetRedirectors(selfObj, funcPath));

    /// <summary>
    /// Clears the backing redirector dictionaries, therefore, uninstalling all local and global redirects.
    /// </summary>
    public static void UnregisterAll()
    {
        Global.UnregisterAll();
        Local.UnregisterAll();
    }
}
