#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_CauseTitanBerserk<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RDmgType_CauseTitanBerserk : BmSDK.BmGame.RDamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_CauseTitanBerserk", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_CauseTitanBerserk() { }

    /// <summary>
    /// Constructs a new RDmgType_CauseTitanBerserk
    /// </summary>
    public RDmgType_CauseTitanBerserk(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_CauseTitanBerserk Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_CauseTitanBerserk(nint ptr) : base(ptr) { }

}
