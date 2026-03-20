#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineTitleFileInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineTitleFileInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: ClearRequestTitleFileListCompleteDelegate
    /// </summary>
    public unsafe void ClearRequestTitleFileListCompleteDelegate(System.IntPtr RequestTitleFileListDelegate);

    /// <summary>
    /// Function: AddRequestTitleFileListCompleteDelegate
    /// </summary>
    public unsafe void AddRequestTitleFileListCompleteDelegate(System.IntPtr RequestTitleFileListDelegate);

    /// <summary>
    /// Function: OnRequestTitleFileListComplete
    /// </summary>
    public unsafe void OnRequestTitleFileListComplete(bool bWasSuccessful, BmSDK.FString ResultStr);

    /// <summary>
    /// Function: RequestTitleFileList
    /// </summary>
    public unsafe void RequestTitleFileList();

    /// <summary>
    /// Function: ClearDownloadedFile
    /// </summary>
    public unsafe bool ClearDownloadedFile(BmSDK.FString Filename);

    /// <summary>
    /// Function: ClearDownloadedFiles
    /// </summary>
    public unsafe bool ClearDownloadedFiles();

    /// <summary>
    /// Function: GetTitleFileState
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetTitleFileState(BmSDK.FString Filename);

    /// <summary>
    /// Function: GetTitleFileContents
    /// </summary>
    public unsafe bool GetTitleFileContents(BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents);

    /// <summary>
    /// Function: ClearReadTitleFileCompleteDelegate
    /// </summary>
    public unsafe void ClearReadTitleFileCompleteDelegate(System.IntPtr ReadTitleFileCompleteDelegate);

    /// <summary>
    /// Function: AddReadTitleFileCompleteDelegate
    /// </summary>
    public unsafe void AddReadTitleFileCompleteDelegate(System.IntPtr ReadTitleFileCompleteDelegate);

    /// <summary>
    /// Function: ReadTitleFile
    /// </summary>
    public unsafe bool ReadTitleFile(BmSDK.FString FileToRead);

    /// <summary>
    /// Function: OnReadTitleFileComplete
    /// </summary>
    public unsafe void OnReadTitleFileComplete(bool bWasSuccessful, BmSDK.FString Filename);
}
