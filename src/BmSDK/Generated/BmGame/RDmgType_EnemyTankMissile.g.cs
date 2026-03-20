#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_EnemyTankMissile<br/>
/// (size = 216)
/// (flags = 18)
/// </summary>
public partial class RDmgType_EnemyTankMissile : BmSDK.BmGame.RDmgType_EnemyExplosiveWeapons, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_EnemyTankMissile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_EnemyTankMissile() { }

    /// <summary>
    /// Constructs a new RDmgType_EnemyTankMissile
    /// </summary>
    public RDmgType_EnemyTankMissile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_EnemyTankMissile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_EnemyTankMissile(nint ptr) : base(ptr) { }

}
