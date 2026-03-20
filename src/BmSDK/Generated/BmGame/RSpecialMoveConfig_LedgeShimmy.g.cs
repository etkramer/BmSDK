#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_LedgeShimmy<br/>
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_LedgeShimmy : BmSDK.BmGame.RSpecialMoveConfig_ActivePoseTransitionWithOffset, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_LedgeShimmy", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_LedgeShimmy() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_LedgeShimmy
    /// </summary>
    public RSpecialMoveConfig_LedgeShimmy(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_LedgeShimmy Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_LedgeShimmy(nint ptr) : base(ptr) { }

}
