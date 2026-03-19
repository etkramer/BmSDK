#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: StaticMesh<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class StaticMesh : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.StaticMesh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal StaticMesh() { }

    /// <summary>
    /// Constructs a new StaticMesh
    /// </summary>
    public StaticMesh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, StaticMesh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected StaticMesh(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: FlexAsset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FlexAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// StrProperty: SourceAuthor
    /// </summary>
    public unsafe BmSDK.FString SourceAuthor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// StrProperty: SourceFileTimestamp
    /// </summary>
    public unsafe BmSDK.FString SourceFileTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// StrProperty: SourceFilePath
    /// </summary>
    public unsafe BmSDK.FString SourceFilePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ObjectProperty: FoliageDefaultSettings
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FoliageDefaultSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: IndexBufferOptimisationVersion
    /// </summary>
    public unsafe int IndexBufferOptimisationVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// BoolProperty: bOneConvexPerUCXObject
    /// </summary>
    public unsafe bool bOneConvexPerUCXObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: CollisionOverride
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CollisionOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ObjectProperty: AutoLODOverride
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AutoLODOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: CachedLOD1TextureUsageEmissive
    /// </summary>
    public unsafe float CachedLOD1TextureUsageEmissive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// FloatProperty: CachedLOD1TextureUsageOpaque
    /// </summary>
    public unsafe float CachedLOD1TextureUsageOpaque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// FloatProperty: CachedLOD1TextureUsageRegular
    /// </summary>
    public unsafe float CachedLOD1TextureUsageRegular
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// BoolProperty: StreamingTextureUseUVXOnMaterialX
    /// </summary>
    public unsafe bool StreamingTextureUseUVXOnMaterialX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: StreamingTextureDisregardLargeUVs
    /// </summary>
    public unsafe bool StreamingTextureDisregardLargeUVs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// IntProperty: UVChannelsToStrip
    /// </summary>
    public unsafe int UVChannelsToStrip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// BoolProperty: bUmbraUseAsOccluder
    /// </summary>
    public unsafe bool bUmbraUseAsOccluder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: AutoCollisionMaxDeviation
    /// </summary>
    public unsafe float AutoCollisionMaxDeviation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: StreamingDistanceMultiplier
    /// </summary>
    public unsafe float StreamingDistanceMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: AutoLODUseFlatQuad
    /// </summary>
    public unsafe bool AutoLODUseFlatQuad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 472); }
    }

    /// <summary>
    /// BoolProperty: AutoLODMasked
    /// </summary>
    public unsafe bool AutoLODMasked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: AutoLODFixMoire
    /// </summary>
    public unsafe bool AutoLODFixMoire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 464) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 464); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 464); }
    }

    /// <summary>
    /// BoolProperty: AutoLODImprovedQuality
    /// </summary>
    public unsafe bool AutoLODImprovedQuality
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 460); }
    }

    /// <summary>
    /// BoolProperty: AutoLODOverrideBeforeSimplification
    /// </summary>
    public unsafe bool AutoLODOverrideBeforeSimplification
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 456); }
    }

    /// <summary>
    /// BoolProperty: HideFromLodGeneration
    /// </summary>
    public unsafe bool HideFromLodGeneration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: IsAutogeneratedLOD1Mesh
    /// </summary>
    public unsafe bool IsAutogeneratedLOD1Mesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: NeverCompressPositions
    /// </summary>
    public unsafe bool NeverCompressPositions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: AutoCompressPositions
    /// </summary>
    public unsafe bool AutoCompressPositions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: CanCompressPositions
    /// </summary>
    public unsafe bool CanCompressPositions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: CanDeriveTangents
    /// </summary>
    public unsafe bool CanDeriveTangents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 404); }
    }

    /// <summary>
    /// BoolProperty: CanStripNormalsAndTangents
    /// </summary>
    public unsafe bool CanStripNormalsAndTangents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: CanStripVertexColours
    /// </summary>
    public unsafe bool CanStripVertexColours
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 396); }
    }

    /// <summary>
    /// BoolProperty: BakeIntoBackgroundForAutoLOD
    /// </summary>
    public unsafe bool BakeIntoBackgroundForAutoLOD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: bAlsoUsedAsDestructibleStreetFurniture
    /// </summary>
    public unsafe bool bAlsoUsedAsDestructibleStreetFurniture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 448); }
    }

    /// <summary>
    /// BoolProperty: bAlsoUsedAsDestructible
    /// </summary>
    public unsafe bool bAlsoUsedAsDestructible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 436); }
    }

    /// <summary>
    /// BoolProperty: bUseMaximumStreamingTexelRatio
    /// </summary>
    public unsafe bool bUseMaximumStreamingTexelRatio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: UseFullPrecisionUVs
    /// </summary>
    public unsafe bool UseFullPrecisionUVs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 392); }
    }

    /// <summary>
    /// BoolProperty: bInvalidGelTarget
    /// </summary>
    public unsafe bool bInvalidGelTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreAudioCollision
    /// </summary>
    public unsafe bool bIgnoreAudioCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }

    /// <summary>
    /// BoolProperty: bAudioOnlyCollision
    /// </summary>
    public unsafe bool bAudioOnlyCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: bUseComplexCollisionForGadgets
    /// </summary>
    public unsafe bool bUseComplexCollisionForGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileBarrier
    /// </summary>
    public unsafe bool bBatmobileBarrier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// BoolProperty: UsedWithSplineMesh
    /// </summary>
    public unsafe bool UsedWithSplineMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: UsedWithParticleVertexSpawn
    /// </summary>
    public unsafe bool UsedWithParticleVertexSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 364); }
    }

    /// <summary>
    /// BoolProperty: ForceStripComplexCollision
    /// </summary>
    public unsafe bool ForceStripComplexCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: UseSimpleCollisionAlways
    /// </summary>
    public unsafe bool UseSimpleCollisionAlways
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }
    }

    /// <summary>
    /// ObjectProperty: LedgeSetup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LedgeSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// ObjectProperty: BodySetup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BodySetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ArrayProperty: MaterialOverrides
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT MaterialOverrides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ArrayProperty: Sockets
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Sockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: LightMapCoordinateIndex
    /// </summary>
    public unsafe int LightMapCoordinateIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// IntProperty: LightMapResolution
    /// </summary>
    public unsafe int LightMapResolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ArrayProperty: LODInfo
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT LODInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }
}
