#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: _Engine<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class _Engine : BmSDK.Subsystem, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Engine", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal _Engine() { }

    /// <summary>
    /// Constructs a new _Engine
    /// </summary>
    public _Engine(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, _Engine Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected _Engine(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TinyFont
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TinyFont
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: SmallFont
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SmallFont
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: MediumFont
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MediumFont
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: LargeFont
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LargeFont
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: SubtitleFont
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SubtitleFont
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: DefaultMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: DefaultDecalMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultDecalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: DefaultTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: WatermarkTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WatermarkTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: BlackTextureCube
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BlackTextureCube
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: DefaultTwoSidedMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultTwoSidedMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ObjectProperty: WireframeMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WireframeMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ObjectProperty: EmissiveTexturedMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EmissiveTexturedMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ObjectProperty: GeomMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GeomMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: DefaultFogVolumeMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultFogVolumeMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: TickMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TickMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ObjectProperty: CrossMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CrossMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ObjectProperty: LevelColorationLitMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LevelColorationLitMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ObjectProperty: LevelColorationUnlitMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LevelColorationUnlitMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ObjectProperty: LevelColorationLitTransMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LevelColorationLitTransMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ObjectProperty: LevelColorationUnlitTransMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LevelColorationUnlitTransMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ObjectProperty: LightingTexelDensityMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LightingTexelDensityMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: ShadedLevelColorationLitMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShadedLevelColorationLitMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ObjectProperty: ShadedLevelColorationUnlitMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShadedLevelColorationUnlitMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ObjectProperty: RemoveSurfaceMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RemoveSurfaceMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ObjectProperty: VertexColorMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VertexColorMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: VertexColorViewModeMaterial_ColorOnly
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VertexColorViewModeMaterial_ColorOnly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ObjectProperty: VertexColorViewModeMaterial_AlphaAsColor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VertexColorViewModeMaterial_AlphaAsColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ObjectProperty: VertexColorViewModeMaterial_RedOnly
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VertexColorViewModeMaterial_RedOnly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// ObjectProperty: VertexColorViewModeMaterial_GreenOnly
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VertexColorViewModeMaterial_GreenOnly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ObjectProperty: VertexColorViewModeMaterial_BlueOnly
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VertexColorViewModeMaterial_BlueOnly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// ObjectProperty: HeatmapMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HeatmapMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// ObjectProperty: BoneWeightMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BoneWeightMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ObjectProperty: TangentColorMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TangentColorMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// ObjectProperty: MobileEmulationMasterMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MobileEmulationMasterMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ObjectProperty: ProcBuildingSimpleMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ProcBuildingSimpleMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// ObjectProperty: BuildingQuadStaticMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BuildingQuadStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ObjectProperty: EditorBrushMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EditorBrushMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ObjectProperty: DefaultPhysMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultPhysMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ObjectProperty: LandscapeHolePhysMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LandscapeHolePhysMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// ObjectProperty: ApexDamageParams
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ApexDamageParams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ObjectProperty: TerrainErrorMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TerrainErrorMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ObjectProperty: DefaultPostProcess
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultPostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ObjectProperty: ThumbnailSkeletalMeshPostProcess
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThumbnailSkeletalMeshPostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// ObjectProperty: ThumbnailParticleSystemPostProcess
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThumbnailParticleSystemPostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ObjectProperty: ThumbnailMaterialPostProcess
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThumbnailMaterialPostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ObjectProperty: DefaultUIScenePostProcess
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultUIScenePostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ObjectProperty: DefaultUICaretMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultUICaretMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ObjectProperty: SceneCaptureReflectActorMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SceneCaptureReflectActorMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// ObjectProperty: SceneCaptureCubeActorMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SceneCaptureCubeActorMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ObjectProperty: ScreenDoorNoiseTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ScreenDoorNoiseTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// ObjectProperty: ImageGrainNoiseTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImageGrainNoiseTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// ObjectProperty: RandomAngleTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RandomAngleTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// ObjectProperty: RandomNormalTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RandomNormalTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// ObjectProperty: RandomMirrorDiscTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RandomMirrorDiscTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// ObjectProperty: WeightMapPlaceholderTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeightMapPlaceholderTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ObjectProperty: MapMaskTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MapMaskTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: PostProcessNoiseTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PostProcessNoiseTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ObjectProperty: ScreenDirt
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ScreenDirt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ObjectProperty: PostProcessGlareBeamTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PostProcessGlareBeamTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ObjectProperty: EyelashMask
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EyelashMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ObjectProperty: GhostMask
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GhostMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ObjectProperty: Rain_TemporalSplashPattern
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Rain_TemporalSplashPattern
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: Dust_DetailMap
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Dust_DetailMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ObjectProperty: Dust_ReliefMap
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Dust_ReliefMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ObjectProperty: Pollen_DetailMap
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Pollen_DetailMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ObjectProperty: Pollen_ReliefMap
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Pollen_ReliefMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ObjectProperty: TileComplexityTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TileComplexityTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// ObjectProperty: SMAA_AreaTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SMAA_AreaTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ObjectProperty: SMAA_SearchTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SMAA_SearchTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ObjectProperty: LightProjection_RenderTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LightProjection_RenderTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// ObjectProperty: LoadingIconTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LoadingIconTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ObjectProperty: LightMapDensityTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LightMapDensityTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: LightMapDensityNormal
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LightMapDensityNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: DefaultSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: Client
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Client
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: GameViewport
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GameViewport
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: DebugData
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DebugData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: GlobalTranslationContext
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GlobalTranslationContext
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ClassProperty: PersistentDebugDataClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PersistentDebugDataClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ComponentProperty: TempCollisionBackLight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TempCollisionBackLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ComponentProperty: TempCollisionLight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TempCollisionLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ClassProperty: OnlineSubsystemClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OnlineSubsystemClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ClassProperty: LocalPlayerClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LocalPlayerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ClassProperty: DataStoreClientClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DataStoreClientClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ClassProperty: GameViewportClientClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GameViewportClientClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ClassProperty: ConsoleClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ConsoleClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// StrProperty: TinyFontName
    /// </summary>
    public unsafe BmSDK.FString TinyFontName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// StrProperty: SmallFontName
    /// </summary>
    public unsafe BmSDK.FString SmallFontName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// StrProperty: MediumFontName
    /// </summary>
    public unsafe BmSDK.FString MediumFontName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// StrProperty: LargeFontName
    /// </summary>
    public unsafe BmSDK.FString LargeFontName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// StrProperty: SubtitleFontName
    /// </summary>
    public unsafe BmSDK.FString SubtitleFontName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalFonts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> AdditionalFonts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalFontNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> AdditionalFontNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// StrProperty: ConsoleClassName
    /// </summary>
    public unsafe BmSDK.FString ConsoleClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StrProperty: GameViewportClientClassName
    /// </summary>
    public unsafe BmSDK.FString GameViewportClientClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// StrProperty: DataStoreClientClassName
    /// </summary>
    public unsafe BmSDK.FString DataStoreClientClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// StrProperty: LocalPlayerClassName
    /// </summary>
    public unsafe BmSDK.FString LocalPlayerClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// StrProperty: DefaultMaterialName
    /// </summary>
    public unsafe BmSDK.FString DefaultMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// StrProperty: DefaultDecalMaterialName
    /// </summary>
    public unsafe BmSDK.FString DefaultDecalMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// StrProperty: DefaultTextureName
    /// </summary>
    public unsafe BmSDK.FString DefaultTextureName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// StrProperty: DefaultTwoSidedMaterialName
    /// </summary>
    public unsafe BmSDK.FString DefaultTwoSidedMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// StrProperty: WireframeMaterialName
    /// </summary>
    public unsafe BmSDK.FString WireframeMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// StrProperty: EmissiveTexturedMaterialName
    /// </summary>
    public unsafe BmSDK.FString EmissiveTexturedMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// StrProperty: GeomMaterialName
    /// </summary>
    public unsafe BmSDK.FString GeomMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// StrProperty: DefaultFogVolumeMaterialName
    /// </summary>
    public unsafe BmSDK.FString DefaultFogVolumeMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// StrProperty: TickMaterialName
    /// </summary>
    public unsafe BmSDK.FString TickMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// StrProperty: CrossMaterialName
    /// </summary>
    public unsafe BmSDK.FString CrossMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// StrProperty: LevelColorationLitMaterialName
    /// </summary>
    public unsafe BmSDK.FString LevelColorationLitMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// StrProperty: LevelColorationUnlitMaterialName
    /// </summary>
    public unsafe BmSDK.FString LevelColorationUnlitMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// StrProperty: LevelColorationLitTransMaterialName
    /// </summary>
    public unsafe BmSDK.FString LevelColorationLitTransMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// StrProperty: LevelColorationUnlitTransMaterialName
    /// </summary>
    public unsafe BmSDK.FString LevelColorationUnlitTransMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// StrProperty: LightingTexelDensityName
    /// </summary>
    public unsafe BmSDK.FString LightingTexelDensityName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// StrProperty: ShadedLevelColorationLitMaterialName
    /// </summary>
    public unsafe BmSDK.FString ShadedLevelColorationLitMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// StrProperty: ShadedLevelColorationUnlitMaterialName
    /// </summary>
    public unsafe BmSDK.FString ShadedLevelColorationUnlitMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// StrProperty: RemoveSurfaceMaterialName
    /// </summary>
    public unsafe BmSDK.FString RemoveSurfaceMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// StrProperty: VertexColorMaterialName
    /// </summary>
    public unsafe BmSDK.FString VertexColorMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// StrProperty: VertexColorViewModeMaterialName_ColorOnly
    /// </summary>
    public unsafe BmSDK.FString VertexColorViewModeMaterialName_ColorOnly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// StrProperty: VertexColorViewModeMaterialName_AlphaAsColor
    /// </summary>
    public unsafe BmSDK.FString VertexColorViewModeMaterialName_AlphaAsColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// StrProperty: VertexColorViewModeMaterialName_RedOnly
    /// </summary>
    public unsafe BmSDK.FString VertexColorViewModeMaterialName_RedOnly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// StrProperty: VertexColorViewModeMaterialName_GreenOnly
    /// </summary>
    public unsafe BmSDK.FString VertexColorViewModeMaterialName_GreenOnly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// StrProperty: VertexColorViewModeMaterialName_BlueOnly
    /// </summary>
    public unsafe BmSDK.FString VertexColorViewModeMaterialName_BlueOnly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// StrProperty: HeatmapMaterialName
    /// </summary>
    public unsafe BmSDK.FString HeatmapMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// StrProperty: BoneWeightMaterialName
    /// </summary>
    public unsafe BmSDK.FString BoneWeightMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// StrProperty: TangentColorMaterialName
    /// </summary>
    public unsafe BmSDK.FString TangentColorMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// StrProperty: MobileEmulationMasterMaterialName
    /// </summary>
    public unsafe BmSDK.FString MobileEmulationMasterMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// StrProperty: ProcBuildingSimpleMaterialName
    /// </summary>
    public unsafe BmSDK.FString ProcBuildingSimpleMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// StrProperty: BuildingQuadStaticMeshName
    /// </summary>
    public unsafe BmSDK.FString BuildingQuadStaticMeshName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// FloatProperty: ProcBuildingLODColorTexelsPerWorldUnit
    /// </summary>
    public unsafe float ProcBuildingLODColorTexelsPerWorldUnit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// FloatProperty: ProcBuildingLODLightingTexelsPerWorldUnit
    /// </summary>
    public unsafe float ProcBuildingLODLightingTexelsPerWorldUnit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// IntProperty: MaxProcBuildingLODColorTextureSize
    /// </summary>
    public unsafe int MaxProcBuildingLODColorTextureSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// IntProperty: MaxProcBuildingLODLightingTextureSize
    /// </summary>
    public unsafe int MaxProcBuildingLODLightingTextureSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: UseProcBuildingLODTextureCropping
    /// </summary>
    public unsafe bool UseProcBuildingLODTextureCropping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: ForcePowerOfTwoProcBuildingLODTextures
    /// </summary>
    public unsafe bool ForcePowerOfTwoProcBuildingLODTextures
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bCombineSimilarMappings
    /// </summary>
    public unsafe bool bCombineSimilarMappings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bRenderLightMapDensityGrayscale
    /// </summary>
    public unsafe bool bRenderLightMapDensityGrayscale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bUseSound
    /// </summary>
    public unsafe bool bUseSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bUseBackgroundLevelStreaming
    /// </summary>
    public unsafe bool bUseBackgroundLevelStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bSubtitlesEnabled
    /// </summary>
    public unsafe bool bSubtitlesEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bSubtitlesForcedOff
    /// </summary>
    public unsafe bool bSubtitlesForcedOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bSmoothFrameRate
    /// </summary>
    public unsafe bool bSmoothFrameRate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bCheckForMultiplePawnsSpawnedInAFrame
    /// </summary>
    public unsafe bool bCheckForMultiplePawnsSpawnedInAFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: OASecondsToToggleDebugCamera
    /// </summary>
    public unsafe bool OASecondsToToggleDebugCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bShouldGenerateSimpleLightmaps
    /// </summary>
    public unsafe bool bShouldGenerateSimpleLightmaps
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bForceStaticTerrain
    /// </summary>
    public unsafe bool bForceStaticTerrain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bUseInvertedLeftStick
    /// </summary>
    public unsafe bool bUseInvertedLeftStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: HackJoystickIdsForMultiPlayer
    /// </summary>
    public unsafe bool HackJoystickIdsForMultiPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: AllowControllerInputWithoutFocus
    /// </summary>
    public unsafe bool AllowControllerInputWithoutFocus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bForceCPUSkinning
    /// </summary>
    public unsafe bool bForceCPUSkinning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bUsePostProcessEffects
    /// </summary>
    public unsafe bool bUsePostProcessEffects
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bOnScreenKismetWarnings
    /// </summary>
    public unsafe bool bOnScreenKismetWarnings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bEnableKismetLogging
    /// </summary>
    public unsafe bool bEnableKismetLogging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bAllowMatureLanguage
    /// </summary>
    public unsafe bool bAllowMatureLanguage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bShowCoderWarnings
    /// </summary>
    public unsafe bool bShowCoderWarnings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bShowDesignerWarnings
    /// </summary>
    public unsafe bool bShowDesignerWarnings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bPauseOnLossOfFocus
    /// </summary>
    public unsafe bool bPauseOnLossOfFocus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bCheckParticleRenderSize
    /// </summary>
    public unsafe bool bCheckParticleRenderSize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bEnablePerfMemDump
    /// </summary>
    public unsafe bool bEnablePerfMemDump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bEnableColorClear
    /// </summary>
    public unsafe bool bEnableColorClear
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bAreConstraintsDirty
    /// </summary>
    public unsafe bool bAreConstraintsDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bHasPendingGlobalReattach
    /// </summary>
    public unsafe bool bHasPendingGlobalReattach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bPausedCheck
    /// </summary>
    public unsafe bool bPausedCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bEnableOnScreenDebugMessages
    /// </summary>
    public unsafe bool bEnableOnScreenDebugMessages
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bEnableOnScreenDebugMessagesDisplay
    /// </summary>
    public unsafe bool bEnableOnScreenDebugMessagesDisplay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bSuppressMapWarnings
    /// </summary>
    public unsafe bool bSuppressMapWarnings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1464); }
    }

    /// <summary>
    /// BoolProperty: bCookSeparateSharedMPGameContent
    /// </summary>
    public unsafe bool bCookSeparateSharedMPGameContent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1464); }
    }

    /// <summary>
    /// BoolProperty: bUseRecastNavMesh
    /// </summary>
    public unsafe bool bUseRecastNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1464); }
    }

    /// <summary>
    /// BoolProperty: bDisableAILogging
    /// </summary>
    public unsafe bool bDisableAILogging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1464); }
    }

    /// <summary>
    /// BoolProperty: bUseNormalMapsForSimpleLightMaps
    /// </summary>
    public unsafe bool bUseNormalMapsForSimpleLightMaps
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1464); }
    }

    /// <summary>
    /// BoolProperty: bStartWithMatineeCapture
    /// </summary>
    public unsafe bool bStartWithMatineeCapture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1464); }
    }

    /// <summary>
    /// BoolProperty: bCompressMatineeCapture
    /// </summary>
    public unsafe bool bCompressMatineeCapture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1464); }
    }

    /// <summary>
    /// BoolProperty: bRockCaptureAudio
    /// </summary>
    public unsafe bool bRockCaptureAudio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1464); }
    }

    /// <summary>
    /// BoolProperty: bRockCaptureAudioNoVideo
    /// </summary>
    public unsafe bool bRockCaptureAudioNoVideo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1464); }
    }

    /// <summary>
    /// BoolProperty: bLockReadOnlyLevels
    /// </summary>
    public unsafe bool bLockReadOnlyLevels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1464); }
    }

    /// <summary>
    /// FloatProperty: MaxRMSDForCombiningMappings
    /// </summary>
    public unsafe float MaxRMSDForCombiningMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// IntProperty: ImageReflectionTextureSize
    /// </summary>
    public unsafe int ImageReflectionTextureSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// StructProperty: LightingOnlyBrightness
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LightingOnlyBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// ArrayProperty: LightComplexityColors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> LightComplexityColors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// ArrayProperty: ShaderComplexityColors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> ShaderComplexityColors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// FloatProperty: MaxPixelShaderAdditiveComplexityCount
    /// </summary>
    public unsafe float MaxPixelShaderAdditiveComplexityCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// FloatProperty: MinTextureDensity
    /// </summary>
    public unsafe float MinTextureDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// FloatProperty: IdealTextureDensity
    /// </summary>
    public unsafe float IdealTextureDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// FloatProperty: MaxTextureDensity
    /// </summary>
    public unsafe float MaxTextureDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// FloatProperty: MinLightMapDensity
    /// </summary>
    public unsafe float MinLightMapDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// FloatProperty: IdealLightMapDensity
    /// </summary>
    public unsafe float IdealLightMapDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// FloatProperty: MaxLightMapDensity
    /// </summary>
    public unsafe float MaxLightMapDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// FloatProperty: RenderLightMapDensityGrayscaleScale
    /// </summary>
    public unsafe float RenderLightMapDensityGrayscaleScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// FloatProperty: RenderLightMapDensityColorScale
    /// </summary>
    public unsafe float RenderLightMapDensityColorScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// StructProperty: LightMapDensityVertexMappedColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LightMapDensityVertexMappedColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// StructProperty: LightMapDensitySelectedColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LightMapDensitySelectedColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// ArrayProperty: StatColorMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> StatColorMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// StrProperty: EditorBrushMaterialName
    /// </summary>
    public unsafe BmSDK.FString EditorBrushMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// StrProperty: DefaultPhysMaterialName
    /// </summary>
    public unsafe BmSDK.FString DefaultPhysMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// StrProperty: LandscapeHolePhysMaterialName
    /// </summary>
    public unsafe BmSDK.FString LandscapeHolePhysMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }
    }

    /// <summary>
    /// StrProperty: ApexDamageParamsName
    /// </summary>
    public unsafe BmSDK.FString ApexDamageParamsName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }
    }

    /// <summary>
    /// IntProperty: ApexDestructibleCount
    /// </summary>
    public unsafe int ApexDestructibleCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// StrProperty: TerrainErrorMaterialName
    /// </summary>
    public unsafe BmSDK.FString TerrainErrorMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// IntProperty: TerrainMaterialMaxTextureCount
    /// </summary>
    public unsafe int TerrainMaterialMaxTextureCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// IntProperty: TerrainTessellationCheckCount
    /// </summary>
    public unsafe int TerrainTessellationCheckCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// FloatProperty: TerrainTessellationCheckDistance
    /// </summary>
    public unsafe float TerrainTessellationCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// StrProperty: DefaultOnlineSubsystemName
    /// </summary>
    public unsafe BmSDK.FString DefaultOnlineSubsystemName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// StrProperty: DefaultPostProcessName
    /// </summary>
    public unsafe BmSDK.FString DefaultPostProcessName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// StrProperty: ThumbnailSkeletalMeshPostProcessName
    /// </summary>
    public unsafe BmSDK.FString ThumbnailSkeletalMeshPostProcessName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// StrProperty: ThumbnailParticleSystemPostProcessName
    /// </summary>
    public unsafe BmSDK.FString ThumbnailParticleSystemPostProcessName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// StrProperty: ThumbnailMaterialPostProcessName
    /// </summary>
    public unsafe BmSDK.FString ThumbnailMaterialPostProcessName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// StrProperty: DefaultUIScenePostProcessName
    /// </summary>
    public unsafe BmSDK.FString DefaultUIScenePostProcessName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// StrProperty: DefaultUICaretMaterialName
    /// </summary>
    public unsafe BmSDK.FString DefaultUICaretMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }
    }

    /// <summary>
    /// StrProperty: SceneCaptureReflectActorMaterialName
    /// </summary>
    public unsafe BmSDK.FString SceneCaptureReflectActorMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// StrProperty: SceneCaptureCubeActorMaterialName
    /// </summary>
    public unsafe BmSDK.FString SceneCaptureCubeActorMaterialName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// StrProperty: ScreenDoorNoiseTextureName
    /// </summary>
    public unsafe BmSDK.FString ScreenDoorNoiseTextureName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// StrProperty: ImageGrainNoiseTextureName
    /// </summary>
    public unsafe BmSDK.FString ImageGrainNoiseTextureName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// StrProperty: RandomAngleTextureName
    /// </summary>
    public unsafe BmSDK.FString RandomAngleTextureName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// StrProperty: RandomNormalTextureName
    /// </summary>
    public unsafe BmSDK.FString RandomNormalTextureName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }
    }

    /// <summary>
    /// StrProperty: RandomMirrorDiscTextureName
    /// </summary>
    public unsafe BmSDK.FString RandomMirrorDiscTextureName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// StrProperty: WeightMapPlaceholderTextureName
    /// </summary>
    public unsafe BmSDK.FString WeightMapPlaceholderTextureName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// StrProperty: MapMaskTextureName
    /// </summary>
    public unsafe BmSDK.FString MapMaskTextureName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// StrProperty: PostProcessNoiseTextureName
    /// </summary>
    public unsafe BmSDK.FString PostProcessNoiseTextureName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }

    /// <summary>
    /// StrProperty: Rain_TemporalSplashPatternName
    /// </summary>
    public unsafe BmSDK.FString Rain_TemporalSplashPatternName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// StrProperty: Dust_DetailMapName
    /// </summary>
    public unsafe BmSDK.FString Dust_DetailMapName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// StrProperty: Dust_ReliefMapName
    /// </summary>
    public unsafe BmSDK.FString Dust_ReliefMapName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// StrProperty: Pollen_DetailMapName
    /// </summary>
    public unsafe BmSDK.FString Pollen_DetailMapName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// StrProperty: Pollen_ReliefMapName
    /// </summary>
    public unsafe BmSDK.FString Pollen_ReliefMapName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }

    /// <summary>
    /// StrProperty: LightProjection_RenderTargetName
    /// </summary>
    public unsafe BmSDK.FString LightProjection_RenderTargetName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// StrProperty: LightMapDensityTextureName
    /// </summary>
    public unsafe BmSDK.FString LightMapDensityTextureName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// StrProperty: LightMapDensityNormalName
    /// </summary>
    public unsafe BmSDK.FString LightMapDensityNormalName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// StrProperty: DefaultSoundName
    /// </summary>
    public unsafe BmSDK.FString DefaultSoundName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenPurgingPendingKillObjects
    /// </summary>
    public unsafe float TimeBetweenPurgingPendingKillObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// ArrayProperty: GamePlayers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> GamePlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// ArrayProperty: DeferredCommands
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DeferredCommands
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// IntProperty: TickCycles
    /// </summary>
    public unsafe int TickCycles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// IntProperty: GameCycles
    /// </summary>
    public unsafe int GameCycles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// IntProperty: ClientCycles
    /// </summary>
    public unsafe int ClientCycles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// FloatProperty: MaxSmoothedFrameRate
    /// </summary>
    public unsafe float MaxSmoothedFrameRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// FloatProperty: MinSmoothedFrameRate
    /// </summary>
    public unsafe float MinSmoothedFrameRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// IntProperty: NumPawnsAllowedToBeSpawnedInAFrame
    /// </summary>
    public unsafe int NumPawnsAllowedToBeSpawnedInAFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// StructProperty: RemoteControlExec
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RemoteControlExec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// StructProperty: MobileMaterialEmulator
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MobileMaterialEmulator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// StructProperty: C_WorldBox
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_WorldBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// StructProperty: C_BrushWire
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_BrushWire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// StructProperty: C_AddWire
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_AddWire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// StructProperty: C_SubtractWire
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_SubtractWire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// StructProperty: C_SemiSolidWire
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_SemiSolidWire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2212); }
    }

    /// <summary>
    /// StructProperty: C_NonSolidWire
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_NonSolidWire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// StructProperty: C_WireBackground
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_WireBackground
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// StructProperty: C_ScaleBoxHi
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_ScaleBoxHi
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// StructProperty: C_VolumeCollision
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_VolumeCollision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2228); }
    }

    /// <summary>
    /// StructProperty: C_BSPCollision
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_BSPCollision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// StructProperty: C_OrthoBackground
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_OrthoBackground
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// StructProperty: C_Volume
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_Volume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// StructProperty: C_BrushShape
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT C_BrushShape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// FloatProperty: StreamingDistanceFactor
    /// </summary>
    public unsafe float StreamingDistanceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// StrProperty: ScoutClassName
    /// </summary>
    public unsafe BmSDK.FString ScoutClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// ByteProperty: TransitionType
    /// </summary>
    public unsafe byte TransitionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// StrProperty: TransitionDescription
    /// </summary>
    public unsafe BmSDK.FString TransitionDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// StrProperty: TransitionGameType
    /// </summary>
    public unsafe BmSDK.FString TransitionGameType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// FloatProperty: MeshLODRange
    /// </summary>
    public unsafe float MeshLODRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// FloatProperty: CameraRotationThreshold
    /// </summary>
    public unsafe float CameraRotationThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// FloatProperty: CameraTranslationThreshold
    /// </summary>
    public unsafe float CameraTranslationThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// FloatProperty: PrimitiveProbablyVisibleTime
    /// </summary>
    public unsafe float PrimitiveProbablyVisibleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// FloatProperty: PercentUnoccludedRequeries
    /// </summary>
    public unsafe float PercentUnoccludedRequeries
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// FloatProperty: MaxOcclusionPixelsFraction
    /// </summary>
    public unsafe float MaxOcclusionPixelsFraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// IntProperty: PhysXLevel
    /// </summary>
    public unsafe int PhysXLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// FloatProperty: ClothingOffset
    /// </summary>
    public unsafe float ClothingOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// IntProperty: MaxFluidNumVerts
    /// </summary>
    public unsafe int MaxFluidNumVerts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// FloatProperty: FluidSimulationTimeLimit
    /// </summary>
    public unsafe float FluidSimulationTimeLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// IntProperty: MaxParticleResize
    /// </summary>
    public unsafe int MaxParticleResize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }

    /// <summary>
    /// IntProperty: MaxParticleResizeWarn
    /// </summary>
    public unsafe int MaxParticleResizeWarn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// IntProperty: MaxParticleVertexMemory
    /// </summary>
    public unsafe int MaxParticleVertexMemory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// IntProperty: MaxParticleSpriteCount
    /// </summary>
    public unsafe int MaxParticleSpriteCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2356); }
    }

    /// <summary>
    /// IntProperty: MaxParticleSubUVCount
    /// </summary>
    public unsafe int MaxParticleSubUVCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// IntProperty: BeginUPTryCount
    /// </summary>
    public unsafe int BeginUPTryCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// ArrayProperty: PendingDroppedNotes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PendingDroppedNotes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// StrProperty: DynamicCoverMeshComponentName
    /// </summary>
    public unsafe BmSDK.FString DynamicCoverMeshComponentName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// FloatProperty: NetClientTicksPerSecond
    /// </summary>
    public unsafe float NetClientTicksPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// FloatProperty: MaxTrackedOcclusionIncrement
    /// </summary>
    public unsafe float MaxTrackedOcclusionIncrement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// FloatProperty: TrackedOcclusionStepSize
    /// </summary>
    public unsafe float TrackedOcclusionStepSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// StrProperty: PersistentDebugDataClassName
    /// </summary>
    public unsafe BmSDK.FString PersistentDebugDataClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// IntProperty: FrameRateLimitingSetting
    /// </summary>
    public unsafe int FrameRateLimitingSetting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// StructProperty: DefaultSelectedMaterialColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DefaultSelectedMaterialColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// StructProperty: DefaultHoveredMaterialColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DefaultHoveredMaterialColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// StructProperty: SelectedMaterialColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SelectedMaterialColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// StructProperty: UnselectedMaterialColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT UnselectedMaterialColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// ArrayProperty: IgnoreSimulatedFuncWarnings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> IgnoreSimulatedFuncWarnings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// IntProperty: ScreenSaverInhibitorSemaphore
    /// </summary>
    public unsafe int ScreenSaverInhibitorSemaphore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// StructProperty: ScreenSaverInhibitor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ScreenSaverInhibitor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// StructProperty: LoadingMovieStartTime
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LoadingMovieStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2524); }
    }

    /// <summary>
    /// StrProperty: MatineeCaptureName
    /// </summary>
    public unsafe BmSDK.FString MatineeCaptureName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// StrProperty: MatineePackageCaptureName
    /// </summary>
    public unsafe BmSDK.FString MatineePackageCaptureName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// StrProperty: VisibleLevelsForMatineeCapture
    /// </summary>
    public unsafe BmSDK.FString VisibleLevelsForMatineeCapture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// IntProperty: MatineeCaptureFPS
    /// </summary>
    public unsafe int MatineeCaptureFPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// IntProperty: MatineeCaptureType
    /// </summary>
    public unsafe int MatineeCaptureType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// FloatProperty: ApexFSRotationalStrengthMultiplier
    /// </summary>
    public unsafe float ApexFSRotationalStrengthMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// FloatProperty: ApexFSRadialStrengthMultiplier
    /// </summary>
    public unsafe float ApexFSRadialStrengthMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// FloatProperty: ApexFSLiftStrengthMultiplier
    /// </summary>
    public unsafe float ApexFSLiftStrengthMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }

    /// <summary>
    /// FloatProperty: ApexFSDurationMultiplier
    /// </summary>
    public unsafe float ApexFSDurationMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// FloatProperty: ApexFSRotationalStrengthMultiplierFlex
    /// </summary>
    public unsafe float ApexFSRotationalStrengthMultiplierFlex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// FloatProperty: ApexFSRadialStrengthMultiplierFlex
    /// </summary>
    public unsafe float ApexFSRadialStrengthMultiplierFlex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// FloatProperty: ApexFSLiftStrengthMultiplierFlex
    /// </summary>
    public unsafe float ApexFSLiftStrengthMultiplierFlex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// FloatProperty: ApexFSDurationMultiplierFlex
    /// </summary>
    public unsafe float ApexFSDurationMultiplierFlex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// ArrayProperty: KismetLevelUpdatePriorities
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT KismetLevelUpdatePriorities
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }

    /// <summary>
    /// FloatProperty: SpeedToStartReducingDestructibleParticles
    /// </summary>
    public unsafe float SpeedToStartReducingDestructibleParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// FloatProperty: SpeedToStopReducingDestructibleParticles
    /// </summary>
    public unsafe float SpeedToStopReducingDestructibleParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// FloatProperty: ScalarToReduceDestructibleParticles
    /// </summary>
    public unsafe float ScalarToReduceDestructibleParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }
}
