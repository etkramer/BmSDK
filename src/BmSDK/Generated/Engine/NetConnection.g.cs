#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NetConnection<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NetConnection : BmSDK.Engine.Player, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NetConnection", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NetConnection() { }

    /// <summary>
    /// Constructs a new NetConnection
    /// </summary>
    public NetConnection(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NetConnection Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NetConnection(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Children
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Children
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 44740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44740); }
    }
}
