#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_SlideAttack<br/>
/// (size = 140)
/// (flags = 18)
/// </summary>
public partial class RDmgType_SlideAttack : BmSDK.BmGame.RDmgType_HeavyStrike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_SlideAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_SlideAttack() { }

    /// <summary>
    /// Constructs a new RDmgType_SlideAttack
    /// </summary>
    public RDmgType_SlideAttack(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_SlideAttack Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_SlideAttack(nint ptr) : base(ptr) { }

}
