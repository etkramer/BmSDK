using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using BmSDK.Engine;
using BmSDK.Framework.Redirection;
using MoreLinq;

namespace BmSDK.Framework;

/// <summary>
/// Manages the registration of auto-attach types and the mass unloading of ScriptComponents.
/// </summary>
/// <seealso cref="Actor"/>
static class ScriptComponentManager
{
    /// <summary>
    /// Stores data about a ScriptComponent type that should be attached when an
    /// actor of a target type runs it's <see cref="Actor.PostBeginPlay"/>.
    /// </summary>
    /// <param name="Component">The component type to auto-atach</param>
    /// <param name="AllowSubtypes">Whether the component should be attached to children
    /// of the target class or only the exact class</param>
    readonly record struct CachedAutoAttachComponent(Type Component, bool AllowSubtypes);

    /// <summary>
    /// Maps Actor types to Lists of ScriptComponents that will auto-attach.
    /// Populated by <see cref="RegisterAutoAttachType(Type, Type, bool)"/> and used by
    /// <see cref="TryAutoAttachComponents(Actor)"/> and <see cref="AutoAttachTypesToExistingActors"/>
    /// </summary>
    static readonly Dictionary<Type, List<CachedAutoAttachComponent>> s_autoAttachTypes = [];

    /// <summary>
    /// Unregisters all <see cref="ScriptComponent"/>s and clears all auto-attachment type registrations.
    /// </summary>
    /// <remarks>This method detaches all registered script components and removes their associations both
    /// in the static and non-static lists. After calling this method, no script components remain registered,
    /// and auto-attachment of script components is disabled until new types are registered.</remarks>
    public static void UnregisterAll()
    {
        // Stop auto attchment of script components
        s_autoAttachTypes.Clear();

        // Detach all existing script components and local redirectors
        Actor.AllScriptComponents.ToArray().ForEach(component => component.Detach());
    }

    /// <summary>
    /// Determines whether any auto-attach <see cref="ScriptComponent"/> are currently registered.
    /// </summary>
    /// <returns><see langword="true"/> if one or more auto-attach types are registered; otherwise, <see langword="false"/>.</returns>
    public static bool HasAutoAttachTypes() => s_autoAttachTypes.Count > 0;

