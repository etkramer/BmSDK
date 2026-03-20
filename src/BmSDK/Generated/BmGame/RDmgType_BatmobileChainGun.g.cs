#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_BatmobileChainGun<br/>
/// (flags = 0)
/// </summary>
public partial class RDmgType_BatmobileChainGun : BmSDK.BmGame.RDmgType_Ranged, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_BatmobileChainGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_BatmobileChainGun() { }

    /// <summary>
    /// Constructs a new RDmgType_BatmobileChainGun
    /// </summary>
    public RDmgType_BatmobileChainGun(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_BatmobileChainGun Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_BatmobileChainGun(nint ptr) : base(ptr) { }

}
