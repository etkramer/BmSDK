#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: UserCloudFileInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface UserCloudFileInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: WriteFileToScatch
    /// </summary>
    public unsafe bool WriteFileToScatch(byte LocalUserNum, BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents);

    /// <summary>
    /// Function: ReadFileFromScatch
    /// </summary>
    public unsafe bool ReadFileFromScatch(byte LocalUserNum, BmSDK.FString Filename, out BmSDK.TArray<byte> OutFileContents);

    /// <summary>
    /// Function: ClearAllDelegates
    /// </summary>
    public unsafe void ClearAllDelegates();

    /// <summary>
    /// Function: CancelDownloadFileIO
    /// </summary>
    public unsafe void CancelDownloadFileIO();

    /// <summary>
    /// Function: ClearDeleteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe void ClearDeleteDownloadFileCompleteDelegate(System.IntPtr DeleteDownloadFileCompleteDelegate);

    /// <summary>
    /// Function: AddDeleteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe void AddDeleteDownloadFileCompleteDelegate(System.IntPtr DeleteDownloadFileCompleteDelegate);

    /// <summary>
    /// Function: OnDeleteDownloadFileComplete
    /// </summary>
    public unsafe void OnDeleteDownloadFileComplete(bool bWasSuccessful, BmSDK.FString Filename);

    /// <summary>
    /// Function: DeleteDownloadFile
    /// </summary>
    public unsafe bool DeleteDownloadFile(BmSDK.FString Filename);

    /// <summary>
    /// Function: ClearWriteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe void ClearWriteDownloadFileCompleteDelegate(System.IntPtr WriteDownloadFileCompleteDelegate);

    /// <summary>
    /// Function: AddWriteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe void AddWriteDownloadFileCompleteDelegate(System.IntPtr WriteDownloadFileCompleteDelegate);

    /// <summary>
    /// Function: OnWriteDownloadFileComplete
    /// </summary>
    public unsafe void OnWriteDownloadFileComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesProcessed);

    /// <summary>
    /// Function: WriteDownloadFile
    /// </summary>
    public unsafe bool WriteDownloadFile(BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents, out BmSDK.FString FileCRC);

    /// <summary>
    /// Function: ClearReadDownloadFileCompleteDelegate
    /// </summary>
    public unsafe void ClearReadDownloadFileCompleteDelegate(System.IntPtr ReadDownloadFileCompleteDelegate);

    /// <summary>
    /// Function: AddReadDownloadFileCompleteDelegate
    /// </summary>
    public unsafe void AddReadDownloadFileCompleteDelegate(System.IntPtr ReadDownloadFileCompleteDelegate);

    /// <summary>
    /// Function: OnReadDownloadFileComplete
    /// </summary>
    public unsafe void OnReadDownloadFileComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesProcessed);

    /// <summary>
    /// Function: ReadDownloadFile
    /// </summary>
    public unsafe bool ReadDownloadFile(BmSDK.FString Filename, out BmSDK.TArray<byte> OutFileContents, out BmSDK.FString OutFileCRC);

    /// <summary>
    /// Function: GetDownloadFileSize
    /// </summary>
    public unsafe int GetDownloadFileSize(BmSDK.FString Filename, bool KeepHandle = default);

    /// <summary>
    /// Function: EnumerateDownloadFiles
    /// </summary>
    public unsafe void EnumerateDownloadFiles(out BmSDK.TArray<BmSDK.FString> OutFiles, BmSDK.FString Subfolder);

    /// <summary>
    /// Function: EnumerateDownloadFolders
    /// </summary>
    public unsafe void EnumerateDownloadFolders(out BmSDK.TArray<BmSDK.FString> OutFolders);

    /// <summary>
    /// Function: ClearDeleteUserFileCompleteDelegate
    /// </summary>
    public unsafe void ClearDeleteUserFileCompleteDelegate(System.IntPtr DeleteUserFileCompleteDelegate);

    /// <summary>
    /// Function: AddDeleteUserFileCompleteDelegate
    /// </summary>
    public unsafe void AddDeleteUserFileCompleteDelegate(System.IntPtr DeleteUserFileCompleteDelegate);

    /// <summary>
    /// Function: DeleteUserFile
    /// </summary>
    public unsafe bool DeleteUserFile(BmSDK.FString UserId, BmSDK.FString Filename, bool bShouldCloudDelete, bool bShouldLocallyDelete);

    /// <summary>
    /// Function: OnDeleteUserFileComplete
    /// </summary>
    public unsafe void OnDeleteUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename);

    /// <summary>
    /// Function: ClearWriteUserFileCompleteDelegate
    /// </summary>
    public unsafe void ClearWriteUserFileCompleteDelegate(System.IntPtr WriteUserFileCompleteDelegate);

    /// <summary>
    /// Function: AddWriteUserFileCompleteDelegate
    /// </summary>
    public unsafe void AddWriteUserFileCompleteDelegate(System.IntPtr WriteUserFileCompleteDelegate);

    /// <summary>
    /// Function: WriteUserFile
    /// </summary>
    public unsafe bool WriteUserFile(BmSDK.FString UserId, BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents);

    /// <summary>
    /// Function: OnWriteUserFileComplete
    /// </summary>
    public unsafe void OnWriteUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename);

    /// <summary>
    /// Function: ClearReadUserFileCompleteDelegate
    /// </summary>
    public unsafe void ClearReadUserFileCompleteDelegate(System.IntPtr ReadUserFileCompleteDelegate);

    /// <summary>
    /// Function: AddReadUserFileCompleteDelegate
    /// </summary>
    public unsafe void AddReadUserFileCompleteDelegate(System.IntPtr ReadUserFileCompleteDelegate);

    /// <summary>
    /// Function: ReadUserFile
    /// </summary>
    public unsafe bool ReadUserFile(BmSDK.FString UserId, BmSDK.FString Filename);

    /// <summary>
    /// Function: OnReadUserFileComplete
    /// </summary>
    public unsafe void OnReadUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename);

    /// <summary>
    /// Function: GetUserFileList
    /// </summary>
    public unsafe void GetUserFileList(BmSDK.FString UserId, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile> UserFiles);

    /// <summary>
    /// Function: ClearEnumerateUserFileCompleteDelegate
    /// </summary>
    public unsafe void ClearEnumerateUserFileCompleteDelegate(System.IntPtr EnumerateUserFileCompleteDelegate);

    /// <summary>
    /// Function: AddEnumerateUserFileCompleteDelegate
    /// </summary>
    public unsafe void AddEnumerateUserFileCompleteDelegate(System.IntPtr EnumerateUserFileCompleteDelegate);

    /// <summary>
    /// Function: EnumerateUserFiles
    /// </summary>
    public unsafe void EnumerateUserFiles(BmSDK.FString UserId);

    /// <summary>
    /// Function: OnEnumerateUserFilesComplete
    /// </summary>
    public unsafe void OnEnumerateUserFilesComplete(bool bWasSuccessful, BmSDK.FString UserId);

    /// <summary>
    /// Function: ClearFile
    /// </summary>
    public unsafe bool ClearFile(BmSDK.FString UserId, BmSDK.FString Filename);

    /// <summary>
    /// Function: ClearFiles
    /// </summary>
    public unsafe bool ClearFiles(BmSDK.FString UserId);

    /// <summary>
    /// Function: GetFileContents
    /// </summary>
    public unsafe bool GetFileContents(BmSDK.FString UserId, BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents);
}
