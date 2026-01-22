namespace BmSDK.Framework;

/// <summary>
/// Marks a class as a script component. Required for components that use auto-attach.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class ScriptComponentAttribute : Attribute
{
    /// <summary>
    /// When set, an instance of this component will be automatically attached
    /// to all actors of the specified class.
    /// </summary>
    public Type? AutoAttach { get; init; }
}
