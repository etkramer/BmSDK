#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxWidgetOverlayScreen<br/>
/// (flags = 0)
/// </summary>
public partial class MGFxWidgetOverlayScreen : BmSDK.GFxUI.GFxObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxWidgetOverlayScreen", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MGFxWidgetOverlayScreen() { }

    /// <summary>
    /// Constructs a new MGFxWidgetOverlayScreen
    /// </summary>
    public MGFxWidgetOverlayScreen(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetOverlayScreen Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetOverlayScreen(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DataMessage
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDDataMessage DataMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDDataMessage>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: ManagerRef
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDOverlayManager ManagerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDOverlayManager>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: _parent
    /// </summary>
    public unsafe BmSDK.BmScript.MGFxWidgetOverlayMain _parent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MGFxWidgetOverlayMain>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: OverlayBasic
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject OverlayBasic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bSetupInput
    /// </summary>
    public unsafe bool bSetupInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bNeedsThreadSafeInvalidate
    /// </summary>
    public unsafe bool bNeedsThreadSafeInvalidate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bNeedsKeyUp
    /// </summary>
    public unsafe bool bNeedsKeyUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: PromptAIndex
    /// </summary>
    public unsafe int PromptAIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// IntProperty: PromptBIndex
    /// </summary>
    public unsafe int PromptBIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// IntProperty: PromptExtraIndex
    /// </summary>
    public unsafe int PromptExtraIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
}
