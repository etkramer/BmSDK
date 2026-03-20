#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: IpNetDriverSteamworks<br/>
/// (size = 0)
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

    /// <summary>
    /// BoolProperty: LogPortUnreach
    /// </summary>
    public unsafe bool LogPortUnreach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: AllowPlayerPortUnreach
    /// </summary>
    public unsafe bool AllowPlayerPortUnreach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 396); }
    }
}
