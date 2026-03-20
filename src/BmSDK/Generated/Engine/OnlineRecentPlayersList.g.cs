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
