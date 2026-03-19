#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RForensicsDevice<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RForensicsDevice : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RForensicsDevice", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RForensicsDevice() { }

    /// <summary>
    /// Constructs a new RForensicsDevice
    /// </summary>
    public RForensicsDevice(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RForensicsDevice Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RForensicsDevice(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: FilterNoiseOn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FilterNoiseOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: FilterNoiseOff
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FilterNoiseOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: ZoomInNoise
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ZoomInNoise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: ZoomInState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ZoomInState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: ZoomParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ZoomParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: ZoomOutNoise
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ZoomOutNoise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: ZoomOutState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ZoomOutState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: ChangeFilterModeSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChangeFilterModeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeJammingOn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DetectiveModeJammingOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeJammingOff
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DetectiveModeJammingOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: mCaseFileDeactivateSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT mCaseFileDeactivateSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: mCaseFileActivateSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT mCaseFileActivateSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: ForensicTrailList
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ForensicTrailList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: FreezeLocationMarker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FreezeLocationMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: RadioLocationMarker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RadioLocationMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: CurrentEvidenceDetailActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentEvidenceDetailActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: CurrentDetectiveDisplayActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentDetectiveDisplayActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: VehicleTrackerTrackedVehicle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VehicleTrackerTrackedVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: VehicleTrackerLostVehicle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VehicleTrackerLostVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: SideStoryFailedThought
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SideStoryFailedThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: ActivePenguinVan
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ActivePenguinVan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: ActiveApc
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ActiveApc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: VehicleTrackerThroughWallViewMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VehicleTrackerThroughWallViewMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: VehicleTrackerThroughWallViewOutOfRangeMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VehicleTrackerThroughWallViewOutOfRangeMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: CurrentAugmentedForensicsSeqAct
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentAugmentedForensicsSeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: SatNavSplineArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SatNavSplineArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: SatNavRoadNetwork
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SatNavRoadNetwork
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: SatNavSplineMat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SatNavSplineMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: SatNavForwardRouteRoads
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SatNavForwardRouteRoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: VehTrackSplineArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VehTrackSplineArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: CurrentBatmobileForensicsSideStorySeqAct
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentBatmobileForensicsSideStorySeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: CurrentAdvanceEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentAdvanceEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ComponentProperty: SatNavUpArrow
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SatNavUpArrow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ComponentProperty: VehicleTrackerThroughWallViewMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VehicleTrackerThroughWallViewMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ComponentProperty: XrayLightFalloff
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XrayLightFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ComponentProperty: XrayLight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XrayLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ComponentProperty: CameraPulseFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraPulseFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ComponentProperty: ScanFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ScanFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ArrayProperty: ViewPP
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> ViewPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ArrayProperty: EvidenceArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> EvidenceArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bShowDetectiveModeInfoDuringCinematicMode
    /// </summary>
    public unsafe bool bShowDetectiveModeInfoDuringCinematicMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bHideDetectiveDataInNormalMode
    /// </summary>
    public unsafe bool bHideDetectiveDataInNormalMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bIsInFilterMode
    /// </summary>
    public unsafe bool bIsInFilterMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bFilterShutdownRequested
    /// </summary>
    public unsafe bool bFilterShutdownRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bIsFlashOutro
    /// </summary>
    public unsafe bool bIsFlashOutro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bInScanMode
    /// </summary>
    public unsafe bool bInScanMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bFilterChangeRequested
    /// </summary>
    public unsafe bool bFilterChangeRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bRestoreXrayWhenFlashFinished
    /// </summary>
    public unsafe bool bRestoreXrayWhenFlashFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bCameraPulseActive
    /// </summary>
    public unsafe bool bCameraPulseActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bUseCameraPulse
    /// </summary>
    public unsafe bool bUseCameraPulse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bCanUseForensicsDeviceDirectly
    /// </summary>
    public unsafe bool bCanUseForensicsDeviceDirectly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bDisableForensicHUDMovie
    /// </summary>
    public unsafe bool bDisableForensicHUDMovie
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bDisableForensicHUDText
    /// </summary>
    public unsafe bool bDisableForensicHUDText
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bIsCommunicationDisrupted
    /// </summary>
    public unsafe bool bIsCommunicationDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bSuppressForensicsOffSound
    /// </summary>
    public unsafe bool bSuppressForensicsOffSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bInRiddlerCave
    /// </summary>
    public unsafe bool bInRiddlerCave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bDetectiveModeJammingSoundActive
    /// </summary>
    public unsafe bool bDetectiveModeJammingSoundActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: mbIsGlitchesEnable
    /// </summary>
    public unsafe bool mbIsGlitchesEnable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: mExitedCaseFile
    /// </summary>
    public unsafe bool mExitedCaseFile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bXrayKeepSceneLights
    /// </summary>
    public unsafe bool bXrayKeepSceneLights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bXrayUseSpecialShading
    /// </summary>
    public unsafe bool bXrayUseSpecialShading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bXrayUsePointCloudShader
    /// </summary>
    public unsafe bool bXrayUsePointCloudShader
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: SpecialTrackingModeAlertsEnabled
    /// </summary>
    public unsafe bool SpecialTrackingModeAlertsEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: LastEvidenceTrailActivationState
    /// </summary>
    public unsafe bool LastEvidenceTrailActivationState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bEvidenceIsHighlighted
    /// </summary>
    public unsafe bool bEvidenceIsHighlighted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bIsBatman
    /// </summary>
    public unsafe bool bIsBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bIsRobin
    /// </summary>
    public unsafe bool bIsRobin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: VehicleTrackerHighPriority
    /// </summary>
    public unsafe bool VehicleTrackerHighPriority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: VehicleTrackerCarCountsAsVisible
    /// </summary>
    public unsafe bool VehicleTrackerCarCountsAsVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: VehicleTrackerCarReachedDestination
    /// </summary>
    public unsafe bool VehicleTrackerCarReachedDestination
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bFiredBatmanSeenTrackedVehicleEvent
    /// </summary>
    public unsafe bool bFiredBatmanSeenTrackedVehicleEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: ViewMeshOutOfRange
    /// </summary>
    public unsafe bool ViewMeshOutOfRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bLocalRadarHudIsActive
    /// </summary>
    public unsafe bool bLocalRadarHudIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bVehicleTrackerRadarActive
    /// </summary>
    public unsafe bool bVehicleTrackerRadarActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bHeavyTankTrackerRadarActive
    /// </summary>
    public unsafe bool bHeavyTankTrackerRadarActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: LosBeneathThreshold
    /// </summary>
    public unsafe bool LosBeneathThreshold
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bCanLoseTarget
    /// </summary>
    public unsafe bool bCanLoseTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bCanUntagTarget
    /// </summary>
    public unsafe bool bCanUntagTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bDrawTargetRoute
    /// </summary>
    public unsafe bool bDrawTargetRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: DisableSatNav
    /// </summary>
    public unsafe bool DisableSatNav
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: SatNavRouteFull
    /// </summary>
    public unsafe bool SatNavRouteFull
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: SatNavWrongWay
    /// </summary>
    public unsafe bool SatNavWrongWay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: SatNavForwardRouteIsLoop
    /// </summary>
    public unsafe bool SatNavForwardRouteIsLoop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: SatNavForwardRouteShowOnHUD
    /// </summary>
    public unsafe bool SatNavForwardRouteShowOnHUD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bRadarJammed
    /// </summary>
    public unsafe bool bRadarJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: ForceSatNavRefresh
    /// </summary>
    public unsafe bool ForceSatNavRefresh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: ScanTimer
    /// </summary>
    public unsafe float ScanTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ByteProperty: RequestedFilterMode
    /// </summary>
    public unsafe byte RequestedFilterMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ByteProperty: CurrentFilterMode
    /// </summary>
    public unsafe byte CurrentFilterMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1025); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1025); }
    }

    /// <summary>
    /// ByteProperty: RequestedFilterModeForDetectiveMode
    /// </summary>
    public unsafe byte RequestedFilterModeForDetectiveMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1026); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1026); }
    }

    /// <summary>
    /// ByteProperty: TrackingModePostProcess
    /// </summary>
    public unsafe byte TrackingModePostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1027); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1027); }
    }

    /// <summary>
    /// ByteProperty: CurrentVisualHudMode
    /// </summary>
    public unsafe byte CurrentVisualHudMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ByteProperty: CurrentVisionMode
    /// </summary>
    public unsafe byte CurrentVisionMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1029); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1029); }
    }

    /// <summary>
    /// ByteProperty: TargetVisionMode
    /// </summary>
    public unsafe byte TargetVisionMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1030); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1030); }
    }

    /// <summary>
    /// ByteProperty: CurrentFlashState
    /// </summary>
    public unsafe byte CurrentFlashState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1031); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1031); }
    }

    /// <summary>
    /// ByteProperty: SideStoryFailed
    /// </summary>
    public unsafe byte SideStoryFailed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// IntProperty: FilterChangeFinishOffTicker
    /// </summary>
    public unsafe int FilterChangeFinishOffTicker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: FilterChangeTimer
    /// </summary>
    public unsafe float FilterChangeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// IntProperty: HasSetFilterMovieMode
    /// </summary>
    public unsafe int HasSetFilterMovieMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: CurrentScannerPower
    /// </summary>
    public unsafe float CurrentScannerPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: TimeForFlash
    /// </summary>
    public unsafe float TimeForFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: TimeForHold
    /// </summary>
    public unsafe float TimeForHold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: DistanceToTrailProximityNode
    /// </summary>
    public unsafe float DistanceToTrailProximityNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: DistanceToTrailProximityNodeLast
    /// </summary>
    public unsafe float DistanceToTrailProximityNodeLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// FloatProperty: AngularDistanceFromProximityNode
    /// </summary>
    public unsafe float AngularDistanceFromProximityNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// StrProperty: TrailName
    /// </summary>
    public unsafe BmSDK.FString TrailName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastForensicsRequest
    /// </summary>
    public unsafe float TimeSinceLastForensicsRequest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ArrayProperty: JammingActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> JammingActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// InterfaceProperty: ClosestJammerActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ClosestJammerActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// IntProperty: NumJammingActorTargetsVisible
    /// </summary>
    public unsafe int NumJammingActorTargetsVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: SpecialTrackingModeAlertThreshold
    /// </summary>
    public unsafe float SpecialTrackingModeAlertThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// FloatProperty: SpecialTrackingModeCurrentBestDistance
    /// </summary>
    public unsafe float SpecialTrackingModeCurrentBestDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// StrProperty: LastEvidenceTrailQueried
    /// </summary>
    public unsafe BmSDK.FString LastEvidenceTrailQueried
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// StructProperty: vVirtualDisruptorTowerLocationStart
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT vVirtualDisruptorTowerLocationStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// StructProperty: vVirtualDisruptorTowerLocationEnd
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT vVirtualDisruptorTowerLocationEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: fVirtualDisruptorTowerTimer
    /// </summary>
    public unsafe float fVirtualDisruptorTowerTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// FloatProperty: fJammedDetectiveModeGlitchTimer
    /// </summary>
    public unsafe float fJammedDetectiveModeGlitchTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// IntProperty: iJammedDetectiveModeGlitchCount
    /// </summary>
    public unsafe int iJammedDetectiveModeGlitchCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// FloatProperty: JammedDetectiveModeGlitchPeriodMin
    /// </summary>
    public unsafe float JammedDetectiveModeGlitchPeriodMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// FloatProperty: JammedDetectiveModeGlitchPeriodRange
    /// </summary>
    public unsafe float JammedDetectiveModeGlitchPeriodRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: JammedDetectiveModeGlitchDuration
    /// </summary>
    public unsafe float JammedDetectiveModeGlitchDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// FloatProperty: DetectiveModeFOVModifier
    /// </summary>
    public unsafe float DetectiveModeFOVModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// StructProperty: PostProcessOverride
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.VehicleTrackerTrackedVehicleObjective PostProcessOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.VehicleTrackerTrackedVehicleObjective>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// FloatProperty: VehicleTrackerLastRealLOSTime
    /// </summary>
    public unsafe float VehicleTrackerLastRealLOSTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// StrProperty: VehicleTrackerTrackedVehicleObjective
    /// </summary>
    public unsafe BmSDK.FString VehicleTrackerTrackedVehicleObjective
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// FloatProperty: SideStoryFailedDelay
    /// </summary>
    public unsafe float SideStoryFailedDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// FloatProperty: MaxOnscreenCos
    /// </summary>
    public unsafe float MaxOnscreenCos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// FloatProperty: LosLockon
    /// </summary>
    public unsafe float LosLockon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// FloatProperty: LosLockonOnHud
    /// </summary>
    public unsafe float LosLockonOnHud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// FloatProperty: LockOn_TimeToFullyLose
    /// </summary>
    public unsafe float LockOn_TimeToFullyLose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// FloatProperty: LockOn_TimeToFullyGain
    /// </summary>
    public unsafe float LockOn_TimeToFullyGain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// FloatProperty: LockOn_ThresholdForWarningFlash
    /// </summary>
    public unsafe float LockOn_ThresholdForWarningFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1772); }
    }

    /// <summary>
    /// FloatProperty: OnscreenTime
    /// </summary>
    public unsafe float OnscreenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// FloatProperty: OffScreenTime
    /// </summary>
    public unsafe float OffScreenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// FloatProperty: VehicleTrackerMaxRangeForTestLos
    /// </summary>
    public unsafe float VehicleTrackerMaxRangeForTestLos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// FloatProperty: VehicleTrackerMaxRangeForTestLosInBatmobile
    /// </summary>
    public unsafe float VehicleTrackerMaxRangeForTestLosInBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// FloatProperty: carOffScreenGraceTime
    /// </summary>
    public unsafe float carOffScreenGraceTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// FloatProperty: DrawTargetRouteRange
    /// </summary>
    public unsafe float DrawTargetRouteRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// FloatProperty: ChaseSplineBackDist
    /// </summary>
    public unsafe float ChaseSplineBackDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }
    }

    /// <summary>
    /// FloatProperty: ChaseSplineFwdDist
    /// </summary>
    public unsafe float ChaseSplineFwdDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// StructProperty: SatNavDestinationLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SatNavDestinationLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// IntProperty: SatNavEndLinkRaw
    /// </summary>
    public unsafe int SatNavEndLinkRaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// FloatProperty: SatNavEndLinkRawTime
    /// </summary>
    public unsafe float SatNavEndLinkRawTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// ArrayProperty: SatNavRoute
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>> SatNavRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// ArrayProperty: SatNavRouteSpans
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>> SatNavRouteSpans
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// ArrayProperty: SatNavRacingLine
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>> SatNavRacingLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// IntProperty: SatNavStartLink
    /// </summary>
    public unsafe int SatNavStartLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// IntProperty: SatNavEndLink
    /// </summary>
    public unsafe int SatNavEndLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// IntProperty: SatNavStartPoint
    /// </summary>
    public unsafe int SatNavStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ArrayProperty: SatNavSpline
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>> SatNavSpline
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// NameProperty: SatNavSplineFadeNearName
    /// </summary>
    public unsafe BmSDK.FName SatNavSplineFadeNearName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// NameProperty: SatNavSplineFadeFarName
    /// </summary>
    public unsafe BmSDK.FName SatNavSplineFadeFarName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// NameProperty: SatNavSplineBrightnessName
    /// </summary>
    public unsafe BmSDK.FName SatNavSplineBrightnessName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// NameProperty: SatNavSplineWrongWayName
    /// </summary>
    public unsafe BmSDK.FName SatNavSplineWrongWayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// FloatProperty: CameraToBatmobileDist
    /// </summary>
    public unsafe float CameraToBatmobileDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// FloatProperty: CameraToBatmobileAngle
    /// </summary>
    public unsafe float CameraToBatmobileAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// FloatProperty: SatNavFadeIn
    /// </summary>
    public unsafe float SatNavFadeIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// FloatProperty: SatNavWantFadeIn
    /// </summary>
    public unsafe float SatNavWantFadeIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// IntProperty: SatNavNumArrows
    /// </summary>
    public unsafe int SatNavNumArrows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// FloatProperty: SatNavArrowsOffset
    /// </summary>
    public unsafe float SatNavArrowsOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// FloatProperty: SatNavArrowsSpacing
    /// </summary>
    public unsafe float SatNavArrowsSpacing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }

    /// <summary>
    /// StructProperty: SatNavFirstArrowDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SatNavFirstArrowDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// StructProperty: SatNavFirstLinkDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SatNavFirstLinkDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// StructProperty: SatNavEndLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SatNavEndLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// StructProperty: SatNavBatmobileDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SatNavBatmobileDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// FloatProperty: BatmobileStationaryTime
    /// </summary>
    public unsafe float BatmobileStationaryTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// FloatProperty: SatNavWrongWayTime
    /// </summary>
    public unsafe float SatNavWrongWayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }

    /// <summary>
    /// IntProperty: SatNavSide
    /// </summary>
    public unsafe int SatNavSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// StructProperty: SatNavRouteJob
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SatNavRouteJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRouteStartPoint
    /// </summary>
    public unsafe int SatNavForwardRouteStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// ArrayProperty: SatNavForwardRoute
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> SatNavForwardRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRouteNearLink
    /// </summary>
    public unsafe int SatNavForwardRouteNearLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRouteNearPoint
    /// </summary>
    public unsafe int SatNavForwardRouteNearPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRouteSide
    /// </summary>
    public unsafe int SatNavForwardRouteSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRouteCheckpoint
    /// </summary>
    public unsafe int SatNavForwardRouteCheckpoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRoutePrevCheckpoint
    /// </summary>
    public unsafe int SatNavForwardRoutePrevCheckpoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRoutePrevPrevCheckpoint
    /// </summary>
    public unsafe int SatNavForwardRoutePrevPrevCheckpoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// FloatProperty: SatNavForwardRouteSign
    /// </summary>
    public unsafe float SatNavForwardRouteSign
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ArrayProperty: VehTrackArrows
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> VehTrackArrows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// IntProperty: VehTrackNumArrows
    /// </summary>
    public unsafe int VehTrackNumArrows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }
}
