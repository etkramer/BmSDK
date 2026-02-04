using BmSDK.Framework;
using BmSDK.Framework.Redirection;

namespace BmSDK.Engine;

public partial class Actor
{
    /// <summary>
    /// Collection of all ScriptComponent instances attached to every actor.
    /// </summary>
    public static IReadOnlyCollection<IScriptComponent> AllScriptComponents => s_scriptComponents;

    internal static readonly List<IScriptComponent> s_scriptComponents = [];

    /// <summary>
    /// Collection of all unique ScriptComponent types attached to this actor.
    /// </summary>
    public IReadOnlyCollection<Type> ScriptComponentTypes => _scriptComponents.Keys;
    /// <summary>
    /// Collection of all ScriptComponent instances attached to this actor.
    /// There's one instance per unique ScriptComponent type.
    /// </summary>
    public IReadOnlyCollection<IScriptComponent> ScriptComponents => _scriptComponents.Values;

    internal readonly Dictionary<Type, IScriptComponent> _scriptComponents = [];

    /// <summary>
    /// Checks if the Actor has a ScriptComponent of a specific type attached.
    /// </summary>
    /// <typeparam name="TComponent">The ScriptComponent type to look for</typeparam>
    /// <returns>True, if the given component type is present in the Actor;
    /// false, if not.</returns>
    public bool HasScriptComponent<TComponent>()
        where TComponent : IScriptComponent
        => _scriptComponents.ContainsKey(typeof(TComponent));

    /// <summary>
    /// Checks if the Actor has a specific ScriptComponent instance attached to itself.
    /// </summary>
    /// <param name="component">The component to check for attachment</param>
    /// <returns>True, if the current Actor is the Owner of the ScriptComponent object;
    /// false if not.</returns>
    public bool HasScriptComponent(IScriptComponent component)
        => component.Owner == this;

    /// <summary>
    /// Attaches an existing script component to this actor.
    /// </summary>
    public void AttachScriptComponent(IScriptComponent newComponent)
    {
        Guard.Require(newComponent.Owner == null, "Component is already attached to an actor");

        // Store new component
        if (!_scriptComponents.TryAdd(newComponent.GetType(), newComponent))
        {
            throw new ArgumentException("This actor already contains a ScriptComponent of this type");
        }

        newComponent.Owner = this;

        s_scriptComponents.Add(newComponent);

        // Register any [Redirect] methods on this component
        RedirectManager.RegisterLocalRedirectors(newComponent);

        // Invoke attach callback
        newComponent.OnAttach();
    }

    /// <summary>
    /// Attaches a new script component of the given type to this actor.
    /// </summary>
    /// <typeparam name="TComponent">The ScriptComponent type to instantiate</typeparam>
    /// <returns>The newly created and attached ScriptComponent</returns>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : IScriptComponent, new()
    {
        // Create/attach new component
        var newComponent = new TComponent();
        AttachScriptComponent(newComponent);

        return newComponent;
    }

    /// <summary>
    /// Detaches the given script component from this actor.
    /// </summary>
    /// <param name="component">The component to detach</param>
    /// <exception cref="ArgumentException">Thrown if the component isn't attached to the actor</exception>
    public void DetachScriptComponent(IScriptComponent component)
    {
        Guard.Require(component.IsOwner(this), "Component is not attached to this actor");

        // Invoke detach callback
        component.OnDetach();

        // Unregister any [Redirect] methods
        RedirectManager.UnregisterComponentRedirectors(component);

        // Remove from storage
        _scriptComponents.Remove(component.GetType());
        s_scriptComponents.Remove(component);
        component.RemoveOwnership();
    }

    /// <summary>
    /// Detaches a ScriptComponent by its type from this actor.
    /// </summary>
    /// <typeparam name="TComponent">The ScriptComponent type to detach</typeparam>
    /// <exception cref="ArgumentException">Thrown if the component isn't attached to the actor</exception>
    public void DetachScriptComponent<TComponent>()
        where TComponent : IScriptComponent
    {
        if (!_scriptComponents.TryGetValue(typeof(TComponent), out var component))
        {
            throw new ArgumentException($"No instance of {nameof(TComponent)} is attached to this actor");
        }

        DetachScriptComponent(component);
    }

    /// <inheritdoc cref="GameObject.Clone"/>
    public new Actor Clone() => Game.SpawnActor(Class, Location, Rotation, this, Owner);
}
