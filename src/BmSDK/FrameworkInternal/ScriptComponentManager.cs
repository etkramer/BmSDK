using System.Reflection;
using BmSDK.Engine;

namespace BmSDK.Framework;

static class ScriptComponentManager
{
    static readonly Dictionary<string, List<Type>> s_autoAttachTypes = [];

    /// <summary>
    /// Unregisters all script components and clears all auto-attachment type registrations.
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

    public static bool HasAutoAttachTypes() => s_autoAttachTypes.Count > 0;

    /// <summary>
    /// Registers a script component type to be automatically attached to instances of a specified actor class,
    /// when they are created.
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

    public static void RegisterAutoAttachTypes(Assembly asm)
    {
        var componentTypes = asm.GetTypes()
            .Where(t => !t.IsAbstract)
            .Where(t => typeof(ScriptComponent).IsAssignableFrom(t));

        foreach (var componentType in componentTypes)
        {
            var attribute = componentType.GetCustomAttribute<ScriptComponentAttribute>();
            if (attribute == null || !attribute.AutoAttach)
            {
                continue;
            }

            RegisterAutoAttachType(componentType, attribute.TargetType);
        }
    }

    /// <summary>
    /// Retrieves all component types that are automatically attached to the specified actor class and its base classes.
    /// </summary>
    /// <param name="actorClass">The type of the actor for which to retrieve auto-attached component types. Must derive from <see cref="Actor"/>.</param>
    /// <returns>An enumerable collection of <see cref="Type"/> objects representing the component types that are automatically
    /// attached to the specified actor class and its base classes. The collection may be empty if no auto-attach types
    /// are defined.</returns>
    public static IEnumerable<Type> GetAutoAttachTypesByActor(Type actorClass)
    {
        foreach (var super in Class.EnumerateSupersAndSelf(actorClass))
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

    public static IEnumerable<Type> GetAutoAttachTypesByActor(Actor actor)
        => GetAutoAttachTypesByActor(actor.GetType());

    public static void TryAutoAttachComponents(Actor actor)
    {
        if (!HasAutoAttachTypes())
        {
            return;
        }

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
                var component = (ScriptComponent)Guard.NotNull(Activator.CreateInstance(componentType));
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

            TryAutoAttachComponents(actor);
        }
    }
}
