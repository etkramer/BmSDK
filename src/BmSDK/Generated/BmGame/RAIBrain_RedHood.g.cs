#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAIBrain_RedHood<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAIBrain_RedHood : BmSDK.BmGame.RAIBrain_Pred, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAIBrain_RedHood", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAIBrain_RedHood() { }

    /// <summary>
    /// Constructs a new RAIBrain_RedHood
    /// </summary>
    public RAIBrain_RedHood(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAIBrain_RedHood Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAIBrain_RedHood(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: FrozenAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_FrozenThug FrozenAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_FrozenThug>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: GoggleBlindedAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_GoggleBlinded_Group GoggleBlindedAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_GoggleBlinded_Group>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: FearDartAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_FearDart FearDartAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_FearDart>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: GrateWatchAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_GrateWatch GrateWatchAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_GrateWatch>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: OutOfControlDroneExplodeAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_OutOfControlDroneExplode OutOfControlDroneExplodeAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_OutOfControlDroneExplode>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: DroneStartleAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_DroneStartle DroneStartleAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_DroneStartle>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ObjectProperty: BankFearStartleAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_BankFearStartle BankFearStartleAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_BankFearStartle>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ObjectProperty: ShootGelAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_ShootGelMine ShootGelAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_ShootGelMine>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ObjectProperty: ShootStickyConcussionGrenadeAEC
    /// </summary>
    public unsafe BmSDK.BmGame.MAEC_ShootStickyConcussionGrenade ShootStickyConcussionGrenadeAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MAEC_ShootStickyConcussionGrenade>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: PotentialAttractEnnemiesToLocation
    /// </summary>
    public unsafe BmSDK.BmGame.MAEC_AttractEnemiesToLocation PotentialAttractEnnemiesToLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MAEC_AttractEnemiesToLocation>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: BatarangAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_BatarangReaction_Master BatarangAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_BatarangReaction_Master>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ObjectProperty: MissingGrateAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_MissingGrate MissingGrateAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_MissingGrate>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ObjectProperty: PostRagdollLookaroundAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_PostRagdollLookaround PostRagdollLookaroundAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_PostRagdollLookaround>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ObjectProperty: LevelScriptingRootAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_LevelScriptingRoot LevelScriptingRootAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_LevelScriptingRoot>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ObjectProperty: DisruptedJammerReactionAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_DisruptedJammerReaction DisruptedJammerReactionAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_DisruptedJammerReaction>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ObjectProperty: HideFromBatmobileAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_HideFromBatmobile HideFromBatmobileAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_HideFromBatmobile>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ObjectProperty: BombPlantAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_SetBombOnPlant BombPlantAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_SetBombOnPlant>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: BangOnDoorRootAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_LockedIn_GroupBase BangOnDoorRootAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_LockedIn_GroupBase>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeDetectorAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_DetectiveModeDetector_Group DetectiveModeDetectorAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_DetectiveModeDetector_Group>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ObjectProperty: DroneAbandonAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_AbandonDrone DroneAbandonAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_AbandonDrone>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ObjectProperty: DestroyedSentryAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_DestroyedSentry DestroyedSentryAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_DestroyedSentry>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: OrderedOutOfVolumeAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_OrderedOutOfVolume OrderedOutOfVolumeAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_OrderedOutOfVolume>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ArrayProperty: PotentialFearDartWatcher
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_FearDart_Watcher> PotentialFearDartWatcher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_FearDart_Watcher>>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ArrayProperty: PotentialSmokeInside
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_Smoke_Inside> PotentialSmokeInside
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_Smoke_Inside>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ArrayProperty: PotentialSmokePerim
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_Smoke_Outsider> PotentialSmokePerim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_Smoke_Outsider>>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// ArrayProperty: ZoneToEscapeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Volume> ZoneToEscapeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Volume>>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// BoolProperty: bHasGun
    /// </summary>
    public unsafe bool bHasGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// BoolProperty: bHasDiscoveredJammedGun
    /// </summary>
    public unsafe bool bHasDiscoveredJammedGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// BoolProperty: bIsSniper
    /// </summary>
    public unsafe bool bIsSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// BoolProperty: bIsAttackStartled
    /// </summary>
    public unsafe bool bIsAttackStartled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// BoolProperty: bIsGadgetStartled
    /// </summary>
    public unsafe bool bIsGadgetStartled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// BoolProperty: bPrimaryAttackAECWantsThug
    /// </summary>
    public unsafe bool bPrimaryAttackAECWantsThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// BoolProperty: bSearchInCocky
    /// </summary>
    public unsafe bool bSearchInCocky
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// ArrayProperty: PotentialMine
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_ConvergeMine> PotentialMine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_ConvergeMine>>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ArrayProperty: PotentialJackInBox
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MAEC_AttractEnemiesWithSound> PotentialJackInBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MAEC_AttractEnemiesWithSound>>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ArrayProperty: PotentialWall
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_ExplodedWall> PotentialWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_ExplodedWall>>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ArrayProperty: PotentialCas
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_CasualtyBase> PotentialCas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_CasualtyBase>>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ArrayProperty: PotentialGel
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_GelMineExplosion> PotentialGel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_GelMineExplosion>>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ArrayProperty: PotentialJammer
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_ExplodedJammer> PotentialJammer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_ExplodedJammer>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: PotentialReactionToStickyConcussionGrenadeAEC
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MAEC_StickyConcussionGrenadeReaction> PotentialReactionToStickyConcussionGrenadeAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MAEC_StickyConcussionGrenadeReaction>>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ArrayProperty: PotentialIceBreaker
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_IceBreaker> PotentialIceBreaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_IceBreaker>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }
}
