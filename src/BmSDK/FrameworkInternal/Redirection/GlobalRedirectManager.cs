using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace BmSDK.Framework.Redirection;

/// <summary>
/// A class managing the creation, retrieval, execution and deletion of detours to in-game functions.
/// The redirectors apply globally and unconditionally to all instances.
/// DO NOT INSTANTIATE! USE <see cref="RedirectManager.Global"/> INSTEAD.
/// </summary>
sealed class GlobalRedirectManager(BindingFlags genericRedirSearchFlags)
{
    /// <summary>
    /// Record storing data of a currently registered global redirect necessary to execute it.
    /// </summary>
    /// <param name="TargetType">Type that the redirect applies to</param>
    /// <param name="RedirectMethod">Method to call on redirect</param>
    /// <param name="RedirectTarget">Object to call <see cref="RedirectMethod"/> on</param>
    public record GlobalRedirectorInfo(Type TargetType, MethodInfo RedirectMethod, object? RedirectTarget);

    readonly BindingFlags _globalRedirSearchFlags = BindingFlags.Static | genericRedirSearchFlags;

    /// <summary>
    /// Maps declaring function paths to GlobalRedirectorInfo objects which contain
    /// the target class and the delegate of the detour.
    /// </summary>
    readonly Dictionary<string, GlobalRedirectorInfo> _globalRedirsDict = [];

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

        if (!_globalRedirsDict.TryAdd(declaringFuncPath, redirInfo))
        {
            // Disallow multiple global redirectors on the same function.
            throw new InvalidOperationException(
                $"{declaringFuncPath} has been redirected already. " +
                $"Cannot register {redirectMi.Name}.");
        }
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
    /// <param name="redirInfo">The object representing the registered global redirect.</param>
    /// <returns>True, if a redirector has been assigned to that declaring path
    /// and it applies to the given object; False, otherwise.</returns>
    public bool TryGetRedirector(
        GameObject obj,
        string funcPath,
        [MaybeNullWhen(false)] out GlobalRedirectorInfo redirInfo
    )
    {
        redirInfo = default;

        if (!_globalRedirsDict.TryGetValue(funcPath, out var info))
        {
            return false;
        }

        // Checks if the object inherits the function to redirect without overriding it
        if (!StaticInit.EnumerateSelfAndSupers(obj.GetType()).Contains(info.TargetType))
        {
            return false;
        }

        redirInfo = info;
        return true;
    }

    /// <summary>
    /// Executes a global redirect from its record instance and the data available in UObject::ProcessInternal().
    /// </summary>
    public unsafe void ExecuteRedirector(GlobalRedirectorInfo redirInfo, GameObject selfObj, Function funcObj, FFrame* stackPtr, IntPtr Result)
    {
        var redirTarget = redirInfo.RedirectTarget;
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
        var result = redirMethod.Invoke(redirTarget, args.ToArray());

        // Marshal result back (if non-void)
        if (result != null && redirMethod.ReturnType != null)
        {
            MarshalUtil.ToUnmanaged(result, Result, redirMethod.ReturnType);
        }
    }

    /// <summary>
    /// Clears the backing redirector dictionary, therefore, uninstalling all global redirects.
    /// </summary>
    public void UnregisterAll() => _globalRedirsDict.Clear();
}
