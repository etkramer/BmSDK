#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RHUDInterface<br/>
/// (size = 84)
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

    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe void PreRender(BmSDK.Engine.Canvas Canvas);
}
