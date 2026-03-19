#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRopeComponentBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RRopeComponentBase : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRopeComponentBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRopeComponentBase() { }

    /// <summary>
    /// Constructs a new RRopeComponentBase
    /// </summary>
    public RRopeComponentBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRopeComponentBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRopeComponentBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: DrawAsChain
    /// </summary>
    public unsafe bool DrawAsChain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: IsRopeEnd1Attached
    /// </summary>
    public unsafe bool IsRopeEnd1Attached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: IsRopeEnd2Attached
    /// </summary>
    public unsafe bool IsRopeEnd2Attached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: AutoRopeLengthCanOnlyShorten
    /// </summary>
    public unsafe bool AutoRopeLengthCanOnlyShorten
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: HasConstraint
    /// </summary>
    public unsafe bool HasConstraint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: EnforceMinLength
    /// </summary>
    public unsafe bool EnforceMinLength
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: EnforceLengthUsingSpring
    /// </summary>
    public unsafe bool EnforceLengthUsingSpring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: IsUpdateRopeRequested
    /// </summary>
    public unsafe bool IsUpdateRopeRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: RopeAttachActor1
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RopeAttachActor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ObjectProperty: RopeAttachActor2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RopeAttachActor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ObjectProperty: Material
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Material
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ObjectProperty: ConstraintSetup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ConstraintSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// ComponentProperty: RopeAttachComponent2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RopeAttachComponent2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ComponentProperty: RopeAttachComponent1
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RopeAttachComponent1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// NameProperty: RopeActor1AttachBone
    /// </summary>
    public unsafe BmSDK.FName RopeActor1AttachBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// NameProperty: RopeActor2AttachBone
    /// </summary>
    public unsafe BmSDK.FName RopeActor2AttachBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// StructProperty: ConstraintActor1AttachPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConstraintActor1AttachPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// StructProperty: ConstraintActor2AttachPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConstraintActor2AttachPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: RopeEnd1AttachMaxDistance
    /// </summary>
    public unsafe float RopeEnd1AttachMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// FloatProperty: RopeEnd2AttachMaxDistance
    /// </summary>
    public unsafe float RopeEnd2AttachMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// FloatProperty: RopeLength
    /// </summary>
    public unsafe float RopeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: RopeRenderStartPos
    /// </summary>
    public unsafe float RopeRenderStartPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: RopeStretch
    /// </summary>
    public unsafe float RopeStretch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// FloatProperty: RopeWidth
    /// </summary>
    public unsafe float RopeWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: RopeTwistLimitPerMetre
    /// </summary>
    public unsafe float RopeTwistLimitPerMetre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: RopeChangeLength
    /// </summary>
    public unsafe float RopeChangeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: RopeChangeDuration
    /// </summary>
    public unsafe float RopeChangeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ByteProperty: RopeChangeType
    /// </summary>
    public unsafe byte RopeChangeType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ByteProperty: RopeLengthControlType
    /// </summary>
    public unsafe byte RopeLengthControlType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 677); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 677); }
    }

    /// <summary>
    /// FloatProperty: RopeDrawWidth
    /// </summary>
    public unsafe float RopeDrawWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// FloatProperty: UnitsPerV
    /// </summary>
    public unsafe float UnitsPerV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// FloatProperty: VOffsetChain
    /// </summary>
    public unsafe float VOffsetChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: RopeRenderInterpolationScale
    /// </summary>
    public unsafe float RopeRenderInterpolationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: AutoRopeLengthSlackRatio
    /// </summary>
    public unsafe float AutoRopeLengthSlackRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: AutoRopeLengthMinLength
    /// </summary>
    public unsafe float AutoRopeLengthMinLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: AutoRopeLengthMaxLength
    /// </summary>
    public unsafe float AutoRopeLengthMaxLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// StructProperty: RopePhysicsBase
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopePhysicsBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// Enum: ERopeLengthControlType
    /// </summary>
    public enum ERopeLengthControlType
    {
        ROPELENGTHCONTROLTYPE_None = 0,
        ROPELENGTHCONTROLTYPE_GradualLengthChange = 1,
        ROPELENGTHCONTROLTYPE_SingleAutoLength = 2,
        ROPELENGTHCONTROLTYPE_ContinuousAutoLength = 3,
        ROPELENGTHCONTROLTYPE_MAX = 4,
    }

    /// <summary>
    /// Enum: ERopeLengthChangeType
    /// </summary>
    public enum ERopeLengthChangeType
    {
        ROPELENGTHCHANGE_ChangeFromEnd1 = 0,
        ROPELENGTHCHANGE_ChangeFromEnd2 = 1,
        ROPELENGTHCHANGE_ChangeFromBothEnds = 2,
        ROPELENGTHCHANGE_ChangeRope = 3,
        ROPELENGTHCHANGE_ChangeRope_VisualEnd1 = 4,
        ROPELENGTHCHANGE_ChangeRope_VisualEnd2 = 5,
        ROPELENGTHCHANGE_MAX = 6,
    }

    /// <summary>
    /// Enum: ERopeEndType
    /// </summary>
    public enum ERopeEndType
    {
        ROPEEND_End1 = 0,
        ROPEEND_End2 = 1,
        ROPEEND_MAX = 2,
    }
}
