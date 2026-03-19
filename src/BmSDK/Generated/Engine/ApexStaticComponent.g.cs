#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexStaticComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ApexStaticComponent : BmSDK.Engine.ApexComponentBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexStaticComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexStaticComponent() { }

    /// <summary>
    /// Constructs a new ApexStaticComponent
    /// </summary>
    public ApexStaticComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexStaticComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexStaticComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ComponentBaseResources
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ComponentBaseResources
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// StructProperty: ReleaseResourcesFence
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReleaseResourcesFence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: Asset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Asset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// StructProperty: WireframeColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WireframeColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// BoolProperty: bAssetChanged
    /// </summary>
    public unsafe bool bAssetChanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }
}
