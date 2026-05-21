namespace BmSDK.Framework;

/// <summary>
/// Marks a class as a ScriptComponent that can be attached to GameObjects.
/// Required for components that use auto-attach and local redirectors.
/// The class being marked must inherit <see cref="ScriptComponent{TClass}"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class ScriptComponentAttribute : Attribute
{
    /// <summary>
    /// Should this script component be automatically attached to new objects?
    /// Use <c>TClass</c> (see <see cref="ScriptComponent{TClass}"/>) to filter by object type.
    /// </summary>
    public bool AutoAttach { get; init; } = false;

    /// <summary>
    /// Should this script component be automatically attached to <i>any</i> subclass of <c>TClass</c>,
    /// or only <c>TClass</c> itself? Only applies when <c>AutoAttach = true</c>.
    /// </summary>
    public bool AllowSubtypes { get; init; } = true;
}
