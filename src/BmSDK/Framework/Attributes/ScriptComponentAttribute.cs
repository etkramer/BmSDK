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
}
