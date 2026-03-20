#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineWebInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineWebInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: OnRequestComplete
    /// </summary>
    public unsafe void OnRequestComplete(BmSDK.Engine.HttpRequestInterface OriginalRequest, BmSDK.Engine.HttpResponseInterface Response, bool bDidSucceed);

    /// <summary>
    /// Function: WebRequest
    /// </summary>
    public unsafe void WebRequest(BmSDK.FString HttpMethod, BmSDK.FString URL, BmSDK.FString Params = default);
}
