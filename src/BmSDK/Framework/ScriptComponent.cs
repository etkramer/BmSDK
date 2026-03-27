using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Provides a base class for script components that are associated with a strongly-typed UObject instance.
/// These are similar to the game's built-in <see cref="ActorComponent"/>s,
/// but allow for scripts to add their own custom behavior.
/// </summary>
/// <remarks>Extend this class to create script components that require access to a specific UObject type. The <see
/// cref="Owner"/> property exposes the UObject instance as the specified type, enabling type-safe interactions
/// within the component.
/// This is especially useful if you want to use <see cref="ScriptComponentAttribute.AutoAttach"/>
/// to apply the ScriptComponent to one specific child class of UObject only.
/// </remarks>
/// <typeparam name="TClass">The type of UObject this script component attaches to.
/// Must inherit from <see cref="GameObject"/>.</typeparam>
/// <seealso cref="ScriptComponentAttribute"/>
public abstract class ScriptComponent<TClass> : IScriptComponent<TClass>
    where TClass : GameObject
{
    /// <inheritdoc cref="IScriptComponent.Owner"/>
    public TClass Owner { get; private set; } = null!;

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
    public bool HasOwner() => Owner != null;

    /// <inheritdoc/>
    public bool IsOwner(GameObject obj) => obj == Owner;

    /// <inheritdoc/>
    public void Detach()
    {
        if (!HasOwner())
        {
            throw new InvalidOperationException(
                "Cannot detach ScriptComponent that is not attached to any UObject"
            );
        }

        Owner.DetachScriptComponent(this);
    }

    /// <inheritdoc/>
    public virtual void OnAttach() { }

    /// <inheritdoc/>
    public virtual void OnDetach() { }

    /// <inheritdoc/>
    public virtual void OnTick() { }
}

/// <summary>
/// Base class for script components that can be attached to actors. Only exists
/// for compatibility reasons. Use <see cref="ScriptComponent{TClass}"/> instead.
/// </summary>
public abstract class ScriptComponent : ScriptComponent<Actor>;
