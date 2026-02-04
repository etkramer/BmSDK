using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using BmSDK.Engine;

namespace BmSDK.Framework.Redirection;

static class RedirectManager
{
    static readonly Dictionary<string, GlobalRedirectorInfo> s_globalRedirsDict = [];

    static readonly Dictionary<Type, List<CachedLocalRedirector>> s_cachedLocalRedirDefinitionDict = [];
    static readonly Dictionary<(IntPtr ObjPtr, string FuncPath), LocalRedirectorInfo> s_localRedirsDict = [];
    static readonly Dictionary<IScriptComponent, List<(IntPtr, string)>> s_componentRedirsDict = [];

    const BindingFlags GenericRedirSearchFlags = BindingFlags.Public | BindingFlags.NonPublic;
    const BindingFlags LocalRedirSearchFlags = BindingFlags.Instance | GenericRedirSearchFlags;
    const BindingFlags GlobalRedirSearchFlags = BindingFlags.Static | BindingFlags.DeclaredOnly | GenericRedirSearchFlags;

    internal static void UnregisterAll()
    {
        s_globalRedirsDict.Clear();

        s_cachedLocalRedirDefinitionDict.Clear();
        s_localRedirsDict.Clear();
        s_componentRedirsDict.Clear();
    }

    public static void UnregisterComponentRedirectors(IScriptComponent component)
    {
        if (!s_componentRedirsDict.TryGetValue(component, out var keys))
        {
            return;
        }

        foreach (var key in keys)
        {
            s_localRedirsDict.Remove(key);
        }

        s_componentRedirsDict.Remove(component);
    }

    public static void RegisterLocalRedirector(
        Actor obj,
        string funcPath,
        IScriptComponent component,
        MethodInfo redirMethod
    )
    {
        var key = (obj.Ptr, funcPath);

        var info = new LocalRedirectorInfo(component, redirMethod);

        // Track redirs per actor object
        if (!s_localRedirsDict.TryAdd(key, info))
        {
            throw new InvalidOperationException(
                $"A redirector for {funcPath} " +
                $"is already registerd for {obj.GetFullName()}");
        }

        // Track redirs per ScriptComponent instance
        if (!s_componentRedirsDict.TryGetValue(component, out var keys))
        {
            keys = [];
            s_componentRedirsDict[component] = keys;
        }

        keys.Add(key);
    }

    /// <summary>
    /// Registers a delegate as a redirector for the given script function.
    /// </summary>
    internal static void RegisterGlobalRedirector(
        Type targetClass,
        string targetMethodName,
        MethodInfo redirectMi,
        object? target = null
    )
    {
        // Prevent creation of invalid redirects
        if (!targetClass.IsAssignableTo(typeof(GameObject)))
        {
            throw new ArgumentException(
                $"{targetClass.FullName}:{targetMethodName} does not " +
                $"inherit from GameObject and cannot be redirected!");
        }

        // Get the full path of the function (as originally declared).
        var targetFuncPath = StaticInit.GetDeclaringFuncPath(targetClass, targetMethodName);

        // Store the redirect for later use.
        var redirInfo = new GlobalRedirectorInfo(
            targetClass,
            redirectMi,
            redirectMi.IsStatic ? null : target);

        if (!s_globalRedirsDict.TryAdd(targetFuncPath, redirInfo))
        {
            // Disallow multiple redirectors on the same function.
            // NOTE: We've got an approach for solving this described in Loader.cs.
            throw new InvalidOperationException($"{targetFuncPath} has already been redirected!");
        }
    }

    public static void RegisterGlobalRedirector(
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

        RegisterGlobalRedirector(targetClass, targetMethodName, mi, newDelegate.Target);
    }

