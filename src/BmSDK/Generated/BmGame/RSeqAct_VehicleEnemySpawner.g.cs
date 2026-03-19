#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_VehicleEnemySpawner<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_VehicleEnemySpawner : BmSDK.BmGame.RSeqAct_SpawnVehicleBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_VehicleEnemySpawner", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_VehicleEnemySpawner() { }

    /// <summary>
    /// Constructs a new RSeqAct_VehicleEnemySpawner
    /// </summary>
    public RSeqAct_VehicleEnemySpawner(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_VehicleEnemySpawner Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_VehicleEnemySpawner(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: SpawnedEnemies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>>>>>>> SpawnedEnemies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>>>>>>>>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// NameProperty: TankBattleName
    /// </summary>
    public unsafe BmSDK.FName TankBattleName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// NameProperty: CommanderName
    /// </summary>
    public unsafe BmSDK.FName CommanderName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// ArrayProperty: SpawnTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>>>>>> SpawnTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>>>>>>>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ArrayProperty: SpawnTypesNewGamePlus
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>>>>> SpawnTypesNewGamePlus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>>>>>>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ArrayProperty: CurrentSpawnTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>>>> CurrentSpawnTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>>>>>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ArrayProperty: TurretSpawnLocations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>>> TurretSpawnLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>>>>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ArrayProperty: GuardPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>> GuardPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>>>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// IntProperty: LastTurretSpawnLocation
    /// </summary>
    public unsafe int LastTurretSpawnLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// BoolProperty: KeepRespawning
    /// </summary>
    public unsafe bool KeepRespawning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bDebugSpawner
    /// </summary>
    public unsafe bool bDebugSpawner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: KeepConstant
    /// </summary>
    public unsafe bool KeepConstant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: AllDead
    /// </summary>
    public unsafe bool AllDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: PreSpawnedUseIndoorVision
    /// </summary>
    public unsafe bool PreSpawnedUseIndoorVision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: SpawnOnMainRoadsOnly
    /// </summary>
    public unsafe bool SpawnOnMainRoadsOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: AllowSpawnOnArmouredRoads
    /// </summary>
    public unsafe bool AllowSpawnOnArmouredRoads
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bInCombat
    /// </summary>
    public unsafe bool bInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bForceIntoCombat
    /// </summary>
    public unsafe bool bForceIntoCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bReady
    /// </summary>
    public unsafe bool bReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bHeavyTankEncounter
    /// </summary>
    public unsafe bool bHeavyTankEncounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bNoSkillPointsAwarded
    /// </summary>
    public unsafe bool bNoSkillPointsAwarded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: UseTurretSpawnLocationsForAllEnemies
    /// </summary>
    public unsafe bool UseTurretSpawnLocationsForAllEnemies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bTrackInThreatLevel
    /// </summary>
    public unsafe bool bTrackInThreatLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: NoFinalSloMo
    /// </summary>
    public unsafe bool NoFinalSloMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bCommandBeacon
    /// </summary>
    public unsafe bool bCommandBeacon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bDontCountForDistrictPop
    /// </summary>
    public unsafe bool bDontCountForDistrictPop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bAllowHeavyTank360Scans
    /// </summary>
    public unsafe bool bAllowHeavyTank360Scans
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: SuppressStartEncounterBarks
    /// </summary>
    public unsafe bool SuppressStartEncounterBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: SuppressEndEncounterBarks
    /// </summary>
    public unsafe bool SuppressEndEncounterBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bBigWaveFight
    /// </summary>
    public unsafe bool bBigWaveFight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bStartsInstantly
    /// </summary>
    public unsafe bool bStartsInstantly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bDoChallengeSpawnFX
    /// </summary>
    public unsafe bool bDoChallengeSpawnFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: SpawnInLineOfSight
    /// </summary>
    public unsafe bool SpawnInLineOfSight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: NoLineOfSightChecks
    /// </summary>
    public unsafe bool NoLineOfSightChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bOnceEngagedStayInCombat
    /// </summary>
    public unsafe bool bOnceEngagedStayInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bChallengeModeOnly
    /// </summary>
    public unsafe bool bChallengeModeOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// IntProperty: TotalNumEnemies
    /// </summary>
    public unsafe int TotalNumEnemies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// IntProperty: CurrentNumEnemies
    /// </summary>
    public unsafe int CurrentNumEnemies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ArrayProperty: DesiredNumEnemies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>> DesiredNumEnemies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// IntProperty: CurrentEnemyTypeToCheck
    /// </summary>
    public unsafe int CurrentEnemyTypeToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// ObjectProperty: SpawnCentre
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnCentre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// ObjectProperty: LeaderVehicle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LeaderVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ObjectProperty: OverrideTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverrideTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ObjectProperty: SpawnEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ObjectProperty: DespawnEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DespawnEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeParticleEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChallengeParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeImpactParticleEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChallengeImpactParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeAkEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChallengeAkEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeDespawnParticleEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChallengeDespawnParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeDespawnAkEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChallengeDespawnAkEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ClassProperty: KillAllDamageType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KillAllDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: NextSpawnAngle
    /// </summary>
    public unsafe float NextSpawnAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: MinSpacing
    /// </summary>
    public unsafe float MinSpacing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ArrayProperty: BehaviourVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles> BehaviourVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// StructProperty: MovementRestrictions
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles MovementRestrictions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.PreSpawnedVehicles>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ArrayProperty: PreSpawnedVehicles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>> PreSpawnedVehicles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// IntProperty: CombatCheckIndex
    /// </summary>
    public unsafe int CombatCheckIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// IntProperty: OverrideChapterDifficulty
    /// </summary>
    public unsafe int OverrideChapterDifficulty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// IntProperty: ChapterDifficultyMod
    /// </summary>
    public unsafe int ChapterDifficultyMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ByteProperty: DistrictOverride
    /// </summary>
    public unsafe byte DistrictOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ArrayProperty: WaveProgression
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>> WaveProgression
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ArrayProperty: WaveProgressionNewGamePlus
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>> WaveProgressionNewGamePlus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// IntProperty: CurrentWave
    /// </summary>
    public unsafe int CurrentWave
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: LastGroupSearchCentreTime
    /// </summary>
    public unsafe float LastGroupSearchCentreTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// StructProperty: LastGroupSearchCentrePos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastGroupSearchCentrePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: LastGroupSearch
    /// </summary>
    public unsafe float LastGroupSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// IntProperty: ThreatToAdd
    /// </summary>
    public unsafe int ThreatToAdd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// IntProperty: NumDeadEnemies
    /// </summary>
    public unsafe int NumDeadEnemies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ArrayProperty: EnemyDeadOutputs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> EnemyDeadOutputs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// IntProperty: MaxNumVehicleOutputsToSpawn
    /// </summary>
    public unsafe int MaxNumVehicleOutputsToSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// IntProperty: AudioActivatedCloseWarning
    /// </summary>
    public unsafe int AudioActivatedCloseWarning
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// Struct: FSpawnedVehicleEnemyDesc
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FSpawnedVehicleEnemyDesc
    {
        /// <summary>
        /// ObjectProperty: Archetype
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Archetype
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: NumEnemies
        /// </summary>
        public unsafe int NumEnemies
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bOverrideDefaultSettings
        /// </summary>
        public unsafe bool bOverrideDefaultSettings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: EnemyName
        /// </summary>
        public unsafe BmSDK.FString EnemyName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: MinRangeToSpawn
        /// </summary>
        public unsafe float MinRangeToSpawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: DropToGround
        /// </summary>
        public unsafe bool DropToGround
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: MinTimeBetweenRespawn
        /// </summary>
        public unsafe float MinTimeBetweenRespawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ClassProperty: OverrideCombatBehaviour
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverrideCombatBehaviour
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ClassProperty: OverrideGuardBehaviour
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverrideGuardBehaviour
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// ArrayProperty: LastDestroyedTime
        /// </summary>
        public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT LastDestroyedTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: UseIndoorVision
        /// </summary>
        public unsafe bool UseIndoorVision
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: SpawnPassengers
        /// </summary>
        public unsafe bool SpawnPassengers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// ObjectProperty: PassengerWeaponArchetype
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PassengerWeaponArchetype
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
    }

    /// <summary>
    /// Struct: FSpawnedVehicleInstance
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FSpawnedVehicleInstance
    {
        /// <summary>
        /// ObjectProperty: SpawnedEnemy
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnedEnemy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: SpawnedEnemyIndex
        /// </summary>
        public unsafe int SpawnedEnemyIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: SpawnedTime
        /// </summary>
        public unsafe float SpawnedTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bInCombat
        /// </summary>
        public unsafe bool bInCombat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }
    }
}
