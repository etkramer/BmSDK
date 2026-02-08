using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Defines the contract for a scriptable component that can be attached to an actor.
/// MODS SHOULDN'T IMPLEMENT THIS DIRECTLY! Use <see cref="ScriptComponent{TActor}"/> instead.
/// </summary>
public interface IScriptComponent
{
    /// <summary>
    /// Returns the actor that this component is attached to.
    /// </summary>
    Actor Owner { get; internal set; }

    /// <summary>
    /// Determines whether the specified actor stores the component.
    /// </summary>
    /// <param name="actor">The actor to check for ownership.</param>
    /// <returns>true if the specified actor is the owner; otherwise, false.</returns>
    bool IsOwner(Actor actor) => actor == Owner;

    /// <summary>
    /// Sets the backing Owner field to null.
    /// </summary>
    internal void RemoveOwnership() => Owner = null!;

    /// <summary>
    /// Detaches the component from the Owner
    /// </summary>
    void Detach()
    {
        if (Owner == null)
        {
            throw new InvalidOperationException("Cannot detach ScriptComponent that is not attached to any Actor");
        }

        Owner.DetachScriptComponentBase(this);
    }

    /// <summary>
    /// Called when this component is attached to an actor.
    /// </summary>
    void OnAttach();

    /// <summary>
    /// Called when this component is detached from an actor (or when that actor is destroyed).
    /// </summary>
    void OnDetach();

    /// <summary>
    /// Called once every world tick.
    /// </summary>
    void OnTick();
}

/// <inheritdoc/>
/// <typeparam name="TActor">The type of actor this script component attaches to. Must inherit from <see cref="Actor"/>.</typeparam>
public interface IScriptComponent<in TActor> : IScriptComponent where TActor : Actor;
