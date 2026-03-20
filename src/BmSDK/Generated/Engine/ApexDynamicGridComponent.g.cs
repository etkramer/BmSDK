#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexDynamicGridComponent<br/>
/// (flags = 0)
/// </summary>
public partial class ApexDynamicGridComponent : BmSDK.Engine.ApexFieldSamplerComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexDynamicGridComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexDynamicGridComponent() { }

    /// <summary>
    /// Constructs a new ApexDynamicGridComponent
    /// </summary>
    public ApexDynamicGridComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexDynamicGridComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexDynamicGridComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: poolDimX
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridPoolDim poolDimX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridPoolDim>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ByteProperty: poolDimY
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridPoolDim poolDimY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridPoolDim>(Ptr + 605); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 605); }
    }

    /// <summary>
    /// ByteProperty: poolDimZ
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridPoolDim poolDimZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridPoolDim>(Ptr + 606); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 606); }
    }

    /// <summary>
    /// ByteProperty: boundingGridDimX
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridBoundingGridDim boundingGridDimX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridBoundingGridDim>(Ptr + 607); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 607); }
    }

    /// <summary>
    /// ByteProperty: boundingGridDimY
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridBoundingGridDim boundingGridDimY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridBoundingGridDim>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ByteProperty: boundingGridDimZ
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridBoundingGridDim boundingGridDimZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridBoundingGridDim>(Ptr + 609); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 609); }
    }

    /// <summary>
    /// StructProperty: blockSizeWorld
    /// </summary>
    public unsafe System.Numerics.Vector3 blockSizeWorld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: trackCameraPosition
    /// </summary>
    public unsafe bool trackCameraPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 624); }
    }

    /// <summary>
    /// FloatProperty: vorticityConfinement
    /// </summary>
    public unsafe float vorticityConfinement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// IntProperty: velocitySmoothingIterationsForVC
    /// </summary>
    public unsafe int velocitySmoothingIterationsForVC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: particleVelocityDissipation
    /// </summary>
    public unsafe float particleVelocityDissipation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// FloatProperty: gridVelocityDissipation
    /// </summary>
    public unsafe float gridVelocityDissipation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// StructProperty: particleToGridCoupling
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.FSCParticleToGridCouplingParams particleToGridCoupling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.FSCParticleToGridCouplingParams>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// StructProperty: gridToParticleCoupling
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.FSCGridToParticleCouplingParams gridToParticleCoupling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.FSCGridToParticleCouplingParams>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// StructProperty: particleDensity
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.FSCDensityParams particleDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.FSCDensityParams>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// IntProperty: pressureSolverIterations
    /// </summary>
    public unsafe int pressureSolverIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// StructProperty: pressureMultigrid
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.FSCMultigridParams pressureMultigrid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.FSCMultigridParams>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StructProperty: stochasticParticleAdvection
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.FSCStochasticParticleAdvectionParams stochasticParticleAdvection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.FSCStochasticParticleAdvectionParams>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// StructProperty: MacCormackAdvection
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.FSCMacCormackAdvectionParams MacCormackAdvection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.FSCMacCormackAdvectionParams>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// StructProperty: selfShadowing
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.FSCSelfShadowingParams selfShadowing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.FSCSelfShadowingParams>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// StructProperty: selfShadowingSpotlight
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.FSCSelfShadowingSpotlightParams selfShadowingSpotlight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.FSCSelfShadowingSpotlightParams>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ComponentProperty: DrawComponent2
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent DrawComponent2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// Enum: EDynamicGridCells
    /// </summary>
    public enum EDynamicGridCells
    {
        CELLS = 0,
        CELLS_2 = 1,
        CELLS_3 = 2,
        CELLS_4 = 3,
        CELLS_MAX = 4,
    }

    /// <summary>
    /// Enum: EDynamicGridVirtualColumns
    /// </summary>
    public enum EDynamicGridVirtualColumns
    {
        VCOLUMNS = 0,
        VCOLUMNS_2 = 1,
        VCOLUMNS_3 = 2,
        VCOLUMNS_4 = 3,
        VCOLUMNS_5 = 4,
        VCOLUMNS_MAX = 5,
    }

    /// <summary>
    /// Enum: EDynamicGridRealColumns
    /// </summary>
    public enum EDynamicGridRealColumns
    {
        RCOLUMNS = 0,
        RCOLUMNS_2 = 1,
        RCOLUMNS_3 = 2,
        RCOLUMNS_4 = 3,
        RCOLUMNS_5 = 4,
        RCOLUMNS_6 = 5,
        RCOLUMNS_7 = 6,
        RCOLUMNS_MAX = 7,
    }

    /// <summary>
    /// Enum: EDynamicGridDirection
    /// </summary>
    public enum EDynamicGridDirection
    {
        DG_AXIS_X_UP = 0,
        DG_AXIS_X_DOWN = 1,
        DG_AXIS_Y_UP = 2,
        DG_AXIS_Y_DOWN = 3,
        DG_AXIS_Z_UP = 4,
        DG_AXIS_Z_DOWN = 5,
        DG_AXIS_MAX = 6,
    }

    /// <summary>
    /// Enum: EDynamicGridBoundingGridDim
    /// </summary>
    public enum EDynamicGridBoundingGridDim
    {
        DG_VBLOCKS = 0,
        DG_VBLOCKS_2 = 1,
        DG_VBLOCKS_3 = 2,
        DG_VBLOCKS_4 = 3,
        DG_VBLOCKS_5 = 4,
        DG_VBLOCKS_MAX = 5,
    }

    /// <summary>
    /// Enum: EDynamicGridPoolDim
    /// </summary>
    public enum EDynamicGridPoolDim
    {
        DG_BLOCKS = 0,
        DG_BLOCKS_2 = 1,
        DG_BLOCKS_3 = 2,
        DG_BLOCKS_4 = 3,
        DG_BLOCKS_5 = 4,
        DG_BLOCKS_MAX = 5,
    }
}
