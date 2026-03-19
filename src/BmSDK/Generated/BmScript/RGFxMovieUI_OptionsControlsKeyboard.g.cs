#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_OptionsControlsKeyboard<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_OptionsControlsKeyboard : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_OptionsControlsKeyboard() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_OptionsControlsKeyboard
    /// </summary>
    public RGFxMovieUI_OptionsControlsKeyboard(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_OptionsControlsKeyboard Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_OptionsControlsKeyboard(nint ptr) : base(ptr) { }

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

    /// <summary>
    /// StrProperty: FunctionPath
    /// </summary>
    public unsafe BmSDK.FString FunctionPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: ApplyKeybindingsPopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ApplyKeybindingsPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ObjectProperty: KeyButtonRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KeyButtonRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ObjectProperty: ButtonPCRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ButtonPCRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ObjectProperty: SetKeybindPopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SetKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: ResetAllToDefaultPopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ResetAllToDefaultPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: NoOption
    /// </summary>
    public unsafe int NoOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// IntProperty: CancelOption
    /// </summary>
    public unsafe int CancelOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// StrProperty: DefaultKeyBind
    /// </summary>
    public unsafe BmSDK.FString DefaultKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// BoolProperty: bHasModifier
    /// </summary>
    public unsafe bool bHasModifier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1184); }
    }

    /// <summary>
    /// StrProperty: SelectedKeyBind
    /// </summary>
    public unsafe BmSDK.FString SelectedKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
}
