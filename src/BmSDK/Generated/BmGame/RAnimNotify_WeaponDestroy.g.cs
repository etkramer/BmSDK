#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_WeaponDestroy<br/>
/// (size = 132)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_WeaponDestroy : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_WeaponDestroy", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_WeaponDestroy() { }

    /// <summary>
    /// Constructs a new RAnimNotify_WeaponDestroy
    /// </summary>
    public RAnimNotify_WeaponDestroy(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_WeaponDestroy Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_WeaponDestroy(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: WeaponDestroyInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.FWeaponDestroyInfo WeaponDestroyInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.FWeaponDestroyInfo>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
