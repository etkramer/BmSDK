#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RPassThroughAdjustMovementDirectionInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface RPassThroughAdjustMovementDirectionInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: AdjustMovementDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 AdjustMovementDirection(System.Numerics.Vector3 MovementDir);
}
