#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: UIDataStore_OnlineStats<br/>
/// (size = 148)
/// (flags = 31)
/// </summary>
public partial class UIDataStore_OnlineStats : BmSDK.Engine.UIDataStore_Remote, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataStore_OnlineStats", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIDataStore_OnlineStats() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataStore_OnlineStats(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: EStatsFetchType
    /// </summary>
    public enum EStatsFetchType
    {
        SFT_Player = 0,
        SFT_CenteredOnPlayer = 1,
        SFT_Friends = 2,
        SFT_TopRankings = 3,
        SFT_MAX = 4,
    }
}
