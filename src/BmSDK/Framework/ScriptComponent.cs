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
/// <typeparam name="TClass">The type of actor this script component attaches to. Must inherit from <see cref="Actor"/>.</typeparam>
/// <seealso cref="ScriptComponentAttribute"/>
public abstract class ScriptComponent<TClass> : IScriptComponent<TClass>
    where TClass : GameObject
{
    /// <inheritdoc cref="IScriptComponent.Owner"/>
    public TClass Owner { get; private set; } = null!;

    /// <inheritdoc/>
    GameObject IScriptComponent.Owner
    {
        get => Owner;
        set
        {
            if (value is not null and not TClass)
            {
                throw new InvalidCastException(
                    $"{value.GetType().Name} is incompatible with {GetType().Name}"
                );
            }

            Owner = (TClass?)value!;
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
/// Only exists for compatibility reasons.
/// </summary>
/// <seealso cref="ScriptComponent{TClass}"/>
public abstract class ScriptComponent : ScriptComponent<Actor>;
