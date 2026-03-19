#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkDrawBoundsComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkDrawBoundsComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkDrawBoundsComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkDrawBoundsComponent() { }

    /// <summary>
    /// Constructs a new AkDrawBoundsComponent
    /// </summary>
    public AkDrawBoundsComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkDrawBoundsComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkDrawBoundsComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: DrawBoundsColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DrawBoundsColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// StructProperty: ExtraBoxDrawColour
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExtraBoxDrawColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// StructProperty: DrawBounds
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DrawBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StructProperty: X_LMH
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT X_LMH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// StructProperty: Y_LMH
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Y_LMH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// StructProperty: Z_LMH
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Z_LMH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// BoolProperty: bX_Enabled
    /// </summary>
    public unsafe bool bX_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: bY_Enabled
    /// </summary>
    public unsafe bool bY_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: bZ_Enabled
    /// </summary>
    public unsafe bool bZ_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }
}
