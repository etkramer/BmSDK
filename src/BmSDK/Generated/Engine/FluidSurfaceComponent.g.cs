#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: FluidSurfaceComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class FluidSurfaceComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.FluidSurfaceComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal FluidSurfaceComponent() { }

    /// <summary>
    /// Constructs a new FluidSurfaceComponent
    /// </summary>
    public FluidSurfaceComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, FluidSurfaceComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FluidSurfaceComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: FluidMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FluidMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: TargetSimulation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetSimulation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ObjectProperty: TargetDetail
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// IntProperty: LightMapResolution
    /// </summary>
    public unsafe int LightMapResolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// StructProperty: LightmassSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LightmassSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: EnableSimulation
    /// </summary>
    public unsafe bool EnableSimulation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: EnableDetail
    /// </summary>
    public unsafe bool EnableDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bTiling
    /// </summary>
    public unsafe bool bTiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bPause
    /// </summary>
    public unsafe bool bPause
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bShowSimulationNormals
    /// </summary>
    public unsafe bool bShowSimulationNormals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bShowSimulationPosition
    /// </summary>
    public unsafe bool bShowSimulationPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bShowDetailNormals
    /// </summary>
    public unsafe bool bShowDetailNormals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bShowDetailPosition
    /// </summary>
    public unsafe bool bShowDetailPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bShowFluidSimulation
    /// </summary>
    public unsafe bool bShowFluidSimulation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bShowFluidDetail
    /// </summary>
    public unsafe bool bShowFluidDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bTestRipple
    /// </summary>
    public unsafe bool bTestRipple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bTestRippleCenterOnDetail
    /// </summary>
    public unsafe bool bTestRippleCenterOnDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// IntProperty: SimulationQuadsX
    /// </summary>
    public unsafe int SimulationQuadsX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// IntProperty: SimulationQuadsY
    /// </summary>
    public unsafe int SimulationQuadsY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: GridSpacing
    /// </summary>
    public unsafe float GridSpacing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: GridSpacingLowRes
    /// </summary>
    public unsafe float GridSpacingLowRes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: GPUTessellationFactor
    /// </summary>
    public unsafe float GPUTessellationFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: FluidDamping
    /// </summary>
    public unsafe float FluidDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: FluidTravelSpeed
    /// </summary>
    public unsafe float FluidTravelSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// FloatProperty: FluidHeightScale
    /// </summary>
    public unsafe float FluidHeightScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: FluidUpdateRate
    /// </summary>
    public unsafe float FluidUpdateRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: ForceImpact
    /// </summary>
    public unsafe float ForceImpact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// FloatProperty: ForceContinuous
    /// </summary>
    public unsafe float ForceContinuous
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// FloatProperty: LightingContrast
    /// </summary>
    public unsafe float LightingContrast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// FloatProperty: DeactivationDistance
    /// </summary>
    public unsafe float DeactivationDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// IntProperty: DetailResolution
    /// </summary>
    public unsafe int DetailResolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: DetailSize
    /// </summary>
    public unsafe float DetailSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// FloatProperty: DetailDamping
    /// </summary>
    public unsafe float DetailDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: DetailTravelSpeed
    /// </summary>
    public unsafe float DetailTravelSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: DetailTransfer
    /// </summary>
    public unsafe float DetailTransfer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: DetailHeightScale
    /// </summary>
    public unsafe float DetailHeightScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// FloatProperty: DetailUpdateRate
    /// </summary>
    public unsafe float DetailUpdateRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// FloatProperty: NormalLength
    /// </summary>
    public unsafe float NormalLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// FloatProperty: TestRippleSpeed
    /// </summary>
    public unsafe float TestRippleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// FloatProperty: TestRippleFrequency
    /// </summary>
    public unsafe float TestRippleFrequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: TestRippleRadius
    /// </summary>
    public unsafe float TestRippleRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: FluidWidth
    /// </summary>
    public unsafe float FluidWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: FluidHeight
    /// </summary>
    public unsafe float FluidHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: TestRippleTime
    /// </summary>
    public unsafe float TestRippleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// FloatProperty: TestRippleAngle
    /// </summary>
    public unsafe float TestRippleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: DeactivationTimer
    /// </summary>
    public unsafe float DeactivationTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: ViewDistance
    /// </summary>
    public unsafe float ViewDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StructProperty: SimulationPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SimulationPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StructProperty: DetailPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DetailPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ArrayProperty: ClampMap
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> ClampMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ArrayProperty: ShadowMaps
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ShadowMaps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// StructProperty: LightMap
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LightMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// StructProperty: FluidSimulation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FluidSimulation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }
}
