#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: ROnlineCustomContentCacheManager<br/>
/// (size = 0)
/// (flags = 0)
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
    [StructLayout(LayoutKind.Explicit, Size = 0)]
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
    [StructLayout(LayoutKind.Explicit, Size = 0)]
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
    [StructLayout(LayoutKind.Explicit, Size = 0)]
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
