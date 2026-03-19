#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavMeshPath_AvoidPathObjects<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RNavMeshPath_AvoidPathObjects : BmSDK.Engine.NavMeshPathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavMeshPath_AvoidPathObjects", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RNavMeshPath_AvoidPathObjects() { }

    /// <summary>
    /// Constructs a new RNavMeshPath_AvoidPathObjects
    /// </summary>
    public RNavMeshPath_AvoidPathObjects(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavMeshPath_AvoidPathObjects Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavMeshPath_AvoidPathObjects(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AvoidObjects
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT AvoidObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}
