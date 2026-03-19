#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: FluidInfluenceComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class FluidInfluenceComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.FluidInfluenceComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal FluidInfluenceComponent() { }

    /// <summary>
    /// Constructs a new FluidInfluenceComponent
    /// </summary>
    public FluidInfluenceComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, FluidInfluenceComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FluidInfluenceComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: RaindropFillEntireFluid
    /// </summary>
    public unsafe bool RaindropFillEntireFluid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: bIsToggleTriggered
    /// </summary>
    public unsafe bool bIsToggleTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: FluidActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FluidActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ObjectProperty: CurrentFluidActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentFluidActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ByteProperty: InfluenceType
    /// </summary>
    public unsafe byte InfluenceType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// FloatProperty: MaxDistance
    /// </summary>
    public unsafe float MaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: WaveStrength
    /// </summary>
    public unsafe float WaveStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// FloatProperty: WaveFrequency
    /// </summary>
    public unsafe float WaveFrequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// FloatProperty: WavePhase
    /// </summary>
    public unsafe float WavePhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// FloatProperty: WaveRadius
    /// </summary>
    public unsafe float WaveRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: RaindropAreaRadius
    /// </summary>
    public unsafe float RaindropAreaRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: RaindropRadius
    /// </summary>
    public unsafe float RaindropRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// FloatProperty: RaindropStrength
    /// </summary>
    public unsafe float RaindropStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// FloatProperty: RaindropRate
    /// </summary>
    public unsafe float RaindropRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: FlowSpeed
    /// </summary>
    public unsafe float FlowSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// IntProperty: FlowNumRipples
    /// </summary>
    public unsafe int FlowNumRipples
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: FlowSideMotionRadius
    /// </summary>
    public unsafe float FlowSideMotionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: FlowWaveRadius
    /// </summary>
    public unsafe float FlowWaveRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: FlowStrength
    /// </summary>
    public unsafe float FlowStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: FlowFrequency
    /// </summary>
    public unsafe float FlowFrequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: SphereOuterRadius
    /// </summary>
    public unsafe float SphereOuterRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// FloatProperty: SphereInnerRadius
    /// </summary>
    public unsafe float SphereInnerRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: SphereStrength
    /// </summary>
    public unsafe float SphereStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: CurrentAngle
    /// </summary>
    public unsafe float CurrentAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// FloatProperty: CurrentTimer
    /// </summary>
    public unsafe float CurrentTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// Enum: EInfluenceType
    /// </summary>
    public enum EInfluenceType
    {
        Fluid_Flow = 0,
        Fluid_Raindrops = 1,
        Fluid_Wave = 2,
        Fluid_Sphere = 3,
        Fluid_MAX = 4,
    }
}
