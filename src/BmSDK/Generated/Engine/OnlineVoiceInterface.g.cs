#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineVoiceInterface<br/>
/// (size = 68)
/// (flags = 16403)
/// </summary>
public partial interface OnlineVoiceInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: OnRecognitionComplete
    /// </summary>
    public unsafe void OnRecognitionComplete();

    /// <summary>
    /// Function: StopNetworkedVoice
    /// </summary>
    public unsafe void StopNetworkedVoice(byte LocalUserNum);

    /// <summary>
    /// Function: StartNetworkedVoice
    /// </summary>
    public unsafe void StartNetworkedVoice(byte LocalUserNum);

    /// <summary>
    /// Function: OnPlayerTalkingStateChange
    /// </summary>
    public unsafe void OnPlayerTalkingStateChange(BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player, bool bIsTalking);
}
