#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GFxMovieHudMenu<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class GFxMovieHudMenu : BmSDK.GFxUI.GFxMoviePlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GFxMovieHudMenu", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GFxMovieHudMenu() { }

    /// <summary>
    /// Constructs a new GFxMovieHudMenu
    /// </summary>
    public GFxMovieHudMenu(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GFxMovieHudMenu Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GFxMovieHudMenu(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: pMovie
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT pMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: pCaptureKeys
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT pCaptureKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: pFocusIgnoreKeys
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT pFocusIgnoreKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// MapProperty: ASUClasses
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ ASUClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// MapProperty: ASUObjects
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ ASUObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: NextASUObject
    /// </summary>
    public unsafe int NextASUObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// BoolProperty: bCurrentlyInAsyncUpdate
    /// </summary>
    public unsafe bool bCurrentlyInAsyncUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bMovieIsOpen
    /// </summary>
    public unsafe bool bMovieIsOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bGamePadUsed
    /// </summary>
    public unsafe bool bGamePadUsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bGamePadUsedFirstSet
    /// </summary>
    public unsafe bool bGamePadUsedFirstSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bAllowUnboundInput
    /// </summary>
    public unsafe bool bAllowUnboundInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bDepthTested
    /// </summary>
    public unsafe bool bDepthTested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bForcedUSFSynching
    /// </summary>
    public unsafe bool bForcedUSFSynching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bWorldRendered
    /// </summary>
    public unsafe bool bWorldRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bWorld3DApplied
    /// </summary>
    public unsafe bool bWorld3DApplied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bDisplayWithHudOff
    /// </summary>
    public unsafe bool bDisplayWithHudOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bNoAutomaticAdvance
    /// </summary>
    public unsafe bool bNoAutomaticAdvance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bNoDrawIfGamePaused
    /// </summary>
    public unsafe bool bNoDrawIfGamePaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bSpansMultimonitorDisplays
    /// </summary>
    public unsafe bool bSpansMultimonitorDisplays
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bForceInputToCenterMonitor
    /// </summary>
    public unsafe bool bForceInputToCenterMonitor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bEnableGammaCorrection
    /// </summary>
    public unsafe bool bEnableGammaCorrection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bWidgetsInitializedThisFrame
    /// </summary>
    public unsafe bool bWidgetsInitializedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bLogUnhandedWidgetInitializations
    /// </summary>
    public unsafe bool bLogUnhandedWidgetInitializations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bAllowInput
    /// </summary>
    public unsafe bool bAllowInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bAllowFocus
    /// </summary>
    public unsafe bool bAllowFocus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysReceiveMouseInput
    /// </summary>
    public unsafe bool bAlwaysReceiveMouseInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bAutoPlay
    /// </summary>
    public unsafe bool bAutoPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bPauseGameWhileActive
    /// </summary>
    public unsafe bool bPauseGameWhileActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bDisableWorldRendering
    /// </summary>
    public unsafe bool bDisableWorldRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bCloseOnLevelChange
    /// </summary>
    public unsafe bool bCloseOnLevelChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bOnlyOwnerFocusable
    /// </summary>
    public unsafe bool bOnlyOwnerFocusable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bForceFullViewport
    /// </summary>
    public unsafe bool bForceFullViewport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bDiscardNonOwnerInput
    /// </summary>
    public unsafe bool bDiscardNonOwnerInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bCaptureInput
    /// </summary>
    public unsafe bool bCaptureInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bCaptureMouseInput
    /// </summary>
    public unsafe bool bCaptureMouseInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreMouseInput
    /// </summary>
    public unsafe bool bIgnoreMouseInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bIsSplitscreenLayoutModified
    /// </summary>
    public unsafe bool bIsSplitscreenLayoutModified
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bShowHardwareMouseCursor
    /// </summary>
    public unsafe bool bShowHardwareMouseCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bBlurLesserMovies
    /// </summary>
    public unsafe bool bBlurLesserMovies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bHideLesserMovies
    /// </summary>
    public unsafe bool bHideLesserMovies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIsPriorityBlurred
    /// </summary>
    public unsafe bool bIsPriorityBlurred
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIsPriorityHidden
    /// </summary>
    public unsafe bool bIsPriorityHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreVisibilityEffect
    /// </summary>
    public unsafe bool bIgnoreVisibilityEffect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreBlurEffect
    /// </summary>
    public unsafe bool bIgnoreBlurEffect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: MovieInfo
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// ObjectProperty: RenderTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RenderTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ObjectProperty: ExternalInterface
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExternalInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ObjectProperty: SplitscreenLayoutObject
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SplitscreenLayoutObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// IntProperty: LocalPlayerOwnerIndex
    /// </summary>
    public unsafe int LocalPlayerOwnerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// StructProperty: OwnerAction
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OwnerAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// StructProperty: ViewMatrix
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ViewMatrix
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// ArrayProperty: CaptureKeys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>> CaptureKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: FocusIgnoreKeys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>> FocusIgnoreKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ByteProperty: SceneDPG
    /// </summary>
    public unsafe byte SceneDPG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ByteProperty: TimingMode
    /// </summary>
    public unsafe byte TimingMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 417); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 417); }
    }

    /// <summary>
    /// ByteProperty: RenderTextureMode
    /// </summary>
    public unsafe byte RenderTextureMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 418); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 418); }
    }

    /// <summary>
    /// ByteProperty: Priority
    /// </summary>
    public unsafe byte Priority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 419); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 419); }
    }

    /// <summary>
    /// ArrayProperty: ExternalTextures
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>> ExternalTextures
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ArrayProperty: SoundThemes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> SoundThemes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// IntProperty: ViewportSplitscreenIndex
    /// </summary>
    public unsafe int ViewportSplitscreenIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ArrayProperty: WidgetBindings
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> WidgetBindings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// MapProperty: WidgetPathBindings
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ WidgetPathBindings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// IntProperty: SplitscreenLayoutYAdjust
    /// </summary>
    public unsafe int SplitscreenLayoutYAdjust
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// DelegateProperty: __OnPostAdvance__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnPostAdvance__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }
}
