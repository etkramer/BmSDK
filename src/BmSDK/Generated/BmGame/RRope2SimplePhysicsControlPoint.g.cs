#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRope2SimplePhysicsControlPoint<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RRope2SimplePhysicsControlPoint : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRope2SimplePhysicsControlPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRope2SimplePhysicsControlPoint() { }

    /// <summary>
    /// Constructs a new RRope2SimplePhysicsControlPoint
    /// </summary>
    public RRope2SimplePhysicsControlPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRope2SimplePhysicsControlPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRope2SimplePhysicsControlPoint(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ControlPointPhysicsNode
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ControlPointPhysicsNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
