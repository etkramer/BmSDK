#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_PlaceStickyBomb<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RDmgType_PlaceStickyBomb : BmSDK.BmGame.RDamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_PlaceStickyBomb", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_PlaceStickyBomb() { }

    /// <summary>
    /// Constructs a new RDmgType_PlaceStickyBomb
    /// </summary>
    public RDmgType_PlaceStickyBomb(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_PlaceStickyBomb Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_PlaceStickyBomb(nint ptr) : base(ptr) { }

}
