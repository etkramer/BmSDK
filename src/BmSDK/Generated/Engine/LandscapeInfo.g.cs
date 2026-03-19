#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LandscapeInfo<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LandscapeInfo : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LandscapeInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LandscapeInfo() { }

    /// <summary>
    /// Constructs a new LandscapeInfo
    /// </summary>
    public LandscapeInfo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LandscapeInfo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LandscapeInfo(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: LandscapeGuid
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LandscapeGuid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// MapProperty: LayerInfoMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ LayerInfoMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: DataInterface
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DataInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// MapProperty: XYtoComponentMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ XYtoComponentMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// MapProperty: XYtoCollisionComponentMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ XYtoCollisionComponentMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ObjectProperty: LandscapeProxy
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LandscapeProxy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// MapProperty: XYtoAddCollisionMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ XYtoAddCollisionMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// StructProperty: Proxies
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Proxies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StructProperty: SelectedComponents
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SelectedComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// StructProperty: SelectedCollisionComponents
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SelectedCollisionComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StructProperty: SelectedRegionComponents
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SelectedRegionComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// MapProperty: SelectedRegion
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ SelectedRegion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// StrProperty: HeightmapFilePath
    /// </summary>
    public unsafe BmSDK.FString HeightmapFilePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bIsValid
    /// </summary>
    public unsafe bool bIsValid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }
}
