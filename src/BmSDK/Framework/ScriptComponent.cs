using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Base class for script components that can be attached to actors. These are similar to
/// the game's built-in <see cref="ActorComponent"/>s, but allow for scripts to add their own custom behavior.
/// </summary>
public abstract class ScriptComponent
{
    /// <summary>
    /// Returns the actor that this component is attached to.
    /// </summary>
    public Actor Owner { get; internal set; } = null!;

    /// <summary>
    /// Called when this component is attached to an actor.
    /// </summary>
    public virtual void OnAttach() { }

    /// <summary>
    /// Called when this component is detached from an actor (or when that actor is destroyed).
    /// </summary>
    public virtual void OnDetach() { }

    /// <summary>
    /// Called once every world tick.
    /// </summary>
    public virtual void OnTick() { }
}
