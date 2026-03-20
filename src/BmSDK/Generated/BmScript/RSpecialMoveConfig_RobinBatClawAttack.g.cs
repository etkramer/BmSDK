#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_RobinBatClawAttack<br/>
/// (size = 480)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_RobinBatClawAttack : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_RobinBatClawAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_RobinBatClawAttack() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_RobinBatClawAttack
    /// </summary>
    public RSpecialMoveConfig_RobinBatClawAttack(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_RobinBatClawAttack Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_RobinBatClawAttack(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: AttackSpeed
    /// </summary>
    public unsafe float AttackSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// FloatProperty: AttackAccel
    /// </summary>
    public unsafe float AttackAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ObjectProperty: VictimReactionAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VictimReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }
}
