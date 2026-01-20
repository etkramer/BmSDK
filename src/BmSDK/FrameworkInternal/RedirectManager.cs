using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace BmSDK.Framework;

public static class RedirectManager
{
    private static readonly Dictionary<string, RedirectorInfo> s_redirectorDict = [];

    public readonly record struct RedirectorInfo
    {
        public Class TargetClass { get; init; }

        public MethodInfo RedirectMethod { get; init; }

        public object? RedirectTarget { get; init; }
    }

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
        var redirInfo = new RedirectorInfo()
        {
            TargetClass = targetClass,
            RedirectMethod = newMethodInfo,
            RedirectTarget = newMethodInfo.IsStatic ? null : newDelegate.Target,
        };

        if (!s_redirectorDict.TryAdd(targetFuncPath, redirInfo))
        {
            // Disallow multiple redirectors on the same function.
            // NOTE: We've got an approach for solving this described in Loader.cs.
            throw new InvalidOperationException($"{targetFuncPath} has already been redirected!");
        }
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
            return false;

        if (info.TargetClass != obj.Class)
            return false;

        redirectorInfo = info;
        return true;
    }
}
