#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameInfo<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGameInfo : BmSDK.BmGame.RGameInfoBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGameInfo() { }

    /// <summary>
    /// Constructs a new RGameInfo
    /// </summary>
    public RGameInfo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGameInfo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameInfo(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: GameplayEventsWriter
    /// </summary>
    public unsafe BmSDK.BmGame.RGameplayEventsHydra GameplayEventsWriter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameplayEventsHydra>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// ObjectProperty: LightningEventListener
    /// </summary>
    public unsafe BmSDK.BmGame.RLightningActor LightningEventListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLightningActor>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// ObjectProperty: MapControllerEventListener
    /// </summary>
    public unsafe BmSDK.BmGame.RMapController MapControllerEventListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMapController>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// ObjectProperty: ContentBeaconPanel
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI_ContentBeaconPanel ContentBeaconPanel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI_ContentBeaconPanel>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// ObjectProperty: ContentBeaconMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie ContentBeaconMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// ObjectProperty: AIManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIManager AIManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIManager>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// ObjectProperty: PopulationManager
    /// </summary>
    public unsafe BmSDK.BmGame.RPopulationManager PopulationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPopulationManager>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }

    /// <summary>
    /// ObjectProperty: CombatManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager CombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// ObjectProperty: CrowdManager
    /// </summary>
    public unsafe BmSDK.BmGame.RCrowdManager CrowdManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCrowdManager>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// ObjectProperty: CombatBarkCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBarkCoordinator CombatBarkCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBarkCoordinator>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }

    /// <summary>
    /// ObjectProperty: AkBeacon
    /// </summary>
    public unsafe BmSDK.BmGame.AkAudioBeacon AkBeacon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.AkAudioBeacon>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// ObjectProperty: GunShotManager
    /// </summary>
    public unsafe BmSDK.BmGame.RGunShotManager GunShotManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGunShotManager>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// ObjectProperty: VehicleCombatManager
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleCombatManager VehicleCombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleCombatManager>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// ObjectProperty: DroneCommanderTannoy
    /// </summary>
    public unsafe BmSDK.BmGame.RDroneCommanderTannoy DroneCommanderTannoy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDroneCommanderTannoy>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }

    /// <summary>
    /// ObjectProperty: CachedPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerControllerCombat CachedPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerControllerCombat>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// ObjectProperty: Batmobile
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// ObjectProperty: DeadBatmobile
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle DeadBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }

    /// <summary>
    /// ObjectProperty: HighestPriorityNonCustomObjectivePointer
    /// </summary>
    public unsafe BmSDK.BmGame.RObjectiveMarker HighestPriorityNonCustomObjectivePointer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RObjectiveMarker>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// ObjectProperty: ActiveTakeoverVideoScreensAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_TakeoverVideoScreens ActiveTakeoverVideoScreensAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_TakeoverVideoScreens>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// ObjectProperty: temporaryLightningSwappedActor
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerSwappableBase temporaryLightningSwappedActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerSwappableBase>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// ObjectProperty: VehicleRoundRobin
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle VehicleRoundRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// ObjectProperty: DeadVehicleRoundRobin
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle DeadVehicleRoundRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// ObjectProperty: PatrolGunDefaultAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PatrolGunDefaultAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// ObjectProperty: PatrolGunUpAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PatrolGunUpAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// ObjectProperty: ManDownPeekAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager ManDownPeekAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// ObjectProperty: GuardPointAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager GuardPointAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// ObjectProperty: LastStandAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager LastStandAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// ObjectProperty: ReloadAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager ReloadAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// ObjectProperty: TutThugAimingAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager TutThugAimingAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// ObjectProperty: PerimOutAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PerimOutAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// ObjectProperty: PlayerSwitchPawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn PlayerSwitchPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// ObjectProperty: CurrentJoker
    /// </summary>
    public unsafe BmSDK.BmGame.RPawn CurrentJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ObjectProperty: JokerFrequencyController
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerHallucinationFrequencyController JokerFrequencyController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerHallucinationFrequencyController>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// ObjectProperty: CurrentManbat
    /// </summary>
    public unsafe BmSDK.BmGame.RPawn CurrentManbat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// ObjectProperty: ManbatController
    /// </summary>
    public unsafe BmSDK.BmGame.RManBatAppearanceController ManbatController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RManBatAppearanceController>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: DoubleTeamAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_ToggleRobinLieutenantAssist DoubleTeamAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_ToggleRobinLieutenantAssist>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ObjectProperty: VideoScreenTakeoverMaterialToInstance
    /// </summary>
    public unsafe BmSDK.Engine.Material VideoScreenTakeoverMaterialToInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// ObjectProperty: VideoScreenOverrideMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant VideoScreenOverrideMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ObjectProperty: TriggerVolumeList
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass TriggerVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// ComponentProperty: CurrentRoomAIState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState CurrentRoomAIState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// StrProperty: FadeDownBy
    /// </summary>
    public unsafe BmSDK.FString FadeDownBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// StrProperty: AudioFadeDownBy
    /// </summary>
    public unsafe BmSDK.FString AudioFadeDownBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// ArrayProperty: DefaultBatmanKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap> DefaultBatmanKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap>>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// ArrayProperty: DefaultPursuitKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap> DefaultPursuitKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap>>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// ArrayProperty: DefaultBattleKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap> DefaultBattleKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap>>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// ArrayProperty: DebugLevelStarts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelStartDefinition> DebugLevelStarts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelStartDefinition>>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerInterrogationTracks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RiddlerInterrogationTracks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// StrProperty: RiddlerInterrogationTrackIntro
    /// </summary>
    public unsafe BmSDK.FString RiddlerInterrogationTrackIntro
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }

    /// <summary>
    /// StrProperty: RiddlerInterrogationTrackDemo
    /// </summary>
    public unsafe BmSDK.FString RiddlerInterrogationTrackDemo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerInterrogationTrackFightBack
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RiddlerInterrogationTrackFightBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// ArrayProperty: NumRiddlersX
    /// </summary>
    public unsafe BmSDK.TArray<int> NumRiddlersX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// ArrayProperty: NumRiddlersY
    /// </summary>
    public unsafe BmSDK.TArray<int> NumRiddlersY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// ArrayProperty: NumRiddlersZ
    /// </summary>
    public unsafe BmSDK.TArray<int> NumRiddlersZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// ArrayProperty: LevelTransitionOffsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelTransitionOffset> LevelTransitionOffsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelTransitionOffset>>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// ArrayProperty: HelicopterPointsOfInterest
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FHelicopterPointOfInterest> HelicopterPointsOfInterest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FHelicopterPointOfInterest>>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// ArrayProperty: checkPointMines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCheckPointMineBase> checkPointMines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCheckPointMineBase>>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// ArrayProperty: commandBeacons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCommandBeaconBase> commandBeacons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCommandBeaconBase>>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// ArrayProperty: AllThugScarableCrows
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCrowsBase> AllThugScarableCrows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCrowsBase>>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// IntProperty: CrowTimeSliceIndex
    /// </summary>
    public unsafe int CrowTimeSliceIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// ArrayProperty: AllPathElevationCheckingActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIAction_BaseMove> AllPathElevationCheckingActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIAction_BaseMove>>(Ptr + 2524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2524); }
    }

    /// <summary>
    /// IntProperty: PathElevationCheck_TimeSliceIndex
    /// </summary>
    public unsafe int PathElevationCheck_TimeSliceIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// ArrayProperty: UnregisteredLockInVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLockinVolume> UnregisteredLockInVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLockinVolume>>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// ArrayProperty: UnregisteredPredTannoyList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerTannoy> UnregisteredPredTannoyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerTannoy>>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// ArrayProperty: UnregisteredFractureWallList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDestructibleProp_FractureWall> UnregisteredFractureWallList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDestructibleProp_FractureWall>>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// StrProperty: acquiredBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString acquiredBMBLUpgradeFlagNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }
    /// <summary>
    /// StrProperty: acquiredBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString acquiredBMBLUpgradeFlagNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }
    /// <summary>
    /// StrProperty: acquiredBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString acquiredBMBLUpgradeFlagNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }
    /// <summary>
    /// StrProperty: acquiredBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString acquiredBMBLUpgradeFlagNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// StrProperty: unavailableBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString unavailableBMBLUpgradeFlagNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }
    /// <summary>
    /// StrProperty: unavailableBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString unavailableBMBLUpgradeFlagNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }
    /// <summary>
    /// StrProperty: unavailableBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString unavailableBMBLUpgradeFlagNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }
    /// <summary>
    /// StrProperty: unavailableBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString unavailableBMBLUpgradeFlagNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// StrProperty: nextBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString nextBMBLUpgradeFlagNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }
    /// <summary>
    /// StrProperty: nextBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString nextBMBLUpgradeFlagNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }
    /// <summary>
    /// StrProperty: nextBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString nextBMBLUpgradeFlagNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }
    /// <summary>
    /// StrProperty: nextBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString nextBMBLUpgradeFlagNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// BoolProperty: bDbgJokerBillboards
    /// </summary>
    public unsafe bool bDbgJokerBillboards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bJokerBillboardQAMode
    /// </summary>
    public unsafe bool bJokerBillboardQAMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bFireflyActive
    /// </summary>
    public unsafe bool bFireflyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ShowcaseItemsSorted
    /// </summary>
    public unsafe bool ShowcaseItemsSorted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: m_bUpgradeHierarchyBuilt
    /// </summary>
    public unsafe bool m_bUpgradeHierarchyBuilt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bSavedSecretsLeftToReveal
    /// </summary>
    public unsafe bool bSavedSecretsLeftToReveal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: PositionBeaconBestInteractable
    /// </summary>
    public unsafe bool PositionBeaconBestInteractable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ContentBeaconRequiresExitArea
    /// </summary>
    public unsafe bool ContentBeaconRequiresExitArea
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ContentBeaconHydraQueryInitiated
    /// </summary>
    public unsafe bool ContentBeaconHydraQueryInitiated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bShowingBatmobileOnHud
    /// </summary>
    public unsafe bool bShowingBatmobileOnHud
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bPlayerControllingBatmobile
    /// </summary>
    public unsafe bool bPlayerControllingBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bPlayerControllingBatmobileAndMovingFast
    /// </summary>
    public unsafe bool bPlayerControllingBatmobileAndMovingFast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bHead2Head
    /// </summary>
    public unsafe bool bHead2Head
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bStoryDLC
    /// </summary>
    public unsafe bool bStoryDLC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bSavingStartPoints
    /// </summary>
    public unsafe bool bSavingStartPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bDemoBuild
    /// </summary>
    public unsafe bool bDemoBuild
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bDisableDebug
    /// </summary>
    public unsafe bool bDisableDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bShowChaseStartPos
    /// </summary>
    public unsafe bool bShowChaseStartPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bLevelDisabledLightningStrikes
    /// </summary>
    public unsafe bool bLevelDisabledLightningStrikes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ObjectiveSystemSuppressed
    /// </summary>
    public unsafe bool ObjectiveSystemSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bNoGadgets
    /// </summary>
    public unsafe bool bNoGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bSilentTakeDownOnly
    /// </summary>
    public unsafe bool bSilentTakeDownOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bNoGrapple
    /// </summary>
    public unsafe bool bNoGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bNoInvestigateMode
    /// </summary>
    public unsafe bool bNoInvestigateMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bUseLowLineLauncherHeight
    /// </summary>
    public unsafe bool bUseLowLineLauncherHeight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: LevelLoadedAndReady
    /// </summary>
    public unsafe bool LevelLoadedAndReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bSuspendAllDeadGameOverOLD
    /// </summary>
    public unsafe bool bSuspendAllDeadGameOverOLD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bDoCombatGrapnelToVpointArriveCheck
    /// </summary>
    public unsafe bool bDoCombatGrapnelToVpointArriveCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ParticlePushBMAffectBaseVel
    /// </summary>
    public unsafe bool ParticlePushBMAffectBaseVel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ParticlePushBMBLAffectBaseVel
    /// </summary>
    public unsafe bool ParticlePushBMBLAffectBaseVel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ChallengeMapListSorted
    /// </summary>
    public unsafe bool ChallengeMapListSorted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bSplitscreenCaptureMode
    /// </summary>
    public unsafe bool bSplitscreenCaptureMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bPreventPauseOnControllerRemoval
    /// </summary>
    public unsafe bool bPreventPauseOnControllerRemoval
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: SavedOWDTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedOWDTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: SavedMuseumTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedMuseumTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: SavedUnderTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedUnderTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bDualPlayPredatorActive
    /// </summary>
    public unsafe bool bDualPlayPredatorActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bSuppressDualPlayMoves
    /// </summary>
    public unsafe bool bSuppressDualPlayMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bDualPlayerSwitchingDisabled
    /// </summary>
    public unsafe bool bDualPlayerSwitchingDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bDualPlayerSwitchingDisabledBySeq
    /// </summary>
    public unsafe bool bDualPlayerSwitchingDisabledBySeq
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bManbatCurrentlyActive
    /// </summary>
    public unsafe bool bManbatCurrentlyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bHasWarnedAboutInvalidRiotLinkPoints
    /// </summary>
    public unsafe bool bHasWarnedAboutInvalidRiotLinkPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bInsideRadioModeConversationStartSpeechCall
    /// </summary>
    public unsafe bool bInsideRadioModeConversationStartSpeechCall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bHasSetFrontEndChallenge
    /// </summary>
    public unsafe bool bHasSetFrontEndChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bIsFrontEndChallenge
    /// </summary>
    public unsafe bool bIsFrontEndChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: StoreContentQueryInitiated
    /// </summary>
    public unsafe bool StoreContentQueryInitiated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: StoreContentQueryCompleted
    /// </summary>
    public unsafe bool StoreContentQueryCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: StoreContentQuerySuccessful
    /// </summary>
    public unsafe bool StoreContentQuerySuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: StoreContentQueryDebug
    /// </summary>
    public unsafe bool StoreContentQueryDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bMinMemChecked
    /// </summary>
    public unsafe bool bMinMemChecked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bMinVideoDriverChecked
    /// </summary>
    public unsafe bool bMinVideoDriverChecked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bExternallyModifiedInisChecked
    /// </summary>
    public unsafe bool bExternallyModifiedInisChecked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bCachedFailsafeSeenSeqEvents
    /// </summary>
    public unsafe bool bCachedFailsafeSeenSeqEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// ArrayProperty: lootPointsWaitingForBeginPlay
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootPointBase> lootPointsWaitingForBeginPlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootPointBase>>(Ptr + 2792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2792); }
    }

    /// <summary>
    /// ArrayProperty: gratesWaitingForBeginPlay
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase> gratesWaitingForBeginPlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase>>(Ptr + 2808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2808); }
    }

    /// <summary>
    /// ArrayProperty: sentryGunsWaitingForBeginPlay
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSentryGunBase> sentryGunsWaitingForBeginPlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSentryGunBase>>(Ptr + 2824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }
    }

    /// <summary>
    /// ArrayProperty: ConceptItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FConceptItem> ConceptItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FConceptItem>>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }

    /// <summary>
    /// ArrayProperty: ShowcaseCameras
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FShowcaseCamera> ShowcaseCameras
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FShowcaseCamera>>(Ptr + 2856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2856); }
    }

    /// <summary>
    /// ArrayProperty: ShowcaseItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FShowcaseItem> ShowcaseItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FShowcaseItem>>(Ptr + 2872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2872); }
    }

    /// <summary>
    /// IntProperty: ShowcaseItemsLength
    /// </summary>
    public unsafe int ShowcaseItemsLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2888); }
    }

    /// <summary>
    /// ArrayProperty: UpgradeHeaders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FUpgradeHeader> UpgradeHeaders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FUpgradeHeader>>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }

    /// <summary>
    /// ArrayProperty: UpgradeItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FUpgradeItem> UpgradeItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FUpgradeItem>>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }

    /// <summary>
    /// ArrayProperty: UpgradeBoosters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> UpgradeBoosters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// ArrayProperty: BAMRewards
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FWBPlayRewardInfo> BAMRewards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FWBPlayRewardInfo>>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }

    /// <summary>
    /// ArrayProperty: BAKRewards
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FWBPlayRewardInfo> BAKRewards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FWBPlayRewardInfo>>(Ptr + 2956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2956); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerPuzzles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FRiddlerPuzzle> RiddlerPuzzles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FRiddlerPuzzle>>(Ptr + 2972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2972); }
    }

    /// <summary>
    /// IntProperty: RiddlerPuzzleLastModified
    /// </summary>
    public unsafe int RiddlerPuzzleLastModified
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2988); }
    }

    /// <summary>
    /// IntProperty: RiddlerPuzzlePieceLastModified
    /// </summary>
    public unsafe int RiddlerPuzzlePieceLastModified
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2992); }
    }

    /// <summary>
    /// IntProperty: RiddlerPuzzleCachedTotal
    /// </summary>
    public unsafe int RiddlerPuzzleCachedTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2996); }
    }

    /// <summary>
    /// IntProperty: SavedPickupReveals
    /// </summary>
    public unsafe int SavedPickupReveals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3000); }
    }

    /// <summary>
    /// ArrayProperty: PositionBeacons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FPositionBeaconData> PositionBeacons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FPositionBeaconData>>(Ptr + 3004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3004); }
    }

    /// <summary>
    /// StructProperty: PositionBeaconCachedPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 PositionBeaconCachedPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3020); }
    }

    /// <summary>
    /// StructProperty: PositionBeaconCachedDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 PositionBeaconCachedDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3032); }
    }

    /// <summary>
    /// StrProperty: PositionBeaconBestType
    /// </summary>
    public unsafe BmSDK.FString PositionBeaconBestType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3044); }
    }

    /// <summary>
    /// StructProperty: PositionBeaconBestPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 PositionBeaconBestPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3060); }
    }

    /// <summary>
    /// IntProperty: PositionBeaconBestId
    /// </summary>
    public unsafe int PositionBeaconBestId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3072); }
    }

    /// <summary>
    /// ArrayProperty: ContentBeacons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FContentBeacon> ContentBeacons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FContentBeacon>>(Ptr + 3076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3076); }
    }

    /// <summary>
    /// ByteProperty: ContentBeaconCurrentDisplayMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EContentBeaconDisplayMode ContentBeaconCurrentDisplayMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EContentBeaconDisplayMode>(Ptr + 3092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3092); }
    }

    /// <summary>
    /// ByteProperty: GameMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameModes GameMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameModes>(Ptr + 3093); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3093); }
    }

    /// <summary>
    /// ByteProperty: StasisLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStasisLevel StasisLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStasisLevel>(Ptr + 3094); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3094); }
    }

    /// <summary>
    /// IntProperty: ContentBeaconCurrentIndex
    /// </summary>
    public unsafe int ContentBeaconCurrentIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3096); }
    }

    /// <summary>
    /// ArrayProperty: GADuplicateList_Main
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GADuplicateList_Main
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 3100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3100); }
    }

    /// <summary>
    /// ArrayProperty: GADuplicateList_Dup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GADuplicateList_Dup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 3116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3116); }
    }

    /// <summary>
    /// ArrayProperty: AAITakedownMapping
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FGameActionToAAITakedownMapping> AAITakedownMapping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FGameActionToAAITakedownMapping>>(Ptr + 3132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3132); }
    }

    /// <summary>
    /// FloatProperty: sideStoryCooldownTimers
    /// </summary>
    public unsafe float sideStoryCooldownTimers_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }
    /// <summary>
    /// FloatProperty: sideStoryCooldownTimers
    /// </summary>
    public unsafe float sideStoryCooldownTimers_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3152); }
    }
    /// <summary>
    /// FloatProperty: sideStoryCooldownTimers
    /// </summary>
    public unsafe float sideStoryCooldownTimers_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3156); }
    }

    /// <summary>
    /// FloatProperty: LastUturnBarkTime
    /// </summary>
    public unsafe float LastUturnBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// IntProperty: ChallengeID
    /// </summary>
    public unsafe int ChallengeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// StrProperty: ChallengeRequiredFlags
    /// </summary>
    public unsafe BmSDK.FString ChallengeRequiredFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }

    /// <summary>
    /// StrProperty: ChallengeRequiredChapters
    /// </summary>
    public unsafe BmSDK.FString ChallengeRequiredChapters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }

    /// <summary>
    /// FloatProperty: SessionTimePlayed
    /// </summary>
    public unsafe float SessionTimePlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }

    /// <summary>
    /// FloatProperty: FootstepNoiseDist
    /// </summary>
    public unsafe float FootstepNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }

    /// <summary>
    /// FloatProperty: WalkFootstepNoiseDist
    /// </summary>
    public unsafe float WalkFootstepNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }
    }

    /// <summary>
    /// FloatProperty: TakedownNoiseDist
    /// </summary>
    public unsafe float TakedownNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3212); }
    }

    /// <summary>
    /// FloatProperty: ChaseCheatTime
    /// </summary>
    public unsafe float ChaseCheatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3216); }
    }

    /// <summary>
    /// FloatProperty: RBSmashSpeedAlertThreshold
    /// </summary>
    public unsafe float RBSmashSpeedAlertThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3220); }
    }

    /// <summary>
    /// FloatProperty: GunStartleTimer
    /// </summary>
    public unsafe float GunStartleTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3224); }
    }

    /// <summary>
    /// StructProperty: CurrentWindState
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FRWindState CurrentWindState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FRWindState>(Ptr + 3228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3228); }
    }

    /// <summary>
    /// StructProperty: CurrentWindConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FRWindConfig CurrentWindConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FRWindConfig>(Ptr + 3296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3296); }
    }

    /// <summary>
    /// FloatProperty: CurrentRainIntensity
    /// </summary>
    public unsafe float CurrentRainIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3332); }
    }

    /// <summary>
    /// ArrayProperty: ObjectiveMarkers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RObjectiveMarker> ObjectiveMarkers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RObjectiveMarker>>(Ptr + 3336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3336); }
    }

    /// <summary>
    /// IntProperty: VisibleObjectiveMarker
    /// </summary>
    public unsafe int VisibleObjectiveMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3352); }
    }

    /// <summary>
    /// IntProperty: HighestPriorityNonCustomObjectiveMarker
    /// </summary>
    public unsafe int HighestPriorityNonCustomObjectiveMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3356); }
    }

    /// <summary>
    /// ArrayProperty: RoadNetworks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadNetwork> RoadNetworks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork>>(Ptr + 3360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3360); }
    }

    /// <summary>
    /// ArrayProperty: VehicleExclusionVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleExclusionVolume> VehicleExclusionVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleExclusionVolume>>(Ptr + 3376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3376); }
    }

    /// <summary>
    /// IntProperty: VehicleExclusionVolumesModCount
    /// </summary>
    public unsafe int VehicleExclusionVolumesModCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3392); }
    }

    /// <summary>
    /// ArrayProperty: FilteredVehicleExclusionVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FFilteredVehicleExclusionVolume> FilteredVehicleExclusionVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FFilteredVehicleExclusionVolume>>(Ptr + 3396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3396); }
    }

    /// <summary>
    /// ArrayProperty: FireflyExclusionVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFireflyRoadExclusionVolume> FireflyExclusionVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFireflyRoadExclusionVolume>>(Ptr + 3412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3412); }
    }

    /// <summary>
    /// ArrayProperty: TakeoverVideoScreens
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRemoteTakeoverVideoScreenInterface> TakeoverVideoScreens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRemoteTakeoverVideoScreenInterface>>(Ptr + 3428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3428); }
    }

    /// <summary>
    /// FloatProperty: lastVideoScreenTakeoverTime
    /// </summary>
    public unsafe float lastVideoScreenTakeoverTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3444); }
    }

    /// <summary>
    /// ArrayProperty: BreakableVentLights
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBreakableVentLightBase> BreakableVentLights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBreakableVentLightBase>>(Ptr + 3448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3448); }
    }

    /// <summary>
    /// ArrayProperty: AllJokerSwappables
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerSwappableBase> AllJokerSwappables
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerSwappableBase>>(Ptr + 3464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3464); }
    }

    /// <summary>
    /// ArrayProperty: CurrentlyJokerfiedSwappables
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerSwappableBase> CurrentlyJokerfiedSwappables
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerSwappableBase>>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// FloatProperty: jokerSwappableChance_Ch3
    /// </summary>
    public unsafe float jokerSwappableChance_Ch3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3496); }
    }

    /// <summary>
    /// FloatProperty: jokerSwappableChance_Ch5
    /// </summary>
    public unsafe float jokerSwappableChance_Ch5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// FloatProperty: jokerSwappableChance_Ch7
    /// </summary>
    public unsafe float jokerSwappableChance_Ch7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }
    }

    /// <summary>
    /// FloatProperty: jokerSwappableChance_Ch9
    /// </summary>
    public unsafe float jokerSwappableChance_Ch9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3508); }
    }

    /// <summary>
    /// FloatProperty: jokerSwappableCooldownTime
    /// </summary>
    public unsafe float jokerSwappableCooldownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// FloatProperty: lastOnScreenJokerfyTime
    /// </summary>
    public unsafe float lastOnScreenJokerfyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3516); }
    }

    /// <summary>
    /// FloatProperty: onScreenJokerfy_LightningDist
    /// </summary>
    public unsafe float onScreenJokerfy_LightningDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3520); }
    }

    /// <summary>
    /// FloatProperty: onScreenJokerfy_MaxDist
    /// </summary>
    public unsafe float onScreenJokerfy_MaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3524); }
    }

    /// <summary>
    /// FloatProperty: onScreenJokerfy_MinInterval
    /// </summary>
    public unsafe float onScreenJokerfy_MinInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3528); }
    }

    /// <summary>
    /// FloatProperty: jokerMeshSwapDuration
    /// </summary>
    public unsafe float jokerMeshSwapDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3532); }
    }

    /// <summary>
    /// ArrayProperty: Vehicles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicle> Vehicles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicle>>(Ptr + 3536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3536); }
    }

    /// <summary>
    /// IntProperty: VehicleRoundRobinIndex
    /// </summary>
    public unsafe int VehicleRoundRobinIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3552); }
    }

    /// <summary>
    /// ArrayProperty: DeadVehicles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDeadVehicle> DeadVehicles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDeadVehicle>>(Ptr + 3556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3556); }
    }

    /// <summary>
    /// IntProperty: DeadVehicleRoundRobinIndex
    /// </summary>
    public unsafe int DeadVehicleRoundRobinIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3572); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileRemoteVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBatmobileRemoteVolume> BatmobileRemoteVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBatmobileRemoteVolume>>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// ArrayProperty: VehicleAntiLevelVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleAntiLevelVolume> VehicleAntiLevelVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleAntiLevelVolume>>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// ArrayProperty: ActiveSmokeScreens
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSmokeScreen> ActiveSmokeScreens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSmokeScreen>>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// ArrayProperty: PredVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPredatorVolume> PredVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPredatorVolume>>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// ArrayProperty: VehiclePassengersToSpawn
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehiclePassengerSpawnInfo> VehiclePassengersToSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehiclePassengerSpawnInfo>>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// ArrayProperty: ScenarioVehiclesToSpawn
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleScenarioSpawnInfo> ScenarioVehiclesToSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleScenarioSpawnInfo>>(Ptr + 3656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }
    }

    /// <summary>
    /// IntProperty: DeferredSpawnFrame
    /// </summary>
    public unsafe int DeferredSpawnFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3672); }
    }

    /// <summary>
    /// ArrayProperty: VehiclesToInit
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleInitInfo> VehiclesToInit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleInitInfo>>(Ptr + 3676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3676); }
    }

    /// <summary>
    /// IntProperty: DeferredVehicleInitFrame
    /// </summary>
    public unsafe int DeferredVehicleInitFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3692); }
    }

    /// <summary>
    /// ArrayProperty: LoadedAllTheTimeOnPCToSaveDVDSpace
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> LoadedAllTheTimeOnPCToSaveDVDSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// FloatProperty: PredChaseTime
    /// </summary>
    public unsafe float PredChaseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }
    }

    /// <summary>
    /// ArrayProperty: LevelTransitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelTransition> LevelTransitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelTransition>>(Ptr + 3716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3716); }
    }

    /// <summary>
    /// FloatProperty: LastExclaimTime
    /// </summary>
    public unsafe float LastExclaimTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3732); }
    }

    /// <summary>
    /// IntProperty: LastExclaimPriority
    /// </summary>
    public unsafe int LastExclaimPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3736); }
    }

    /// <summary>
    /// FloatProperty: CombatGrapnelToVPointStartTime
    /// </summary>
    public unsafe float CombatGrapnelToVPointStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3740); }
    }

    /// <summary>
    /// ArrayProperty: ActiveHelicopters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterBase> ActiveHelicopters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterBase>>(Ptr + 3744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3744); }
    }

    /// <summary>
    /// IntProperty: HelicopterTimesliceIndex
    /// </summary>
    public unsafe int HelicopterTimesliceIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3760); }
    }

    /// <summary>
    /// ArrayProperty: CurrentBatmobileForensicSideStories
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_BatmobileForensicsSideStory> CurrentBatmobileForensicSideStories
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_BatmobileForensicsSideStory>>(Ptr + 3764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3764); }
    }

    /// <summary>
    /// StructProperty: ParticlePushBMPos1Mult
    /// </summary>
    public unsafe System.Numerics.Vector3 ParticlePushBMPos1Mult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3780); }
    }

    /// <summary>
    /// StructProperty: ParticlePushBMPos2Mult
    /// </summary>
    public unsafe System.Numerics.Vector3 ParticlePushBMPos2Mult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3792); }
    }

    /// <summary>
    /// FloatProperty: ParticlePushBMMaxSpeed
    /// </summary>
    public unsafe float ParticlePushBMMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3804); }
    }

    /// <summary>
    /// FloatProperty: ParticlePushBMMaxRange
    /// </summary>
    public unsafe float ParticlePushBMMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3808); }
    }

    /// <summary>
    /// FloatProperty: ParticlePushBMMaxStrength
    /// </summary>
    public unsafe float ParticlePushBMMaxStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3812); }
    }

    /// <summary>
    /// StructProperty: ParticlePushBMBLPos1Mult
    /// </summary>
    public unsafe System.Numerics.Vector3 ParticlePushBMBLPos1Mult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3816); }
    }

    /// <summary>
    /// StructProperty: ParticlePushBMBLPos2Mult
    /// </summary>
    public unsafe System.Numerics.Vector3 ParticlePushBMBLPos2Mult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3828); }
    }

    /// <summary>
    /// FloatProperty: ParticlePushBMBLMaxSpeed
    /// </summary>
    public unsafe float ParticlePushBMBLMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }
    }

    /// <summary>
    /// FloatProperty: ParticlePushBMBLMaxRange
    /// </summary>
    public unsafe float ParticlePushBMBLMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3844); }
    }

    /// <summary>
    /// FloatProperty: ParticlePushBMBLMaxStrength
    /// </summary>
    public unsafe float ParticlePushBMBLMaxStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3848); }
    }

    /// <summary>
    /// FloatProperty: ICStasisRange
    /// </summary>
    public unsafe float ICStasisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3852); }
    }

    /// <summary>
    /// FloatProperty: FullStasisRange
    /// </summary>
    public unsafe float FullStasisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3856); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeMapList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FChallengeDesc> ChallengeMapList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FChallengeDesc>>(Ptr + 3860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3860); }
    }

    /// <summary>
    /// ArrayProperty: MostWantedSetupData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMostWantedSetup> MostWantedSetupData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMostWantedSetup>>(Ptr + 3876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3876); }
    }

    /// <summary>
    /// ArrayProperty: LevelVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelVolumeDesc> LevelVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelVolumeDesc>>(Ptr + 3892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3892); }
    }

    /// <summary>
    /// ArrayProperty: LevelVolumeBspNodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelVolumeBsp> LevelVolumeBspNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelVolumeBsp>>(Ptr + 3908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3908); }
    }

    /// <summary>
    /// ArrayProperty: LevelTransitionList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelTransitionDesc> LevelTransitionList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelTransitionDesc>>(Ptr + 3924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3924); }
    }

    /// <summary>
    /// ArrayProperty: SubMapLocList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapHackOWLoc> SubMapLocList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapHackOWLoc>>(Ptr + 3940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3940); }
    }

    /// <summary>
    /// ArrayProperty: MapElementList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElements> MapElementList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElements>>(Ptr + 3956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3956); }
    }

    /// <summary>
    /// ArrayProperty: MapElementItemList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElementsItem> MapElementItemList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElementsItem>>(Ptr + 3972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3972); }
    }

    /// <summary>
    /// ArrayProperty: StoryDLCList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FStoryDLCItem> StoryDLCList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FStoryDLCItem>>(Ptr + 3988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3988); }
    }

    /// <summary>
    /// FloatProperty: DebugForceGarbageTimer
    /// </summary>
    public unsafe float DebugForceGarbageTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4004); }
    }

    /// <summary>
    /// ArrayProperty: DLCBundlesInstalled
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DLCBundlesInstalled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 4008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4008); }
    }

    /// <summary>
    /// FloatProperty: CameraMovementSpeed
    /// </summary>
    public unsafe float CameraMovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }
    }

    /// <summary>
    /// StrProperty: deathMovieOverride
    /// </summary>
    public unsafe BmSDK.FString deathMovieOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4028); }
    }

    /// <summary>
    /// IntProperty: SavedMapIndexForSecretsLeftCheck
    /// </summary>
    public unsafe int SavedMapIndexForSecretsLeftCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// IntProperty: SavedSecretIndexForSecretsLeftCheck
    /// </summary>
    public unsafe int SavedSecretIndexForSecretsLeftCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4048); }
    }

    /// <summary>
    /// ArrayProperty: OverworldSpawnPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> OverworldSpawnPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 4052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4052); }
    }

    /// <summary>
    /// ArrayProperty: OverworldCarSpawnPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> OverworldCarSpawnPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 4068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4068); }
    }

    /// <summary>
    /// ArrayProperty: BrokenRiotingLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BrokenRiotingLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 4084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4084); }
    }

    /// <summary>
    /// ArrayProperty: objectsSettingChaseInProgress
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> objectsSettingChaseInProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// ArrayProperty: objectsSuppressingChatter
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> objectsSuppressingChatter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }

    /// <summary>
    /// StrProperty: CurrentObjectiveString
    /// </summary>
    public unsafe BmSDK.FString CurrentObjectiveString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// FloatProperty: LastCombatSuccessTime
    /// </summary>
    public unsafe float LastCombatSuccessTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// FloatProperty: lastFireflyGrenadeDamageTime
    /// </summary>
    public unsafe float lastFireflyGrenadeDamageTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// StructProperty: dialoguePlayTimes
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror dialoguePlayTimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }

    /// <summary>
    /// ArrayProperty: AllGrates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase> AllGrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase>>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// FloatProperty: IncendiaryChargeDamageTime
    /// </summary>
    public unsafe float IncendiaryChargeDamageTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4244); }
    }

    /// <summary>
    /// FloatProperty: lastBankSmokeBarkTime
    /// </summary>
    public unsafe float lastBankSmokeBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// ObjectProperty: SuspendAllDeadGameOver
    /// </summary>
    public unsafe BmSDK.GameObject SuspendAllDeadGameOver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 4252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4252); }
    }

    /// <summary>
    /// ArrayProperty: recentConversationActivationTimes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FConversationActivationTime> recentConversationActivationTimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FConversationActivationTime>>(Ptr + 4260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4260); }
    }

    /// <summary>
    /// IntProperty: NumPurchaseableUpgrades
    /// </summary>
    public unsafe int NumPurchaseableUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4276); }
    }

    /// <summary>
    /// ArrayProperty: StoreContent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent> StoreContent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent>>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// IntProperty: StoreContentQueryControllerId
    /// </summary>
    public unsafe int StoreContentQueryControllerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// DelegateProperty: StoreContentQueryCallback
    /// </summary>
    public unsafe System.IntPtr StoreContentQueryCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// FloatProperty: StoreContentQueryTime
    /// </summary>
    public unsafe float StoreContentQueryTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// ArrayProperty: DefaultBatgirlKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap> DefaultBatgirlKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap>>(Ptr + 4320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4320); }
    }

    /// <summary>
    /// ArrayProperty: DefaultRedHoodKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap> DefaultRedHoodKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap>>(Ptr + 4336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4336); }
    }

    /// <summary>
    /// ArrayProperty: DefaultHarleyKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap> DefaultHarleyKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap>>(Ptr + 4352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4352); }
    }

    /// <summary>
    /// ArrayProperty: LevelVolumeListBatchBase
    /// </summary>
    public unsafe BmSDK.TArray<int> LevelVolumeListBatchBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// ArrayProperty: LevelVolumeBspNodesBatchBase
    /// </summary>
    public unsafe BmSDK.TArray<int> LevelVolumeBspNodesBatchBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4384); }
    }

    /// <summary>
    /// ArrayProperty: LevelTransitionListBatchBase
    /// </summary>
    public unsafe BmSDK.TArray<int> LevelTransitionListBatchBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4400); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeCharacterIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FChallengeCharacterId> ChallengeCharacterIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FChallengeCharacterId>>(Ptr + 4416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4416); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeRequiredChaptersById
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FRequiredChaptersByChallengeId> ChallengeRequiredChaptersById
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FRequiredChaptersByChallengeId>>(Ptr + 4432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4432); }
    }

    /// <summary>
    /// ArrayProperty: NoAssistedTakedownVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNoAssistedTakedownVolume> NoAssistedTakedownVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNoAssistedTakedownVolume>>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }

    /// <summary>
    /// ArrayProperty: FailsafeSeenSeqEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> FailsafeSeenSeqEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 4464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4464); }
    }

    /// <summary>
    /// ArrayProperty: FreezeTankDestroyers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFreezeTankDestroyerBase> FreezeTankDestroyers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFreezeTankDestroyerBase>>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }

    /// <summary>
    /// DelegateProperty: __SortByIndexDist__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByIndexDist__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4496); }
    }

    /// <summary>
    /// DelegateProperty: __OnStoreContentQueryComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnStoreContentQueryComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }

    /// <summary>
    /// DelegateProperty: __ContentBeaconManifestLoaded__Delegate
    /// </summary>
    public unsafe System.IntPtr __ContentBeaconManifestLoaded__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4528); }
    }

}
