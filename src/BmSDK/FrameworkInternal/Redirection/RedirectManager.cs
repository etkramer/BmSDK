using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace BmSDK.Framework.Redirection;

static class RedirectManager
{
    static readonly Dictionary<string, RedirectorInfo> s_redirectorDict = [];

    internal static void UnregisterAllRedirectors()
        => s_redirectorDict.Clear();

    /// <summary>
    /// Registers a delegate as a redirector for the given script function.
    /// </summary>
    internal static void RegisterRedirector(
        Class targetClass,
        string targetMethodName,
        Delegate newDelegate
    )
    {
        Class declaringClass = targetClass;
        {
            // To replace a method on a non-declaring subclass, we need to find the actual
            // declaring class name. So we enumerate all supers until we find the first class that declares our function.
            declaringClass = Guard.NotNull(
                targetClass
                    .EnumerateSupersAndSelf()
                    .OfType<Class>()
                    .FirstOrDefault(super =>
                        super
                            .EnumerateFields()
                            .Any(field => field.Name.ToString() == targetMethodName)
                    ),
                $"Couldn't find declaring class for method {targetMethodName}!"
            );
        }

        // Get the full path of the function (as originally declared).
        var targetFuncPath = $"{declaringClass.GetPathName()}:{targetMethodName}";

        // Get the delegate's MethodInfo.
        MethodInfo newMethodInfo;
        try
        {
            newMethodInfo = newDelegate.Method;
        }
        catch (Exception e)
        {
            throw new InvalidOperationException("Redirected delegate is not a method!", e);
        }

        // Store the redirect for later use.
        var redirInfo = new RedirectorInfo(
            targetClass,
            newMethodInfo,
            newMethodInfo.IsStatic ? null : newDelegate.Target);

        if (!s_redirectorDict.TryAdd(targetFuncPath, redirInfo))
        {
            // Disallow multiple redirectors on the same function.
            // NOTE: We've got an approach for solving this described in Loader.cs.
            throw new InvalidOperationException($"{targetFuncPath} has already been redirected!");
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

        if (!obj.Class.EnumerateSupersAndSelf().Contains(info.TargetClass))
        {
            return false;
        }

        redirectorInfo = info;
        return true;
    }
}
