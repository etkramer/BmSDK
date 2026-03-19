#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: FracturedStaticMeshComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class FracturedStaticMeshComponent : BmSDK.Engine.FracturedBaseComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.FracturedStaticMeshComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal FracturedStaticMeshComponent() { }

    /// <summary>
    /// Constructs a new FracturedStaticMeshComponent
    /// </summary>
    public FracturedStaticMeshComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, FracturedStaticMeshComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FracturedStaticMeshComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: FragmentNeighborsVisible
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>>>> FragmentNeighborsVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>>>>>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// StructProperty: VisibleBox
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VisibleBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bUseSkinnedRendering
    /// </summary>
    public unsafe bool bUseSkinnedRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bUseVisibleVertsForBounds
    /// </summary>
    public unsafe bool bUseVisibleVertsForBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bTopFragmentsRootNonDestroyable
    /// </summary>
    public unsafe bool bTopFragmentsRootNonDestroyable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bBottomFragmentsRootNonDestroyable
    /// </summary>
    public unsafe bool bBottomFragmentsRootNonDestroyable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bCopyParentMaterialInstancesOnAttach
    /// </summary>
    public unsafe bool bCopyParentMaterialInstancesOnAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: XRaySet
    /// </summary>
    public unsafe bool XRaySet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: TopBottomFragmentDistThreshold
    /// </summary>
    public unsafe float TopBottomFragmentDistThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ObjectProperty: LoseChunkOutsideMaterialOverride
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LoseChunkOutsideMaterialOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: OldMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OldMaterial_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }
    /// <summary>
    /// ObjectProperty: OldMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OldMaterial_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }
    /// <summary>
    /// ObjectProperty: OldMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OldMaterial_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }
    /// <summary>
    /// ObjectProperty: OldMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OldMaterial_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
    /// <summary>
    /// ObjectProperty: OldMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OldMaterial_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }
    /// <summary>
    /// ObjectProperty: OldMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OldMaterial_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }
    /// <summary>
    /// ObjectProperty: OldMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OldMaterial_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }
    /// <summary>
    /// ObjectProperty: OldMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OldMaterial_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
    /// <summary>
    /// ObjectProperty: OldMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OldMaterial_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }
    /// <summary>
    /// ObjectProperty: OldMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OldMaterial_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ComponentProperty: SkinnedComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SkinnedComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: FragmentBoundsMaxZ
    /// </summary>
    public unsafe float FragmentBoundsMaxZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: FragmentBoundsMinZ
    /// </summary>
    public unsafe float FragmentBoundsMinZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
}
