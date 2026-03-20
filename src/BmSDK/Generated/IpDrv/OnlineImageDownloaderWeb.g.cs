#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: OnlineImageDownloaderWeb<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class OnlineImageDownloaderWeb : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.OnlineImageDownloaderWeb", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineImageDownloaderWeb() { }

    /// <summary>
    /// Constructs a new OnlineImageDownloaderWeb
    /// </summary>
    public OnlineImageDownloaderWeb(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineImageDownloaderWeb Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineImageDownloaderWeb(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: DownloadImages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.IpDrv.OnlineImageDownloaderWeb.FOnlineImageDownload> DownloadImages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.IpDrv.OnlineImageDownloaderWeb.FOnlineImageDownload>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: MaxSimultaneousDownloads
    /// </summary>
    public unsafe int MaxSimultaneousDownloads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// DelegateProperty: __OnOnlineImageDownloaded__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnOnlineImageDownloaded__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// Struct: FOnlineImageDownload
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FOnlineImageDownload
    {
        /// <summary>
        /// StrProperty: URL
        /// </summary>
        public unsafe BmSDK.FString URL
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: HTTPRequest
        /// </summary>
        public unsafe BmSDK.Engine.HttpRequestInterface HTTPRequest
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HttpRequestInterface>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: State
        /// </summary>
        public unsafe BmSDK.IpDrv.OnlineImageDownloaderWeb.EOnlineImageDownloadState State
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.OnlineImageDownloaderWeb.EOnlineImageDownloadState>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bPendingRemoval
        /// </summary>
        public unsafe bool bPendingRemoval
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// ObjectProperty: Texture
        /// </summary>
        public unsafe BmSDK.Engine.Texture2DDynamic Texture
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2DDynamic>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Enum: EOnlineImageDownloadState
    /// </summary>
    public enum EOnlineImageDownloadState
    {
        PIDS_NotStarted = 0,
        PIDS_Downloading = 1,
        PIDS_Succeeded = 2,
        PIDS_Failed = 3,
        PIDS_MAX = 4,
    }
}
