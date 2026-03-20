#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_ThugMineExplosion<br/>
/// (size = 216)
/// (flags = 0)
/// </summary>
public partial class RDmgType_ThugMineExplosion : BmSDK.BmGame.RDmgType_Explosion, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_ThugMineExplosion", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_ThugMineExplosion() { }

    /// <summary>
    /// Constructs a new RDmgType_ThugMineExplosion
    /// </summary>
    public RDmgType_ThugMineExplosion(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_ThugMineExplosion Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_ThugMineExplosion(nint ptr) : base(ptr) { }

}
