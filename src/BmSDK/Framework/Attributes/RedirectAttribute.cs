namespace BmSDK.Framework;

/// <summary>
/// Marks a static function as a global detour to a target method on a specified type.
/// The detour applies globally and unconditionally to every instance of the target type.
/// Do NOT register the function separately using
/// <see cref="Game.SetFunctionRedirect(Type, string, Delegate)"/>;
/// BmSDK performs registration automatically when this attribute is present.
/// </summary>
/// <remarks>The method being marked must be static and take an artificial self parameter
/// of the <see cref="TargetType"/> as the first argument. The return type and the
/// parameter types that follow (the function signature) must match the actual method exactly
/// (both types and order). Names and the method's access modifier are irrelevant.</remarks>
/// <example>
/// [Redirect(typeof(RPawnPlayer), nameof(RPawnPlayer.ExperienceAwarded))]
/// private static void ExperienceAwardedRedirect(RPawnPlayer self, int xp, int teethXp)
/// {
///     Debug.Log("Experiencing less...");
///     self.ExperienceAwarded(xp / 10, teethXp / 10);
/// }
/// </example>
/// <param name="targetType">The type that contains the method of which calls are redirected.
/// Use <see langword="typeof"/> to get it safely.</param>
/// <param name="targetMethod">The name of the method on the target type to which calls are redirected.
/// Use <see langword="nameof"/> to get it safely.</param>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class RedirectAttribute(Type targetType, string targetMethod) : Attribute
{
    public Type TargetType { get; } = targetType;
    public string TargetMethod { get; } = targetMethod;
}
