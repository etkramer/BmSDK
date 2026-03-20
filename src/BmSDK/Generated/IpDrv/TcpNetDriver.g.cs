#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: TcpNetDriver<br/>
/// (flags = 0)
/// </summary>
public partial class TcpNetDriver : BmSDK.Engine.NetDriver, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.TcpNetDriver", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TcpNetDriver() { }

    /// <summary>
    /// Constructs a new TcpNetDriver
    /// </summary>
    public TcpNetDriver(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TcpNetDriver Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TcpNetDriver(nint ptr) : base(ptr) { }

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
