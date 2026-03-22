#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_IdleAllowCombat<br/>
/// (size = 432)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_IdleAllowCombat : BmSDK.BmGame.RBMBehaviour_Idle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_IdleAllowCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_IdleAllowCombat() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_IdleAllowCombat
    /// </summary>
    public RBMBehaviour_IdleAllowCombat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_IdleAllowCombat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_IdleAllowCombat(nint ptr) : base(ptr) { }

}
