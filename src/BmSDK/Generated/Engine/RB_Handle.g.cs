#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RB_Handle<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RB_Handle : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RB_Handle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RB_Handle() { }

    /// <summary>
    /// Constructs a new RB_Handle
    /// </summary>
    public RB_Handle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RB_Handle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RB_Handle(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: GrabbedComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrabbedComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// NameProperty: GrabbedBoneName
    /// </summary>
    public unsafe BmSDK.FName GrabbedBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// IntProperty: SceneIndex
    /// </summary>
    public unsafe int SceneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bInHardware
    /// </summary>
    public unsafe bool bInHardware
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: bRotationConstrained
    /// </summary>
    public unsafe bool bRotationConstrained
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: bInterpolating
    /// </summary>
    public unsafe bool bInterpolating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }
    }

    /// <summary>
    /// StructProperty: HandleData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HandleData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StructProperty: KinActorData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT KinActorData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: LinearDamping
    /// </summary>
    public unsafe float LinearDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// FloatProperty: LinearStiffness
    /// </summary>
    public unsafe float LinearStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StructProperty: LinearStiffnessScale3D
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LinearStiffnessScale3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: LinearDampingScale3D
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LinearDampingScale3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// FloatProperty: AngularDamping
    /// </summary>
    public unsafe float AngularDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// FloatProperty: AngularStiffness
    /// </summary>
    public unsafe float AngularStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: AngularForceLimit
    /// </summary>
    public unsafe float AngularForceLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: Destination
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Destination
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// StructProperty: StepSize
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StepSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Location
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
}
