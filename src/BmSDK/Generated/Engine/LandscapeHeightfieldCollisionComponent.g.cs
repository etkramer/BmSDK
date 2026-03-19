#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LandscapeHeightfieldCollisionComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LandscapeHeightfieldCollisionComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LandscapeHeightfieldCollisionComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LandscapeHeightfieldCollisionComponent() { }

    /// <summary>
    /// Constructs a new LandscapeHeightfieldCollisionComponent
    /// </summary>
    public LandscapeHeightfieldCollisionComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LandscapeHeightfieldCollisionComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LandscapeHeightfieldCollisionComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: CollisionHeightData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CollisionHeightData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ArrayProperty: ComponentLayers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>> ComponentLayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// StructProperty: DominantLayerData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DominantLayerData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// IntProperty: SectionBaseX
    /// </summary>
    public unsafe int SectionBaseX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// IntProperty: SectionBaseY
    /// </summary>
    public unsafe int SectionBaseY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// IntProperty: CollisionSizeQuads
    /// </summary>
    public unsafe int CollisionSizeQuads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: CollisionScale
    /// </summary>
    public unsafe float CollisionScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ArrayProperty: CollisionQuadFlags
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> CollisionQuadFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: PhysicalMaterials
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT PhysicalMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StructProperty: RBHeightfield
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RBHeightfield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// StructProperty: CachedBoxSphereBounds
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CachedBoxSphereBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: bIncludeHoles
    /// </summary>
    public unsafe bool bIncludeHoles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bHeightFieldDataHasHole
    /// </summary>
    public unsafe bool bHeightFieldDataHasHole
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }
}
