using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Marks a class as a ScriptComponent that can be attached to Actors.
/// Required for components that use auto-attach and local redirectors.
/// The class being marked must inherit <see cref="ScriptComponent{TActor}"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class ScriptComponentAttribute : Attribute
{
    /// <summary>
    /// A value indicating whether the script component should be automatically applied,
    /// when an Actor runs its <see cref="Actor.PostBeginPlay"/>. <see cref="ScriptComponent{TActor}"/>
    /// can be used to constraint the Actor types to apply the component to.
    /// </summary>
    public bool AutoAttach { get; init; } = false;
    /// <summary>
    /// Indicates whether the script component should automatically attach to actors of the
    /// <c>TActor</c> type and its derived types, or only to the exact <c>TActor</c> type.
    /// This behavior is similar to C#'s <see langword="sealed"/> keyword. Irrelevant when the
    /// <see cref="ScriptComponent"/> is attached manually. Therefore, <see cref="AutoAttach"/>
    /// must be set for this option to take effect.
    /// </summary>
    public bool AllowSubtypes { get; init; } = true;
}
