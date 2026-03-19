#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: _OnlineSubsystemSteamworks<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class _OnlineSubsystemSteamworks : BmSDK.IpDrv.OnlineSubsystemCommonImpl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal _OnlineSubsystemSteamworks() { }

    /// <summary>
    /// Constructs a new _OnlineSubsystemSteamworks
    /// </summary>
    public _OnlineSubsystemSteamworks(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, _OnlineSubsystemSteamworks Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected _OnlineSubsystemSteamworks(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: DLCAPI
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DLCAPI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ObjectProperty: CachedGameInt
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CachedGameInt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ObjectProperty: CachedProfile
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CachedProfile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: PlayerStorageCache
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerStorageCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: CachedAuthInt
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CachedAuthInt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ObjectProperty: CurrentStatsRead
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentStatsRead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// IntProperty: GameID
    /// </summary>
    public unsafe int GameID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// StrProperty: EncryptedProductKey
    /// </summary>
    public unsafe BmSDK.FString EncryptedProductKey
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ArrayProperty: ConnectionStatusChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> ConnectionStatusChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: ControllerChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> ControllerChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ArrayProperty: LinkStatusDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LinkStatusDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ByteProperty: CurrentNotificationPosition
    /// </summary>
    public unsafe byte CurrentNotificationPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ByteProperty: LoggedInStatus
    /// </summary>
    public unsafe byte LoggedInStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 749); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 749); }
    }

    /// <summary>
    /// ByteProperty: bWasKeyboardInputCanceled
    /// </summary>
    public unsafe byte bWasKeyboardInputCanceled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 750); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 750); }
    }

    /// <summary>
    /// ByteProperty: UserStatsReceivedState
    /// </summary>
    public unsafe byte UserStatsReceivedState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 751); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 751); }
    }

    /// <summary>
    /// StrProperty: LocalProfileName
    /// </summary>
    public unsafe BmSDK.FString LocalProfileName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StrProperty: LoggedInPlayerName
    /// </summary>
    public unsafe BmSDK.FString LoggedInPlayerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// StructProperty: LoggedInPlayerId
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LoggedInPlayerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// IntProperty: LoggedInPlayerNum
    /// </summary>
    public unsafe int LoggedInPlayerNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// StrProperty: ProfileDataDirectory
    /// </summary>
    public unsafe BmSDK.FString ProfileDataDirectory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// StrProperty: ProfileDataExtension
    /// </summary>
    public unsafe BmSDK.FString ProfileDataExtension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ArrayProperty: FriendInviteReceivedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.CachedFriendMessage>>> FriendInviteReceivedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.CachedFriendMessage>>>>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ArrayProperty: FriendMessageReceivedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.CachedFriendMessage>> FriendMessageReceivedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.CachedFriendMessage>>>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ArrayProperty: AddFriendByNameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.CachedFriendMessage> AddFriendByNameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.CachedFriendMessage>>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// StructProperty: ProfileCache
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.CachedFriendMessage ProfileCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.CachedFriendMessage>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// StrProperty: CachedFriendMessage
    /// </summary>
    public unsafe BmSDK.FString CachedFriendMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ArrayProperty: LocationUrlsForInvites
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LocationUrlsForInvites
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// StrProperty: LocationUrl
    /// </summary>
    public unsafe BmSDK.FString LocationUrl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ArrayProperty: ReceivedGameInviteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>> ReceivedGameInviteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ArrayProperty: JoinFriendGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>> JoinFriendGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ArrayProperty: GetNumberOfCurrentPlayersCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>> GetNumberOfCurrentPlayersCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ArrayProperty: RegisterHostStatGuidCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>> RegisterHostStatGuidCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ArrayProperty: CachedFriendMessages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>> CachedFriendMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// BoolProperty: bStoringAchievement
    /// </summary>
    public unsafe bool bStoringAchievement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bLastHasConnection
    /// </summary>
    public unsafe bool bLastHasConnection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bHasSteamworksAccount
    /// </summary>
    public unsafe bool bHasSteamworksAccount
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bShouldUseMcp
    /// </summary>
    public unsafe bool bShouldUseMcp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bNeedsKeyboardTicking
    /// </summary>
    public unsafe bool bNeedsKeyboardTicking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bVideoRecordEnabled
    /// </summary>
    public unsafe bool bVideoRecordEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bClientStatsStorePending
    /// </summary>
    public unsafe bool bClientStatsStorePending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bGSStatsStoresSuccess
    /// </summary>
    public unsafe bool bGSStatsStoresSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bIsStatsSessionOk
    /// </summary>
    public unsafe bool bIsStatsSessionOk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: m_bReadOpComplete
    /// </summary>
    public unsafe bool m_bReadOpComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: m_bWriteOpComplete
    /// </summary>
    public unsafe bool m_bWriteOpComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: m_bDeleteOpComplete
    /// </summary>
    public unsafe bool m_bDeleteOpComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: m_bOpSuccessful
    /// </summary>
    public unsafe bool m_bOpSuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bHasReceivedSteamPrices
    /// </summary>
    public unsafe bool bHasReceivedSteamPrices
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// ArrayProperty: AchievementDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>> AchievementDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ArrayProperty: AchievementReadDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>> AchievementReadDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: ReadFriendsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>> ReadFriendsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ArrayProperty: WriteProfileSettingsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> WriteProfileSettingsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ArrayProperty: FriendsChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> FriendsChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ArrayProperty: LoginChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> LoginChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ArrayProperty: LoginFailedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> LoginFailedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ArrayProperty: LogoutCompletedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> LogoutCompletedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ArrayProperty: MutingChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> MutingChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ArrayProperty: StatusMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> StatusMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// StrProperty: DefaultStatus
    /// </summary>
    public unsafe BmSDK.FString DefaultStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// StrProperty: GameInviteMessage
    /// </summary>
    public unsafe BmSDK.FString GameInviteMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ControllerStates_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }
    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ControllerStates_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }
    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ControllerStates_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }
    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ControllerStates_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// FloatProperty: ConnectionPresenceTimeInterval
    /// </summary>
    public unsafe float ConnectionPresenceTimeInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: ConnectionPresenceElapsedTime
    /// </summary>
    public unsafe float ConnectionPresenceElapsedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// ArrayProperty: PendingRedirects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PendingRedirects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// StrProperty: KeyboardResultsString
    /// </summary>
    public unsafe BmSDK.FString KeyboardResultsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// ArrayProperty: KeyboardInputDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests>>>>>> KeyboardInputDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests>>>>>>>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// ArrayProperty: AchievementMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests>>>>> AchievementMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests>>>>>>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// ArrayProperty: LocalPlayerStorageReadDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests>>>> LocalPlayerStorageReadDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests>>>>>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ArrayProperty: LocalPlayerStorageWriteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests>>> LocalPlayerStorageWriteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests>>>>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// ArrayProperty: RemotePlayerStorageReadDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests>> RemotePlayerStorageReadDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests>>>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// ArrayProperty: PendingAchievementProgress
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests> PendingAchievementProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests>>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// StructProperty: DeviceCache
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests DeviceCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.QueuedAvatarRequests>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// ArrayProperty: QueuedAvatarRequests
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>>>>>>> QueuedAvatarRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>>>>>>>>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// ArrayProperty: AccountCreateDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>>>>>> AccountCreateDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>>>>>>>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// IntProperty: TotalGSStatsStoresPending
    /// </summary>
    public unsafe int TotalGSStatsStoresPending
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// ArrayProperty: ReadOnlineStatsCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>>>>> ReadOnlineStatsCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>>>>>>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// ArrayProperty: FlushOnlineStatsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>>>> FlushOnlineStatsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>>>>>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// ArrayProperty: PendingStats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>>> PendingStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>>>>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// ArrayProperty: LeaderboardList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>> LeaderboardList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>>>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// ArrayProperty: DeferredLeaderboardReads
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>> DeferredLeaderboardReads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// ArrayProperty: DeferredLeaderboardWrites
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>> DeferredLeaderboardWrites
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// ArrayProperty: PendingLeaderboardStats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>> PendingLeaderboardStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// ArrayProperty: GameServerStatsMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir> GameServerStatsMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// StructProperty: ContentCache
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir ContentCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.DLCRootDir>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// StrProperty: DLCRootDir
    /// </summary>
    public unsafe BmSDK.FString DLCRootDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// ArrayProperty: ReadTitleFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>> ReadTitleFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// ArrayProperty: SharedFileCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>> SharedFileCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// ArrayProperty: SpeechRecognitionCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>> SpeechRecognitionCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// ArrayProperty: TalkingDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>> TalkingDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// ArrayProperty: MuteList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>> MuteList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// StructProperty: CurrentLocalTalker
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentLocalTalker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// ArrayProperty: RemoteTalkers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>> RemoteTalkers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// ArrayProperty: EnumerateUserFilesCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>> EnumerateUserFilesCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ArrayProperty: ReadUserFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>> ReadUserFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ArrayProperty: WriteUserFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>> WriteUserFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ArrayProperty: DeleteUserFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>> DeleteUserFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// ArrayProperty: ReadDownloadFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> ReadDownloadFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// ArrayProperty: WriteDownloadFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> WriteDownloadFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// ArrayProperty: DeleteDownloadFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> DeleteDownloadFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// ArrayProperty: UserCloudFiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> UserCloudFiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// ArrayProperty: UserCloudMetadata
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> UserCloudMetadata
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// ArrayProperty: SharedFileReadCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> SharedFileReadCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// ArrayProperty: SharedFileWriteCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SharedFileWriteCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// StrProperty: m_DownloadFileName
    /// </summary>
    public unsafe BmSDK.FString m_DownloadFileName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// StructProperty: m_DownloadFileDescriptor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT m_DownloadFileDescriptor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// StructProperty: m_DownloadFileTask
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT m_DownloadFileTask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// IntProperty: m_bytesProcessed
    /// </summary>
    public unsafe int m_bytesProcessed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// ArrayProperty: CachedSteamPrices
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> CachedSteamPrices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// DelegateProperty: __OnLinkStatusChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLinkStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// DelegateProperty: __OnExternalUIChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnExternalUIChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// DelegateProperty: __OnControllerChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnControllerChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// DelegateProperty: __OnConnectionStatusChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnConnectionStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// DelegateProperty: __OnStorageDeviceChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnStorageDeviceChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoginChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginCancelled__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoginCancelled__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// DelegateProperty: __OnMutingChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnMutingChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// DelegateProperty: __OnFriendsChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFriendsChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginFailed__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoginFailed__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// DelegateProperty: __OnLogoutCompleted__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLogoutCompleted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginStatusChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoginStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadProfileSettingsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadProfileSettingsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteProfileSettingsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteProfileSettingsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// DelegateProperty: __OnGetNumberOfCurrentPlayersComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnGetNumberOfCurrentPlayersComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadPlayerStorageComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadPlayerStorageComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadPlayerStorageForNetIdComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadPlayerStorageForNetIdComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// DelegateProperty: __OnWritePlayerStorageComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWritePlayerStorageComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadFriendsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadFriendsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// DelegateProperty: __OnKeyboardInputComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnKeyboardInputComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// DelegateProperty: __OnAddFriendByNameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnAddFriendByNameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// DelegateProperty: __OnFriendInviteReceived__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFriendInviteReceived__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// DelegateProperty: __OnReceivedGameInvite__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReceivedGameInvite__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// DelegateProperty: __OnJoinFriendGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnJoinFriendGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// DelegateProperty: __OnFriendMessageReceived__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFriendMessageReceived__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// DelegateProperty: __OnUnlockAchievementComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnUnlockAchievementComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadAchievementsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadAchievementsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// DelegateProperty: __OnMsgBoxUIComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnMsgBoxUIComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeviceSelectionComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDeviceSelectionComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// DelegateProperty: __OnProfileDataChanged__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnProfileDataChanged__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// DelegateProperty: __OnNewInfocast__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnNewInfocast__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadCrossTitleProfileSettingsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadCrossTitleProfileSettingsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadOnlineAvatarComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadOnlineAvatarComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// DelegateProperty: __OnGTCCommand__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnGTCCommand__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// DelegateProperty: __OnCreateOnlineAccountCompleted__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCreateOnlineAccountCompleted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadOnlineStatsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadOnlineStatsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// DelegateProperty: __OnFlushOnlineStatsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFlushOnlineStatsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// DelegateProperty: __OnRegisterHostStatGuidComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRegisterHostStatGuidComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// DelegateProperty: __OnContentChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnContentChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadContentComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// DelegateProperty: __OnContentStatusChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnContentStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadInGameStoreContentComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadInGameStoreContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// DelegateProperty: __OnPurchaseInGameStoreContentComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnPurchaseInGameStoreContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadCrossTitleContentComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadCrossTitleContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadCrossTitleSaveGameDataComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadCrossTitleSaveGameDataComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }

    /// <summary>
    /// DelegateProperty: __OnQueryAvailableDownloadsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnQueryAvailableDownloadsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2800); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadSaveGameDataComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadSaveGameDataComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteSaveGameDataComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteSaveGameDataComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2832); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadTitleFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadTitleFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2848); }
    }

    /// <summary>
    /// DelegateProperty: __OnRequestTitleFileListComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRequestTitleFileListComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2864); }
    }

    /// <summary>
    /// DelegateProperty: __OnPlayerTalkingStateChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnPlayerTalkingStateChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2880); }
    }

    /// <summary>
    /// DelegateProperty: __OnRecognitionComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRecognitionComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2896); }
    }

    /// <summary>
    /// DelegateProperty: __OnEnumerateUserFilesComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnEnumerateUserFilesComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2912); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadUserFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadUserFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteUserFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteUserFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeleteUserFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDeleteUserFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2960); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadDownloadFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadDownloadFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2976); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteDownloadFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteDownloadFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2992); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeleteDownloadFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDeleteDownloadFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3008); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadSharedFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadSharedFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3024); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteSharedFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteSharedFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3040); }
    }

    /// <summary>
    /// DelegateProperty: __OnRequestComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRequestComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3056); }
    }

    /// <summary>
    /// DelegateProperty: __SteamDLCCallback__Delegate
    /// </summary>
    public unsafe System.IntPtr __SteamDLCCallback__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3072); }
    }
}
