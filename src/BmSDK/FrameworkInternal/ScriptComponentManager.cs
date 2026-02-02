using System.Reflection;
using BmSDK.Engine;
using BmSDK.Framework.Redirection;

namespace BmSDK.Framework;

static class ScriptComponentManager
{
    static readonly Dictionary<string, List<Type>> s_autoAttachTypes = [];

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

        // Run detach code in advance
        Actor.s_scriptComponents.ForEach(component => component.OnDetach());
        // Unregister components locally
        Actor.s_scriptComponents.ForEach(component => component.Owner._scriptComponents.Clear());
        // Unregister components globally
        Actor.s_scriptComponents.Clear();
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
    public static void RegisterAutoAttachType(Type componentType, Type targetClass)
    {
        var className = StaticInit.GetClassPathForManagedType(targetClass);
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
    /// Registers all <see cref="ScriptComponent"/>s in the specified assembly that are marked with
    /// a ScriptComponentAttribute and have AutoAttach enabled for automatic attachment.
    /// It also stores the redirectors defined in the types.
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

            RedirectManager.RegisterLocalRedirectors(type, actorType!);

            if (attribute!.AutoAttach)
            {
                RegisterAutoAttachType(type, actorType!);
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
    public static bool IsTypeAScriptComponent(Type type, out ScriptComponentAttribute? attribute, out Type? actorType)
    {
        attribute = null;
        actorType = null;

        if (!type.IsClass || type.IsGenericType || type.IsAbstract)
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
            var className = StaticInit.GetClassPathForManagedType(super);
            if (s_autoAttachTypes.TryGetValue(className, out var types))
            {
                foreach (var type in types)
                {
                    yield return type;
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
            var alreadyAttached = actor.ScriptComponents.Any(c => c.GetType() == componentType);
            if (alreadyAttached)
            {
                continue;
            }

            try
            {
                var component = (IScriptComponent)Guard.NotNull(Activator.CreateInstance(componentType));
                actor.AttachScriptComponent(component);
            }
            catch (Exception e)
            {
                Debug.LogError(
                    $"Failed to auto-attach {componentType.Name} to '{actor.GetFullName()}': {e.Message}",
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
