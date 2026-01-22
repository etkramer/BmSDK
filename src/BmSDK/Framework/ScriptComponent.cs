using System.Reflection;
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

    /// <summary>
    /// Registers all [Redirector] methods on this component for its owner.
    /// Called internally when the component is attached.
    /// </summary>
    internal void RegisterRedirectors()
    {
        var componentType = GetType();
        var methods = componentType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (var method in methods)
        {
            var attr = method.GetCustomAttribute<RedirectorAttribute>();
            if (attr == null)
            {
                continue;
            }

            // Resolve the function path (accounts for inheritance)
            var targetClass = Class.FindByManagedType(attr.TargetClass);
            var funcPath = RedirectManager.GetDeclaringFuncPath(targetClass, attr.TargetMethod);

            // Register the redirector for this specific owner
            RedirectManager.RegisterComponentRedirector(Owner, funcPath, this, method);
        }
    }

    /// <summary>
    /// Unregisters all redirectors associated with this component.
    /// Called internally when the component is detached.
    /// </summary>
    internal void UnregisterRedirectors()
    {
        RedirectManager.UnregisterComponentRedirectors(this);
    }

    /// <summary>
    /// Gets all [Redirector] attribute metadata from the given component type.
    /// Used during auto-attach registration.
    /// </summary>
    internal static IEnumerable<RedirectorAttribute> GetRedirectorAttributes(Type componentType)
    {
        var methods = componentType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (var method in methods)
        {
            var attr = method.GetCustomAttribute<RedirectorAttribute>();
            if (attr != null)
            {
                yield return attr;
            }
        }
    }
}
