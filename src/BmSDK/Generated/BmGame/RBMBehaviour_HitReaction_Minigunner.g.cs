#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_HitReaction_Minigunner<br/>
/// (size = 908)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_HitReaction_Minigunner : BmSDK.BmGame.RBMBehaviour_HitReaction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_HitReaction_Minigunner", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_HitReaction_Minigunner() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_HitReaction_Minigunner
    /// </summary>
    public RBMBehaviour_HitReaction_Minigunner(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_HitReaction_Minigunner Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_HitReaction_Minigunner(nint ptr) : base(ptr) { }

}
