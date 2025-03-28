using System.Reflection;

namespace BmSDK.Framework;

public enum MixinOrder
{
    Before = 0,
    After,
}

[AttributeUsage(AttributeTargets.Method)]
public class MixinAttribute : Attribute
{
    public MethodInfo TargetMethod { get; }

    public MixinOrder Order { get; }

    public MixinAttribute(
        Type targetClass,
        string targetMethodName,
        MixinOrder order = MixinOrder.Before
    )
    {
        Order = order;
        TargetMethod = Guard.NotNull(
            targetClass.GetMethod(
                targetMethodName,
                BindingFlags.Public
                    | BindingFlags.NonPublic
                    | BindingFlags.Instance
                    | BindingFlags.FlattenHierarchy
            ),
            $"Couldn't find target method {targetMethodName} in {targetClass.Name}"
        );
    }
}
