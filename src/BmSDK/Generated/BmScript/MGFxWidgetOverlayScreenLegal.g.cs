#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxWidgetOverlayScreenLegal<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MGFxWidgetOverlayScreenLegal : BmSDK.BmScript.MGFxWidgetOverlayScreen, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxWidgetOverlayScreenLegal", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MGFxWidgetOverlayScreenLegal() { }

    /// <summary>
    /// Constructs a new MGFxWidgetOverlayScreenLegal
    /// </summary>
    public MGFxWidgetOverlayScreenLegal(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetOverlayScreenLegal Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetOverlayScreenLegal(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TextImage
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TextImage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: ImageData
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImageData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: ImageRef
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImageRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ObjectProperty: ScrollBar
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ScrollBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ObjectProperty: TextContainer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TextContainer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ObjectProperty: BlackBox
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BlackBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// IntProperty: SelectedButton
    /// </summary>
    public unsafe int SelectedButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: OriginalTextImageY
    /// </summary>
    public unsafe int OriginalTextImageY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// IntProperty: OriginalScrollBlockY
    /// </summary>
    public unsafe int OriginalScrollBlockY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// IntProperty: ScrollInteriorHeight
    /// </summary>
    public unsafe int ScrollInteriorHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// IntProperty: TextImageHeight
    /// </summary>
    public unsafe int TextImageHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// IntProperty: ScrollMax
    /// </summary>
    public unsafe int ScrollMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// IntProperty: MASK_HEIGHT
    /// </summary>
    public unsafe int MASK_HEIGHT
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// IntProperty: SCROLL_RATE
    /// </summary>
    public unsafe int SCROLL_RATE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bQueueScrollerSetup
    /// </summary>
    public unsafe bool bQueueScrollerSetup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bIsScrollDisabled
    /// </summary>
    public unsafe bool bIsScrollDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// FloatProperty: ScrollBlockHeight
    /// </summary>
    public unsafe float ScrollBlockHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }
}
