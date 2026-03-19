#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineGameSettings<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class OnlineGameSettings : BmSDK.Engine.Settings, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineGameSettings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineGameSettings() { }

    /// <summary>
    /// Constructs a new OnlineGameSettings
    /// </summary>
    public OnlineGameSettings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineGameSettings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineGameSettings(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: NumPublicConnections
    /// </summary>
    public unsafe int NumPublicConnections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: NumPrivateConnections
    /// </summary>
    public unsafe int NumPrivateConnections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// IntProperty: NumOpenPublicConnections
    /// </summary>
    public unsafe int NumOpenPublicConnections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// IntProperty: NumOpenPrivateConnections
    /// </summary>
    public unsafe int NumOpenPrivateConnections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// StructProperty: ServerNonce
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ServerNonce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bShouldAdvertise
    /// </summary>
    public unsafe bool bShouldAdvertise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bIsLanMatch
    /// </summary>
    public unsafe bool bIsLanMatch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bIsSinglePlayer
    /// </summary>
    public unsafe bool bIsSinglePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bUsesStats
    /// </summary>
    public unsafe bool bUsesStats
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bAllowJoinInProgress
    /// </summary>
    public unsafe bool bAllowJoinInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bAllowInvites
    /// </summary>
    public unsafe bool bAllowInvites
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bUsesPresence
    /// </summary>
    public unsafe bool bUsesPresence
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bAllowJoinViaPresence
    /// </summary>
    public unsafe bool bAllowJoinViaPresence
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bAllowJoinViaPresenceFriendsOnly
    /// </summary>
    public unsafe bool bAllowJoinViaPresenceFriendsOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bUsesArbitration
    /// </summary>
    public unsafe bool bUsesArbitration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bAntiCheatProtected
    /// </summary>
    public unsafe bool bAntiCheatProtected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bWasFromInvite
    /// </summary>
    public unsafe bool bWasFromInvite
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bIsDedicated
    /// </summary>
    public unsafe bool bIsDedicated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bHasSkillUpdateInProgress
    /// </summary>
    public unsafe bool bHasSkillUpdateInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bShouldShrinkArbitratedSessions
    /// </summary>
    public unsafe bool bShouldShrinkArbitratedSessions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// StrProperty: OwningPlayerName
    /// </summary>
    public unsafe BmSDK.FString OwningPlayerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: OwningPlayerId
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OwningPlayerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// IntProperty: PingInMs
    /// </summary>
    public unsafe int PingInMs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: MatchQuality
    /// </summary>
    public unsafe float MatchQuality
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ByteProperty: GameState
    /// </summary>
    public unsafe byte GameState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: BuildUniqueId
    /// </summary>
    public unsafe int BuildUniqueId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }
}
