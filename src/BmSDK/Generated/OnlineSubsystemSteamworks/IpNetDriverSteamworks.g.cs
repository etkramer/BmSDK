#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: IpNetDriverSteamworks<br/>
/// (size = 428)
/// (flags = 0)
/// </summary>
public partial class IpNetDriverSteamworks : BmSDK.IpDrv.TcpNetDriver, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemSteamworks.IpNetDriverSteamworks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal IpNetDriverSteamworks() { }

    /// <summary>
    /// Constructs a new IpNetDriverSteamworks
    /// </summary>
    public IpNetDriverSteamworks(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, IpNetDriverSteamworks Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected IpNetDriverSteamworks(nint ptr) : base(ptr) { }

}
