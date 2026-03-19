#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxWidgetOverlayScreenEmailForm<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MGFxWidgetOverlayScreenEmailForm : BmSDK.BmScript.MGFxWidgetOverlayScreen, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxWidgetOverlayScreenEmailForm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MGFxWidgetOverlayScreenEmailForm() { }

    /// <summary>
    /// Constructs a new MGFxWidgetOverlayScreenEmailForm
    /// </summary>
    public MGFxWidgetOverlayScreenEmailForm(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetOverlayScreenEmailForm Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetOverlayScreenEmailForm(nint ptr) : base(ptr) { }

    /// <summary>
    /// InterfaceProperty: PlayerInterface
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ArrayProperty: ButtonGroup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> ButtonGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ArrayProperty: ErrorHighlights
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> ErrorHighlights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ArrayProperty: Cache_TextFields
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Cache_TextFields
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: SelectedButton
    /// </summary>
    public unsafe int SelectedButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// StrProperty: CurrentAge
    /// </summary>
    public unsafe BmSDK.FString CurrentAge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// ObjectProperty: TitleLabel
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TitleLabel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ObjectProperty: EmailForm
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EmailForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// BoolProperty: bShouldReceiveEmails
    /// </summary>
    public unsafe bool bShouldReceiveEmails
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bHidePassword
    /// </summary>
    public unsafe bool bHidePassword
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bIsCreate
    /// </summary>
    public unsafe bool bIsCreate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bIsDropDownCollapsed
    /// </summary>
    public unsafe bool bIsDropDownCollapsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bIsConsoleKeyboardOpen
    /// </summary>
    public unsafe bool bIsConsoleKeyboardOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// StrProperty: BladeKeyboardResult
    /// </summary>
    public unsafe BmSDK.FString BladeKeyboardResult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// IntProperty: MIN_AGE
    /// </summary>
    public unsafe int MIN_AGE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: MAX_AGE
    /// </summary>
    public unsafe int MAX_AGE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: MIN_PASSWORD_LEN
    /// </summary>
    public unsafe int MIN_PASSWORD_LEN
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// IntProperty: MAX_PASSWORD_LEN
    /// </summary>
    public unsafe int MAX_PASSWORD_LEN
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// IntProperty: AGE_DROPDOWN_SLOTS
    /// </summary>
    public unsafe int AGE_DROPDOWN_SLOTS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// DelegateProperty: __OnBladeKeyboardFinished__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnBladeKeyboardFinished__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
}
