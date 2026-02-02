using BmSDK.Framework;

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
    /// Attaches an existing script component to this actor.
    /// </summary>
    public void AttachScriptComponent(IScriptComponent newComponent)
    {
        Guard.Require(newComponent.Owner == null, "Component is already attached to an actor");

        newComponent.Owner = this;

        // Store new component
        s_scriptComponents.Add(newComponent);
        _scriptComponents.Add(newComponent);

        // Invoke attach callback
        newComponent.OnAttach();
    }

    /// <summary>
    /// Attaches a new script component of the given type to this actor.
    /// </summary>
    public TComponent AttachScriptComponent<TComponent, TActor>()
        where TComponent : ScriptComponent<TActor>, new()
        where TActor : Actor
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

        // Remove from storage
        _scriptComponents.Remove(component);
        s_scriptComponents.Remove(component);
        component.RemoveOwnership();
    }

    /// <inheritdoc cref="GameObject.Clone"/>
    public new Actor Clone() => Game.SpawnActor(Class, Location, Rotation, this, Owner);
}
