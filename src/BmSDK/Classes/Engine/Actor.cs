using BmSDK.Framework;
using BmSDK.Framework.Redirection;

namespace BmSDK.Engine;

public partial class Actor
{
    /// <summary>
    /// Collection of all script components attached to this actor.
    /// </summary>
    public static IReadOnlyCollection<IScriptComponent> AllScriptComponents => s_scriptComponents;

    internal static readonly List<IScriptComponent> s_scriptComponents = [];

    /// <summary>
    /// Collection of all script components attached to this actor.
    /// </summary>
    public IReadOnlyCollection<IScriptComponent> ScriptComponents => _scriptComponents;

    internal readonly List<IScriptComponent> _scriptComponents = [];

    /// <summary>
    /// Checks if the Actor has a ScriptComponent of a specific type attached.
    /// </summary>
    /// <typeparam name="TComponent">The ScriptComponent type to look for</typeparam>
    /// <returns>True, if the given component type is present in the Actor;
    /// false, if not.</returns>
    public bool HasScriptComponentType<TComponent>()
        where TComponent : IScriptComponent
        => _scriptComponents.OfType<TComponent>().Any();

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

        newComponent.Owner = this;

        // Store new component
        s_scriptComponents.Add(newComponent);
        _scriptComponents.Add(newComponent);

        // Register any [Redirect] methods on this component
        RedirectManager.RegisterLocalRedirectors(newComponent);

        // Invoke attach callback
        newComponent.OnAttach();
    }

    /// <summary>
    /// Attaches a new script component of the given type to this actor.
    /// </summary>
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
    public void DetachScriptComponent(IScriptComponent component)
    {
        Guard.Require(component.IsOwner(this), "Component is not attached to this actor");

        // Invoke detach callback
        component.OnDetach();

        // Unregister any [Redirect] methods
        RedirectManager.UnregisterComponentRedirectors(component);

        // Remove from storage
        _scriptComponents.Remove(component);
        s_scriptComponents.Remove(component);
        component.RemoveOwnership();
    }

    public void DetachScriptComponent<TComponent>()
        where TComponent : IScriptComponent
    {
        foreach (var component in _scriptComponents.OfType<TComponent>())
        {
            DetachScriptComponent(component);
        }
    }

    /// <inheritdoc cref="GameObject.Clone"/>
    public new Actor Clone() => Game.SpawnActor(Class, Location, Rotation, this, Owner);
}
