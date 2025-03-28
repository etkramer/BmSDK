using System.Reflection;

namespace BmSDK.Framework;

public enum MixinOrder
{
    Before = 0,
    After,
}

[AttributeUsage(AttributeTargets.Method)]
public class MixinAttribute(Type targetClass, string targetMethodName, MixinOrder order) : Attribute
{
    public Type TargetClass { get; } = targetClass;

    public MethodInfo TargetMethod { get; } =
        Guard.NotNull(
            targetClass.GetMethod(
                targetMethodName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance
            ),
            $"Couldn't find target method {targetMethodName} in {targetClass.Name}"
        );

    public MixinOrder Order { get; } = order;
}
