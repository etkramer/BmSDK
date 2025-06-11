using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace BmSDK.Framework;

public static class MixinManager
{
    readonly record struct MixinInfo
    {
        public MethodInfo MixinMethod { get; init; }

        public Type TargetClass { get; init; }
    }

    const BindingFlags MixinBindingFlags =
        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

    static readonly Dictionary<string, MixinInfo> s_mixinDict = [];

    /// <summary>
    /// Registers all static [Mixin]-tagged methods from the given target type.
    /// </summary>
    public static void RegisterMixins(Type mixinType)
    {
        Guard.Require(mixinType.IsSealed && mixinType.IsAbstract, "Mixin type must be static.");

        // Get all candidate methods
        var mixinMethods = mixinType
            .GetMethods(MixinBindingFlags)
            .Select(method =>
                ((MethodInfo, MixinMethodAttribute?))
                    (method, method.GetCustomAttribute<MixinMethodAttribute>())
            )
            .Where(tuple => tuple.Item2 is not null)
            .Select(tuple => (tuple.Item1, tuple.Item2!));

        if (!mixinMethods.Any())
        {
            Debug.Log($"No mixins found in {mixinType.Name}");
            return;
        }

        Debug.Log($"Registering {mixinMethods.Count()} mixins from {mixinType.Name}");

        foreach (var (mixinMethod, mixinAttribute) in mixinMethods)
        {
            var targetClassPath = StaticInit.GetClassPathForManagedType(
                mixinAttribute.TargetMethod.DeclaringType!
            );
            var targetFuncPath = $"{targetClassPath}:{mixinAttribute.TargetMethod.Name}";

            Debug.Log($"Mixin will target {targetFuncPath}");

            if (s_mixinDict.ContainsKey(targetFuncPath))
            {
                throw new InvalidOperationException(
                    $"{targetFuncPath} already has a registered mixin!"
                );
            }

            s_mixinDict[targetFuncPath] = new MixinInfo()
            {
                MixinMethod = mixinMethod,
                TargetClass = mixinAttribute.TargetClass,
            };
        }
    }

    /// <summary>
    /// Gets all mixins for the given function object, or returns false if none exist.
    /// </summary>
    public static bool TryGetMixinMethod(
        GameObject obj,
        Function func,
        [MaybeNullWhen(false)] out MethodInfo mixinMethod
    )
    {
        var funcPath = func.GetPathName();
        if (
            s_mixinDict.TryGetValue(funcPath, out var mixinInfo)
            && mixinInfo.TargetClass == obj.GetType()
        )
        {
            mixinMethod = mixinInfo.MixinMethod;
            return true;
        }

        mixinMethod = null;
        return false;
    }
}
