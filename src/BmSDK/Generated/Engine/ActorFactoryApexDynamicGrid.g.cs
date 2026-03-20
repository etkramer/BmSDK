#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryApexDynamicGrid<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ActorFactoryApexDynamicGrid : BmSDK.Engine.ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryApexDynamicGrid", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryApexDynamicGrid() { }

    /// <summary>
    /// Constructs a new ActorFactoryApexDynamicGrid
    /// </summary>
    public ActorFactoryApexDynamicGrid(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryApexDynamicGrid Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryApexDynamicGrid(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: poolDimX
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridPoolDim poolDimX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridPoolDim>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ByteProperty: poolDimY
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridPoolDim poolDimY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridPoolDim>(Ptr + 145); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 145); }
    }

    /// <summary>
    /// ByteProperty: poolDimZ
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridPoolDim poolDimZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridPoolDim>(Ptr + 146); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 146); }
    }

    /// <summary>
    /// ByteProperty: boundingGridDimX
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridBoundingGridDim boundingGridDimX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridBoundingGridDim>(Ptr + 147); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 147); }
    }

    /// <summary>
    /// ByteProperty: boundingGridDimY
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridBoundingGridDim boundingGridDimY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridBoundingGridDim>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ByteProperty: boundingGridDimZ
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridBoundingGridDim boundingGridDimZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridBoundingGridDim>(Ptr + 149); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 149); }
    }

    /// <summary>
    /// ByteProperty: CollisionChannel
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel CollisionChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel>(Ptr + 150); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 150); }
    }

    /// <summary>
    /// StructProperty: blockSizeWorld
    /// </summary>
    public unsafe System.Numerics.Vector3 blockSizeWorld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: trackCameraPosition
    /// </summary>
    public unsafe bool trackCameraPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// FloatProperty: vorticityConfinement
    /// </summary>
    public unsafe float vorticityConfinement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// IntProperty: velocitySmoothingIterationsForVC
    /// </summary>
    public unsafe int velocitySmoothingIterationsForVC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// FloatProperty: particleVelocityDissipation
    /// </summary>
    public unsafe float particleVelocityDissipation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// FloatProperty: gridVelocityDissipation
    /// </summary>
    public unsafe float gridVelocityDissipation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: particleToGridCoupling
    /// </summary>
    public unsafe BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFParticleToGridCouplingParams particleToGridCoupling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFParticleToGridCouplingParams>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// StructProperty: gridToParticleCoupling
    /// </summary>
    public unsafe BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFGridToParticleCouplingParams gridToParticleCoupling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFGridToParticleCouplingParams>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StructProperty: particleDensity
    /// </summary>
    public unsafe BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFDensityParams particleDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFDensityParams>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: pressureSolverIterations
    /// </summary>
    public unsafe int pressureSolverIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StructProperty: pressureMultigrid
    /// </summary>
    public unsafe BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFMultigridParams pressureMultigrid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFMultigridParams>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// StructProperty: stochasticParticleAdvection
    /// </summary>
    public unsafe BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFStochasticParticleAdvectionParams stochasticParticleAdvection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFStochasticParticleAdvectionParams>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// StructProperty: MacCormackAdvection
    /// </summary>
    public unsafe BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFMacCormackAdvectionParams MacCormackAdvection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFMacCormackAdvectionParams>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StructProperty: selfShadowing
    /// </summary>
    public unsafe BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFSelfShadowingParams selfShadowing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFSelfShadowingParams>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// StructProperty: selfShadowingSpotlight
    /// </summary>
    public unsafe BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFSelfShadowingSpotlightParams selfShadowingSpotlight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ActorFactoryApexDynamicGrid.FSFSelfShadowingSpotlightParams>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StructProperty: CollideWithChannels
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer CollideWithChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }
}
