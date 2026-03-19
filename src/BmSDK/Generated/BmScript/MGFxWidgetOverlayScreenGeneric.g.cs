#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxWidgetOverlayScreenGeneric<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MGFxWidgetOverlayScreenGeneric : BmSDK.BmScript.MGFxWidgetOverlayScreen, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxWidgetOverlayScreenGeneric", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MGFxWidgetOverlayScreenGeneric() { }

    /// <summary>
    /// Constructs a new MGFxWidgetOverlayScreenGeneric
    /// </summary>
    public MGFxWidgetOverlayScreenGeneric(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetOverlayScreenGeneric Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetOverlayScreenGeneric(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TextContainer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TextContainer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: CookieImage
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CookieImage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// IntProperty: SelectedButton
    /// </summary>
    public unsafe int SelectedButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// BoolProperty: bIsPleaseWait
    /// </summary>
    public unsafe bool bIsPleaseWait
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }

    /// <summary>
    /// BoolProperty: bIsNetworkDebug
    /// </summary>
    public unsafe bool bIsNetworkDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }
}
