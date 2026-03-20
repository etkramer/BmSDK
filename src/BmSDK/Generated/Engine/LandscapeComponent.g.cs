#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LandscapeComponent<br/>
/// (size = 836)
/// (flags = 2290090194)
/// </summary>
public partial class LandscapeComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LandscapeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LandscapeComponent() { }

    /// <summary>
    /// Constructs a new LandscapeComponent
    /// </summary>
    public LandscapeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LandscapeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LandscapeComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// Struct: FWeightmapLayerAllocationInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 10)]
    public partial record struct FWeightmapLayerAllocationInfo
    {
        /// <summary>
        /// NameProperty: LayerName
        /// </summary>
        public unsafe BmSDK.FName LayerName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: WeightmapTextureIndex
        /// </summary>
        public unsafe byte WeightmapTextureIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: WeightmapTextureChannel
        /// </summary>
        public unsafe byte WeightmapTextureChannel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 9); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9); }; }
        }
    }

    /// <summary>
    /// IntProperty: SectionBaseX
    /// </summary>
    public unsafe int SectionBaseX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// IntProperty: SectionBaseY
    /// </summary>
    public unsafe int SectionBaseY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// IntProperty: ComponentSizeQuads
    /// </summary>
    public unsafe int ComponentSizeQuads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// IntProperty: SubsectionSizeQuads
    /// </summary>
    public unsafe int SubsectionSizeQuads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: NumSubsections
    /// </summary>
    public unsafe int NumSubsections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ObjectProperty: OverrideMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface OverrideMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ObjectProperty: MaterialInstance
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MaterialInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ObjectProperty: HeightmapTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D HeightmapTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// ArrayProperty: WeightmapLayerAllocations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.LandscapeComponent.FWeightmapLayerAllocationInfo> WeightmapLayerAllocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.LandscapeComponent.FWeightmapLayerAllocationInfo>>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ArrayProperty: WeightmapTextures
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Texture2D> WeightmapTextures
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Texture2D>>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// StructProperty: WeightmapScaleBias
    /// </summary>
    public unsafe System.Numerics.Vector4 WeightmapScaleBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector4>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// FloatProperty: WeightmapSubsectionOffset
    /// </summary>
    public unsafe float WeightmapSubsectionOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// StructProperty: HeightmapScaleBias
    /// </summary>
    public unsafe System.Numerics.Vector4 HeightmapScaleBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector4>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// StructProperty: CachedBoxSphereBounds
    /// </summary>
    public unsafe BmSDK.GameObject.FBoxSphereBounds CachedBoxSphereBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoxSphereBounds>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StructProperty: CachedLocalBox
    /// </summary>
    public unsafe BmSDK.GameObject.FBox CachedLocalBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBox>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// StructProperty: LightingGuid
    /// </summary>
    public unsafe BmSDK.GameObject.FGuid LightingGuid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ArrayProperty: ShadowMaps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ShadowMap2D> ShadowMaps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ShadowMap2D>>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ArrayProperty: IrrelevantLights
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FGuid> IrrelevantLights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FGuid>>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// StructProperty: LightMap
    /// </summary>
    public unsafe BmSDK.Engine.EngineTypes.FLightMapRef LightMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.EngineTypes.FLightMapRef>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// StructProperty: EditToolRenderData
    /// </summary>
    public unsafe System.IntPtr EditToolRenderData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// IntProperty: CollisionMipLevel
    /// </summary>
    public unsafe int CollisionMipLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// StructProperty: PlatformData
    /// </summary>
    public unsafe System.IntPtr PlatformData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// IntProperty: PlatformDataSize
    /// </summary>
    public unsafe int PlatformDataSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// BoolProperty: bNeedPostUndo
    /// </summary>
    public unsafe bool bNeedPostUndo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// IntProperty: ForcedLOD
    /// </summary>
    public unsafe int ForcedLOD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ByteProperty: NeighborLOD
    /// </summary>
    public unsafe byte NeighborLOD_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }
    /// <summary>
    /// ByteProperty: NeighborLOD
    /// </summary>
    public unsafe byte NeighborLOD_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 817); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 817); }
    }
    /// <summary>
    /// ByteProperty: NeighborLOD
    /// </summary>
    public unsafe byte NeighborLOD_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 818); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 818); }
    }
    /// <summary>
    /// ByteProperty: NeighborLOD
    /// </summary>
    public unsafe byte NeighborLOD_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 819); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 819); }
    }
    /// <summary>
    /// ByteProperty: NeighborLOD
    /// </summary>
    public unsafe byte NeighborLOD_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }
    /// <summary>
    /// ByteProperty: NeighborLOD
    /// </summary>
    public unsafe byte NeighborLOD_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 821); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 821); }
    }
    /// <summary>
    /// ByteProperty: NeighborLOD
    /// </summary>
    public unsafe byte NeighborLOD_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 822); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 822); }
    }
    /// <summary>
    /// ByteProperty: NeighborLOD
    /// </summary>
    public unsafe byte NeighborLOD_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 823); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 823); }
    }

    /// <summary>
    /// ByteProperty: NeighborLODBias
    /// </summary>
    public unsafe byte NeighborLODBias_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
    /// <summary>
    /// ByteProperty: NeighborLODBias
    /// </summary>
    public unsafe byte NeighborLODBias_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 825); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 825); }
    }
    /// <summary>
    /// ByteProperty: NeighborLODBias
    /// </summary>
    public unsafe byte NeighborLODBias_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 826); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 826); }
    }
    /// <summary>
    /// ByteProperty: NeighborLODBias
    /// </summary>
    public unsafe byte NeighborLODBias_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 827); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 827); }
    }
    /// <summary>
    /// ByteProperty: NeighborLODBias
    /// </summary>
    public unsafe byte NeighborLODBias_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }
    /// <summary>
    /// ByteProperty: NeighborLODBias
    /// </summary>
    public unsafe byte NeighborLODBias_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 829); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 829); }
    }
    /// <summary>
    /// ByteProperty: NeighborLODBias
    /// </summary>
    public unsafe byte NeighborLODBias_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 830); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 830); }
    }
    /// <summary>
    /// ByteProperty: NeighborLODBias
    /// </summary>
    public unsafe byte NeighborLODBias_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 831); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 831); }
    }

    /// <summary>
    /// IntProperty: LODBias
    /// </summary>
    public unsafe int LODBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }
}
