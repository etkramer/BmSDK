#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineContentInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineContentInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: ClearSaveGames
    /// </summary>
    public unsafe bool ClearSaveGames(byte LocalUserNum);

    /// <summary>
    /// Function: DeleteSaveGame
    /// </summary>
    public unsafe bool DeleteSaveGame(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename);

    /// <summary>
    /// Function: ClearWriteSaveGameDataComplete
    /// </summary>
    public unsafe void ClearWriteSaveGameDataComplete(byte LocalUserNum, System.IntPtr WriteSaveGameDataCompleteDelegate);

    /// <summary>
    /// Function: AddWriteSaveGameDataComplete
    /// </summary>
    public unsafe void AddWriteSaveGameDataComplete(byte LocalUserNum, System.IntPtr WriteSaveGameDataCompleteDelegate);

    /// <summary>
    /// Function: OnWriteSaveGameDataComplete
    /// </summary>
    public unsafe void OnWriteSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName);

    /// <summary>
    /// Function: WriteSaveGameData
    /// </summary>
    public unsafe bool WriteSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName, out BmSDK.TArray<byte> SaveGameData);

    /// <summary>
    /// Function: ClearReadSaveGameDataComplete
    /// </summary>
    public unsafe void ClearReadSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate);

    /// <summary>
    /// Function: AddReadSaveGameDataComplete
    /// </summary>
    public unsafe void AddReadSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate);

    /// <summary>
    /// Function: OnReadSaveGameDataComplete
    /// </summary>
    public unsafe void OnReadSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName);

    /// <summary>
    /// Function: GetSaveGameData
    /// </summary>
    public unsafe bool GetSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName, out byte bIsValid, out BmSDK.TArray<byte> SaveGameData);

    /// <summary>
    /// Function: ReadSaveGameData
    /// </summary>
    public unsafe bool ReadSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName);

    /// <summary>
    /// Function: GetAvailableDownloadCounts
    /// </summary>
    public unsafe void GetAvailableDownloadCounts(byte LocalUserNum, out int NewDownloads, out int TotalDownloads);

    /// <summary>
    /// Function: ClearQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe void ClearQueryAvailableDownloadsComplete(byte LocalUserNum, System.IntPtr QueryDownloadsDelegate);

    /// <summary>
    /// Function: AddQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe void AddQueryAvailableDownloadsComplete(byte LocalUserNum, System.IntPtr QueryDownloadsDelegate);

    /// <summary>
    /// Function: OnQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe void OnQueryAvailableDownloadsComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: QueryAvailableDownloads
    /// </summary>
    public unsafe bool QueryAvailableDownloads(byte LocalUserNum, int CategoryMask = default);

    /// <summary>
    /// Function: ClearCrossTitleSaveGames
    /// </summary>
    public unsafe bool ClearCrossTitleSaveGames(byte LocalUserNum);

    /// <summary>
    /// Function: ClearReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe void ClearReadCrossTitleSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate);

    /// <summary>
    /// Function: AddReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe void AddReadCrossTitleSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate);

    /// <summary>
    /// Function: OnReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe void OnReadCrossTitleSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName);

    /// <summary>
    /// Function: GetCrossTitleSaveGameData
    /// </summary>
    public unsafe bool GetCrossTitleSaveGameData(byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName, out byte bIsValid, out BmSDK.TArray<byte> SaveGameData);

    /// <summary>
    /// Function: ReadCrossTitleSaveGameData
    /// </summary>
    public unsafe bool ReadCrossTitleSaveGameData(byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName);

    /// <summary>
    /// Function: ClearReadCrossTitleContentCompleteDelegate
    /// </summary>
    public unsafe void ClearReadCrossTitleContentCompleteDelegate(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate);

    /// <summary>
    /// Function: AddReadCrossTitleContentCompleteDelegate
    /// </summary>
    public unsafe void AddReadCrossTitleContentCompleteDelegate(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate);

    /// <summary>
    /// Function: OnReadCrossTitleContentComplete
    /// </summary>
    public unsafe void OnReadCrossTitleContentComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: GetCrossTitleContentList
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineCrossTitleContent> ContentList);

    /// <summary>
    /// Function: ClearCrossTitleContentList
    /// </summary>
    public unsafe void ClearCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType);

    /// <summary>
    /// Function: ReadCrossTitleContentList
    /// </summary>
    public unsafe bool ReadCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, int TitleId = default, int DeviceID = default);

    /// <summary>
    /// Function: GetUserLanguage
    /// </summary>
    public unsafe BmSDK.FString GetUserLanguage();

    /// <summary>
    /// Function: GetUserCountryCode
    /// </summary>
    public unsafe BmSDK.FString GetUserCountryCode();

    /// <summary>
    /// Function: ShowPS4DownloadList
    /// </summary>
    public unsafe void ShowPS4DownloadList(byte LocalUserNum);

    /// <summary>
    /// Function: ShowPS4StoreIcon
    /// </summary>
    public unsafe void ShowPS4StoreIcon(bool bShow, int Position = default);

    /// <summary>
    /// Function: BrowseInGameStoreItem
    /// </summary>
    public unsafe void BrowseInGameStoreItem(byte LocalUserNum, BmSDK.FString ItemId);

    /// <summary>
    /// Function: PurchaseInGameStoreItem
    /// </summary>
    public unsafe void PurchaseInGameStoreItem(byte LocalUserNum, BmSDK.FString ItemId);

    /// <summary>
    /// Function: ClearPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe void ClearPurchaseInGameStoreContentComplete(byte LocalUserNum, System.IntPtr PurchaseInGameStoreContentComplete);

    /// <summary>
    /// Function: AddPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe void AddPurchaseInGameStoreContentComplete(byte LocalUserNum, System.IntPtr PurchaseInGameStoreContentComplete);

    /// <summary>
    /// Function: OnPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe void OnPurchaseInGameStoreContentComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: GetInGameStoreContentList
    /// </summary>
    public unsafe void GetInGameStoreContentList(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent> ContentList);

    /// <summary>
    /// Function: ReadInGameStoreContentList
    /// </summary>
    public unsafe bool ReadInGameStoreContentList(byte LocalUserNum);

    /// <summary>
    /// Function: ClearInGameStoreContentList
    /// </summary>
    public unsafe void ClearInGameStoreContentList(byte LocalUserNum);

    /// <summary>
    /// Function: ClearReadInGameStoreContentComplete
    /// </summary>
    public unsafe void ClearReadInGameStoreContentComplete(byte LocalUserNum, System.IntPtr ReadInGameStoreContentComplete);

    /// <summary>
    /// Function: AddReadInGameStoreContentComplete
    /// </summary>
    public unsafe void AddReadInGameStoreContentComplete(byte LocalUserNum, System.IntPtr ReadInGameStoreContentComplete);

    /// <summary>
    /// Function: OnReadInGameStoreContentComplete
    /// </summary>
    public unsafe void OnReadInGameStoreContentComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ClearContentStatusChangeDelegate
    /// </summary>
    public unsafe void ClearContentStatusChangeDelegate(System.IntPtr ContentStatusChangeDelegate);

    /// <summary>
    /// Function: AddContentStatusChangeDelegate
    /// </summary>
    public unsafe void AddContentStatusChangeDelegate(System.IntPtr ContentStatusChangeDelegate);

    /// <summary>
    /// Function: OnContentStatusChange
    /// </summary>
    public unsafe void OnContentStatusChange();

    /// <summary>
    /// Function: GetContentList
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent> ContentList);

    /// <summary>
    /// Function: ClearContentList
    /// </summary>
    public unsafe void ClearContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType);

    /// <summary>
    /// Function: ReadContentList
    /// </summary>
    public unsafe bool ReadContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, int DeviceID = default);

    /// <summary>
    /// Function: HasContentUpdated
    /// </summary>
    public unsafe bool HasContentUpdated();

    /// <summary>
    /// Function: ClearReadContentComplete
    /// </summary>
    public unsafe void ClearReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate);

    /// <summary>
    /// Function: AddReadContentComplete
    /// </summary>
    public unsafe void AddReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate);

    /// <summary>
    /// Function: OnReadContentComplete
    /// </summary>
    public unsafe void OnReadContentComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ClearContentChangeDelegate
    /// </summary>
    public unsafe void ClearContentChangeDelegate(System.IntPtr ContentDelegate, byte LocalUserNum = default);

    /// <summary>
    /// Function: AddContentChangeDelegate
    /// </summary>
    public unsafe void AddContentChangeDelegate(System.IntPtr ContentDelegate, byte LocalUserNum = default);

    /// <summary>
    /// Function: OnContentChange
    /// </summary>
    public unsafe void OnContentChange();
}
