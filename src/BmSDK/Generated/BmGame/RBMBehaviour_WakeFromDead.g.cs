#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_WakeFromDead<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_WakeFromDead : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_WakeFromDead", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_WakeFromDead() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_WakeFromDead
    /// </summary>
    public RBMBehaviour_WakeFromDead(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_WakeFromDead Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_WakeFromDead(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bStartedGetUp
    /// </summary>
    public unsafe bool bStartedGetUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bBeenInGetUp
    /// </summary>
    public unsafe bool bBeenInGetUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bFinishedGetUp
    /// </summary>
    public unsafe bool bFinishedGetUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bAnimImmediate
    /// </summary>
    public unsafe bool bAnimImmediate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// NameProperty: OverrideGetUpMovementStance
    /// </summary>
    public unsafe BmSDK.FName OverrideGetUpMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// NameProperty: GetUpMovementStance
    /// </summary>
    public unsafe BmSDK.FName GetUpMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// NameProperty: GetupWeaponStance
    /// </summary>
    public unsafe BmSDK.FName GetupWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ObjectProperty: GetUpMaster
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GetUpMaster
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ObjectProperty: GetUpAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GetUpAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// StructProperty: GetUpMasterAnimID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GetUpMasterAnimID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// NameProperty: GetUpAnimName
    /// </summary>
    public unsafe BmSDK.FName GetUpAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }
}
