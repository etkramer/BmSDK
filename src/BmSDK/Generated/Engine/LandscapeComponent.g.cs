#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LandscapeComponent<br/>
/// (size = 648)
/// (flags = 2290090130)
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

    /// <summary>
    /// Gets the class default object as LandscapeComponent.
    /// </summary>
    public static LandscapeComponent DefaultObject => (LandscapeComponent)StaticClass().DefaultObject;

    internal LandscapeComponent() { }

    /// <summary>
    /// Constructs a new LandscapeComponent
    /// </summary>
    public LandscapeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LandscapeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LandscapeComponent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LandscapeComponent>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeComponent>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LandscapeComponent>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeComponent>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeComponent>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeComponent>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LandscapeComponent>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeComponent>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Enum: ETerrainComponentNeighbors
    /// </summary>
    public enum ETerrainComponentNeighbors
    {
        TCN_NW = 0,
        TCN_N = 1,
        TCN_NE = 2,
        TCN_W = 3,
        TCN_E = 4,
        TCN_SW = 5,
        TCN_S = 6,
        TCN_SE = 7,
        TCN_MAX = 8,
    }

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
    /// Struct: FLandscapeComponentAlphaInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FLandscapeComponentAlphaInfo
    {
        /// <summary>
        /// IntProperty: LayerIndex
        /// </summary>
        public unsafe int LayerIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: AlphaValues
        /// </summary>
        public unsafe BmSDK.TArray<byte> AlphaValues
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// IntProperty: SectionBaseX
    /// </summary>
    public unsafe int SectionBaseX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// IntProperty: SectionBaseY
    /// </summary>
    public unsafe int SectionBaseY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// IntProperty: ComponentSizeQuads
    /// </summary>
    public unsafe int ComponentSizeQuads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// IntProperty: SubsectionSizeQuads
    /// </summary>
    public unsafe int SubsectionSizeQuads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// IntProperty: NumSubsections
    /// </summary>
    public unsafe int NumSubsections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ObjectProperty: MaterialInstance
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MaterialInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ArrayProperty: EditingAlphaLayerData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.LandscapeComponent.FLandscapeComponentAlphaInfo> EditingAlphaLayerData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.LandscapeComponent.FLandscapeComponentAlphaInfo>>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// NameProperty: EditingAlphaLayerName
    /// </summary>
    public unsafe BmSDK.FName EditingAlphaLayerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ArrayProperty: WeightmapLayerAllocations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.LandscapeComponent.FWeightmapLayerAllocationInfo> WeightmapLayerAllocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.LandscapeComponent.FWeightmapLayerAllocationInfo>>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ArrayProperty: WeightmapTextures
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Texture2D> WeightmapTextures
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Texture2D>>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// StructProperty: WeightmapScaleBias
    /// </summary>
    public unsafe ref System.Numerics.Vector4 WeightmapScaleBias
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector4>(Ptr + 480);

    /// <summary>
    /// FloatProperty: WeightmapSubsectionOffset
    /// </summary>
    public unsafe float WeightmapSubsectionOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// StructProperty: HeightmapScaleBias
    /// </summary>
    public unsafe ref System.Numerics.Vector4 HeightmapScaleBias
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector4>(Ptr + 512);

    /// <summary>
    /// FloatProperty: HeightmapSubsectionOffset
    /// </summary>
    public unsafe float HeightmapSubsectionOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StructProperty: LayerUVPan
    /// </summary>
    public unsafe ref System.Numerics.Vector2 LayerUVPan
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 532);

    /// <summary>
    /// ObjectProperty: HeightmapTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D HeightmapTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// StructProperty: CachedBoxSphereBounds
    /// </summary>
    public unsafe ref BmSDK.GameObject.FBoxSphereBounds CachedBoxSphereBounds
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FBoxSphereBounds>(Ptr + 544);

    /// <summary>
    /// IntProperty: StaticLightingResolution
    /// </summary>
    public unsafe int StaticLightingResolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// StructProperty: LightingGuid
    /// </summary>
    public unsafe ref BmSDK.GameObject.FGuid LightingGuid
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FGuid>(Ptr + 576);

    /// <summary>
    /// ArrayProperty: ShadowMaps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ShadowMap2D> ShadowMaps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ShadowMap2D>>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ArrayProperty: IrrelevantLights
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FGuid> IrrelevantLights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FGuid>>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// StructProperty: LightMap
    /// </summary>
    public unsafe ref BmSDK.Engine.EngineTypes.FLightMapRef LightMap
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.EngineTypes.FLightMapRef>(Ptr + 604);

    /// <summary>
    /// StructProperty: EditToolRenderData
    /// </summary>
    public unsafe System.IntPtr EditToolRenderData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// IntProperty: CollisionMipLevel
    /// </summary>
    public unsafe int CollisionMipLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ComponentProperty: Neighbors
    /// </summary>
    public unsafe BmSDK.Engine.LandscapeComponent Neighbors_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LandscapeComponent>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
    /// <summary>
    /// ComponentProperty: Neighbors
    /// </summary>
    public unsafe BmSDK.Engine.LandscapeComponent Neighbors_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LandscapeComponent>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }
    /// <summary>
    /// ComponentProperty: Neighbors
    /// </summary>
    public unsafe BmSDK.Engine.LandscapeComponent Neighbors_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LandscapeComponent>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }
    /// <summary>
    /// ComponentProperty: Neighbors
    /// </summary>
    public unsafe BmSDK.Engine.LandscapeComponent Neighbors_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LandscapeComponent>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }
    /// <summary>
    /// ComponentProperty: Neighbors
    /// </summary>
    public unsafe BmSDK.Engine.LandscapeComponent Neighbors_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LandscapeComponent>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }
    /// <summary>
    /// ComponentProperty: Neighbors
    /// </summary>
    public unsafe BmSDK.Engine.LandscapeComponent Neighbors_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LandscapeComponent>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }
    /// <summary>
    /// ComponentProperty: Neighbors
    /// </summary>
    public unsafe BmSDK.Engine.LandscapeComponent Neighbors_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LandscapeComponent>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }
    /// <summary>
    /// ComponentProperty: Neighbors
    /// </summary>
    public unsafe BmSDK.Engine.LandscapeComponent Neighbors_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LandscapeComponent>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }
}
