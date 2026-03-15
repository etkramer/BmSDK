#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RXrayInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface RXrayInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe void SetInXrayMode(bool On, bool bForceOff);
}
