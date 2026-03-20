#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_PerchLedgeToGrate<br/>
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_PerchLedgeToGrate : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_PerchLedgeToGrate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_PerchLedgeToGrate() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_PerchLedgeToGrate
    /// </summary>
    public RSpecialMoveConfig_PerchLedgeToGrate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_PerchLedgeToGrate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_PerchLedgeToGrate(nint ptr) : base(ptr) { }

}
