#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_Interp<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_Interp : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_Interp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_Interp() { }

    /// <summary>
    /// Constructs a new SeqAct_Interp
    /// </summary>
    public SeqAct_Interp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_Interp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_Interp(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_AkEvaluate
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_AkEvaluate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// MapProperty: SavedActorTransforms
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ SavedActorTransforms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// MapProperty: SavedActorVisibilities
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ SavedActorVisibilities
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: OriginActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OriginActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// ObjectProperty: InterpData
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InterpData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ObjectProperty: ReplicatedActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReplicatedActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ObjectProperty: PropertySheet
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp.RocksteadyOwner PropertySheet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp.RocksteadyOwner>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ClassProperty: ReplicatedActorClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReplicatedActorClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// BoolProperty: bOriginActorWasNULL
    /// </summary>
    public unsafe bool bOriginActorWasNULL
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: ForceEnableDebugOverlayIfNotRendering
    /// </summary>
    public unsafe bool ForceEnableDebugOverlayIfNotRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: ForceEnableDebugOverlay
    /// </summary>
    public unsafe bool ForceEnableDebugOverlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bIsPlaying
    /// </summary>
    public unsafe bool bIsPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bPaused
    /// </summary>
    public unsafe bool bPaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bIsBeingEdited
    /// </summary>
    public unsafe bool bIsBeingEdited
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bLooping
    /// </summary>
    public unsafe bool bLooping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bDisableLoopingWhenAutoCapturing
    /// </summary>
    public unsafe bool bDisableLoopingWhenAutoCapturing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bTriggerStoppedInsteadOfCompleted
    /// </summary>
    public unsafe bool bTriggerStoppedInsteadOfCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bRewindOnPlay
    /// </summary>
    public unsafe bool bRewindOnPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bRewindToEndOnReverse
    /// </summary>
    public unsafe bool bRewindToEndOnReverse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bNoResetOnRewind
    /// </summary>
    public unsafe bool bNoResetOnRewind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bSingleScreenCutscene
    /// </summary>
    public unsafe bool bSingleScreenCutscene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bRewindIfAlreadyPlaying
    /// </summary>
    public unsafe bool bRewindIfAlreadyPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bReversePlayback
    /// </summary>
    public unsafe bool bReversePlayback
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bInterpForPathBuilding
    /// </summary>
    public unsafe bool bInterpForPathBuilding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bForceStartPos
    /// </summary>
    public unsafe bool bForceStartPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bSynchroniseWithOtherMatinees
    /// </summary>
    public unsafe bool bSynchroniseWithOtherMatinees
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bDisableRadioFilter
    /// </summary>
    public unsafe bool bDisableRadioFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bClientSideOnly
    /// </summary>
    public unsafe bool bClientSideOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bSkipUpdateIfNotVisible
    /// </summary>
    public unsafe bool bSkipUpdateIfNotVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bSkippedUpdateBecauseNotVisible
    /// </summary>
    public unsafe bool bSkippedUpdateBecauseNotVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bSkipUpdateIfGameNotRendering
    /// </summary>
    public unsafe bool bSkipUpdateIfGameNotRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bSkippedUpdateBecausefGameNotRendering
    /// </summary>
    public unsafe bool bSkippedUpdateBecausefGameNotRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bIsSkippable
    /// </summary>
    public unsafe bool bIsSkippable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bDoNotSetMainViewTarget
    /// </summary>
    public unsafe bool bDoNotSetMainViewTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: AutoCapture
    /// </summary>
    public unsafe bool AutoCapture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: ExitAutoCapture
    /// </summary>
    public unsafe bool ExitAutoCapture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: GivePlayerControlDone
    /// </summary>
    public unsafe bool GivePlayerControlDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: PendingSkipOutputOnUpdate
    /// </summary>
    public unsafe bool PendingSkipOutputOnUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: PendingSkipOutputOnDeactivate
    /// </summary>
    public unsafe bool PendingSkipOutputOnDeactivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: PendingStoppedOutputOnDeactivate
    /// </summary>
    public unsafe bool PendingStoppedOutputOnDeactivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: WasSkipped
    /// </summary>
    public unsafe bool WasSkipped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: LoadedBanks
    /// </summary>
    public unsafe bool LoadedBanks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: TriggerCompletedIfSkipped
    /// </summary>
    public unsafe bool TriggerCompletedIfSkipped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bShouldShowGore
    /// </summary>
    public unsafe bool bShouldShowGore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bWasStopped
    /// </summary>
    public unsafe bool bWasStopped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: HACK_SyncTimeToAudio
    /// </summary>
    public unsafe bool HACK_SyncTimeToAudio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: EnableAudioTimeSmoothing
    /// </summary>
    public unsafe bool EnableAudioTimeSmoothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: UseMasterSyncTrackIfAvailable
    /// </summary>
    public unsafe bool UseMasterSyncTrackIfAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: dbgFirstStep
    /// </summary>
    public unsafe bool dbgFirstStep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: AudioOnSkipSetMusicToSilenceBriefly
    /// </summary>
    public unsafe bool AudioOnSkipSetMusicToSilenceBriefly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: DisableEventsOnDirectorTrack
    /// </summary>
    public unsafe bool DisableEventsOnDirectorTrack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: mCaseFileActivated
    /// </summary>
    public unsafe bool mCaseFileActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bPreviewCameraBlends
    /// </summary>
    public unsafe bool bPreviewCameraBlends
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bAllowSkippingDialoguelines
    /// </summary>
    public unsafe bool bAllowSkippingDialoguelines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bRegisterAsConversation
    /// </summary>
    public unsafe bool bRegisterAsConversation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bTerminated
    /// </summary>
    public unsafe bool bTerminated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bIsGameplayControlled
    /// </summary>
    public unsafe bool bIsGameplayControlled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// FloatProperty: PlayRate
    /// </summary>
    public unsafe float PlayRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// FloatProperty: MovementMultiplier
    /// </summary>
    public unsafe float MovementMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: Position
    /// </summary>
    public unsafe float Position
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: ForceStartPosition
    /// </summary>
    public unsafe float ForceStartPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// StrProperty: RocksteadyOwner
    /// </summary>
    public unsafe BmSDK.FString RocksteadyOwner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: RocksteadyStageOfDev
    /// </summary>
    public unsafe int RocksteadyStageOfDev
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// IntProperty: RocksteadyRevision
    /// </summary>
    public unsafe int RocksteadyRevision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// StrProperty: RocksteadyRevisionDate
    /// </summary>
    public unsafe BmSDK.FString RocksteadyRevisionDate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// IntProperty: NumFramesNotVisible
    /// </summary>
    public unsafe int NumFramesNotVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ByteProperty: SkipPosition
    /// </summary>
    public unsafe byte SkipPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ByteProperty: GivePlayerControlPosition
    /// </summary>
    public unsafe byte GivePlayerControlPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 637); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 637); }
    }

    /// <summary>
    /// ByteProperty: ConstantCameraAnim
    /// </summary>
    public unsafe byte ConstantCameraAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 638); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 638); }
    }

    /// <summary>
    /// FloatProperty: SkipCustomPosition
    /// </summary>
    public unsafe float SkipCustomPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// FloatProperty: GivePlayerControlCustomPosition
    /// </summary>
    public unsafe float GivePlayerControlCustomPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ArrayProperty: LinkedCover
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> LinkedCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ArrayProperty: GroupInst
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> GroupInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ArrayProperty: DelayedStartupGroups
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> DelayedStartupGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// IntProperty: PreferredSplitScreenNum
    /// </summary>
    public unsafe int PreferredSplitScreenNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ArrayProperty: CameraCuts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> CameraCuts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: CameraCutsNV
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CameraCutsNV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// IntProperty: CameraCutIndexNV
    /// </summary>
    public unsafe int CameraCutIndexNV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// StrProperty: CameraCutNameNV
    /// </summary>
    public unsafe BmSDK.FString CameraCutNameNV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: TerminationTime
    /// </summary>
    public unsafe float TerminationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StructProperty: m_AudioLastSyncTime
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT m_AudioLastSyncTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// StructProperty: dbgStartTime
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT dbgStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// FloatProperty: dbgRegularTime
    /// </summary>
    public unsafe float dbgRegularTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: dbgMaxDiff
    /// </summary>
    public unsafe float dbgMaxDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// FloatProperty: dbgSkipMaxDiff
    /// </summary>
    public unsafe float dbgSkipMaxDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// StructProperty: dbgDisplayTime
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT dbgDisplayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// StructProperty: dbgUnclampedTime
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT dbgUnclampedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// StructProperty: dbgAudioTime
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT dbgAudioTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// StructProperty: RenderingOverrides
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RenderingOverrides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: ConstantCameraAnimRate
    /// </summary>
    public unsafe float ConstantCameraAnimRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// StructProperty: DialogueLines
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DialogueLines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// IntProperty: PlayingSpeechId
    /// </summary>
    public unsafe int PlayingSpeechId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
}
