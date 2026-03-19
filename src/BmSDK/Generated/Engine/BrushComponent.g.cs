#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: BrushComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class BrushComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.BrushComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal BrushComponent() { }

    /// <summary>
    /// Constructs a new BrushComponent
    /// </summary>
    public BrushComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, BrushComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected BrushComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Brush
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Brush
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// StructProperty: BrushAggGeom
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BrushAggGeom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StructProperty: CachedPhysBrushData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CachedPhysBrushData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// IntProperty: CachedPhysBrushDataVersion
    /// </summary>
    public unsafe int CachedPhysBrushDataVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// BoolProperty: bBlockComplexCollisionTrace
    /// </summary>
    public unsafe bool bBlockComplexCollisionTrace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 676); }
    }
}
