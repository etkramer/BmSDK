#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIManager<br/>
/// (flags = 0)
/// </summary>
public partial class RBMAIManager : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMAIManager() { }

    /// <summary>
    /// Constructs a new RBMAIManager
    /// </summary>
    public RBMAIManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMAIManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIManager>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Game
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo Game
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: BroadcastPlayerToSnipersActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor BroadcastPlayerToSnipersActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: JokerHallucinationCombatController
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerHallucinationCombatController JokerHallucinationCombatController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerHallucinationCombatController>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: MilitiaChatter
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDef MilitiaChatter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDef>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: GangChatter
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDef GangChatter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDef>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: BarkPillarData
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkPillarLookup BarkPillarData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkPillarLookup>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: PillarState
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkFlagBase PillarState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ArrayProperty: GlobalControllerInfoList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FControllerInfo> GlobalControllerInfoList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FControllerInfo>>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ArrayProperty: ActiveAIPawnList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> ActiveAIPawnList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// IntProperty: MaxPathNodesSeenPerCheck
    /// </summary>
    public unsafe int MaxPathNodesSeenPerCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenSuccessfulChecks
    /// </summary>
    public unsafe float MinTimeBetweenSuccessfulChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceBark
    /// </summary>
    public unsafe float TimeSinceBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// IntProperty: CurrentControllerIndex
    /// </summary>
    public unsafe int CurrentControllerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// IntProperty: AIUpdatesPerFrame
    /// </summary>
    public unsafe int AIUpdatesPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// BoolProperty: bCombatEnabled
    /// </summary>
    public unsafe bool bCombatEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPauseOnNextSighting
    /// </summary>
    public unsafe bool bPauseOnNextSighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bSetPieceTeleport
    /// </summary>
    public unsafe bool bSetPieceTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bAIFallIntoWater
    /// </summary>
    public unsafe bool bAIFallIntoWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bDisableAIFallingCheck
    /// </summary>
    public unsafe bool bDisableAIFallingCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bCanBatclawThroughNavMesh
    /// </summary>
    public unsafe bool bCanBatclawThroughNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bScanMode
    /// </summary>
    public unsafe bool bScanMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPredatorPartial
    /// </summary>
    public unsafe bool bPredatorPartial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPredatorActive
    /// </summary>
    public unsafe bool bPredatorActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPredAllDownOrLockedUp
    /// </summary>
    public unsafe bool bPredAllDownOrLockedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bSuppressFinaleCam
    /// </summary>
    public unsafe bool bSuppressFinaleCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPawnSpawnedThisFrame
    /// </summary>
    public unsafe bool bPawnSpawnedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bUpdateNavigationObstacles
    /// </summary>
    public unsafe bool bUpdateNavigationObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bForceUpdateNavigationObstacles
    /// </summary>
    public unsafe bool bForceUpdateNavigationObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPillarStateDirty
    /// </summary>
    public unsafe bool bPillarStateDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bShouldLoadPredVolBarks_Militia
    /// </summary>
    public unsafe bool bShouldLoadPredVolBarks_Militia
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bShouldLoadPredVolBarks_Gang
    /// </summary>
    public unsafe bool bShouldLoadPredVolBarks_Gang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bNavMeshJobInProgress
    /// </summary>
    public unsafe bool bNavMeshJobInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bPylonLoaded
    /// </summary>
    public unsafe bool bPylonLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bQueuedUnZoomPawns
    /// </summary>
    public unsafe bool bQueuedUnZoomPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// IntProperty: ManDownPerimeterCap
    /// </summary>
    public unsafe int ManDownPerimeterCap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: SmashNoiseRadius_Close
    /// </summary>
    public unsafe float SmashNoiseRadius_Close
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ArrayProperty: PawnSpawnerControllers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnSpawnerController> PawnSpawnerControllers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnSpawnerController>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// IntProperty: CurrPathNodeSeenUpdater
    /// </summary>
    public unsafe int CurrPathNodeSeenUpdater
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// IntProperty: StoredSeenVal
    /// </summary>
    public unsafe int StoredSeenVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// IntProperty: LastSetSeenVal
    /// </summary>
    public unsafe int LastSetSeenVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: LastRocketTime
    /// </summary>
    public unsafe float LastRocketTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ArrayProperty: ThugsPreventingRocketFire
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsPreventingRocketFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: PHFOV
    /// </summary>
    public unsafe float PHFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: PVFOV
    /// </summary>
    public unsafe float PVFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: FocusViewDist
    /// </summary>
    public unsafe float FocusViewDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// FloatProperty: PeriViewDist
    /// </summary>
    public unsafe float PeriViewDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// FloatProperty: ExtViewDist
    /// </summary>
    public unsafe float ExtViewDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: LastSearchSpecialTime
    /// </summary>
    public unsafe float LastSearchSpecialTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// IntProperty: CurrWorldAvoidanceUpdate
    /// </summary>
    public unsafe int CurrWorldAvoidanceUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// IntProperty: WorldAvoidanceUpdateGroups
    /// </summary>
    public unsafe int WorldAvoidanceUpdateGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// IntProperty: NextAvoidanceUpdate
    /// </summary>
    public unsafe int NextAvoidanceUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// IntProperty: PriorityAvoidanceCounter
    /// </summary>
    public unsafe int PriorityAvoidanceCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// IntProperty: CurrCombatCollisionUpdate
    /// </summary>
    public unsafe int CurrCombatCollisionUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// IntProperty: CombatCollisionUpdateGroups
    /// </summary>
    public unsafe int CombatCollisionUpdateGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// IntProperty: CurrNavMeshCollisionFloorCheckUpdate
    /// </summary>
    public unsafe int CurrNavMeshCollisionFloorCheckUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// IntProperty: NavMeshCollisionFloorCheckUpdateGroups
    /// </summary>
    public unsafe int NavMeshCollisionFloorCheckUpdateGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// IntProperty: CurrIdleConfigLOSCheckUpdate
    /// </summary>
    public unsafe int CurrIdleConfigLOSCheckUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// IntProperty: IdleConfigLOSCheckUpdateGroups
    /// </summary>
    public unsafe int IdleConfigLOSCheckUpdateGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// StrProperty: PredPartialFlagName
    /// </summary>
    public unsafe BmSDK.FString PredPartialFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StrProperty: PredActiveFlagName
    /// </summary>
    public unsafe BmSDK.FString PredActiveFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// StrProperty: PredAllDownOrLockedUpFlagName
    /// </summary>
    public unsafe BmSDK.FString PredAllDownOrLockedUpFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// IntProperty: FiringCount
    /// </summary>
    public unsafe int FiringCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// FloatProperty: PathLookPitchScale_Up
    /// </summary>
    public unsafe float PathLookPitchScale_Up
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: PathLookPitchScale_Down
    /// </summary>
    public unsafe float PathLookPitchScale_Down
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ArrayProperty: PredatorGunLockers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPredatorGunLockerBase> PredatorGunLockers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPredatorGunLockerBase>>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: PredatorSpecialMovePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPredatorSpecialMovePointBase> PredatorSpecialMovePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPredatorSpecialMovePointBase>>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ArrayProperty: PredDifficulty
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FPredatorDifficultyLevelDefine> PredDifficulty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FPredatorDifficultyLevelDefine>>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ArrayProperty: PredFiringCountDamageMultiplier
    /// </summary>
    public unsafe BmSDK.TArray<float> PredFiringCountDamageMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ArrayProperty: ActiveSnipers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> ActiveSnipers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ArrayProperty: PawnSpawnerTimeoutInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FPawnSpawnerTimeout> PawnSpawnerTimeoutInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FPawnSpawnerTimeout>>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ArrayProperty: BatmanCloseCheckBehaviours
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig> BatmanCloseCheckBehaviours
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBM2Behaviour_IdleConfig>>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// ArrayProperty: PendingNavMeshObstacleOperations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FNavMeshObstacleOperation> PendingNavMeshObstacleOperations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FNavMeshObstacleOperation>>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ArrayProperty: takedownCountVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTakedownCountVolume> takedownCountVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTakedownCountVolume>>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ArrayProperty: lootSources
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootSourceBase> lootSources
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootSourceBase>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: lootDestinations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootDestinationBase> lootDestinations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootDestinationBase>>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ArrayProperty: deadThugCounters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_DeadThugOnscreenCounter> deadThugCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_DeadThugOnscreenCounter>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ArrayProperty: destructibleWallsWaitingToRegisterWithNavMesh
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDestructibleProp_FractureWall> destructibleWallsWaitingToRegisterWithNavMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDestructibleProp_FractureWall>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ArrayProperty: DialogueLocationVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDialogueLocationVolume> DialogueLocationVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDialogueLocationVolume>>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: FramesUntilNextPawnSpawn
    /// </summary>
    public unsafe int FramesUntilNextPawnSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ArrayProperty: ScriptedSpawners
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> ScriptedSpawners
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// IntProperty: SpawnsThisFrame
    /// </summary>
    public unsafe int SpawnsThisFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// IntProperty: CurrShockedIdleID
    /// </summary>
    public unsafe int CurrShockedIdleID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// IntProperty: CurrRainMaterialUpdate
    /// </summary>
    public unsafe int CurrRainMaterialUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ByteProperty: NavMeshObstacleQueueType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIManager.ENavMeshObstacleQueueType NavMeshObstacleQueueType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIManager.ENavMeshObstacleQueueType>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredNavMeshObstacleActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FStoredNavMeshObstacle> RegisteredNavMeshObstacleActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FStoredNavMeshObstacle>>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// IntProperty: iNextSpawnedThugUniqueIdentifier
    /// </summary>
    public unsafe int iNextSpawnedThugUniqueIdentifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// ArrayProperty: StasisDestroyPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FStasisPawnDestroyInfo> StasisDestroyPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FStasisPawnDestroyInfo>>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ArrayProperty: StasisTeleportPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FStasisPawnTeleportInfo> StasisTeleportPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIManager.FStasisPawnTeleportInfo>>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ArrayProperty: RebuildSpecialEdgeActorList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> RebuildSpecialEdgeActorList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// ArrayProperty: PreviousFramePawnNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PreviousFramePawnNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// ArrayProperty: BarkData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkCharacterDefInstance> BarkData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkCharacterDefInstance>>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// ArrayProperty: ActiveChasePoints
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ActiveChasePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ArrayProperty: CornerPointsToRegister
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCornerPointBase> CornerPointsToRegister
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCornerPointBase>>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// ArrayProperty: LLDAIToRegister
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLedgeLookDangerAreaInfo> LLDAIToRegister
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLedgeLookDangerAreaInfo>>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// ArrayProperty: DisableDivingVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDisableAIDivingAwayFromVehiclesVolume> DisableDivingVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDisableAIDivingAwayFromVehiclesVolume>>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// ArrayProperty: PropsToUpdate
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDestructibleProp> PropsToUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDestructibleProp>>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// ArrayProperty: BlockadesToUpdate
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCheckpointBlockadeBase> BlockadesToUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCheckpointBlockadeBase>>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// ArrayProperty: ObstaclesToUpdate
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavMeshObstacle_Queue> ObstaclesToUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavMeshObstacle_Queue>>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// StructProperty: CachedBmblNavLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 CachedBmblNavLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// ArrayProperty: CachedBmblNavShape
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> CachedBmblNavShape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }
}
