#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineVoiceInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineVoiceInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: UnmuteAll
    /// </summary>
    public unsafe bool UnmuteAll(byte LocalUserNum);

    /// <summary>
    /// Function: MuteAll
    /// </summary>
    public unsafe bool MuteAll(byte LocalUserNum, bool bAllowFriends);

    /// <summary>
    /// Function: SetSpeechRecognitionObject
    /// </summary>
    public unsafe bool SetSpeechRecognitionObject(byte LocalUserNum, BmSDK.Engine.SpeechRecognition SpeechRecogObj);

    /// <summary>
    /// Function: SelectVocabulary
    /// </summary>
    public unsafe bool SelectVocabulary(byte LocalUserNum, int VocabularyId);

    /// <summary>
    /// Function: ClearRecognitionCompleteDelegate
    /// </summary>
    public unsafe void ClearRecognitionCompleteDelegate(byte LocalUserNum, System.IntPtr RecognitionDelegate);

    /// <summary>
    /// Function: AddRecognitionCompleteDelegate
    /// </summary>
    public unsafe void AddRecognitionCompleteDelegate(byte LocalUserNum, System.IntPtr RecognitionDelegate);

    /// <summary>
    /// Function: OnRecognitionComplete
    /// </summary>
    public unsafe void OnRecognitionComplete();

    /// <summary>
    /// Function: GetRecognitionResults
    /// </summary>
    public unsafe bool GetRecognitionResults(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FSpeechRecognizedWord> Words);

    /// <summary>
    /// Function: StopSpeechRecognition
    /// </summary>
    public unsafe bool StopSpeechRecognition(byte LocalUserNum);

    /// <summary>
    /// Function: StartSpeechRecognition
    /// </summary>
    public unsafe bool StartSpeechRecognition(byte LocalUserNum);

    /// <summary>
    /// Function: StopNetworkedVoice
    /// </summary>
    public unsafe void StopNetworkedVoice(byte LocalUserNum);

    /// <summary>
    /// Function: StartNetworkedVoice
    /// </summary>
    public unsafe void StartNetworkedVoice(byte LocalUserNum);

    /// <summary>
    /// Function: ClearPlayerTalkingDelegate
    /// </summary>
    public unsafe void ClearPlayerTalkingDelegate(System.IntPtr TalkerDelegate);

    /// <summary>
    /// Function: AddPlayerTalkingDelegate
    /// </summary>
    public unsafe void AddPlayerTalkingDelegate(System.IntPtr TalkerDelegate);

    /// <summary>
    /// Function: OnPlayerTalkingStateChange
    /// </summary>
    public unsafe void OnPlayerTalkingStateChange(BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player, bool bIsTalking);

    /// <summary>
    /// Function: UnmuteRemoteTalker
    /// </summary>
    public unsafe bool UnmuteRemoteTalker(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bIsSystemWide = default);

    /// <summary>
    /// Function: MuteRemoteTalker
    /// </summary>
    public unsafe bool MuteRemoteTalker(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bIsSystemWide = default);

    /// <summary>
    /// Function: SetRemoteTalkerPriority
    /// </summary>
    public unsafe bool SetRemoteTalkerPriority(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, int Priority);

    /// <summary>
    /// Function: IsHeadsetPresent
    /// </summary>
    public unsafe bool IsHeadsetPresent(byte LocalUserNum);

    /// <summary>
    /// Function: IsRemotePlayerTalking
    /// </summary>
    public unsafe bool IsRemotePlayerTalking(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);

    /// <summary>
    /// Function: IsLocalPlayerTalking
    /// </summary>
    public unsafe bool IsLocalPlayerTalking(byte LocalUserNum);

    /// <summary>
    /// Function: UnregisterRemoteTalker
    /// </summary>
    public unsafe bool UnregisterRemoteTalker(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);

    /// <summary>
    /// Function: RegisterRemoteTalker
    /// </summary>
    public unsafe bool RegisterRemoteTalker(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);

    /// <summary>
    /// Function: UnregisterLocalTalker
    /// </summary>
    public unsafe bool UnregisterLocalTalker(byte LocalUserNum);

    /// <summary>
    /// Function: RegisterLocalTalker
    /// </summary>
    public unsafe bool RegisterLocalTalker(byte LocalUserNum);
}
