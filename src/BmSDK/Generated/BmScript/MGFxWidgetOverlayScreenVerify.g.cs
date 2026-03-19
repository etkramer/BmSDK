#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxWidgetOverlayScreenVerify<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MGFxWidgetOverlayScreenVerify : BmSDK.BmScript.MGFxWidgetOverlayScreen, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxWidgetOverlayScreenVerify", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MGFxWidgetOverlayScreenVerify() { }

    /// <summary>
    /// Constructs a new MGFxWidgetOverlayScreenVerify
    /// </summary>
    public MGFxWidgetOverlayScreenVerify(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetOverlayScreenVerify Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetOverlayScreenVerify(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ButtonGroup
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> ButtonGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: TextContainer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TextContainer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// IntProperty: SelectedButton
    /// </summary>
    public unsafe int SelectedButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bIsCreate
    /// </summary>
    public unsafe bool bIsCreate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }
}
