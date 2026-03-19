#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_BagCarrierBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_BagCarrierBase : BmSDK.BmGame.RBMBehaviour_DoorHandler, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_BagCarrierBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_BagCarrierBase() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_BagCarrierBase
    /// </summary>
    public RBMBehaviour_BagCarrierBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_BagCarrierBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_BagCarrierBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bRunningToExit
    /// </summary>
    public unsafe bool bRunningToExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bCountsAsAttackingForAttackAEC
    /// </summary>
    public unsafe bool bCountsAsAttackingForAttackAEC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// ObjectProperty: bag
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT bag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }
}
