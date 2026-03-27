using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using BmSDK.Framework.Redirection;
using MoreLinq;

namespace BmSDK.Framework;

/// <summary>
/// Manages the registration of auto-attach types and the mass unloading of ScriptComponents.
/// </summary>
/// <seealso cref="GameObject"/>
internal static class ScriptComponentManager
{
    /// <summary>
    /// Stores data about a ScriptComponent type that should be attached when a
    /// UObject is instantiated.
    /// </summary>
    /// <param name="Component">The component type to auto-atach</param>
    /// <param name="AllowSubtypes">Whether the component should be attached to children
    /// of the target class or only the exact class</param>
    private readonly record struct CachedAutoAttachComponent(Type Component, bool AllowSubtypes);

    /// <summary>
    /// Maps UObject types to Lists of ScriptComponents that will auto-attach.
    /// Populated by <see cref="RegisterAutoAttachType(Type, Type, bool)"/> and used by
    /// <see cref="TryAutoAttachComponents(GameObject, bool)"/> and <see cref="AutoAttachTypesToExistingObjs"/>
    /// </summary>
    private static readonly Dictionary<Type, List<CachedAutoAttachComponent>> s_autoAttachTypes =
    [];

    /// <summary>
    /// Registers all <see cref="ScriptComponent"/>s in the specified assembly that are marked with
    /// a ScriptComponentAttribute: This means that local redirectors are created and auto-attachment
    /// is registered if enabled.
    /// </summary>
    public static void RegisterTypes(Assembly asm)
    {
        foreach (var componentType in asm.GetTypes())
        {
            if (!IsTypeAScriptComponent(componentType, out var attribute, out var objType))
            {
                continue;
            }

            RedirectManager.Local.CacheRedirectors(componentType, objType);

            if (attribute.AutoAttach)
            {
                RegisterAutoAttachType(componentType, objType, attribute.AllowSubtypes);
            }
        }
    }

