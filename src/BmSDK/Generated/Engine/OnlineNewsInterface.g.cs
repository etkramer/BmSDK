#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineNewsInterface<br/>
/// (size = 56)
/// (flags = 16403)
/// </summary>
public partial interface OnlineNewsInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetNews
    /// </summary>
    public unsafe BmSDK.FString GetNews(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineNewsType NewsType);

    /// <summary>
    /// Function: ClearReadNewsCompletedDelegate
    /// </summary>
    public unsafe void ClearReadNewsCompletedDelegate(System.IntPtr ReadNewsDelegate);

    /// <summary>
    /// Function: AddReadNewsCompletedDelegate
    /// </summary>
    public unsafe void AddReadNewsCompletedDelegate(System.IntPtr ReadNewsDelegate);

    /// <summary>
    /// Function: OnReadNewsCompleted
    /// </summary>
    public unsafe void OnReadNewsCompleted(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.EOnlineNewsType NewsType);

    /// <summary>
    /// Function: ReadNews
    /// </summary>
    public unsafe bool ReadNews(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineNewsType NewsType);
}
