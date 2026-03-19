#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Pylon<br/>
/// (size = 0)
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_IEditorLinkSelectionInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavigationHandle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_IInterface_NavigationHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// StructProperty: NavMeshPtr
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NavMeshPtr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// StructProperty: ObstacleMesh
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ObstacleMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// StructProperty: DynamicObstacleMesh
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DynamicObstacleMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// StructProperty: WorkingSetPtr
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WorkingSetPtr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StructProperty: PathObjectsThatAffectThisPylon
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PathObjectsThatAffectThisPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ArrayProperty: NextPassSeedList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>>>>>> NextPassSeedList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>>>>>>>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// StructProperty: OctreeId
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OctreeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// StructProperty: OctreeIWasAddedTo
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OctreeIWasAddedTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ObjectProperty: NextPylon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NextPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ComponentProperty: BrokenSprite
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BrokenSprite
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ComponentProperty: RenderingComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RenderingComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ComponentProperty: PylonRadiusPreview
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PylonRadiusPreview
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// ArrayProperty: ExpansionVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>>>>> ExpansionVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>>>>>>(Ptr + 1068); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bUseExpansionSphereOverride
    /// </summary>
    public unsafe bool bUseExpansionSphereOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bNeedsCostCheck
    /// </summary>
    public unsafe bool bNeedsCostCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bStreetLevelCityPylon
    /// </summary>
    public unsafe bool bStreetLevelCityPylon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bAllowAutomaticConnectionToAdjacentPylons
    /// </summary>
    public unsafe bool bAllowAutomaticConnectionToAdjacentPylons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bUseUnstableSnappingStep
    /// </summary>
    public unsafe bool bUseUnstableSnappingStep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bMergePolysAfterGeneration
    /// </summary>
    public unsafe bool bMergePolysAfterGeneration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bSkipPylonIntersections
    /// </summary>
    public unsafe bool bSkipPylonIntersections
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bExcludeSameSidePolysWhenBuildingObstacleMesh
    /// </summary>
    public unsafe bool bExcludeSameSidePolysWhenBuildingObstacleMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bConformMeshToFloor
    /// </summary>
    public unsafe bool bConformMeshToFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bSplitPolys
    /// </summary>
    public unsafe bool bSplitPolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bSplitEdges
    /// </summary>
    public unsafe bool bSplitEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bPylonInHighLevelPath
    /// </summary>
    public unsafe bool bPylonInHighLevelPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bUseRecast
    /// </summary>
    public unsafe bool bUseRecast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bAllowRecastGenerator
    /// </summary>
    public unsafe bool bAllowRecastGenerator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bDrawEdgePolys
    /// </summary>
    public unsafe bool bDrawEdgePolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bDrawPolyBounds
    /// </summary>
    public unsafe bool bDrawPolyBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRenderInShowPaths
    /// </summary>
    public unsafe bool bRenderInShowPaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bDrawWalkableSurface
    /// </summary>
    public unsafe bool bDrawWalkableSurface
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bDrawObstacleSurface
    /// </summary>
    public unsafe bool bDrawObstacleSurface
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bSolidObstaclesInGame
    /// </summary>
    public unsafe bool bSolidObstaclesInGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bAboutToBeDeleted
    /// </summary>
    public unsafe bool bAboutToBeDeleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bEmbedVisibilityInfo
    /// </summary>
    public unsafe bool bEmbedVisibilityInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRecast_RespectAICanStepUpOn
    /// </summary>
    public unsafe bool bRecast_RespectAICanStepUpOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRecast_MergeFlags
    /// </summary>
    public unsafe bool bRecast_MergeFlags
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRecast_ApplyHeightSpanFilter
    /// </summary>
    public unsafe bool bRecast_ApplyHeightSpanFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRecast_FilterLowHangingWalkableObstacles
    /// </summary>
    public unsafe bool bRecast_FilterLowHangingWalkableObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRecast_FilterLedgeSpans
    /// </summary>
    public unsafe bool bRecast_FilterLedgeSpans
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRecast_FilterWalkableLowHeightSpans
    /// </summary>
    public unsafe bool bRecast_FilterWalkableLowHeightSpans
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bMoveablePylon
    /// </summary>
    public unsafe bool bMoveablePylon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bRebuildThisPylon
    /// </summary>
    public unsafe bool bRebuildThisPylon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bAddedToValidationList
    /// </summary>
    public unsafe bool bAddedToValidationList
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bBuildThisPylon
    /// </summary>
    public unsafe bool bBuildThisPylon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bForceDontBuildThisPylon
    /// </summary>
    public unsafe bool bForceDontBuildThisPylon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bDisabled
    /// </summary>
    public unsafe bool bDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bForceObstacleMeshCollision
    /// </summary>
    public unsafe bool bForceObstacleMeshCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bSkipSquareMerge
    /// </summary>
    public unsafe bool bSkipSquareMerge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bSkipConcaveMerge
    /// </summary>
    public unsafe bool bSkipConcaveMerge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bDoRawGridOnly
    /// </summary>
    public unsafe bool bDoRawGridOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bMaxVertIDLimitHit
    /// </summary>
    public unsafe bool bMaxVertIDLimitHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1096); }
    }

    /// <summary>
    /// StructProperty: ExpansionSphereCenter
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExpansionSphereCenter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ArrayProperty: ImposterPylons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>>>> ImposterPylons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>>>>>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ArrayProperty: OnBuild_DisableCollisionForThese
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>>> OnBuild_DisableCollisionForThese
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>>>>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ArrayProperty: OnBuild_EnableCollisionForThese
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>> OnBuild_EnableCollisionForThese
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>>>(Ptr + 1144); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>> VoxelFilterBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// ArrayProperty: VoxelFilterTM
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>> VoxelFilterTM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>(Ptr + 1220); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>> AdditionalSeedList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>(Ptr + 1240); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>> CrossLevelPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>(Ptr + 1264); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugPathExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// StructProperty: DebugPathStartLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugPathStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1296); }
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
