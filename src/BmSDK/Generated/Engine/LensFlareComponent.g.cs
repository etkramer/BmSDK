#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LensFlareComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LensFlareComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LensFlareComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LensFlareComponent() { }

    /// <summary>
    /// Constructs a new LensFlareComponent
    /// </summary>
    public LensFlareComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LensFlareComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LensFlareComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Template
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Template
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ComponentProperty: PreviewRadius
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviewRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ComponentProperty: PreviewOuterCone
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviewOuterCone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ComponentProperty: PreviewInnerCone
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviewInnerCone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// BoolProperty: bAutoActivate
    /// </summary>
    public unsafe bool bAutoActivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bIsActive
    /// </summary>
    public unsafe bool bIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bHasTranslucency
    /// </summary>
    public unsafe bool bHasTranslucency
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bHasUnlitTranslucency
    /// </summary>
    public unsafe bool bHasUnlitTranslucency
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bHasUnlitDistortion
    /// </summary>
    public unsafe bool bHasUnlitDistortion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bUsesSceneColor
    /// </summary>
    public unsafe bool bUsesSceneColor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bUseTrueConeCalculation
    /// </summary>
    public unsafe bool bUseTrueConeCalculation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bVisibleForMobile
    /// </summary>
    public unsafe bool bVisibleForMobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// FloatProperty: OuterCone
    /// </summary>
    public unsafe float OuterCone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// FloatProperty: InnerCone
    /// </summary>
    public unsafe float InnerCone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: ConeFudgeFactor
    /// </summary>
    public unsafe float ConeFudgeFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: Radius
    /// </summary>
    public unsafe float Radius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// FloatProperty: MinStrength
    /// </summary>
    public unsafe float MinStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// StructProperty: SourceColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SourceColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ArrayProperty: Materials
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Materials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// StructProperty: ReleaseResourcesFence
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReleaseResourcesFence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: NextTraceTime
    /// </summary>
    public unsafe float NextTraceTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }
}
