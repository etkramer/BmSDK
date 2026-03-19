#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: OnlineEventsInterfaceMcp<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class OnlineEventsInterfaceMcp : BmSDK.IpDrv.MCPBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.OnlineEventsInterfaceMcp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineEventsInterfaceMcp() { }

    /// <summary>
    /// Constructs a new OnlineEventsInterfaceMcp
    /// </summary>
    public OnlineEventsInterfaceMcp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineEventsInterfaceMcp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineEventsInterfaceMcp(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: EventUploadConfigs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> EventUploadConfigs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: MCPEventPostObjects
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT MCPEventPostObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: DisabledUploadTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DisabledUploadTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bBinaryStats
    /// </summary>
    public unsafe bool bBinaryStats
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// Struct: FEventUploadConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FEventUploadConfig
    {
        /// <summary>
        /// ByteProperty: UploadType
        /// </summary>
        public unsafe byte UploadType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: UploadUrl
        /// </summary>
        public unsafe BmSDK.FString UploadUrl
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: TimeOut
        /// </summary>
        public unsafe float TimeOut
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bUseCompression
        /// </summary>
        public unsafe bool bUseCompression
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: EEventUploadType
    /// </summary>
    public enum EEventUploadType
    {
        EUT_GenericStats = 0,
        EUT_ProfileData = 1,
        EUT_MatchmakingData = 2,
        EUT_PlaylistPopulation = 3,
        EUT_MAX = 4,
    }
}