    /// <summary>
    /// Registers a <see cref="ScriptComponent"/> type to be automatically attached to
    /// instances of a specified actor class, when they are created.
    /// </summary>
    /// <param name="componentType">The type of the script component to register for automatic attachment. Must derive from ScriptComponent.</param>
    /// <param name="targetClass">The actor class type which the component will be automatically attached to. Must derive from Actor.</param>
    /// <param name="allowSubtypes">Flag whether the component should auto-attach to
    /// subtypes of <paramref name="targetClass"/>.</param>
    public static void RegisterAutoAttachType(Type componentType, Type targetClass, bool allowSubtypes)
    {
        // We need a default constructor so we can't auto instantiate generic types
        if (componentType.IsGenericType)
        {
            throw new ArgumentException(
                $"ScriptComponents with generic type parameters " +
                $"cannot use AutoAttach: {componentType.FullName}");
        }

        if (componentType.IsAssignableTo(typeof(ScriptComponent)))
        {
            Debug.LogWarning(
                $"{componentType.FullName} enables AutoAttach and inherits ScriptComponent.\n" +
                $"This means implicitly that the component will auto-attach to ALL actors.\n" +
                $"Extend ScriptComponent<Actor> to hide this warning if this behavior is intended!",
                skipSender: true);
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
    /// Registers all <see cref="ScriptComponent"/>s in the specified assembly that are marked with
    /// a ScriptComponentAttribute: This means that local redirectors are created and auto-attachment
    /// is registered if enabled.
    /// </summary>
    /// <param name="asm">The assembly to scan for types eligible for automatic attachment. Cannot be null.</param>
    public static void RegisterTypes(Assembly asm)
    {
        foreach (var type in asm.GetTypes())
        {
            if (!IsTypeAScriptComponent(type, out var attribute, out var actorType))
            {
                continue;
            }

            RedirectManager.Local.CacheRedirectors(type, actorType);

            if (attribute.AutoAttach)
            {
                RegisterAutoAttachType(type, actorType, attribute.AllowSubtypes);
            }
        }
    }

    /// <summary>
    /// Determines whether the specified type represents a valid script component and retrieves its associated attribute
    /// and actor type if available.
    /// </summary>
    /// <remarks>This method checks for the presence of the <see cref="ScriptComponentAttribute"/> and a valid
    /// actor type on the specified type. The type must be a concrete, non-generic class to be considered a script
    /// component.</remarks>
    /// <param name="type">The type to evaluate for script component eligibility.</param>
    /// <param name="attribute">When this method returns, contains the <see cref="ScriptComponentAttribute"/> applied to the type if it is a
    /// script component; otherwise, <see langword="null"/>.</param>
    /// <param name="actorType">When this method returns, contains the actor type associated with the script component if available; otherwise,
    /// <see langword="null"/>.</param>
    /// <returns>true if the specified type is a valid script component and both the attribute and actor type are found;
    /// otherwise, false.</returns>
    public static bool IsTypeAScriptComponent(
        Type type,
        [MaybeNullWhen(false)] out ScriptComponentAttribute attribute,
        [MaybeNullWhen(false)] out Type actorType
    )
    {
        attribute = null;
        actorType = null;

        if (!type.IsClass || type.IsAbstract)
        {
            return false;
        }

        attribute = type.GetCustomAttribute<ScriptComponentAttribute>();
        if (attribute == null)
        {
            return false;
        }

        actorType = TryGetComponentActorType(type);
        if (actorType == null)
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// Retrieves the type argument used for the <see cref="ScriptComponent{TActor}"/> base class of the given type.
    /// </summary>
    /// <param name="type">The type whose inheritance hierarchy is searched for a ScriptComponent base class.</param>
    /// <returns>The type argument of the nearest ScriptComponent base class if found; otherwise, null.</returns>
    public static Type? TryGetComponentActorType(Type type)
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
    /// Retrieves all <see cref="ScriptComponent"/> types that are automatically attached to the specified actor class and its base classes.
    /// </summary>
    /// <param name="actorClass">The type of the actor for which to retrieve auto-attached component types. Must derive from <see cref="Actor"/>.</param>
    /// <returns>An enumerable collection of <see cref="Type"/> objects representing the component types that are automatically
    /// attached to the specified actor class and its base classes. The collection may be empty if no auto-attach types
    /// are defined.</returns>
    public static IEnumerable<Type> GetAutoAttachTypesByActor(Type actorClass)
    {
        foreach (var super in StaticInit.EnumerateSelfAndSupers(actorClass))
        {
            if (s_autoAttachTypes.TryGetValue(super, out var cachedTypes))
            {
                foreach (var type in cachedTypes)
                {
                    if (!type.AllowSubtypes && super != actorClass)
                    {
                        continue;
                    }

                    yield return type.Component;
                }
            }

            if (super == typeof(Actor))
            {
                break;
            }
        }
    }

    /// <inheritdoc cref="GetAutoAttachTypesByActor(Type)"/>
    /// <param name="actor">The object of whose class to scan for auto-attach components.</param>
    public static IEnumerable<Type> GetAutoAttachTypesByActor(Actor actor)
        => GetAutoAttachTypesByActor(actor.GetType());

    /// <summary>
    /// Attempts to automatically attach predefined script components to the specified actor if they are not already
    /// present.
    /// </summary>
    /// <remarks>This method checks for component types that are configured for automatic attachment and adds
    /// them to the actor if they are not already attached. If a component cannot be instantiated or attached, an error
    /// is logged and the method continues processing remaining components.</remarks>
    /// <param name="actor">The actor to which script components will be auto-attached. Cannot be null.</param>
    public static void TryAutoAttachComponents(Actor actor)
    {
        var componentTypes = GetAutoAttachTypesByActor(actor);

        foreach (var componentType in componentTypes)
        {
            if (actor.HasScriptComponent(componentType))
            {
                continue;
            }

            try
            {
                actor.AttachScriptComponent(componentType);
            }
            catch (Exception e)
            {
                Debug.LogError(
                    $"Failed to auto-attach {componentType.Name} to '{actor.GetFullName()}': \n{e.Message}",
                    skipSender: true);
            }
        }
    }

    /// <summary>
    /// Automatically attaches eligible component types to all existing actors in the world.
    /// </summary>
    public static void AutoAttachTypesToExistingActors()
    {
        if (!HasAutoAttachTypes())
        {
            return;
        }

        foreach (var actor in GameObject.FindObjectsSlow<Actor>())
        {
            if (!actor.IsValid())
            {
                continue;
            }

            if (actor == actor.Class.DefaultObject)
            {
                continue;
            }

            TryAutoAttachComponents(actor);
        }
    }
}
