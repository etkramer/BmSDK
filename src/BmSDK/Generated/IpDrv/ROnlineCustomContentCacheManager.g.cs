#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: ROnlineCustomContentCacheManager<br/>
/// (size = 252)
/// (flags = 134217874)
/// </summary>
public partial class ROnlineCustomContentCacheManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.ROnlineCustomContentCacheManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ROnlineCustomContentCacheManager() { }

    /// <summary>
    /// Constructs a new ROnlineCustomContentCacheManager
    /// </summary>
    public ROnlineCustomContentCacheManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ROnlineCustomContentCacheManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ROnlineCustomContentCacheManager(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: CheckStateChange
    /// </summary>
    public unsafe void CheckStateChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.CheckStateChange", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: GetActivityLogAsList
    /// </summary>
    public unsafe void GetActivityLogAsList(out BmSDK.TArray<BmSDK.FString> OutList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.GetActivityLogAsList", true);
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: UpdateActivity
    /// </summary>
    public unsafe void UpdateActivity(BmSDK.FString Filename, BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheActivityType Type, BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheActivityStatus Status, int bytesTransferred, float timeTaken)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.UpdateActivity", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Status, paramsPtr + 17);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesTransferred, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnCleanupObsoleteInternal
    /// </summary>
    public unsafe void OnCleanupObsoleteInternal(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.OnCleanupObsoleteInternal", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnCrcDownloadComplete
    /// </summary>
    public unsafe void OnCrcDownloadComplete(BmSDK.Engine.OnlineCustomContentRequestHydra SubRequest, BmSDK.FString Category)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.OnCrcDownloadComplete", true);
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubRequest, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Category, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetRegistryAsFileNames
    /// </summary>
    public unsafe void GetRegistryAsFileNames(out BmSDK.TArray<BmSDK.FString> OutList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.GetRegistryAsFileNames", true);
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetRegistryAsList
    /// </summary>
    public unsafe int GetRegistryAsList(out BmSDK.TArray<BmSDK.FString> OutList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.GetRegistryAsList", true);
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetIndexOfFolderInRegistry
    /// </summary>
    public unsafe int GetIndexOfFolderInRegistry(out BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryFolder folderCopy, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.GetIndexOfFolderInRegistry", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        folderCopy = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryFolder>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 52);
    }

    /// <summary>
    /// Function: GetIndexOfEntryInFolder
    /// </summary>
    public unsafe int GetIndexOfEntryInFolder(out BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryEntry entryCopy, BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryFolder folderCopy, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.GetIndexOfEntryInFolder", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(folderCopy, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        entryCopy = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryEntry>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 80);
    }

    /// <summary>
    /// Function: GetCopyOfEntryInRegistry
    /// </summary>
    public unsafe bool GetCopyOfEntryInRegistry(out BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryEntry entryCopy, BmSDK.FString Filename, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.GetCopyOfEntryInRegistry", true);
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        entryCopy = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryEntry>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 60);
    }

    /// <summary>
    /// Function: FlagObsoleteInRegistry
    /// </summary>
    public unsafe bool FlagObsoleteInRegistry(BmSDK.FString Filename, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.FlagObsoleteInRegistry", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: RemoveFromRegistry
    /// </summary>
    public unsafe bool RemoveFromRegistry(BmSDK.FString Filename, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.RemoveFromRegistry", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: UpdateRegistry
    /// </summary>
    public unsafe void UpdateRegistry(BmSDK.FString Filename, BmSDK.FString Subfolder, int Crc32, int Size, bool bObsolete)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.UpdateRegistry", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Crc32, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bObsolete, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetFileCacheSize
    /// </summary>
    public unsafe int GetFileCacheSize(BmSDK.FString Filename, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.GetFileCacheSize", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: GetFileCacheStatus
    /// </summary>
    public unsafe BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheFileStatus GetFileCacheStatus(BmSDK.FString Filename, BmSDK.FString Subfolder, int ExpectedCrc32)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.GetFileCacheStatus", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExpectedCrc32, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheFileStatus>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: InitializeCacheRegistry
    /// </summary>
    public unsafe void InitializeCacheRegistry()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.InitializeCacheRegistry", true);
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnCacheDeleteComplete
    /// </summary>
    public unsafe void OnCacheDeleteComplete(bool bWasSuccessful, BmSDK.FString Filename, float timeTaken)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.OnCacheDeleteComplete", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnCacheDeleteBegin
    /// </summary>
    public unsafe void OnCacheDeleteBegin()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.OnCacheDeleteBegin", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnCacheSaveComplete
    /// </summary>
    public unsafe void OnCacheSaveComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesTransferred, float timeTaken)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.OnCacheSaveComplete", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesTransferred, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnCacheSaveBegin
    /// </summary>
    public unsafe void OnCacheSaveBegin()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.OnCacheSaveBegin", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnCacheLoadComplete
    /// </summary>
    public unsafe void OnCacheLoadComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesTransferred, float timeTaken)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.OnCacheLoadComplete", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesTransferred, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnCacheLoadBegin
    /// </summary>
    public unsafe void OnCacheLoadBegin()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.OnCacheLoadBegin", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddToDeleteQueue
    /// </summary>
    public unsafe void AddToDeleteQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.AddToDeleteQueue", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: AddToWriteQueue
    /// </summary>
    public unsafe void AddToWriteQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.AddToWriteQueue", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: RemoveFromReadQueue
    /// </summary>
    public unsafe void RemoveFromReadQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.RemoveFromReadQueue", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: AddToReadQueue
    /// </summary>
    public unsafe void AddToReadQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.ROnlineCustomContentCacheManager.AddToReadQueue", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// ObjectProperty: OnlineSub
    /// </summary>
    public unsafe BmSDK.IpDrv.OnlineSubsystemCommonImpl OnlineSub
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.OnlineSubsystemCommonImpl>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: RequestInProgress
    /// </summary>
    public unsafe BmSDK.Engine.OnlineCustomContentRequestCacheableHydra RequestInProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ByteProperty: CurrentState
    /// </summary>
    public unsafe BmSDK.IpDrv.ROnlineCustomContentCacheManager.QueuePriorityState CurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.ROnlineCustomContentCacheManager.QueuePriorityState>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: FileSystemBusy
    /// </summary>
    public unsafe bool FileSystemBusy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: ReadQueue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra> ReadQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: WriteQueue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra> WriteQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: DeleteQueue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra> DeleteQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: Registries
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryFolder> Registries
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryFolder>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: ActivityLog
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FCacheActivityEntry> ActivityLog
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FCacheActivityEntry>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// DelegateProperty: __OnCacheLoadComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCacheLoadComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// DelegateProperty: __OnCacheSaveComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCacheSaveComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// DelegateProperty: __OnCacheDeleteComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCacheDeleteComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// DelegateProperty: __OnCleanupObsoleteInternal__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCleanupObsoleteInternal__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// Struct: FCacheActivityEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FCacheActivityEntry
    {
        /// <summary>
        /// StrProperty: Filename
        /// </summary>
        public unsafe BmSDK.FString Filename
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: OpType
        /// </summary>
        public unsafe BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheActivityType OpType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheActivityType>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: Status
        /// </summary>
        public unsafe BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheActivityStatus Status
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheActivityStatus>(Ptr + 17); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17); }; }
        }

        /// <summary>
        /// IntProperty: bytesTransferred
        /// </summary>
        public unsafe int bytesTransferred
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: timeTaken
        /// </summary>
        public unsafe float timeTaken
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: CacheActivityType
    /// </summary>
    public enum CacheActivityType
    {
        ActivityRead = 0,
        ActivityWrite = 1,
        ActivityDelete = 2,
        CacheActivityType_MAX = 3,
    }

    /// <summary>
    /// Enum: CacheActivityStatus
    /// </summary>
    public enum CacheActivityStatus
    {
        ActivitySuccessful = 0,
        ActivityFailed = 1,
        CacheActivityStatus_MAX = 2,
    }

    /// <summary>
    /// Enum: CacheFileStatus
    /// </summary>
    public enum CacheFileStatus
    {
        FileOK = 0,
        FileObsolete = 1,
        FileNonexistent = 2,
        CacheFileStatus_MAX = 3,
    }

    /// <summary>
    /// Enum: QueuePriorityState
    /// </summary>
    public enum QueuePriorityState
    {
        StandbyState = 0,
        ReadState = 1,
        WriteState = 2,
        DeleteState = 3,
        QueuePriorityState_MAX = 4,
    }

    /// <summary>
    /// Struct: FRegistryFolder
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FRegistryFolder
    {
        /// <summary>
        /// StrProperty: FolderName
        /// </summary>
        public unsafe BmSDK.FString FolderName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Entries
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryEntry> Entries
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryEntry>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Version
        /// </summary>
        public unsafe int Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FRegistryEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FRegistryEntry
    {
        /// <summary>
        /// StrProperty: Filename
        /// </summary>
        public unsafe BmSDK.FString Filename
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Size
        /// </summary>
        public unsafe int Size
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: CRC
        /// </summary>
        public unsafe int CRC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: Obsolete
        /// </summary>
        public unsafe bool Obsolete
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }
}
