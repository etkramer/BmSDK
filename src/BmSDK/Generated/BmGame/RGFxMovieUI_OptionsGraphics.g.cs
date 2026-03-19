#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_OptionsGraphics<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_OptionsGraphics : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_OptionsGraphics", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_OptionsGraphics() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_OptionsGraphics
    /// </summary>
    public RGFxMovieUI_OptionsGraphics(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_OptionsGraphics Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_OptionsGraphics(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: DisplayModeCopy
    /// </summary>
    public unsafe int DisplayModeCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: ResolutionXCopy
    /// </summary>
    public unsafe int ResolutionXCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// IntProperty: ResolutionYCopy
    /// </summary>
    public unsafe int ResolutionYCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: TimeInSec
    /// </summary>
    public unsafe float TimeInSec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// BoolProperty: bQuestionPrompted
    /// </summary>
    public unsafe bool bQuestionPrompted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// BoolProperty: bWindowedFullscreenMode
    /// </summary>
    public unsafe bool bWindowedFullscreenMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// BoolProperty: bInitialized
    /// </summary>
    public unsafe bool bInitialized
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: ConfirmationPopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ConfirmationPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: RestartPopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RestartPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: ApplyChangesPopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ApplyChangesPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ArrayProperty: SupportedResolutions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> SupportedResolutions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// IntProperty: DisplayMode_WindowedFullscreen
    /// </summary>
    public unsafe int DisplayMode_WindowedFullscreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ArrayProperty: FPSArray
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FPSArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// DelegateProperty: __SortByFPS__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByFPS__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }
}
