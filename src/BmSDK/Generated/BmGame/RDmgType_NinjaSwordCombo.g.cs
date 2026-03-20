#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_NinjaSwordCombo<br/>
/// (size = 216)
/// (flags = 18)
/// </summary>
public partial class RDmgType_NinjaSwordCombo : BmSDK.BmGame.RDmgType_NinjaSword, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_NinjaSwordCombo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_NinjaSwordCombo() { }

    /// <summary>
    /// Constructs a new RDmgType_NinjaSwordCombo
    /// </summary>
    public RDmgType_NinjaSwordCombo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_NinjaSwordCombo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_NinjaSwordCombo(nint ptr) : base(ptr) { }

}
