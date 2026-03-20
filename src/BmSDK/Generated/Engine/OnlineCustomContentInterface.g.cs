#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineCustomContentInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineCustomContentInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: CancelCustomContentRequest
    /// </summary>
    public unsafe void CancelCustomContentRequest(BmSDK.FString sCustomId);

    /// <summary>
    /// Function: GetCustomContentAsString
    /// </summary>
    public unsafe void GetCustomContentAsString(BmSDK.FString sCustomId, out BmSDK.FString ContentData);

    /// <summary>
    /// Function: GetCustomContent
    /// </summary>
    public unsafe void GetCustomContent(BmSDK.FString sCustomId, out BmSDK.TArray<byte> ContentData);

    /// <summary>
    /// Function: StartCustomContentRequest
    /// </summary>
    public unsafe void StartCustomContentRequest(BmSDK.FString sContentName, BmSDK.FString sCustomId, System.IntPtr dReadCustomContentComplete, BmSDK.Engine.OnlineSubsystem.ECustomContentAccessMode eCCAM = default, BmSDK.FString Category = default);

    /// <summary>
    /// Function: IsCustomContentAccessModeAvailable
    /// </summary>
    public unsafe bool IsCustomContentAccessModeAvailable(BmSDK.Engine.OnlineSubsystem.ECustomContentAccessMode eCCAM);

    /// <summary>
    /// Function: IsCustomContentTypeAvailable
    /// </summary>
    public unsafe bool IsCustomContentTypeAvailable(BmSDK.Engine.OnlineSubsystem.ECustomContentType CustomContentType);

    /// <summary>
    /// Function: IsCustomContentAvailable
    /// </summary>
    public unsafe bool IsCustomContentAvailable();
}