    /// <summary>
    /// Determines whether the specified type represents a valid script component
    /// and retrieves its associated attribute and UObject type.
    /// </summary>
    /// <param name="type">The type to evaluate for script component eligibility</param>
    /// <param name="attribute">Attribute associated with the ScriptComponent.
    /// <see langword="null"/> if the type is not a ScriptComponent.</param>
    /// <param name="objType">UObject type the ScriptComponent applies to.
    /// <see langword="null"/> if the type is not a ScriptComponent.</param>
    /// <returns>Whether <paramref name="type"/> is a valid ScriptComponent</returns>
    private static bool IsTypeAScriptComponent(
        Type type,
        [MaybeNullWhen(false)] out ScriptComponentAttribute attribute,
        [MaybeNullWhen(false)] out Type objType
    )
    {
        attribute = null;
        objType = null;

        if (!type.IsClass || type.IsAbstract)
        {
            return false;
        }

        attribute = type.GetCustomAttribute<ScriptComponentAttribute>();
        if (attribute == null)
        {
            return false;
        }

        objType = TryGetComponentTargetType(type);
        if (objType == null)
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// Retrieves the type argument used for the <see cref="ScriptComponent{TClass}"/> base class of the given type.
    /// </summary>
    /// <param name="type">The type whose inheritance hierarchy is searched for a ScriptComponent base class.</param>
    /// <returns>The type argument of the nearest ScriptComponent base class if found; otherwise, null.</returns>
    private static Type? TryGetComponentTargetType(Type type)
    {
        for (var cur = type.BaseType; cur != null; cur = cur.BaseType)
        {
            if (!cur.IsGenericType)
            {
                continue;
            }

            if (cur.GetGenericTypeDefinition() != typeof(ScriptComponent<>))
            {
                continue;
            }

            return cur.GetGenericArguments()[0];
        }

        return null;
    }

    /// <summary>
    /// Registers a <see cref="ScriptComponent"/> type to be automatically attached to
    /// instances of a specified UObject class, when they are created.
    /// </summary>
    /// <param name="componentType">The type of the script component to register for automatic attachment.
    /// Must derive from ScriptComponent.</param>
    /// <param name="targetClass">The UObject type which the component will be automatically attached to.
    /// Must derive from UObject.</param>
    /// <param name="allowSubtypes">Flag whether the component should auto-attach to
    /// child classes of <paramref name="targetClass"/>.</param>
    private static void RegisterAutoAttachType(
        Type componentType,
        Type targetClass,
        bool allowSubtypes
    )
    {
        // We can't auto instantiate generic types
        if (componentType.IsGenericType)
        {
            throw new ArgumentException(
                $"ScriptComponents with generic type parameters "
                    + $"cannot use AutoAttach: {componentType.FullName}"
            );
        }

        // We need a default constructor to auto instantiate
        if (componentType.GetConstructor(Type.EmptyTypes) == null)
        {
            throw new ArgumentException(
                $"ScriptComponents without a public, parameterless constructor "
                    + $"cannot use AutoAttach: {componentType.FullName}"
            );
        }

        // Warning for backwards compatibility
        if (componentType.IsAssignableTo(typeof(ScriptComponent)))
        {
            Debug.LogWarning(
                $"{componentType.FullName} enables AutoAttach and inherits ScriptComponent.\n"
                    + $"This means implicitly that the component will auto-attach to ALL actors.\n"
                    + $"Extend ScriptComponent<Actor> to hide this warning if this behavior is intended!",
                skipSender: true
            );
        }

        if (!s_autoAttachTypes.TryGetValue(targetClass, out var types))
        {
            types = [];
            s_autoAttachTypes[targetClass] = types;
        }

        var cachedComponent = new CachedAutoAttachComponent(componentType, allowSubtypes);

        if (!types.Contains(cachedComponent))
        {
            types.Add(cachedComponent);
        }
    }

    /// <summary>
    /// Determines whether any auto-attach <see cref="ScriptComponent"/> are currently registered.
    /// </summary>
    public static bool HasAutoAttachTypes() => s_autoAttachTypes.Count > 0;

    /// <summary>
    /// Retrieves all <see cref="ScriptComponent"/> types that are automatically
    /// attached to the specified UObject type and its base classes.
    /// </summary>
    /// <param name="objType">The type for which to retrieve auto-attached component types.
    /// Should derive from <see cref="GameObject"/>.</param>
    private static IEnumerable<Type> GetAutoAttachTypesByObjType(Type objType)
    {
        foreach (var super in StaticInit.EnumerateSelfAndSupers(objType))
        {
            if (s_autoAttachTypes.TryGetValue(super, out var cachedTypes))
            {
                foreach (var type in cachedTypes)
                {
                    if (!type.AllowSubtypes && super != objType)
                    {
                        continue;
                    }

                    yield return type.Component;
                }
            }

            if (super == typeof(GameObject))
            {
                break;
            }
        }
    }

    /// <inheritdoc cref="GetAutoAttachTypesByObjType(Type)"/>
    /// <param name="obj">The object of whose class to scan for auto-attach components.</param>
    private static IEnumerable<Type> GetAutoAttachTypesByObj(GameObject obj) =>
        GetAutoAttachTypesByObjType(obj.GetType());

    /// <summary>
    /// Attempts to auto-attach eligible script components to the specified UObject
    /// if they are not already present.
    /// </summary>
    public static void TryAutoAttachComponents(GameObject obj, bool objNotLoaded)
    {
        if (objNotLoaded)
        {
            if (obj.ObjectFlags.HasFlag(GameObject.EObjectFlags.RF_NeedLoad))
            {
                return;
            }
        }

        var componentTypes = GetAutoAttachTypesByObj(obj);

        foreach (var componentType in componentTypes)
        {
            if (!obj.HasScriptComponent(componentType))
            {
                try
                {
                    obj.AttachScriptComponent(componentType);
                }
                catch (Exception e)
                {
                    Debug.LogError(
                        $"Failed to auto-attach {componentType.Name} to '{obj.GetFullName()}': \n{e.Message}",
                        skipSender: true
                    );
                }
            }
        }
    }

    /// <summary>
    /// Automatically attaches eligible component types to all existing UObjects.
    /// </summary>
    public static void AutoAttachTypesToExistingObjs()
    {
        if (!HasAutoAttachTypes())
        {
            return;
        }

        foreach (var obj in GameObject.FindObjectsSlow<GameObject>())
        {
            // Skip GC'd objects
            if (!obj.IsValid)
            {
                continue;
            }

            // Skip the Class Default Object (CDO)
            if (obj == obj.Class.DefaultObject)
            {
                continue;
            }

            TryAutoAttachComponents(obj, objNotLoaded: false);
        }
    }

    /// <summary>
    /// Unregisters all <see cref="ScriptComponent"/>s and clears all auto-attachment type registrations.
    /// </summary>
    public static void UnregisterAll()
    {
        // Stop auto attchment of script components
        s_autoAttachTypes.Clear();

        // Detach all existing script components and local redirectors
        GameObject.AllScriptComponents.ToArray().ForEach(component => component.Detach());
    }
}
