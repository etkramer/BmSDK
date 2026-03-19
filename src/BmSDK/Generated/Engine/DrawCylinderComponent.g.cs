#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DrawCylinderComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DrawCylinderComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DrawCylinderComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DrawCylinderComponent() { }

    /// <summary>
    /// Constructs a new DrawCylinderComponent
    /// </summary>
    public DrawCylinderComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DrawCylinderComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DrawCylinderComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: CylinderColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CylinderColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: CylinderMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CylinderMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: CylinderRadius
    /// </summary>
    public unsafe float CylinderRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// FloatProperty: CylinderTopRadius
    /// </summary>
    public unsafe float CylinderTopRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: CylinderHeight
    /// </summary>
    public unsafe float CylinderHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// FloatProperty: CylinderHeightOffset
    /// </summary>
    public unsafe float CylinderHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// IntProperty: CylinderSides
    /// </summary>
    public unsafe int CylinderSides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bDrawWireCylinder
    /// </summary>
    public unsafe bool bDrawWireCylinder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bDrawLitCylinder
    /// </summary>
    public unsafe bool bDrawLitCylinder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bDrawOnlyIfSelected
    /// </summary>
    public unsafe bool bDrawOnlyIfSelected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }
}
