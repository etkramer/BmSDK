#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RRemovableInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface RRemovableInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: SuperEasy
    /// </summary>
    public unsafe bool SuperEasy();

    /// <summary>
    /// Function: GetBatClawImpactSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GetBatClawImpactSound();

    /// <summary>
    /// Function: GetHarpoonTargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetHarpoonTargetLocation();

    /// <summary>
    /// Function: IsHarpoonable
    /// </summary>
    public unsafe bool IsHarpoonable(BmSDK.BmGame.RHarpoonGun HarpoonGun);

    /// <summary>
    /// Function: StartRemoveAttempt
    /// </summary>
    public unsafe void StartRemoveAttempt(BmSDK.Engine.Pawn AttemptingPawn, System.Numerics.Vector3 HitLocation);

    /// <summary>
    /// Function: FailedToRemove
    /// </summary>
    public unsafe void FailedToRemove(BmSDK.Engine.Pawn AttemptingPawn);

    /// <summary>
    /// Function: Remove
    /// </summary>
    public unsafe void Remove(BmSDK.Engine.Pawn AttemptingPawn);
}
