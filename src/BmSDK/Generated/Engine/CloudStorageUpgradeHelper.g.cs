#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: CloudStorageUpgradeHelper<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface CloudStorageUpgradeHelper : BmSDK.Interface
{
    /// <summary>
    /// Function: GetCloudUpgradeKeys
    /// </summary>
    public unsafe void GetCloudUpgradeKeys(out BmSDK.TArray<BmSDK.FString> CloudKeys);

    /// <summary>
    /// Function: HandleLocalKeyValue
    /// </summary>
    public unsafe void HandleLocalKeyValue(out BmSDK.FString CloudKeyName, out BmSDK.Engine.PlatformInterfaceBase.FPlatformInterfaceData CloudValue, out int bShouldMoveToCloud, out int bShouldDeleteLocalKey);

    /// <summary>
    /// Function: HandleLocalDocument
    /// </summary>
    public unsafe void HandleLocalDocument(out BmSDK.FString DocName, out int bShouldMoveToCloud, out int bShouldDeleteLocalFile);
}
