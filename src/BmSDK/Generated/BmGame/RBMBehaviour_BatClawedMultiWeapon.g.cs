#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_BatClawedMultiWeapon<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_BatClawedMultiWeapon : BmSDK.BmGame.RBMBehaviour_BatClawed, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_BatClawedMultiWeapon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_BatClawedMultiWeapon() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_BatClawedMultiWeapon
    /// </summary>
    public RBMBehaviour_BatClawedMultiWeapon(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_BatClawedMultiWeapon Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_BatClawedMultiWeapon(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: StumbleTime
    /// </summary>
    public unsafe float StumbleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bCanBeAttacked
    /// </summary>
    public unsafe bool bCanBeAttacked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bCanTripAndFall
    /// </summary>
    public unsafe bool bCanTripAndFall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }
}
