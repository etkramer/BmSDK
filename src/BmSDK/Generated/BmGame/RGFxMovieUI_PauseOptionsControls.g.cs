#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_PauseOptionsControls<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_PauseOptionsControls : BmSDK.BmGame.RGFxMovieUI_PauseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_PauseOptionsControls", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_PauseOptionsControls() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PauseOptionsControls
    /// </summary>
    public RGFxMovieUI_PauseOptionsControls(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PauseOptionsControls Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PauseOptionsControls(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: CachedFunction_AddPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCurrentPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCurrentPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }

    /// <summary>
    /// StructProperty: KeyboardScreen
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT KeyboardScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }
}
