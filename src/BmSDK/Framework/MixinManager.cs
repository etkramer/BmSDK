using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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

    static readonly Dictionary<string, List<MixinInfo>> _beforeMixins = [];
    static readonly Dictionary<string, List<MixinInfo>> _afterMixins = [];

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
                ((MethodInfo, MixinAttribute?))(method, method.GetCustomAttribute<MixinAttribute>())
            )
            .Where(tuple => tuple.Item2 is not null);

        if (!mixinMethods.Any())
        {
            Debug.WriteLine($"No mixins found in {mixinType.Name}");
            return;
        }

        Debug.WriteLine($"Registering {mixinMethods.Count()} mixins from {mixinType.Name}");

        foreach (var (mixinMethod, mixinAttribute) in mixinMethods)
        {
            var targetMethod = mixinAttribute!.TargetMethod;
            var targetClass = Guard.NotNull(targetMethod.DeclaringType);

            var targetClassPath = StaticInit.GetClassPathForManagedType(targetClass);
            var targetFuncPath = $"{targetClassPath}:{targetMethod.Name}";

            Debug.WriteLine($"Mixin will target {targetFuncPath}");

            var mixinDict = mixinAttribute.Order switch
            {
                MixinOrder.Before => _beforeMixins,
                MixinOrder.After => _afterMixins,
                _ => throw new Exception(),
            };

            // Create new mixin list if needed
            if (!mixinDict.TryGetValue(targetFuncPath, out var mixinList))
            {
                mixinList = mixinDict[targetFuncPath] = [];
            }

            mixinList.Add(
                new MixinInfo() { MixinMethod = mixinMethod, TargetClass = targetClass! }
            );
        }
    }

    /// <summary>
    /// Gets all mixins for the given function object, or returns false if none exist.
    /// </summary>
    public static bool TryGetMixinMethods(
        GameObject obj,
        Function func,
        MixinOrder order,
        [MaybeNullWhen(false)] out IEnumerable<MethodInfo> mixinMethods
    )
    {
        var funcPath = func.GetPathName();
        if (GetOrderDict(order).TryGetValue(funcPath, out var mixinInfos))
        {
            mixinMethods = mixinInfos
                .Where(info => obj.GetType().IsAssignableTo(info.TargetClass))
                .Select(info => info.MixinMethod);

            return true;
        }

        mixinMethods = null;
        return false;
    }

    static Dictionary<string, List<MixinInfo>> GetOrderDict(MixinOrder order)
    {
        return order switch
        {
            MixinOrder.Before => _beforeMixins,
            MixinOrder.After => _afterMixins,
            _ => throw new ArgumentOutOfRangeException(nameof(order), order, null),
        };
    }
}
