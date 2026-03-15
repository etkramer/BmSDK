#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_HarleyDodgeProjectile<br/>
/// (size = 428)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_HarleyDodgeProjectile : BmSDK.BmGame.RBMBehaviour_DodgeProjectile, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_HarleyDodgeProjectile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_HarleyDodgeProjectile() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_HarleyDodgeProjectile
    /// </summary>
    public RBMBehaviour_HarleyDodgeProjectile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_HarleyDodgeProjectile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_HarleyDodgeProjectile(nint ptr) : base(ptr) { }

}
