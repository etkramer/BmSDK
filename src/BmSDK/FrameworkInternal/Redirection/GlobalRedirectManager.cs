using System.Reflection;

namespace BmSDK.Framework.Redirection;

/// <summary>
/// A class managing the creation, retrieval, execution and deletion of detours to in-game functions.
/// The redirectors apply globally and unconditionally to all instances.
/// DO NOT INSTANTIATE! USE <see cref="RedirectManager.Global"/> INSTEAD.
/// </summary>
sealed class GlobalRedirectManager(BindingFlags genericRedirSearchFlags)
{
    readonly BindingFlags _globalRedirSearchFlags = BindingFlags.Static | genericRedirSearchFlags;

    /// <summary>
    /// Maps declaring function paths to GlobalRedirectorInfo objects which contain
    /// the target class and the delegate of the detour.
    /// </summary>
    readonly Dictionary<string, List<GlobalRedirectorInfo>> _globalRedirsDict = [];

    /// <summary>
    /// Registers a delegate as a redirector for the given in-game function.
    /// </summary>
    /// <param name="targetType">The type of the in-game class to override</param>
    /// <param name="targetMethodName">The name of the target method to override.</param>
    /// <param name="redirectMi">The MethodInfo of the custom detour.</param>
    /// <param name="target">The object to call the custom delegate on.
    /// May be null if the redirect is static.</param>
    /// <exception cref="ArgumentException">Thrown if the target class does not inherit GameObject.
    /// Only methods of in-game classes may be overriden.</exception>
    /// <exception cref="InvalidOperationException">Thrown if the specific declaring function path
    /// already contains a redirect. You may have multiple redirects of the same method name
    /// as long as they're different definitions.</exception>
    public void RegisterRedirector(
        Type targetType,
        string targetMethodName,
        MethodInfo redirectMi,
        object? target = null
    )
    {
        // Prevent creation of invalid redirects
        if (!targetType.IsAssignableTo(typeof(GameObject)))
        {
            throw new ArgumentException(
                $"{targetType.FullName} is not a managed type of" +
                $"an in-game unmanaged type and cannot be redirected.");
        }

        // Get the full path of the function (as originally declared).
        var declaringFuncPath = StaticInit.GetDeclaringFuncPath(targetType, targetMethodName);

        // Store the redirect for later use.
        var redirInfo = new GlobalRedirectorInfo(
            targetType,
            redirectMi,
            redirectMi.IsStatic ? null : target
        );

        // Add new redirect to the target function's redirect list
        if (!_globalRedirsDict.TryGetValue(declaringFuncPath, out var redirects))
        {
            redirects = [];
            _globalRedirsDict[declaringFuncPath] = redirects;
        }

        if (redirects.Contains(redirInfo))
        {
            throw new InvalidOperationException(
                $"{redirInfo} has already been registered once" +
                $"on {declaringFuncPath}!");
        }

        redirects.Add(redirInfo);
    }

    /// <summary>
    /// Registers all functions marked with a <see cref="RedirectAttribute"/> in a given assembly.
    /// </summary>
    /// <param name="asm">The assembly to scan.</param>
    public void RegisterRedirectors(Assembly asm)
    {
        foreach (var type in asm.GetTypes())
        {
            foreach (var func in type.GetMethods(_globalRedirSearchFlags))
            {
                var redirAttr = func.GetCustomAttribute<RedirectAttribute>();
                if (redirAttr == null)
                {
                    continue;
                }

                RegisterRedirector(redirAttr.TargetType, redirAttr.TargetMethod, func);
            }
        }
    }

    /// <summary>
    /// Gets any redirections for the given function path if it applies to the given GameObject.
    /// </summary>
    /// <param name="obj">The object to scan for redirect application.</param>
    /// <param name="funcPath">The declaring path to look for.</param>
    /// <returns>Objects representing the registered global redirects.
    /// The collection may be empty if there are no redircts.</returns>
    public IEnumerable<GlobalRedirectorInfo> GetRedirectors(GameObject obj, string funcPath)
    {
        if (!_globalRedirsDict.TryGetValue(funcPath, out var infos) || infos.Count == 0)
        {
            return [];
        }

        var targetTypes = StaticInit.EnumerateSelfAndSupers(obj.GetType());
        var result = infos.Where(info => targetTypes.Contains(info.TargetType));
        if (!result.Any())
        {
            return [];
        }

        return result;
    }

    /// <summary>
    /// Executes a global redirect from its record instance and the data available in UObject::ProcessInternal().
    /// </summary>
    public unsafe void ExecuteRedirector(GlobalRedirectorInfo redirInfo, GameObject selfObj, Function funcObj, FFrame* stackPtr, IntPtr Result)
    {
        var redirMethod = redirInfo.RedirectMethod;

        // Gather (expected) managed types using the redirector, noting the artificial 'self' param.
        var paramTypes = redirMethod
            .GetParameters()
            .Select(param => param.ParameterType)
            .Skip(funcObj.IsStatic ? 0 : 1)
            .ToArray();

        // Marshal args, add self as first arg if needed.
        var args = stackPtr->ParamsToManaged(paramTypes).ToList();
        if (!funcObj.IsStatic)
        {
            args.Insert(0, selfObj);
        }

        // Execute detour
        var result = redirInfo.Invoker.Invoke(
            redirInfo.RedirectTarget,
            args.ToArray());

        // Marshal result back (if non-void)
        if (result != null && redirMethod.ReturnType != typeof(void))
        {
            MarshalUtil.ToUnmanaged(result, Result, redirMethod.ReturnType);
        }
    }

    /// <summary>
    /// Clears the backing redirector dictionary, therefore, uninstalling all global redirects.
    /// </summary>
    public void UnregisterAll() => _globalRedirsDict.Clear();
}
