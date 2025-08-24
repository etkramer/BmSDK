using BmSDK.Framework;

namespace BmSDK.Engine;

public partial class Actor
{
    /// <summary>
    /// Enumerates all script components attached to this actor.
    /// </summary>
    public static IEnumerable<ScriptComponent> AllScriptComponents => s_scriptComponents;

    private static readonly List<ScriptComponent> s_scriptComponents = [];

    /// <summary>
    /// Enumerates all script components attached to this actor.
    /// </summary>
    public IEnumerable<ScriptComponent> ScriptComponents => _scriptComponents;

    private readonly List<ScriptComponent> _scriptComponents = [];

    /// <summary>
    /// Attaches a new script component of the given type to this actor.
    /// </summary>
    public T AttachScriptComponent<T>()
        where T : ScriptComponent, new()
    {
        // Create/store new component
        var newComponent = new T { Owner = this };
        s_scriptComponents.Add(newComponent);
        _scriptComponents.Add(newComponent);

        // Invoke attach callback
        newComponent.OnAttach();
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
}
