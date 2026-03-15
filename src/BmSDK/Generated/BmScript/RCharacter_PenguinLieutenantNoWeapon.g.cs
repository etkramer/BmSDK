#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_PenguinLieutenantNoWeapon<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_PenguinLieutenantNoWeapon : BmSDK.BmScript.RCharacter_PenguinLieutenant, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_PenguinLieutenantNoWeapon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_PenguinLieutenantNoWeapon() { }

    /// <summary>
    /// Constructs a new RCharacter_PenguinLieutenantNoWeapon
    /// </summary>
    public RCharacter_PenguinLieutenantNoWeapon(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_PenguinLieutenantNoWeapon Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_PenguinLieutenantNoWeapon(nint ptr) : base(ptr) { }

}
