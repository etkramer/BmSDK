#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBM2Behaviour_IdleConfig<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBM2Behaviour_IdleConfig : BmSDK.BmGame.RBMBehaviour_MoveToBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBM2Behaviour_IdleConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBM2Behaviour_IdleConfig() { }

    /// <summary>
    /// Constructs a new RBM2Behaviour_IdleConfig
    /// </summary>
    public RBM2Behaviour_IdleConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBM2Behaviour_IdleConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBM2Behaviour_IdleConfig(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: IdleConfig
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT IdleConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: Prop
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Prop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: PropSearch
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PropSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLookAtTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentLookAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ObjectProperty: AEC_Dummy
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AEC_Dummy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// ObjectProperty: LinkActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationLocator
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InterrogationLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ArrayProperty: Props
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>> Props
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bSearchingForClosestProp
    /// </summary>
    public unsafe bool bSearchingForClosestProp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bMirrorEverything
    /// </summary>
    public unsafe bool bMirrorEverything
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreOverlaysWhenExiting
    /// </summary>
    public unsafe bool bIgnoreOverlaysWhenExiting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bCanExitDuringTransIn
    /// </summary>
    public unsafe bool bCanExitDuringTransIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bDontInitialiseIdleTime
    /// </summary>
    public unsafe bool bDontInitialiseIdleTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExtendStasisRangeForDialogue
    /// </summary>
    public unsafe bool bExtendStasisRangeForDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bAllowedToLookAtThings
    /// </summary>
    public unsafe bool bAllowedToLookAtThings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bEnableProximityChecks
    /// </summary>
    public unsafe bool bEnableProximityChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bAllowTurningForAims
    /// </summary>
    public unsafe bool bAllowTurningForAims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bNoLookAtsConnected
    /// </summary>
    public unsafe bool bNoLookAtsConnected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExposeTransitionOptions
    /// </summary>
    public unsafe bool bExposeTransitionOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExposedTransitionOptions
    /// </summary>
    public unsafe bool bExposedTransitionOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreTransitionIn
    /// </summary>
    public unsafe bool bIgnoreTransitionIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreTransitionOut
    /// </summary>
    public unsafe bool bIgnoreTransitionOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExposeRandomAnimationToggle
    /// </summary>
    public unsafe bool bExposeRandomAnimationToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExposedRandomAnimationToggle
    /// </summary>
    public unsafe bool bExposedRandomAnimationToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bDisallowRandomAnimations
    /// </summary>
    public unsafe bool bDisallowRandomAnimations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExposeLinkActor
    /// </summary>
    public unsafe bool bExposeLinkActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bExposedLinkActor
    /// </summary>
    public unsafe bool bExposedLinkActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bLinkedSlave
    /// </summary>
    public unsafe bool bLinkedSlave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bHasFiredWalkOutput
    /// </summary>
    public unsafe bool bHasFiredWalkOutput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bEventRequested
    /// </summary>
    public unsafe bool bEventRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bAllowStartlesDuringEvent
    /// </summary>
    public unsafe bool bAllowStartlesDuringEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bPlayingEvent
    /// </summary>
    public unsafe bool bPlayingEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bPlayingRandomAnimation
    /// </summary>
    public unsafe bool bPlayingRandomAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bPlayingStartledAnimation
    /// </summary>
    public unsafe bool bPlayingStartledAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bPlayingDialogueRandomAnimation
    /// </summary>
    public unsafe bool bPlayingDialogueRandomAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bHasRandomsWithNoMovement
    /// </summary>
    public unsafe bool bHasRandomsWithNoMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bHasDialogueRandomsWithNoMovement
    /// </summary>
    public unsafe bool bHasDialogueRandomsWithNoMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bInDialogueLook
    /// </summary>
    public unsafe bool bInDialogueLook
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bInNPCDialogueLook
    /// </summary>
    public unsafe bool bInNPCDialogueLook
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bInNPCDialogueLookIdle
    /// </summary>
    public unsafe bool bInNPCDialogueLookIdle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bInTransitionIn
    /// </summary>
    public unsafe bool bInTransitionIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bInTransitionOut
    /// </summary>
    public unsafe bool bInTransitionOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bStoredIsInAnyTransition
    /// </summary>
    public unsafe bool bStoredIsInAnyTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bStoredIsPlayingOverlay
    /// </summary>
    public unsafe bool bStoredIsPlayingOverlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bOnExitEnterCombat
    /// </summary>
    public unsafe bool bOnExitEnterCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bIsHostageThatShouldBlockNavHere
    /// </summary>
    public unsafe bool bIsHostageThatShouldBlockNavHere
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bAllowRandomTransitionsIfBatmanClose
    /// </summary>
    public unsafe bool bAllowRandomTransitionsIfBatmanClose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bForceIdleAsInAllowed
    /// </summary>
    public unsafe bool bForceIdleAsInAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// ByteProperty: StasisType
    /// </summary>
    public unsafe byte StasisType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: CurrentLookAtTargetPriority
    /// </summary>
    public unsafe float CurrentLookAtTargetPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// NameProperty: CurrentLookAtBone
    /// </summary>
    public unsafe BmSDK.FName CurrentLookAtBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: CurrentLookTimer
    /// </summary>
    public unsafe float CurrentLookTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: TimeTillNextLookCheck
    /// </summary>
    public unsafe float TimeTillNextLookCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// StructProperty: MoveOptions
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MoveOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StructProperty: CSOptions
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CSOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: PredBarkFudgeFactor
    /// </summary>
    public unsafe float PredBarkFudgeFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// StructProperty: ProximityAndSightOptions
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ProximityAndSightOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// NameProperty: ConfigName
    /// </summary>
    public unsafe BmSDK.FName ConfigName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// IntProperty: ReservedInputLinks
    /// </summary>
    public unsafe int ReservedInputLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// IntProperty: ReservedOutputLinks
    /// </summary>
    public unsafe int ReservedOutputLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// StructProperty: TransInId
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TransInId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ArrayProperty: EventNotifyLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>> EventNotifyLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ArrayProperty: IdleNotifyLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>> IdleNotifyLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ArrayProperty: RandomNotifyLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> RandomNotifyLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// StructProperty: PlayingOverlay
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PlayingOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// IntProperty: LastRandomIndex
    /// </summary>
    public unsafe int LastRandomIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// IntProperty: LastDialogueRandomIndex
    /// </summary>
    public unsafe int LastDialogueRandomIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: RandomAnimationTimer
    /// </summary>
    public unsafe float RandomAnimationTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: NPCDialogueRandomAnimationTimer
    /// </summary>
    public unsafe float NPCDialogueRandomAnimationTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// IntProperty: EventRequested
    /// </summary>
    public unsafe int EventRequested
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// StructProperty: DialogueLookStartPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DialogueLookStartPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: DialogueLookStartYaw
    /// </summary>
    public unsafe float DialogueLookStartYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// StructProperty: TraceLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TraceLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// StructProperty: TraceNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TraceNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// IntProperty: SpawnFix
    /// </summary>
    public unsafe int SpawnFix
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// IntProperty: QueueAbsoluteTeleport
    /// </summary>
    public unsafe int QueueAbsoluteTeleport
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: nextPossibleWalkVariantTriggerTime
    /// </summary>
    public unsafe float nextPossibleWalkVariantTriggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }
}
