using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Provides a base class for script components that are associated with a strongly-typed actor instance.
/// These are similar to the game's built-in <see cref="ActorComponent"/>s,
/// but allow for scripts to add their own custom behavior.
/// </summary>
/// <remarks>Extend this class to create script components that require access to a specific actor type. The <see
/// cref="Owner"/> property exposes the actor instance as the specified type, enabling type-safe interactions within the
/// component.
/// This is especially useful if you want to use <see cref="ScriptComponentAttribute.AutoAttach"/>
/// to apply the ScriptComponent to one specific child class of Actor only.
/// </remarks>
/// <typeparam name="TActor">The type of actor this script component attaches to. Must inherit from <see cref="Actor"/>.</typeparam>
/// <seealso cref="ScriptComponentAttribute"/>
public abstract class ScriptComponent<TActor> : IScriptComponent<TActor>
    where TActor : Actor
{
    /// <inheritdoc cref="IScriptComponent.Owner"/>
    public TActor Owner { get; internal set; } = null!;
    /// <inheritdoc/>
    Actor IScriptComponent.Owner
    {
        get => Owner;
        set
        {
            if (value is not null and not TActor)
            {
                throw new InvalidCastException($"{value.GetType().Name} is incompatible with {GetType().Name}");
            }

            Owner = (TActor?)value!;
        }
    }

    /// <inheritdoc/>
    public virtual void OnAttach() { }
    /// <inheritdoc/>
    public virtual void OnDetach() { }
    /// <inheritdoc/>
    public virtual void OnTick() { }
}

/// <summary>
/// Base class for script components that can be attached to actors.
/// Use this non-generic type if the script component should apply to any Actor.
/// </summary>
/// <seealso cref="ScriptComponent{TActor}"/>
public abstract class ScriptComponent : ScriptComponent<Actor>;
