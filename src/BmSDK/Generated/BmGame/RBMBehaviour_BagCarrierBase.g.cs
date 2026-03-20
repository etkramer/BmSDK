#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_BagCarrierBase<br/>
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bCountsAsAttackingForAttackAEC
    /// </summary>
    public unsafe bool bCountsAsAttackingForAttackAEC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// ObjectProperty: bag
    /// </summary>
    public unsafe BmSDK.BmGame.RCarriableObjectBagBase bag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCarriableObjectBagBase>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }
}
