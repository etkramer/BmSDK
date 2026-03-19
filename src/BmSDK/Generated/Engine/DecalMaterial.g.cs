#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DecalMaterial<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DecalMaterial : BmSDK.Engine.Material, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DecalMaterial", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DecalMaterial() { }

    /// <summary>
    /// Constructs a new DecalMaterial
    /// </summary>
    public DecalMaterial(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DecalMaterial Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DecalMaterial(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: PhysMaterialMask
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysMaterialMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: BlackPhysicalMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BlackPhysicalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: WhitePhysicalMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WhitePhysicalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: PhysMaterialMaskUVChannel
    /// </summary>
    public unsafe int PhysMaterialMaskUVChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ByteProperty: NvidiaParticleDownsampling
    /// </summary>
    public unsafe byte NvidiaParticleDownsampling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// ByteProperty: BlendMode
    /// </summary>
    public unsafe byte BlendMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 161); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 161); }
    }

    /// <summary>
    /// ByteProperty: LightingModel
    /// </summary>
    public unsafe byte LightingModel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 162); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 162); }
    }

    /// <summary>
    /// ByteProperty: DecalPriority
    /// </summary>
    public unsafe byte DecalPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 163); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 163); }
    }

    /// <summary>
    /// ByteProperty: DecalDrawMode
    /// </summary>
    public unsafe byte DecalDrawMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ByteProperty: D3D11TessellationMode
    /// </summary>
    public unsafe byte D3D11TessellationMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 165); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 165); }
    }

    /// <summary>
    /// StructProperty: DiffuseColor
    /// </summary>
    public unsafe BmSDK.Engine.Material.DiffusePower DiffuseColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.DiffusePower>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StructProperty: DiffusePower
    /// </summary>
    public unsafe BmSDK.Engine.Material.SpecularColor DiffusePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.SpecularColor>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// StructProperty: SpecularColor
    /// </summary>
    public unsafe BmSDK.Engine.Material.SpecularColor2 SpecularColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.SpecularColor2>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StructProperty: SpecularColor2
    /// </summary>
    public unsafe BmSDK.Engine.Material.SpecularPower SpecularColor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.SpecularPower>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// StructProperty: SpecularPower
    /// </summary>
    public unsafe BmSDK.Engine.Material.SpecularPower2 SpecularPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.SpecularPower2>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// StructProperty: SpecularPower2
    /// </summary>
    public unsafe BmSDK.Engine.Material.Normal SpecularPower2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.Normal>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// StructProperty: Normal
    /// </summary>
    public unsafe BmSDK.Engine.Material.EmissiveColor Normal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.EmissiveColor>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StructProperty: EmissiveColor
    /// </summary>
    public unsafe BmSDK.Engine.Material.Opacity EmissiveColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.Opacity>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// StructProperty: Opacity
    /// </summary>
    public unsafe BmSDK.Engine.Material.OpacityMask Opacity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.OpacityMask>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// StructProperty: OpacityMask
    /// </summary>
    public unsafe BmSDK.Engine.Material.Distortion OpacityMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.Distortion>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: OpacityMaskClipValue
    /// </summary>
    public unsafe float OpacityMaskClipValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// FloatProperty: OpacityMaskClipValuePostDepth
    /// </summary>
    public unsafe float OpacityMaskClipValuePostDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: ShadowDepthBias
    /// </summary>
    public unsafe float ShadowDepthBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// StructProperty: Distortion
    /// </summary>
    public unsafe BmSDK.Engine.Material.CustomLighting Distortion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.CustomLighting>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// StructProperty: CustomLighting
    /// </summary>
    public unsafe BmSDK.Engine.Material.CustomSkylightDiffuse CustomLighting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.CustomSkylightDiffuse>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// StructProperty: CustomSkylightDiffuse
    /// </summary>
    public unsafe BmSDK.Engine.Material.AnisotropicDirection CustomSkylightDiffuse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.AnisotropicDirection>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// StructProperty: AnisotropicDirection
    /// </summary>
    public unsafe BmSDK.Engine.Material.SSSColor AnisotropicDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.SSSColor>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// StructProperty: SSSColor
    /// </summary>
    public unsafe BmSDK.Engine.Material.SSSRadius SSSColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.SSSRadius>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// StructProperty: SSSRadius
    /// </summary>
    public unsafe BmSDK.Engine.Material.MetalMask SSSRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.MetalMask>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// StructProperty: MetalMask
    /// </summary>
    public unsafe BmSDK.Engine.Material.BlurDirection MetalMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.BlurDirection>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// StructProperty: BlurDirection
    /// </summary>
    public unsafe BmSDK.Engine.Material.FaceWorksDeepScatterColor BlurDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.FaceWorksDeepScatterColor>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// StructProperty: FaceWorksDeepScatterColor
    /// </summary>
    public unsafe BmSDK.Engine.Material.TwoSidedLightingMask FaceWorksDeepScatterColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.TwoSidedLightingMask>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// StructProperty: TwoSidedLightingMask
    /// </summary>
    public unsafe BmSDK.Engine.Material.TwoSidedLightingColor TwoSidedLightingMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.TwoSidedLightingColor>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// StructProperty: TwoSidedLightingColor
    /// </summary>
    public unsafe BmSDK.Engine.Material.WorldPositionOffset TwoSidedLightingColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.WorldPositionOffset>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// StructProperty: WorldPositionOffset
    /// </summary>
    public unsafe BmSDK.Engine.Material.PostWorldPositionOffset WorldPositionOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.PostWorldPositionOffset>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// StructProperty: PostWorldPositionOffset
    /// </summary>
    public unsafe BmSDK.Engine.Material.WorldDisplacement PostWorldPositionOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.WorldDisplacement>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// StructProperty: WorldDisplacement
    /// </summary>
    public unsafe BmSDK.Engine.Material.TangentDisplacement WorldDisplacement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.TangentDisplacement>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// StructProperty: TangentDisplacement
    /// </summary>
    public unsafe BmSDK.Engine.Material.TessellationMultiplier TangentDisplacement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.TessellationMultiplier>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// StructProperty: TessellationMultiplier
    /// </summary>
    public unsafe BmSDK.Engine.Material.SubsurfaceInscatteringColor TessellationMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.SubsurfaceInscatteringColor>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// StructProperty: SubsurfaceInscatteringColor
    /// </summary>
    public unsafe BmSDK.Engine.Material.SubsurfaceAbsorptionColor SubsurfaceInscatteringColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.SubsurfaceAbsorptionColor>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// StructProperty: SubsurfaceAbsorptionColor
    /// </summary>
    public unsafe BmSDK.Engine.Material.SubsurfaceScatteringRadius SubsurfaceAbsorptionColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.SubsurfaceScatteringRadius>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// StructProperty: SubsurfaceScatteringRadius
    /// </summary>
    public unsafe BmSDK.Engine.Material.Expressions SubsurfaceScatteringRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material.Expressions>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreMissingLODFadeWhenUsedInLODs
    /// </summary>
    public unsafe bool bIgnoreMissingLODFadeWhenUsedInLODs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: EnableSubsurfaceScattering
    /// </summary>
    public unsafe bool EnableSubsurfaceScattering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bEnableMaskedAntialiasing
    /// </summary>
    public unsafe bool bEnableMaskedAntialiasing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: TwoSided
    /// </summary>
    public unsafe bool TwoSided
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: TwoSidedSeparatePass
    /// </summary>
    public unsafe bool TwoSidedSeparatePass
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bThinBackScattering
    /// </summary>
    public unsafe bool bThinBackScattering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bDeferredCoverageTransparency
    /// </summary>
    public unsafe bool bDeferredCoverageTransparency
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bHairForwardLighting
    /// </summary>
    public unsafe bool bHairForwardLighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bExpensiveForwardLighting
    /// </summary>
    public unsafe bool bExpensiveForwardLighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bVertexOffsetBeforeSkinning
    /// </summary>
    public unsafe bool bVertexOffsetBeforeSkinning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bVertexOffsetAfterProjection
    /// </summary>
    public unsafe bool bVertexOffsetAfterProjection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bVolumeLighting
    /// </summary>
    public unsafe bool bVolumeLighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bVolumeLightingPerPixel
    /// </summary>
    public unsafe bool bVolumeLightingPerPixel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: SortWithSceneTextureSampleMaterials
    /// </summary>
    public unsafe bool SortWithSceneTextureSampleMaterials
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bDisableTwoSidedLighting
    /// </summary>
    public unsafe bool bDisableTwoSidedLighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: WorldNormalMap
    /// </summary>
    public unsafe bool WorldNormalMap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bDeriveTangentSpace
    /// </summary>
    public unsafe bool bDeriveTangentSpace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bDeriveNormals
    /// </summary>
    public unsafe bool bDeriveNormals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bParticleMotionBlur
    /// </summary>
    public unsafe bool bParticleMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bRenderAsPointCloud
    /// </summary>
    public unsafe bool bRenderAsPointCloud
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bVisibleAgainstStaticChannel
    /// </summary>
    public unsafe bool bVisibleAgainstStaticChannel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bGenerateFakeNormals
    /// </summary>
    public unsafe bool bGenerateFakeNormals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bDoPointCloudFalloff
    /// </summary>
    public unsafe bool bDoPointCloudFalloff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bDoPointCloudFalloffMin
    /// </summary>
    public unsafe bool bDoPointCloudFalloffMin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bPointCloudTransitionAsAlpha
    /// </summary>
    public unsafe bool bPointCloudTransitionAsAlpha
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bSupportsMapViewPointCloud
    /// </summary>
    public unsafe bool bSupportsMapViewPointCloud
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bUseMatColorInMapViewPointCloud
    /// </summary>
    public unsafe bool bUseMatColorInMapViewPointCloud
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bFadeAgainstOccludedDepth
    /// </summary>
    public unsafe bool bFadeAgainstOccludedDepth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: ReflectionsOnTranslucency
    /// </summary>
    public unsafe bool ReflectionsOnTranslucency
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: XrayVisualsOnTranslucency
    /// </summary>
    public unsafe bool XrayVisualsOnTranslucency
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: DisableDepth
    /// </summary>
    public unsafe bool DisableDepth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: DisableDiffuse
    /// </summary>
    public unsafe bool DisableDiffuse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: DisableEmissive
    /// </summary>
    public unsafe bool DisableEmissive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: DisableMetalness
    /// </summary>
    public unsafe bool DisableMetalness
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: DisableNormals
    /// </summary>
    public unsafe bool DisableNormals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: DisableReflectivity
    /// </summary>
    public unsafe bool DisableReflectivity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: DisableRoughness
    /// </summary>
    public unsafe bool DisableRoughness
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bDisableDepthTest
    /// </summary>
    public unsafe bool bDisableDepthTest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bDisableDepthWrite
    /// </summary>
    public unsafe bool bDisableDepthWrite
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bSceneTextureRenderBehindTranslucency
    /// </summary>
    public unsafe bool bSceneTextureRenderBehindTranslucency
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bExpensiveDrawBehindAllOtherTranslucency
    /// </summary>
    public unsafe bool bExpensiveDrawBehindAllOtherTranslucency
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bAllowFog
    /// </summary>
    public unsafe bool bAllowFog
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bAllowFogPerPixel
    /// </summary>
    public unsafe bool bAllowFogPerPixel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bTranslucencyReceiveDominantShadowsFromStatic
    /// </summary>
    public unsafe bool bTranslucencyReceiveDominantShadowsFromStatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bTranslucencyInheritDominantShadowsFromOpaque
    /// </summary>
    public unsafe bool bTranslucencyInheritDominantShadowsFromOpaque
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bAllowTranslucencyDoF
    /// </summary>
    public unsafe bool bAllowTranslucencyDoF
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUseOneLayerDistortion
    /// </summary>
    public unsafe bool bUseOneLayerDistortion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUseLitTranslucencyDepthPass
    /// </summary>
    public unsafe bool bUseLitTranslucencyDepthPass
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUseLitTranslucencyPostRenderDepthPass
    /// </summary>
    public unsafe bool bUseLitTranslucencyPostRenderDepthPass
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bCastLitTranslucencyShadowAsMasked
    /// </summary>
    public unsafe bool bCastLitTranslucencyShadowAsMasked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bLockUsageFlags
    /// </summary>
    public unsafe bool bLockUsageFlags
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedAsLightFunction
    /// </summary>
    public unsafe bool bUsedAsLightFunction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithFogVolumes
    /// </summary>
    public unsafe bool bUsedWithFogVolumes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithPerVertexRockAtmosFog
    /// </summary>
    public unsafe bool bUsedWithPerVertexRockAtmosFog
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithLightEnvironment
    /// </summary>
    public unsafe bool bUsedWithLightEnvironment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithStaticMesh
    /// </summary>
    public unsafe bool bUsedWithStaticMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedAsSpecialEngineMaterial
    /// </summary>
    public unsafe bool bUsedAsSpecialEngineMaterial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithSkeletalMesh
    /// </summary>
    public unsafe bool bUsedWithSkeletalMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithTerrain
    /// </summary>
    public unsafe bool bUsedWithTerrain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithLandscape
    /// </summary>
    public unsafe bool bUsedWithLandscape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithFracturedMeshes
    /// </summary>
    public unsafe bool bUsedWithFracturedMeshes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithParticleSystem
    /// </summary>
    public unsafe bool bUsedWithParticleSystem
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithParticleSprites
    /// </summary>
    public unsafe bool bUsedWithParticleSprites
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithBeamTrails
    /// </summary>
    public unsafe bool bUsedWithBeamTrails
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithParticleSubUV
    /// </summary>
    public unsafe bool bUsedWithParticleSubUV
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithParticleGPU
    /// </summary>
    public unsafe bool bUsedWithParticleGPU
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithSpeedTree
    /// </summary>
    public unsafe bool bUsedWithSpeedTree
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithStaticLighting
    /// </summary>
    public unsafe bool bUsedWithStaticLighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithLensFlare
    /// </summary>
    public unsafe bool bUsedWithLensFlare
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithGammaCorrection
    /// </summary>
    public unsafe bool bUsedWithGammaCorrection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithHitMasks
    /// </summary>
    public unsafe bool bUsedWithHitMasks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithInstancedMeshParticles
    /// </summary>
    public unsafe bool bUsedWithInstancedMeshParticles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithFluidSurfaces
    /// </summary>
    public unsafe bool bUsedWithFluidSurfaces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithRockDecals
    /// </summary>
    public unsafe bool bUsedWithRockDecals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithMaterialEffect
    /// </summary>
    public unsafe bool bUsedWithMaterialEffect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithMorphTargets
    /// </summary>
    public unsafe bool bUsedWithMorphTargets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithRadialBlur
    /// </summary>
    public unsafe bool bUsedWithRadialBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithInstancedMeshes
    /// </summary>
    public unsafe bool bUsedWithInstancedMeshes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithSplineMeshes
    /// </summary>
    public unsafe bool bUsedWithSplineMeshes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithAPEXMeshes
    /// </summary>
    public unsafe bool bUsedWithAPEXMeshes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithAPEXClothing
    /// </summary>
    public unsafe bool bUsedWithAPEXClothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithApexSprites
    /// </summary>
    public unsafe bool bUsedWithApexSprites
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithOpacityShadows
    /// </summary>
    public unsafe bool bUsedWithOpacityShadows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithScreenDoorFade
    /// </summary>
    public unsafe bool bUsedWithScreenDoorFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bEnableCrackFreeDisplacement
    /// </summary>
    public unsafe bool bEnableCrackFreeDisplacement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUseImageBasedReflections
    /// </summary>
    public unsafe bool bUseImageBasedReflections
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: Wireframe
    /// </summary>
    public unsafe bool Wireframe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bPerPixelCameraVector
    /// </summary>
    public unsafe bool bPerPixelCameraVector
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bAllowLightmapSpecular
    /// </summary>
    public unsafe bool bAllowLightmapSpecular
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: CanStripNormalsAndTangents
    /// </summary>
    public unsafe bool CanStripNormalsAndTangents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: CanStripVertexColours
    /// </summary>
    public unsafe bool CanStripVertexColours
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: UseFastLODRendering
    /// </summary>
    public unsafe bool UseFastLODRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: DisallowGlobalSamplerStates
    /// </summary>
    public unsafe bool DisallowGlobalSamplerStates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bIsFallbackMaterial
    /// </summary>
    public unsafe bool bIsFallbackMaterial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsesDistortion
    /// </summary>
    public unsafe bool bUsesDistortion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bIsMasked
    /// </summary>
    public unsafe bool bIsMasked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsesSSS
    /// </summary>
    public unsafe bool bUsesSSS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: bUseBlurDirection
    /// </summary>
    public unsafe bool bUseBlurDirection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: bIsPreviewMaterial
    /// </summary>
    public unsafe bool bIsPreviewMaterial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// FloatProperty: PointCloudOcclusion
    /// </summary>
    public unsafe float PointCloudOcclusion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }

    /// <summary>
    /// FloatProperty: PointCloudScale
    /// </summary>
    public unsafe float PointCloudScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// StructProperty: SSSColourDefault
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SSSColourDefault
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// FloatProperty: ImageReflectionNormalDampening
    /// </summary>
    public unsafe float ImageReflectionNormalDampening
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// FloatProperty: DeepScatterIntensity
    /// </summary>
    public unsafe float DeepScatterIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// FloatProperty: DeepScatterRadius
    /// </summary>
    public unsafe float DeepScatterRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }

    /// <summary>
    /// FloatProperty: ThicknessNormalOffset
    /// </summary>
    public unsafe float ThicknessNormalOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// FloatProperty: ThicknessBlurRadius
    /// </summary>
    public unsafe float ThicknessBlurRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// FloatProperty: ThicknessDepthSharpness
    /// </summary>
    public unsafe float ThicknessDepthSharpness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// StructProperty: MaterialResources
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MaterialResources_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }
    /// <summary>
    /// StructProperty: MaterialResources
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MaterialResources_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }

    /// <summary>
    /// StructProperty: DefaultMaterialInstances
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DefaultMaterialInstances_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }
    /// <summary>
    /// StructProperty: DefaultMaterialInstances
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DefaultMaterialInstances_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }
    /// <summary>
    /// StructProperty: DefaultMaterialInstances
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DefaultMaterialInstances_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// IntProperty: EditorX
    /// </summary>
    public unsafe int EditorX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// IntProperty: EditorY
    /// </summary>
    public unsafe int EditorY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// IntProperty: EditorPitch
    /// </summary>
    public unsafe int EditorPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// IntProperty: EditorYaw
    /// </summary>
    public unsafe int EditorYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// ArrayProperty: Expressions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> Expressions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// ArrayProperty: EditorComments
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> EditorComments
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// ArrayProperty: MaterialFunctionInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> MaterialFunctionInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// MapProperty: EditorParameters
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ EditorParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// ArrayProperty: ReferencedTextures
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> ReferencedTextures
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ArrayProperty: ReferencedTextureGuids
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ReferencedTextureGuids
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// StrProperty: SourceTimestamp
    /// </summary>
    public unsafe BmSDK.FString SourceTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// StrProperty: SourceAuthor
    /// </summary>
    public unsafe BmSDK.FString SourceAuthor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// Struct: FVector2MaterialInput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FVector2MaterialInput
    {
        /// <summary>
        /// BoolProperty: UseConstant
        /// </summary>
        public unsafe bool UseConstant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: ConstantX
        /// </summary>
        public unsafe float ConstantX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: ConstantY
        /// </summary>
        public unsafe float ConstantY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Struct: FVectorMaterialInput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FVectorMaterialInput
    {
        /// <summary>
        /// BoolProperty: UseConstant
        /// </summary>
        public unsafe bool UseConstant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// StructProperty: Constant
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Constant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FScalarMaterialInput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FScalarMaterialInput
    {
        /// <summary>
        /// BoolProperty: UseConstant
        /// </summary>
        public unsafe bool UseConstant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: Constant
        /// </summary>
        public unsafe float Constant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FColorMaterialInput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FColorMaterialInput
    {
        /// <summary>
        /// BoolProperty: UseConstant
        /// </summary>
        public unsafe bool UseConstant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// StructProperty: Constant
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Constant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FMaterialInput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FMaterialInput
    {
        /// <summary>
        /// ObjectProperty: Expression
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Expression
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: OutputIndex
        /// </summary>
        public unsafe int OutputIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: InputName
        /// </summary>
        public unsafe BmSDK.FString InputName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Mask
        /// </summary>
        public unsafe int Mask
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: MaskR
        /// </summary>
        public unsafe int MaskR
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: MaskG
        /// </summary>
        public unsafe int MaskG
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: MaskB
        /// </summary>
        public unsafe int MaskB
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: MaskA
        /// </summary>
        public unsafe int MaskA
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// IntProperty: GCC64_Padding
        /// </summary>
        public unsafe int GCC64_Padding
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }
}
