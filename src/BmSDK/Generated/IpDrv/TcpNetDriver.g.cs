#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: TcpNetDriver<br/>
/// (size = 428)
/// (flags = 268435596)
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

}
