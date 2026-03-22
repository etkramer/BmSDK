#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RJammerInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface RJammerInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetParameterInterference
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName GetParameterInterference();

    /// <summary>
    /// Function: GetParameterAngle
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName GetParameterAngle();
}
