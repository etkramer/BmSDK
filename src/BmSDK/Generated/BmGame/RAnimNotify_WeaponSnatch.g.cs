#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_WeaponSnatch<br/>
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_WeaponSnatch : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_WeaponSnatch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_WeaponSnatch() { }

    /// <summary>
    /// Constructs a new RAnimNotify_WeaponSnatch
    /// </summary>
    public RAnimNotify_WeaponSnatch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_WeaponSnatch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_WeaponSnatch(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SnatchInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.FWeaponSnatchInfo SnatchInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.FWeaponSnatchInfo>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
