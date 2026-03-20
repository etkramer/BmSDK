#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_CombatRifleRobot<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_CombatRifleRobot : BmSDK.BmGame.RBMBehaviour_CombatRifle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_CombatRifleRobot", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_CombatRifleRobot() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_CombatRifleRobot
    /// </summary>
    public RBMBehaviour_CombatRifleRobot(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_CombatRifleRobot Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_CombatRifleRobot(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: BatmobileTauntTime
    /// </summary>
    public unsafe float BatmobileTauntTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: AttackRange
    /// </summary>
    public unsafe float AttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }
}
