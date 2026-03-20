#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPlayerController<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPlayerController : BmSDK.BmGame.RPlayerControllerBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPlayerController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPlayerController() { }

    /// <summary>
    /// Constructs a new RPlayerController
    /// </summary>
    public RPlayerController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPlayerController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPlayerController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerController>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerController>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerController>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerController>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerController>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerController>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerController>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: FinishedCombatSpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FinishedCombatSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// ObjectProperty: FinishedCombatSpecialMoveThug
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain FinishedCombatSpecialMoveThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// ObjectProperty: ModularHud
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieModularHud ModularHud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieModularHud>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// ObjectProperty: GadgetSelect
    /// </summary>
    public unsafe BmSDK.BmGame.RGadgetSelectBM3 GadgetSelect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGadgetSelectBM3>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// ObjectProperty: RadialGadgetSelect
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieRadialGadgetSelect RadialGadgetSelect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieRadialGadgetSelect>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// ObjectProperty: GauntletProjector
    /// </summary>
    public unsafe BmSDK.BmGame.RGauntletProjector GauntletProjector
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGauntletProjector>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// ObjectProperty: GauntletProjectorArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RGauntletProjector GauntletProjectorArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGauntletProjector>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// ObjectProperty: CurrentAirshipController
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_AirshipBobbingBase CurrentAirshipController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_AirshipBobbingBase>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// ObjectProperty: ObjectivesContainer
    /// </summary>
    public unsafe BmSDK.BmGame.RHudObjectivesContainer ObjectivesContainer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudObjectivesContainer>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// ObjectProperty: TapeSubtitlesToMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovie TapeSubtitlesToMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovie>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// ObjectProperty: BackScreenMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieBackScreen BackScreenMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieBackScreen>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// ObjectProperty: Map3DActRef
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxWorldMovieActorMap3D Map3DActRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxWorldMovieActorMap3D>(Ptr + 2004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2004); }
    }

    /// <summary>
    /// ObjectProperty: MinigameMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieResonatorMinigame MinigameMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieResonatorMinigame>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// ObjectProperty: PauseMenuMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI_PauseBase PauseMenuMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI_PauseBase>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// ObjectProperty: LobbyMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovie LobbyMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovie>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// ObjectProperty: MWStatsMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovie MWStatsMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovie>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// ObjectProperty: CreditsMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovie CreditsMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovie>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// ObjectProperty: GenericErrorMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieGenericError GenericErrorMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieGenericError>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// ObjectProperty: PLMResumeMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovie PLMResumeMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovie>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// ObjectProperty: MissionWheelMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieMissionWheel MissionWheelMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieMissionWheel>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// ObjectProperty: Music_CombatCameraActivePawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn Music_CombatCameraActivePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ObjectProperty: RadioScannerSubtitleLookup
    /// </summary>
    public unsafe BmSDK.BmGame.RSubtitleLookup RadioScannerSubtitleLookup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSubtitleLookup>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// ObjectProperty: CurrentScanInformant
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain CurrentScanInformant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// ObjectProperty: RiddlerPickupTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPickupBaseBase RiddlerPickupTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPickupBaseBase>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// ObjectProperty: CurrentAggressiveHelicopter
    /// </summary>
    public unsafe BmSDK.BmGame.RHelicopterBase CurrentAggressiveHelicopter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// ObjectProperty: CachedHelicopterAggroEvent
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqEvent_HelicopterAggroStateChanged CachedHelicopterAggroEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqEvent_HelicopterAggroStateChanged>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// ObjectProperty: CurrentEvidenceTrail
    /// </summary>
    public unsafe BmSDK.BmGame.REvidence CurrentEvidenceTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REvidence>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSurveillanceInterceptActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentSurveillanceInterceptActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// ObjectProperty: SurveillanceParticleEffectTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SurveillanceParticleEffectTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ObjectProperty: SurveillanceParticleEffectTemplate_Helicopter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SurveillanceParticleEffectTemplate_Helicopter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileInDoorway
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelTransition BatmobileInDoorway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelTransition>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileNearDoorway
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelTransition BatmobileNearDoorway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelTransition>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ObjectProperty: UIOptionRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform UIOptionRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// ObjectProperty: HudMovieScore
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieScoreHUD HudMovieScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieScoreHUD>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// ObjectProperty: FadeCinematicMode
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_CinematicMode FadeCinematicMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_CinematicMode>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// ObjectProperty: CombatPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer CombatPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// ObjectProperty: BasePawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat BasePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// ObjectProperty: BatmobilePawn
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase BatmobilePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase>(Ptr + 2212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2212); }
    }

    /// <summary>
    /// ObjectProperty: OriginalPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer OriginalPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// ObjectProperty: PlayerWaypoint
    /// </summary>
    public unsafe BmSDK.BmGame.RObjectiveMarker PlayerWaypoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RObjectiveMarker>(Ptr + 2228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2228); }
    }

    /// <summary>
    /// ObjectProperty: ManuallySelectedObjectiveMarker
    /// </summary>
    public unsafe BmSDK.BmGame.RObjectiveMarker ManuallySelectedObjectiveMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RObjectiveMarker>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// ObjectProperty: CurrentlyActiveObjectiveMarker
    /// </summary>
    public unsafe BmSDK.BmGame.RObjectiveMarker CurrentlyActiveObjectiveMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RObjectiveMarker>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// ObjectProperty: GameSettings
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSettings GameSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSettings>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// ObjectProperty: ProfileSettings
    /// </summary>
    public unsafe BmSDK.BmGame.RProfileSettings ProfileSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProfileSettings>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// ObjectProperty: StatsReadObject
    /// </summary>
    public unsafe BmSDK.BmGame.ROnlineStatsRead StatsReadObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.ROnlineStatsRead>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// ObjectProperty: StatsReadObjectMW
    /// </summary>
    public unsafe BmSDK.BmGame.ROnlineStatsReadMostWanted StatsReadObjectMW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.ROnlineStatsReadMostWanted>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// ObjectProperty: CartoonPP
    /// </summary>
    public unsafe BmSDK.BmGame.RCartoonViewPostProcess CartoonPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCartoonViewPostProcess>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// ObjectProperty: BackScreenPP
    /// </summary>
    public unsafe BmSDK.BmGame.RBackScreenViewPostProcess BackScreenPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBackScreenViewPostProcess>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// ObjectProperty: PhotoPP
    /// </summary>
    public unsafe BmSDK.BmGame.RPhotoViewPostProcess PhotoPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhotoViewPostProcess>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// ObjectProperty: FlashPP
    /// </summary>
    public unsafe BmSDK.BmGame.RFlashViewPostProcess FlashPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFlashViewPostProcess>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// ObjectProperty: InteractableItemActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor InteractableItemActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// ObjectProperty: ExperienceSystem
    /// </summary>
    public unsafe BmSDK.BmGame.RExperienceSystem ExperienceSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RExperienceSystem>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// ObjectProperty: HUDPrompt
    /// </summary>
    public unsafe BmSDK.BmGame.RHUDPrompt HUDPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// ObjectProperty: CurrentHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint CurrentHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// ObjectProperty: PendingHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint PendingHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// ObjectProperty: NextHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint NextHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2356); }
    }

    /// <summary>
    /// ObjectProperty: LastHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LastHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// ObjectProperty: RecentHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint RecentHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickOriginHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint GlideKickOriginHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// ObjectProperty: DropAttackOriginHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint DropAttackOriginHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2388); }
    }

    /// <summary>
    /// ObjectProperty: LampPostHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LampPostHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// ObjectProperty: CurrentForensicsDevice
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice CurrentForensicsDevice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// ObjectProperty: CurrentCrimeScene
    /// </summary>
    public unsafe BmSDK.BmGame.RCrimeSceneBase CurrentCrimeScene
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCrimeSceneBase>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// ObjectProperty: ForensicsInvestigator
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsInvestigator ForensicsInvestigator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsInvestigator>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileForensicsSeqAct
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_SetBatmobileForensicsBase BatmobileForensicsSeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_SetBatmobileForensicsBase>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// ObjectProperty: MultipleMobileObjectivesSeqAct
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_MultipleMobileObjectives MultipleMobileObjectivesSeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_MultipleMobileObjectives>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// ObjectProperty: DialogueCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RDialogueCamera DialogueCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDialogueCamera>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// ObjectProperty: TalkerInRange
    /// </summary>
    public unsafe BmSDK.BmGame.RPawn TalkerInRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// ObjectProperty: ShowcaseCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RShowcaseCamera ShowcaseCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RShowcaseCamera>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// ObjectProperty: CharacterSwitchCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerTransitionCameraActor CharacterSwitchCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerTransitionCameraActor>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// ObjectProperty: VentChuteCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RVentChuteCamera VentChuteCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVentChuteCamera>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// ObjectProperty: MoveToAct
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_MovePlayer MoveToAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_MovePlayer>(Ptr + 2484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2484); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSpecialMoveController
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController CurrentSpecialMoveController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// ObjectProperty: CurrentAgilitySpecialMoveController
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController CurrentAgilitySpecialMoveController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 2500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2500); }
    }

    /// <summary>
    /// ObjectProperty: CurrentCoverSpecialMoveController
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController CurrentCoverSpecialMoveController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 2508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2508); }
    }

    /// <summary>
    /// ObjectProperty: CurrentClimbDownSpecialMoveController
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController CurrentClimbDownSpecialMoveController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// ObjectProperty: LeftMoveController
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController LeftMoveController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 2524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2524); }
    }

    /// <summary>
    /// ObjectProperty: RightMoveController
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController RightMoveController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// ObjectProperty: CinematicCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RInGameCinematicCam CinematicCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInGameCinematicCam>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// ObjectProperty: VantagePointCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RVantagePointGrappleCamera VantagePointCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVantagePointGrappleCamera>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// ObjectProperty: RescueCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RAutoRescueCamera RescueCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAutoRescueCamera>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// ObjectProperty: DeathCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RDeathCamera DeathCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeathCamera>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// ObjectProperty: BatarangCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarangCamera BatarangCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarangCamera>(Ptr + 2572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2572); }
    }

    /// <summary>
    /// ObjectProperty: mCaseFileCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RCaseFileCameraActor mCaseFileCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCaseFileCameraActor>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// ObjectProperty: MultiTargetCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RMultiTargetCamera MultiTargetCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMultiTargetCamera>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// ObjectProperty: VantagePointMovementCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RVantagePointMovementCamera VantagePointMovementCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVantagePointMovementCamera>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }

    /// <summary>
    /// ObjectProperty: AgilitySpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig AgilitySpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// ObjectProperty: ClimbDownSpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClimbDownSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// ObjectProperty: CoverSpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }

    /// <summary>
    /// ObjectProperty: CurrentAltitudeVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RAltitudeVolume CurrentAltitudeVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAltitudeVolume>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// ObjectProperty: CurrentStealthTakeDown
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage CurrentStealthTakeDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// ObjectProperty: InteractingObject
    /// </summary>
    public unsafe BmSDK.Engine.Actor InteractingObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }

    /// <summary>
    /// ObjectProperty: SilentPredatorCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RSilentPredatorCamera SilentPredatorCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSilentPredatorCamera>(Ptr + 2652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2652); }
    }

    /// <summary>
    /// ObjectProperty: CameraConversationAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_PlayCameraConversation CameraConversationAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_PlayCameraConversation>(Ptr + 2660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2660); }
    }

    /// <summary>
    /// ObjectProperty: RadioConversationAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue RadioConversationAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue>(Ptr + 2668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2668); }
    }

    /// <summary>
    /// ObjectProperty: GlidePostProcess
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess GlidePostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 2676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2676); }
    }

    /// <summary>
    /// ObjectProperty: FearTakedownPostProcess
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess FearTakedownPostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 2684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2684); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDamagePostProcess
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess PlayerDamagePostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 2692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2692); }
    }

    /// <summary>
    /// ObjectProperty: CurrentRescuePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRescuePoint CurrentRescuePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRescuePoint>(Ptr + 2700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2700); }
    }

    /// <summary>
    /// ObjectProperty: KillZone
    /// </summary>
    public unsafe BmSDK.BmGame.RKillVolume KillZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RKillVolume>(Ptr + 2708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2708); }
    }

    /// <summary>
    /// ObjectProperty: CurrentBossPawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn CurrentBossPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 2716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2716); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CapeGlideTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTakedownTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain CurrentTakedownTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTakedownTarget2
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain CurrentTakedownTarget2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }

    /// <summary>
    /// ObjectProperty: CurrentVehicleTakedownTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentVehicleTakedownTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2748); }
    }

    /// <summary>
    /// ObjectProperty: TakedownFractureWall
    /// </summary>
    public unsafe BmSDK.Engine.Actor TakedownFractureWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2756); }
    }

    /// <summary>
    /// ObjectProperty: TakedownRemoveableGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RRemoveableGrate TakedownRemoveableGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRemoveableGrate>(Ptr + 2764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2764); }
    }

    /// <summary>
    /// ObjectProperty: AboveTakedownTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor AboveTakedownTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2772); }
    }

    /// <summary>
    /// ObjectProperty: CurrentCapeAttackTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAIAnim CurrentCapeAttackTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAIAnim>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }

    /// <summary>
    /// ObjectProperty: LineLauncherTakedownTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LineLauncherTakedownTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 2788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2788); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain InterrogationTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 2796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2796); }
    }

    /// <summary>
    /// ObjectProperty: ActiveCrawlSpaceVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RCrawlSpaceVolume ActiveCrawlSpaceVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCrawlSpaceVolume>(Ptr + 2804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2804); }
    }

    /// <summary>
    /// ObjectProperty: DiveBombFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform DiveBombFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2812); }
    }

    /// <summary>
    /// ObjectProperty: MovieInfoToRestoreWhenJammingCeases
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie MovieInfoToRestoreWhenJammingCeases
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 2820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2820); }
    }

    /// <summary>
    /// ObjectProperty: lastEnteredGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase lastEnteredGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 2828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2828); }
    }

    /// <summary>
    /// ObjectProperty: lastExitedGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase lastExitedGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 2836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2836); }
    }

    /// <summary>
    /// ObjectProperty: BatmanCutscene
    /// </summary>
    public unsafe BmSDK.BmGame.RBmBatmanCutscene BatmanCutscene
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBmBatmanCutscene>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }

    /// <summary>
    /// ObjectProperty: DeathCutscene
    /// </summary>
    public unsafe BmSDK.BmGame.RBMDeathCutscene DeathCutscene
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMDeathCutscene>(Ptr + 2852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2852); }
    }

    /// <summary>
    /// ObjectProperty: ProjectileAudioDetector
    /// </summary>
    public unsafe BmSDK.Engine.Actor ProjectileAudioDetector
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2860); }
    }

    /// <summary>
    /// ObjectProperty: OriginalBatmanPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer OriginalBatmanPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 2868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2868); }
    }

    /// <summary>
    /// ObjectProperty: DisplayGroundTakedownInstructions
    /// </summary>
    public unsafe BmSDK.Engine.Actor DisplayGroundTakedownInstructions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2876); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation CurrentLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 2884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2884); }
    }

    /// <summary>
    /// ObjectProperty: AffectPlayerVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RAffectPlayerVolume AffectPlayerVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAffectPlayerVolume>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }

    /// <summary>
    /// ObjectProperty: ForceGlideVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume ForceGlideVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 2900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2900); }
    }

    /// <summary>
    /// ObjectProperty: CurrentDisableEvadeVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RDisableEvadeVolume CurrentDisableEvadeVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDisableEvadeVolume>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }

    /// <summary>
    /// ObjectProperty: OverrideCreviceCameraVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume OverrideCreviceCameraVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 2916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2916); }
    }

    /// <summary>
    /// ObjectProperty: TakedownTunnelGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase TakedownTunnelGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// ObjectProperty: PredatorAttackTargets
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass PredatorAttackTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 2932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2932); }
    }

    /// <summary>
    /// ObjectProperty: GlideAttackTargets
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass GlideAttackTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }

    /// <summary>
    /// ObjectProperty: InteractableTargets
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass InteractableTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 2948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2948); }
    }

    /// <summary>
    /// ObjectProperty: InteractableFarRangeTargets
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass InteractableFarRangeTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 2956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2956); }
    }

    /// <summary>
    /// ObjectProperty: TunnelGrates
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass TunnelGrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 2964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2964); }
    }

    /// <summary>
    /// ObjectProperty: SmashFractureGlassTargets
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass SmashFractureGlassTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 2972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2972); }
    }

    /// <summary>
    /// ObjectProperty: Grenades
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass Grenades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 2980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2980); }
    }

    /// <summary>
    /// ObjectProperty: TakedownRopes
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass TakedownRopes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 2988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2988); }
    }

    /// <summary>
    /// ObjectProperty: ChuteExits
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass ChuteExits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 2996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2996); }
    }

    /// <summary>
    /// ObjectProperty: HostileMissiles
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass HostileMissiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 3004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3004); }
    }

    /// <summary>
    /// ObjectProperty: EnemyCarTargets
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass EnemyCarTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 3012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3012); }
    }

    /// <summary>
    /// ObjectProperty: VehicleTakedownTargets
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass VehicleTakedownTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 3020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3020); }
    }

    /// <summary>
    /// ObjectProperty: VehicleThreats
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass VehicleThreats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 3028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3028); }
    }

    /// <summary>
    /// ObjectProperty: SideStoryPointsOfInterest
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass SideStoryPointsOfInterest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 3036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3036); }
    }

    /// <summary>
    /// ObjectProperty: IncendiaryChargeGrenades
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass IncendiaryChargeGrenades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 3044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3044); }
    }

    /// <summary>
    /// ObjectProperty: AmbientOcclusionEffect
    /// </summary>
    public unsafe BmSDK.Engine.PostProcessEffect AmbientOcclusionEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessEffect>(Ptr + 3052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3052); }
    }

    /// <summary>
    /// ObjectProperty: ForcedLookAtEnemy
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI ForcedLookAtEnemy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 3060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3060); }
    }

    /// <summary>
    /// ObjectProperty: LastLadder
    /// </summary>
    public unsafe BmSDK.BmGame.RLadder LastLadder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLadder>(Ptr + 3068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3068); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSavedMove
    /// </summary>
    public unsafe BmSDK.Engine.SavedMove CurrentSavedMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SavedMove>(Ptr + 3076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3076); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLastSavedMove
    /// </summary>
    public unsafe BmSDK.Engine.SavedMove CurrentLastSavedMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SavedMove>(Ptr + 3084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3084); }
    }

    /// <summary>
    /// ObjectProperty: CurrentOldSavedMove
    /// </summary>
    public unsafe BmSDK.Engine.SavedMove CurrentOldSavedMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SavedMove>(Ptr + 3092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3092); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeModifierTimer
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_HUDTimer ChallengeModifierTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_HUDTimer>(Ptr + 3100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3100); }
    }

    /// <summary>
    /// ObjectProperty: NPCAvoidanceLookActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor NPCAvoidanceLookActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3108); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTauntVol
    /// </summary>
    public unsafe BmSDK.BmGame.RTauntVolume CurrentTauntVol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTauntVolume>(Ptr + 3116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3116); }
    }

    /// <summary>
    /// ObjectProperty: NeedsTickingFirst
    /// </summary>
    public unsafe BmSDK.Engine.Actor NeedsTickingFirst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3124); }
    }

    /// <summary>
    /// ObjectProperty: deathCamOverridePawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn deathCamOverridePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 3132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3132); }
    }

    /// <summary>
    /// ObjectProperty: SpecialQuickGadgetAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_QuickGadgetAction SpecialQuickGadgetAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_QuickGadgetAction>(Ptr + 3140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3140); }
    }

    /// <summary>
    /// ObjectProperty: RiddlerProgressEventCached
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqEvent_RiddlerProgressionAdvanced RiddlerProgressEventCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqEvent_RiddlerProgressionAdvanced>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }

    /// <summary>
    /// ObjectProperty: InterrogatablePredatorThug
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain InterrogatablePredatorThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 3156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3156); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPredatorZone
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerPredatorZone PlayerPredatorZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerPredatorZone>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// ObjectProperty: DrivingBoostFeedback
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform DrivingBoostFeedback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 3172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3172); }
    }

    /// <summary>
    /// ObjectProperty: DrivingSlideFeedback
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform DrivingSlideFeedback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }

    /// <summary>
    /// ObjectProperty: CurrentDrivingFeedback
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform CurrentDrivingFeedback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 3188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3188); }
    }

    /// <summary>
    /// ObjectProperty: StunnedPostProcess
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess StunnedPostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 3196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3196); }
    }

    /// <summary>
    /// ObjectProperty: OverrideCharacterData
    /// </summary>
    public unsafe BmSDK.BmGame.RAddContentPlayerCharacter OverrideCharacterData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAddContentPlayerCharacter>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }

    /// <summary>
    /// ObjectProperty: CurrentChuteExit
    /// </summary>
    public unsafe BmSDK.BmGame.RSwingChuteExitBase CurrentChuteExit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSwingChuteExitBase>(Ptr + 3212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3212); }
    }

    /// <summary>
    /// ObjectProperty: CurrentChuteHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint CurrentChuteHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 3220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3220); }
    }

    /// <summary>
    /// ObjectProperty: CachedTunnelNetworkTargetClass
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass CachedTunnelNetworkTargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 3228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3228); }
    }

    /// <summary>
    /// ObjectProperty: OWWaterVolumes
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass OWWaterVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 3236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3236); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideGadgetSpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideGadgetSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3244); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideGadgetTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CapeGlideGadgetTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3252); }
    }

    /// <summary>
    /// ObjectProperty: ForceGlideBatclawTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor ForceGlideBatclawTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3260); }
    }

    /// <summary>
    /// ObjectProperty: ClosestVehicleChaser
    /// </summary>
    public unsafe BmSDK.Engine.Actor ClosestVehicleChaser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3268); }
    }

    /// <summary>
    /// ObjectProperty: GlideTargetHelper
    /// </summary>
    public unsafe BmSDK.Engine.Actor GlideTargetHelper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3276); }
    }

    /// <summary>
    /// ObjectProperty: FlameManagerInstance
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_FlameManagerBase FlameManagerInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_FlameManagerBase>(Ptr + 3284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3284); }
    }

    /// <summary>
    /// ObjectProperty: BufferedFearTakedownTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain BufferedFearTakedownTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 3292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3292); }
    }

    /// <summary>
    /// ObjectProperty: CurrentCeilingGrateTakedownTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain CurrentCeilingGrateTakedownTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 3300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3300); }
    }

    /// <summary>
    /// ObjectProperty: PreviouslyTakendownFearTakedownVictim
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PreviouslyTakendownFearTakedownVictim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 3308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3308); }
    }

    /// <summary>
    /// ObjectProperty: ArkhamKnightClashSequenceAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_ArkhamKnightClash ArkhamKnightClashSequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_ArkhamKnightClash>(Ptr + 3316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3316); }
    }

    /// <summary>
    /// ObjectProperty: HeavyTankArrowTexture
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface HeavyTankArrowTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 3324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3324); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileCameraVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileRiddlerCameraVolume BatmobileCameraVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileRiddlerCameraVolume>(Ptr + 3332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3332); }
    }

    /// <summary>
    /// ObjectProperty: LocalCharacterLightArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RLocalLightContainer LocalCharacterLightArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLocalLightContainer>(Ptr + 3340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3340); }
    }

    /// <summary>
    /// ObjectProperty: InactiveMissionBasedTrigger
    /// </summary>
    public unsafe BmSDK.BmGame.RTriggerVolumeMissionBased InactiveMissionBasedTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTriggerVolumeMissionBased>(Ptr + 3348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3348); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileSideSwipeTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC BatmobileSideSwipeTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 3356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3356); }
    }

    /// <summary>
    /// ObjectProperty: HushController
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_HushCounterController HushController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_HushCounterController>(Ptr + 3364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3364); }
    }

    /// <summary>
    /// ObjectProperty: DoingWhenSpotted
    /// </summary>
    public unsafe BmSDK.Engine.Actor DoingWhenSpotted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3372); }
    }

    /// <summary>
    /// ObjectProperty: SlowMoSpotter
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain SlowMoSpotter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 3380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3380); }
    }

    /// <summary>
    /// ObjectProperty: ForcedGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint ForcedGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 3388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3388); }
    }

    /// <summary>
    /// ObjectProperty: PhotoCameraControllerRef
    /// </summary>
    public unsafe BmSDK.BmGame.RPhotoCameraController PhotoCameraControllerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhotoCameraController>(Ptr + 3396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3396); }
    }

    /// <summary>
    /// ObjectProperty: SuppressMostWantedPromptAction
    /// </summary>
    public unsafe BmSDK.Engine.SequenceAction SuppressMostWantedPromptAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SequenceAction>(Ptr + 3404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3404); }
    }

    /// <summary>
    /// ComponentProperty: LocalCharacterLight
    /// </summary>
    public unsafe BmSDK.Engine.LightComponent LocalCharacterLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LightComponent>(Ptr + 3412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3412); }
    }

    /// <summary>
    /// ComponentProperty: EnvironmentChecker
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker EnvironmentChecker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker>(Ptr + 3420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3420); }
    }

    /// <summary>
    /// ClassProperty: LastDamageType
    /// </summary>
    public unsafe BmSDK.Class LastDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3428); }
    }

    /// <summary>
    /// BoolProperty: bIsKeyMapSetToDefault
    /// </summary>
    public unsafe bool bIsKeyMapSetToDefault
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bLockedIntoCeilingGrateTakedown
    /// </summary>
    public unsafe bool bLockedIntoCeilingGrateTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bSlomoSelectingFearTakedownFromGrappleBoostGrappleMovement
    /// </summary>
    public unsafe bool bSlomoSelectingFearTakedownFromGrappleBoostGrappleMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bGrappleBoostFearTakedownSlomoHasFinished
    /// </summary>
    public unsafe bool bGrappleBoostFearTakedownSlomoHasFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysShowClimbDownPrompt
    /// </summary>
    public unsafe bool bAlwaysShowClimbDownPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: OverworldGameplayLastFrame
    /// </summary>
    public unsafe bool OverworldGameplayLastFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bMapMode3D
    /// </summary>
    public unsafe bool bMapMode3D
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bTestPresence
    /// </summary>
    public unsafe bool bTestPresence
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bTestPresenceChallenge
    /// </summary>
    public unsafe bool bTestPresenceChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bTestFillLB
    /// </summary>
    public unsafe bool bTestFillLB
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bCustomSaveRetry
    /// </summary>
    public unsafe bool bCustomSaveRetry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: LastHealthBarValueSentWasBatmobile
    /// </summary>
    public unsafe bool LastHealthBarValueSentWasBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bShowHealthBar
    /// </summary>
    public unsafe bool bShowHealthBar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bLevelUpImminent
    /// </summary>
    public unsafe bool bLevelUpImminent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: LevelUpVisible
    /// </summary>
    public unsafe bool LevelUpVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: LevelUpAvailableAndNotDismissed
    /// </summary>
    public unsafe bool LevelUpAvailableAndNotDismissed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: LevelUpSoundRequired
    /// </summary>
    public unsafe bool LevelUpSoundRequired
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bForceStorageUIShow
    /// </summary>
    public unsafe bool bForceStorageUIShow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bIsVideoRecording
    /// </summary>
    public unsafe bool bIsVideoRecording
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bRiddlerPickupDebugLabels
    /// </summary>
    public unsafe bool bRiddlerPickupDebugLabels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bSpecialDontUnpauseAfterErrorUI
    /// </summary>
    public unsafe bool bSpecialDontUnpauseAfterErrorUI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bBlockPauseChallengeStuff
    /// </summary>
    public unsafe bool bBlockPauseChallengeStuff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bLookInputTemporarilyIgnored
    /// </summary>
    public unsafe bool bLookInputTemporarilyIgnored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bInformantScanActive
    /// </summary>
    public unsafe bool bInformantScanActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bRiddlerPickupScanActive
    /// </summary>
    public unsafe bool bRiddlerPickupScanActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bMostRecentCombatEndedInVictory
    /// </summary>
    public unsafe bool bMostRecentCombatEndedInVictory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: CurrentEvidenceTrailActive
    /// </summary>
    public unsafe bool CurrentEvidenceTrailActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bPickUpConfirmed
    /// </summary>
    public unsafe bool bPickUpConfirmed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: SurveillanceBroadcastDirty
    /// </summary>
    public unsafe bool SurveillanceBroadcastDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bPreventBatmbileExit
    /// </summary>
    public unsafe bool bPreventBatmbileExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bPauseExitAction
    /// </summary>
    public unsafe bool bPauseExitAction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bPredatorStatusOpen
    /// </summary>
    public unsafe bool bPredatorStatusOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3436); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3436); }
    }

    /// <summary>
    /// BoolProperty: bUsingGamepadStored
    /// </summary>
    public unsafe bool bUsingGamepadStored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bShouldBlockSubtitles
    /// </summary>
    public unsafe bool bShouldBlockSubtitles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bOptionsSavePending
    /// </summary>
    public unsafe bool bOptionsSavePending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bPauseDelayed
    /// </summary>
    public unsafe bool bPauseDelayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bMusicAtmosPlaying
    /// </summary>
    public unsafe bool bMusicAtmosPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bMusicThemePlaying
    /// </summary>
    public unsafe bool bMusicThemePlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bMusicChallengePlaying
    /// </summary>
    public unsafe bool bMusicChallengePlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bHasDismissedChallengeResults
    /// </summary>
    public unsafe bool bHasDismissedChallengeResults
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bAutomaticallyDisplayScore
    /// </summary>
    public unsafe bool bAutomaticallyDisplayScore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: FadedAudio
    /// </summary>
    public unsafe bool FadedAudio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bMissileLockOnscreen
    /// </summary>
    public unsafe bool bMissileLockOnscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysShowVehicleRadar
    /// </summary>
    public unsafe bool bAlwaysShowVehicleRadar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bIntroFinished
    /// </summary>
    public unsafe bool bIntroFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: CurrentlyUsingFakeCustomMarker
    /// </summary>
    public unsafe bool CurrentlyUsingFakeCustomMarker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: ReshowObjectiveAfterNextObjectiveUpdate
    /// </summary>
    public unsafe bool ReshowObjectiveAfterNextObjectiveUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: ShouldShowOverworldRiddleHint
    /// </summary>
    public unsafe bool ShouldShowOverworldRiddleHint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: ShowingOverworldRiddleHint
    /// </summary>
    public unsafe bool ShowingOverworldRiddleHint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: ObjectiveTargetSuppressedByProximity
    /// </summary>
    public unsafe bool ObjectiveTargetSuppressedByProximity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bBlockCycleGadgets
    /// </summary>
    public unsafe bool bBlockCycleGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bDebugSimulateForDurango
    /// </summary>
    public unsafe bool bDebugSimulateForDurango
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bDebugSimulateForOrbis
    /// </summary>
    public unsafe bool bDebugSimulateForOrbis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bSigningIn
    /// </summary>
    public unsafe bool bSigningIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bReadingStats
    /// </summary>
    public unsafe bool bReadingStats
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bReadingStatsMW
    /// </summary>
    public unsafe bool bReadingStatsMW
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bStorageSelect
    /// </summary>
    public unsafe bool bStorageSelect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bStorageSelectRetryUI
    /// </summary>
    public unsafe bool bStorageSelectRetryUI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bStorageSelectCheckExists
    /// </summary>
    public unsafe bool bStorageSelectCheckExists
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bDisableLiveChecking
    /// </summary>
    public unsafe bool bDisableLiveChecking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bInCredits
    /// </summary>
    public unsafe bool bInCredits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: Lobby_bReady
    /// </summary>
    public unsafe bool Lobby_bReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bStartingCartoonPP
    /// </summary>
    public unsafe bool bStartingCartoonPP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bAllowCartoonPP
    /// </summary>
    public unsafe bool bAllowCartoonPP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3440); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3440); }
    }

    /// <summary>
    /// BoolProperty: bStartingBackScreenPP
    /// </summary>
    public unsafe bool bStartingBackScreenPP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bAllowBackScreenPP
    /// </summary>
    public unsafe bool bAllowBackScreenPP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bWasGoodPhoto
    /// </summary>
    public unsafe bool bWasGoodPhoto
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: InteractableItemLongRange
    /// </summary>
    public unsafe bool InteractableItemLongRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bIsLookingAtInteractableItem
    /// </summary>
    public unsafe bool bIsLookingAtInteractableItem
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bIsLookingAtInterestingItem
    /// </summary>
    public unsafe bool bIsLookingAtInterestingItem
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bAllowAirbornePitchControl
    /// </summary>
    public unsafe bool bAllowAirbornePitchControl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bGrappleMoving
    /// </summary>
    public unsafe bool bGrappleMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: LastVolumeEnteredHadRoomNameSuppressed
    /// </summary>
    public unsafe bool LastVolumeEnteredHadRoomNameSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bAllowFakeTakedown
    /// </summary>
    public unsafe bool bAllowFakeTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bSpotted
    /// </summary>
    public unsafe bool bSpotted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bAbleToHideMove
    /// </summary>
    public unsafe bool bAbleToHideMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bCapeGlideDisabled
    /// </summary>
    public unsafe bool bCapeGlideDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bLedgeGrabDisabled
    /// </summary>
    public unsafe bool bLedgeGrabDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bTunnelGratesDisabled
    /// </summary>
    public unsafe bool bTunnelGratesDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bJustCrouched
    /// </summary>
    public unsafe bool bJustCrouched
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: CapeGlideDiveToGround
    /// </summary>
    public unsafe bool CapeGlideDiveToGround
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bIsInCrimeScene
    /// </summary>
    public unsafe bool bIsInCrimeScene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bHasResetPP
    /// </summary>
    public unsafe bool bHasResetPP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bInvestigateMode
    /// </summary>
    public unsafe bool bInvestigateMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bHideHudGadgets
    /// </summary>
    public unsafe bool bHideHudGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bLockForensics
    /// </summary>
    public unsafe bool bLockForensics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bEnableJokerLaugh
    /// </summary>
    public unsafe bool bEnableJokerLaugh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreNextForensicsButtonRelease
    /// </summary>
    public unsafe bool bIgnoreNextForensicsButtonRelease
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: BatmobileForensicDecalsActive
    /// </summary>
    public unsafe bool BatmobileForensicDecalsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bLockMap
    /// </summary>
    public unsafe bool bLockMap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bAllowedToUseIteractableItems
    /// </summary>
    public unsafe bool bAllowedToUseIteractableItems
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bInDialogueCamera
    /// </summary>
    public unsafe bool bInDialogueCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bForceBlendOutFinalDialogueCam
    /// </summary>
    public unsafe bool bForceBlendOutFinalDialogueCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bIsMovingToDialoguePoint
    /// </summary>
    public unsafe bool bIsMovingToDialoguePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreFirstCamCut
    /// </summary>
    public unsafe bool bIgnoreFirstCamCut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bKilledByPod
    /// </summary>
    public unsafe bool bKilledByPod
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3444); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3444); }
    }

    /// <summary>
    /// BoolProperty: bKilledByThug
    /// </summary>
    public unsafe bool bKilledByThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bTravellingToWayPoint
    /// </summary>
    public unsafe bool bTravellingToWayPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bReachedWayPoint
    /// </summary>
    public unsafe bool bReachedWayPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bAimingWithBatarang
    /// </summary>
    public unsafe bool bAimingWithBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: SimpleGlideBoostControls
    /// </summary>
    public unsafe bool SimpleGlideBoostControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: ButtonOnlyBoostControls
    /// </summary>
    public unsafe bool ButtonOnlyBoostControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: SimpleGlideBoostForwardTrigger
    /// </summary>
    public unsafe bool SimpleGlideBoostForwardTrigger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: AttackButtonHeld
    /// </summary>
    public unsafe bool AttackButtonHeld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: CoverButtonHeld
    /// </summary>
    public unsafe bool CoverButtonHeld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bGadgetButtonHeld
    /// </summary>
    public unsafe bool bGadgetButtonHeld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bClumsy
    /// </summary>
    public unsafe bool bClumsy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bForceCrouch
    /// </summary>
    public unsafe bool bForceCrouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bForcePawnRotationToFollowCamera
    /// </summary>
    public unsafe bool bForcePawnRotationToFollowCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bDisableRunInstantTurn
    /// </summary>
    public unsafe bool bDisableRunInstantTurn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bControllerCentered
    /// </summary>
    public unsafe bool bControllerCentered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bExitScanModeRequested
    /// </summary>
    public unsafe bool bExitScanModeRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bReturnToDetectiveModeOnExit
    /// </summary>
    public unsafe bool bReturnToDetectiveModeOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bTriggerBatarangCamera
    /// </summary>
    public unsafe bool bTriggerBatarangCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bBlockVehicleCameraTransition
    /// </summary>
    public unsafe bool bBlockVehicleCameraTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: DisplayFlashingText
    /// </summary>
    public unsafe bool DisplayFlashingText
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bCapeGlideTargetRobinControlled
    /// </summary>
    public unsafe bool bCapeGlideTargetRobinControlled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bDisableTakedowns
    /// </summary>
    public unsafe bool bDisableTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bCurrentTakedownTargetIsStunned
    /// </summary>
    public unsafe bool bCurrentTakedownTargetIsStunned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: TakedownVictimWasFrozen
    /// </summary>
    public unsafe bool TakedownVictimWasFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: TakedownVictimWasTrapped
    /// </summary>
    public unsafe bool TakedownVictimWasTrapped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bThroughGrateBelowBatmanTakedownTarget
    /// </summary>
    public unsafe bool bThroughGrateBelowBatmanTakedownTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bThroughGlassCeilingBelowBatmanTakedownTarget
    /// </summary>
    public unsafe bool bThroughGlassCeilingBelowBatmanTakedownTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bIsAboveTakedownTarget
    /// </summary>
    public unsafe bool bIsAboveTakedownTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bIsAboveTakedownTargetBelow
    /// </summary>
    public unsafe bool bIsAboveTakedownTargetBelow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: LockGlide
    /// </summary>
    public unsafe bool LockGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bInGlideKickPose
    /// </summary>
    public unsafe bool bInGlideKickPose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bCanTriggerPounce
    /// </summary>
    public unsafe bool bCanTriggerPounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3448); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3448); }
    }

    /// <summary>
    /// BoolProperty: bTurnDisablesCameraDrag
    /// </summary>
    public unsafe bool bTurnDisablesCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bDamageEffectDroppingOff
    /// </summary>
    public unsafe bool bDamageEffectDroppingOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreGameOverPromptResult
    /// </summary>
    public unsafe bool bIgnoreGameOverPromptResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: CapeGlideDisabledDueToKickOff
    /// </summary>
    public unsafe bool CapeGlideDisabledDueToKickOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: UseRailingJumpAssistance
    /// </summary>
    public unsafe bool UseRailingJumpAssistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: HasJustComeOutOfDive
    /// </summary>
    public unsafe bool HasJustComeOutOfDive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: BoostGlide
    /// </summary>
    public unsafe bool BoostGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: GadgetAimGlide
    /// </summary>
    public unsafe bool GadgetAimGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: HasSlowedDownAfterDiveBoost
    /// </summary>
    public unsafe bool HasSlowedDownAfterDiveBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: ForceDiveBoost
    /// </summary>
    public unsafe bool ForceDiveBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: PerformingInitialBoostDive
    /// </summary>
    public unsafe bool PerformingInitialBoostDive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bJammedDetectiveModeGlitched
    /// </summary>
    public unsafe bool bJammedDetectiveModeGlitched
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bJammedDetectiveModeAudioActive
    /// </summary>
    public unsafe bool bJammedDetectiveModeAudioActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: MovieShowBoolToRestoreWhenJammingCeases
    /// </summary>
    public unsafe bool MovieShowBoolToRestoreWhenJammingCeases
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bIntiallyHiddenInCeilingMode
    /// </summary>
    public unsafe bool bIntiallyHiddenInCeilingMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bBodyDetectedDuringCeilingMode
    /// </summary>
    public unsafe bool bBodyDetectedDuringCeilingMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bDebugSpeedometer
    /// </summary>
    public unsafe bool bDebugSpeedometer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawNumPrimitives
    /// </summary>
    public unsafe bool bDebugDrawNumPrimitives
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bDrawSmokeScreenTimer
    /// </summary>
    public unsafe bool bDrawSmokeScreenTimer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: UsedQuickGadget
    /// </summary>
    public unsafe bool UsedQuickGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: QuickGadgetOnRT
    /// </summary>
    public unsafe bool QuickGadgetOnRT
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: SlideOnTapRT
    /// </summary>
    public unsafe bool SlideOnTapRT
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: AudioCapeGlideSlowMoStarted
    /// </summary>
    public unsafe bool AudioCapeGlideSlowMoStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: UseLedgePerch
    /// </summary>
    public unsafe bool UseLedgePerch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bAimGadgetPressed
    /// </summary>
    public unsafe bool bAimGadgetPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bKeepMovementState
    /// </summary>
    public unsafe bool bKeepMovementState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bGrappleBetweenVantagePoints
    /// </summary>
    public unsafe bool bGrappleBetweenVantagePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bEnteredVentWithoutBeingSeen
    /// </summary>
    public unsafe bool bEnteredVentWithoutBeingSeen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bEnteredVentViaTunnelGrate
    /// </summary>
    public unsafe bool bEnteredVentViaTunnelGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: bSwingGrapple
    /// </summary>
    public unsafe bool bSwingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: InSoftCover
    /// </summary>
    public unsafe bool InSoftCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: LockedToCorner
    /// </summary>
    public unsafe bool LockedToCorner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3452); }
    }

    /// <summary>
    /// BoolProperty: CoverLocked
    /// </summary>
    public unsafe bool CoverLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bShouldPeerDown
    /// </summary>
    public unsafe bool bShouldPeerDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: ShowingCrossHair
    /// </summary>
    public unsafe bool ShowingCrossHair
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bDebugRagdollFreeSpot
    /// </summary>
    public unsafe bool bDebugRagdollFreeSpot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bDebugFearTakedowns
    /// </summary>
    public unsafe bool bDebugFearTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bDebugStealthAttacks
    /// </summary>
    public unsafe bool bDebugStealthAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bDebugAllowFrontTakedowns
    /// </summary>
    public unsafe bool bDebugAllowFrontTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: AttackGlide
    /// </summary>
    public unsafe bool AttackGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: SpecialGlideTakedown
    /// </summary>
    public unsafe bool SpecialGlideTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: ButtonCover
    /// </summary>
    public unsafe bool ButtonCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bOpeningDoor
    /// </summary>
    public unsafe bool bOpeningDoor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bComingOffRightTrigger
    /// </summary>
    public unsafe bool bComingOffRightTrigger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bLeftTriggerBatarang
    /// </summary>
    public unsafe bool bLeftTriggerBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bDestroyingPod
    /// </summary>
    public unsafe bool bDestroyingPod
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bBeingGrabbed
    /// </summary>
    public unsafe bool bBeingGrabbed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bTryingToJumpOffRailing
    /// </summary>
    public unsafe bool bTryingToJumpOffRailing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bDidCriticalFallCheck
    /// </summary>
    public unsafe bool bDidCriticalFallCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bIsCriticalFallHeight
    /// </summary>
    public unsafe bool bIsCriticalFallHeight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bIsDying
    /// </summary>
    public unsafe bool bIsDying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: CapeGlideFromVantagePoint
    /// </summary>
    public unsafe bool CapeGlideFromVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bFallGliding
    /// </summary>
    public unsafe bool bFallGliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bForceCinematicMode
    /// </summary>
    public unsafe bool bForceCinematicMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bAlignJumpsToAxis
    /// </summary>
    public unsafe bool bAlignJumpsToAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bDisableAutoJumping
    /// </summary>
    public unsafe bool bDisableAutoJumping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bForceGlide
    /// </summary>
    public unsafe bool bForceGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: BatarangReadied
    /// </summary>
    public unsafe bool BatarangReadied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bForce1stPersonLookDirection
    /// </summary>
    public unsafe bool bForce1stPersonLookDirection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bDisableCineCapeControl
    /// </summary>
    public unsafe bool bDisableCineCapeControl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bDissalowRun
    /// </summary>
    public unsafe bool bDissalowRun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bStopPlayerFallingOffEdges
    /// </summary>
    public unsafe bool bStopPlayerFallingOffEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bDoneCapeKickCamera
    /// </summary>
    public unsafe bool bDoneCapeKickCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bDisplaySilentPredatorEscapeInstructions
    /// </summary>
    public unsafe bool bDisplaySilentPredatorEscapeInstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3456); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3456); }
    }

    /// <summary>
    /// BoolProperty: bDisplayIncendiaryGrenadeInstructions
    /// </summary>
    public unsafe bool bDisplayIncendiaryGrenadeInstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bDisplayCallBatmobileToRoadHelp
    /// </summary>
    public unsafe bool bDisplayCallBatmobileToRoadHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bDisplayKOSmashInstructions
    /// </summary>
    public unsafe bool bDisplayKOSmashInstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bCeilingHiddenInstructions
    /// </summary>
    public unsafe bool bCeilingHiddenInstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bDualPlayPredSwitchInstructions
    /// </summary>
    public unsafe bool bDualPlayPredSwitchInstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bDisplaySixaxisSteerTutorial
    /// </summary>
    public unsafe bool bDisplaySixaxisSteerTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bDisplaySonicBatarangFail
    /// </summary>
    public unsafe bool bDisplaySonicBatarangFail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bShowLineLaunchStopInstructions
    /// </summary>
    public unsafe bool bShowLineLaunchStopInstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bShowVulcanGunIneffectiveInstructions
    /// </summary>
    public unsafe bool bShowVulcanGunIneffectiveInstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bDisplayKnightmareModeFearTakedownLost
    /// </summary>
    public unsafe bool bDisplayKnightmareModeFearTakedownLost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: CompassEmpty
    /// </summary>
    public unsafe bool CompassEmpty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: PlayInWheel
    /// </summary>
    public unsafe bool PlayInWheel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bSupressLowUrgencyOpenWheelMessage
    /// </summary>
    public unsafe bool bSupressLowUrgencyOpenWheelMessage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bObjectiveQueueActive
    /// </summary>
    public unsafe bool bObjectiveQueueActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bDelayMissionSelectAudio
    /// </summary>
    public unsafe bool bDelayMissionSelectAudio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bDelayMissionSelectTurn
    /// </summary>
    public unsafe bool bDelayMissionSelectTurn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bDelayMissionSelectObjectiveMessage
    /// </summary>
    public unsafe bool bDelayMissionSelectObjectiveMessage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: LowUrgencyOpenWheelShouldDisplayForever
    /// </summary>
    public unsafe bool LowUrgencyOpenWheelShouldDisplayForever
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: MissionSound_Param_FadeOverOldDialogue
    /// </summary>
    public unsafe bool MissionSound_Param_FadeOverOldDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bRenderCornerPointDebug
    /// </summary>
    public unsafe bool bRenderCornerPointDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bHasGrappleBoostedThisGlide
    /// </summary>
    public unsafe bool bHasGrappleBoostedThisGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bRunOverridesGadget
    /// </summary>
    public unsafe bool bRunOverridesGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bUnderATunnelGrate
    /// </summary>
    public unsafe bool bUnderATunnelGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bAllowPelvisCameraSway
    /// </summary>
    public unsafe bool bAllowPelvisCameraSway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bDisableUseCover
    /// </summary>
    public unsafe bool bDisableUseCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bQueuedEvade
    /// </summary>
    public unsafe bool bQueuedEvade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bHangingNearHangRope
    /// </summary>
    public unsafe bool bHangingNearHangRope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bDisableGadgetSelect
    /// </summary>
    public unsafe bool bDisableGadgetSelect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bDisableGadgets
    /// </summary>
    public unsafe bool bDisableGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bFirstHangFrame
    /// </summary>
    public unsafe bool bFirstHangFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bUsingToggledCrouch
    /// </summary>
    public unsafe bool bUsingToggledCrouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToDebounceRun
    /// </summary>
    public unsafe bool bWaitingToDebounceRun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3460); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToDebounceCrouch
    /// </summary>
    public unsafe bool bWaitingToDebounceCrouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToDebounceAimGadget
    /// </summary>
    public unsafe bool bWaitingToDebounceAimGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToDebounceCrouchForSwingCamera
    /// </summary>
    public unsafe bool bWaitingToDebounceCrouchForSwingCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToDebounceBatmobileFire
    /// </summary>
    public unsafe bool bWaitingToDebounceBatmobileFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToDebounceSecondaryFire
    /// </summary>
    public unsafe bool bWaitingToDebounceSecondaryFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToCornerForward
    /// </summary>
    public unsafe bool bWaitingToCornerForward
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bTryingToGrappleLaunch
    /// </summary>
    public unsafe bool bTryingToGrappleLaunch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bAllowOverLook
    /// </summary>
    public unsafe bool bAllowOverLook
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bReadyToStartMatch
    /// </summary>
    public unsafe bool bReadyToStartMatch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bPoisoned
    /// </summary>
    public unsafe bool bPoisoned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: AvoidAllowStayInZoom
    /// </summary>
    public unsafe bool AvoidAllowStayInZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bGrapplePressed
    /// </summary>
    public unsafe bool bGrapplePressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bCarryingSomeone
    /// </summary>
    public unsafe bool bCarryingSomeone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bAllowDemoMute
    /// </summary>
    public unsafe bool bAllowDemoMute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: MuteAudioForDemo
    /// </summary>
    public unsafe bool MuteAudioForDemo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bAutoClimbFromWallStick
    /// </summary>
    public unsafe bool bAutoClimbFromWallStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bNewQuickGadgetControls
    /// </summary>
    public unsafe bool bNewQuickGadgetControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bLookingFromSecondScreen
    /// </summary>
    public unsafe bool bLookingFromSecondScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bAllowSuperGlideAttack
    /// </summary>
    public unsafe bool bAllowSuperGlideAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bHasSpeedMutator
    /// </summary>
    public unsafe bool bHasSpeedMutator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bHasProjectileMutator
    /// </summary>
    public unsafe bool bHasProjectileMutator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bSlowdownAllowed
    /// </summary>
    public unsafe bool bSlowdownAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bShowingDoubleLineLauncherTutorial
    /// </summary>
    public unsafe bool bShowingDoubleLineLauncherTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bEnygmaScreenTutorial
    /// </summary>
    public unsafe bool bEnygmaScreenTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bShowHostageTakenHelpPrompt
    /// </summary>
    public unsafe bool bShowHostageTakenHelpPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bAttackFromLineLauncher
    /// </summary>
    public unsafe bool bAttackFromLineLauncher
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bTriggerCinematicCam
    /// </summary>
    public unsafe bool bTriggerCinematicCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bUnderFire
    /// </summary>
    public unsafe bool bUnderFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bNewGamePlus
    /// </summary>
    public unsafe bool bNewGamePlus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bCatwomanReplay
    /// </summary>
    public unsafe bool bCatwomanReplay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bVerticalSlice
    /// </summary>
    public unsafe bool bVerticalSlice
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: bSimplifiedHUDForDemo
    /// </summary>
    public unsafe bool bSimplifiedHUDForDemo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3464); }
    }

    /// <summary>
    /// BoolProperty: RiddlerUnlockDeferredByCombat
    /// </summary>
    public unsafe bool RiddlerUnlockDeferredByCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bCombatPawnsBlockingInterrogation
    /// </summary>
    public unsafe bool bCombatPawnsBlockingInterrogation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bInterrogationLoaded
    /// </summary>
    public unsafe bool bInterrogationLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bInterrogationSetInvisibleToHelicopters
    /// </summary>
    public unsafe bool bInterrogationSetInvisibleToHelicopters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bUnlockedPhysicalChallenges
    /// </summary>
    public unsafe bool bUnlockedPhysicalChallenges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bStartedInterrogateTut
    /// </summary>
    public unsafe bool bStartedInterrogateTut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bStartedInterrogateTutCar
    /// </summary>
    public unsafe bool bStartedInterrogateTutCar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bStartedInterrogateTutFoot
    /// </summary>
    public unsafe bool bStartedInterrogateTutFoot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bRaceInProgress
    /// </summary>
    public unsafe bool bRaceInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bAllowFirstRiddlerTrophySpeech
    /// </summary>
    public unsafe bool bAllowFirstRiddlerTrophySpeech
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bDisableGrappleCancel
    /// </summary>
    public unsafe bool bDisableGrappleCancel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bQueueCallBatmobileFromSpecialMove
    /// </summary>
    public unsafe bool bQueueCallBatmobileFromSpecialMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bDisplayedGroundTakedownPrompt
    /// </summary>
    public unsafe bool bDisplayedGroundTakedownPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bNoDeathRumble
    /// </summary>
    public unsafe bool bNoDeathRumble
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: AllowHitReactionsInCinematicMode
    /// </summary>
    public unsafe bool AllowHitReactionsInCinematicMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: JustDoneHangAttack
    /// </summary>
    public unsafe bool JustDoneHangAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bFirstGrappleFrame
    /// </summary>
    public unsafe bool bFirstGrappleFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: CarFollowsCamera
    /// </summary>
    public unsafe bool CarFollowsCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bShowVehicleThreats
    /// </summary>
    public unsafe bool bShowVehicleThreats
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bModernControls
    /// </summary>
    public unsafe bool bModernControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bThrottleOnLeftStick
    /// </summary>
    public unsafe bool bThrottleOnLeftStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bShowDrivingInputs
    /// </summary>
    public unsafe bool bShowDrivingInputs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bShowDrivingDashboard
    /// </summary>
    public unsafe bool bShowDrivingDashboard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bShowLevelVolumes
    /// </summary>
    public unsafe bool bShowLevelVolumes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bDebugVehicleRainbow
    /// </summary>
    public unsafe bool bDebugVehicleRainbow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bDrawBatmobileThreatRange
    /// </summary>
    public unsafe bool bDrawBatmobileThreatRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: DrivingCantMoveDirSticky
    /// </summary>
    public unsafe bool DrivingCantMoveDirSticky
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: EscortingVehicle
    /// </summary>
    public unsafe bool EscortingVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bDrivingModePlayingMissileWarning
    /// </summary>
    public unsafe bool bDrivingModePlayingMissileWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bDrivingModeHeavyTankLock
    /// </summary>
    public unsafe bool bDrivingModeHeavyTankLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bPlayingLowHealthWarning
    /// </summary>
    public unsafe bool bPlayingLowHealthWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bDrivingModePerformingWheelspin
    /// </summary>
    public unsafe bool bDrivingModePerformingWheelspin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3468); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3468); }
    }

    /// <summary>
    /// BoolProperty: bBoostGlideFromBatmobile
    /// </summary>
    public unsafe bool bBoostGlideFromBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bStunned
    /// </summary>
    public unsafe bool bStunned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bZapped
    /// </summary>
    public unsafe bool bZapped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bLasered
    /// </summary>
    public unsafe bool bLasered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bRobinAssistMode
    /// </summary>
    public unsafe bool bRobinAssistMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bDualTakedownAvailable
    /// </summary>
    public unsafe bool bDualTakedownAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bDualClashAvailable
    /// </summary>
    public unsafe bool bDualClashAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bTunnelNetworkHighlighted
    /// </summary>
    public unsafe bool bTunnelNetworkHighlighted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bTunnelNetworkCurrentlyHighlightedByDetectiveMode
    /// </summary>
    public unsafe bool bTunnelNetworkCurrentlyHighlightedByDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: AlternativeWalk
    /// </summary>
    public unsafe bool AlternativeWalk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: AlternativeWalkAllowCameraTurn
    /// </summary>
    public unsafe bool AlternativeWalkAllowCameraTurn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bAimingBatmobile
    /// </summary>
    public unsafe bool bAimingBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bShowingBatmobileAim
    /// </summary>
    public unsafe bool bShowingBatmobileAim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bBufferedFearTakedownIsGlide
    /// </summary>
    public unsafe bool bBufferedFearTakedownIsGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bPerformingFearTakedown
    /// </summary>
    public unsafe bool bPerformingFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bDisplayFearTakedownRechargeInstructions
    /// </summary>
    public unsafe bool bDisplayFearTakedownRechargeInstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bPlayerHasFourthFearTakedownUpgrade
    /// </summary>
    public unsafe bool bPlayerHasFourthFearTakedownUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bPlayerHasFifthFearTakedownUpgrade
    /// </summary>
    public unsafe bool bPlayerHasFifthFearTakedownUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bForceAllowActionButtons
    /// </summary>
    public unsafe bool bForceAllowActionButtons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bDisplayExtraMinidroneTutorial
    /// </summary>
    public unsafe bool bDisplayExtraMinidroneTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bRadarInZoomedModeForFight
    /// </summary>
    public unsafe bool bRadarInZoomedModeForFight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bAllowHealthBarInCine
    /// </summary>
    public unsafe bool bAllowHealthBarInCine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bLockCornerCover
    /// </summary>
    public unsafe bool bLockCornerCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: VentCameraBelow
    /// </summary>
    public unsafe bool VentCameraBelow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bJokerfiedBatman
    /// </summary>
    public unsafe bool bJokerfiedBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bGadgetsDisabledByDamage
    /// </summary>
    public unsafe bool bGadgetsDisabledByDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bExitingRadioMode
    /// </summary>
    public unsafe bool bExitingRadioMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bRadioModePlayingBatmobileCameraIn
    /// </summary>
    public unsafe bool bRadioModePlayingBatmobileCameraIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bShowGetInBatmobilePrompt
    /// </summary>
    public unsafe bool bShowGetInBatmobilePrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bCanGetInBatmobile
    /// </summary>
    public unsafe bool bCanGetInBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bSuppressPOILabel
    /// </summary>
    public unsafe bool bSuppressPOILabel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bDebugAlwaysUseBattleModeToggle
    /// </summary>
    public unsafe bool bDebugAlwaysUseBattleModeToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3472); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3472); }
    }

    /// <summary>
    /// BoolProperty: bLocalCharacterLightShouldBeAttached
    /// </summary>
    public unsafe bool bLocalCharacterLightShouldBeAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: BatmobileOutOfRemoteRange
    /// </summary>
    public unsafe bool BatmobileOutOfRemoteRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileUnderAttack
    /// </summary>
    public unsafe bool bBatmobileUnderAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bStealthTakedownClearOfNavMeshObstacle
    /// </summary>
    public unsafe bool bStealthTakedownClearOfNavMeshObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: DrawGrappleWaypoints
    /// </summary>
    public unsafe bool DrawGrappleWaypoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bSpottedSlowMo
    /// </summary>
    public unsafe bool bSpottedSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bAllowInteractablesWhenNoMovement
    /// </summary>
    public unsafe bool bAllowInteractablesWhenNoMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: LandCausesThugStartle
    /// </summary>
    public unsafe bool LandCausesThugStartle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bAllowCombo
    /// </summary>
    public unsafe bool bAllowCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bHideGlideKickAndFearTakedowns
    /// </summary>
    public unsafe bool bHideGlideKickAndFearTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bStoredLockCamera
    /// </summary>
    public unsafe bool bStoredLockCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bPlayingUnderAttackSound
    /// </summary>
    public unsafe bool bPlayingUnderAttackSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bBatarangBoost
    /// </summary>
    public unsafe bool bBatarangBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bInDeathStrokeFinale
    /// </summary>
    public unsafe bool bInDeathStrokeFinale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bSuppressOpenLevelUpOrMapInput
    /// </summary>
    public unsafe bool bSuppressOpenLevelUpOrMapInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bForceNextGrappleToBoost
    /// </summary>
    public unsafe bool bForceNextGrappleToBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bRootsPermanentlyVisible
    /// </summary>
    public unsafe bool bRootsPermanentlyVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bPreviousObjectiveDelayed
    /// </summary>
    public unsafe bool bPreviousObjectiveDelayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// BoolProperty: bDisplayHarleyCantUseGrateChutesTutorial
    /// </summary>
    public unsafe bool bDisplayHarleyCantUseGrateChutesTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3476); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3476); }
    }

    /// <summary>
    /// ByteProperty: CurrentCheckFrame
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController.EPCCheckFrame CurrentCheckFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController.EPCCheckFrame>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// ByteProperty: LastVehicleCombatMedal
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController.EVehicleCombatMedals LastVehicleCombatMedal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController.EVehicleCombatMedals>(Ptr + 3481); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3481); }
    }

    /// <summary>
    /// ByteProperty: CurrentSpecialTrackingMode
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.SpecialTrackingMode CurrentSpecialTrackingMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.SpecialTrackingMode>(Ptr + 3482); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3482); }
    }

    /// <summary>
    /// ByteProperty: CurrentSurveillanceMode
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleAlertsAndSurveillance.SurveillanceModes CurrentSurveillanceMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleAlertsAndSurveillance.SurveillanceModes>(Ptr + 3483); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3483); }
    }

    /// <summary>
    /// ByteProperty: TargetSurveillanceMode
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleAlertsAndSurveillance.SurveillanceModes TargetSurveillanceMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleAlertsAndSurveillance.SurveillanceModes>(Ptr + 3484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3484); }
    }

    /// <summary>
    /// ByteProperty: ControllerWasDisconnectedCount
    /// </summary>
    public unsafe byte ControllerWasDisconnectedCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3485); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3485); }
    }

    /// <summary>
    /// ByteProperty: MapKeyActiveType
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController.MapKeyType MapKeyActiveType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController.MapKeyType>(Ptr + 3486); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3486); }
    }

    /// <summary>
    /// ByteProperty: LastCharacterBioUnlocked
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EBioCharacter LastCharacterBioUnlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EBioCharacter>(Ptr + 3487); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3487); }
    }

    /// <summary>
    /// ByteProperty: FriendsListFetchType
    /// </summary>
    public unsafe BmSDK.Engine.UIDataStore_OnlineStats.EStatsFetchType FriendsListFetchType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataStore_OnlineStats.EStatsFetchType>(Ptr + 3488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3488); }
    }

    /// <summary>
    /// ByteProperty: PresenceID
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EPresenceID PresenceID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EPresenceID>(Ptr + 3489); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3489); }
    }

    /// <summary>
    /// ByteProperty: MostWantedLeaderboardId
    /// </summary>
    public unsafe byte MostWantedLeaderboardId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3490); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3490); }
    }

    /// <summary>
    /// ByteProperty: TakedownFeatureType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.ETakedownFeature_Type TakedownFeatureType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.ETakedownFeature_Type>(Ptr + 3491); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3491); }
    }

    /// <summary>
    /// ByteProperty: bSavedIgnoreLook
    /// </summary>
    public unsafe byte bSavedIgnoreLook
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3492); }
    }

    /// <summary>
    /// ByteProperty: bSavedIgnoreMove
    /// </summary>
    public unsafe byte bSavedIgnoreMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3493); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3493); }
    }

    /// <summary>
    /// ByteProperty: CapeGlideBoostRumbleFunctionLeft
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform.EWaveformFunction CapeGlideBoostRumbleFunctionLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform.EWaveformFunction>(Ptr + 3494); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3494); }
    }

    /// <summary>
    /// ByteProperty: CapeGlideBoostRumbleFunctionRight
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform.EWaveformFunction CapeGlideBoostRumbleFunctionRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform.EWaveformFunction>(Ptr + 3495); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3495); }
    }

    /// <summary>
    /// ByteProperty: PreferedCoverSide
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.CoverCornerType PreferedCoverSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.CoverCornerType>(Ptr + 3496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3496); }
    }

    /// <summary>
    /// ByteProperty: KismetState
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController.KismetBatmanStates KismetState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController.KismetBatmanStates>(Ptr + 3497); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3497); }
    }

    /// <summary>
    /// ByteProperty: CurrentLowUrgencyOpenWheelState
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController.LowUrgencyOpenWheelStates CurrentLowUrgencyOpenWheelState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController.LowUrgencyOpenWheelStates>(Ptr + 3498); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3498); }
    }

    /// <summary>
    /// ByteProperty: MissionSound_Param_DialogueType
    /// </summary>
    public unsafe BmSDK.BmGame.RSideStoryManager.MissionDialogueType MissionSound_Param_DialogueType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSideStoryManager.MissionDialogueType>(Ptr + 3499); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3499); }
    }

    /// <summary>
    /// ByteProperty: InterrogationPose
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2IdleConfig.EInterrogationPose InterrogationPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2IdleConfig.EInterrogationPose>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// ByteProperty: CurrentJumpSpace
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController.JumpSpaceResult CurrentJumpSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController.JumpSpaceResult>(Ptr + 3501); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3501); }
    }

    /// <summary>
    /// ByteProperty: CurrentEjectType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileEjectType CurrentEjectType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileEjectType>(Ptr + 3502); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3502); }
    }

    /// <summary>
    /// ArrayProperty: CreditsSectionOrderFull
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CreditsSectionOrderFull
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 3504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }
    }

    /// <summary>
    /// FloatProperty: audio_cover
    /// </summary>
    public unsafe float audio_cover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3520); }
    }

    /// <summary>
    /// StructProperty: AudioCachedBattleMode
    /// </summary>
    public unsafe System.Numerics.Vector3 AudioCachedBattleMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3524); }
    }

    /// <summary>
    /// ArrayProperty: PlayableCharactersV2
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerController.FPlayableCharacterItem> PlayableCharactersV2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerController.FPlayableCharacterItem>>(Ptr + 3536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3536); }
    }

    /// <summary>
    /// ArrayProperty: RiddleInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerController.FRiddleData> RiddleInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerController.FRiddleData>>(Ptr + 3552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3552); }
    }

    /// <summary>
    /// NameProperty: LastRiddleTypeSolved
    /// </summary>
    public unsafe BmSDK.FName LastRiddleTypeSolved
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// ArrayProperty: MapUseCurrentLevelInstead
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MapUseCurrentLevelInstead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// ArrayProperty: MapCityTransitionRemaps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerController.FRemapStringAtoB> MapCityTransitionRemaps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerController.FRemapStringAtoB>>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// FloatProperty: HudReappearTimer
    /// </summary>
    public unsafe float HudReappearTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// IntProperty: CurrentAirshipInvalidControlAttempts
    /// </summary>
    public unsafe int CurrentAirshipInvalidControlAttempts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3612); }
    }

    /// <summary>
    /// ArrayProperty: CurrentAirshipTiltBlockerVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RStopBatmanFromUsingAirshipTiltVolume> CurrentAirshipTiltBlockerVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStopBatmanFromUsingAirshipTiltVolume>>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// ArrayProperty: ManualAdvanceMovies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMovie> ManualAdvanceMovies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMovie>>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// ArrayProperty: GFxDrawHUD
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMovie> GFxDrawHUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMovie>>(Ptr + 3648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3648); }
    }

    /// <summary>
    /// ArrayProperty: VoiceRecList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> VoiceRecList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 3664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3664); }
    }

    /// <summary>
    /// FloatProperty: RunningTimer
    /// </summary>
    public unsafe float RunningTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceRunPressed
    /// </summary>
    public unsafe float TimeSinceRunPressed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3684); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceStunPressed
    /// </summary>
    public unsafe float TimeSinceStunPressed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }

    /// <summary>
    /// StrProperty: Backscreen_Params
    /// </summary>
    public unsafe BmSDK.FString Backscreen_Params
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3692); }
    }

    /// <summary>
    /// StrProperty: OverrideMapPMap
    /// </summary>
    public unsafe BmSDK.FString OverrideMapPMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3708); }
    }

    /// <summary>
    /// StrProperty: OverrideMapRoom
    /// </summary>
    public unsafe BmSDK.FString OverrideMapRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3724); }
    }

    /// <summary>
    /// StructProperty: MapMode3D_InitialLocationGame
    /// </summary>
    public unsafe System.Numerics.Vector3 MapMode3D_InitialLocationGame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3740); }
    }

    /// <summary>
    /// StructProperty: MapMode3D_InitialRotationGame
    /// </summary>
    public unsafe BmSDK.Rotator MapMode3D_InitialRotationGame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 3752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }
    }

    /// <summary>
    /// FloatProperty: MapMode3D_InitialFOVGame
    /// </summary>
    public unsafe float MapMode3D_InitialFOVGame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3764); }
    }

    /// <summary>
    /// StructProperty: MapMode3D_InitialLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 MapMode3D_InitialLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3768); }
    }

    /// <summary>
    /// StructProperty: MapMode3D_InitialRotation
    /// </summary>
    public unsafe BmSDK.Rotator MapMode3D_InitialRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 3780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3780); }
    }

    /// <summary>
    /// FloatProperty: MapMode3D_InitialFOV
    /// </summary>
    public unsafe float MapMode3D_InitialFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3792); }
    }

    /// <summary>
    /// StructProperty: MapMode3D_CurrentLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 MapMode3D_CurrentLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3796); }
    }

    /// <summary>
    /// StructProperty: MapMode3D_CurrentRotation
    /// </summary>
    public unsafe BmSDK.Rotator MapMode3D_CurrentRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 3808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3808); }
    }

    /// <summary>
    /// FloatProperty: MapMode3D_CurrentFOV
    /// </summary>
    public unsafe float MapMode3D_CurrentFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3820); }
    }

    /// <summary>
    /// IntProperty: TestPresenceCounter
    /// </summary>
    public unsafe int TestPresenceCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3824); }
    }

    /// <summary>
    /// IntProperty: TestPresenceFrameDelay
    /// </summary>
    public unsafe int TestPresenceFrameDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3828); }
    }

    /// <summary>
    /// IntProperty: TestPresenceFrameDelayMax
    /// </summary>
    public unsafe int TestPresenceFrameDelayMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3832); }
    }

    /// <summary>
    /// IntProperty: TestFillLBIniIndex
    /// </summary>
    public unsafe int TestFillLBIniIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3836); }
    }

    /// <summary>
    /// IntProperty: TestFillLBUserIndex
    /// </summary>
    public unsafe int TestFillLBUserIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }
    }

    /// <summary>
    /// IntProperty: TestFillLBFrameDelay
    /// </summary>
    public unsafe int TestFillLBFrameDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3844); }
    }

    /// <summary>
    /// ArrayProperty: TestFillLBUsers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> TestFillLBUsers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 3848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3848); }
    }

    /// <summary>
    /// StrProperty: saveDelayedFilename
    /// </summary>
    public unsafe BmSDK.FString saveDelayedFilename
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3864); }
    }

    /// <summary>
    /// FloatProperty: CurrentHealthBarValue
    /// </summary>
    public unsafe float CurrentHealthBarValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3880); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceDisplayedHealthBar
    /// </summary>
    public unsafe float TimeSinceDisplayedHealthBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3884); }
    }

    /// <summary>
    /// FloatProperty: PeriodBeforeHideHealthBar
    /// </summary>
    public unsafe float PeriodBeforeHideHealthBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3888); }
    }

    /// <summary>
    /// IntProperty: InitialUpgradeDelay
    /// </summary>
    public unsafe int InitialUpgradeDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3892); }
    }

    /// <summary>
    /// IntProperty: LastPointsToSpend
    /// </summary>
    public unsafe int LastPointsToSpend
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3896); }
    }

    /// <summary>
    /// StrProperty: LastDebugSaveGameDescription
    /// </summary>
    public unsafe BmSDK.FString LastDebugSaveGameDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3900); }
    }

    /// <summary>
    /// FloatProperty: OtherPlayerHealthBarValue
    /// </summary>
    public unsafe float OtherPlayerHealthBarValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3916); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceDisplayedOtherPlayerHealthBar
    /// </summary>
    public unsafe float TimeSinceDisplayedOtherPlayerHealthBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3920); }
    }

    /// <summary>
    /// IntProperty: iInvisibleToHelicoptersCount
    /// </summary>
    public unsafe int iInvisibleToHelicoptersCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3924); }
    }

    /// <summary>
    /// FloatProperty: fHelicopterFlightControlHorizThreshold
    /// </summary>
    public unsafe float fHelicopterFlightControlHorizThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3928); }
    }

    /// <summary>
    /// FloatProperty: fHelicopterFlightControlVertSeparation
    /// </summary>
    public unsafe float fHelicopterFlightControlVertSeparation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3932); }
    }

    /// <summary>
    /// FloatProperty: fOverridePromptDuration
    /// </summary>
    public unsafe float fOverridePromptDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3936); }
    }

    /// <summary>
    /// FloatProperty: LastTimeEvidenceFound
    /// </summary>
    public unsafe float LastTimeEvidenceFound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3940); }
    }

    /// <summary>
    /// FloatProperty: GlideDist
    /// </summary>
    public unsafe float GlideDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3944); }
    }

    /// <summary>
    /// StrProperty: SpecialTrackingModeDisplayName
    /// </summary>
    public unsafe BmSDK.FString SpecialTrackingModeDisplayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3948); }
    }

    /// <summary>
    /// StrProperty: SpecialTrackingEvidenceInternalName
    /// </summary>
    public unsafe BmSDK.FString SpecialTrackingEvidenceInternalName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3964); }
    }

    /// <summary>
    /// ArrayProperty: TripleTrailRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.REvidence> TripleTrailRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.REvidence>>(Ptr + 3980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3980); }
    }

    /// <summary>
    /// ArrayProperty: TripleTrailCompletion
    /// </summary>
    public unsafe BmSDK.TArray<bool> TripleTrailCompletion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 3996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3996); }
    }

    /// <summary>
    /// StructProperty: CurrentSurveillanceInterceptActorLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentSurveillanceInterceptActorLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4012); }
    }

    /// <summary>
    /// StrProperty: SurveillanceBroadcastStation
    /// </summary>
    public unsafe BmSDK.FString SurveillanceBroadcastStation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }
    }

    /// <summary>
    /// StrProperty: SurveillanceBroadcastSpeaker
    /// </summary>
    public unsafe BmSDK.FString SurveillanceBroadcastSpeaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }

    /// <summary>
    /// IntProperty: nSurveillanceSuppressedRef
    /// </summary>
    public unsafe int nSurveillanceSuppressedRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4056); }
    }

    /// <summary>
    /// StrProperty: MapKeyActiveTypeParams
    /// </summary>
    public unsafe BmSDK.FString MapKeyActiveTypeParams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4060); }
    }

    /// <summary>
    /// StrProperty: ActiveScreenName
    /// </summary>
    public unsafe BmSDK.FString ActiveScreenName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4076); }
    }

    /// <summary>
    /// IntProperty: iHudScoreScore
    /// </summary>
    public unsafe int iHudScoreScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4092); }
    }

    /// <summary>
    /// IntProperty: iHudScoreOpponent
    /// </summary>
    public unsafe int iHudScoreOpponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// FloatProperty: fClientLastSentTimeValue
    /// </summary>
    public unsafe float fClientLastSentTimeValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// FloatProperty: fHudScoreTime
    /// </summary>
    public unsafe float fHudScoreTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }

    /// <summary>
    /// IntProperty: iOtherPlayerHealth
    /// </summary>
    public unsafe int iOtherPlayerHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4108); }
    }

    /// <summary>
    /// IntProperty: iOtherPlayerMaxHealth
    /// </summary>
    public unsafe int iOtherPlayerMaxHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4112); }
    }

    /// <summary>
    /// IntProperty: TakedownLevelOnHud
    /// </summary>
    public unsafe int TakedownLevelOnHud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }

    /// <summary>
    /// FloatProperty: Audio_RainCurrentCapeArmPosition
    /// </summary>
    public unsafe float Audio_RainCurrentCapeArmPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4120); }
    }

    /// <summary>
    /// StructProperty: HudScoreCombo
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController.FHudComboData HudScoreCombo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController.FHudComboData>(Ptr + 4124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4124); }
    }

    /// <summary>
    /// IntProperty: iHead2HeadBank
    /// </summary>
    public unsafe int iHead2HeadBank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// StructProperty: HudChallengeCombatData
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController.FChallengeCombatData HudChallengeCombatData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController.FChallengeCombatData>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// IntProperty: WaypointProximityThresholdCentimetres
    /// </summary>
    public unsafe int WaypointProximityThresholdCentimetres
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4184); }
    }

    /// <summary>
    /// IntProperty: WaypointProximityThresholdSquared
    /// </summary>
    public unsafe int WaypointProximityThresholdSquared
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4188); }
    }

    /// <summary>
    /// ArrayProperty: FriendsList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend> FriendsList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend>>(Ptr + 4192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4192); }
    }

    /// <summary>
    /// IntProperty: FetchMyRankRetry
    /// </summary>
    public unsafe int FetchMyRankRetry
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4208); }
    }

    /// <summary>
    /// IntProperty: DelayLiveChecking
    /// </summary>
    public unsafe int DelayLiveChecking
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4212); }
    }

    /// <summary>
    /// IntProperty: Lobby_CharIndex
    /// </summary>
    public unsafe int Lobby_CharIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }

    /// <summary>
    /// IntProperty: Lobby_SkinIndex
    /// </summary>
    public unsafe int Lobby_SkinIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4220); }
    }

    /// <summary>
    /// StrProperty: Lobby_CharacterName
    /// </summary>
    public unsafe BmSDK.FString Lobby_CharacterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4224); }
    }

    /// <summary>
    /// FloatProperty: CartoonTimer
    /// </summary>
    public unsafe float CartoonTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4240); }
    }

    /// <summary>
    /// FloatProperty: CartoonPPSpeedMulDown
    /// </summary>
    public unsafe float CartoonPPSpeedMulDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4244); }
    }

    /// <summary>
    /// FloatProperty: CartoonPPSpeedMulUp
    /// </summary>
    public unsafe float CartoonPPSpeedMulUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// FloatProperty: BackScreenTimer
    /// </summary>
    public unsafe float BackScreenTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4252); }
    }

    /// <summary>
    /// FloatProperty: BackScreenPPSpeedMulDown
    /// </summary>
    public unsafe float BackScreenPPSpeedMulDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4256); }
    }

    /// <summary>
    /// FloatProperty: BackScreenPPSpeedMulUp
    /// </summary>
    public unsafe float BackScreenPPSpeedMulUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4260); }
    }

    /// <summary>
    /// FloatProperty: PhotoPPTimer
    /// </summary>
    public unsafe float PhotoPPTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// FloatProperty: FlashPPTimer
    /// </summary>
    public unsafe float FlashPPTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// FloatProperty: HackGrappleEscape
    /// </summary>
    public unsafe float HackGrappleEscape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// FloatProperty: GrappleAimTime
    /// </summary>
    public unsafe float GrappleAimTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4276); }
    }

    /// <summary>
    /// FloatProperty: TimeToWaitForGrappleAim
    /// </summary>
    public unsafe float TimeToWaitForGrappleAim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// InterfaceProperty: InteractableItem
    /// </summary>
    public unsafe BmSDK.BmGame.RInteractInterface InteractableItem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInteractInterface>(Ptr + 4284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4284); }
    }

    /// <summary>
    /// ArrayProperty: GameActionWatchers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_GameActionPerformed> GameActionWatchers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_GameActionPerformed>>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// StructProperty: RunRotation
    /// </summary>
    public unsafe BmSDK.Rotator RunRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// StrProperty: LastRoomNameShown
    /// </summary>
    public unsafe BmSDK.FString LastRoomNameShown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// StrProperty: NextRoomNameToShow
    /// </summary>
    public unsafe BmSDK.FString NextRoomNameToShow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4344); }
    }

    /// <summary>
    /// StrProperty: LastRiddleStringShown
    /// </summary>
    public unsafe BmSDK.FString LastRiddleStringShown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4360); }
    }

    /// <summary>
    /// StrProperty: NextRiddleStringToShow
    /// </summary>
    public unsafe BmSDK.FString NextRiddleStringToShow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4376); }
    }

    /// <summary>
    /// StrProperty: NextRiddleRefName
    /// </summary>
    public unsafe BmSDK.FString NextRiddleRefName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4392); }
    }

    /// <summary>
    /// FloatProperty: ShowRoomNameCountdown
    /// </summary>
    public unsafe float ShowRoomNameCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4408); }
    }

    /// <summary>
    /// StrProperty: FallbackRoomName
    /// </summary>
    public unsafe BmSDK.FString FallbackRoomName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4412); }
    }

    /// <summary>
    /// IntProperty: CurrTakedowns
    /// </summary>
    public unsafe int CurrTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4428); }
    }

    /// <summary>
    /// IntProperty: MaxTakedowns
    /// </summary>
    public unsafe int MaxTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4432); }
    }

    /// <summary>
    /// StructProperty: LastHidePointPerchPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 LastHidePointPerchPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4436); }
    }

    /// <summary>
    /// FloatProperty: NextHideTravelTime
    /// </summary>
    public unsafe float NextHideTravelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }

    /// <summary>
    /// IntProperty: CurrentHideCamIndex
    /// </summary>
    public unsafe int CurrentHideCamIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4452); }
    }

    /// <summary>
    /// FloatProperty: CoverMoveTimer
    /// </summary>
    public unsafe float CoverMoveTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }

    /// <summary>
    /// FloatProperty: DelaySpecialMoves
    /// </summary>
    public unsafe float DelaySpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4460); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideSlideTurn
    /// </summary>
    public unsafe float CapeGlideSlideTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4464); }
    }

    /// <summary>
    /// IntProperty: NumEvidenceInCrimeSceneTotal
    /// </summary>
    public unsafe int NumEvidenceInCrimeSceneTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4468); }
    }

    /// <summary>
    /// IntProperty: NumEvidenceInCrimeSceneCollected
    /// </summary>
    public unsafe int NumEvidenceInCrimeSceneCollected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }

    /// <summary>
    /// StrProperty: CrimeSceneText
    /// </summary>
    public unsafe BmSDK.FString CrimeSceneText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4476); }
    }

    /// <summary>
    /// FloatProperty: ForensicsBloomValue
    /// </summary>
    public unsafe float ForensicsBloomValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4492); }
    }

    /// <summary>
    /// StrProperty: BatmobileCurrentForensicTrail
    /// </summary>
    public unsafe BmSDK.FString BatmobileCurrentForensicTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4496); }
    }

    /// <summary>
    /// FloatProperty: InvestigateOnTime
    /// </summary>
    public unsafe float InvestigateOnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }

    /// <summary>
    /// FloatProperty: MapOpenTime
    /// </summary>
    public unsafe float MapOpenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }

    /// <summary>
    /// FloatProperty: UpgradesOpenTime
    /// </summary>
    public unsafe float UpgradesOpenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4520); }
    }

    /// <summary>
    /// FloatProperty: RiddlerOpenTime
    /// </summary>
    public unsafe float RiddlerOpenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4524); }
    }

    /// <summary>
    /// FloatProperty: BioOpenTime
    /// </summary>
    public unsafe float BioOpenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4528); }
    }

    /// <summary>
    /// FloatProperty: ControlledMoveToOldDist
    /// </summary>
    public unsafe float ControlledMoveToOldDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4532); }
    }

    /// <summary>
    /// FloatProperty: HoldDialogueCameraTime
    /// </summary>
    public unsafe float HoldDialogueCameraTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4536); }
    }

    /// <summary>
    /// IntProperty: framesSinceMatineeHasEnded
    /// </summary>
    public unsafe int framesSinceMatineeHasEnded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4540); }
    }

    /// <summary>
    /// FloatProperty: TimeInDialogueMode
    /// </summary>
    public unsafe float TimeInDialogueMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4544); }
    }

    /// <summary>
    /// StructProperty: CharacterSwitchRot
    /// </summary>
    public unsafe BmSDK.Rotator CharacterSwitchRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 4548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4548); }
    }

    /// <summary>
    /// ArrayProperty: SpecialMoveCameraAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> SpecialMoveCameraAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }

    /// <summary>
    /// NameProperty: BatmobileCustomCamera
    /// </summary>
    public unsafe BmSDK.FName BatmobileCustomCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4576); }
    }

    /// <summary>
    /// StructProperty: AgilitySpecialMoveLocator
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator AgilitySpecialMoveLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 4584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4584); }
    }

    /// <summary>
    /// StructProperty: ClimbDownSpecialMoveLocator
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator ClimbDownSpecialMoveLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 4716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4716); }
    }

    /// <summary>
    /// StructProperty: CoverSpecialMoveLocator
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator CoverSpecialMoveLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 4848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4848); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideTerminalVelocity
    /// </summary>
    public unsafe float CapeGlideTerminalVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4980); }
    }

    /// <summary>
    /// FloatProperty: MaxCapeGlideTerminalVelocity
    /// </summary>
    public unsafe float MaxCapeGlideTerminalVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4984); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideAccelRate
    /// </summary>
    public unsafe float CapeGlideAccelRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4988); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideMaxLevelOffAlt
    /// </summary>
    public unsafe float CapeGlideMaxLevelOffAlt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4992); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideMinLevelOffAlt
    /// </summary>
    public unsafe float CapeGlideMinLevelOffAlt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4996); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideBoostSoundParam
    /// </summary>
    public unsafe float CapeGlideBoostSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5000); }
    }

    /// <summary>
    /// FloatProperty: GlideBoostSoundParamRampUpTime
    /// </summary>
    public unsafe float GlideBoostSoundParamRampUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5004); }
    }

    /// <summary>
    /// IntProperty: BoostGlideMinCameraPitch
    /// </summary>
    public unsafe int BoostGlideMinCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5008); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideCameraTurnSpeed
    /// </summary>
    public unsafe float CapeGlideCameraTurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5012); }
    }

    /// <summary>
    /// FloatProperty: SimpleGlideBoostDelay
    /// </summary>
    public unsafe float SimpleGlideBoostDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5016); }
    }

    /// <summary>
    /// FloatProperty: GadgetsWhileGlidingRange
    /// </summary>
    public unsafe float GadgetsWhileGlidingRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5020); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideCeilingDropRate
    /// </summary>
    public unsafe float CapeGlideCeilingDropRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5024); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideCeilingSpeedFactor
    /// </summary>
    public unsafe float CapeGlideCeilingSpeedFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5028); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideCeiling
    /// </summary>
    public unsafe float CapeGlideCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5032); }
    }

    /// <summary>
    /// FloatProperty: LastDesiredRoll
    /// </summary>
    public unsafe float LastDesiredRoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5036); }
    }

    /// <summary>
    /// FloatProperty: LastDesiredPitch
    /// </summary>
    public unsafe float LastDesiredPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5040); }
    }

    /// <summary>
    /// FloatProperty: AttackButtonPressedTime
    /// </summary>
    public unsafe float AttackButtonPressedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5044); }
    }

    /// <summary>
    /// FloatProperty: TimeForSilentAttack
    /// </summary>
    public unsafe float TimeForSilentAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5048); }
    }

    /// <summary>
    /// StructProperty: GlideRotator
    /// </summary>
    public unsafe BmSDK.Rotator GlideRotator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 5052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5052); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideTurnProp
    /// </summary>
    public unsafe float CapeGlideTurnProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5064); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideRollSpeed
    /// </summary>
    public unsafe float CapeGlideRollSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5068); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideYawRollRate
    /// </summary>
    public unsafe float CapeGlideYawRollRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5072); }
    }

    /// <summary>
    /// IntProperty: CapeGlideMaxPitch
    /// </summary>
    public unsafe int CapeGlideMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5076); }
    }

    /// <summary>
    /// IntProperty: CapeGlideMinPitch
    /// </summary>
    public unsafe int CapeGlideMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5080); }
    }

    /// <summary>
    /// IntProperty: CapeBoostMaxPitch
    /// </summary>
    public unsafe int CapeBoostMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5084); }
    }

    /// <summary>
    /// FloatProperty: CapeGlidePitchRate
    /// </summary>
    public unsafe float CapeGlidePitchRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5088); }
    }

    /// <summary>
    /// FloatProperty: CapeGlidePitchAccel
    /// </summary>
    public unsafe float CapeGlidePitchAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5092); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideMinSpeed
    /// </summary>
    public unsafe float CapeGlideMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5096); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideMaxSpeed
    /// </summary>
    public unsafe float CapeGlideMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5100); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideAccel
    /// </summary>
    public unsafe float CapeGlideAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5104); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideDecel
    /// </summary>
    public unsafe float CapeGlideDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5108); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideQuickAccel
    /// </summary>
    public unsafe float CapeGlideQuickAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5112); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideOverworldMinSpeed
    /// </summary>
    public unsafe float CapeGlideOverworldMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5116); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideMinDipTime
    /// </summary>
    public unsafe float CapeGlideMinDipTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5120); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideMaxDipTime
    /// </summary>
    public unsafe float CapeGlideMaxDipTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5124); }
    }

    /// <summary>
    /// IntProperty: CapeGlideDippedMaxPitch
    /// </summary>
    public unsafe int CapeGlideDippedMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5128); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringMaxPitchVelocityDiff
    /// </summary>
    public unsafe float CapeSoaringMaxPitchVelocityDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5132); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringMaxPitchPower
    /// </summary>
    public unsafe float CapeSoaringMaxPitchPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5136); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringMaxAngle
    /// </summary>
    public unsafe float CapeSoaringMaxAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5140); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringVelocityPower
    /// </summary>
    public unsafe float CapeSoaringVelocityPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5144); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringMinSpeed
    /// </summary>
    public unsafe float CapeSoaringMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5148); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringDecelPower
    /// </summary>
    public unsafe float CapeSoaringDecelPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5152); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringExtraDecel
    /// </summary>
    public unsafe float CapeSoaringExtraDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5156); }
    }

    /// <summary>
    /// FloatProperty: CapeGlidePitchPower
    /// </summary>
    public unsafe float CapeGlidePitchPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5160); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringExtraPullUp
    /// </summary>
    public unsafe float CapeSoaringExtraPullUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5164); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringPullUpAssist
    /// </summary>
    public unsafe float CapeSoaringPullUpAssist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5168); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringPullUpAssistTime
    /// </summary>
    public unsafe float CapeSoaringPullUpAssistTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5172); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideCameraTurnStrength
    /// </summary>
    public unsafe float CapeGlideCameraTurnStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5176); }
    }

    /// <summary>
    /// FloatProperty: BoostGlideAccelModifier
    /// </summary>
    public unsafe float BoostGlideAccelModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5180); }
    }

    /// <summary>
    /// StructProperty: CapeGlidePawnRotError
    /// </summary>
    public unsafe BmSDK.Rotator CapeGlidePawnRotError
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 5184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5184); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideSpeed
    /// </summary>
    public unsafe float CapeGlideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5196); }
    }

    /// <summary>
    /// FloatProperty: CapeGlidePitchSpeed
    /// </summary>
    public unsafe float CapeGlidePitchSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5200); }
    }

    /// <summary>
    /// FloatProperty: NoSpeechIconTimer
    /// </summary>
    public unsafe float NoSpeechIconTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5204); }
    }

    /// <summary>
    /// FloatProperty: DodgeMax
    /// </summary>
    public unsafe float DodgeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5208); }
    }

    /// <summary>
    /// StructProperty: GlideViewModifier
    /// </summary>
    public unsafe BmSDK.Rotator GlideViewModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 5212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5212); }
    }

    /// <summary>
    /// StructProperty: RunDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 RunDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5224); }
    }

    /// <summary>
    /// FloatProperty: CurrentGlidePPStrength
    /// </summary>
    public unsafe float CurrentGlidePPStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5236); }
    }

    /// <summary>
    /// FloatProperty: DesiredGlidePPStrength
    /// </summary>
    public unsafe float DesiredGlidePPStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5240); }
    }

    /// <summary>
    /// FloatProperty: CurrentFearTakedownPostProcessStrength
    /// </summary>
    public unsafe float CurrentFearTakedownPostProcessStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5244); }
    }

    /// <summary>
    /// FloatProperty: DesiredFearTakedownPostProcessStrength
    /// </summary>
    public unsafe float DesiredFearTakedownPostProcessStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5248); }
    }

    /// <summary>
    /// FloatProperty: GlidePPMaxStrength
    /// </summary>
    public unsafe float GlidePPMaxStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5252); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideCameraRotSpeed
    /// </summary>
    public unsafe float CapeGlideCameraRotSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5256); }
    }

    /// <summary>
    /// IntProperty: StationaryCount
    /// </summary>
    public unsafe int StationaryCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5260); }
    }

    /// <summary>
    /// FloatProperty: BestCapeGlideTargetAngle
    /// </summary>
    public unsafe float BestCapeGlideTargetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5264); }
    }

    /// <summary>
    /// IntProperty: CrawlSpaceCount
    /// </summary>
    public unsafe int CrawlSpaceCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5268); }
    }

    /// <summary>
    /// StructProperty: TakedownBarrier
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator TakedownBarrier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 5272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5272); }
    }

    /// <summary>
    /// FloatProperty: AboveTakedownTargetFloor2FloorHeight
    /// </summary>
    public unsafe float AboveTakedownTargetFloor2FloorHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5404); }
    }

    /// <summary>
    /// FloatProperty: AboveTakedownSideDistance
    /// </summary>
    public unsafe float AboveTakedownSideDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5408); }
    }

    /// <summary>
    /// FloatProperty: AboveTakedownExtraCeilingSpace
    /// </summary>
    public unsafe float AboveTakedownExtraCeilingSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5412); }
    }

    /// <summary>
    /// FloatProperty: DropToGrabMaxHeight
    /// </summary>
    public unsafe float DropToGrabMaxHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5416); }
    }

    /// <summary>
    /// FloatProperty: SwingDownFromAboveTakedownMaxHeight
    /// </summary>
    public unsafe float SwingDownFromAboveTakedownMaxHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5420); }
    }

    /// <summary>
    /// FloatProperty: AboveTakedownHorizontalRange
    /// </summary>
    public unsafe float AboveTakedownHorizontalRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5424); }
    }

    /// <summary>
    /// FloatProperty: AboveTakedownHorizontalRange512
    /// </summary>
    public unsafe float AboveTakedownHorizontalRange512
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5428); }
    }

    /// <summary>
    /// StructProperty: AboveTakedownRailingDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 AboveTakedownRailingDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5432); }
    }

    /// <summary>
    /// StructProperty: CatwalkTakedownLocator
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator CatwalkTakedownLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 5444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5444); }
    }

    /// <summary>
    /// StructProperty: PawnVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 PawnVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5576); }
    }

    /// <summary>
    /// StructProperty: LastGoodGrappleLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 LastGoodGrappleLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5588); }
    }

    /// <summary>
    /// StructProperty: GrappleLaunchLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleLaunchLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5600); }
    }

    /// <summary>
    /// FloatProperty: GrapplePullStrength
    /// </summary>
    public unsafe float GrapplePullStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5612); }
    }

    /// <summary>
    /// StructProperty: GrapplePullDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 GrapplePullDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5616); }
    }

    /// <summary>
    /// FloatProperty: GrappleLegPullUpSpeed
    /// </summary>
    public unsafe float GrappleLegPullUpSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5628); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideLeftArmPullIn
    /// </summary>
    public unsafe float CapeGlideLeftArmPullIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5632); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideRightArmPullIn
    /// </summary>
    public unsafe float CapeGlideRightArmPullIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5636); }
    }

    /// <summary>
    /// IntProperty: CapeGlideFromVantagePointPitchOffset
    /// </summary>
    public unsafe int CapeGlideFromVantagePointPitchOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5640); }
    }

    /// <summary>
    /// FloatProperty: GlideBoostRumbleDescentMin
    /// </summary>
    public unsafe float GlideBoostRumbleDescentMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5644); }
    }

    /// <summary>
    /// FloatProperty: GlideBoostRumbleDescentMax
    /// </summary>
    public unsafe float GlideBoostRumbleDescentMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5648); }
    }

    /// <summary>
    /// IntProperty: CapeGlideBoostMaxRumbleLeft
    /// </summary>
    public unsafe int CapeGlideBoostMaxRumbleLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5652); }
    }

    /// <summary>
    /// IntProperty: CapeGlideBoostMaxRumbleRight
    /// </summary>
    public unsafe int CapeGlideBoostMaxRumbleRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5656); }
    }

    /// <summary>
    /// IntProperty: CapeGlideCurrentRumbleLeft
    /// </summary>
    public unsafe int CapeGlideCurrentRumbleLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }

    /// <summary>
    /// IntProperty: CapeGlideCurrentRumbleRight
    /// </summary>
    public unsafe int CapeGlideCurrentRumbleRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5664); }
    }

    /// <summary>
    /// FloatProperty: OldHealthPct
    /// </summary>
    public unsafe float OldHealthPct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5668); }
    }

    /// <summary>
    /// ArrayProperty: InterestingItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerController.FIntItems> InterestingItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerController.FIntItems>>(Ptr + 5672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5672); }
    }

    /// <summary>
    /// StructProperty: LadderTop
    /// </summary>
    public unsafe System.Numerics.Vector3 LadderTop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5688); }
    }

    /// <summary>
    /// FloatProperty: FallingAttackHeight
    /// </summary>
    public unsafe float FallingAttackHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5700); }
    }

    /// <summary>
    /// FloatProperty: CurrentGlideLevelOff
    /// </summary>
    public unsafe float CurrentGlideLevelOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5704); }
    }

    /// <summary>
    /// FloatProperty: DamageEffectTimer
    /// </summary>
    public unsafe float DamageEffectTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5708); }
    }

    /// <summary>
    /// FloatProperty: DamageEffectDropOff
    /// </summary>
    public unsafe float DamageEffectDropOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5712); }
    }

    /// <summary>
    /// FloatProperty: MaxDamageEffectDamage
    /// </summary>
    public unsafe float MaxDamageEffectDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5716); }
    }

    /// <summary>
    /// FloatProperty: DamageEffectDelay
    /// </summary>
    public unsafe float DamageEffectDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5720); }
    }

    /// <summary>
    /// FloatProperty: ShimmyMoveTimer
    /// </summary>
    public unsafe float ShimmyMoveTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5724); }
    }

    /// <summary>
    /// FloatProperty: fJammedDetectiveModeAudioLevel
    /// </summary>
    public unsafe float fJammedDetectiveModeAudioLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5728); }
    }

    /// <summary>
    /// FloatProperty: TimeInRun
    /// </summary>
    public unsafe float TimeInRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5732); }
    }

    /// <summary>
    /// FloatProperty: TimeInCrouch
    /// </summary>
    public unsafe float TimeInCrouch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5736); }
    }

    /// <summary>
    /// ArrayProperty: MovementStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MovementStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 5740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5740); }
    }

    /// <summary>
    /// ArrayProperty: MovementStateSelected
    /// </summary>
    public unsafe BmSDK.TArray<bool> MovementStateSelected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 5756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5756); }
    }

    /// <summary>
    /// ArrayProperty: NPCSpeechBehaviour
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour> NPCSpeechBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour>>(Ptr + 5772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5772); }
    }

    /// <summary>
    /// FloatProperty: MinFallHeight
    /// </summary>
    public unsafe float MinFallHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5788); }
    }

    /// <summary>
    /// IntProperty: AmbRefCounter
    /// </summary>
    public unsafe int AmbRefCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5792); }
    }

    /// <summary>
    /// FloatProperty: lastExitGrateTime
    /// </summary>
    public unsafe float lastExitGrateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5796); }
    }

    /// <summary>
    /// FloatProperty: grateTakedownTimeLimit
    /// </summary>
    public unsafe float grateTakedownTimeLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5800); }
    }

    /// <summary>
    /// StrProperty: deathTip
    /// </summary>
    public unsafe BmSDK.FString deathTip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5804); }
    }

    /// <summary>
    /// StrProperty: deathMovie
    /// </summary>
    public unsafe BmSDK.FString deathMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5820); }
    }

    /// <summary>
    /// FloatProperty: SwingGravity
    /// </summary>
    public unsafe float SwingGravity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5836); }
    }

    /// <summary>
    /// ArrayProperty: CapeTrailBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CapeTrailBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 5840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5840); }
    }

    /// <summary>
    /// ArrayProperty: CapeTrail
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent> CapeTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent>>(Ptr + 5856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5856); }
    }

    /// <summary>
    /// StructProperty: SoftCoverEnvironmentTypes
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveTypesContainer SoftCoverEnvironmentTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveTypesContainer>(Ptr + 5872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5872); }
    }

    /// <summary>
    /// FloatProperty: SoftCoverInDistance
    /// </summary>
    public unsafe float SoftCoverInDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5880); }
    }

    /// <summary>
    /// FloatProperty: SoftCoverOutDistance
    /// </summary>
    public unsafe float SoftCoverOutDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5884); }
    }

    /// <summary>
    /// FloatProperty: TimeInSoftCover
    /// </summary>
    public unsafe float TimeInSoftCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5888); }
    }

    /// <summary>
    /// FloatProperty: TimeToTriggerSoftCover
    /// </summary>
    public unsafe float TimeToTriggerSoftCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5892); }
    }

    /// <summary>
    /// StructProperty: CornerCoverTransitionID
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CornerCoverTransitionID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 5896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5896); }
    }

    /// <summary>
    /// StructProperty: PeerCameraType
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveTypesContainer PeerCameraType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveTypesContainer>(Ptr + 5900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5900); }
    }

    /// <summary>
    /// StructProperty: GlideDiveEdgeType
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveTypesContainer GlideDiveEdgeType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveTypesContainer>(Ptr + 5908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5908); }
    }

    /// <summary>
    /// NameProperty: OverridableTransitionCamera
    /// </summary>
    public unsafe BmSDK.FName OverridableTransitionCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5916); }
    }

    /// <summary>
    /// FloatProperty: CombatCameraScore
    /// </summary>
    public unsafe float CombatCameraScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5924); }
    }

    /// <summary>
    /// FloatProperty: TimeInCapeGlide
    /// </summary>
    public unsafe float TimeInCapeGlide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5928); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideOrientationBlendTime
    /// </summary>
    public unsafe float CapeGlideOrientationBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5932); }
    }

    /// <summary>
    /// IntProperty: CapeGlideProtectionStatus
    /// </summary>
    public unsafe int CapeGlideProtectionStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5936); }
    }

    /// <summary>
    /// IntProperty: MinVantagePointGlidePitch
    /// </summary>
    public unsafe int MinVantagePointGlidePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5940); }
    }

    /// <summary>
    /// IntProperty: FallingRescueVolumeCount
    /// </summary>
    public unsafe int FallingRescueVolumeCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5944); }
    }

    /// <summary>
    /// FloatProperty: KillZoneTimer
    /// </summary>
    public unsafe float KillZoneTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5948); }
    }

    /// <summary>
    /// FloatProperty: QuickFireBatarangTrigger
    /// </summary>
    public unsafe float QuickFireBatarangTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5952); }
    }

    /// <summary>
    /// FloatProperty: QuickGadgetTrigger
    /// </summary>
    public unsafe float QuickGadgetTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5956); }
    }

    /// <summary>
    /// FloatProperty: FallingTime
    /// </summary>
    public unsafe float FallingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5960); }
    }

    /// <summary>
    /// FloatProperty: FallingStartHeight
    /// </summary>
    public unsafe float FallingStartHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5964); }
    }

    /// <summary>
    /// StructProperty: FallingIntoSwingTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId FallingIntoSwingTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 5968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5968); }
    }

    /// <summary>
    /// IntProperty: FallingIntoSwingPhase
    /// </summary>
    public unsafe int FallingIntoSwingPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5972); }
    }

    /// <summary>
    /// StructProperty: AutoAlignDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 AutoAlignDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5976); }
    }

    /// <summary>
    /// ArrayProperty: HangUnfixedBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> HangUnfixedBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 5988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5988); }
    }

    /// <summary>
    /// ArrayProperty: DangleUnfixedBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> DangleUnfixedBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 6004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6004); }
    }

    /// <summary>
    /// StrProperty: MovieDumpPath
    /// </summary>
    public unsafe BmSDK.FString MovieDumpPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6020); }
    }

    /// <summary>
    /// StructProperty: Force1stPersonLookDirection
    /// </summary>
    public unsafe BmSDK.Rotator Force1stPersonLookDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 6036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6036); }
    }

    /// <summary>
    /// StructProperty: Force1stPersonLookDirectionOriginalDirection
    /// </summary>
    public unsafe BmSDK.Rotator Force1stPersonLookDirectionOriginalDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 6048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6048); }
    }

    /// <summary>
    /// FloatProperty: StateTimer
    /// </summary>
    public unsafe float StateTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6060); }
    }

    /// <summary>
    /// NameProperty: OverrideWalkCamera
    /// </summary>
    public unsafe BmSDK.FName OverrideWalkCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6064); }
    }

    /// <summary>
    /// NameProperty: OverrideAllCamera
    /// </summary>
    public unsafe BmSDK.FName OverrideAllCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6072); }
    }

    /// <summary>
    /// NameProperty: OverrideVantageCamera
    /// </summary>
    public unsafe BmSDK.FName OverrideVantageCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6080); }
    }

    /// <summary>
    /// NameProperty: OverrideCoverCamera
    /// </summary>
    public unsafe BmSDK.FName OverrideCoverCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6088); }
    }

    /// <summary>
    /// FloatProperty: BatarangUnequipTime
    /// </summary>
    public unsafe float BatarangUnequipTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6096); }
    }

    /// <summary>
    /// StructProperty: LastGrappleLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastGrappleLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6100); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleLengthThisGrapple
    /// </summary>
    public unsafe float MinGrappleLengthThisGrapple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6112); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleLengthThisGrappleTime
    /// </summary>
    public unsafe float MinGrappleLengthThisGrappleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6116); }
    }

    /// <summary>
    /// ArrayProperty: QuickGrappleSwings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerController.FQuickGrappleSwingContainer> QuickGrappleSwings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerController.FQuickGrappleSwingContainer>>(Ptr + 6120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6120); }
    }

    /// <summary>
    /// FloatProperty: GargoyleEnteredTime
    /// </summary>
    public unsafe float GargoyleEnteredTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6136); }
    }

    /// <summary>
    /// FloatProperty: fMyFadeTimeSec
    /// </summary>
    public unsafe float fMyFadeTimeSec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6140); }
    }

    /// <summary>
    /// StrProperty: missionNameTemp
    /// </summary>
    public unsafe BmSDK.FString missionNameTemp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6144); }
    }

    /// <summary>
    /// StrProperty: LoadingPackageName
    /// </summary>
    public unsafe BmSDK.FString LoadingPackageName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6160); }
    }

    /// <summary>
    /// StrProperty: MissionSound_CachedMission
    /// </summary>
    public unsafe BmSDK.FString MissionSound_CachedMission
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6176); }
    }

    /// <summary>
    /// StrProperty: CurrentHighlightMW
    /// </summary>
    public unsafe BmSDK.FString CurrentHighlightMW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6192); }
    }

    /// <summary>
    /// StrProperty: CurrentHighlightMWCached
    /// </summary>
    public unsafe BmSDK.FString CurrentHighlightMWCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6208); }
    }

    /// <summary>
    /// StrProperty: CurrentHighlightAR
    /// </summary>
    public unsafe BmSDK.FString CurrentHighlightAR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6224); }
    }

    /// <summary>
    /// StrProperty: CurrentHighlightARCached
    /// </summary>
    public unsafe BmSDK.FString CurrentHighlightARCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6240); }
    }

    /// <summary>
    /// StrProperty: CurrentHighlightARType
    /// </summary>
    public unsafe BmSDK.FString CurrentHighlightARType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6256); }
    }

    /// <summary>
    /// StrProperty: CurrentHighlightARTypeCached
    /// </summary>
    public unsafe BmSDK.FString CurrentHighlightARTypeCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6272); }
    }

    /// <summary>
    /// FloatProperty: MostWantedDisplayTime
    /// </summary>
    public unsafe float MostWantedDisplayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6288); }
    }

    /// <summary>
    /// IntProperty: DelayMissionSelectAudioCount
    /// </summary>
    public unsafe int DelayMissionSelectAudioCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6292); }
    }

    /// <summary>
    /// IntProperty: DelayMissionSelectAudioMaxFrames
    /// </summary>
    public unsafe int DelayMissionSelectAudioMaxFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6296); }
    }

    /// <summary>
    /// IntProperty: DelayMissionSelectTurnCount
    /// </summary>
    public unsafe int DelayMissionSelectTurnCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6300); }
    }

    /// <summary>
    /// IntProperty: DelayMissionSelectTurnMaxFrames
    /// </summary>
    public unsafe int DelayMissionSelectTurnMaxFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6304); }
    }

    /// <summary>
    /// IntProperty: DelayMissionSelectObjectiveMessageCount
    /// </summary>
    public unsafe int DelayMissionSelectObjectiveMessageCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6308); }
    }

    /// <summary>
    /// IntProperty: DelayMissionSelectObjectiveMessageMaxFrames
    /// </summary>
    public unsafe int DelayMissionSelectObjectiveMessageMaxFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6312); }
    }

    /// <summary>
    /// FloatProperty: LowUrgencyOpenWheelLogicTimer
    /// </summary>
    public unsafe float LowUrgencyOpenWheelLogicTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6316); }
    }

    /// <summary>
    /// StrProperty: MissionSound_Param_Mission
    /// </summary>
    public unsafe BmSDK.FString MissionSound_Param_Mission
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6320); }
    }

    /// <summary>
    /// StrProperty: MissionSound_Param_SpecialCase
    /// </summary>
    public unsafe BmSDK.FString MissionSound_Param_SpecialCase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6336); }
    }

    /// <summary>
    /// StrProperty: MissionSound_ReturnValue_AudioRef
    /// </summary>
    public unsafe BmSDK.FString MissionSound_ReturnValue_AudioRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6352); }
    }

    /// <summary>
    /// StructProperty: GlideStartLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GlideStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6368); }
    }

    /// <summary>
    /// FloatProperty: GlideStartTime
    /// </summary>
    public unsafe float GlideStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6380); }
    }

    /// <summary>
    /// StructProperty: GlideOverWaterStartLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GlideOverWaterStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6384); }
    }

    /// <summary>
    /// FloatProperty: DiveStartHeight
    /// </summary>
    public unsafe float DiveStartHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6396); }
    }

    /// <summary>
    /// StructProperty: WalkStartLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 WalkStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6400); }
    }

    /// <summary>
    /// StructProperty: CoverTurnTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CoverTurnTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 6412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6412); }
    }

    /// <summary>
    /// StructProperty: FallingPose
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId FallingPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 6416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6416); }
    }

    /// <summary>
    /// FloatProperty: LastTimeOutOfGrate
    /// </summary>
    public unsafe float LastTimeOutOfGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6420); }
    }

    /// <summary>
    /// IntProperty: NumKilledByBatclaw
    /// </summary>
    public unsafe int NumKilledByBatclaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6424); }
    }

    /// <summary>
    /// FloatProperty: LastBatclawKillTime
    /// </summary>
    public unsafe float LastBatclawKillTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6428); }
    }

    /// <summary>
    /// FloatProperty: TunnelSpeed
    /// </summary>
    public unsafe float TunnelSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6432); }
    }

    /// <summary>
    /// StructProperty: SaveGameLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 SaveGameLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6436); }
    }

    /// <summary>
    /// StructProperty: SaveGameRotation
    /// </summary>
    public unsafe BmSDK.Rotator SaveGameRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 6448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6448); }
    }

    /// <summary>
    /// FloatProperty: SaveGameSetTime
    /// </summary>
    public unsafe float SaveGameSetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6460); }
    }

    /// <summary>
    /// StructProperty: SavedMovementRequestDir
    /// </summary>
    public unsafe System.Numerics.Vector3 SavedMovementRequestDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6464); }
    }

    /// <summary>
    /// StructProperty: LastTakedownLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastTakedownLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6476); }
    }

    /// <summary>
    /// StructProperty: LastTakedownRotation
    /// </summary>
    public unsafe BmSDK.Rotator LastTakedownRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 6488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6488); }
    }

    /// <summary>
    /// IntProperty: LastTakedownRandomChoice
    /// </summary>
    public unsafe int LastTakedownRandomChoice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6500); }
    }

    /// <summary>
    /// IntProperty: ForceSilentTakedownIndex
    /// </summary>
    public unsafe int ForceSilentTakedownIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6504); }
    }

    /// <summary>
    /// StructProperty: InitialGrapplePos
    /// </summary>
    public unsafe System.Numerics.Vector3 InitialGrapplePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6508); }
    }

    /// <summary>
    /// FloatProperty: GadgetUsedRecentlyTime
    /// </summary>
    public unsafe float GadgetUsedRecentlyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6520); }
    }

    /// <summary>
    /// FloatProperty: GrappleUsedRecentlyTime
    /// </summary>
    public unsafe float GrappleUsedRecentlyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6524); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostBonus
    /// </summary>
    public unsafe float GrappleBoostBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6528); }
    }

    /// <summary>
    /// FloatProperty: ActualGrappleBoostBonus
    /// </summary>
    public unsafe float ActualGrappleBoostBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6532); }
    }

    /// <summary>
    /// FloatProperty: PoisonRate
    /// </summary>
    public unsafe float PoisonRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6536); }
    }

    /// <summary>
    /// FloatProperty: PoisonDamage
    /// </summary>
    public unsafe float PoisonDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6540); }
    }

    /// <summary>
    /// FloatProperty: PoisonKORegainAmount
    /// </summary>
    public unsafe float PoisonKORegainAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6544); }
    }

    /// <summary>
    /// StructProperty: NPCAvoidanceNPCDir
    /// </summary>
    public unsafe System.Numerics.Vector3 NPCAvoidanceNPCDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6548); }
    }

    /// <summary>
    /// StructProperty: NPCAvoidancePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 NPCAvoidancePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6560); }
    }

    /// <summary>
    /// FloatProperty: InitialTargetLockOnSpeed
    /// </summary>
    public unsafe float InitialTargetLockOnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6572); }
    }

    /// <summary>
    /// FloatProperty: AdditionalTargetLockOnSpeed
    /// </summary>
    public unsafe float AdditionalTargetLockOnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6576); }
    }

    /// <summary>
    /// IntProperty: MaxSuperGlideAttackTargets
    /// </summary>
    public unsafe int MaxSuperGlideAttackTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6580); }
    }

    /// <summary>
    /// FloatProperty: SuperGlideAttackWidth
    /// </summary>
    public unsafe float SuperGlideAttackWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6584); }
    }

    /// <summary>
    /// FloatProperty: SuperGlideAttackLength
    /// </summary>
    public unsafe float SuperGlideAttackLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6588); }
    }

    /// <summary>
    /// ArrayProperty: SuperGlideAttackTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> SuperGlideAttackTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 6592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6592); }
    }

    /// <summary>
    /// IntProperty: CurrentSuperGlideTarget
    /// </summary>
    public unsafe int CurrentSuperGlideTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6608); }
    }

    /// <summary>
    /// FloatProperty: CurrentSuperGlideBuildUpTime
    /// </summary>
    public unsafe float CurrentSuperGlideBuildUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6612); }
    }

    /// <summary>
    /// FloatProperty: SpeedMutatorSpeedScale
    /// </summary>
    public unsafe float SpeedMutatorSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6616); }
    }

    /// <summary>
    /// StructProperty: LastLookAround
    /// </summary>
    public unsafe BmSDK.Rotator LastLookAround
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 6620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6620); }
    }

    /// <summary>
    /// FloatProperty: CurrentLookAroundBlendTime
    /// </summary>
    public unsafe float CurrentLookAroundBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6632); }
    }

    /// <summary>
    /// FloatProperty: RunCameraDuration
    /// </summary>
    public unsafe float RunCameraDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6636); }
    }

    /// <summary>
    /// FloatProperty: RunCameraTimer
    /// </summary>
    public unsafe float RunCameraTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6640); }
    }

    /// <summary>
    /// IntProperty: KeyboardQuickGadget
    /// </summary>
    public unsafe int KeyboardQuickGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6644); }
    }

    /// <summary>
    /// IntProperty: KeyboardSuperQuickGadget
    /// </summary>
    public unsafe int KeyboardSuperQuickGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6648); }
    }

    /// <summary>
    /// StructProperty: ForceBatmobileCallLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 ForceBatmobileCallLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6652); }
    }

    /// <summary>
    /// FloatProperty: BatmobileRescueFadeUpDelay
    /// </summary>
    public unsafe float BatmobileRescueFadeUpDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6664); }
    }

    /// <summary>
    /// ArrayProperty: StopGadgetActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_StopPlayerUsingGadgets> StopGadgetActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_StopPlayerUsingGadgets>>(Ptr + 6668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6668); }
    }

    /// <summary>
    /// ArrayProperty: MoveStrings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerController.FMoveNameString> MoveStrings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerController.FMoveNameString>>(Ptr + 6684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6684); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileKillStrings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerController.FBatmobileChallengeKillString> BatmobileKillStrings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerController.FBatmobileChallengeKillString>>(Ptr + 6700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6700); }
    }

    /// <summary>
    /// FloatProperty: SavedBoostHeight
    /// </summary>
    public unsafe float SavedBoostHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6716); }
    }

    /// <summary>
    /// IntProperty: RiddlerProgressTotal
    /// </summary>
    public unsafe int RiddlerProgressTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }

    /// <summary>
    /// IntProperty: RiddlerProgressLeft
    /// </summary>
    public unsafe int RiddlerProgressLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6724); }
    }

    /// <summary>
    /// FloatProperty: InterrogationCloseRange
    /// </summary>
    public unsafe float InterrogationCloseRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6728); }
    }

    /// <summary>
    /// FloatProperty: InterrogationCloseRangeDownTolerance
    /// </summary>
    public unsafe float InterrogationCloseRangeDownTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6732); }
    }

    /// <summary>
    /// FloatProperty: InterrogationCloseRangeUpTolerance
    /// </summary>
    public unsafe float InterrogationCloseRangeUpTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6736); }
    }

    /// <summary>
    /// FloatProperty: InterrogationCombatThugsCheckRange
    /// </summary>
    public unsafe float InterrogationCombatThugsCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6740); }
    }

    /// <summary>
    /// FloatProperty: LastInterrogationCheckFrame
    /// </summary>
    public unsafe float LastInterrogationCheckFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6744); }
    }

    /// <summary>
    /// IntProperty: SafeInterrogationFramesInARow
    /// </summary>
    public unsafe int SafeInterrogationFramesInARow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6748); }
    }

    /// <summary>
    /// ArrayProperty: GadgetFlagsForAchievement
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> GadgetFlagsForAchievement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 6752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6752); }
    }

    /// <summary>
    /// FloatProperty: DotProdForInterrogateTutorialNew
    /// </summary>
    public unsafe float DotProdForInterrogateTutorialNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6768); }
    }

    /// <summary>
    /// FloatProperty: DotProdForInterrogateTutorialAlreadySeen
    /// </summary>
    public unsafe float DotProdForInterrogateTutorialAlreadySeen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6772); }
    }

    /// <summary>
    /// FloatProperty: DistForInterrogateTutorialNew
    /// </summary>
    public unsafe float DistForInterrogateTutorialNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6776); }
    }

    /// <summary>
    /// FloatProperty: DistForInterrogateTutorialAlreadySeen
    /// </summary>
    public unsafe float DistForInterrogateTutorialAlreadySeen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6780); }
    }

    /// <summary>
    /// FloatProperty: DotProdForInterrogateTutorialNewZoomed
    /// </summary>
    public unsafe float DotProdForInterrogateTutorialNewZoomed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6784); }
    }

    /// <summary>
    /// FloatProperty: DotProdForInterrogateTutorialAlreadySeenZoomed
    /// </summary>
    public unsafe float DotProdForInterrogateTutorialAlreadySeenZoomed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6788); }
    }

    /// <summary>
    /// FloatProperty: DistForInterrogateTutorialNewZoomed
    /// </summary>
    public unsafe float DistForInterrogateTutorialNewZoomed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6792); }
    }

    /// <summary>
    /// FloatProperty: DistForInterrogateTutorialAlreadySeenZoomed
    /// </summary>
    public unsafe float DistForInterrogateTutorialAlreadySeenZoomed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6796); }
    }

    /// <summary>
    /// ArrayProperty: ValidGrappleBoostDir
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> ValidGrappleBoostDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 6800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6800); }
    }

    /// <summary>
    /// ArrayProperty: ValidGrappleBoostDirIsReverse
    /// </summary>
    public unsafe BmSDK.TArray<int> ValidGrappleBoostDirIsReverse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 6816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6816); }
    }

    /// <summary>
    /// ArrayProperty: CheatCodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerController.FCheatCode> CheatCodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerController.FCheatCode>>(Ptr + 6832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6832); }
    }

    /// <summary>
    /// StructProperty: AffectPlayerInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RAffectPlayerVolume.FAffectPlayerVolumeInfo AffectPlayerInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAffectPlayerVolume.FAffectPlayerVolumeInfo>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// FloatProperty: PursuitModeCameraLockTime
    /// </summary>
    public unsafe float PursuitModeCameraLockTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6860); }
    }

    /// <summary>
    /// FloatProperty: MinSlipForDrivingRumble
    /// </summary>
    public unsafe float MinSlipForDrivingRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6864); }
    }

    /// <summary>
    /// FloatProperty: MaxSlipForDrivingRumble
    /// </summary>
    public unsafe float MaxSlipForDrivingRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6868); }
    }

    /// <summary>
    /// FloatProperty: DrivingSlipRumblePower
    /// </summary>
    public unsafe float DrivingSlipRumblePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6872); }
    }

    /// <summary>
    /// FloatProperty: LastAccelAmount
    /// </summary>
    public unsafe float LastAccelAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6876); }
    }

    /// <summary>
    /// FloatProperty: LastSteerAmount
    /// </summary>
    public unsafe float LastSteerAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6880); }
    }

    /// <summary>
    /// FloatProperty: MaxDriveSpeed
    /// </summary>
    public unsafe float MaxDriveSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6884); }
    }

    /// <summary>
    /// StructProperty: DrivingCantMoveDir
    /// </summary>
    public unsafe System.Numerics.Vector3 DrivingCantMoveDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6888); }
    }

    /// <summary>
    /// StructProperty: BattleModeCantMoveSideways
    /// </summary>
    public unsafe System.Numerics.Vector3 BattleModeCantMoveSideways
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6900); }
    }

    /// <summary>
    /// StructProperty: BattleModeCantMoveForwards
    /// </summary>
    public unsafe System.Numerics.Vector3 BattleModeCantMoveForwards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6912); }
    }

    /// <summary>
    /// StructProperty: DrivingCantMoveDirPrev
    /// </summary>
    public unsafe System.Numerics.Vector3 DrivingCantMoveDirPrev
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6924); }
    }

    /// <summary>
    /// FloatProperty: DrivingModeTimeRemoteBatmobileOutOfRange
    /// </summary>
    public unsafe float DrivingModeTimeRemoteBatmobileOutOfRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6936); }
    }

    /// <summary>
    /// FloatProperty: DrivingModeThrottle
    /// </summary>
    public unsafe float DrivingModeThrottle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6940); }
    }

    /// <summary>
    /// FloatProperty: BoostingTime
    /// </summary>
    public unsafe float BoostingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6944); }
    }

    /// <summary>
    /// FloatProperty: DriftingTime
    /// </summary>
    public unsafe float DriftingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6948); }
    }

    /// <summary>
    /// FloatProperty: HandbrakingTime
    /// </summary>
    public unsafe float HandbrakingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6952); }
    }

    /// <summary>
    /// FloatProperty: StunnedTime
    /// </summary>
    public unsafe float StunnedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6956); }
    }

    /// <summary>
    /// FloatProperty: ZappedTime
    /// </summary>
    public unsafe float ZappedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6960); }
    }

    /// <summary>
    /// FloatProperty: LaseredTime
    /// </summary>
    public unsafe float LaseredTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6964); }
    }

    /// <summary>
    /// FloatProperty: fCurrentTunnelNetworkHighlightAlpha
    /// </summary>
    public unsafe float fCurrentTunnelNetworkHighlightAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6968); }
    }

    /// <summary>
    /// NameProperty: radioPoseName
    /// </summary>
    public unsafe BmSDK.FName radioPoseName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6972); }
    }

    /// <summary>
    /// ArrayProperty: GlideGadgetTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.FGlideGadgetTargetContainer> GlideGadgetTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.FGlideGadgetTargetContainer>>(Ptr + 6980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6980); }
    }

    /// <summary>
    /// NameProperty: BufferedFearTakedownState
    /// </summary>
    public unsafe BmSDK.FName BufferedFearTakedownState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6996); }
    }

    /// <summary>
    /// StructProperty: BufferedFearTakedownInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FPlayerTakedownInfo BufferedFearTakedownInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FPlayerTakedownInfo>(Ptr + 7004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7004); }
    }

    /// <summary>
    /// IntProperty: CurrentFearTakedownBtn
    /// </summary>
    public unsafe int CurrentFearTakedownBtn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7032); }
    }

    /// <summary>
    /// FloatProperty: ChainTakedownRange
    /// </summary>
    public unsafe float ChainTakedownRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7036); }
    }

    /// <summary>
    /// IntProperty: iMaximumNumberOfFearTakedowns
    /// </summary>
    public unsafe int iMaximumNumberOfFearTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7040); }
    }

    /// <summary>
    /// IntProperty: iNumberOfRemainingFearTakedowns
    /// </summary>
    public unsafe int iNumberOfRemainingFearTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7044); }
    }

    /// <summary>
    /// ArrayProperty: CurrentlyHighlightedFearTakedownTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerController.FFearTakedownHightlightInfo> CurrentlyHighlightedFearTakedownTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerController.FFearTakedownHightlightInfo>>(Ptr + 7048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7048); }
    }

    /// <summary>
    /// ArrayProperty: FearTakedownTargetHighlightBeams
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent> FearTakedownTargetHighlightBeams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent>>(Ptr + 7064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7064); }
    }

    /// <summary>
    /// ArrayProperty: TrackedRadarActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> TrackedRadarActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 7080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7080); }
    }

    /// <summary>
    /// ArrayProperty: ExtraRadarActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ExtraRadarActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 7096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7096); }
    }

    /// <summary>
    /// FloatProperty: HeavyTankRadarRange
    /// </summary>
    public unsafe float HeavyTankRadarRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7112); }
    }

    /// <summary>
    /// ArrayProperty: BattleModeWeaponSelectButtons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerController.FBattleModeWeaponButton> BattleModeWeaponSelectButtons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerController.FBattleModeWeaponButton>>(Ptr + 7116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7116); }
    }

    /// <summary>
    /// StructProperty: BattleModeWeaponSelectOrigin
    /// </summary>
    public unsafe System.Numerics.Vector2 BattleModeWeaponSelectOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 7132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7132); }
    }

    /// <summary>
    /// FloatProperty: BattleModeWeaponSelectSize
    /// </summary>
    public unsafe float BattleModeWeaponSelectSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7140); }
    }

    /// <summary>
    /// FloatProperty: BattleModeWeaponSelectButtonSize
    /// </summary>
    public unsafe float BattleModeWeaponSelectButtonSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7144); }
    }

    /// <summary>
    /// NameProperty: RadioModeFromState
    /// </summary>
    public unsafe BmSDK.FName RadioModeFromState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7148); }
    }

    /// <summary>
    /// StructProperty: RadioModeInitialCameraRot
    /// </summary>
    public unsafe BmSDK.Rotator RadioModeInitialCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 7156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7156); }
    }

    /// <summary>
    /// IntProperty: NumBatmobileMissileHits
    /// </summary>
    public unsafe int NumBatmobileMissileHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7168); }
    }

    /// <summary>
    /// IntProperty: NumBatmobileCannonHits
    /// </summary>
    public unsafe int NumBatmobileCannonHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7172); }
    }

    /// <summary>
    /// FloatProperty: LocalCharacterLightBrightnesFactor
    /// </summary>
    public unsafe float LocalCharacterLightBrightnesFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7176); }
    }

    /// <summary>
    /// FloatProperty: LocalCharacterLightDesredBrightness
    /// </summary>
    public unsafe float LocalCharacterLightDesredBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7180); }
    }

    /// <summary>
    /// FloatProperty: lastShotByWatchtowerTime
    /// </summary>
    public unsafe float lastShotByWatchtowerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7184); }
    }

    /// <summary>
    /// FloatProperty: LastEjectFromBatmobileTime
    /// </summary>
    public unsafe float LastEjectFromBatmobileTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7188); }
    }

    /// <summary>
    /// FloatProperty: RCBatmanFallingTime
    /// </summary>
    public unsafe float RCBatmanFallingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7192); }
    }

    /// <summary>
    /// ArrayProperty: ChildStateCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerController.FChildStateCacheElement> ChildStateCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerController.FChildStateCacheElement>>(Ptr + 7196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7196); }
    }

    /// <summary>
    /// IntProperty: MaxNumberofGlidingGadgets
    /// </summary>
    public unsafe int MaxNumberofGlidingGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7212); }
    }

    /// <summary>
    /// ArrayProperty: QuickFireGadgetTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> QuickFireGadgetTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 7216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7216); }
    }

    /// <summary>
    /// FloatProperty: LastTriggerAmount
    /// </summary>
    public unsafe float LastTriggerAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7232); }
    }

    /// <summary>
    /// StructProperty: RailingTurnTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId RailingTurnTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 7236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7236); }
    }

    /// <summary>
    /// IntProperty: NumTakedownsInThisFearTakedown
    /// </summary>
    public unsafe int NumTakedownsInThisFearTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7240); }
    }

    /// <summary>
    /// IntProperty: SpottedSlowMoId
    /// </summary>
    public unsafe int SpottedSlowMoId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7244); }
    }

    /// <summary>
    /// FloatProperty: MedEjectGlideAttackHeight
    /// </summary>
    public unsafe float MedEjectGlideAttackHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7248); }
    }

    /// <summary>
    /// FloatProperty: MaxEjectGlideAttackHeight
    /// </summary>
    public unsafe float MaxEjectGlideAttackHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7252); }
    }

    /// <summary>
    /// FloatProperty: AchievementSkimmingDistance
    /// </summary>
    public unsafe float AchievementSkimmingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7256); }
    }

    /// <summary>
    /// ArrayProperty: BridgeVolumesHit
    /// </summary>
    public unsafe BmSDK.TArray<byte> BridgeVolumesHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 7260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7260); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostCameraLagTime
    /// </summary>
    public unsafe float GrappleBoostCameraLagTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7276); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostCameraLagExtraTime
    /// </summary>
    public unsafe float GrappleBoostCameraLagExtraTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7280); }
    }

    /// <summary>
    /// StructProperty: BatmobileUnderAttackSound
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.FAkSoundHandle BatmobileUnderAttackSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 7284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7284); }
    }

    /// <summary>
    /// StrProperty: sForensicsRootNetworkString
    /// </summary>
    public unsafe BmSDK.FString sForensicsRootNetworkString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 7300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7300); }
    }

    /// <summary>
    /// ObjectProperty: PhotoModeOverlay
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI_PhotoModeOverlay PhotoModeOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI_PhotoModeOverlay>(Ptr + 7316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7316); }
    }

    /// <summary>
    /// StrProperty: CurrentHighlightMW_DLC
    /// </summary>
    public unsafe BmSDK.FString CurrentHighlightMW_DLC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 7324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7324); }
    }

    /// <summary>
    /// StrProperty: CurrentHighlightMW_DLCChached
    /// </summary>
    public unsafe BmSDK.FString CurrentHighlightMW_DLCChached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 7340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7340); }
    }

    /// <summary>
    /// StrProperty: CurrentHighlightMWType
    /// </summary>
    public unsafe BmSDK.FString CurrentHighlightMWType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 7356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7356); }
    }

    /// <summary>
    /// StrProperty: CurrentHighlightMWTypeCached
    /// </summary>
    public unsafe BmSDK.FString CurrentHighlightMWTypeCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 7372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7372); }
    }

    /// <summary>
    /// IntProperty: SelectedGadgetIndex
    /// </summary>
    public unsafe int SelectedGadgetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7388); }
    }

    /// <summary>
    /// ObjectProperty: StopAutomaticDetectiveModeSequenceAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_StopSmokeBombFromAutomaticallyTurningDetectiveModeOn StopAutomaticDetectiveModeSequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_StopSmokeBombFromAutomaticallyTurningDetectiveModeOn>(Ptr + 7392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7392); }
    }

    /// <summary>
    /// ObjectProperty: StatsReadMyRankObject
    /// </summary>
    public unsafe BmSDK.BmGame.ROnlineStatsRead StatsReadMyRankObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.ROnlineStatsRead>(Ptr + 7400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7400); }
    }

    /// <summary>
    /// DelegateProperty: __MostWantedSortById__Delegate
    /// </summary>
    public unsafe System.IntPtr __MostWantedSortById__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 7408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7408); }
    }

    /// <summary>
    /// DelegateProperty: __SortByMissionId__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByMissionId__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 7424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7424); }
    }

    /// <summary>
    /// Enum: EVehicleCombatMedals
    /// </summary>
    public enum EVehicleCombatMedals
    {
        EMedal_A = 0,
        EMedal_B = 1,
        EMedal_C = 2,
        EMedal_D = 3,
        EMedal_E = 4,
        EMedal_MAX = 5,
    }

    /// <summary>
    /// Enum: EGlideAttackTargettingType
    /// </summary>
    public enum EGlideAttackTargettingType
    {
        GATT_GlideAndDropAttack = 0,
        GATT_GlideAttackOnly = 1,
        GATT_DropAttackOnly = 2,
        GATT_CatwomanPounceAttack = 3,
        GATT_MAX = 4,
    }

    /// <summary>
    /// Enum: EPCCheckFrame
    /// </summary>
    public enum EPCCheckFrame
    {
        PCCF_InteractableItemFrame = 0,
        PCCF_StealthAttackTargetFrame = 1,
        PCCF_PCCheckFrameMAX = 2,
        PCCF_MAX = 3,
    }

    /// <summary>
    /// Enum: JumpSpaceResult
    /// </summary>
    public enum JumpSpaceResult
    {
        JSR_NoSpace = 0,
        JSR_NoGlide = 1,
        JSR_BlockedByNoGlideVolume = 2,
        JSR_OK = 3,
        JSR_MAX = 4,
    }

    /// <summary>
    /// Enum: MapKeyType
    /// </summary>
    public enum MapKeyType
    {
        MK_Upgrades = 0,
        MK_Map = 1,
        MK_Riddler = 2,
        MK_Bio = 3,
        MK_Enygma = 4,
        MK_Predator = 5,
        MK_Default = 6,
        MK_MAX = 7,
    }

    /// <summary>
    /// Enum: StealthAttackType
    /// </summary>
    public enum StealthAttackType
    {
        SAT_SilentTakedown = 0,
        SAT_FearTakedown = 1,
        SAT_MAX = 2,
    }

    /// <summary>
    /// Struct: FUnlockableDefinition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FUnlockableDefinition
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Level
        /// </summary>
        public unsafe int Level
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bSecret
        /// </summary>
        public unsafe bool bSecret
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }

        /// <summary>
        /// StrProperty: NeedsFlagSet
        /// </summary>
        public unsafe BmSDK.FString NeedsFlagSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }
}
