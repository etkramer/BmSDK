#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: TcpipConnection<br/>
/// (size = 44828)
/// (flags = 268435596)
/// </summary>
public partial class TcpipConnection : BmSDK.Engine.NetConnection, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.TcpipConnection", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TcpipConnection() { }

    /// <summary>
    /// Constructs a new TcpipConnection
    /// </summary>
    public TcpipConnection(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TcpipConnection Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TcpipConnection(nint ptr) : base(ptr) { }

}
