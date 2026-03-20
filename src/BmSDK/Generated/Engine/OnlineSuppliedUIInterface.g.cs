#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineSuppliedUIInterface<br/>
/// (flags = 0)
/// </summary>
public partial class OnlineSuppliedUIInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineSuppliedUIInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineSuppliedUIInterface() { }

    /// <summary>
    /// Constructs a new OnlineSuppliedUIInterface
    /// </summary>
    public OnlineSuppliedUIInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineSuppliedUIInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineSuppliedUIInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: ShowMatchmakingUI
    /// </summary>
    public unsafe bool ShowMatchmakingUI(byte SearchingPlayerNum, BmSDK.Engine.OnlineGameSearch SearchSettings, BmSDK.Engine.OnlineGameSettings GameSettings)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineSuppliedUIInterface.ShowMatchmakingUI", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchingPlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchSettings, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameSettings, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: ClearShowOnlineStatsUICompleteDelegate
    /// </summary>
    public unsafe void ClearShowOnlineStatsUICompleteDelegate(System.IntPtr ShowOnlineStatsUICompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineSuppliedUIInterface.ClearShowOnlineStatsUICompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowOnlineStatsUICompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddShowOnlineStatsUICompleteDelegate
    /// </summary>
    public unsafe void AddShowOnlineStatsUICompleteDelegate(System.IntPtr ShowOnlineStatsUICompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineSuppliedUIInterface.AddShowOnlineStatsUICompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowOnlineStatsUICompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowOnlineStatsUI
    /// </summary>
    public unsafe bool ShowOnlineStatsUI(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineSuppliedUIInterface.ShowOnlineStatsUI", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Players = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: OnShowOnlineStatsUIComplete
    /// </summary>
    public unsafe void OnShowOnlineStatsUIComplete()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineSuppliedUIInterface.OnShowOnlineStatsUIComplete", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
