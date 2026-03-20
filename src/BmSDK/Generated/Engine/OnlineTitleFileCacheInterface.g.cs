#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineTitleFileCacheInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineTitleFileCacheInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: AttemptGetDownloadFileSize
    /// </summary>
    public unsafe int AttemptGetDownloadFileSize(BmSDK.FString Filename, bool KeepHandle = default);

    /// <summary>
    /// Function: FindFolders
    /// </summary>
    public unsafe void FindFolders(out BmSDK.TArray<BmSDK.FString> Results);

    /// <summary>
    /// Function: FindFiles
    /// </summary>
    public unsafe void FindFiles(out BmSDK.TArray<BmSDK.FString> Results, BmSDK.FString Subfolder);

    /// <summary>
    /// Function: DeleteTitleFile
    /// </summary>
    public unsafe bool DeleteTitleFile(BmSDK.FString Filename);

    /// <summary>
    /// Function: DeleteTitleFiles
    /// </summary>
    public unsafe bool DeleteTitleFiles(float MaxAgeSeconds);

    /// <summary>
    /// Function: ClearCachedFile
    /// </summary>
    public unsafe bool ClearCachedFile(BmSDK.FString Filename);

    /// <summary>
    /// Function: ClearCachedFiles
    /// </summary>
    public unsafe bool ClearCachedFiles();

    /// <summary>
    /// Function: GetTitleFileLogicalName
    /// </summary>
    public unsafe BmSDK.FString GetTitleFileLogicalName(BmSDK.FString Filename);

    /// <summary>
    /// Function: GetTitleFileHash
    /// </summary>
    public unsafe BmSDK.FString GetTitleFileHash(BmSDK.FString Filename);

    /// <summary>
    /// Function: GetTitleFileState
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetTitleFileState(BmSDK.FString Filename);

    /// <summary>
    /// Function: GetTitleFileContents
    /// </summary>
    public unsafe bool GetTitleFileContents(BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents);

    /// <summary>
    /// Function: AddDeleteTitleFileCompleteDelegate
    /// </summary>
    public unsafe void AddDeleteTitleFileCompleteDelegate(System.IntPtr DeleteCompleteDelegate);

    /// <summary>
    /// Function: ClearDeleteTitleFileCompleteDelegate
    /// </summary>
    public unsafe void ClearDeleteTitleFileCompleteDelegate(System.IntPtr DeleteCompleteDelegate);

    /// <summary>
    /// Function: OnDeleteTitleFileComplete
    /// </summary>
    public unsafe void OnDeleteTitleFileComplete(bool bWasSuccessful, BmSDK.FString Filename, float timeTaken);

    /// <summary>
    /// Function: ClearSaveTitleFileCompleteDelegate
    /// </summary>
    public unsafe void ClearSaveTitleFileCompleteDelegate(System.IntPtr SaveCompleteDelegate);

    /// <summary>
    /// Function: AddSaveTitleFileCompleteDelegate
    /// </summary>
    public unsafe void AddSaveTitleFileCompleteDelegate(System.IntPtr SaveCompleteDelegate);

    /// <summary>
    /// Function: OnSaveTitleFileComplete
    /// </summary>
    public unsafe void OnSaveTitleFileComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesTransferred, float timeTaken);

    /// <summary>
    /// Function: SaveTitleFile
    /// </summary>
    public unsafe bool SaveTitleFile(BmSDK.FString Filename, BmSDK.FString LogicalName, BmSDK.TArray<byte> FileContents);

    /// <summary>
    /// Function: ClearLoadTitleFileCompleteDelegate
    /// </summary>
    public unsafe void ClearLoadTitleFileCompleteDelegate(System.IntPtr LoadCompleteDelegate);

    /// <summary>
    /// Function: AddLoadTitleFileCompleteDelegate
    /// </summary>
    public unsafe void AddLoadTitleFileCompleteDelegate(System.IntPtr LoadCompleteDelegate);

    /// <summary>
    /// Function: OnLoadTitleFileComplete
    /// </summary>
    public unsafe void OnLoadTitleFileComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesTransferred, float timeTaken);

    /// <summary>
    /// Function: LoadTitleFile
    /// </summary>
    public unsafe bool LoadTitleFile(BmSDK.FString Filename);
}
