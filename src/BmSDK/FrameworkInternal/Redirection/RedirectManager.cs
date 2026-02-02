using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace BmSDK.Framework.Redirection;

static class RedirectManager
{
    static readonly Dictionary<string, RedirectorInfo> s_redirectorDict = [];
    const BindingFlags RedirAttrSearchFlags = BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic;

    internal static void UnregisterAll() => s_redirectorDict.Clear();

    /// <summary>
    /// Registers a delegate as a redirector for the given script function.
    /// </summary>
    internal static void RegisterRedirector(
        Type targetClass,
        string targetMethodName,
        MethodInfo redirectMi,
        object? target = null
    )
    {
        // Prevent creation of invalid redirects
        if (!targetClass.IsSubclassOf(typeof(GameObject)))
        {
            throw new ArgumentException("Only methods of UClasses may be redirected!");
        }

        // Get the full path of the function (as originally declared).
        var targetFuncPath = StaticInit.GetDeclaringFuncPath(targetClass, targetMethodName);

        // Store the redirect for later use.
        var redirInfo = new RedirectorInfo(
            targetClass,
            redirectMi,
            redirectMi.IsStatic ? null : target);

        if (!s_redirectorDict.TryAdd(targetFuncPath, redirInfo))
        {
            // Disallow multiple redirectors on the same function.
            // NOTE: We've got an approach for solving this described in Loader.cs.
            throw new InvalidOperationException($"{targetFuncPath} has already been redirected!");
        }
    }

    public static void RegisterRedirector(
        Type targetClass,
        string targetMethodName,
        Delegate newDelegate
    )
    {
        MethodInfo mi;
        try
        {
            mi = newDelegate.Method;
        }
        catch (Exception e)
        {
            throw new InvalidOperationException("Redirected delegate is not a method!", e);
        }

        RegisterRedirector(targetClass, targetMethodName, mi, newDelegate.Target);
    }

    public static void RegisterRedirectors(Assembly asm)
    {
        foreach (var type in asm.GetTypes())
        {
            foreach (var func in type.GetMethods(RedirAttrSearchFlags))
            {
                var redirAttr = func.GetCustomAttribute<RedirectAttribute>();
                if (redirAttr == null)
                {
                    continue;
                }

                if (redirAttr.TargetType == null)
                {
                    Debug.LogWarning(
                        "Redirect definitions outside of ScriptComponents require an explicit type definition!",
                        skipSender: true);
                    continue;
                }

                RegisterRedirector(redirAttr.TargetType, redirAttr.TargetMethod, func);
            }
        }
    }

    internal static unsafe bool ExecuteRedirector(GameObject selfObj, Function funcObj, FFrame* stackPtr, IntPtr Result)
    {
        if (!TryGetRedirector(selfObj, funcObj, out var redirInfo))
        {
            return false;
        }

        var redirTarget = redirInfo.RedirectTarget;
        var redirMethod = redirInfo.RedirectMethod;

        // Gather (expected) managed types using the redirector, noting the artificial 'self' param.
        var argTypes = redirMethod
            .GetParameters()
            .Select(param => param.ParameterType)
            .Skip(funcObj.IsStatic ? 0 : 1)
            .ToArray();

        // Marshal args, add self as first arg if needed.
        var args = stackPtr->ParamsToManaged(argTypes).ToList();
        if (!funcObj.IsStatic)
        {
            args.Insert(0, selfObj);
        }

        var result = redirMethod.Invoke(redirTarget, args.ToArray());

        // Marshal result back (if non-void)
        if (result != null && redirMethod.ReturnType != null)
        {
            MarshalUtil.ToUnmanaged(result, Result, redirMethod.ReturnType);
        }

        return true;
    }

    /// <summary>
    /// Gets any redirections for the given function object, or returns false if none exist.
    /// </summary>
    internal static bool TryGetRedirector(
        GameObject obj,
        Function func,
        [MaybeNullWhen(false)] out RedirectorInfo redirectorInfo
    )
    {
        redirectorInfo = default;

        var funcPath = func.GetPathName();
        if (!s_redirectorDict.TryGetValue(funcPath, out var info))
        {
            return false;
        }

        if (!StaticInit.EnumerateSelfAndSupers(obj.GetType()).Contains(info.TargetClass))
        {
            return false;
        }

        redirectorInfo = info;
        return true;
    }
}
