#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_GangIdleOrGroupAnimationPointWeapon<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_GangIdleOrGroupAnimationPointWeapon : BmSDK.BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPointWeapon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_GangIdleOrGroupAnimationPointWeapon() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_GangIdleOrGroupAnimationPointWeapon
    /// </summary>
    public RBMBehaviour_GangIdleOrGroupAnimationPointWeapon(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_GangIdleOrGroupAnimationPointWeapon Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_GangIdleOrGroupAnimationPointWeapon(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: PickedWeaponAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PickedWeaponAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
}
