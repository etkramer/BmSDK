#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_Takedown_GlassAttack<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RDmgType_Takedown_GlassAttack : BmSDK.BmGame.RDmgType_Takedown, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_Takedown_GlassAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_Takedown_GlassAttack() { }

    /// <summary>
    /// Constructs a new RDmgType_Takedown_GlassAttack
    /// </summary>
    public RDmgType_Takedown_GlassAttack(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_Takedown_GlassAttack Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_Takedown_GlassAttack(nint ptr) : base(ptr) { }

}
