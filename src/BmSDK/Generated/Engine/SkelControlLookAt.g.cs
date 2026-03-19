#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControlLookAt<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SkelControlLookAt : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkelControlLookAt", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkelControlLookAt() { }

    /// <summary>
    /// Constructs a new SkelControlLookAt
    /// </summary>
    public SkelControlLookAt(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkelControlLookAt Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkelControlLookAt(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: TargetLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ByteProperty: TargetLocationSpace
    /// </summary>
    public unsafe byte TargetLocationSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ByteProperty: LookAtAxis
    /// </summary>
    public unsafe byte LookAtAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 261); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 261); }
    }

    /// <summary>
    /// ByteProperty: UpAxis
    /// </summary>
    public unsafe byte UpAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 262); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 262); }
    }

    /// <summary>
    /// ByteProperty: AllowRotationSpace
    /// </summary>
    public unsafe byte AllowRotationSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 263); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 263); }
    }

    /// <summary>
    /// NameProperty: TargetSpaceBoneName
    /// </summary>
    public unsafe BmSDK.FName TargetSpaceBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bInvertLookAtAxis
    /// </summary>
    public unsafe bool bInvertLookAtAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bDefineUpAxis
    /// </summary>
    public unsafe bool bDefineUpAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bInvertUpAxis
    /// </summary>
    public unsafe bool bInvertUpAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bEnableLimit
    /// </summary>
    public unsafe bool bEnableLimit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bLimitBasedOnRefPose
    /// </summary>
    public unsafe bool bLimitBasedOnRefPose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bDisableBeyondLimit
    /// </summary>
    public unsafe bool bDisableBeyondLimit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bNotifyBeyondLimit
    /// </summary>
    public unsafe bool bNotifyBeyondLimit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bShowLimit
    /// </summary>
    public unsafe bool bShowLimit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAllowRotationX
    /// </summary>
    public unsafe bool bAllowRotationX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAllowRotationY
    /// </summary>
    public unsafe bool bAllowRotationY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAllowRotationZ
    /// </summary>
    public unsafe bool bAllowRotationZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// FloatProperty: TargetLocationInterpSpeed
    /// </summary>
    public unsafe float TargetLocationInterpSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StructProperty: DesiredTargetLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DesiredTargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// StructProperty: ActorSpaceLookAtTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ActorSpaceLookAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// FloatProperty: MaxAngle
    /// </summary>
    public unsafe float MaxAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// FloatProperty: OuterMaxAngle
    /// </summary>
    public unsafe float OuterMaxAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// FloatProperty: DeadZoneAngle
    /// </summary>
    public unsafe float DeadZoneAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: RotationAngleRangeX
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RotationAngleRangeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StructProperty: RotationAngleRangeY
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RotationAngleRangeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StructProperty: RotationAngleRangeZ
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RotationAngleRangeZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// NameProperty: AllowRotationOtherBoneName
    /// </summary>
    public unsafe BmSDK.FName AllowRotationOtherBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// FloatProperty: LookAtAlpha
    /// </summary>
    public unsafe float LookAtAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// FloatProperty: LookAtAlphaTarget
    /// </summary>
    public unsafe float LookAtAlphaTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: LookAtAlphaBlendTimeToGo
    /// </summary>
    public unsafe float LookAtAlphaBlendTimeToGo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// StructProperty: LimitLookDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LimitLookDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// StructProperty: BaseLookDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BaseLookDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// StructProperty: BaseBonePos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BaseBonePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// FloatProperty: LastCalcTime
    /// </summary>
    public unsafe float LastCalcTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// IntProperty: ControlBoneIndex
    /// </summary>
    public unsafe int ControlBoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}
