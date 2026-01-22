namespace BmSDK.Framework;

/// <summary>
/// Marks a method as a redirector that intercepts calls to an UnrealScript function.
/// When the component is attached to an actor, the decorated method will be called
/// instead of the original function.
/// </summary>
/// <param name="targetClass">The class containing the function to redirect.</param>
/// <param name="targetMethod">The name of the function to redirect.</param>
[AttributeUsage(AttributeTargets.Method)]
public sealed class RedirectorAttribute(Type targetClass, string targetMethod) : Attribute
{
    /// <summary>
    /// The class containing the function to redirect.
    /// </summary>
    public Type TargetClass { get; } = targetClass;

    /// <summary>
    /// The name of the function to redirect.
    /// </summary>
    public string TargetMethod { get; } = targetMethod;
}
