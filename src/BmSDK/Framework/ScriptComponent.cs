using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Base class for script components that can be attached to an object.
/// These are similar to the game's built-in <see cref="ActorComponent"/>s,
/// but allow for scripts to add their own custom behavior.
/// </summary>
/// <remarks>Extend this class to create script components that require access to a specific object type. The <see
/// cref="Owner"/> property exposes the object instance as the specified type, enabling type-safe interactions
/// within the component.
/// This is especially useful if you want to use <see cref="ScriptComponentAttribute.AutoAttach"/> to automatically
/// apply script components to a certain class.
/// </remarks>
/// <typeparam name="TClass">The object type that this script component can be attached to.
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
                "Script component is not attached to an object"
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
