#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RDetonateGadgetInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RDetonateGadgetInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetCurrentDetonateTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor GetCurrentDetonateTarget();
}
