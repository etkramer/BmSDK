#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RSpecialMoveInstance_VantageSwingInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RSpecialMoveInstance_VantageSwingInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: NextSwing
    /// </summary>
    public unsafe void NextSwing();

    /// <summary>
    /// Function: GetNextHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint GetNextHidePoint();

    /// <summary>
    /// Function: GetTargetHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint GetTargetHidePoint();

    /// <summary>
    /// Function: CanUpdateGrapple
    /// </summary>
    public unsafe bool CanUpdateGrapple();

    /// <summary>
    /// Function: SetNextHidePoint
    /// </summary>
    public unsafe void SetNextHidePoint(BmSDK.BmGame.RHidePoint NextPoint, System.Numerics.Vector3 NextPos);
}
