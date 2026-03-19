#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RAggGeomCollisionComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAggGeomCollisionComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RAggGeomCollisionComponent", false);
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AggGeom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDrawInEditor
    /// </summary>
    public unsafe bool bAlwaysDrawInEditor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 648); }
    }

    /// <summary>
    /// BoolProperty: bAllowTraceComplexCollision
    /// </summary>
    public unsafe bool bAllowTraceComplexCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 648); }
    }

    /// <summary>
    /// StructProperty: CachedPhysBrushData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CachedPhysBrushData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// IntProperty: CachedPhysBrushDataVersion
    /// </summary>
    public unsafe int CachedPhysBrushDataVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }
}
