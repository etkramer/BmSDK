#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_MainMenu<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_MainMenu : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_MainMenu", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_MainMenu() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_MainMenu
    /// </summary>
    public RGFxMovieUI_MainMenu(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_MainMenu Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_MainMenu(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: FadeMode
    /// </summary>
    public unsafe int FadeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ByteProperty: PopupType
    /// </summary>
    public unsafe byte PopupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ByteProperty: m_eWBIDStatus
    /// </summary>
    public unsafe byte m_eWBIDStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1077); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1077); }
    }

    /// <summary>
    /// ByteProperty: m_eWBIDStatusWhenOpeningWBPlayFlow
    /// </summary>
    public unsafe byte m_eWBIDStatusWhenOpeningWBPlayFlow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1078); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1078); }
    }

    /// <summary>
    /// ByteProperty: NetworkDebugCheatSequence
    /// </summary>
    public unsafe byte NetworkDebugCheatSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1079); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1079); }
    }

    /// <summary>
    /// BoolProperty: bWBPlayGiftsChecked
    /// </summary>
    public unsafe bool bWBPlayGiftsChecked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bOrbisBeginSignIn
    /// </summary>
    public unsafe bool bOrbisBeginSignIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsSaveInProgress
    /// </summary>
    public unsafe bool bIsSaveInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsPC
    /// </summary>
    public unsafe bool bIsPC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsDurango
    /// </summary>
    public unsafe bool bIsDurango
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsOrbis
    /// </summary>
    public unsafe bool bIsOrbis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsDemo
    /// </summary>
    public unsafe bool bIsDemo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bInGameStore
    /// </summary>
    public unsafe bool bInGameStore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bEventCalendar
    /// </summary>
    public unsafe bool bEventCalendar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bRequestedMWRating
    /// </summary>
    public unsafe bool bRequestedMWRating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bMWReadPending
    /// </summary>
    public unsafe bool bMWReadPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bMWFetchSuccess
    /// </summary>
    public unsafe bool bMWFetchSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bMWMainBoard
    /// </summary>
    public unsafe bool bMWMainBoard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bBeatenByActive
    /// </summary>
    public unsafe bool bBeatenByActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bNewDLCMsg
    /// </summary>
    public unsafe bool bNewDLCMsg
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: MOTDRequested
    /// </summary>
    public unsafe bool MOTDRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bCheatHoldLock
    /// </summary>
    public unsafe bool bCheatHoldLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: CMan
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: ActivePopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ActivePopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: InstallerGFxMovieInstance
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InstallerGFxMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: InstallerMovieUI
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InstallerMovieUI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ObjectProperty: WBIDOverlays
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WBIDOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ObjectProperty: ManagerRef
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ManagerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ObjectProperty: DataMessage
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DataMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: UnlockedChallengeCount
    /// </summary>
    public unsafe int UnlockedChallengeCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: LatentInstallFromId
    /// </summary>
    public unsafe int LatentInstallFromId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: ASetRivalState
    /// </summary>
    public unsafe int ASetRivalState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// StrProperty: MWTargetPath
    /// </summary>
    public unsafe BmSDK.FString MWTargetPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// StrProperty: BeatenByPath
    /// </summary>
    public unsafe BmSDK.FString BeatenByPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// StrProperty: MOTDPath
    /// </summary>
    public unsafe BmSDK.FString MOTDPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ArrayProperty: WBIDMovieInfo
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> WBIDMovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadInGameStoreContentComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadInGameStoreContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// DelegateProperty: __CustomContentLoadedMOTD__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomContentLoadedMOTD__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// DelegateProperty: __CustomManifestLoadedMOTD__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomManifestLoadedMOTD__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// Enum: MMFadeAndTypes
    /// </summary>
    public enum MMFadeAndTypes
    {
        FadeAnd_None = 0,
        FadeAnd_Exit = 1,
        FadeAnd_NewGame = 2,
        FadeAnd_Continue = 3,
        FadeAnd_StartVSlice = 4,
        FadeAnd_ContinueVSlice = 5,
        FadeAnd_FreeRoam = 6,
        FadeAnd_NewGamePlus = 7,
        FadeAnd_MAX = 8,
    }

    /// <summary>
    /// Enum: MMPopTypes
    /// </summary>
    public enum MMPopTypes
    {
        MMPopType_None = 0,
        MMPopType_Exit = 1,
        MMPopType_BackFromMain = 2,
        MMPopType_NewGame = 3,
        MMPopType_NewGamePlus = 4,
        MMPopType_NewGame_VS = 5,
        MMPopType_Continue_VS = 6,
        MMPopType_NewGame_FreeRoam = 7,
        MMPopType_GoOnlineForStore = 8,
        MMPopType_OrbisNewGameSignIn = 9,
        MMPopType_OrbisContinueGameSignIn = 10,
        MMPopType_OrbisNewGamePlusSignIn = 11,
        MMPopType_OrbisContinueGamePlusSignIn = 12,
        MMPopType_OrbisChallengeSignIn = 13,
        MMPopType_OrbisSignIn = 14,
        MMPopType_Orbis_WBID = 15,
        MMPopType_NewGame_NP = 16,
        MMPopType_ContinueGame_NP = 17,
        MMPopType_NewGamePlus_NP = 18,
        MMPopType_ContinueGamePlus_NP = 19,
        MMPopType_Challenge_NP = 20,
        MMPopType_WBPlay = 21,
        MMPopType_WBPlay_GiftReward = 22,
        MMPopType_OrbisWBRewardsSignIn = 23,
        MMPopType_MinSpecWarning = 24,
        MMPopType_ModifiedIniWarning = 25,
        MMPopType_PCWBRewardsSignIn = 26,
        MMPopType_MAX = 27,
    }
}
