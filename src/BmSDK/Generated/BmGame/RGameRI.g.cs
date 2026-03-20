#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameRI<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGameRI : BmSDK.Engine.GameReplicationInfo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameRI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGameRI() { }

    /// <summary>
    /// Constructs a new RGameRI
    /// </summary>
    public RGameRI(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGameRI Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameRI(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameRI>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameRI>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameRI>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameRI>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameRI>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameRI>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameRI>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ByteProperty: GameStatus
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EGameStatus GameStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EGameStatus>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ByteProperty: ChallengeStatus
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EChallengeFlow ChallengeStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EChallengeFlow>(Ptr + 793); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 793); }
    }

    /// <summary>
    /// ByteProperty: GameMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameModes GameMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameModes>(Ptr + 794); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 794); }
    }

    /// <summary>
    /// ByteProperty: ActiveModifiers
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeModifierType ActiveModifiers_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeModifierType>(Ptr + 795); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 795); }
    }
    /// <summary>
    /// ByteProperty: ActiveModifiers
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeModifierType ActiveModifiers_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeModifierType>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }
    /// <summary>
    /// ByteProperty: ActiveModifiers
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeModifierType ActiveModifiers_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeModifierType>(Ptr + 797); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 797); }
    }
    /// <summary>
    /// ByteProperty: ActiveModifiers
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeModifierType ActiveModifiers_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeModifierType>(Ptr + 798); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 798); }
    }
    /// <summary>
    /// ByteProperty: ActiveModifiers
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeModifierType ActiveModifiers_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeModifierType>(Ptr + 799); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 799); }
    }
    /// <summary>
    /// ByteProperty: ActiveModifiers
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeModifierType ActiveModifiers_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeModifierType>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
    /// <summary>
    /// ByteProperty: ActiveModifiers
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeModifierType ActiveModifiers_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeModifierType>(Ptr + 801); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 801); }
    }
    /// <summary>
    /// ByteProperty: ActiveModifiers
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeModifierType ActiveModifiers_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeModifierType>(Ptr + 802); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 802); }
    }

    /// <summary>
    /// ByteProperty: GlobalDoorLockType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.ECombatLockType GlobalDoorLockType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ECombatLockType>(Ptr + 803); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 803); }
    }

    /// <summary>
    /// ByteProperty: CurrentCombatCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.GameCombatCameraType CurrentCombatCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.GameCombatCameraType>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ByteProperty: DetectiveModeJammed
    /// </summary>
    public unsafe byte DetectiveModeJammed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 805); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 805); }
    }

    /// <summary>
    /// ByteProperty: MultiPlayerGameType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EMultiPlayerGameType MultiPlayerGameType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EMultiPlayerGameType>(Ptr + 806); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 806); }
    }

    /// <summary>
    /// IntProperty: ChallengeID
    /// </summary>
    public unsafe int ChallengeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: FlagManager
    /// </summary>
    public unsafe BmSDK.BmGame.RFlagManager FlagManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFlagManager>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: LevelVolumeToTriggerOnOverrideClear
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelVolume LevelVolumeToTriggerOnOverrideClear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelVolume>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLevelVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelVolume CurrentLevelVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelVolume>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: PendingPredictedLevelVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelVolume PendingPredictedLevelVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelVolume>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: PredictedLevelVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelVolume PredictedLevelVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelVolume>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: UnpredictedLevelVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelVolume UnpredictedLevelVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelVolume>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: CurrentRCBatarangProjectile
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentRCBatarangProjectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: FadeManager
    /// </summary>
    public unsafe BmSDK.BmGame.RFadeManager FadeManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFadeManager>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: PersistentOptions
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions PersistentOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: SaveGameManager
    /// </summary>
    public unsafe BmSDK.BmGame.RSaveGameManager SaveGameManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSaveGameManager>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: FrontMostMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieFrontMost FrontMostMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieFrontMost>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: FrontendBGFader
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieFrontendBGFader FrontendBGFader
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieFrontendBGFader>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: NoController
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieNoController NoController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieNoController>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: StopDialogueEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StopDialogueEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: NavigationManager
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationManager NavigationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationManager>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ArrayProperty: WindVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RWindVolume> WindVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RWindVolume>>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ArrayProperty: ParticleKillVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RParticleKillVolume> ParticleKillVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RParticleKillVolume>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// StrProperty: CurrentAreaOverride
    /// </summary>
    public unsafe BmSDK.FString CurrentAreaOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: PendingPredictedTime
    /// </summary>
    public unsafe float PendingPredictedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// NameProperty: CurrentLevel
    /// </summary>
    public unsafe BmSDK.FName CurrentLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StrProperty: CurrentLevelAsString
    /// </summary>
    public unsafe BmSDK.FString CurrentLevelAsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// NameProperty: CurrentRCBatarangLevel
    /// </summary>
    public unsafe BmSDK.FName CurrentRCBatarangLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// NameProperty: PreviousLevelToKeepVisibleForOneFrame
    /// </summary>
    public unsafe BmSDK.FName PreviousLevelToKeepVisibleForOneFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ArrayProperty: LevelVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelVolume> LevelVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelVolume>>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// IntProperty: ConsecutiveFailedRoadNetworkChecks
    /// </summary>
    public unsafe int ConsecutiveFailedRoadNetworkChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ArrayProperty: CineLevelsToLoadOutsideOfCurrentLevel
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CineLevelsToLoadOutsideOfCurrentLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ArrayProperty: CineLevelsStartingInBatmobile
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CineLevelsStartingInBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: FadingOutToRestart
    /// </summary>
    public unsafe bool FadingOutToRestart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: LevelStreamingLocked
    /// </summary>
    public unsafe bool LevelStreamingLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: LevelStreamingInitialising
    /// </summary>
    public unsafe bool LevelStreamingInitialising
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: MakeLevelsVisibleOnLoad
    /// </summary>
    public unsafe bool MakeLevelsVisibleOnLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: GlobalDoorLock
    /// </summary>
    public unsafe bool GlobalDoorLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: LevelStreamingLockedMakeLODsVisibleImmediately
    /// </summary>
    public unsafe bool LevelStreamingLockedMakeLODsVisibleImmediately
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bChallengeFromFrontend
    /// </summary>
    public unsafe bool bChallengeFromFrontend
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bLockoutSilentTakedownsDueToAttack
    /// </summary>
    public unsafe bool bLockoutSilentTakedownsDueToAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanInCombat
    /// </summary>
    public unsafe bool bBatmanInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanEngagedInCombat
    /// </summary>
    public unsafe bool bBatmanEngagedInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bRidingVenom
    /// </summary>
    public unsafe bool bRidingVenom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileInCombat
    /// </summary>
    public unsafe bool bBatmobileInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileInBattleMode
    /// </summary>
    public unsafe bool bBatmobileInBattleMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bOneShotPerFrame
    /// </summary>
    public unsafe bool bOneShotPerFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bSomeoneHasFiredThisFrame
    /// </summary>
    public unsafe bool bSomeoneHasFiredThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bSearchWidthCheckedThisFrame
    /// </summary>
    public unsafe bool bSearchWidthCheckedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bIsNightwing
    /// </summary>
    public unsafe bool bIsNightwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: PlayerCharactersLoading
    /// </summary>
    public unsafe bool PlayerCharactersLoading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: PlayerBatmobilesLoading
    /// </summary>
    public unsafe bool PlayerBatmobilesLoading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// IntProperty: ObjectiveMarkerUniqueIdentifierCount
    /// </summary>
    public unsafe int ObjectiveMarkerUniqueIdentifierCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: StreamingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameRI.FStreamingLevelInfo> StreamingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameRI.FStreamingLevelInfo>>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ArrayProperty: StreamingLevelsLODs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameRI.FStreamingLevelInfo> StreamingLevelsLODs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameRI.FStreamingLevelInfo>>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ArrayProperty: StreamingPMaps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameRI.FStreamingPMapInfo> StreamingPMaps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameRI.FStreamingPMapInfo>>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// StructProperty: GlobalPMap
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FStreamingPMapInfo GlobalPMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FStreamingPMapInfo>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// StructProperty: StreamingLOD2s
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FStreamingLOD2Info StreamingLOD2s
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FStreamingLOD2Info>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// NameProperty: RequestedNearbyLOD1
    /// </summary>
    public unsafe BmSDK.FName RequestedNearbyLOD1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// NameProperty: UnloadingNearbyLOD1
    /// </summary>
    public unsafe BmSDK.FName UnloadingNearbyLOD1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// ArrayProperty: DLCAdditionalLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameRI.FDLCAdditionalLevel> DLCAdditionalLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameRI.FDLCAdditionalLevel>>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// StructProperty: RoadNetworkSearchJob
    /// </summary>
    public unsafe System.IntPtr RoadNetworkSearchJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// MapProperty: LevelNameToLevelList
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ LevelNameToLevelList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// NameProperty: GlobalDoorLockRoom
    /// </summary>
    public unsafe BmSDK.FName GlobalDoorLockRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// StrProperty: LevelStreamingLockedBy
    /// </summary>
    public unsafe BmSDK.FString LevelStreamingLockedBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// IntProperty: XPEarned
    /// </summary>
    public unsafe int XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// FloatProperty: EnterCurrentLevelTime
    /// </summary>
    public unsafe float EnterCurrentLevelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// FloatProperty: PlayerSpottedTimer
    /// </summary>
    public unsafe float PlayerSpottedTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// NameProperty: WaitingToFinishLoadingLevel
    /// </summary>
    public unsafe BmSDK.FName WaitingToFinishLoadingLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// FloatProperty: WaitingToFinishLoadingStartTime
    /// </summary>
    public unsafe float WaitingToFinishLoadingStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// FloatProperty: WaitingToFinishLoadingTime
    /// </summary>
    public unsafe float WaitingToFinishLoadingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// FloatProperty: TotalGameThreadTime
    /// </summary>
    public unsafe float TotalGameThreadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// FloatProperty: TotalRenderThreadTime
    /// </summary>
    public unsafe float TotalRenderThreadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// FloatProperty: TotalGPUTime
    /// </summary>
    public unsafe float TotalGPUTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// IntProperty: TotalFrameCount
    /// </summary>
    public unsafe int TotalFrameCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// NameProperty: LastStreamingLevel
    /// </summary>
    public unsafe BmSDK.FName LastStreamingLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// StructProperty: LastStreamingLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastStreamingLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// StrProperty: BatmanInCombatFlagName
    /// </summary>
    public unsafe BmSDK.FString BatmanInCombatFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// ArrayProperty: CombatPawnList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> CombatPawnList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// ArrayProperty: PreviousFrameCombatPawnList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PreviousFrameCombatPawnList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// ArrayProperty: PlayerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat> PlayerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat>>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// ArrayProperty: CrowdList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCrowd> CrowdList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCrowd>>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// ArrayProperty: PawnAIList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> PawnAIList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// ArrayProperty: CombatPickups
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject> CombatPickups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject>>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// ArrayProperty: SniperPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSniperPoint> SniperPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSniperPoint>>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// ArrayProperty: FleePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFleePoint> FleePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFleePoint>>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// ArrayProperty: PredFleePoint
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPredHostageFleePoint> PredFleePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPredHostageFleePoint>>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// ArrayProperty: WanderPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RWanderPoint> WanderPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RWanderPoint>>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// ArrayProperty: DebugLabels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDebugLabel> DebugLabels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDebugLabel>>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// IntProperty: XrayCount
    /// </summary>
    public unsafe int XrayCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }

    /// <summary>
    /// IntProperty: ScanModeCount
    /// </summary>
    public unsafe int ScanModeCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// IntProperty: ThermalCount
    /// </summary>
    public unsafe int ThermalCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }
    }

    /// <summary>
    /// FloatProperty: CustomXrayFadeInStart
    /// </summary>
    public unsafe float CustomXrayFadeInStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// FloatProperty: CustomXrayFadeInDuration
    /// </summary>
    public unsafe float CustomXrayFadeInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// NameProperty: CustomXrayFadeLevelName
    /// </summary>
    public unsafe BmSDK.FName CustomXrayFadeLevelName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// IntProperty: FakeUnarmedGuysForDM
    /// </summary>
    public unsafe int FakeUnarmedGuysForDM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// IntProperty: FakeArmedGuysForDM
    /// </summary>
    public unsafe int FakeArmedGuysForDM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// IntProperty: TextureStreamingLastRequestID
    /// </summary>
    public unsafe int TextureStreamingLastRequestID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// ArrayProperty: objectsSuppressingRiddlerBillboards
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> objectsSuppressingRiddlerBillboards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// StructProperty: PlayerCharacters
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter PlayerCharacters_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }
    /// <summary>
    /// StructProperty: PlayerCharacters
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter PlayerCharacters_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }
    /// <summary>
    /// StructProperty: PlayerCharacters
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter PlayerCharacters_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }
    /// <summary>
    /// StructProperty: PlayerCharacters
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter PlayerCharacters_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }
    /// <summary>
    /// StructProperty: PlayerCharacters
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter PlayerCharacters_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }
    /// <summary>
    /// StructProperty: PlayerCharacters
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter PlayerCharacters_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }
    /// <summary>
    /// StructProperty: PlayerCharacters
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter PlayerCharacters_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }
    /// <summary>
    /// StructProperty: PlayerCharacters
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter PlayerCharacters_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// ArrayProperty: PIECharacters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter> PIECharacters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameRI.FLoadedPlayerCharacter>>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// StructProperty: PlayerBatmobiles
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile PlayerBatmobiles_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }
    /// <summary>
    /// StructProperty: PlayerBatmobiles
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile PlayerBatmobiles_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile>(Ptr + 2524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2524); }
    }
    /// <summary>
    /// StructProperty: PlayerBatmobiles
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile PlayerBatmobiles_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }
    /// <summary>
    /// StructProperty: PlayerBatmobiles
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile PlayerBatmobiles_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }
    /// <summary>
    /// StructProperty: PlayerBatmobiles
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile PlayerBatmobiles_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile>(Ptr + 2824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }
    }
    /// <summary>
    /// StructProperty: PlayerBatmobiles
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile PlayerBatmobiles_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }
    /// <summary>
    /// StructProperty: PlayerBatmobiles
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile PlayerBatmobiles_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile>(Ptr + 3024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3024); }
    }
    /// <summary>
    /// StructProperty: PlayerBatmobiles
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile PlayerBatmobiles_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FLoadedPlayerBatmobile>(Ptr + 3124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3124); }
    }

    /// <summary>
    /// ArrayProperty: detectiveModeThroughWallsSuppressableObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDMThroughWallsSuppressableInterface> detectiveModeThroughWallsSuppressableObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDMThroughWallsSuppressableInterface>>(Ptr + 3224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3224); }
    }

    /// <summary>
    /// IntProperty: NumThugsTakenOutDuringCurrentChallenge
    /// </summary>
    public unsafe int NumThugsTakenOutDuringCurrentChallenge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }
    }

    /// <summary>
    /// ArrayProperty: VillainsTakenDownInCurrentTakedownChain
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> VillainsTakenDownInCurrentTakedownChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 3244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3244); }
    }

    /// <summary>
    /// Enum: EGameStatus
    /// </summary>
    public enum EGameStatus
    {
        GameStatus_None = 0,
        GameStatus_CharacterSelect = 1,
        GameStatus_MapSelect = 2,
        GameStatus_Transition = 3,
        GameStatus_WaitingForHost = 4,
        GameStatus_PreMatch = 5,
        GameStatus_RoundInProgress = 6,
        GameStatus_RoundOver = 7,
        GameStatus_EndMatch = 8,
        GameStatus_Loading = 9,
        GameStatus_MAX = 10,
    }

    /// <summary>
    /// Enum: EStaticString
    /// </summary>
    public enum EStaticString
    {
        StaticString_Placeholder1 = 0,
        StaticString_MAX = 1,
    }

    /// <summary>
    /// Enum: EStaticFloat
    /// </summary>
    public enum EStaticFloat
    {
        StaticFloat_Placeholder1 = 0,
        StaticFloat_MAX = 1,
    }

    /// <summary>
    /// Enum: EStaticInt
    /// </summary>
    public enum EStaticInt
    {
        StaticInt_TempMapIndex = 0,
        StaticInt_MAX = 1,
    }

    /// <summary>
    /// Enum: EStaticBool
    /// </summary>
    public enum EStaticBool
    {
        StaticBool_CatwomanDLCChecked = 0,
        StaticBool_MAX = 1,
    }
}
