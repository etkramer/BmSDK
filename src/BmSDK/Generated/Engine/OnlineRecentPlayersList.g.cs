#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineRecentPlayersList<br/>
/// (flags = 0)
/// </summary>
public partial class OnlineRecentPlayersList : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineRecentPlayersList", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineRecentPlayersList() { }

    /// <summary>
    /// Constructs a new OnlineRecentPlayersList
    /// </summary>
    public OnlineRecentPlayersList(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineRecentPlayersList Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineRecentPlayersList(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetCurrentPlayersListCount
    /// </summary>
    public unsafe int GetCurrentPlayersListCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.GetCurrentPlayersListCount", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetCurrentPlayersList
    /// </summary>
    public unsafe void SetCurrentPlayersList(BmSDK.TArray<BmSDK.Engine.OnlineRecentPlayersList.FCurrentPlayerMet> Players)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.SetCurrentPlayersList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Players, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowCurrentPlayersList
    /// </summary>
    public unsafe bool ShowCurrentPlayersList(byte LocalUserNum, BmSDK.FString Title, BmSDK.FString Description)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.ShowCurrentPlayersList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: ShowLastPartyPlayerList
    /// </summary>
    public unsafe bool ShowLastPartyPlayerList(byte LocalUserNum, BmSDK.FString Title, BmSDK.FString Description)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.ShowLastPartyPlayerList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: ShowRecentPartiesPlayerList
    /// </summary>
    public unsafe bool ShowRecentPartiesPlayerList(byte LocalUserNum, BmSDK.FString Title, BmSDK.FString Description)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.ShowRecentPartiesPlayerList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: ShowRecentPlayerList
    /// </summary>
    public unsafe bool ShowRecentPlayerList(byte LocalUserNum, BmSDK.FString Title, BmSDK.FString Description)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.ShowRecentPlayerList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: SetLastParty
    /// </summary>
    public unsafe void SetLastParty(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PartyLeader, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> PartyMembers)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.SetLastParty", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartyLeader, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PartyMembers = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: GetTeamForCurrentPlayer
    /// </summary>
    public unsafe int GetTeamForCurrentPlayer(BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.GetTeamForCurrentPlayer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetSkillForCurrentPlayer
    /// </summary>
    public unsafe int GetSkillForCurrentPlayer(BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.GetSkillForCurrentPlayer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetPlayersFromCurrentPlayers
    /// </summary>
    public unsafe void GetPlayersFromCurrentPlayers(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.GetPlayersFromCurrentPlayers", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Players = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetPlayersFromRecentParties
    /// </summary>
    public unsafe void GetPlayersFromRecentParties(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.GetPlayersFromRecentParties", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Players = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: ClearRecentParties
    /// </summary>
    public unsafe void ClearRecentParties()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.ClearRecentParties", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddPartyToRecentParties
    /// </summary>
    public unsafe void AddPartyToRecentParties(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PartyLeader, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> PartyMembers)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.AddPartyToRecentParties", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartyLeader, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PartyMembers = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: ClearRecentPlayers
    /// </summary>
    public unsafe void ClearRecentPlayers()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.ClearRecentPlayers", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddPlayerToRecentPlayers
    /// </summary>
    public unsafe void AddPlayerToRecentPlayers(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NewPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineRecentPlayersList.AddPlayerToRecentPlayers", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FCurrentPlayerMet
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FCurrentPlayerMet
    {
        /// <summary>
        /// IntProperty: TeamNum
        /// </summary>
        public unsafe int TeamNum
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Skill
        /// </summary>
        public unsafe int Skill
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: NetId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FRecentParty
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRecentParty
    {
        /// <summary>
        /// StructProperty: PartyLeader
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId PartyLeader
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: PartyMembers
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> PartyMembers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: RecentPlayers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> RecentPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: RecentParties
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineRecentPlayersList.FRecentParty> RecentParties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineRecentPlayersList.FRecentParty>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: LastParty
    /// </summary>
    public unsafe BmSDK.Engine.OnlineRecentPlayersList.FRecentParty LastParty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineRecentPlayersList.FRecentParty>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: MaxRecentPlayers
    /// </summary>
    public unsafe int MaxRecentPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// IntProperty: MaxRecentParties
    /// </summary>
    public unsafe int MaxRecentParties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// IntProperty: RecentPlayersAddIndex
    /// </summary>
    public unsafe int RecentPlayersAddIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: RecentPartiesAddIndex
    /// </summary>
    public unsafe int RecentPartiesAddIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ArrayProperty: CurrentPlayers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineRecentPlayersList.FCurrentPlayerMet> CurrentPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineRecentPlayersList.FCurrentPlayerMet>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
