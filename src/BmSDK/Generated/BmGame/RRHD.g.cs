#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRHD<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RRHD : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRHD", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRHD() { }

    /// <summary>
    /// Constructs a new RRHD
    /// </summary>
    public RRHD(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRHD Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRHD(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRHD>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRHD>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRHD>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRHD>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRHD>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRHD>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRHD>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bCanResonate
    /// </summary>
    public unsafe bool bCanResonate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bCanResonateHS
    /// </summary>
    public unsafe bool bCanResonateHS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bCanResonateRiddler
    /// </summary>
    public unsafe bool bCanResonateRiddler
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: CurrentTargetOutOfRange
    /// </summary>
    public unsafe bool CurrentTargetOutOfRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: PreviousTargetOutOfRange
    /// </summary>
    public unsafe bool PreviousTargetOutOfRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bSecondaryTargetBeamsAreVisible
    /// </summary>
    public unsafe bool bSecondaryTargetBeamsAreVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: CodeDownloadInProgress
    /// </summary>
    public unsafe bool CodeDownloadInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bForceRHDScreenUpdate
    /// </summary>
    public unsafe bool bForceRHDScreenUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bDeployingBroadcastAnalyser
    /// </summary>
    public unsafe bool bDeployingBroadcastAnalyser
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasBlindDroneUpgrade
    /// </summary>
    public unsafe bool bBatmanHasBlindDroneUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bDebugTargeting
    /// </summary>
    public unsafe bool bDebugTargeting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bPasswordCrackingMode
    /// </summary>
    public unsafe bool bPasswordCrackingMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bCanEnterPasswordCrackingMode
    /// </summary>
    public unsafe bool bCanEnterPasswordCrackingMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bSwitchingBlindedDroneThoughtHasBeenPlayed
    /// </summary>
    public unsafe bool bSwitchingBlindedDroneThoughtHasBeenPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bBrainHackingActive
    /// </summary>
    public unsafe bool bBrainHackingActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// FloatProperty: DisruptorRange
    /// </summary>
    public unsafe float DisruptorRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// ObjectProperty: PasswordCrackingMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PasswordCrackingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ObjectProperty: RemoteControlMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RemoteControlMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// ObjectProperty: PreviousTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviousTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// ObjectProperty: RemoteSwitch
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RemoteSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// ObjectProperty: LastStartleControl
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastStartleControl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// ObjectProperty: cachedHelicopter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT cachedHelicopter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// ObjectProperty: MinidroneControllerIsOutOfRangeThought
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MinidroneControllerIsOutOfRangeThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// ObjectProperty: MinidroneNeedsATargetThought
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MinidroneNeedsATargetThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ObjectProperty: MinidroneExtraTutorialThought
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MinidroneExtraTutorialThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ObjectProperty: TargetIsOutOfRangeThought
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetIsOutOfRangeThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// ObjectProperty: RestrictedTargetsSequenceAction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RestrictedTargetsSequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ObjectProperty: SuccessBeepSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SuccessBeepSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// ObjectProperty: EventStartSequencer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventStartSequencer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// ObjectProperty: EventStopSequencer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventStopSequencer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// ObjectProperty: EventStickStable
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventStickStable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// ObjectProperty: EventBothSticksStable
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventBothSticksStable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// ObjectProperty: EventBothSticksCorrect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventBothSticksCorrect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2212); }
    }

    /// <summary>
    /// ObjectProperty: EventDisruptConfirm
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventDisruptConfirm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// ObjectProperty: EventLeftStickStartMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventLeftStickStartMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2228); }
    }

    /// <summary>
    /// ObjectProperty: EventLeftStickStopMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventLeftStickStopMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// ObjectProperty: EventRightStickStartMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventRightStickStartMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// ObjectProperty: EventRightStickStopMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventRightStickStopMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// ObjectProperty: CachedKismetHelpText
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CachedKismetHelpText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// ObjectProperty: ThumbPadMIC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThumbPadMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// ObjectProperty: CurrentBlindedDroneTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentBlindedDroneTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// ObjectProperty: BlindedDroneSoundStart
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BlindedDroneSoundStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// ObjectProperty: BlindedDroneSoundFiveSecondsLeft
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BlindedDroneSoundFiveSecondsLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// ObjectProperty: BlindedDroneSoundReactivates
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BlindedDroneSoundReactivates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// ObjectProperty: LockInRemoteSwitch
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LockInRemoteSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// ObjectProperty: StartupBeamVFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StartupBeamVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// ObjectProperty: TriggerTargetBeamVFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TriggerTargetBeamVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// ObjectProperty: FailedFireSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FailedFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// ObjectProperty: TargetOnFocusSFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetOnFocusSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// ObjectProperty: MiniDroneCodesDownloadingSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MiniDroneCodesDownloadingSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// ObjectProperty: MiniDroneCodesSuccessfullyDownloadedSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MiniDroneCodesSuccessfullyDownloadedSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2356); }
    }

    /// <summary>
    /// ObjectProperty: SwitchingBlindedDroneThought
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SwitchingBlindedDroneThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// FloatProperty: LeftThumbOffset
    /// </summary>
    public unsafe float LeftThumbOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// FloatProperty: RightThumbOffset
    /// </summary>
    public unsafe float RightThumbOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// StructProperty: FireAnimationId
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FireAnimationId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// IntProperty: MaxSecondaryTargets
    /// </summary>
    public unsafe int MaxSecondaryTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// ArrayProperty: InitialSecondaryTargetBeams
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> InitialSecondaryTargetBeams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 2388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2388); }
    }

    /// <summary>
    /// ArrayProperty: SecondaryTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> SecondaryTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// ArrayProperty: TriggerTargetBeams
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> TriggerTargetBeams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// ArrayProperty: TriggerTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> TriggerTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// FloatProperty: cachedHelicopterCodeDownloadedProportion
    /// </summary>
    public unsafe float cachedHelicopterCodeDownloadedProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// StrProperty: DownloadDroneCodesString
    /// </summary>
    public unsafe BmSDK.FString DownloadDroneCodesString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// FloatProperty: ScreenLightBrightness
    /// </summary>
    public unsafe float ScreenLightBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// FloatProperty: FrequencyScore
    /// </summary>
    public unsafe float FrequencyScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// ArrayProperty: ResonatorTargetIcons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> ResonatorTargetIcons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerTargetIcons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> RiddlerTargetIcons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// ArrayProperty: PasswordArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> PasswordArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// FloatProperty: fPrimedDelay
    /// </summary>
    public unsafe float fPrimedDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// ArrayProperty: StartleTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> StartleTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// ByteProperty: CurrentBlindedDroneState
    /// </summary>
    public unsafe byte CurrentBlindedDroneState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// IntProperty: BlindedTimeRemainingRounded
    /// </summary>
    public unsafe int BlindedTimeRemainingRounded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// FloatProperty: iLockInTimeRemainingRounded
    /// </summary>
    public unsafe float iLockInTimeRemainingRounded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// Struct: FSecondaryTargetData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FSecondaryTargetData
    {
        /// <summary>
        /// ObjectProperty: Target
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Target
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bActive
        /// </summary>
        public unsafe bool bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// ComponentProperty: ConnectionBeam
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ConnectionBeam
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
