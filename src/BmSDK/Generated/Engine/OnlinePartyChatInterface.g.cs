#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlinePartyChatInterface<br/>
/// (size = 80)
/// (flags = 16403)
/// </summary>
public partial interface OnlinePartyChatInterface : BmSDK.Interface
{
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
    /// Function: OnSendPartyGameInvitesComplete
    /// </summary>
    public unsafe void OnSendPartyGameInvitesComplete(bool bWasSuccessful);
}
