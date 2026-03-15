#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_RobinBatClawAttackPDLC<br/>
/// (size = 368)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_RobinBatClawAttackPDLC : BmSDK.BmScript.RSpecialMoveConfig_RobinBatClawAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_RobinBatClawAttackPDLC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_RobinBatClawAttackPDLC() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_RobinBatClawAttackPDLC
    /// </summary>
    public RSpecialMoveConfig_RobinBatClawAttackPDLC(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_RobinBatClawAttackPDLC Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_RobinBatClawAttackPDLC(nint ptr) : base(ptr) { }

}
