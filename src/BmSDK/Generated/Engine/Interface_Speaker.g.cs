#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: Interface_Speaker<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface Interface_Speaker : BmSDK.Interface
{
    /// <summary>
    /// Function: Speak
    /// </summary>
    public unsafe void Speak(BmSDK.Engine.SoundCue Cue);
}
