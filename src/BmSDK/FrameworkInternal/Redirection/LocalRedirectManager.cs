using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using BmSDK.Engine;

namespace BmSDK.Framework.Redirection;

/// <summary>
/// A class managing the creation, retrieval, execution and deletion of detours to in-game functions
/// which only apply to Actors with specific <see cref="ScriptComponent{TActor}"/>s attached.
/// DO NOT INSTANTIATE! USE <see cref="RedirectManager.Local"/> INSTEAD.
/// </summary>
sealed class LocalRedirectManager(BindingFlags genericRedirSearchFlags)
{
    /// <summary>
    /// Record storing data necessary to register local redirects when a ScriptComponent is attached.
    /// This is used to avoid unnecessary repeated reflection.
    /// </summary>
    /// <param name="TargetType">Type that the redirect applies to</param>
    /// <param name="FuncPath">The UE3 declaration path of the method to redirect.
    /// If the method is not defined in <see cref="TargetType"/>, path could lead to super.</param>
    /// <param name="RedirectMethod">Method to call on redirect</param>
    public record CachedLocalRedirector(Type TargetType, string FuncPath, MethodInfo RedirectMethod);
    /// <summary>
    /// Record storing data of a currently registered local redirect necessary to execute it.
    /// </summary>
    /// <param name="Component">The ScriptComponent that declares the redirect</param>
    /// <param name="RedirectMethod">Method to call on redirect</param>
    public record LocalRedirectorInfo(IScriptComponent Component, MethodInfo RedirectMethod);

    readonly BindingFlags _localRedirSearchFlags = BindingFlags.Instance | genericRedirSearchFlags;

    /// <summary>
    /// Maps ScriptComponent types to Lists of CachedLocalRedirector instances.
    /// One object is created per method marked with <see cref="ComponentRedirectAttribute"/>.
    /// This is done to reduce reflection on ScriptComponent attach.
    /// </summary>
    readonly Dictionary<Type, List<CachedLocalRedirector>> _cachedLocalRedirDefinitionDict = [];
    /// <summary>
    /// Maps pointers to target Actors and declaring function paths of redirected functions
    /// to LocalRedirectorInfo instances. This allows for per Actor/ScriptComponent function redirects.
    /// </summary>
    readonly Dictionary<(IntPtr ObjPtr, string FuncPath), LocalRedirectorInfo> _localRedirsDict = [];
    /// <summary>
    /// Maps ScriptComponents to Lists of keys for <see cref="_localRedirsDict"/>.
    /// This is used for cleanup inside of <see cref="Actor.DetachScriptComponentBase(IScriptComponent)"/>  
    /// </summary>
    readonly Dictionary<IScriptComponent, List<(IntPtr, string)>> _componentRedirsDict = [];

    /// <summary>
    /// Finds and stores component redirector methods defined on the specified ScriptComponent type.
    /// That's done by searching for methods with the <see cref="ComponentRedirectAttribute"/>.
    /// This method is used to prevent repeated reflection on ScriptComponent attachment.
    /// </summary>
    /// <param name="componentType">The type that contains methods to be registered as local redirectors.
    /// The function doesn't check if the type inherits ScriptComponent. One must do it on the call site.</param>
    /// <param name="targetType">The target type for which redirector methods are being registered.</param>
    /// <exception cref="InvalidOperationException">Thrown if the same ScriptComponent is cached twice.</exception>
    public void CacheRedirectors(Type componentType, Type targetType)
    {
        List<CachedLocalRedirector> redirectors = [];

        foreach (var func in componentType.GetMethods(_localRedirSearchFlags))
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

        if (!_cachedLocalRedirDefinitionDict.TryAdd(componentType, redirectors))
        {
            throw new InvalidOperationException("Tried to cache a ScriptComponent type's redirectors twice.");
        }
    }

