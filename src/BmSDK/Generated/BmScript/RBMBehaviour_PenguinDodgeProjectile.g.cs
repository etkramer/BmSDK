#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_PenguinDodgeProjectile<br/>
/// (size = 428)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_PenguinDodgeProjectile : BmSDK.BmGame.RBMBehaviour_DodgeProjectile, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_PenguinDodgeProjectile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_PenguinDodgeProjectile() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_PenguinDodgeProjectile
    /// </summary>
    public RBMBehaviour_PenguinDodgeProjectile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_PenguinDodgeProjectile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_PenguinDodgeProjectile(nint ptr) : base(ptr) { }

}
