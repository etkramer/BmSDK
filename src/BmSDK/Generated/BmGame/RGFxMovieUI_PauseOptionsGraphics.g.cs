#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_PauseOptionsGraphics<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_PauseOptionsGraphics : BmSDK.BmGame.RGFxMovieUI_PauseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_PauseOptionsGraphics", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_PauseOptionsGraphics() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PauseOptionsGraphics
    /// </summary>
    public RGFxMovieUI_PauseOptionsGraphics(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PauseOptionsGraphics Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PauseOptionsGraphics(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: DisplayModeCopy
    /// </summary>
    public unsafe int DisplayModeCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// IntProperty: ResolutionXCopy
    /// </summary>
    public unsafe int ResolutionXCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// IntProperty: ResolutionYCopy
    /// </summary>
    public unsafe int ResolutionYCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// FloatProperty: TimeInSec
    /// </summary>
    public unsafe float TimeInSec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// BoolProperty: bQuestionPrompted
    /// </summary>
    public unsafe bool bQuestionPrompted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1628) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1628); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1628); }
    }

    /// <summary>
    /// BoolProperty: bWindowedFullscreenMode
    /// </summary>
    public unsafe bool bWindowedFullscreenMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1628) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1628); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1628); }
    }

    /// <summary>
    /// BoolProperty: bInitialized
    /// </summary>
    public unsafe bool bInitialized
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1628) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1628); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1628); }
    }

    /// <summary>
    /// ObjectProperty: ConfirmationPopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ConfirmationPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// ObjectProperty: RestartPopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RestartPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }
    }

    /// <summary>
    /// ObjectProperty: ApplyChangesPopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ApplyChangesPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// ArrayProperty: SupportedResolutions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> SupportedResolutions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 1656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }
    }

    /// <summary>
    /// IntProperty: DisplayMode_WindowedFullscreen
    /// </summary>
    public unsafe int DisplayMode_WindowedFullscreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// ArrayProperty: FPSArray
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FPSArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// DelegateProperty: __SortByFPS__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByFPS__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }
}
