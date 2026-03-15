#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAggGeomCollisionComponent<br/>
/// (size = 460)
/// (flags = 2290090130)
/// </summary>
public partial class RAggGeomCollisionComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAggGeomCollisionComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAggGeomCollisionComponent() { }

    /// <summary>
    /// Constructs a new RAggGeomCollisionComponent
    /// </summary>
    public RAggGeomCollisionComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAggGeomCollisionComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAggGeomCollisionComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: AggGeom
    /// </summary>
    public unsafe BmSDK.Engine.KMeshProps.FKAggregateGeom AggGeom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KMeshProps.FKAggregateGeom>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }
}
