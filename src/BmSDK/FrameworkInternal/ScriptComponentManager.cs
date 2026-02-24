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
    /// Registers all <see cref="ScriptComponent"/>s in the specified assembly that are marked with
    /// a ScriptComponentAttribute: This means that local redirectors are created and auto-attachment
    /// is registered if enabled.
    /// </summary>
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
    /// Determines whether the specified type represents a valid script component
    /// and retrieves its associated attribute and actor type.
    /// </summary>
    /// <param name="type">The type to evaluate for script component eligibility</param>
    /// <param name="attribute">Attribute associated with the ScriptComponent.
    /// <see langword="null"/> if the type is not a ScriptComponent.</param>
    /// <param name="actorType">Actor type the ScriptComponent applies to.
    /// <see langword="null"/> if the type is not a ScriptComponent.</param>
    /// <returns>Whether <paramref name="type"/> is a valid ScriptComponent</returns>
    static bool IsTypeAScriptComponent(
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
    static Type? TryGetComponentActorType(Type type)
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
    /// instances of a specified actor class, when they are created.
    /// </summary>
    /// <param name="componentType">The type of the script component to register for automatic attachment.
    /// Must derive from ScriptComponent.</param>
    /// <param name="targetClass">The actor class type which the component will be automatically attached to.
    /// Must derive from Actor.</param>
    /// <param name="allowSubtypes">Flag whether the component should auto-attach to
    /// child classes of <paramref name="targetClass"/>.</param>
    static void RegisterAutoAttachType(Type componentType, Type targetClass, bool allowSubtypes)
    {
        // We can't auto instantiate generic types
        if (componentType.IsGenericType)
        {
            throw new ArgumentException(
                $"ScriptComponents with generic type parameters " +
                $"cannot use AutoAttach: {componentType.FullName}");
        }

        // We need a default constructor to auto instantiate
        if (componentType.GetConstructor(Type.EmptyTypes) == null)
        {
            throw new ArgumentException(
                $"ScriptComponents without a public, parameterless constructor " +
                $"cannot use AutoAttach: {componentType.FullName}");
        }

        // Warning for backwards compatibility
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
    /// Determines whether any auto-attach <see cref="ScriptComponent"/> are currently registered.
    /// </summary>
    public static bool HasAutoAttachTypes() => s_autoAttachTypes.Count > 0;

    /// <summary>
    /// Retrieves all <see cref="ScriptComponent"/> types that are automatically
    /// attached to the specified actor class and its base classes.
    /// </summary>
    /// <param name="actorClass">The type for which to retrieve auto-attached component types.
    /// Should derive from <see cref="Actor"/>.</param>
    static IEnumerable<Type> GetAutoAttachTypesByActor(Type actorClass)
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
    static IEnumerable<Type> GetAutoAttachTypesByActor(Actor actor)
        => GetAutoAttachTypesByActor(actor.GetType());

    /// <summary>
    /// Attempts to auto-attach eligible script components to the specified actor
    /// if they are not already present.
    /// </summary>
    public static void TryAutoAttachComponents(Actor actor)
    {
        var componentTypes = GetAutoAttachTypesByActor(actor);

        foreach (var componentType in componentTypes)
        {
            if (!actor.HasScriptComponent(componentType))
            {
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
            // Skip actors to be GC'd
            if (!actor.IsValid())
            {
                continue;
            }

            // Skip the Class Default Object (CDO)
            if (actor == actor.Class.DefaultObject)
            {
                continue;
            }

            TryAutoAttachComponents(actor);
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
        Actor.AllScriptComponents.ToArray().ForEach(component => component.Detach());
    }
}
