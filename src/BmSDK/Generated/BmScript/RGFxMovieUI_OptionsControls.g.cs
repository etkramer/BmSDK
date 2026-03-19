#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_OptionsControls<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_OptionsControls : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_OptionsControls", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_OptionsControls() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_OptionsControls
    /// </summary>
    public RGFxMovieUI_OptionsControls(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_OptionsControls Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_OptionsControls(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: CachedFunction_AddPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCurrentPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCurrentPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }
}
