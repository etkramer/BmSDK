#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieModularHud_TargetsEtc<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieModularHud_TargetsEtc : BmSDK.BmGame.RGFxMovieModularHudBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieModularHud_TargetsEtc", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieModularHud_TargetsEtc() { }

    /// <summary>
    /// Constructs a new RGFxMovieModularHud_TargetsEtc
    /// </summary>
    public RGFxMovieModularHud_TargetsEtc(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieModularHud_TargetsEtc Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieModularHud_TargetsEtc(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: MainHud
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MainHud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }
}
