#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_TakedownSentryGun<br/>
/// (size = 408)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_TakedownSentryGun : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_TakedownSentryGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_TakedownSentryGun() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_TakedownSentryGun
    /// </summary>
    public RSpecialMoveConfig_TakedownSentryGun(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_TakedownSentryGun Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_TakedownSentryGun(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: BMAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}
