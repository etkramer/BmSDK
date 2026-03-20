#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_WalkerMissiles<br/>
/// (flags = 0)
/// </summary>
public partial class RDmgType_WalkerMissiles : BmSDK.BmGame.RDmgType_EnemyExplosiveWeapons, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_WalkerMissiles", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_WalkerMissiles() { }

    /// <summary>
    /// Constructs a new RDmgType_WalkerMissiles
    /// </summary>
    public RDmgType_WalkerMissiles(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_WalkerMissiles Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_WalkerMissiles(nint ptr) : base(ptr) { }

}
