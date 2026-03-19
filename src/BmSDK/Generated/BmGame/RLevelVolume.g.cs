#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RLevelVolume<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RLevelVolume : BmSDK.Engine.UmbraStreamingVolume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RLevelVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RLevelVolume() { }

    /// <summary>
    /// Constructs a new RLevelVolume
    /// </summary>
    public RLevelVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RLevelVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RLevelVolume(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelVolume>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelVolume>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelVolume>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelVolume>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelVolume>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelVolume>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelVolume>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_AkEvaluate
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_AkEvaluate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// NameProperty: Level
    /// </summary>
    public unsafe BmSDK.FName Level
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// BoolProperty: bDoNotShowRoomName
    /// </summary>
    public unsafe bool bDoNotShowRoomName
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bOnlyActivateThroughLevelTransitions
    /// </summary>
    public unsafe bool bOnlyActivateThroughLevelTransitions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bOnlyDeactivateThroughLevelTransitions
    /// </summary>
    public unsafe bool bOnlyDeactivateThroughLevelTransitions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bIsLevelActive
    /// </summary>
    public unsafe bool bIsLevelActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreTouchUntouch
    /// </summary>
    public unsafe bool bIgnoreTouchUntouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bHasOnlyLoadWhenNearLevels
    /// </summary>
    public unsafe bool bHasOnlyLoadWhenNearLevels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bLoadedDLCLevels
    /// </summary>
    public unsafe bool bLoadedDLCLevels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bAIFallIntoWater
    /// </summary>
    public unsafe bool bAIFallIntoWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bCanBatclawThroughNavMesh
    /// </summary>
    public unsafe bool bCanBatclawThroughNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDisableAIFallingCheck
    /// </summary>
    public unsafe bool bDisableAIFallingCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDontExitCombatOnceStarted
    /// </summary>
    public unsafe bool bDontExitCombatOnceStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDisableHostileCount
    /// </summary>
    public unsafe bool bDisableHostileCount
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bUseLowLineLauncherHeight
    /// </summary>
    public unsafe bool bUseLowLineLauncherHeight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: TreatAsOw
    /// </summary>
    public unsafe bool TreatAsOw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: TreatAsInterior
    /// </summary>
    public unsafe bool TreatAsInterior
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: CanUseBatmobile
    /// </summary>
    public unsafe bool CanUseBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: CanTeleportBatmobile
    /// </summary>
    public unsafe bool CanTeleportBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: CanTeleportBatmobileOut
    /// </summary>
    public unsafe bool CanTeleportBatmobileOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: TreatAsOwForRcBatmobile
    /// </summary>
    public unsafe bool TreatAsOwForRcBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: OverrideAllowXrayOnBatmobile
    /// </summary>
    public unsafe bool OverrideAllowXrayOnBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: BatmobileAlwaysVisibleInDetectiveMode
    /// </summary>
    public unsafe bool BatmobileAlwaysVisibleInDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: NoVehicles
    /// </summary>
    public unsafe bool NoVehicles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: RemoteBatmobileAllowedToVeryEdgeXY
    /// </summary>
    public unsafe bool RemoteBatmobileAllowedToVeryEdgeXY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bIsRiddlerCave
    /// </summary>
    public unsafe bool bIsRiddlerCave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bIsArkhamCity
    /// </summary>
    public unsafe bool bIsArkhamCity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDisableLightningStrikes
    /// </summary>
    public unsafe bool bDisableLightningStrikes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bFadeOutOWLighting
    /// </summary>
    public unsafe bool bFadeOutOWLighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bActivated
    /// </summary>
    public unsafe bool bActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bVehiclesDontBlockNavMesh
    /// </summary>
    public unsafe bool bVehiclesDontBlockNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bChatterAllowed
    /// </summary>
    public unsafe bool bChatterAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bStopDialogueOnEntry
    /// </summary>
    public unsafe bool bStopDialogueOnEntry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bNoDynamicGlideTutorial
    /// </summary>
    public unsafe bool bNoDynamicGlideTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bTestLevel
    /// </summary>
    public unsafe bool bTestLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bIsStandalone
    /// </summary>
    public unsafe bool bIsStandalone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bDisableLocalCharacterLight
    /// </summary>
    public unsafe bool bDisableLocalCharacterLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bEnableCityTutorials
    /// </summary>
    public unsafe bool bEnableCityTutorials
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// StrProperty: DesignerResponsible
    /// </summary>
    public unsafe BmSDK.FString DesignerResponsible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// StrProperty: ArtistResponsible
    /// </summary>
    public unsafe BmSDK.FString ArtistResponsible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ArrayProperty: OverrideVolumesToIgnoreForRoomNamesAndRiddles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelVolume.OtherLevelsVisibleInfo> OverrideVolumesToIgnoreForRoomNamesAndRiddles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelVolume.OtherLevelsVisibleInfo>>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: AkProps
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelVolume.OtherLevelsVisibleInfo AkProps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelVolume.OtherLevelsVisibleInfo>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: BoundaryDistrictRefActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BoundaryDistrictRefActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ArrayProperty: OtherLevelsVisibleInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> OtherLevelsVisibleInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ArrayProperty: OtherLevelLODsVisibleInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> OtherLevelLODsVisibleInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: OtherLevelsTransitionActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> OtherLevelsTransitionActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ArrayProperty: OtherLevelsTransitionActors2
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> OtherLevelsTransitionActors2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ArrayProperty: OtherLevelLODsTransitionActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> OtherLevelLODsTransitionActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ArrayProperty: OtherLevelLODsTransitionActors2
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> OtherLevelLODsTransitionActors2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// StrProperty: ForceHideLOD2
    /// </summary>
    public unsafe BmSDK.FString ForceHideLOD2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// StructProperty: LevelWind
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LevelWind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: RainIntensity
    /// </summary>
    public unsafe float RainIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ByteProperty: CombatCamera
    /// </summary>
    public unsafe byte CombatCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// ByteProperty: StandaloneGroup
    /// </summary>
    public unsafe byte StandaloneGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 989); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 989); }
    }

    /// <summary>
    /// ByteProperty: BoundaryDistrict
    /// </summary>
    public unsafe byte BoundaryDistrict
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 990); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 990); }
    }

    /// <summary>
    /// ArrayProperty: OverrideDeathMovie
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> OverrideDeathMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: VantagePointCheckWorldZ
    /// </summary>
    public unsafe float VantagePointCheckWorldZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenRandomBarks
    /// </summary>
    public unsafe float MinTimeBetweenRandomBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// FloatProperty: Priority
    /// </summary>
    public unsafe float Priority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: OverrideBatclawRange
    /// </summary>
    public unsafe float OverrideBatclawRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: RoofTopLevel
    /// </summary>
    public unsafe float RoofTopLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: StreetLevel
    /// </summary>
    public unsafe float StreetLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: TrimBatmobileRouteMinRange
    /// </summary>
    public unsafe float TrimBatmobileRouteMinRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: RemoteBatmobileAllowedToVeryEdgePlusX
    /// </summary>
    public unsafe float RemoteBatmobileAllowedToVeryEdgePlusX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: RemoteBatmobileAllowedToVeryEdgeMinusX
    /// </summary>
    public unsafe float RemoteBatmobileAllowedToVeryEdgeMinusX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: RemoteBatmobileAllowedToVeryEdgePlusY
    /// </summary>
    public unsafe float RemoteBatmobileAllowedToVeryEdgePlusY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: RemoteBatmobileAllowedToVeryEdgeMinusY
    /// </summary>
    public unsafe float RemoteBatmobileAllowedToVeryEdgeMinusY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: LocalCharacterLightBrightness
    /// </summary>
    public unsafe float LocalCharacterLightBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }
}
