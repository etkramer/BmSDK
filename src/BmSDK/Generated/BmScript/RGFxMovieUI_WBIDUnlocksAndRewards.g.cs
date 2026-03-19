#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_WBIDUnlocksAndRewards<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_WBIDUnlocksAndRewards : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_WBIDUnlocksAndRewards() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_WBIDUnlocksAndRewards
    /// </summary>
    public RGFxMovieUI_WBIDUnlocksAndRewards(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_WBIDUnlocksAndRewards Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_WBIDUnlocksAndRewards(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: SaveOnClose
    /// </summary>
    public unsafe bool SaveOnClose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bOrbisBeginSignIn
    /// </summary>
    public unsafe bool bOrbisBeginSignIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bIsPC
    /// </summary>
    public unsafe bool bIsPC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bIsDurango
    /// </summary>
    public unsafe bool bIsDurango
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bIsOrbis
    /// </summary>
    public unsafe bool bIsOrbis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bIsDemo
    /// </summary>
    public unsafe bool bIsDemo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: ScreenFailedToLoad
    /// </summary>
    public unsafe bool ScreenFailedToLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: RewardManifestSuccessful
    /// </summary>
    public unsafe bool RewardManifestSuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: MobileReleaseOverlayEnabled
    /// </summary>
    public unsafe bool MobileReleaseOverlayEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: MobileReleaseOverlayShown
    /// </summary>
    public unsafe bool MobileReleaseOverlayShown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: ShowTabPrompt
    /// </summary>
    public unsafe bool ShowTabPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: ReturnToMainMenu
    /// </summary>
    public unsafe bool ReturnToMainMenu
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: RGI
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RGI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ObjectProperty: WBIDOverlays
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WBIDOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: ManagerRef
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ManagerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: DataMessage
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DataMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// StrProperty: FlashPath
    /// </summary>
    public unsafe BmSDK.FString FlashPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// IntProperty: NumberOfPendingRewards
    /// </summary>
    public unsafe int NumberOfPendingRewards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ArrayProperty: WBIDMovieInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> WBIDMovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ByteProperty: PopupType
    /// </summary>
    public unsafe byte PopupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// StrProperty: MOTD_SelectedTab
    /// </summary>
    public unsafe BmSDK.FString MOTD_SelectedTab
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// StrProperty: MOTD_SelectedNode
    /// </summary>
    public unsafe BmSDK.FString MOTD_SelectedNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// StrProperty: MobileReleaseMessage
    /// </summary>
    public unsafe BmSDK.FString MobileReleaseMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ArrayProperty: ActiveCustomRequestIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ActiveCustomRequestIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// StructProperty: CurrentReward
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentReward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }
}
