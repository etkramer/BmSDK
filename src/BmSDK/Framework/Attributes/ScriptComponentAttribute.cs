using BmSDK.Engine;

namespace BmSDK.Framework;

/// <summary>
/// Marks a class as a ScriptComponent that can be attached to Actors.
/// Required for components that use auto-attach.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class ScriptComponentAttribute : Attribute
{
    public readonly Type TargetType;
    public readonly bool AutoAttach;

    /// <param name="targetType">The type of Actor which the script component can attach to.
    /// Therefore, it must inherit from <see cref="Actor"/>.
    /// If null, the attribute may be applied to any actor.</param>
    /// <param name="autoAttach">A value indicating whether the script component should be automatically applied,
    /// when an Actor of <see cref="TargetType"/> runs its <see cref="Actor.PostBeginPlay"/></param>
    /// <exception cref="ArgumentException">Thrown if targetType is not null and does not inherit from Actor.</exception>
    public ScriptComponentAttribute(Type? targetType = null, bool autoAttach = false)
    {
        if (targetType == null)
        {
            targetType = typeof(Actor);
        }
        else if (!typeof(Actor).IsAssignableFrom(targetType))
        {
            throw new ArgumentException("The target type of a script component must inherit from Actor!");
        }

        TargetType = targetType;
        AutoAttach = autoAttach;
    }
}
