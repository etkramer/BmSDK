using BmSDK.Framework;

namespace BmSDK.Engine;

public partial class Actor
{
    /// <summary>
    /// Collection of all script components attached to this actor.
    /// </summary>
    public static IReadOnlyCollection<ScriptComponent> AllScriptComponents => s_scriptComponents;

    internal static readonly List<ScriptComponent> s_scriptComponents = [];

    /// <summary>
    /// Collection of all script components attached to this actor.
    /// </summary>
    public IReadOnlyCollection<ScriptComponent> ScriptComponents => _scriptComponents;

    internal readonly List<ScriptComponent> _scriptComponents = [];

    /// <summary>
    /// Attaches an existing script component to this actor.
    /// </summary>
    public void AttachScriptComponent(ScriptComponent newComponent)
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
    public T AttachScriptComponent<T>()
        where T : ScriptComponent, new()
    {
        // Create/attach new component
        var newComponent = new T();
        AttachScriptComponent(newComponent);

        return newComponent;
    }

    /// <summary>
    /// Detaches the given script component from this actor.
    /// </summary>
    public void DetachScriptComponent(ScriptComponent component)
    {
        Guard.Require(component.Owner == this, "Component is not attached to this actor");

        // Invoke detach callback
        component.OnDetach();

        // Remove from storage
        _scriptComponents.Remove(component);
        s_scriptComponents.Remove(component);
        component.Owner = null!;
    }

    /// <inheritdoc cref="GameObject.Clone"/>
    public new Actor Clone()
    {
        return Game.SpawnActor(Class, Location, Rotation, this, Owner);
    }
}