    /// <summary>
    /// Registers one detoured function for a specific Actor.
    /// </summary>
    /// <param name="obj">The Actor to register the redirect for</param>
    /// <param name="funcPath">Path to the target declaring function</param>
    /// <param name="component">ScriptComponent that adds the redirectors to the Actor</param>
    /// <param name="redirMethod">MethodInfo of the detour function</param>
    /// <exception cref="InvalidOperationException">Thrown if the target Actor already contains
    /// a redirector for the declaring function path</exception>
    void RegisterRedirector(
        Actor obj,
        string funcPath,
        IScriptComponent component,
        MethodInfo redirMethod
    )
    {
        var key = (obj.Ptr, funcPath);
        var info = new LocalRedirectorInfo(component, redirMethod);

        // Track redirs per actor object
        if (!_localRedirsDict.TryAdd(key, info))
        {
            throw new InvalidOperationException(
                $"A redirector for {funcPath} " +
                $"is already registered for {obj.GetFullName()}");
        }

        // Track redirs per ScriptComponent instance for cleanup
        if (!_componentRedirsDict.TryGetValue(component, out var keys))
        {
            keys = [];
            _componentRedirsDict[component] = keys;
        }

        keys.Add(key);
    }

    /// <summary>
    /// Registers every redirect defined in the given ScriptComponent to its Owner.
    /// </summary>
    /// <param name="component">The ScriptComponent of which to register the
    /// local redirectors from.</param>
    public void RegisterComponentRedirectors(IScriptComponent component)
    {
        // Skip registration if no redirects defined
        if (!_cachedLocalRedirDefinitionDict.TryGetValue(component.GetType(), out var redirs))
        {
            return;
        }

        foreach (var redir in redirs)
        {
            RegisterRedirector(
                component.Owner,
                redir.FuncPath,
                component,
                redir.RedirectMethod
            );
        }
    }

    /// <summary>
    /// Gets any redirections for the given function path if it applies to the given GameObject.
    /// </summary>
    /// <param name="obj">Object to scan for redirect application</param>
    /// <param name="funcPath">The declaring path to look for</param>
    /// <param name="redirInfo">Object representing the registered local redirect</param>
    /// <returns>True, if a redirector has been assigned to that declaring path
    /// and it applies to the given object; false, otherwise</returns>
    public bool TryGetRedirector(
        GameObject obj,
        string funcPath,
        [MaybeNullWhen(false)] out LocalRedirectorInfo redirInfo
    )
    {
        redirInfo = default;

        var key = (obj.Ptr, funcPath);

        if (!_localRedirsDict.TryGetValue(key, out var info))
        {
            return false;
        }

        redirInfo = info;
        return true;
    }

    /// <summary>
    /// Executes a local redirect from its record instance and the data available in UObject::ProcessInternal().
    /// </summary>
    public unsafe void ExecuteRedirector(LocalRedirectorInfo localRedirInfo, GameObject selfObj, Function funcObj, FFrame* stackPtr, IntPtr Result)
    {
        var redirectMethod = localRedirInfo.RedirectMethod;
        var component = localRedirInfo.Component;

        var paramTypes = redirectMethod
            .GetParameters()
            .Select(param => param.ParameterType)
            .ToArray();

        var args = stackPtr->ParamsToManaged(paramTypes).ToArray();

        var result = redirectMethod.Invoke(component, args);

        if (result != null && redirectMethod.ReturnType != null)
        {
            MarshalUtil.ToUnmanaged(result, Result, redirectMethod.ReturnType);
        }
    }

    /// <summary>
    /// Unregisteres all redirects associated with a ScriptComponent and it's Owner.
    /// Used when ScriptComponents are detached.
    /// </summary>
    /// <param name="component">The ScriptComponent to unregister</param>
    public void UnregisterComponentRedirectors(IScriptComponent component)
    {
        if (!_componentRedirsDict.TryGetValue(component, out var keys))
        {
            return;
        }

        foreach (var key in keys)
        {
            _localRedirsDict.Remove(key);
        }

        _componentRedirsDict.Remove(component);
    }

    /// <summary>
    /// Clears the backing redirector dictionaries, therefore, uninstalling all local redirects.
    /// </summary>
    public void UnregisterAll()
    {
        _cachedLocalRedirDefinitionDict.Clear();
        _localRedirsDict.Clear();
        _componentRedirsDict.Clear();
    }
}
