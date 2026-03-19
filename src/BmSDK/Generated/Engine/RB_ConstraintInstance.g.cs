#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RB_ConstraintInstance<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RB_ConstraintInstance : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RB_ConstraintInstance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RB_ConstraintInstance() { }

    /// <summary>
    /// Constructs a new RB_ConstraintInstance
    /// </summary>
    public RB_ConstraintInstance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RB_ConstraintInstance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RB_ConstraintInstance(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Owner
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Owner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ComponentProperty: OwnerComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OwnerComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// IntProperty: ConstraintIndex
    /// </summary>
    public unsafe int ConstraintIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: SceneIndex
    /// </summary>
    public unsafe int SceneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bInHardware
    /// </summary>
    public unsafe bool bInHardware
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bLinearXPositionDrive
    /// </summary>
    public unsafe bool bLinearXPositionDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bLinearXVelocityDrive
    /// </summary>
    public unsafe bool bLinearXVelocityDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bLinearYPositionDrive
    /// </summary>
    public unsafe bool bLinearYPositionDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bLinearYVelocityDrive
    /// </summary>
    public unsafe bool bLinearYVelocityDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bLinearZPositionDrive
    /// </summary>
    public unsafe bool bLinearZPositionDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bLinearZVelocityDrive
    /// </summary>
    public unsafe bool bLinearZVelocityDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bSwingPositionDrive
    /// </summary>
    public unsafe bool bSwingPositionDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bSwingVelocityDrive
    /// </summary>
    public unsafe bool bSwingVelocityDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bTwistPositionDrive
    /// </summary>
    public unsafe bool bTwistPositionDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bTwistVelocityDrive
    /// </summary>
    public unsafe bool bTwistVelocityDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bAngularSlerpDrive
    /// </summary>
    public unsafe bool bAngularSlerpDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bTerminated
    /// </summary>
    public unsafe bool bTerminated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bDisableConstraint
    /// </summary>
    public unsafe bool bDisableConstraint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// StructProperty: ConstraintData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConstraintData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: PulleyJoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PulleyJoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// StructProperty: LinearPositionTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LinearPositionTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StructProperty: LinearVelocityTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LinearVelocityTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: LinearDriveSpring
    /// </summary>
    public unsafe float LinearDriveSpring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: LinearDriveDamping
    /// </summary>
    public unsafe float LinearDriveDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: LinearDriveForceLimit
    /// </summary>
    public unsafe float LinearDriveForceLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// StructProperty: AngularPositionTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AngularPositionTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: AngularVelocityTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AngularVelocityTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// FloatProperty: AngularDriveSpring
    /// </summary>
    public unsafe float AngularDriveSpring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// FloatProperty: AngularDriveDamping
    /// </summary>
    public unsafe float AngularDriveDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: AngularDriveForceLimit
    /// </summary>
    public unsafe float AngularDriveForceLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StructProperty: DummyKinActor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DummyKinActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
}
