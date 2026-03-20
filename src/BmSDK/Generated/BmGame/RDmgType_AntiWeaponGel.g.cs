#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_AntiWeaponGel<br/>
/// (size = 236)
/// (flags = 0)
/// </summary>
public partial class RDmgType_AntiWeaponGel : BmSDK.BmGame.RDmgType_Strike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_AntiWeaponGel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_AntiWeaponGel() { }

    /// <summary>
    /// Constructs a new RDmgType_AntiWeaponGel
    /// </summary>
    public RDmgType_AntiWeaponGel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_AntiWeaponGel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_AntiWeaponGel(nint ptr) : base(ptr) { }

}
