using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Marks a class as a ScriptComponent that can be attached to Actors.
/// Required for components that use auto-attach.
/// </summary>
/// <param name="autoAttach">A value indicating whether the script component should be automatically applied,
/// when an Actor runs its <see cref="Actor.PostBeginPlay"/>. <see cref="ScriptComponent{TActor}"/>
/// can be used to constraint the Actor types to apply the component to.</param>
[AttributeUsage(AttributeTargets.Class)]
public sealed class ScriptComponentAttribute(bool autoAttach = false) : Attribute
{
    public readonly bool AutoAttach = autoAttach;
}
