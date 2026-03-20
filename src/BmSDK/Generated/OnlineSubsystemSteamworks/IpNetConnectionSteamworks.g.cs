#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: IpNetConnectionSteamworks<br/>
/// (size = 44828)
/// (flags = 268435596)
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

}
