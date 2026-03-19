#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CylinderComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class CylinderComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CylinderComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal CylinderComponent() { }

    /// <summary>
    /// Constructs a new CylinderComponent
    /// </summary>
    public CylinderComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, CylinderComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CylinderComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: CollisionHeight
    /// </summary>
    public unsafe float CollisionHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: CollisionRadius
    /// </summary>
    public unsafe float CollisionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: AABBScale
    /// </summary>
    public unsafe float AABBScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StructProperty: CylinderColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CylinderColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// BoolProperty: bDrawBoundingBox
    /// </summary>
    public unsafe bool bDrawBoundingBox
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bDrawNonColliding
    /// </summary>
    public unsafe bool bDrawNonColliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysRenderIfSelected
    /// </summary>
    public unsafe bool bAlwaysRenderIfSelected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bForceGreenWhenSelected
    /// </summary>
    public unsafe bool bForceGreenWhenSelected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }
}
