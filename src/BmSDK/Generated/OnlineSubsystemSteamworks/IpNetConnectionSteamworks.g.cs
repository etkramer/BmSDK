#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: IpNetConnectionSteamworks<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class IpNetConnectionSteamworks : BmSDK.IpDrv.TcpipConnection, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemSteamworks.IpNetConnectionSteamworks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal IpNetConnectionSteamworks() { }

    /// <summary>
    /// Constructs a new IpNetConnectionSteamworks
    /// </summary>
    public IpNetConnectionSteamworks(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, IpNetConnectionSteamworks Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected IpNetConnectionSteamworks(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Children
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ChildConnection> Children
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ChildConnection>>(Ptr + 44740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44740); }
    }
}
