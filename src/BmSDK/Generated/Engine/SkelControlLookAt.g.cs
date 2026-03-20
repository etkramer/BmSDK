#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControlLookAt<br/>
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
    public unsafe System.Numerics.Vector3 TargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ByteProperty: TargetLocationSpace
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlBase.EBoneControlSpace TargetLocationSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlBase.EBoneControlSpace>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ByteProperty: LookAtAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis LookAtAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 261); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 261); }
    }

    /// <summary>
    /// ByteProperty: UpAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis UpAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 262); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 262); }
    }

    /// <summary>
    /// ByteProperty: AllowRotationSpace
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlBase.EBoneControlSpace AllowRotationSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlBase.EBoneControlSpace>(Ptr + 263); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bDefineUpAxis
    /// </summary>
    public unsafe bool bDefineUpAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bInvertUpAxis
    /// </summary>
    public unsafe bool bInvertUpAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bEnableLimit
    /// </summary>
    public unsafe bool bEnableLimit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bLimitBasedOnRefPose
    /// </summary>
    public unsafe bool bLimitBasedOnRefPose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bDisableBeyondLimit
    /// </summary>
    public unsafe bool bDisableBeyondLimit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bNotifyBeyondLimit
    /// </summary>
    public unsafe bool bNotifyBeyondLimit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bShowLimit
    /// </summary>
    public unsafe bool bShowLimit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAllowRotationX
    /// </summary>
    public unsafe bool bAllowRotationX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAllowRotationY
    /// </summary>
    public unsafe bool bAllowRotationY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAllowRotationZ
    /// </summary>
    public unsafe bool bAllowRotationZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
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
    public unsafe System.Numerics.Vector3 DesiredTargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// StructProperty: ActorSpaceLookAtTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 ActorSpaceLookAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 292); }
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
    public unsafe System.Numerics.Vector2 RotationAngleRangeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StructProperty: RotationAngleRangeY
    /// </summary>
    public unsafe System.Numerics.Vector2 RotationAngleRangeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StructProperty: RotationAngleRangeZ
    /// </summary>
    public unsafe System.Numerics.Vector2 RotationAngleRangeZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 332); }
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
    public unsafe System.Numerics.Vector3 LimitLookDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// StructProperty: BaseLookDir
    /// </summary>
    public unsafe System.Numerics.Vector3 BaseLookDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// StructProperty: BaseBonePos
    /// </summary>
    public unsafe System.Numerics.Vector3 BaseBonePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 384); }
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
