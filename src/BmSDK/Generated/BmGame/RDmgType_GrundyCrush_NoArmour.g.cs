#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_GrundyCrush_NoArmour<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RDmgType_GrundyCrush_NoArmour : BmSDK.BmGame.RDmgType_GrundyCrush, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_GrundyCrush_NoArmour", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_GrundyCrush_NoArmour() { }

    /// <summary>
    /// Constructs a new RDmgType_GrundyCrush_NoArmour
    /// </summary>
    public RDmgType_GrundyCrush_NoArmour(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_GrundyCrush_NoArmour Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_GrundyCrush_NoArmour(nint ptr) : base(ptr) { }

}
