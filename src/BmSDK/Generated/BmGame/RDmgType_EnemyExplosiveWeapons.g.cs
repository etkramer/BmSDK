#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_EnemyExplosiveWeapons<br/>
/// (flags = 0)
/// </summary>
public partial class RDmgType_EnemyExplosiveWeapons : BmSDK.BmGame.RDmgType_Explosion, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_EnemyExplosiveWeapons", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_EnemyExplosiveWeapons() { }

    /// <summary>
    /// Constructs a new RDmgType_EnemyExplosiveWeapons
    /// </summary>
    public RDmgType_EnemyExplosiveWeapons(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_EnemyExplosiveWeapons Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_EnemyExplosiveWeapons(nint ptr) : base(ptr) { }

}
