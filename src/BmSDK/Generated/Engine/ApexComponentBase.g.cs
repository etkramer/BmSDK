#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexComponentBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ApexComponentBase : BmSDK.Engine.MeshComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexComponentBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexComponentBase() { }

    /// <summary>
    /// Constructs a new ApexComponentBase
    /// </summary>
    public ApexComponentBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexComponentBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexComponentBase(nint ptr) : base(ptr) { }

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
