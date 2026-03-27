namespace BmSDK.Framework;

/// <summary>
/// Defines the contract for a scriptable component that can be attached to a UObject.
/// MODS SHOULDN'T IMPLEMENT THIS DIRECTLY! Use <see cref="ScriptComponent{TClass}"/> instead.
/// </summary>
public interface IScriptComponent
{
    /// <summary>
    /// The UObject that this component is attached to.
    /// </summary>
    GameObject Owner { get; internal set; }

    /// <summary>
    /// Sets the backing Owner field to null.
    /// </summary>
    internal void RemoveOwnership() => Owner = null!;

    /// <summary>
    /// Determines whether the component is attached to any UObject.
    /// </summary>
    /// <returns>True, if Owner not null; false otherwise</returns>
    bool HasOwner();

    /// <summary>
    /// Determines whether the specified UObject stores the component.
    /// </summary>
    /// <param name="obj">The UObject to check for ownership.</param>
    /// <returns>true if the specified UObject is the owner; otherwise, false.</returns>
    bool IsOwner(GameObject obj);

    /// <summary>
    /// Detaches the component from the Owner
    /// </summary>
    void Detach();

    /// <summary>
    /// Called when this component is attached to a UObject.
    /// </summary>
    void OnAttach();

    /// <summary>
    /// Called when this component is detached from a UObject (or when that UObject is destroyed).
    /// </summary>
    void OnDetach();

    /// <summary>
    /// Called once every world tick (each frame when unpaused).
    /// </summary>
    void OnTick();
}

/// <inheritdoc/>
/// <typeparam name="TClass">The type of UObject this script component attaches to.
/// Must inherit from <see cref="GameObject"/>.</typeparam>
public interface IScriptComponent<in TClass> : IScriptComponent
    where TClass : GameObject;
