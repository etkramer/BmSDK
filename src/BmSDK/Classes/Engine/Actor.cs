using BmSDK.Framework;
using BmSDK.Framework.Redirection;
using MoreLinq;

namespace BmSDK.Engine;

public partial class Actor
{
    /// <summary>
    /// Collection of all ScriptComponent instances attached to every actor.
    /// </summary>
    public static IReadOnlyCollection<IScriptComponent> AllScriptComponents => s_scriptComponents;

    static readonly List<IScriptComponent> s_scriptComponents = [];

    /// <summary>
    /// Collection of all ScriptComponent instances attached to this actor.
    /// There's one instance per unique ScriptComponent type.
    /// </summary>
    public IReadOnlyCollection<IScriptComponent> ScriptComponents => _scriptComponents.Values;

    readonly Dictionary<Type, IScriptComponent> _scriptComponents = [];

    /// <summary>
    /// Attaches an existing script component to this actor.
    /// </summary>
    internal void AttachScriptComponent(IScriptComponent component)
    {
        Guard.Require(!component.HasOwner(), "Component is already attached to an actor");

        // Store new component
        if (!_scriptComponents.TryAdd(component.GetType(), component))
        {
            throw new ArgumentException("This actor already contains a ScriptComponent of this type");
        }

        s_scriptComponents.Add(component);
        
        component.Owner = this;

        // Register any [Redirect] methods on this component
        RedirectManager.Local.RegisterComponentRedirectors(component);

        // Invoke attach callback
        component.OnAttach();
    }

    /// <summary>
    /// Attaches a new script component of the given type to this actor.
    /// </summary>
    /// <param name="type">The ScriptComponent type to instantiate</param>
    /// <returns>The newly created and attached ScriptComponent</returns>
    /// <exception cref="ArgumentException">Thrown if the given type is not a
    /// non-generic, non-abstract class with a parameterless constructor that
    /// extends <see cref="ScriptComponent{TActor}"/>.</exception>
    internal IScriptComponent AttachScriptComponent(Type type)
    {
        if (!type.IsClass || type.IsAbstract || type.ContainsGenericParameters)
        {
            throw new ArgumentException(
                $"{type.FullName}: ScriptComponents that are attached " +
                $"by their types must be non-genric, non-abstract classes.");
        }

        if (type.GetConstructor(Type.EmptyTypes) == null)
        {
            throw new ArgumentException(
                $"{type.FullName}: ScriptComponents that are attached by" +
                $"their types must contain a public, parameterless constructor");
        }

        if (!type.IsAssignableTo(typeof(IScriptComponent)))
        {
            throw new ArgumentException(
                $"{type.FullName}: A class you want to attach as a " +
                $"ScriptComponent must inherit from ScriptComponent<TActor>.");
        }

        var component = (IScriptComponent)Guard.NotNull(Activator.CreateInstance(type));
        AttachScriptComponent(component);
        return component;
    }

    /// <summary>
    /// Checks if the Actor has a specific ScriptComponent instance attached to itself.
    /// </summary>
    /// <param name="component">The component to check for attachment</param>
    /// <returns>True, if the current Actor is the Owner of the ScriptComponent object;
    /// false if not.</returns>
    internal bool HasScriptComponent(IScriptComponent component)
        => component.Owner == this;

    /// <summary>
    /// Checks if the Actor has a ScriptComponent of a specific type attached.
    /// </summary>
    /// <param name="type">The ScriptComponent type to look for</param>
    /// <returns>True, if the given component type is present in the Actor;
    /// false, if not.</returns>
    internal bool HasScriptComponent(Type type)
        => _scriptComponents.ContainsKey(type);

    internal IScriptComponent GetScriptComponent(Type type)
    {
        if (_scriptComponents.TryGetValue(type, out var result))
        {
            return result;
        }

        throw new KeyNotFoundException($"No script component of {type} is attached to this actor");
    }

    /// <summary>
    /// Detaches the given script component from this actor.
    /// </summary>
    /// <param name="component">The component to detach</param>
    /// <exception cref="ArgumentException">Thrown if the component isn't attached to the actor</exception>
    internal void DetachScriptComponent(IScriptComponent component)
    {
        Guard.Require(component.IsOwner(this), "Component is not attached to this actor");

        // Invoke detach callback
        component.OnDetach();

        // Unregister any [Redirect] methods
        RedirectManager.Local.UnregisterComponentRedirectors(component);

        // Remove from storage
        _scriptComponents.Remove(component.GetType());
        s_scriptComponents.Remove(component);
        component.RemoveOwnership();
    }

    /// <summary>
    /// Detaches a ScriptComponent by its type from this actor.
    /// </summary>
    /// <param name="type">The ScriptComponent type to detach</param>
    /// <exception cref="ArgumentException">Thrown if the component isn't attached to the actor</exception>
    internal void DetachScriptComponent(Type type)
    {
        if (!_scriptComponents.TryGetValue(type, out var component))
        {
            throw new ArgumentException($"No instance of {type} is attached to this actor");
        }

        DetachScriptComponent(component);
    }

    /// <summary>
    /// Unregisters all script components attached to the actor.
    /// </summary>
    internal void DetachAllScriptComponents()
        => ScriptComponents.ToArray().ForEach(DetachScriptComponent);

    /// <inheritdoc cref="GameObject.Clone"/>
    public new Actor Clone() => Game.SpawnActor(Class, Location, Rotation, this, Owner);
}
