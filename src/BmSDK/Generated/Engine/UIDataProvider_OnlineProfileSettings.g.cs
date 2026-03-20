#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDataProvider_OnlineProfileSettings<br/>
/// (flags = 0)
/// </summary>
public partial class UIDataProvider_OnlineProfileSettings : BmSDK.Engine.UIDataProvider_OnlinePlayerStorage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataProvider_OnlineProfileSettings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIDataProvider_OnlineProfileSettings() { }

    /// <summary>
    /// Constructs a new UIDataProvider_OnlineProfileSettings
    /// </summary>
    public UIDataProvider_OnlineProfileSettings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDataProvider_OnlineProfileSettings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataProvider_OnlineProfileSettings(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Profile
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePlayerStorage Profile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerStorage>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// NameProperty: ProviderName
    /// </summary>
    public unsafe BmSDK.FName ProviderName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bWasErrorLastRead
    /// </summary>
    public unsafe bool bWasErrorLastRead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bIsExternalUIOpen
    /// </summary>
    public unsafe bool bIsExternalUIOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bNeedsDeferredRefresh
    /// </summary>
    public unsafe bool bNeedsDeferredRefresh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// ArrayProperty: PlayerStorageArrayProviders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.UIDataProvider_OnlinePlayerStorage.FPlayerStorageArrayProvider> PlayerStorageArrayProviders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIDataProvider_OnlinePlayerStorage.FPlayerStorageArrayProvider>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// IntProperty: DeviceStorageSizeNeeded
    /// </summary>
    public unsafe int DeviceStorageSizeNeeded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
