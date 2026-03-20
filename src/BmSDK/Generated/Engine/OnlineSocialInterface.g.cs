#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineSocialInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineSocialInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: ClearPostLinkCompleted
    /// </summary>
    public unsafe void ClearPostLinkCompleted(byte LocalUserNum, System.IntPtr PostLinkDelegate);

    /// <summary>
    /// Function: AddPostLinkCompleted
    /// </summary>
    public unsafe void AddPostLinkCompleted(byte LocalUserNum, System.IntPtr PostLinkDelegate);

    /// <summary>
    /// Function: OnPostLinkCompleted
    /// </summary>
    public unsafe void OnPostLinkCompleted(byte LocalUserNum, bool bWasSuccessful);

    /// <summary>
    /// Function: PostLink
    /// </summary>
    public unsafe bool PostLink(byte LocalUserNum, out BmSDK.Engine.OnlineSubsystem.FSocialPostLinkInfo PostLinkInfo);

    /// <summary>
    /// Function: ClearPostImageCompleted
    /// </summary>
    public unsafe void ClearPostImageCompleted(byte LocalUserNum, System.IntPtr PostImageDelegate);

    /// <summary>
    /// Function: AddPostImageCompleted
    /// </summary>
    public unsafe void AddPostImageCompleted(byte LocalUserNum, System.IntPtr PostImageDelegate);

    /// <summary>
    /// Function: OnPostImageCompleted
    /// </summary>
    public unsafe void OnPostImageCompleted(byte LocalUserNum, bool bWasSuccessful);

    /// <summary>
    /// Function: PostImage
    /// </summary>
    public unsafe bool PostImage(byte LocalUserNum, out BmSDK.Engine.OnlineSubsystem.FSocialPostImageInfo PostImageInfo, BmSDK.TArray<byte> FullImage);

    /// <summary>
    /// Function: ClearQuerySocialPostPrivilegesCompleted
    /// </summary>
    public unsafe void ClearQuerySocialPostPrivilegesCompleted(System.IntPtr PostPrivilegesDelegate);

    /// <summary>
    /// Function: AddQuerySocialPostPrivilegesCompleted
    /// </summary>
    public unsafe void AddQuerySocialPostPrivilegesCompleted(System.IntPtr PostPrivilegesDelegate);

    /// <summary>
    /// Function: OnQuerySocialPostPrivilegesCompleted
    /// </summary>
    public unsafe void OnQuerySocialPostPrivilegesCompleted(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.FSocialPostPrivileges PostPrivileges);

    /// <summary>
    /// Function: QuerySocialPostPrivileges
    /// </summary>
    public unsafe bool QuerySocialPostPrivileges();
}
