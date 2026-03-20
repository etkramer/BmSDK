#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlinePlayerStorage<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class OnlinePlayerStorage : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlinePlayerStorage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlinePlayerStorage() { }

    /// <summary>
    /// Constructs a new OnlinePlayerStorage
    /// </summary>
    public OnlinePlayerStorage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlinePlayerStorage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlinePlayerStorage(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: VersionNumber
    /// </summary>
    public unsafe int VersionNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: VersionSettingsId
    /// </summary>
    public unsafe int VersionSettingsId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// IntProperty: SaveCountSettingId
    /// </summary>
    public unsafe int SaveCountSettingId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: ProfileSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlinePlayerStorage.FOnlineProfileSetting> ProfileSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlinePlayerStorage.FOnlineProfileSetting>>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ArrayProperty: ProfileMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Settings.FSettingsPropertyPropertyMetaData> ProfileMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FSettingsPropertyPropertyMetaData>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ByteProperty: AsyncState
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePlayerStorage.EOnlinePlayerStorageAsyncState AsyncState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerStorage.EOnlinePlayerStorageAsyncState>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// IntProperty: DeviceID
    /// </summary>
    public unsafe int DeviceID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// Struct: FOnlineProfileSetting
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FOnlineProfileSetting
    {
        /// <summary>
        /// ByteProperty: Owner
        /// </summary>
        public unsafe BmSDK.Engine.OnlinePlayerStorage.EOnlineProfilePropertyOwner Owner
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerStorage.EOnlineProfilePropertyOwner>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ProfileSetting
        /// </summary>
        public unsafe BmSDK.Engine.Settings.FSettingsProperty ProfileSetting
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Settings.FSettingsProperty>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EOnlineProfilePropertyOwner
    /// </summary>
    public enum EOnlineProfilePropertyOwner
    {
        OPPO_None = 0,
        OPPO_OnlineService = 1,
        OPPO_Game = 2,
        OPPO_MAX = 3,
    }
}
