#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: SharedCloudFileInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface SharedCloudFileInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: ClearWriteSharedFileCompleteDelegate
    /// </summary>
    public unsafe void ClearWriteSharedFileCompleteDelegate(System.IntPtr WriteSharedFileCompleteDelegate);

    /// <summary>
    /// Function: AddWriteSharedFileCompleteDelegate
    /// </summary>
    public unsafe void AddWriteSharedFileCompleteDelegate(System.IntPtr WriteSharedFileCompleteDelegate);

    /// <summary>
    /// Function: WriteSharedFile
    /// </summary>
    public unsafe bool WriteSharedFile(BmSDK.FString UserId, BmSDK.FString Filename, out BmSDK.TArray<byte> Contents);

    /// <summary>
    /// Function: OnWriteSharedFileComplete
    /// </summary>
    public unsafe void OnWriteSharedFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename, BmSDK.FString SharedHandle);

    /// <summary>
    /// Function: ClearReadSharedFileCompleteDelegate
    /// </summary>
    public unsafe void ClearReadSharedFileCompleteDelegate(System.IntPtr ReadSharedFileCompleteDelegate);

    /// <summary>
    /// Function: AddReadSharedFileCompleteDelegate
    /// </summary>
    public unsafe void AddReadSharedFileCompleteDelegate(System.IntPtr ReadSharedFileCompleteDelegate);

    /// <summary>
    /// Function: ReadSharedFile
    /// </summary>
    public unsafe bool ReadSharedFile(BmSDK.FString SharedHandle);

    /// <summary>
    /// Function: OnReadSharedFileComplete
    /// </summary>
    public unsafe void OnReadSharedFileComplete(bool bWasSuccessful, BmSDK.FString SharedHandle);

    /// <summary>
    /// Function: ClearSharedFile
    /// </summary>
    public unsafe bool ClearSharedFile(BmSDK.FString SharedHandle);

    /// <summary>
    /// Function: ClearSharedFiles
    /// </summary>
    public unsafe bool ClearSharedFiles();

    /// <summary>
    /// Function: GetSharedFileContents
    /// </summary>
    public unsafe bool GetSharedFileContents(BmSDK.FString SharedHandle, out BmSDK.TArray<byte> FileContents);
}
