#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: ROnlineStatsReadMostWanted<br/>
/// (size = 180)
/// (flags = 0)
/// </summary>
public partial class ROnlineStatsReadMostWanted : BmSDK.Engine.OnlineStatsRead, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.ROnlineStatsReadMostWanted", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ROnlineStatsReadMostWanted() { }

    /// <summary>
    /// Constructs a new ROnlineStatsReadMostWanted
    /// </summary>
    public ROnlineStatsReadMostWanted(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ROnlineStatsReadMostWanted Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ROnlineStatsReadMostWanted(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: EMWLeaderboardColumns
    /// </summary>
    public enum EMWLeaderboardColumns
    {
        EMWC_RatingScore = 0,
        EMWC_MainProgression = 1,
        EMWC_MostWantedProgression = 2,
        EMWC_ARProgression = 3,
        EMWC_ARRivalScore = 4,
        EMWC_MAX = 5,
    }
}
