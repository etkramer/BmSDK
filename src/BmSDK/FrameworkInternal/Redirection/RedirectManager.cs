using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace BmSDK.Framework.Redirection;

static class RedirectManager
{
    static readonly Dictionary<string, RedirectorInfo> s_redirectorDict = [];
    const BindingFlags GenericRedirSearchFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic;
    const BindingFlags GlobalRedirSearchFlags = BindingFlags.Static | GenericRedirSearchFlags;
    const BindingFlags LocalRedirSearchFlags = BindingFlags.Instance | GenericRedirSearchFlags;

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

    public static void RegisterGlobalRedirectors(Assembly asm)
    {
        foreach (var type in asm.GetTypes())
        {
            bool? isScriptComponent = null;

            foreach (var func in type.GetMethods(GlobalRedirSearchFlags))
            {
                var redirAttr = func.GetCustomAttribute<RedirectAttribute>();
                if (redirAttr == null)
                {
                    continue;
                }

                isScriptComponent ??= ScriptComponentManager.IsTypeAScriptComponent(type, out var attr, out var actorType);

                if (redirAttr.TargetType == null)
                {
                    if (isScriptComponent == true)
                    {
                        throw new ArgumentException(
                            $"{type.FullName}:{func.Name} is a static member" +
                            $"and cannot use the ScriptComponent's target type implicitly!");
                    }

                    throw new ArgumentException(
                        $"The redirect definition {type.FullName}:{func.Name} is " +
                        $"outside of a ScriptComponent and therefore requires an explicit type definition!");
                }

                if (isScriptComponent == true)
                {
                    Debug.LogWarning(
                        $"{type.FullName}:{func.Name} is a static member " +
                        $"and is interpreted as a global redirect! " +
                        $"The redirect applies even when the ScriptComponent is not attached.",
                        skipSender: true);
                }

                RegisterRedirector(redirAttr.TargetType, redirAttr.TargetMethod, func);
            }
        }
    }

    /// <summary>
    /// Stores local redirector methods defined on the specified ScriptComponent for use with the given target type.
    /// </summary>
    /// <remarks>If a redirector method's RedirectAttribute specifies a TargetType that is compatible with the
    /// targetType, a warning is logged indicating that TargetType is unnecessary and can be inferred. Only methods with
    /// RedirectAttribute are processed; others are ignored.</remarks>
    /// <param name="componentType">The type that contains methods to be registered as local redirectors.
    /// Should define methods annotated with RedirectAttribute.</param>
    /// <param name="targetType">The target type for which redirector methods are being registered.</param>
    /// <exception cref="ArgumentException">Thrown if the TargetType specified in a RedirectAttribute cannot be assigned from the provided targetType.</exception>
    public static void RegisterLocalRedirectors(Type componentType, Type targetType)
    {
        foreach (var func in componentType.GetMethods(LocalRedirSearchFlags))
        {
            var redirAttr = func.GetCustomAttribute<RedirectAttribute>();
            if (redirAttr == null)
            {
                continue;
            }

            if (redirAttr.TargetType != null)
            {
                if (redirAttr.TargetType.IsAssignableFrom(targetType))
                {
                    Debug.LogWarning(
                        $"{componentType.FullName}:{func.Name} defines TargetType in RedirectAttribute unnecessarily! " +
                        $"TargetType can be infered from ScriptComponent.",
                        skipSender: true);
                }
                else
                {
                    throw new ArgumentException(
                        $"{redirAttr.TargetType.Name} cannot be casted to {targetType.Name} " +
                        $"in {componentType.FullName}:{func.Name}!");
                }
            }

            // TODO: Implement registration
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
