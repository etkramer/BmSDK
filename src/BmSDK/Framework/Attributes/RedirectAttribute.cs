namespace BmSDK.Framework;

[AttributeUsage(AttributeTargets.Method)]
public sealed class RedirectAttribute(string targetMethod) : Attribute
{
    public readonly Type? TargetType;
    public readonly string TargetMethod = targetMethod;

    public RedirectAttribute(Type targetType, string targetMethod) : this(targetMethod)
    {
        TargetType = targetType;
    }
}
