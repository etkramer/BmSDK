#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_JokerBoxerCloseAttackStrike<br/>
/// (flags = 0)
/// </summary>
public partial class RDmgType_JokerBoxerCloseAttackStrike : BmSDK.BmGame.RDmgType_Strike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_JokerBoxerCloseAttackStrike", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_JokerBoxerCloseAttackStrike() { }

    /// <summary>
    /// Constructs a new RDmgType_JokerBoxerCloseAttackStrike
    /// </summary>
    public RDmgType_JokerBoxerCloseAttackStrike(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_JokerBoxerCloseAttackStrike Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_JokerBoxerCloseAttackStrike(nint ptr) : base(ptr) { }

}
