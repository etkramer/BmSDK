#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlinePartyChatInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlinePartyChatInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: IsInPartyChat
    /// </summary>
    public unsafe bool IsInPartyChat(byte LocalUserNum);

    /// <summary>
    /// Function: ShowCommunitySessionsUI
    /// </summary>
    public unsafe bool ShowCommunitySessionsUI(byte LocalUserNum);

    /// <summary>
    /// Function: ShowVoiceChannelUI
    /// </summary>
    public unsafe bool ShowVoiceChannelUI(byte LocalUserNum);

    /// <summary>
    /// Function: ShowPartyUI
    /// </summary>
    public unsafe bool ShowPartyUI(byte LocalUserNum);

    /// <summary>
    /// Function: GetPartyBandwidth
    /// </summary>
    public unsafe int GetPartyBandwidth();

    /// <summary>
    /// Function: SetPartyMemberCustomData
    /// </summary>
    public unsafe bool SetPartyMemberCustomData(byte LocalUserNum, int Data1, int Data2, int Data3, int Data4);

    /// <summary>
    /// Function: ClearPartyMembersInfoChangedDelegate
    /// </summary>
    public unsafe void ClearPartyMembersInfoChangedDelegate(byte LocalUserNum, System.IntPtr PartyMembersInfoChangedDelegate);

    /// <summary>
    /// Function: AddPartyMembersInfoChangedDelegate
    /// </summary>
    public unsafe void AddPartyMembersInfoChangedDelegate(byte LocalUserNum, System.IntPtr PartyMembersInfoChangedDelegate);

    /// <summary>
    /// Function: OnPartyMembersInfoChanged
    /// </summary>
    public unsafe void OnPartyMembersInfoChanged(BmSDK.FString PlayerName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, int CustomData1, int CustomData2, int CustomData3, int CustomData4);

    /// <summary>
    /// Function: ClearPartyMemberListChangedDelegate
    /// </summary>
    public unsafe void ClearPartyMemberListChangedDelegate(byte LocalUserNum, System.IntPtr PartyMemberListChangedDelegate);

    /// <summary>
    /// Function: AddPartyMemberListChangedDelegate
    /// </summary>
    public unsafe void AddPartyMemberListChangedDelegate(byte LocalUserNum, System.IntPtr PartyMemberListChangedDelegate);

    /// <summary>
    /// Function: OnPartyMemberListChanged
    /// </summary>
    public unsafe void OnPartyMemberListChanged(bool bJoinedOrLeft, BmSDK.FString PlayerName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);

    /// <summary>
    /// Function: GetPartyMemberInformation
    /// </summary>
    public unsafe bool GetPartyMemberInformation(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberId, out BmSDK.Engine.OnlineSubsystem.FOnlinePartyMember PartyMember);

    /// <summary>
    /// Function: GetPartyMembersInformation
    /// </summary>
    public unsafe bool GetPartyMembersInformation(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlinePartyMember> PartyMembers);

    /// <summary>
    /// Function: ClearSendPartyGameInvitesCompleteDelegate
    /// </summary>
    public unsafe void ClearSendPartyGameInvitesCompleteDelegate(byte LocalUserNum, System.IntPtr SendPartyGameInvitesCompleteDelegate);

    /// <summary>
    /// Function: AddSendPartyGameInvitesCompleteDelegate
    /// </summary>
    public unsafe void AddSendPartyGameInvitesCompleteDelegate(byte LocalUserNum, System.IntPtr SendPartyGameInvitesCompleteDelegate);

    /// <summary>
    /// Function: OnSendPartyGameInvitesComplete
    /// </summary>
    public unsafe void OnSendPartyGameInvitesComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: SendPartyGameInvites
    /// </summary>
    public unsafe bool SendPartyGameInvites(byte LocalUserNum);
}
