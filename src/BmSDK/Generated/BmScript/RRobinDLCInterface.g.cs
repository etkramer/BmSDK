#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Interface: RRobinDLCInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface RRobinDLCInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: IsShieldActive
    /// </summary>
    public unsafe bool IsShieldActive();

    /// <summary>
    /// Function: SetShieldBlocking
    /// </summary>
    public unsafe void SetShieldBlocking(bool bBlock);

    /// <summary>
    /// Function: CanBlockShotsFrom
    /// </summary>
    public unsafe bool CanBlockShotsFrom(System.Numerics.Vector3 Location, bool bCheck2DOnly = default);

    /// <summary>
    /// Function: BlockedTurret
    /// </summary>
    public unsafe bool BlockedTurret(BmSDK.Engine.Actor Turret);

    /// <summary>
    /// Function: BlockedSteamVent
    /// </summary>
    public unsafe bool BlockedSteamVent(BmSDK.Engine.Actor Vent);
}