    public static void RegisterGlobalRedirectors(Assembly asm)
    {
        foreach (var type in asm.GetTypes())
        {
            foreach (var func in type.GetMethods(GlobalRedirSearchFlags))
            {
                var redirAttr = func.GetCustomAttribute<RedirectAttribute>();
                if (redirAttr == null)
                {
                    continue;
                }

                RegisterGlobalRedirector(redirAttr.TargetType, redirAttr.TargetMethod, func);
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
    public static void CacheLocalRedirectors(Type componentType, Type targetType)
    {
        List<CachedLocalRedirector> redirectors = [];

        foreach (var func in componentType.GetMethods(LocalRedirSearchFlags))
        {
            var redirAttr = func.GetCustomAttribute<ComponentRedirectAttribute>();
            if (redirAttr == null)
            {
                continue;
            }

            var targetFuncPath = StaticInit.GetDeclaringFuncPath(targetType, redirAttr.TargetMethod);

            redirectors.Add(new(targetType, targetFuncPath, func));
        }

        if (redirectors.Count == 0)
        {
            return;
        }

        if (!s_cachedLocalRedirDefinitionDict.TryAdd(componentType, redirectors))
        {
            throw new InvalidOperationException("Tried to cache a ScriptComponent type's redirectors twice!");
        }
    }

    public static void RegisterLocalRedirectors(IScriptComponent component)
    {
        // Skip registration if no redirects defined
        if (!s_cachedLocalRedirDefinitionDict.TryGetValue(component.GetType(), out var redirs))
        {
            return;
        }

        foreach (var redir in redirs)
        {
            RegisterLocalRedirector(
                component.Owner,
                redir.FuncPath,
                component,
                redir.Redirector
            );
        }
    }

    internal static unsafe bool ExecuteRedirector(GameObject selfObj, Function funcObj, FFrame* stackPtr, IntPtr Result)
    {
        var funcPath = funcObj.GetPathName();

        if (TryGetLocalRedirector(selfObj, funcPath, out var localRedirInfo))
        {
            ExecuteLocalRedirector(localRedirInfo, selfObj, funcObj, stackPtr, Result);
            return true;
        }
        else if (TryGetGlobalRedirector(selfObj, funcPath, out var globalRedirInfo))
        {
            ExecuteGlobalRedirector(globalRedirInfo, selfObj, funcObj, stackPtr, Result);
            return true;
        }
        else
        {
            return false;
        }
    }

    static unsafe void ExecuteLocalRedirector(LocalRedirectorInfo localRedirInfo, GameObject selfObj, Function funcObj, FFrame* stackPtr, IntPtr Result)
    {
        var redirectMethod = localRedirInfo.RedirectMethod;
        var component = localRedirInfo.Component;

        var argTypes = redirectMethod
            .GetParameters()
            .Select(p => p.ParameterType)
            .ToArray();

        var args = stackPtr->ParamsToManaged(argTypes).ToArray();

        var result = redirectMethod.Invoke(component, args);

        if (result != null && redirectMethod != null)
        {
            MarshalUtil.ToUnmanaged(result, Result, redirectMethod.ReturnType);
        }
    }

    static unsafe void ExecuteGlobalRedirector(GlobalRedirectorInfo redirInfo, GameObject selfObj, Function funcObj, FFrame* stackPtr, IntPtr Result)
    {
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
    }

    public static bool TryGetLocalRedirector(
        GameObject obj,
        string funcPath,
        [MaybeNullWhen(false)] out LocalRedirectorInfo redirInfo
    )
    {
        redirInfo = null;

        var key = (obj.Ptr, funcPath);

        if (!s_localRedirsDict.TryGetValue(key, out var info))
        {
            return false;
        }

        redirInfo = info;
        return true;
    }

    /// <summary>
    /// Gets any redirections for the given function object, or returns false if none exist.
    /// </summary>
    public static bool TryGetGlobalRedirector(
        GameObject obj,
        string funcPath,
        [MaybeNullWhen(false)] out GlobalRedirectorInfo redirectorInfo
    )
    {
        redirectorInfo = default;

        if (!s_globalRedirsDict.TryGetValue(funcPath, out var info))
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
