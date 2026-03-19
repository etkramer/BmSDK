#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_PhotoModeOverlay<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_PhotoModeOverlay : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_PhotoModeOverlay", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_PhotoModeOverlay() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PhotoModeOverlay
    /// </summary>
    public RGFxMovieUI_PhotoModeOverlay(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PhotoModeOverlay Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PhotoModeOverlay(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: PhotoCamera
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhotoCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: VignetteType
    /// </summary>
    public unsafe int VignetteType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// IntProperty: VignetteIntensity
    /// </summary>
    public unsafe int VignetteIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// IntProperty: FrameType
    /// </summary>
    public unsafe int FrameType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: FrameIntensity
    /// </summary>
    public unsafe int FrameIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// IntProperty: LogoPosition
    /// </summary>
    public unsafe int LogoPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// IntProperty: LogoScale
    /// </summary>
    public unsafe int LogoScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// StrProperty: LoadingFrame
    /// </summary>
    public unsafe BmSDK.FString LoadingFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// IntProperty: TimeOnEnter
    /// </summary>
    public unsafe int TimeOnEnter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bIsPromptsVisible
    /// </summary>
    public unsafe bool bIsPromptsVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bPrevUsingGamepad
    /// </summary>
    public unsafe bool bPrevUsingGamepad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bBackPressed
    /// </summary>
    public unsafe bool bBackPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }
}
