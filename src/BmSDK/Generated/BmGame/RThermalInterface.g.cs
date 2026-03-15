#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RThermalInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface RThermalInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: SetInThermalMode
    /// </summary>
    public unsafe void SetInThermalMode(bool On, bool bForceOff);
}
