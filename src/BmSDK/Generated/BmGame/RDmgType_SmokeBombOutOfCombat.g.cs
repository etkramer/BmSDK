#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_SmokeBombOutOfCombat<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RDmgType_SmokeBombOutOfCombat : BmSDK.BmGame.RDmgType_SmokeBomb, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_SmokeBombOutOfCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_SmokeBombOutOfCombat() { }

    /// <summary>
    /// Constructs a new RDmgType_SmokeBombOutOfCombat
    /// </summary>
    public RDmgType_SmokeBombOutOfCombat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_SmokeBombOutOfCombat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_SmokeBombOutOfCombat(nint ptr) : base(ptr) { }

}
