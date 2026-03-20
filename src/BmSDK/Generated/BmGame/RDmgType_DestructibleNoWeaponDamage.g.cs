#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_DestructibleNoWeaponDamage<br/>
/// (flags = 0)
/// </summary>
public partial class RDmgType_DestructibleNoWeaponDamage : BmSDK.BmGame.RDamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_DestructibleNoWeaponDamage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_DestructibleNoWeaponDamage() { }

    /// <summary>
    /// Constructs a new RDmgType_DestructibleNoWeaponDamage
    /// </summary>
    public RDmgType_DestructibleNoWeaponDamage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_DestructibleNoWeaponDamage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_DestructibleNoWeaponDamage(nint ptr) : base(ptr) { }

}
