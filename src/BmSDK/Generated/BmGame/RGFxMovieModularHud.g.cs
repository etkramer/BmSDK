#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieModularHud<br/>
/// (size = 0)
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileModeRequested
    /// </summary>
    public unsafe bool bBatmobileModeRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileModeActive
    /// </summary>
    public unsafe bool bBatmobileModeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bPromptSystemAvailable
    /// </summary>
    public unsafe bool bPromptSystemAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bObjectivesVisible
    /// </summary>
    public unsafe bool bObjectivesVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bStandingStill
    /// </summary>
    public unsafe bool bStandingStill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: MinimalHudMode
    /// </summary>
    public unsafe bool MinimalHudMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: MinimalHudBecausePlayerJustDied
    /// </summary>
    public unsafe bool MinimalHudBecausePlayerJustDied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: TargetsModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetsModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: HealthBarModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HealthBarModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: StoryModeModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StoryModeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: CrimeSceneInfoModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CrimeSceneInfoModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DetectiveModeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: ExtraSequenceModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExtraSequenceModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: DownloadProgressModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DownloadProgressModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmobileModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeJammingModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DetectiveModeJammingModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: HackingModeModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HackingModeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: ScannerModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ScannerModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: ForensicDetailModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ForensicDetailModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: ObjectivesModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ObjectivesModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: RoomNameModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RoomNameModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: BespokeModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BespokeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: LocalRadarModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LocalRadarModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeModeModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChallengeModeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: AlertsAndSurveillanceModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AlertsAndSurveillanceModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: BossModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BossModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: ForensicBeaconModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ForensicBeaconModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: HeavyTankScanModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HeavyTankScanModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: SuicideCarsModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SuicideCarsModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ObjectProperty: MinigameSequence
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MinigameSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: FireflyModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireflyModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ObjectProperty: TargetsEtcGfxMovie
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetsEtcGfxMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ObjectProperty: LocalRadarGfxMovie
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LocalRadarGfxMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileGfxMovie
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmobileGfxMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ArrayProperty: DisposableGfxMovies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> DisposableGfxMovies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 972); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmanLastPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1012); }
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
