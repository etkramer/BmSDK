#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RB_PulleyJointSetup<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RB_PulleyJointSetup : BmSDK.Engine.RB_ConstraintSetup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RB_PulleyJointSetup", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RB_PulleyJointSetup() { }

    /// <summary>
    /// Constructs a new RB_PulleyJointSetup
    /// </summary>
    public RB_PulleyJointSetup(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RB_PulleyJointSetup Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RB_PulleyJointSetup(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: JointName
    /// </summary>
    public unsafe BmSDK.FName JointName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// NameProperty: ConstraintBone1
    /// </summary>
    public unsafe BmSDK.FName ConstraintBone1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// NameProperty: ConstraintBone2
    /// </summary>
    public unsafe BmSDK.FName ConstraintBone2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: Pos1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Pos1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// StructProperty: PriAxis1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PriAxis1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// StructProperty: SecAxis1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SecAxis1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StructProperty: Pos2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Pos2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// StructProperty: PriAxis2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PriAxis2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// StructProperty: SecAxis2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SecAxis2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StructProperty: PulleyPivot1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PulleyPivot1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: PulleyPivot2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PulleyPivot2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// BoolProperty: bEnableProjection
    /// </summary>
    public unsafe bool bEnableProjection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bEnableCollision
    /// </summary>
    public unsafe bool bEnableCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bRampDownBreakThresholds
    /// </summary>
    public unsafe bool bRampDownBreakThresholds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bLinearLimitSoft
    /// </summary>
    public unsafe bool bLinearLimitSoft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bLinearBreakable
    /// </summary>
    public unsafe bool bLinearBreakable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bSwingLimited
    /// </summary>
    public unsafe bool bSwingLimited
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bTwistLimited
    /// </summary>
    public unsafe bool bTwistLimited
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bSwingLimitSoft
    /// </summary>
    public unsafe bool bSwingLimitSoft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bTwistLimitSoft
    /// </summary>
    public unsafe bool bTwistLimitSoft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bAngularBreakable
    /// </summary>
    public unsafe bool bAngularBreakable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bIsPulley
    /// </summary>
    public unsafe bool bIsPulley
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bMaintainMinDistance
    /// </summary>
    public unsafe bool bMaintainMinDistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bIsDistance
    /// </summary>
    public unsafe bool bIsDistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// ByteProperty: ProjectionMode
    /// </summary>
    public unsafe byte ProjectionMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: ProjectionDistance
    /// </summary>
    public unsafe float ProjectionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// FloatProperty: ProjectionAngle
    /// </summary>
    public unsafe float ProjectionAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// StructProperty: LinearXSetup
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LinearXSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StructProperty: LinearYSetup
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LinearYSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// StructProperty: LinearZSetup
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LinearZSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// FloatProperty: LinearLimitStiffness
    /// </summary>
    public unsafe float LinearLimitStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: LinearLimitDamping
    /// </summary>
    public unsafe float LinearLimitDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// FloatProperty: LinearBreakThreshold
    /// </summary>
    public unsafe float LinearBreakThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: Swing1LimitAngle
    /// </summary>
    public unsafe float Swing1LimitAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: Swing2LimitAngle
    /// </summary>
    public unsafe float Swing2LimitAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: TwistLimitAngle
    /// </summary>
    public unsafe float TwistLimitAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// FloatProperty: SwingLimitStiffness
    /// </summary>
    public unsafe float SwingLimitStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// FloatProperty: SwingLimitDamping
    /// </summary>
    public unsafe float SwingLimitDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// FloatProperty: TwistLimitStiffness
    /// </summary>
    public unsafe float TwistLimitStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// FloatProperty: TwistLimitDamping
    /// </summary>
    public unsafe float TwistLimitDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// FloatProperty: AngularBreakThreshold
    /// </summary>
    public unsafe float AngularBreakThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: PulleyRatio
    /// </summary>
    public unsafe float PulleyRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// FloatProperty: MaxDistance
    /// </summary>
    public unsafe float MaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// FloatProperty: MinDistance
    /// </summary>
    public unsafe float MinDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }
}
