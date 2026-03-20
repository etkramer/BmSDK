#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RSpecialMoveListenerInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RSpecialMoveListenerInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: SpecialMoveFinished
    /// </summary>
    public unsafe void SpecialMoveFinished(BmSDK.BmGame.RSpecialMoveInstance MoveFinishing, BmSDK.BmGame.RPawnPlayer Pawn);
}
