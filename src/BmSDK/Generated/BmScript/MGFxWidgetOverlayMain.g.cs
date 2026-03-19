#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxWidgetOverlayMain<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MGFxWidgetOverlayMain : BmSDK.GFxUI.GFxObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxWidgetOverlayMain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MGFxWidgetOverlayMain() { }

    /// <summary>
    /// Constructs a new MGFxWidgetOverlayMain
    /// </summary>
    public MGFxWidgetOverlayMain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetOverlayMain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetOverlayMain(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: _parent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT _parent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: Screen_Current
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Screen_Current
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
