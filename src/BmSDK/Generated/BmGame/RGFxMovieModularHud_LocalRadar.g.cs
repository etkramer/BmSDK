#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieModularHud_LocalRadar<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieModularHud_LocalRadar : BmSDK.BmGame.RGFxMovieModularHudBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieModularHud_LocalRadar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieModularHud_LocalRadar() { }

    /// <summary>
    /// Constructs a new RGFxMovieModularHud_LocalRadar
    /// </summary>
    public RGFxMovieModularHud_LocalRadar(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieModularHud_LocalRadar Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieModularHud_LocalRadar(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: MainHud
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MainHud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: DeregisterCountdown
    /// </summary>
    public unsafe float DeregisterCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }
}
