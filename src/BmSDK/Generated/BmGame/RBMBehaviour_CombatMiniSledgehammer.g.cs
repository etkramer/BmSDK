#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_CombatMiniSledgehammer<br/>
/// (size = 1020)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_CombatMiniSledgehammer : BmSDK.BmGame.RBMBehaviour_CombatPipe, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_CombatMiniSledgehammer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_CombatMiniSledgehammer() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_CombatMiniSledgehammer
    /// </summary>
    public RBMBehaviour_CombatMiniSledgehammer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_CombatMiniSledgehammer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_CombatMiniSledgehammer(nint ptr) : base(ptr) { }

}
