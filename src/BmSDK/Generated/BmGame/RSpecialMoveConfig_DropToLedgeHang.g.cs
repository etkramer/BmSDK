#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_DropToLedgeHang<br/>
/// (size = 492)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_DropToLedgeHang : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimWithTravelAnim, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_DropToLedgeHang", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_DropToLedgeHang() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_DropToLedgeHang
    /// </summary>
    public RSpecialMoveConfig_DropToLedgeHang(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_DropToLedgeHang Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_DropToLedgeHang(nint ptr) : base(ptr) { }

}
