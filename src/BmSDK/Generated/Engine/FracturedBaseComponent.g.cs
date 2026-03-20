#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: FracturedBaseComponent<br/>
/// (flags = 0)
/// </summary>
public partial class FracturedBaseComponent : BmSDK.Engine.StaticMeshComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.FracturedBaseComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal FracturedBaseComponent() { }

    /// <summary>
    /// Constructs a new FracturedBaseComponent
    /// </summary>
    public FracturedBaseComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, FracturedBaseComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FracturedBaseComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ComponentBaseResources
    /// </summary>
    public unsafe System.IntPtr ComponentBaseResources
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// StructProperty: ReleaseResourcesFence
    /// </summary>
    public unsafe BmSDK.GameObject.FRenderCommandFence_Mirror ReleaseResourcesFence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FRenderCommandFence_Mirror>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ArrayProperty: VisibleFragments
    /// </summary>
    public unsafe BmSDK.TArray<byte> VisibleFragments
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bVisibilityHasChanged
    /// </summary>
    public unsafe bool bVisibilityHasChanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bVisibilityReset
    /// </summary>
    public unsafe bool bVisibilityReset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bInitialVisibilityValue
    /// </summary>
    public unsafe bool bInitialVisibilityValue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bUseDynamicIndexBuffer
    /// </summary>
    public unsafe bool bUseDynamicIndexBuffer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bUseDynamicIBWithHiddenFragments
    /// </summary>
    public unsafe bool bUseDynamicIBWithHiddenFragments
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// IntProperty: NumResourceIndices
    /// </summary>
    public unsafe int NumResourceIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ByteProperty: BoxCollisionType
    /// </summary>
    public unsafe BmSDK.Engine.FracturedBaseComponent.ESimpleCollisionUsageType BoxCollisionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FracturedBaseComponent.ESimpleCollisionUsageType>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ByteProperty: LineCollisionType
    /// </summary>
    public unsafe BmSDK.Engine.FracturedBaseComponent.ESimpleCollisionUsageType LineCollisionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FracturedBaseComponent.ESimpleCollisionUsageType>(Ptr + 785); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 785); }
    }

    /// <summary>
    /// IntProperty: bResetStaticMesh
    /// </summary>
    public unsafe int bResetStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }
}
