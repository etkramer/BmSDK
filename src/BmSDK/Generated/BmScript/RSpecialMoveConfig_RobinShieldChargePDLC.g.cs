#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_RobinShieldChargePDLC<br/>
/// (size = 364)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_RobinShieldChargePDLC : BmSDK.BmScript.RSpecialMoveConfig_RobinShieldCharge, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_RobinShieldChargePDLC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_RobinShieldChargePDLC() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_RobinShieldChargePDLC
    /// </summary>
    public RSpecialMoveConfig_RobinShieldChargePDLC(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_RobinShieldChargePDLC Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_RobinShieldChargePDLC(nint ptr) : base(ptr) { }

}
