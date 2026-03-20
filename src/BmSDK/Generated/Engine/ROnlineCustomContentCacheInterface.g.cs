#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: ROnlineCustomContentCacheInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface ROnlineCustomContentCacheInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: FlagObsoleteInRegistry
    /// </summary>
    public unsafe bool FlagObsoleteInRegistry(BmSDK.FString Filename, BmSDK.FString Subfolder);

    /// <summary>
    /// Function: UpdateRegistry
    /// </summary>
    public unsafe void UpdateRegistry(BmSDK.FString Filename, BmSDK.FString Subfolder, int Crc32, int Size, bool bObsolete);

    /// <summary>
    /// Function: AddToDeleteQueue
    /// </summary>
    public unsafe void AddToDeleteQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request);

    /// <summary>
    /// Function: AddToWriteQueue
    /// </summary>
    public unsafe void AddToWriteQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request);

    /// <summary>
    /// Function: RemoveFromReadQueue
    /// </summary>
    public unsafe void RemoveFromReadQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request);

    /// <summary>
    /// Function: AddToReadQueue
    /// </summary>
    public unsafe void AddToReadQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request);
}
