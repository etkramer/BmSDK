#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieModularHud<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieModularHud : BmSDK.BmGame.RGFxMovieModularHudBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieModularHud", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieModularHud() { }

    /// <summary>
    /// Constructs a new RGFxMovieModularHud
    /// </summary>
    public RGFxMovieModularHud(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieModularHud Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieModularHud(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bCommonElementsInitialised
    /// </summary>
    public unsafe bool bCommonElementsInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileModeRequested
    /// </summary>
    public unsafe bool bBatmobileModeRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileModeActive
    /// </summary>
    public unsafe bool bBatmobileModeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bPromptSystemAvailable
    /// </summary>
    public unsafe bool bPromptSystemAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bObjectivesVisible
    /// </summary>
    public unsafe bool bObjectivesVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bStandingStill
    /// </summary>
    public unsafe bool bStandingStill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: MinimalHudMode
    /// </summary>
    public unsafe bool MinimalHudMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: MinimalHudBecausePlayerJustDied
    /// </summary>
    public unsafe bool MinimalHudBecausePlayerJustDied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: TargetsModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleTargets TargetsModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleTargets>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: HealthBarModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleHealthBar HealthBarModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleHealthBar>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: StoryModeModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleStoryMode StoryModeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleStoryMode>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: CrimeSceneInfoModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleCrimeSceneInfo CrimeSceneInfoModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleCrimeSceneInfo>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleDetectiveMode DetectiveModeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleDetectiveMode>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: ExtraSequenceModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleExtraSequence ExtraSequenceModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleExtraSequence>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: DownloadProgressModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleDownloadProgress DownloadProgressModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleDownloadProgress>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBatmobile BatmobileModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBatmobile>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeJammingModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleDetectiveModeJamming DetectiveModeJammingModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleDetectiveModeJamming>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: HackingModeModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleHackingMode HackingModeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleHackingMode>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: ScannerModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleScanner ScannerModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleScanner>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: ForensicDetailModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleForensicDetail ForensicDetailModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleForensicDetail>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: ObjectivesModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleObjectives ObjectivesModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleObjectives>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: RoomNameModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleRoomName RoomNameModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleRoomName>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: BespokeModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBespokeBase BespokeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBespokeBase>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: LocalRadarModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleLocalRadar LocalRadarModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleLocalRadar>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeModeModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleChallengeMode ChallengeModeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleChallengeMode>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: AlertsAndSurveillanceModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleAlertsAndSurveillance AlertsAndSurveillanceModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleAlertsAndSurveillance>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: BossModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBoss BossModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBoss>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: ForensicBeaconModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleForensicBeaconTracking ForensicBeaconModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleForensicBeaconTracking>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: HeavyTankScanModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleHeavyTankScanBase HeavyTankScanModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleHeavyTankScanBase>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: SuicideCarsModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleSuicideCars SuicideCarsModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleSuicideCars>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ObjectProperty: MinigameSequence
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_MinigameSequenceBase MinigameSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_MinigameSequenceBase>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: FireflyModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleFirefly FireflyModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleFirefly>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ObjectProperty: TargetsEtcGfxMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieModularHud_TargetsEtc TargetsEtcGfxMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieModularHud_TargetsEtc>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ObjectProperty: LocalRadarGfxMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieModularHud_LocalRadar LocalRadarGfxMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieModularHud_LocalRadar>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileGfxMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieModularHud_Batmobile BatmobileGfxMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieModularHud_Batmobile>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ArrayProperty: DisposableGfxMovies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMovieModularHud_Disposable> DisposableGfxMovies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMovieModularHud_Disposable>>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: ColTrans_RedOffset
    /// </summary>
    public unsafe float ColTrans_RedOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: ColTrans_GreenOffset
    /// </summary>
    public unsafe float ColTrans_GreenOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: ColTrans_BlueOffset
    /// </summary>
    public unsafe float ColTrans_BlueOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: ColTrans_RedScalar
    /// </summary>
    public unsafe float ColTrans_RedScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: ColTrans_GreenScalar
    /// </summary>
    public unsafe float ColTrans_GreenScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// FloatProperty: ColTrans_BlueScalar
    /// </summary>
    public unsafe float ColTrans_BlueScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// StructProperty: BatmanLastPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 BatmanLastPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// IntProperty: ViewUpgradePromptDuration
    /// </summary>
    public unsafe int ViewUpgradePromptDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }
}
