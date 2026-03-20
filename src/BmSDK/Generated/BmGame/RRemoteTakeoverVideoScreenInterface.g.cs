#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RRemoteTakeoverVideoScreenInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RRemoteTakeoverVideoScreenInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: SetStaticTransitionParameter
    /// </summary>
    public unsafe void SetStaticTransitionParameter(float val);

    /// <summary>
    /// Function: RevertToStandardTexture
    /// </summary>
    public unsafe void RevertToStandardTexture();

    /// <summary>
    /// Function: SetTakeoverTexture
    /// </summary>
    public unsafe void SetTakeoverTexture(BmSDK.Engine.TextureRenderTarget2D takeoverTexture);

    /// <summary>
    /// Function: CanBeTakenOverByScarecrow
    /// </summary>
    public unsafe bool CanBeTakenOverByScarecrow();

    /// <summary>
    /// Function: CanBeTakenOverByRiddler
    /// </summary>
    public unsafe bool CanBeTakenOverByRiddler();
}
