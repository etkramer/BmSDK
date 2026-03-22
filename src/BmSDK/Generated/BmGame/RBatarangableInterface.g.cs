#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RBatarangableInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface RBatarangableInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetBatarangSpeedBoost
    /// </summary>
    public unsafe float GetBatarangSpeedBoost();

    /// <summary>
    /// Function: ForceHitAtEndOfFlight
    /// </summary>
    public unsafe bool ForceHitAtEndOfFlight();

    /// <summary>
    /// Function: GetBatarangPriority
    /// </summary>
    public unsafe float GetBatarangPriority();

    /// <summary>
    /// Function: IsBatarangable
    /// </summary>
    public unsafe bool IsBatarangable();

    /// <summary>
    /// Function: GetBatarangTargetPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 GetBatarangTargetPosition(System.Numerics.Vector3 AimLocation, System.Numerics.Vector3 AimDirection, bool bDuringTargetPhase = default);
}
