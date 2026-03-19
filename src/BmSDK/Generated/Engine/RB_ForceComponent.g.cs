#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RB_ForceComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RB_ForceComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RB_ForceComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RB_ForceComponent() { }

    /// <summary>
    /// Constructs a new RB_ForceComponent
    /// </summary>
    public RB_ForceComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RB_ForceComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RB_ForceComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bUseNxForcefield
    /// </summary>
    public unsafe bool bUseNxForcefield
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: bForceActive
    /// </summary>
    public unsafe bool bForceActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: bDetachWhenInactive
    /// </summary>
    public unsafe bool bDetachWhenInactive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: bForceApplyToCloth
    /// </summary>
    public unsafe bool bForceApplyToCloth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: bForceApplyToFluid
    /// </summary>
    public unsafe bool bForceApplyToFluid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: bForceApplyToRigidBodies
    /// </summary>
    public unsafe bool bForceApplyToRigidBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: bForceApplyToProjectiles
    /// </summary>
    public unsafe bool bForceApplyToProjectiles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// ByteProperty: ForceMode
    /// </summary>
    public unsafe byte ForceMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: Duration
    /// </summary>
    public unsafe float Duration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StructProperty: CollideWithChannels
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CollideWithChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// FloatProperty: ElapsedTime
    /// </summary>
    public unsafe float ElapsedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ComponentProperty: RenderComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RenderComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// StructProperty: LinearKernel
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LinearKernel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// StructProperty: TheNxForceField
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TheNxForceField
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// Enum: EForceModeType
    /// </summary>
    public enum EForceModeType
    {
        FMT_Constant = 0,
        FMT_Impulse = 1,
        FMT_MAX = 2,
    }
}
