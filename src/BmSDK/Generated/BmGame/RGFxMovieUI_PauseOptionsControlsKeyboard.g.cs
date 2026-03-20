#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_PauseOptionsControlsKeyboard<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_PauseOptionsControlsKeyboard : BmSDK.BmGame.RGFxMovieUI_PauseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_PauseOptionsControlsKeyboard() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PauseOptionsControlsKeyboard
    /// </summary>
    public RGFxMovieUI_PauseOptionsControlsKeyboard(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PauseOptionsControlsKeyboard Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PauseOptionsControlsKeyboard(nint ptr) : base(ptr) { }

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
    /// StructProperty: ControlsScreen
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI_PauseBase.FScreenDef ControlsScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI_PauseBase.FScreenDef>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// StrProperty: FunctionPath
    /// </summary>
    public unsafe BmSDK.FString FunctionPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// ObjectProperty: ApplyKeybindingsPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ApplyKeybindingsPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// ObjectProperty: KeyButtonRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester KeyButtonRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// ObjectProperty: ButtonPCRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ButtonPCRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// ObjectProperty: SetKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester SetKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// ObjectProperty: ResetAllToDefaultPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ResetAllToDefaultPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// IntProperty: NoOption
    /// </summary>
    public unsafe int NoOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// IntProperty: CancelOption
    /// </summary>
    public unsafe int CancelOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// StrProperty: DefaultKeyBind
    /// </summary>
    public unsafe BmSDK.FString DefaultKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// BoolProperty: bHasModifier
    /// </summary>
    public unsafe bool bHasModifier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1740) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1740); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1740); }
    }

    /// <summary>
    /// StrProperty: SelectedKeyBind
    /// </summary>
    public unsafe BmSDK.FString SelectedKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }
}
