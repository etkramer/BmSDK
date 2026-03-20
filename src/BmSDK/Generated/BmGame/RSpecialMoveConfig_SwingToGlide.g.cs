#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_SwingToGlide<br/>
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_SwingToGlide : BmSDK.BmGame.RSpecialMoveConfig_SwingToVantagePoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_SwingToGlide", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_SwingToGlide() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_SwingToGlide
    /// </summary>
    public RSpecialMoveConfig_SwingToGlide(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_SwingToGlide Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_SwingToGlide(nint ptr) : base(ptr) { }

}
