using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace BmSDK.Framework;

/// <summary>
/// Manages function redirectors for ScriptComponents.
/// </summary>
public static class RedirectManager
{
    /// <summary>
    /// Stores redirectors by (object pointer, function path) pairs.
    /// </summary>
    static readonly Dictionary<(IntPtr ObjPtr, string FuncPath), RedirectorInfo> s_redirectorDict = [];

    /// <summary>
    /// Tracks which components have registered redirectors, for cleanup.
    /// Maps component instance to the list of keys it registered.
    /// </summary>
    static readonly Dictionary<ScriptComponent, List<(IntPtr, string)>> s_componentRedirectors = [];

    /// <summary>
    /// Tracks component types that should be auto-attached to actors of specific classes.
    /// Maps target class name to the component types to attach.
    /// </summary>
    static readonly Dictionary<string, List<Type>> s_autoAttachTypes = [];

    public readonly record struct RedirectorInfo
    {
        public ScriptComponent Component { get; init; }
        public MethodInfo RedirectMethod { get; init; }
    }

    internal static void UnregisterAllRedirectors()
    {
        s_redirectorDict.Clear();
        s_componentRedirectors.Clear();
        s_autoAttachTypes.Clear();
    }

    /// <summary>
    /// Registers a component type for auto-attachment to actors of the specified class.
    /// </summary>
    internal static void RegisterAutoAttachType(Type componentType, Class targetClass)
    {
        var className = targetClass.GetPathName();
        if (!s_autoAttachTypes.TryGetValue(className, out var types))
        {
            types = [];
            s_autoAttachTypes[className] = types;
        }

        if (!types.Contains(componentType))
        {
            types.Add(componentType);
        }
    }

    /// <summary>
    /// Gets component types that should be auto-attached to the given actor class.
    /// Checks the actor's class and all super classes.
    /// </summary>
    internal static IEnumerable<Type> GetAutoAttachTypesForActor(Class actorClass)
    {
        foreach (var cls in actorClass.EnumerateSupersAndSelf().OfType<Class>())
        {
            var className = cls.GetPathName();
            if (s_autoAttachTypes.TryGetValue(className, out var types))
            {
                foreach (var type in types)
                {
                    yield return type;
                }
            }
        }
    }

    /// <summary>
    /// Checks if there are any auto-attach registrations.
    /// </summary>
    internal static bool HasAutoAttachTypes() => s_autoAttachTypes.Count > 0;

    /// <summary>
    /// Registers a redirector for a specific object and function.
    /// </summary>
    internal static void RegisterComponentRedirector(
        GameObject obj,
        string funcPath,
        ScriptComponent component,
        MethodInfo redirectMethod
    )
    {
        var key = (obj.Ptr, funcPath);

        var info = new RedirectorInfo
        {
            Component = component,
            RedirectMethod = redirectMethod
        };

        if (!s_redirectorDict.TryAdd(key, info))
        {
            throw new InvalidOperationException(
                $"A redirector for {funcPath} is already registered on this object!"
            );
        }

        // Track which keys this component registered
        if (!s_componentRedirectors.TryGetValue(component, out var keys))
        {
            keys = [];
            s_componentRedirectors[component] = keys;
        }
        keys.Add(key);
    }

    /// <summary>
    /// Unregisters all redirectors associated with the given component.
    /// </summary>
    internal static void UnregisterComponentRedirectors(ScriptComponent component)
    {
        if (!s_componentRedirectors.TryGetValue(component, out var keys))
        {
            return;
        }

        foreach (var key in keys)
        {
            s_redirectorDict.Remove(key);
        }

        s_componentRedirectors.Remove(component);
    }

    /// <summary>
    /// Gets any redirections for the given object and function, or returns false if none exist.
    /// </summary>
    internal static bool TryGetRedirector(
        GameObject obj,
        Function func,
        [MaybeNullWhen(false)] out RedirectorInfo redirectorInfo
    )
    {
        redirectorInfo = default;

        var funcPath = func.GetPathName();
        var key = (obj.Ptr, funcPath);

        if (!s_redirectorDict.TryGetValue(key, out var info))
        {
            return false;
        }

        redirectorInfo = info;
        return true;
    }

    /// <summary>
    /// Resolves the declaring function path for the given class and method name.
    /// Traverses the class hierarchy to find where the method is actually defined.
    /// </summary>
    internal static string GetDeclaringFuncPath(Class targetClass, string targetMethodName)
    {
        var declaringClass = Guard.NotNull(
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

        return $"{declaringClass.GetPathName()}:{targetMethodName}";
    }
}
