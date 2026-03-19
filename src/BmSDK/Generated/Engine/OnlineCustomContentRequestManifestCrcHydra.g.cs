#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineCustomContentRequestManifestCrcHydra<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class OnlineCustomContentRequestManifestCrcHydra : BmSDK.Engine.OnlineCustomContentRequestHydra, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineCustomContentRequestManifestCrcHydra", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineCustomContentRequestManifestCrcHydra() { }

    /// <summary>
    /// Constructs a new OnlineCustomContentRequestManifestCrcHydra
    /// </summary>
    public OnlineCustomContentRequestManifestCrcHydra(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineCustomContentRequestManifestCrcHydra Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineCustomContentRequestManifestCrcHydra(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: Category
    /// </summary>
    public unsafe BmSDK.FString Category
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// ObjectProperty: CrcSubRequest
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CrcSubRequest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// DelegateProperty: __CrcDownloadComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __CrcDownloadComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
}
