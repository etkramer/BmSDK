using BmSDK.Framework;
using BmSDK.Framework.Redirection;
using MoreLinq;

namespace BmSDK;

public partial class GameObject
{
    /// <summary>
    /// Collection of all ScriptComponent instances attached to every object.
    /// </summary>
    public static IReadOnlyCollection<IScriptComponent> AllScriptComponents => s_scriptComponents;

    private static readonly List<IScriptComponent> s_scriptComponents = [];

    /// <summary>
    /// Collection of all ScriptComponent instances attached to this object.
    /// There's one instance per unique ScriptComponent type.
    /// </summary>
    public IReadOnlyCollection<IScriptComponent> ScriptComponents => _scriptComponents.Values;

    private readonly Dictionary<Type, IScriptComponent> _scriptComponents = [];

    /// <summary>
    /// Attaches an existing script component instance to this object.
    /// </summary>
    /// <param name="component">ScriptComponent to attach;
    /// cannot have an Owner when trying to attach it.</param>
    internal void AttachScriptComponent(IScriptComponent component)
    {
        Guard.Require(!component.HasOwner(), "Component is already attached to an object");

        // Store new component
        if (!_scriptComponents.TryAdd(component.GetType(), component))
        {
            throw new ArgumentException(
                "This object already contains a ScriptComponent of this type"
            );
        }

        s_scriptComponents.Add(component);

        component.Owner = this;

        // Register any [ComponentRedirect] methods on this component
        RedirectManager.Local.RegisterComponentRedirectors(component);

        // Invoke attach callback
        component.OnAttach();
    }

    /// <summary>
    /// Attaches a new script component of the given type to this object.
    /// </summary>
    /// <param name="type">The ScriptComponent type to instantiate</param>
    /// <returns>The newly created and attached ScriptComponent</returns>
    /// <exception cref="ArgumentException">Thrown if the given type is not a
    /// non-generic, non-abstract class with a parameterless constructor that
    /// extends <see cref="ScriptComponent{TClass}"/>.</exception>
    internal IScriptComponent AttachScriptComponent(Type type)
    {
        if (!type.IsClass || type.IsAbstract || type.ContainsGenericParameters)
        {
            throw new ArgumentException(
                $"{type.FullName}: ScriptComponents that are attached "
                    + $"by their types must be non-genric, non-abstract classes."
            );
        }

        if (type.GetConstructor(Type.EmptyTypes) == null)
        {
            throw new ArgumentException(
                $"{type.FullName}: ScriptComponents that are attached by"
                    + $"their types must contain a public, parameterless constructor"
            );
        }

        if (!type.IsAssignableTo(typeof(IScriptComponent)))
        {
            throw new ArgumentException(
                $"{type.FullName}: A class you want to attach as a "
                    + $"ScriptComponent must inherit from ScriptComponent<TClass>."
            );
        }

        var component = (IScriptComponent)Guard.NotNull(Activator.CreateInstance(type));
        AttachScriptComponent(component);
        return component;
    }

    /// <summary>
    /// Checks if the Object has the specified ScriptComponent instance attached to itself.
    /// </summary>
    internal bool HasScriptComponent(IScriptComponent component) => component.Owner == this;

    /// <summary>
    /// Checks if the Object has a ScriptComponent of a specific type attached.
    /// </summary>
    internal bool HasScriptComponent(Type type) => _scriptComponents.ContainsKey(type);

    /// <summary>
    /// Gets an attached ScriptComponent instance by its type.
    /// </summary>
    /// <exception cref="KeyNotFoundException">Thrown if the component type
    /// has not been attached</exception>
    internal IScriptComponent GetScriptComponent(Type type)
    {
        if (_scriptComponents.TryGetValue(type, out var result))
        {
            return result;
        }

        throw new KeyNotFoundException($"No script component of {type} is attached to this object");
    }

    /// <summary>
    /// Detaches the given script component from this Object.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown if the component isn't attached to the object</exception>
    internal void DetachScriptComponent(IScriptComponent component)
    {
        Guard.Require(component.IsOwner(this), "Component is not attached to this object");

        // Invoke detach callback
        component.OnDetach();

        // Unregister any [ComponentRedirect] methods
        RedirectManager.Local.UnregisterComponentRedirectors(component);

        // Remove from storage
        _scriptComponents.Remove(component.GetType());
        s_scriptComponents.Remove(component);
        component.RemoveOwnership();
    }

    /// <summary>
    /// Detaches a ScriptComponent by its type from this object.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown if the component isn't attached to the object</exception>
    internal void DetachScriptComponent(Type type)
    {
        if (!_scriptComponents.TryGetValue(type, out var component))
        {
            throw new ArgumentException($"No instance of {type} is attached to this object");
        }

        DetachScriptComponent(component);
    }

    /// <summary>
    /// Unregisters all script components attached to the object.
    /// </summary>
    internal void DetachAllScriptComponents() =>
        ScriptComponents.ToArray().ForEach(DetachScriptComponent);
}
