#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: ClientBeaconAddressResolver<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ClientBeaconAddressResolver : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.ClientBeaconAddressResolver", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ClientBeaconAddressResolver() { }

    /// <summary>
    /// Constructs a new ClientBeaconAddressResolver
    /// </summary>
    public ClientBeaconAddressResolver(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ClientBeaconAddressResolver Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ClientBeaconAddressResolver(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: BeaconPort
    /// </summary>
    public unsafe int BeaconPort
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// NameProperty: BeaconName
    /// </summary>
    public unsafe BmSDK.FName BeaconName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
}
