#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: Interface_AudioImpact<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface Interface_AudioImpact : BmSDK.Interface
{
    /// <summary>
    /// Function: GetImpactAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GetImpactAudioEvent(BmSDK.Engine.AkWwise.EAkWorldMaterial Mat);
}
