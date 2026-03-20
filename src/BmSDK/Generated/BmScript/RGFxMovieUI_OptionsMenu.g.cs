#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_OptionsMenu<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_OptionsMenu : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_OptionsMenu", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_OptionsMenu() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_OptionsMenu
    /// </summary>
    public RGFxMovieUI_OptionsMenu(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_OptionsMenu Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_OptionsMenu(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: FadeMode
    /// </summary>
    public unsafe int FadeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// Enum: MMFadeAndTypes
    /// </summary>
    public enum MMFadeAndTypes
    {
        FadeAnd_Benchmark = 0,
        FadeAnd_MAX = 1,
    }
}
