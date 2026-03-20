#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_BigZapHit<br/>
/// (size = 216)
/// (flags = 18)
/// </summary>
public partial class RDmgType_BigZapHit : BmSDK.BmGame.RDmgType_BigHit, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_BigZapHit", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_BigZapHit() { }

    /// <summary>
    /// Constructs a new RDmgType_BigZapHit
    /// </summary>
    public RDmgType_BigZapHit(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_BigZapHit Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_BigZapHit(nint ptr) : base(ptr) { }

}
