#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: ROnlineStatsWriteMostWanted<br/>
/// (size = 184)
/// (flags = 50)
/// </summary>
public partial class ROnlineStatsWriteMostWanted : BmSDK.Engine.OnlineStatsWrite, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.ROnlineStatsWriteMostWanted", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ROnlineStatsWriteMostWanted() { }

    /// <summary>
    /// Constructs a new ROnlineStatsWriteMostWanted
    /// </summary>
    public ROnlineStatsWriteMostWanted(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ROnlineStatsWriteMostWanted Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ROnlineStatsWriteMostWanted(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: CopyAndWriteAllStats
    /// </summary>
    public unsafe void CopyAndWriteAllStats(BmSDK.BmGame.RPlayerController PC, BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqId, BmSDK.Engine.PlayerReplicationInfo PRI, BmSDK.Engine.OnlineStatsInterface StatsInterface)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.ROnlineStatsWriteMostWanted.CopyAndWriteAllStats", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqId, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsInterface, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CopyAllStats
    /// </summary>
    public unsafe bool CopyAllStats(BmSDK.BmGame.RPlayerController PC, BmSDK.Engine.PlayerReplicationInfo PRI)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.ROnlineStatsWriteMostWanted.CopyAllStats", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }
}
