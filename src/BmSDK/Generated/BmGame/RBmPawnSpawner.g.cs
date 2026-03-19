#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBmPawnSpawner<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBmPawnSpawner : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBmPawnSpawner", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBmPawnSpawner() { }

    /// <summary>
    /// Constructs a new RBmPawnSpawner
    /// </summary>
    public RBmPawnSpawner(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBmPawnSpawner Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBmPawnSpawner(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SpawnPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: CharacterDefine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CharacterDefine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: CharacterDefineFallback
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CharacterDefineFallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: AlternateAnimAndWeapon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AlternateAnimAndWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ObjectProperty: SpawnedPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnedPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: KOPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KOPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ObjectProperty: CombatLOSCheckVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatLOSCheckVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ObjectProperty: LoadedWeaponRefHolder
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LoadedWeaponRefHolder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeParticleEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChallengeParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeDespawnParticleEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChallengeDespawnParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeImpactParticleEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChallengeImpactParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeAkEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChallengeAkEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeDespawnAkEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChallengeDespawnAkEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ObjectProperty: NewGamePlus_CharacterDefine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NewGamePlus_CharacterDefine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ObjectProperty: InVehicleWeaponArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InVehicleWeaponArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ObjectProperty: CustomChatterData
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CustomChatterData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ClassProperty: NewGamePlus_WeaponType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NewGamePlus_WeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ClassProperty: NewGamePlus_PawnClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NewGamePlus_PawnClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ClassProperty: WeaponType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ClassProperty: NewGamePlus_CharacterType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NewGamePlus_CharacterType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// ClassProperty: CharacterType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CharacterType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ClassProperty: BrainType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BrainType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ClassProperty: PawnClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PawnClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ArrayProperty: RandomSpawnPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RandomSpawnPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// BoolProperty: bUseFurthestSpawnPointFromPlayer
    /// </summary>
    public unsafe bool bUseFurthestSpawnPointFromPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bCanThrowGrenadesIfUnarmed
    /// </summary>
    public unsafe bool bCanThrowGrenadesIfUnarmed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bSnapToGround
    /// </summary>
    public unsafe bool bSnapToGround
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bDontTurnOffGeoFloorChecksAtRange
    /// </summary>
    public unsafe bool bDontTurnOffGeoFloorChecksAtRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bCastShadow
    /// </summary>
    public unsafe bool bCastShadow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bInstantEnterCombatOnMagBlast
    /// </summary>
    public unsafe bool bInstantEnterCombatOnMagBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAwardXPOnDeath
    /// </summary>
    public unsafe bool bOverrideAwardXPOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bAwardXPOnDeath
    /// </summary>
    public unsafe bool bAwardXPOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bReduceGelForce
    /// </summary>
    public unsafe bool bReduceGelForce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bIsInformant
    /// </summary>
    public unsafe bool bIsInformant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bIsRiddlerTutorial
    /// </summary>
    public unsafe bool bIsRiddlerTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bNotScaredOfBatmobileIfVillain
    /// </summary>
    public unsafe bool bNotScaredOfBatmobileIfVillain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bForceFlappyBitsOff
    /// </summary>
    public unsafe bool bForceFlappyBitsOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bForceAlwaysUsePhysicsOn
    /// </summary>
    public unsafe bool bForceAlwaysUsePhysicsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bDisableRagdollCalming
    /// </summary>
    public unsafe bool bDisableRagdollCalming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bCanBeXrayed
    /// </summary>
    public unsafe bool bCanBeXrayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bPickClosestOutOfSightFromRandoms
    /// </summary>
    public unsafe bool bPickClosestOutOfSightFromRandoms
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bUsedInCutsceneDialogue
    /// </summary>
    public unsafe bool bUsedInCutsceneDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bCanUsePool
    /// </summary>
    public unsafe bool bCanUsePool
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bPawnPoolRequiresNavMeshCheck
    /// </summary>
    public unsafe bool bPawnPoolRequiresNavMeshCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bTreatXrayAsOverworld
    /// </summary>
    public unsafe bool bTreatXrayAsOverworld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bForceLongRangeXrayFading
    /// </summary>
    public unsafe bool bForceLongRangeXrayFading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: SideStoryIsMainActor
    /// </summary>
    public unsafe bool SideStoryIsMainActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bTriggerDeathOutput
    /// </summary>
    public unsafe bool bTriggerDeathOutput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bRemovedPawnWithoutKillingIt
    /// </summary>
    public unsafe bool bRemovedPawnWithoutKillingIt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bSpawned
    /// </summary>
    public unsafe bool bSpawned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bPawnDead
    /// </summary>
    public unsafe bool bPawnDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bPendingSpawn
    /// </summary>
    public unsafe bool bPendingSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bSpawnOnceOnly
    /// </summary>
    public unsafe bool bSpawnOnceOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bSpawnOncePerPlayer
    /// </summary>
    public unsafe bool bSpawnOncePerPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bCleanUpRagdollOnRespawn
    /// </summary>
    public unsafe bool bCleanUpRagdollOnRespawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bTriggerBatarangCamera
    /// </summary>
    public unsafe bool bTriggerBatarangCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bCanTargetBatmobile
    /// </summary>
    public unsafe bool bCanTargetBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bCanBeZappedByBatmobile
    /// </summary>
    public unsafe bool bCanBeZappedByBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bSurveillanceVisualEffectDisabled
    /// </summary>
    public unsafe bool bSurveillanceVisualEffectDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bFadeOutAfterDeath
    /// </summary>
    public unsafe bool bFadeOutAfterDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bMagneticBlastClingToWeapon
    /// </summary>
    public unsafe bool bMagneticBlastClingToWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bWeaponCanBePickedUp
    /// </summary>
    public unsafe bool bWeaponCanBePickedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bWeaponCanBePickedUpOnlyBySelf
    /// </summary>
    public unsafe bool bWeaponCanBePickedUpOnlyBySelf
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bDontAlertPawnsInOtherPylons
    /// </summary>
    public unsafe bool bDontAlertPawnsInOtherPylons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bDisallowQuickTakedowns
    /// </summary>
    public unsafe bool bDisallowQuickTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bImmuneToBatclawDisarm
    /// </summary>
    public unsafe bool bImmuneToBatclawDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bCanCrossLevelVolumes
    /// </summary>
    public unsafe bool bCanCrossLevelVolumes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bForceNonCombatSilentTakedown
    /// </summary>
    public unsafe bool bForceNonCombatSilentTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bPreventPredatorTakedownCam
    /// </summary>
    public unsafe bool bPreventPredatorTakedownCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bShouldPreventFinalBlowCam
    /// </summary>
    public unsafe bool bShouldPreventFinalBlowCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bIsPickPocketTarget
    /// </summary>
    public unsafe bool bIsPickPocketTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bCanPlayEnterCombatBark
    /// </summary>
    public unsafe bool bCanPlayEnterCombatBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bSilentRagdoll
    /// </summary>
    public unsafe bool bSilentRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bRegisterDeadIfSP
    /// </summary>
    public unsafe bool bRegisterDeadIfSP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToSpawnPawn
    /// </summary>
    public unsafe bool bWaitingToSpawnPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bStaggerPawnSpawning
    /// </summary>
    public unsafe bool bStaggerPawnSpawning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bPawnShouldBeReflected
    /// </summary>
    public unsafe bool bPawnShouldBeReflected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForWeaponLoad
    /// </summary>
    public unsafe bool bWaitingForWeaponLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bWeaponLoaded
    /// </summary>
    public unsafe bool bWeaponLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bAutoUpdatedWeaponStreaming
    /// </summary>
    public unsafe bool bAutoUpdatedWeaponStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bAutoUpdatedWeaponStreaming2
    /// </summary>
    public unsafe bool bAutoUpdatedWeaponStreaming2
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: OverridePhysWalkingType
    /// </summary>
    public unsafe bool OverridePhysWalkingType
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bFallBackToNavMeshFloor
    /// </summary>
    public unsafe bool bFallBackToNavMeshFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bTreatAsOverworldForStasis
    /// </summary>
    public unsafe bool bTreatAsOverworldForStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bForceConstantGroundChecks
    /// </summary>
    public unsafe bool bForceConstantGroundChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bForceCollisionOnCrowdPawn
    /// </summary>
    public unsafe bool bForceCollisionOnCrowdPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bApplySoftPawnCollision
    /// </summary>
    public unsafe bool bApplySoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bReceiveSoftPawnCollision
    /// </summary>
    public unsafe bool bReceiveSoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 580); }
    }

    /// <summary>
    /// BoolProperty: bForceDisableFloorCorrection
    /// </summary>
    public unsafe bool bForceDisableFloorCorrection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bApplyPlayerNPCCollision
    /// </summary>
    public unsafe bool bApplyPlayerNPCCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bLargerCollision
    /// </summary>
    public unsafe bool bLargerCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bAllowConversationsToContinueWhenTakenDown
    /// </summary>
    public unsafe bool bAllowConversationsToContinueWhenTakenDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bNewGamePlus
    /// </summary>
    public unsafe bool bNewGamePlus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bCheckedForNewGamePlus
    /// </summary>
    public unsafe bool bCheckedForNewGamePlus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bReduceBlinksAndEyeMovements
    /// </summary>
    public unsafe bool bReduceBlinksAndEyeMovements
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bUseSkeletalMeshAggressiveLODScale
    /// </summary>
    public unsafe bool bUseSkeletalMeshAggressiveLODScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bReplaceStandardChatter
    /// </summary>
    public unsafe bool bReplaceStandardChatter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bResurrectOnNextInput
    /// </summary>
    public unsafe bool bResurrectOnNextInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bSpawnHidden
    /// </summary>
    public unsafe bool bSpawnHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// ByteProperty: PawnStuckRagdollSolutionType
    /// </summary>
    public unsafe byte PawnStuckRagdollSolutionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ByteProperty: HelicopterPointOfInterestType
    /// </summary>
    public unsafe byte HelicopterPointOfInterestType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 589); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 589); }
    }

    /// <summary>
    /// ByteProperty: StreamedPredWeaponType
    /// </summary>
    public unsafe byte StreamedPredWeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 590); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 590); }
    }

    /// <summary>
    /// ByteProperty: StreamedCombatWeaponType
    /// </summary>
    public unsafe byte StreamedCombatWeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 591); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 591); }
    }

    /// <summary>
    /// ByteProperty: PhysWalkingType
    /// </summary>
    public unsafe byte PhysWalkingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ByteProperty: StasisMode
    /// </summary>
    public unsafe byte StasisMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 593); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 593); }
    }

    /// <summary>
    /// ByteProperty: RagdollVsNavMeshSolution
    /// </summary>
    public unsafe byte RagdollVsNavMeshSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 594); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 594); }
    }

    /// <summary>
    /// ByteProperty: NewGamePlus_StreamedPredWeaponType
    /// </summary>
    public unsafe byte NewGamePlus_StreamedPredWeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 595); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 595); }
    }

    /// <summary>
    /// ByteProperty: NewGamePlus_StreamedCombatWeaponType
    /// </summary>
    public unsafe byte NewGamePlus_StreamedCombatWeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ByteProperty: Headset
    /// </summary>
    public unsafe byte Headset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 597); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 597); }
    }

    /// <summary>
    /// StrProperty: SideStoryIconName
    /// </summary>
    public unsafe BmSDK.FString SideStoryIconName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// IntProperty: SideStoryDiscoveryHeight
    /// </summary>
    public unsafe int SideStoryDiscoveryHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// StrProperty: DeathMovieIfThisPawnKillsBatman
    /// </summary>
    public unsafe BmSDK.FString DeathMovieIfThisPawnKillsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// StrProperty: DeathTipIfThisPawnKillsBatman
    /// </summary>
    public unsafe BmSDK.FString DeathTipIfThisPawnKillsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// NameProperty: PawnReferenceName
    /// </summary>
    public unsafe BmSDK.FName PawnReferenceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// StrProperty: PawnDeadFlagName
    /// </summary>
    public unsafe BmSDK.FString PawnDeadFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// IntProperty: ForceTauntSetID
    /// </summary>
    public unsafe int ForceTauntSetID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// IntProperty: PostSpawnCounter
    /// </summary>
    public unsafe int PostSpawnCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// StrProperty: LoadingWeaponPackage
    /// </summary>
    public unsafe BmSDK.FString LoadingWeaponPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// FloatProperty: DelayBetweenSpawns
    /// </summary>
    public unsafe float DelayBetweenSpawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// IntProperty: BrainOutputStartIndex
    /// </summary>
    public unsafe int BrainOutputStartIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ArrayProperty: DefineIndexes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> DefineIndexes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: SkeletalMeshAggressiveLODMultiplier
    /// </summary>
    public unsafe float SkeletalMeshAggressiveLODMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// IntProperty: fireCrewIndex
    /// </summary>
    public unsafe int fireCrewIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// Enum: EPS_PawnTypes
    /// </summary>
    public enum EPS_PawnTypes
    {
        EPS_LEAVEEMPTY = 0,
        EPS_MAX = 1,
    }
}
