#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_CombatJokerBoxer<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_CombatJokerBoxer : BmSDK.BmGame.RBMBehaviour_CombatAI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_CombatJokerBoxer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_CombatJokerBoxer() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_CombatJokerBoxer
    /// </summary>
    public RBMBehaviour_CombatJokerBoxer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_CombatJokerBoxer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_CombatJokerBoxer(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: StrikeNum
    /// </summary>
    public unsafe int StrikeNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// NameProperty: StrikeName
    /// </summary>
    public unsafe BmSDK.FName StrikeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ObjectProperty: JBoxer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JBoxer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: LastReviveTime
    /// </summary>
    public unsafe float LastReviveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }
}
