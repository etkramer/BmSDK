#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlinePlayerInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlinePlayerInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: ClearMsgBoxUIDelegate
    /// </summary>
    public unsafe void ClearMsgBoxUIDelegate(System.IntPtr MsgDelegate);

    /// <summary>
    /// Function: AddMsgBoxUIDoneDelegate
    /// </summary>
    public unsafe void AddMsgBoxUIDoneDelegate(System.IntPtr MsgDelegate);

    /// <summary>
    /// Function: OnMsgBoxUIComplete
    /// </summary>
    public unsafe void OnMsgBoxUIComplete(int ButtonResult);

    /// <summary>
    /// Function: ShowSystemMsgBoxUI
    /// </summary>
    public unsafe bool ShowSystemMsgBoxUI(byte LocalUserNum, int SysMsg);

    /// <summary>
    /// Function: GetAchievements
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetAchievements(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FAchievementDetails> Achievements, int TitleId = default);

    /// <summary>
    /// Function: ClearReadAchievementsCompleteDelegate
    /// </summary>
    public unsafe void ClearReadAchievementsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadAchievementsCompleteDelegate);

    /// <summary>
    /// Function: AddReadAchievementsCompleteDelegate
    /// </summary>
    public unsafe void AddReadAchievementsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadAchievementsCompleteDelegate);

    /// <summary>
    /// Function: OnReadAchievementsComplete
    /// </summary>
    public unsafe void OnReadAchievementsComplete(int TitleId);

    /// <summary>
    /// Function: ReadAchievements
    /// </summary>
    public unsafe bool ReadAchievements(byte LocalUserNum, int TitleId = default, bool bShouldReadText = default, bool bShouldReadImages = default);

    /// <summary>
    /// Function: ClearUnlockAchievementCompleteDelegate
    /// </summary>
    public unsafe void ClearUnlockAchievementCompleteDelegate(byte LocalUserNum, System.IntPtr UnlockAchievementCompleteDelegate);

    /// <summary>
    /// Function: AddUnlockAchievementCompleteDelegate
    /// </summary>
    public unsafe void AddUnlockAchievementCompleteDelegate(byte LocalUserNum, System.IntPtr UnlockAchievementCompleteDelegate);

    /// <summary>
    /// Function: OnUnlockAchievementComplete
    /// </summary>
    public unsafe void OnUnlockAchievementComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: UnlockAchievement
    /// </summary>
    public unsafe bool UnlockAchievement(byte LocalUserNum, int AchievementId, float PercentComplete = default);

    /// <summary>
    /// Function: DeleteMessage
    /// </summary>
    public unsafe bool DeleteMessage(byte LocalUserNum, int MessageIndex);

    /// <summary>
    /// Function: ClearFriendMessageReceivedDelegate
    /// </summary>
    public unsafe void ClearFriendMessageReceivedDelegate(byte LocalUserNum, System.IntPtr MessageDelegate);

    /// <summary>
    /// Function: AddFriendMessageReceivedDelegate
    /// </summary>
    public unsafe void AddFriendMessageReceivedDelegate(byte LocalUserNum, System.IntPtr MessageDelegate);

    /// <summary>
    /// Function: OnFriendMessageReceived
    /// </summary>
    public unsafe void OnFriendMessageReceived(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId SendingPlayer, BmSDK.FString SendingNick, BmSDK.FString Message);

    /// <summary>
    /// Function: GetFriendMessages
    /// </summary>
    public unsafe void GetFriendMessages(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage> FriendMessages);

    /// <summary>
    /// Function: ClearJoinFriendGameCompleteDelegate
    /// </summary>
    public unsafe void ClearJoinFriendGameCompleteDelegate(System.IntPtr JoinFriendGameCompleteDelegate);

    /// <summary>
    /// Function: AddJoinFriendGameCompleteDelegate
    /// </summary>
    public unsafe void AddJoinFriendGameCompleteDelegate(System.IntPtr JoinFriendGameCompleteDelegate);

    /// <summary>
    /// Function: OnJoinFriendGameComplete
    /// </summary>
    public unsafe void OnJoinFriendGameComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: JoinFriendGame
    /// </summary>
    public unsafe bool JoinFriendGame(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Friend);

    /// <summary>
    /// Function: ClearReceivedGameInviteDelegate
    /// </summary>
    public unsafe void ClearReceivedGameInviteDelegate(byte LocalUserNum, System.IntPtr ReceivedGameInviteDelegate);

    /// <summary>
    /// Function: AddReceivedGameInviteDelegate
    /// </summary>
    public unsafe void AddReceivedGameInviteDelegate(byte LocalUserNum, System.IntPtr ReceivedGameInviteDelegate);

    /// <summary>
    /// Function: OnReceivedGameInvite
    /// </summary>
    public unsafe void OnReceivedGameInvite(byte LocalUserNum, BmSDK.FString InviterName);

    /// <summary>
    /// Function: SendGameInviteToFriends
    /// </summary>
    public unsafe bool SendGameInviteToFriends(byte LocalUserNum, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Friends, BmSDK.FString Text = default);

    /// <summary>
    /// Function: SendGameInviteToFriend
    /// </summary>
    public unsafe bool SendGameInviteToFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Friend, BmSDK.FString Text = default);

    /// <summary>
    /// Function: SendMessageToFriend
    /// </summary>
    public unsafe bool SendMessageToFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Friend, BmSDK.FString Message);

    /// <summary>
    /// Function: ClearFriendInviteReceivedDelegate
    /// </summary>
    public unsafe void ClearFriendInviteReceivedDelegate(byte LocalUserNum, System.IntPtr InviteDelegate);

    /// <summary>
    /// Function: AddFriendInviteReceivedDelegate
    /// </summary>
    public unsafe void AddFriendInviteReceivedDelegate(byte LocalUserNum, System.IntPtr InviteDelegate);

    /// <summary>
    /// Function: OnFriendInviteReceived
    /// </summary>
    public unsafe void OnFriendInviteReceived(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer, BmSDK.FString RequestingNick, BmSDK.FString Message);

    /// <summary>
    /// Function: RemoveFriend
    /// </summary>
    public unsafe bool RemoveFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId FormerFriend);

    /// <summary>
    /// Function: DenyFriendInvite
    /// </summary>
    public unsafe bool DenyFriendInvite(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer);

    /// <summary>
    /// Function: AcceptFriendInvite
    /// </summary>
    public unsafe bool AcceptFriendInvite(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer);

    /// <summary>
    /// Function: ClearAddFriendByNameCompleteDelegate
    /// </summary>
    public unsafe void ClearAddFriendByNameCompleteDelegate(byte LocalUserNum, System.IntPtr FriendDelegate);

    /// <summary>
    /// Function: AddAddFriendByNameCompleteDelegate
    /// </summary>
    public unsafe void AddAddFriendByNameCompleteDelegate(byte LocalUserNum, System.IntPtr FriendDelegate);

    /// <summary>
    /// Function: OnAddFriendByNameComplete
    /// </summary>
    public unsafe void OnAddFriendByNameComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: AddFriendByName
    /// </summary>
    public unsafe bool AddFriendByName(byte LocalUserNum, BmSDK.FString FriendName, BmSDK.FString Message = default);

    /// <summary>
    /// Function: AddFriend
    /// </summary>
    public unsafe bool AddFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NewFriend, BmSDK.FString Message = default);

    /// <summary>
    /// Function: GetKeyboardInputResults
    /// </summary>
    public unsafe BmSDK.FString GetKeyboardInputResults(out byte bWasCanceled);

    /// <summary>
    /// Function: ClearKeyboardInputDoneDelegate
    /// </summary>
    public unsafe void ClearKeyboardInputDoneDelegate(System.IntPtr InputDelegate);

    /// <summary>
    /// Function: AddKeyboardInputDoneDelegate
    /// </summary>
    public unsafe void AddKeyboardInputDoneDelegate(System.IntPtr InputDelegate);

    /// <summary>
    /// Function: OnKeyboardInputComplete
    /// </summary>
    public unsafe void OnKeyboardInputComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ShowKeyboardUI
    /// </summary>
    public unsafe bool ShowKeyboardUI(byte LocalUserNum, BmSDK.FString TitleText, BmSDK.FString DescriptionText, bool bIsPassword = default, bool bShouldValidate = default, BmSDK.FString DefaultText = default, int MaxResultLength = default);

    /// <summary>
    /// Function: SetOnlineStatus
    /// </summary>
    public unsafe void SetOnlineStatus(byte LocalUserNum, int StatusId, out BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSetting> LocalizedStringSettings, out BmSDK.TArray<BmSDK.Engine.Settings.FSettingsProperty> Properties);

    /// <summary>
    /// Function: GetFriendsList
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetFriendsList(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend> Friends, int Count = default, int StartingAt = default);

    /// <summary>
    /// Function: ClearReadFriendsCompleteDelegate
    /// </summary>
    public unsafe void ClearReadFriendsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadFriendsCompleteDelegate);

    /// <summary>
    /// Function: AddReadFriendsCompleteDelegate
    /// </summary>
    public unsafe void AddReadFriendsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadFriendsCompleteDelegate);

    /// <summary>
    /// Function: OnReadFriendsComplete
    /// </summary>
    public unsafe void OnReadFriendsComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ReadFriendsList
    /// </summary>
    public unsafe bool ReadFriendsList(byte LocalUserNum, int Count = default, int StartingAt = default);

    /// <summary>
    /// Function: ClearWritePlayerStorageCompleteDelegate
    /// </summary>
    public unsafe void ClearWritePlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr WritePlayerStorageCompleteDelegate);

    /// <summary>
    /// Function: AddWritePlayerStorageCompleteDelegate
    /// </summary>
    public unsafe void AddWritePlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr WritePlayerStorageCompleteDelegate);

    /// <summary>
    /// Function: OnWritePlayerStorageComplete
    /// </summary>
    public unsafe void OnWritePlayerStorageComplete(byte LocalUserNum, bool bWasSuccessful);

    /// <summary>
    /// Function: WritePlayerStorage
    /// </summary>
    public unsafe bool WritePlayerStorage(byte LocalUserNum, BmSDK.Engine.OnlinePlayerStorage PlayerStorage, int DeviceID = default);

    /// <summary>
    /// Function: GetPlayerStorage
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePlayerStorage GetPlayerStorage(byte LocalUserNum);

    /// <summary>
    /// Function: ClearReadPlayerStorageForNetIdCompleteDelegate
    /// </summary>
    public unsafe void ClearReadPlayerStorageForNetIdCompleteDelegate(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, System.IntPtr ReadPlayerStorageForNetIdCompleteDelegate);

    /// <summary>
    /// Function: AddReadPlayerStorageForNetIdCompleteDelegate
    /// </summary>
    public unsafe void AddReadPlayerStorageForNetIdCompleteDelegate(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, System.IntPtr ReadPlayerStorageForNetIdCompleteDelegate);

    /// <summary>
    /// Function: OnReadPlayerStorageForNetIdComplete
    /// </summary>
    public unsafe void OnReadPlayerStorageForNetIdComplete(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, bool bWasSuccessful);

    /// <summary>
    /// Function: ReadPlayerStorageForNetId
    /// </summary>
    public unsafe bool ReadPlayerStorageForNetId(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, BmSDK.Engine.OnlinePlayerStorage PlayerStorage);

    /// <summary>
    /// Function: ClearReadPlayerStorageCompleteDelegate
    /// </summary>
    public unsafe void ClearReadPlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr ReadPlayerStorageCompleteDelegate);

    /// <summary>
    /// Function: AddReadPlayerStorageCompleteDelegate
    /// </summary>
    public unsafe void AddReadPlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr ReadPlayerStorageCompleteDelegate);

    /// <summary>
    /// Function: OnReadPlayerStorageComplete
    /// </summary>
    public unsafe void OnReadPlayerStorageComplete(byte LocalUserNum, bool bWasSuccessful);

    /// <summary>
    /// Function: ReadPlayerStorage
    /// </summary>
    public unsafe bool ReadPlayerStorage(byte LocalUserNum, BmSDK.Engine.OnlinePlayerStorage PlayerStorage, int DeviceID = default);

    /// <summary>
    /// Function: ClearWriteProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe void ClearWriteProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr WriteProfileSettingsCompleteDelegate);

    /// <summary>
    /// Function: AddWriteProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe void AddWriteProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr WriteProfileSettingsCompleteDelegate);

    /// <summary>
    /// Function: OnWriteProfileSettingsComplete
    /// </summary>
    public unsafe void OnWriteProfileSettingsComplete(byte LocalUserNum, bool bWasSuccessful);

    /// <summary>
    /// Function: WriteProfileSettings
    /// </summary>
    public unsafe bool WriteProfileSettings(byte LocalUserNum, BmSDK.Engine.OnlineProfileSettings ProfileSettings);

    /// <summary>
    /// Function: GetProfileSettings
    /// </summary>
    public unsafe BmSDK.Engine.OnlineProfileSettings GetProfileSettings(byte LocalUserNum);

    /// <summary>
    /// Function: ClearReadProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe void ClearReadProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate);

    /// <summary>
    /// Function: AddReadProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe void AddReadProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate);

    /// <summary>
    /// Function: OnReadProfileSettingsComplete
    /// </summary>
    public unsafe void OnReadProfileSettingsComplete(byte LocalUserNum, bool bWasSuccessful);

    /// <summary>
    /// Function: ReadProfileSettings
    /// </summary>
    public unsafe bool ReadProfileSettings(byte LocalUserNum, BmSDK.Engine.OnlineProfileSettings ProfileSettings);

    /// <summary>
    /// Function: ClearFriendsChangeDelegate
    /// </summary>
    public unsafe void ClearFriendsChangeDelegate(byte LocalUserNum, System.IntPtr FriendsDelegate);

    /// <summary>
    /// Function: AddFriendsChangeDelegate
    /// </summary>
    public unsafe void AddFriendsChangeDelegate(byte LocalUserNum, System.IntPtr FriendsDelegate);

    /// <summary>
    /// Function: ClearMutingChangeDelegate
    /// </summary>
    public unsafe void ClearMutingChangeDelegate(System.IntPtr MutingDelegate);

    /// <summary>
    /// Function: AddMutingChangeDelegate
    /// </summary>
    public unsafe void AddMutingChangeDelegate(System.IntPtr MutingDelegate);

    /// <summary>
    /// Function: ClearLoginCancelledDelegate
    /// </summary>
    public unsafe void ClearLoginCancelledDelegate(System.IntPtr CancelledDelegate);

    /// <summary>
    /// Function: AddLoginCancelledDelegate
    /// </summary>
    public unsafe void AddLoginCancelledDelegate(System.IntPtr CancelledDelegate);

    /// <summary>
    /// Function: ClearLoginStatusChangeDelegate
    /// </summary>
    public unsafe void ClearLoginStatusChangeDelegate(System.IntPtr LoginStatusDelegate, byte LocalUserNum);

    /// <summary>
    /// Function: AddLoginStatusChangeDelegate
    /// </summary>
    public unsafe void AddLoginStatusChangeDelegate(System.IntPtr LoginStatusDelegate, byte LocalUserNum);

    /// <summary>
    /// Function: OnLoginStatusChange
    /// </summary>
    public unsafe void OnLoginStatusChange(BmSDK.Engine.OnlineSubsystem.ELoginStatus NewStatus, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NewId);

    /// <summary>
    /// Function: ClearLoginChangeDelegate
    /// </summary>
    public unsafe void ClearLoginChangeDelegate(System.IntPtr LoginDelegate);

    /// <summary>
    /// Function: AddLoginChangeDelegate
    /// </summary>
    public unsafe void AddLoginChangeDelegate(System.IntPtr LoginDelegate);

    /// <summary>
    /// Function: ShowFriendsUI
    /// </summary>
    public unsafe bool ShowFriendsUI(byte LocalUserNum);

    /// <summary>
    /// Function: IsMuted
    /// </summary>
    public unsafe bool IsMuted(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);

    /// <summary>
    /// Function: AreAnyFriends
    /// </summary>
    public unsafe bool AreAnyFriends(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FFriendsQuery> Query);

    /// <summary>
    /// Function: IsFriend
    /// </summary>
    public unsafe bool IsFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);

    /// <summary>
    /// Function: CanShowPresenceInformation
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanShowPresenceInformation(byte LocalUserNum);

    /// <summary>
    /// Function: CanViewPlayerProfiles
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanViewPlayerProfiles(byte LocalUserNum);

    /// <summary>
    /// Function: CanPurchaseContent
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanPurchaseContent(byte LocalUserNum);

    /// <summary>
    /// Function: CanDownloadUserContent
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanDownloadUserContent(byte LocalUserNum);

    /// <summary>
    /// Function: CanCommunicate
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanCommunicate(byte LocalUserNum);

    /// <summary>
    /// Function: CanPlayOnline
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanPlayOnline(byte LocalUserNum);

    /// <summary>
    /// Function: IsOnlineAccount
    /// </summary>
    public unsafe bool IsOnlineAccount(byte LocalUserNum);

    /// <summary>
    /// Function: IsLocalLogin
    /// </summary>
    public unsafe bool IsLocalLogin(byte LocalUserNum);

    /// <summary>
    /// Function: IsGuestLogin
    /// </summary>
    public unsafe bool IsGuestLogin(byte LocalUserNum);

    /// <summary>
    /// Function: GetPlayerDisplayName
    /// </summary>
    public unsafe BmSDK.FString GetPlayerDisplayName(byte LocalUserNum);

    /// <summary>
    /// Function: GetPlayerNickname
    /// </summary>
    public unsafe BmSDK.FString GetPlayerNickname(byte LocalUserNum);

    /// <summary>
    /// Function: GetUniquePlayerId
    /// </summary>
    public unsafe bool GetUniquePlayerId(byte LocalUserNum, out BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);

    /// <summary>
    /// Function: GetLoginStatus
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ELoginStatus GetLoginStatus(byte LocalUserNum);

    /// <summary>
    /// Function: ClearLogoutCompletedDelegate
    /// </summary>
    public unsafe void ClearLogoutCompletedDelegate(byte LocalUserNum, System.IntPtr LogoutDelegate);

    /// <summary>
    /// Function: AddLogoutCompletedDelegate
    /// </summary>
    public unsafe void AddLogoutCompletedDelegate(byte LocalUserNum, System.IntPtr LogoutDelegate);

    /// <summary>
    /// Function: OnLogoutCompleted
    /// </summary>
    public unsafe void OnLogoutCompleted(bool bWasSuccessful);

    /// <summary>
    /// Function: Logout
    /// </summary>
    public unsafe bool Logout(byte LocalUserNum);

    /// <summary>
    /// Function: ClearLoginFailedDelegate
    /// </summary>
    public unsafe void ClearLoginFailedDelegate(byte LocalUserNum, System.IntPtr LoginDelegate);

    /// <summary>
    /// Function: AddLoginFailedDelegate
    /// </summary>
    public unsafe void AddLoginFailedDelegate(byte LocalUserNum, System.IntPtr LoginDelegate);

    /// <summary>
    /// Function: OnLoginFailed
    /// </summary>
    public unsafe void OnLoginFailed(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus ErrorCode);

    /// <summary>
    /// Function: AutoLogin
    /// </summary>
    public unsafe bool AutoLogin();

    /// <summary>
    /// Function: Login
    /// </summary>
    public unsafe bool Login(byte LocalUserNum, BmSDK.FString LoginName, BmSDK.FString Password, bool bWantsLocalOnly = default);

    /// <summary>
    /// Function: ShowLoginUI
    /// </summary>
    public unsafe bool ShowLoginUI(bool bShowOnlineOnly = default);

    /// <summary>
    /// Function: OnFriendsChange
    /// </summary>
    public unsafe void OnFriendsChange();

    /// <summary>
    /// Function: OnMutingChange
    /// </summary>
    public unsafe void OnMutingChange();

    /// <summary>
    /// Function: OnLoginCancelled
    /// </summary>
    public unsafe void OnLoginCancelled();

    /// <summary>
    /// Function: OnLoginChange
    /// </summary>
    public unsafe void OnLoginChange(byte LocalUserNum);
}
