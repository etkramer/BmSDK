#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Scout<br/>
/// (flags = 0)
/// </summary>
public partial class Scout : BmSDK.Engine.Pawn, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Scout", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Scout() { }

    /// <summary>
    /// Constructs a new Scout
    /// </summary>
    public Scout(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Scout Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Scout(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Scout>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Scout>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Scout>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Scout>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Scout>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Scout>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Scout>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: PathSizes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Scout.FPathSizeInfo> PathSizes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Scout.FPathSizeInfo>>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// FloatProperty: TestJumpZ
    /// </summary>
    public unsafe float TestJumpZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// FloatProperty: TestGroundSpeed
    /// </summary>
    public unsafe float TestGroundSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// FloatProperty: TestMaxFallSpeed
    /// </summary>
    public unsafe float TestMaxFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// FloatProperty: TestFallSpeed
    /// </summary>
    public unsafe float TestFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// FloatProperty: MaxLandingVelocity
    /// </summary>
    public unsafe float MaxLandingVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// IntProperty: MinNumPlayerStarts
    /// </summary>
    public unsafe int MinNumPlayerStarts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// ClassProperty: DefaultReachSpecClass
    /// </summary>
    public unsafe BmSDK.Class DefaultReachSpecClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// ArrayProperty: EdgePathColors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FColor> EdgePathColors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FColor>>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_StepSize
    /// </summary>
    public unsafe float NavMeshGen_StepSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_EntityHalfHeight
    /// </summary>
    public unsafe float NavMeshGen_EntityHalfHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_StartingHeightOffset
    /// </summary>
    public unsafe float NavMeshGen_StartingHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_MaxDropHeight
    /// </summary>
    public unsafe float NavMeshGen_MaxDropHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_MaxStepHeight
    /// </summary>
    public unsafe float NavMeshGen_MaxStepHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_VertZDeltaSnapThresh
    /// </summary>
    public unsafe float NavMeshGen_VertZDeltaSnapThresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_MinPolyArea
    /// </summary>
    public unsafe float NavMeshGen_MinPolyArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_BorderBackfill_CheckDist
    /// </summary>
    public unsafe float NavMeshGen_BorderBackfill_CheckDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_MinMergeDotAreaThreshold
    /// </summary>
    public unsafe float NavMeshGen_MinMergeDotAreaThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_MinMergeDotSmallArea
    /// </summary>
    public unsafe float NavMeshGen_MinMergeDotSmallArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_MinMergeDotLargeArea
    /// </summary>
    public unsafe float NavMeshGen_MinMergeDotLargeArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_MaxPolyHeight
    /// </summary>
    public unsafe float NavMeshGen_MaxPolyHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_MaxPolyBuildHeight
    /// </summary>
    public unsafe float NavMeshGen_MaxPolyBuildHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_HeightMergeThreshold
    /// </summary>
    public unsafe float NavMeshGen_HeightMergeThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_EdgeMaxDelta
    /// </summary>
    public unsafe float NavMeshGen_EdgeMaxDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_MaxGroundCheckSize
    /// </summary>
    public unsafe float NavMeshGen_MaxGroundCheckSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// FloatProperty: NavMeshGen_MinEdgeLength
    /// </summary>
    public unsafe float NavMeshGen_MinEdgeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: NavMeshGen_ExpansionDoObstacleMeshSimplification
    /// </summary>
    public unsafe bool NavMeshGen_ExpansionDoObstacleMeshSimplification
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1612) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1612); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1612); }
    }

    /// <summary>
    /// BoolProperty: bHightlightOneWayReachSpecs
    /// </summary>
    public unsafe bool bHightlightOneWayReachSpecs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1612) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1612); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1612); }
    }

    /// <summary>
    /// FloatProperty: MinMantleFallDist
    /// </summary>
    public unsafe float MinMantleFallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// FloatProperty: MaxMantleFallDist
    /// </summary>
    public unsafe float MaxMantleFallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// FloatProperty: MinMantleLateralDist
    /// </summary>
    public unsafe float MinMantleLateralDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// FloatProperty: MaxMantleLateralDist
    /// </summary>
    public unsafe float MaxMantleLateralDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }

    /// <summary>
    /// FloatProperty: MaxMantleFallTime
    /// </summary>
    public unsafe float MaxMantleFallTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// Struct: FPathSizeInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FPathSizeInfo
    {
        /// <summary>
        /// NameProperty: Desc
        /// </summary>
        public unsafe BmSDK.FName Desc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Radius
        /// </summary>
        public unsafe float Radius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: Height
        /// </summary>
        public unsafe float Height
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: CrouchHeight
        /// </summary>
        public unsafe float CrouchHeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: PathColor
        /// </summary>
        public unsafe byte PathColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }
}
