#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RFlaps_BodySetup<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RFlaps_BodySetup : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RFlaps_BodySetup", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFlaps_BodySetup() { }

    /// <summary>
    /// Constructs a new RFlaps_BodySetup
    /// </summary>
    public RFlaps_BodySetup(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFlaps_BodySetup Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFlaps_BodySetup(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: ConstraintSolverIterationCount
    /// </summary>
    public unsafe int ConstraintSolverIterationCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: EnableGroundPlaneCollision
    /// </summary>
    public unsafe bool EnableGroundPlaneCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: bFlapsBonesBlockApexCloth
    /// </summary>
    public unsafe bool bFlapsBonesBlockApexCloth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// FloatProperty: GroundPlaneCollisionRadius
    /// </summary>
    public unsafe float GroundPlaneCollisionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: GroundPlaneCollisionFriction
    /// </summary>
    public unsafe float GroundPlaneCollisionFriction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: SpringStrengthForDistanceConstraint
    /// </summary>
    public unsafe float SpringStrengthForDistanceConstraint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: Owner
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Owner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// NameProperty: BoneName
    /// </summary>
    public unsafe BmSDK.FName BoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: PoseControlParticles
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PoseControlParticles_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
    /// <summary>
    /// StructProperty: PoseControlParticles
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PoseControlParticles_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
    /// <summary>
    /// StructProperty: PoseControlParticles
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PoseControlParticles_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ByteProperty: PoseControlType
    /// </summary>
    public unsafe byte PoseControlType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// ArrayProperty: FlapParticles
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> FlapParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ArrayProperty: FlapConstraintRefs
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT FlapConstraintRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// Enum: ERFlapsPoseControlType
    /// </summary>
    public enum ERFlapsPoseControlType
    {
        RFPCT_RotationOnly = 0,
        RFPCT_PositionOnly = 1,
        RFPCT_Full = 2,
        RFPCT_MAX = 3,
    }
}
