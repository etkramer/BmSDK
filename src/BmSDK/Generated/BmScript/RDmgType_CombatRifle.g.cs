#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RDmgType_CombatRifle<br/>
/// (size = 124)
/// (flags = 18)
/// </summary>
public partial class RDmgType_CombatRifle : BmSDK.BmGame.RDmgType_Rifle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RDmgType_CombatRifle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_CombatRifle() { }

    /// <summary>
    /// Constructs a new RDmgType_CombatRifle
    /// </summary>
    public RDmgType_CombatRifle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_CombatRifle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_CombatRifle(nint ptr) : base(ptr) { }

}
