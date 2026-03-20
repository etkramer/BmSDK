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
    public unsafe BmSDK.BmScript.RGFxMovieUI_MainMenu.MMPopTypes PopupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_MainMenu.MMPopTypes>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ByteProperty: m_eWBIDStatus
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDOverlayManager.WBIDStatus m_eWBIDStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDOverlayManager.WBIDStatus>(Ptr + 1077); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1077); }
    }

    /// <summary>
    /// ByteProperty: m_eWBIDStatusWhenOpeningWBPlayFlow
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDOverlayManager.WBIDStatus m_eWBIDStatusWhenOpeningWBPlayFlow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDOverlayManager.WBIDStatus>(Ptr + 1078); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bOrbisBeginSignIn
    /// </summary>
    public unsafe bool bOrbisBeginSignIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsSaveInProgress
    /// </summary>
    public unsafe bool bIsSaveInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsPC
    /// </summary>
    public unsafe bool bIsPC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsDurango
    /// </summary>
    public unsafe bool bIsDurango
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsOrbis
    /// </summary>
    public unsafe bool bIsOrbis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsDemo
    /// </summary>
    public unsafe bool bIsDemo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bInGameStore
    /// </summary>
    public unsafe bool bInGameStore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bEventCalendar
    /// </summary>
    public unsafe bool bEventCalendar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bRequestedMWRating
    /// </summary>
    public unsafe bool bRequestedMWRating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bMWReadPending
    /// </summary>
    public unsafe bool bMWReadPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bMWFetchSuccess
    /// </summary>
    public unsafe bool bMWFetchSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bMWMainBoard
    /// </summary>
    public unsafe bool bMWMainBoard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bBeatenByActive
    /// </summary>
    public unsafe bool bBeatenByActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bNewDLCMsg
    /// </summary>
    public unsafe bool bNewDLCMsg
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: MOTDRequested
    /// </summary>
    public unsafe bool MOTDRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bCheatHoldLock
    /// </summary>
    public unsafe bool bCheatHoldLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: CMan
    /// </summary>
    public unsafe BmSDK.BmGame.RChallengeManager CMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChallengeManager>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: ActivePopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ActivePopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: InstallerGFxMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie InstallerGFxMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: InstallerMovieUI
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_InstallationMessage InstallerMovieUI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_InstallationMessage>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ObjectProperty: WBIDOverlays
    /// </summary>
    public unsafe BmSDK.BmScript.MGFxMovieUI_WBIDMain WBIDOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MGFxMovieUI_WBIDMain>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ObjectProperty: ManagerRef
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDOverlayManager ManagerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDOverlayManager>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ObjectProperty: DataMessage
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDDataMessage DataMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDDataMessage>(Ptr + 1132); }
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
    public unsafe BmSDK.TArray<BmSDK.GFxUI.SwfMovie> WBIDMovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.SwfMovie>>(Ptr + 1200); }
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
