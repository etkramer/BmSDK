#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RHUDInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface RHUDInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: BlockLevelName
    /// </summary>
    public unsafe bool BlockLevelName();

    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe void DrawHUD(BmSDK.Engine.Canvas Canvas);
}
