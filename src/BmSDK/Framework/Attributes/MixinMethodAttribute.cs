using System.Reflection;

namespace BmSDK.Framework;

[AttributeUsage(AttributeTargets.Method)]
public class MixinMethodAttribute(Type targetClass, string targetMethodName) : Attribute
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
}
