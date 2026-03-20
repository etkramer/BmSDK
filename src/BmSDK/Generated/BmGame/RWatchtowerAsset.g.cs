#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RWatchtowerAsset<br/>
/// (flags = 0)
/// </summary>
public partial class RWatchtowerAsset : BmSDK.BmGame.RThreatBaseAsset, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RWatchtowerAsset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RWatchtowerAsset() { }

    /// <summary>
    /// Constructs a new RWatchtowerAsset
    /// </summary>
    public RWatchtowerAsset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RWatchtowerAsset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RWatchtowerAsset(nint ptr) : base(ptr) { }

}
