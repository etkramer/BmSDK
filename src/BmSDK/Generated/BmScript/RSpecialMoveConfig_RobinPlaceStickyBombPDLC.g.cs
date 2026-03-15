#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_RobinPlaceStickyBombPDLC<br/>
/// (size = 396)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_RobinPlaceStickyBombPDLC : BmSDK.BmScript.RSpecialMoveConfig_RobinPlaceStickyBomb, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_RobinPlaceStickyBombPDLC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_RobinPlaceStickyBombPDLC() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_RobinPlaceStickyBombPDLC
    /// </summary>
    public RSpecialMoveConfig_RobinPlaceStickyBombPDLC(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_RobinPlaceStickyBombPDLC Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_RobinPlaceStickyBombPDLC(nint ptr) : base(ptr) { }

}
