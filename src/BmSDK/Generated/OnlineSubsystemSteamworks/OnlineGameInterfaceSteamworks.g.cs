#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: OnlineGameInterfaceSteamworks<br/>
/// (flags = 0)
/// </summary>
public partial class OnlineGameInterfaceSteamworks : BmSDK.IpDrv.OnlineGameInterfaceImpl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineGameInterfaceSteamworks() { }

    /// <summary>
    /// Constructs a new OnlineGameInterfaceSteamworks
    /// </summary>
    public OnlineGameInterfaceSteamworks(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineGameInterfaceSteamworks Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineGameInterfaceSteamworks(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ServerBrowserSearchQuery
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FMatchmakingQueryState ServerBrowserSearchQuery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FMatchmakingQueryState>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// StructProperty: InviteSearchQuery
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FMatchmakingQueryState InviteSearchQuery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FMatchmakingQueryState>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// FloatProperty: ServerBrowserTimeout
    /// </summary>
    public unsafe float ServerBrowserTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: InviteTimeout
    /// </summary>
    public unsafe float InviteTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// StructProperty: InviteServerUID
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId InviteServerUID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ArrayProperty: GameInviteAcceptedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> GameInviteAcceptedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: InviteGameSearch
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSearch InviteGameSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSearch>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// StrProperty: InviteLocationUrl
    /// </summary>
    public unsafe BmSDK.FString InviteLocationUrl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ArrayProperty: RegisterPlayerCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> RegisterPlayerCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ArrayProperty: UnregisterPlayerCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> UnregisterPlayerCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bFilterEngineBuild
    /// </summary>
    public unsafe bool bFilterEngineBuild
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// ArrayProperty: FilterKeyToSteamKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FFilterKeyToSteamKeyMapping> FilterKeyToSteamKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FFilterKeyToSteamKeyMapping>>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// DelegateProperty: __OnGameInviteAccepted__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnGameInviteAccepted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// DelegateProperty: __OnRegisterPlayerComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRegisterPlayerComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// DelegateProperty: __OnUnregisterPlayerComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnUnregisterPlayerComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// Struct: FMatchmakingQueryState
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FMatchmakingQueryState
    {
        /// <summary>
        /// ObjectProperty: GameSearch
        /// </summary>
        public unsafe BmSDK.Engine.OnlineGameSearch GameSearch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSearch>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: QueryToRulesResponseMap
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FServerQueryToRulesResponseMapping> QueryToRulesResponseMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FServerQueryToRulesResponseMapping>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: QueryToPingResponseMap
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FServerQueryToPingResponseMapping> QueryToPingResponseMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FServerQueryToPingResponseMapping>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: ServerListResponse
        /// </summary>
        public unsafe System.IntPtr ServerListResponse
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ByteProperty: CurrentMatchmakingType
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.ESteamMatchmakingType CurrentMatchmakingType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.ESteamMatchmakingType>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: CurrentMatchmakingQuery
        /// </summary>
        public unsafe System.IntPtr CurrentMatchmakingQuery
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// ArrayProperty: ActiveClientsideFilters
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FClientFilterORClause> ActiveClientsideFilters
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FClientFilterORClause>>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// ArrayProperty: PendingRulesSearchSettings
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineGameSettings> PendingRulesSearchSettings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineGameSettings>>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// ArrayProperty: PendingPingSearchSettings
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineGameSettings> PendingPingSearchSettings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineGameSettings>>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// BoolProperty: bIgnoreRefreshComplete
        /// </summary>
        public unsafe bool bIgnoreRefreshComplete
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }; }
        }

        /// <summary>
        /// FloatProperty: LastActivityTimestamp
        /// </summary>
        public unsafe float LastActivityTimestamp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }
    }

    /// <summary>
    /// Struct: FClientFilterORClause
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FClientFilterORClause
    {
        /// <summary>
        /// StructProperty: OrParams
        /// </summary>
        public unsafe BmSDK.GameObject.FMultiMap_Mirror OrParams
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMultiMap_Mirror>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: ESteamMatchmakingType
    /// </summary>
    public enum ESteamMatchmakingType
    {
        SMT_Invalid = 0,
        SMT_LAN = 1,
        SMT_Internet = 2,
        SMT_MAX = 3,
    }

    /// <summary>
    /// Struct: FServerQueryToPingResponseMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FServerQueryToPingResponseMapping
    {
        /// <summary>
        /// IntProperty: Query
        /// </summary>
        public unsafe int Query
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Response
        /// </summary>
        public unsafe System.IntPtr Response
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FServerQueryToRulesResponseMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FServerQueryToRulesResponseMapping
    {
        /// <summary>
        /// IntProperty: Query
        /// </summary>
        public unsafe int Query
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Response
        /// </summary>
        public unsafe System.IntPtr Response
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
