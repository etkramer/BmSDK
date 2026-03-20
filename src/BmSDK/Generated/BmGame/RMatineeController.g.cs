#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RMatineeController<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RMatineeController : BmSDK.Interface
{
    /// <summary>
    /// Function: ClearMatinee
    /// </summary>
    public unsafe void ClearMatinee();

    /// <summary>
    /// Function: SetMatinee
    /// </summary>
    public unsafe void SetMatinee(BmSDK.Engine.SeqAct_Interp M);
}
