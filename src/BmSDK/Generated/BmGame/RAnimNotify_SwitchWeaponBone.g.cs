#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_SwitchWeaponBone<br/>
/// (size = 96)
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_SwitchWeaponBone : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_SwitchWeaponBone", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_SwitchWeaponBone() { }

    /// <summary>
    /// Constructs a new RAnimNotify_SwitchWeaponBone
    /// </summary>
    public RAnimNotify_SwitchWeaponBone(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_SwitchWeaponBone Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_SwitchWeaponBone(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: TypeOfSwitch
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_SwitchWeaponBone.ESwitchType TypeOfSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_SwitchWeaponBone.ESwitchType>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// NameProperty: BoneName
    /// </summary>
    public unsafe BmSDK.FName BoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// Enum: ESwitchType
    /// </summary>
    public enum ESwitchType
    {
        ESWITCH_SwitchToBone = 0,
        ESWITCH_SwitchToHolster = 1,
        ESWITCH_SwitchToDefault = 2,
        ESWITCH_MAX = 3,
    }
}
