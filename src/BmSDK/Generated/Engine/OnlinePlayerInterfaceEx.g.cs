#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlinePlayerInterfaceEx<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlinePlayerInterfaceEx : BmSDK.Interface
{
    /// <summary>
    /// Function: IsExternalRemoteDevice
    /// </summary>
    public unsafe bool IsExternalRemoteDevice();

    /// <summary>
    /// Function: OpenWebBrowser
    /// </summary>
    public unsafe void OpenWebBrowser(BmSDK.FString sURL);

    /// <summary>
    /// Function: GetNpAvailabilityForUser
    /// </summary>
    public unsafe int GetNpAvailabilityForUser(byte LocalUserNum);

    /// <summary>
    /// Function: CheckNpAvailabilityForUser
    /// </summary>
    public unsafe void CheckNpAvailabilityForUser(byte LocalUserNum);

    /// <summary>
    /// Function: StreamingInstall_Poll
    /// </summary>
    public unsafe int StreamingInstall_Poll(out int Percent, out int Time);

    /// <summary>
    /// Function: StreamingInstall_CheckChunk
    /// </summary>
    public unsafe bool StreamingInstall_CheckChunk(int Chunk);

    /// <summary>
    /// Function: StreamingInstall_IsFinished
    /// </summary>
    public unsafe bool StreamingInstall_IsFinished();

    /// <summary>
    /// Function: SetDurangoKinectState
    /// </summary>
    public unsafe void SetDurangoKinectState(bool bEnabled);

    /// <summary>
    /// Function: SetGTCStates
    /// </summary>
    public unsafe void SetGTCStates(bool bPlayEnabled, bool bPauseEnabled, bool bMenuEnabled, bool bViewEnabled, bool bBackEnabled);

    /// <summary>
    /// Function: SetGTCState
    /// </summary>
    public unsafe void SetGTCState(BmSDK.Engine.OnlineSubsystem.EGTCCommand Id, bool bState);

    /// <summary>
    /// Function: ClearGTCCommandDelegate
    /// </summary>
    public unsafe void ClearGTCCommandDelegate(System.IntPtr GTCCommandDelegate);

    /// <summary>
    /// Function: AddGTCCommandDelegate
    /// </summary>
    public unsafe void AddGTCCommandDelegate(System.IntPtr GTCCommandDelegate);

    /// <summary>
    /// Function: OnGTCCommand
    /// </summary>
    public unsafe void OnGTCCommand(BmSDK.Engine.OnlineSubsystem.EGTCCommand NewCommand);

    /// <summary>
    /// Function: NavigateBack
    /// </summary>
    public unsafe void NavigateBack();

    /// <summary>
    /// Function: OpenHelpManual
    /// </summary>
    public unsafe void OpenHelpManual(byte LocalUserNum);

    /// <summary>
    /// Function: VideoRecordStop
    /// </summary>
    public unsafe bool VideoRecordStop(byte LocalUserNum, byte VideoId, BmSDK.FString TitleStr);

    /// <summary>
    /// Function: VideoRecordStart
    /// </summary>
    public unsafe bool VideoRecordStart(byte LocalUserNum);

    /// <summary>
    /// Function: VideoRecord
    /// </summary>
    public unsafe void VideoRecord(byte LocalUserNum, byte VideoId, BmSDK.FString TitleStr, float TimeStart, float TimeStop);

    /// <summary>
    /// Function: VideoRecordSetGameSectionId
    /// </summary>
    public unsafe void VideoRecordSetGameSectionId(int SectionId);

    /// <summary>
    /// Function: VideoRecordAllowed
    /// </summary>
    public unsafe void VideoRecordAllowed(bool bEnabled);

    /// <summary>
    /// Function: IsVideoRecordAllowed
    /// </summary>
    public unsafe bool IsVideoRecordAllowed();

    /// <summary>
    /// Function: UnBindAllPlayers
    /// </summary>
    public unsafe void UnBindAllPlayers();

    /// <summary>
    /// Function: UnBindPlayer
    /// </summary>
    public unsafe void UnBindPlayer(int ControllerId);

    /// <summary>
    /// Function: ResumePlayer
    /// </summary>
    public unsafe int ResumePlayer(int ControllerId, int ControllerIndex);

    /// <summary>
    /// Function: ReBindPlayer
    /// </summary>
    public unsafe void ReBindPlayer(int ControllerId, int ControllerIndex);

    /// <summary>
    /// Function: BindPlayer
    /// </summary>
    public unsafe int BindPlayer(int ControllerIndex);

    /// <summary>
    /// Function: GetBoundCount
    /// </summary>
    public unsafe int GetBoundCount();

    /// <summary>
    /// Function: ReadOnlineAvatar
    /// </summary>
    public unsafe void ReadOnlineAvatar(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId, int Size, System.IntPtr ReadOnlineAvatarCompleteDelegate);

    /// <summary>
    /// Function: OnReadOnlineAvatarComplete
    /// </summary>
    public unsafe void OnReadOnlineAvatarComplete(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId, BmSDK.Engine.Texture2D Avatar);

    /// <summary>
    /// Function: ShowCustomMessageUI
    /// </summary>
    public unsafe bool ShowCustomMessageUI(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Recipients, BmSDK.FString MessageTitle, BmSDK.FString NonEditableMessage, BmSDK.FString EditableMessage = default);

    /// <summary>
    /// Function: ClearCrossTitleProfileSettings
    /// </summary>
    public unsafe void ClearCrossTitleProfileSettings(byte LocalUserNum, int TitleId);

    /// <summary>
    /// Function: GetCrossTitleProfileSettings
    /// </summary>
    public unsafe BmSDK.Engine.OnlineProfileSettings GetCrossTitleProfileSettings(byte LocalUserNum, int TitleId);

    /// <summary>
    /// Function: ClearReadCrossTitleProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe void ClearReadCrossTitleProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate);

    /// <summary>
    /// Function: AddReadCrossTitleProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe void AddReadCrossTitleProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate);

    /// <summary>
    /// Function: OnReadCrossTitleProfileSettingsComplete
    /// </summary>
    public unsafe void OnReadCrossTitleProfileSettingsComplete(byte LocalUserNum, int TitleId, bool bWasSuccessful);

    /// <summary>
    /// Function: ReadCrossTitleProfileSettings
    /// </summary>
    public unsafe bool ReadCrossTitleProfileSettings(byte LocalUserNum, int TitleId, BmSDK.Engine.OnlineProfileSettings ProfileSettings);

    /// <summary>
    /// Function: UnlockAvatarAward
    /// </summary>
    public unsafe bool UnlockAvatarAward(byte LocalUserNum, int AvatarItemId);

    /// <summary>
    /// Function: GetTimeSinceGuideLastClosed
    /// </summary>
    public unsafe float GetTimeSinceGuideLastClosed();

    /// <summary>
    /// Function: CreateInfocastSystem
    /// </summary>
    public unsafe void CreateInfocastSystem();

    /// <summary>
    /// Function: ClearNewInfocastDelegate
    /// </summary>
    public unsafe void ClearNewInfocastDelegate(System.IntPtr InfocastDelegate);

    /// <summary>
    /// Function: AddNewInfocastDelegate
    /// </summary>
    public unsafe void AddNewInfocastDelegate(System.IntPtr InfocastDelegate);

    /// <summary>
    /// Function: OnNewInfocast
    /// </summary>
    public unsafe void OnNewInfocast(BmSDK.FString Infocast);

    /// <summary>
    /// Function: ShowCustomPlayersUI
    /// </summary>
    public unsafe bool ShowCustomPlayersUI(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.FString Title, BmSDK.FString Description);

    /// <summary>
    /// Function: ShowPlayersUI
    /// </summary>
    public unsafe bool ShowPlayersUI(byte LocalUserNum);

    /// <summary>
    /// Function: ShowGuideUI
    /// </summary>
    public unsafe bool ShowGuideUI();

    /// <summary>
    /// Function: ShowFriendsInviteUI
    /// </summary>
    public unsafe bool ShowFriendsInviteUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);

    /// <summary>
    /// Function: ClearProfileDataChangedDelegate
    /// </summary>
    public unsafe void ClearProfileDataChangedDelegate(byte LocalUserNum, System.IntPtr ProfileDataChangedDelegate);

    /// <summary>
    /// Function: AddProfileDataChangedDelegate
    /// </summary>
    public unsafe void AddProfileDataChangedDelegate(byte LocalUserNum, System.IntPtr ProfileDataChangedDelegate);

    /// <summary>
    /// Function: OnProfileDataChanged
    /// </summary>
    public unsafe void OnProfileDataChanged();

    /// <summary>
    /// Function: UnlockGamerPicture
    /// </summary>
    public unsafe bool UnlockGamerPicture(byte LocalUserNum, int PictureId);

    /// <summary>
    /// Function: IsDeviceValid
    /// </summary>
    public unsafe bool IsDeviceValid(int DeviceID, int SizeNeeded = default);

    /// <summary>
    /// Function: GetDeviceSelectionResults
    /// </summary>
    public unsafe int GetDeviceSelectionResults(byte LocalUserNum, out BmSDK.FString DeviceName);

    /// <summary>
    /// Function: ClearDeviceSelectionDoneDelegate
    /// </summary>
    public unsafe void ClearDeviceSelectionDoneDelegate(byte LocalUserNum, System.IntPtr DeviceDelegate);

    /// <summary>
    /// Function: AddDeviceSelectionDoneDelegate
    /// </summary>
    public unsafe void AddDeviceSelectionDoneDelegate(byte LocalUserNum, System.IntPtr DeviceDelegate);

    /// <summary>
    /// Function: OnDeviceSelectionComplete
    /// </summary>
    public unsafe void OnDeviceSelectionComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ShowDeviceSelectionUI
    /// </summary>
    public unsafe bool ShowDeviceSelectionUI(byte LocalUserNum, int SizeNeeded, bool bForceShowUI = default, bool bManageStorage = default);

    /// <summary>
    /// Function: ShowMembershipMarketplaceUI
    /// </summary>
    public unsafe bool ShowMembershipMarketplaceUI(byte LocalUserNum);

    /// <summary>
    /// Function: ShowContentMarketplaceUI
    /// </summary>
    public unsafe bool ShowContentMarketplaceUI(byte LocalUserNum, int CategoryMask = default, int OfferId = default);

    /// <summary>
    /// Function: ShowInviteUI
    /// </summary>
    public unsafe bool ShowInviteUI(byte LocalUserNum, BmSDK.FString InviteText = default);

    /// <summary>
    /// Function: ShowAchievementsUI
    /// </summary>
    public unsafe bool ShowAchievementsUI(byte LocalUserNum);

    /// <summary>
    /// Function: ShowMessagesUI
    /// </summary>
    public unsafe bool ShowMessagesUI(byte LocalUserNum);

    /// <summary>
    /// Function: ShowTokenRedemptionUI
    /// </summary>
    public unsafe bool ShowTokenRedemptionUI(byte LocalUserNum, BmSDK.FString OfferId = default);

    /// <summary>
    /// Function: ShowAccountPickerUI
    /// </summary>
    public unsafe bool ShowAccountPickerUI(byte LocalUserNum);

    /// <summary>
    /// Function: ShowGamerCardUI
    /// </summary>
    public unsafe bool ShowGamerCardUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, BmSDK.FString NickName = default);

    /// <summary>
    /// Function: ShowFeedbackUI
    /// </summary>
    public unsafe bool ShowFeedbackUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);
}
