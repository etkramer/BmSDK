#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MSpecialMoveConfig_ShootHandGunRh<br/>
/// (size = 408)
/// (flags = 0)
/// </summary>
public partial class MSpecialMoveConfig_ShootHandGunRh : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MSpecialMoveConfig_ShootHandGunRh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MSpecialMoveConfig_ShootHandGunRh() { }

    /// <summary>
    /// Constructs a new MSpecialMoveConfig_ShootHandGunRh
    /// </summary>
    public MSpecialMoveConfig_ShootHandGunRh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MSpecialMoveConfig_ShootHandGunRh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSpecialMoveConfig_ShootHandGunRh(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Gadget
    /// </summary>
    public unsafe BmSDK.BmGame.MThrowGadgetBase Gadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MThrowGadgetBase>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}
