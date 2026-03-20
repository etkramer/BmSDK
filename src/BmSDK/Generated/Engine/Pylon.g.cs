#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Pylon<br/>
/// (flags = 0)
/// </summary>
public partial class Pylon : BmSDK.Engine.NavigationPoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Pylon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Pylon() { }

    /// <summary>
    /// Constructs a new Pylon
    /// </summary>
    public Pylon(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Pylon Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Pylon(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Pylon>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Pylon>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Pylon>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Pylon>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Pylon>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Pylon>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Pylon>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IEditorLinkSelectionInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IEditorLinkSelectionInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavigationHandle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavigationHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// StructProperty: NavMeshPtr
    /// </summary>
    public unsafe System.IntPtr NavMeshPtr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// StructProperty: ObstacleMesh
    /// </summary>
    public unsafe System.IntPtr ObstacleMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// StructProperty: DynamicObstacleMesh
    /// </summary>
    public unsafe System.IntPtr DynamicObstacleMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// StructProperty: WorkingSetPtr
    /// </summary>
    public unsafe System.IntPtr WorkingSetPtr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StructProperty: PathObjectsThatAffectThisPylon
    /// </summary>
    public unsafe System.IntPtr PathObjectsThatAffectThisPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ArrayProperty: NextPassSeedList
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> NextPassSeedList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// StructProperty: OctreeId
    /// </summary>
    public unsafe BmSDK.GameObject.FOctreeElementId OctreeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FOctreeElementId>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// StructProperty: OctreeIWasAddedTo
    /// </summary>
    public unsafe System.IntPtr OctreeIWasAddedTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ObjectProperty: NextPylon
    /// </summary>
    public unsafe BmSDK.Engine.Pylon NextPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ComponentProperty: BrokenSprite
    /// </summary>
    public unsafe BmSDK.Engine.SpriteComponent BrokenSprite
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpriteComponent>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ComponentProperty: RenderingComp
    /// </summary>
    public unsafe BmSDK.Engine.NavMeshRenderingComponent RenderingComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshRenderingComponent>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ComponentProperty: PylonRadiusPreview
    /// </summary>
    public unsafe BmSDK.Engine.DrawPylonRadiusComponent PylonRadiusPreview
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawPylonRadiusComponent>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// ArrayProperty: ExpansionVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Volume> ExpansionVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Volume>>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// FloatProperty: ExpansionRadius
    /// </summary>
    public unsafe float ExpansionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// FloatProperty: MaxExpansionRadius
    /// </summary>
    public unsafe float MaxExpansionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// BoolProperty: bImportedMesh
    /// </summary>
    public unsafe bool bImportedMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bUseExpansionSphereOverride
    /// </summary>
    public unsafe bool bUseExpansionSphereOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bNeedsCostCheck
    /// </summary>
    public unsafe bool bNeedsCostCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bStreetLevelCityPylon
    /// </summary>
    public unsafe bool bStreetLevelCityPylon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bAllowAutomaticConnectionToAdjacentPylons
    /// </summary>
    public unsafe bool bAllowAutomaticConnectionToAdjacentPylons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bUseUnstableSnappingStep
    /// </summary>
    public unsafe bool bUseUnstableSnappingStep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bMergePolysAfterGeneration
    /// </summary>
    public unsafe bool bMergePolysAfterGeneration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bSkipPylonIntersections
    /// </summary>
    public unsafe bool bSkipPylonIntersections
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bExcludeSameSidePolysWhenBuildingObstacleMesh
    /// </summary>
    public unsafe bool bExcludeSameSidePolysWhenBuildingObstacleMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bConformMeshToFloor
    /// </summary>
    public unsafe bool bConformMeshToFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bSplitPolys
    /// </summary>
    public unsafe bool bSplitPolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bSplitEdges
    /// </summary>
    public unsafe bool bSplitEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bPylonInHighLevelPath
    /// </summary>
    public unsafe bool bPylonInHighLevelPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bUseRecast
    /// </summary>
    public unsafe bool bUseRecast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bAllowRecastGenerator
    /// </summary>
    public unsafe bool bAllowRecastGenerator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bDrawEdgePolys
    /// </summary>
    public unsafe bool bDrawEdgePolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bDrawPolyBounds
    /// </summary>
    public unsafe bool bDrawPolyBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRenderInShowPaths
    /// </summary>
    public unsafe bool bRenderInShowPaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bDrawWalkableSurface
    /// </summary>
    public unsafe bool bDrawWalkableSurface
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bDrawObstacleSurface
    /// </summary>
    public unsafe bool bDrawObstacleSurface
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bSolidObstaclesInGame
    /// </summary>
    public unsafe bool bSolidObstaclesInGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bAboutToBeDeleted
    /// </summary>
    public unsafe bool bAboutToBeDeleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bEmbedVisibilityInfo
    /// </summary>
    public unsafe bool bEmbedVisibilityInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRecast_RespectAICanStepUpOn
    /// </summary>
    public unsafe bool bRecast_RespectAICanStepUpOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRecast_MergeFlags
    /// </summary>
    public unsafe bool bRecast_MergeFlags
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRecast_ApplyHeightSpanFilter
    /// </summary>
    public unsafe bool bRecast_ApplyHeightSpanFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRecast_FilterLowHangingWalkableObstacles
    /// </summary>
    public unsafe bool bRecast_FilterLowHangingWalkableObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRecast_FilterLedgeSpans
    /// </summary>
    public unsafe bool bRecast_FilterLedgeSpans
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRecast_FilterWalkableLowHeightSpans
    /// </summary>
    public unsafe bool bRecast_FilterWalkableLowHeightSpans
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bMoveablePylon
    /// </summary>
    public unsafe bool bMoveablePylon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRebuildThisPylon
    /// </summary>
    public unsafe bool bRebuildThisPylon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bAddedToValidationList
    /// </summary>
    public unsafe bool bAddedToValidationList
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bBuildThisPylon
    /// </summary>
    public unsafe bool bBuildThisPylon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bForceDontBuildThisPylon
    /// </summary>
    public unsafe bool bForceDontBuildThisPylon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bDisabled
    /// </summary>
    public unsafe bool bDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bForceObstacleMeshCollision
    /// </summary>
    public unsafe bool bForceObstacleMeshCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bSkipSquareMerge
    /// </summary>
    public unsafe bool bSkipSquareMerge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bSkipConcaveMerge
    /// </summary>
    public unsafe bool bSkipConcaveMerge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bDoRawGridOnly
    /// </summary>
    public unsafe bool bDoRawGridOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bMaxVertIDLimitHit
    /// </summary>
    public unsafe bool bMaxVertIDLimitHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// StructProperty: ExpansionSphereCenter
    /// </summary>
    public unsafe System.Numerics.Vector3 ExpansionSphereCenter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ArrayProperty: ImposterPylons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pylon> ImposterPylons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pylon>>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ArrayProperty: OnBuild_DisableCollisionForThese
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> OnBuild_DisableCollisionForThese
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ArrayProperty: OnBuild_EnableCollisionForThese
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> OnBuild_EnableCollisionForThese
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// FloatProperty: MaxPolyHeight_Optional
    /// </summary>
    public unsafe float MaxPolyHeight_Optional
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// FloatProperty: AdjoiningPylonFillerDepth
    /// </summary>
    public unsafe float AdjoiningPylonFillerDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: ExcludePolyMinWidth
    /// </summary>
    public unsafe float ExcludePolyMinWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// FloatProperty: ObstacleMeshEdgeDelta
    /// </summary>
    public unsafe float ObstacleMeshEdgeDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// FloatProperty: ObstacleMeshEdgeDeltaZ
    /// </summary>
    public unsafe float ObstacleMeshEdgeDeltaZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// FloatProperty: MaxMeshHeightDeviationAllowed
    /// </summary>
    public unsafe float MaxMeshHeightDeviationAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// FloatProperty: CheckAmountUp
    /// </summary>
    public unsafe float CheckAmountUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// FloatProperty: CheckAmountDown
    /// </summary>
    public unsafe float CheckAmountDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// FloatProperty: MinEdgeLengthToSplit
    /// </summary>
    public unsafe float MinEdgeLengthToSplit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: MinPolyWidthToSplit
    /// </summary>
    public unsafe float MinPolyWidthToSplit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// ByteProperty: NavMeshGenerator
    /// </summary>
    public unsafe byte NavMeshGenerator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ArrayProperty: VoxelFilterBounds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.KMeshProps.FKAggregateGeom> VoxelFilterBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.KMeshProps.FKAggregateGeom>>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// ArrayProperty: VoxelFilterTM
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FMatrix> VoxelFilterTM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FMatrix>>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// IntProperty: DebugEdgeCount
    /// </summary>
    public unsafe int DebugEdgeCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalSeedList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> AdditionalSeedList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// IntProperty: PylonCellSize
    /// </summary>
    public unsafe int PylonCellSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// IntProperty: PylonCellHeight
    /// </summary>
    public unsafe int PylonCellHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// ArrayProperty: CrossLevelPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pawn> CrossLevelPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pawn>>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// IntProperty: NavMeshBuildID
    /// </summary>
    public unsafe int NavMeshBuildID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// StructProperty: DebugPathExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 DebugPathExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// StructProperty: DebugPathStartLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 DebugPathStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// FloatProperty: MaxGroundCheckSize
    /// </summary>
    public unsafe float MaxGroundCheckSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// IntProperty: MaxSubdivisions
    /// </summary>
    public unsafe int MaxSubdivisions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }
}
