#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexDynamicGridComponent<br/>
/// (size = 876)
/// (flags = 2290094290)
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

    /// <summary>
    /// Gets the class default object as ApexDynamicGridComponent.
    /// </summary>
    public static ApexDynamicGridComponent DefaultObject => (ApexDynamicGridComponent)StaticClass().DefaultObject;

    internal ApexDynamicGridComponent() { }

    /// <summary>
    /// Constructs a new ApexDynamicGridComponent
    /// </summary>
    public ApexDynamicGridComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexDynamicGridComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexDynamicGridComponent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ApexDynamicGridComponent>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ApexDynamicGridComponent>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ApexDynamicGridComponent>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ApexDynamicGridComponent>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ApexDynamicGridComponent>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ApexDynamicGridComponent>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ApexDynamicGridComponent>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ApexDynamicGridComponent>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Struct: FSCSelfShadowingSpotlightParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial record struct FSCSelfShadowingSpotlightParams
    {
        /// <summary>
        /// BoolProperty: Enabled
        /// </summary>
        public unsafe bool Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: saturationDensity
        /// </summary>
        public unsafe float saturationDensity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: Direction
        /// </summary>
        public unsafe System.Numerics.Vector3 Direction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: LocationOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 LocationOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: FOV
        /// </summary>
        public unsafe float FOV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: NearPlane
        /// </summary>
        public unsafe float NearPlane
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: FarPlane
        /// </summary>
        public unsafe float FarPlane
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ByteProperty: RealColumns
        /// </summary>
        public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridRealColumns RealColumns
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridRealColumns>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ByteProperty: VirtualColumns
        /// </summary>
        public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridVirtualColumns VirtualColumns
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridVirtualColumns>(Ptr + 45); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 45); }; }
        }

        /// <summary>
        /// ByteProperty: ColumnDepthResolution
        /// </summary>
        public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridCells ColumnDepthResolution
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridCells>(Ptr + 46); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 46); }; }
        }

        /// <summary>
        /// FloatProperty: shadowCouplingTimeConstant
        /// </summary>
        public unsafe float shadowCouplingTimeConstant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: SampleOffset
        /// </summary>
        public unsafe float SampleOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
    }

    /// <summary>
    /// Struct: FSCSelfShadowingParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FSCSelfShadowingParams
    {
        /// <summary>
        /// BoolProperty: Enabled
        /// </summary>
        public unsafe bool Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: saturationDensity
        /// </summary>
        public unsafe float saturationDensity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: directionToLight
        /// </summary>
        public unsafe BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridDirection directionToLight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.EDynamicGridDirection>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: rawDensityWeight
        /// </summary>
        public unsafe float rawDensityWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: shadowMinDensity
        /// </summary>
        public unsafe float shadowMinDensity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: shadowCouplingTimeConstant
        /// </summary>
        public unsafe float shadowCouplingTimeConstant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FSCMacCormackAdvectionParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSCMacCormackAdvectionParams
    {
        /// <summary>
        /// BoolProperty: Enabled
        /// </summary>
        public unsafe bool Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Sharpness
        /// </summary>
        public unsafe float Sharpness
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FSCStochasticParticleAdvectionParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSCStochasticParticleAdvectionParams
    {
        /// <summary>
        /// BoolProperty: Enabled
        /// </summary>
        public unsafe bool Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: SpatialStandardDeviation
        /// </summary>
        public unsafe float SpatialStandardDeviation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: VelocityStandardDeviation
        /// </summary>
        public unsafe float VelocityStandardDeviation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FSCDensityParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial record struct FSCDensityParams
    {
        /// <summary>
        /// BoolProperty: Enabled
        /// </summary>
        public unsafe bool Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: smoothingRate
        /// </summary>
        public unsafe float smoothingRate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: smoothingIterations
        /// </summary>
        public unsafe int smoothingIterations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: multigrid
        /// </summary>
        public unsafe BmSDK.Engine.ApexDynamicGridComponent.FSCMultigridParams multigrid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.FSCMultigridParams>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: smoothingRadius
        /// </summary>
        public unsafe float smoothingRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: saturationThreshold
        /// </summary>
        public unsafe float saturationThreshold
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: GammaCorrection
        /// </summary>
        public unsafe float GammaCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: Buoyancy
        /// </summary>
        public unsafe float Buoyancy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: BuoyancyAdvanced
        /// </summary>
        public unsafe BmSDK.Engine.ApexDynamicGridComponent.FSCBuoyancyAdvancedParams BuoyancyAdvanced
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.FSCBuoyancyAdvancedParams>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: Expansion
        /// </summary>
        public unsafe float Expansion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// StructProperty: ExpansionAdvanced
        /// </summary>
        public unsafe BmSDK.Engine.ApexDynamicGridComponent.FSCExpansionAdvancedParams ExpansionAdvanced
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridComponent.FSCExpansionAdvancedParams>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FSCExpansionAdvancedParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSCExpansionAdvancedParams
    {
        /// <summary>
        /// FloatProperty: rawDensityWeight
        /// </summary>
        public unsafe float rawDensityWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: rateBias
        /// </summary>
        public unsafe float rateBias
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: rateMaximum
        /// </summary>
        public unsafe float rateMaximum
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: rateMinimum
        /// </summary>
        public unsafe float rateMinimum
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSCBuoyancyAdvancedParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSCBuoyancyAdvancedParams
    {
        /// <summary>
        /// FloatProperty: rawDensityWeight
        /// </summary>
        public unsafe float rawDensityWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: forceBias
        /// </summary>
        public unsafe float forceBias
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: forceMaximum
        /// </summary>
        public unsafe float forceMaximum
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: forceMinimum
        /// </summary>
        public unsafe float forceMinimum
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSCMultigridParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSCMultigridParams
    {
        /// <summary>
        /// BoolProperty: Enabled
        /// </summary>
        public unsafe bool Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Levels
        /// </summary>
        public unsafe int Levels
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: FineIterations
        /// </summary>
        public unsafe int FineIterations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: CoarseIterations
        /// </summary>
        public unsafe int CoarseIterations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSCGridToParticleCouplingParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSCGridToParticleCouplingParams
    {
        /// <summary>
        /// FloatProperty: accelTimeConstant
        /// </summary>
        public unsafe float accelTimeConstant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: decelTimeConstant
        /// </summary>
        public unsafe float decelTimeConstant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: thresholdMultiplier
        /// </summary>
        public unsafe float thresholdMultiplier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FSCParticleToGridCouplingParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSCParticleToGridCouplingParams
    {
        /// <summary>
        /// FloatProperty: accelTimeConstant
        /// </summary>
        public unsafe float accelTimeConstant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: decelTimeConstant
        /// </summary>
        public unsafe float decelTimeConstant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: thresholdMultiplier
        /// </summary>
        public unsafe float thresholdMultiplier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

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
    public unsafe ref System.Numerics.Vector3 blockSizeWorld
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 612);

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
    public unsafe ref BmSDK.Engine.ApexDynamicGridComponent.FSCParticleToGridCouplingParams particleToGridCoupling
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.ApexDynamicGridComponent.FSCParticleToGridCouplingParams>(Ptr + 644);

    /// <summary>
    /// StructProperty: gridToParticleCoupling
    /// </summary>
    public unsafe ref BmSDK.Engine.ApexDynamicGridComponent.FSCGridToParticleCouplingParams gridToParticleCoupling
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.ApexDynamicGridComponent.FSCGridToParticleCouplingParams>(Ptr + 656);

    /// <summary>
    /// StructProperty: particleDensity
    /// </summary>
    public unsafe ref BmSDK.Engine.ApexDynamicGridComponent.FSCDensityParams particleDensity
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.ApexDynamicGridComponent.FSCDensityParams>(Ptr + 668);

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
    public unsafe ref BmSDK.Engine.ApexDynamicGridComponent.FSCMultigridParams pressureMultigrid
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.ApexDynamicGridComponent.FSCMultigridParams>(Ptr + 752);

    /// <summary>
    /// StructProperty: stochasticParticleAdvection
    /// </summary>
    public unsafe ref BmSDK.Engine.ApexDynamicGridComponent.FSCStochasticParticleAdvectionParams stochasticParticleAdvection
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.ApexDynamicGridComponent.FSCStochasticParticleAdvectionParams>(Ptr + 768);

    /// <summary>
    /// StructProperty: MacCormackAdvection
    /// </summary>
    public unsafe ref BmSDK.Engine.ApexDynamicGridComponent.FSCMacCormackAdvectionParams MacCormackAdvection
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.ApexDynamicGridComponent.FSCMacCormackAdvectionParams>(Ptr + 780);

    /// <summary>
    /// StructProperty: selfShadowing
    /// </summary>
    public unsafe ref BmSDK.Engine.ApexDynamicGridComponent.FSCSelfShadowingParams selfShadowing
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.ApexDynamicGridComponent.FSCSelfShadowingParams>(Ptr + 788);

    /// <summary>
    /// StructProperty: selfShadowingSpotlight
    /// </summary>
    public unsafe ref BmSDK.Engine.ApexDynamicGridComponent.FSCSelfShadowingSpotlightParams selfShadowingSpotlight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.ApexDynamicGridComponent.FSCSelfShadowingSpotlightParams>(Ptr + 812);

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
    public enum EDynamicGridCells : byte
    {
        CELLS_64 = 0,
        CELLS_128 = 1,
        CELLS_256 = 2,
        CELLS_512 = 3,
        CELLS_MAX = 4,
    }

    /// <summary>
    /// Enum: EDynamicGridVirtualColumns
    /// </summary>
    public enum EDynamicGridVirtualColumns : byte
    {
        VCOLUMNS_4096 = 0,
        VCOLUMNS_16384 = 1,
        VCOLUMNS_65536 = 2,
        VCOLUMNS_262144 = 3,
        VCOLUMNS_1048576 = 4,
        VCOLUMNS_MAX = 5,
    }

    /// <summary>
    /// Enum: EDynamicGridRealColumns
    /// </summary>
    public enum EDynamicGridRealColumns : byte
    {
        RCOLUMNS_64 = 0,
        RCOLUMNS_128 = 1,
        RCOLUMNS_256 = 2,
        RCOLUMNS_512 = 3,
        RCOLUMNS_1024 = 4,
        RCOLUMNS_2048 = 5,
        RCOLUMNS_4096 = 6,
        RCOLUMNS_MAX = 7,
    }

    /// <summary>
    /// Enum: EDynamicGridDirection
    /// </summary>
    public enum EDynamicGridDirection : byte
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
    public enum EDynamicGridBoundingGridDim : byte
    {
        DG_VBLOCKS_16 = 0,
        DG_VBLOCKS_32 = 1,
        DG_VBLOCKS_64 = 2,
        DG_VBLOCKS_128 = 3,
        DG_VBLOCKS_256 = 4,
        DG_VBLOCKS_MAX = 5,
    }

    /// <summary>
    /// Enum: EDynamicGridPoolDim
    /// </summary>
    public enum EDynamicGridPoolDim : byte
    {
        DG_BLOCKS_4 = 0,
        DG_BLOCKS_8 = 1,
        DG_BLOCKS_16 = 2,
        DG_BLOCKS_32 = 3,
        DG_BLOCKS_64 = 4,
        DG_BLOCKS_MAX = 5,
    }
}
