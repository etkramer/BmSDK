#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexDestructibleAsset<br/>
/// (flags = 0)
/// </summary>
public partial class ApexDestructibleAsset : BmSDK.Engine.ApexAsset, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexDestructibleAsset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexDestructibleAsset() { }

    /// <summary>
    /// Constructs a new ApexDestructibleAsset
    /// </summary>
    public ApexDestructibleAsset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexDestructibleAsset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexDestructibleAsset(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: FractureMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.FractureMaterial> FractureMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.FractureMaterial>>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: InitalDamageParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem InitalDamageParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ObjectProperty: LowSpeedInitalDamageParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LowSpeedInitalDamageParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ObjectProperty: CrumbleParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem CrumbleParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ObjectProperty: DefaultPhysMaterial
    /// </summary>
    public unsafe BmSDK.Engine.PhysicalMaterial DefaultPhysMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ObjectProperty: InitialBreakSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent InitialBreakSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ObjectProperty: InitialBreakSoundWhenFractureWallDamagedByGel
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent InitialBreakSoundWhenFractureWallDamagedByGel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: AssetDamageSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AssetDamageSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ObjectProperty: AssetShardSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AssetShardSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ObjectProperty: StaticMeshReplacement
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh StaticMeshReplacement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: MaxDamageForLowSpeedInitialDamageEffect
    /// </summary>
    public unsafe float MaxDamageForLowSpeedInitialDamageEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// FloatProperty: PercentageOfFracturedChunksForInitialDamage
    /// </summary>
    public unsafe float PercentageOfFracturedChunksForInitialDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// FloatProperty: PercentageOfChunksToCrumble
    /// </summary>
    public unsafe float PercentageOfChunksToCrumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// FloatProperty: FractureEffectScale
    /// </summary>
    public unsafe float FractureEffectScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// FloatProperty: MinSizeChunkToCrumble
    /// </summary>
    public unsafe float MinSizeChunkToCrumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// FloatProperty: MaxSizeChunkToCrumble
    /// </summary>
    public unsafe float MaxSizeChunkToCrumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// FloatProperty: PercentageOfCrumbleEffects
    /// </summary>
    public unsafe float PercentageOfCrumbleEffects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenInitialBreaks
    /// </summary>
    public unsafe float TimeBetweenInitialBreaks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: bEnablePhysicalMaterialSoundFallbacks
    /// </summary>
    public unsafe bool bEnablePhysicalMaterialSoundFallbacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bHasUniqueAssetMaterialNames
    /// </summary>
    public unsafe bool bHasUniqueAssetMaterialNames
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bAlsoUsedAsStaticMesh
    /// </summary>
    public unsafe bool bAlsoUsedAsStaticMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bNeedsCollisionGeomUpdate
    /// </summary>
    public unsafe bool bNeedsCollisionGeomUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bApplyApexMaterialsToStaticMesh
    /// </summary>
    public unsafe bool bApplyApexMaterialsToStaticMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bReplaceDepthZeroCollisionOnPostLoad
    /// </summary>
    public unsafe bool bReplaceDepthZeroCollisionOnPostLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bDeprecatedApexDestructibleAsset
    /// </summary>
    public unsafe bool bDeprecatedApexDestructibleAsset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bInvalidGelTarget
    /// </summary>
    public unsafe bool bInvalidGelTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: IsCooked
    /// </summary>
    public unsafe bool IsCooked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bDynamic
    /// </summary>
    public unsafe bool bDynamic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: BreakLargeChunksOnImpact
    /// </summary>
    public unsafe bool BreakLargeChunksOnImpact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bUseStaticMeshReplacementForNavMeshBounds
    /// </summary>
    public unsafe bool bUseStaticMeshReplacementForNavMeshBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bEnableSelfCollision
    /// </summary>
    public unsafe bool bEnableSelfCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// StructProperty: MDestructibleThumbnailComponent
    /// </summary>
    public unsafe System.IntPtr MDestructibleThumbnailComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// StructProperty: BaseCollisionGeom
    /// </summary>
    public unsafe BmSDK.Engine.KMeshProps.FKAggregateGeom BaseCollisionGeom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KMeshProps.FKAggregateGeom>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// FloatProperty: MinPlayerNavigationGeometryChunkDimension
    /// </summary>
    public unsafe float MinPlayerNavigationGeometryChunkDimension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ArrayProperty: Sockets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.StaticMeshSocket> Sockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.StaticMeshSocket>>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ArrayProperty: CookedStaticVertexBuffers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ApexDestructibleAsset.FCookedBuffer> CookedStaticVertexBuffers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ApexDestructibleAsset.FCookedBuffer>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// StructProperty: CookedBounds
    /// </summary>
    public unsafe System.Numerics.Vector4 CookedBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector4>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// StrProperty: CrumbleEmitterName
    /// </summary>
    public unsafe BmSDK.FString CrumbleEmitterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// StrProperty: DustEmitterName
    /// </summary>
    public unsafe BmSDK.FString DustEmitterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// StructProperty: DestructibleParameters
    /// </summary>
    public unsafe BmSDK.Engine.ApexDestructibleAsset.FNxDestructibleParameters DestructibleParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDestructibleAsset.FNxDestructibleParameters>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// FloatProperty: RemoveChunksBelowHeight
    /// </summary>
    public unsafe float RemoveChunksBelowHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ArrayProperty: CrumbleParameters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ApexDestructibleAsset.FDestructibleCrumbleParameters> CrumbleParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ApexDestructibleAsset.FDestructibleCrumbleParameters>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// NameProperty: JokerHallucinationIdleName
    /// </summary>
    public unsafe BmSDK.FName JokerHallucinationIdleName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ArrayProperty: JokerHallucinationOverlayNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> JokerHallucinationOverlayNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ByteProperty: NavMeshObstacleOverride
    /// </summary>
    public unsafe BmSDK.Engine.ApexDestructibleAsset.ENavMeshObstacleOverride NavMeshObstacleOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDestructibleAsset.ENavMeshObstacleOverride>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// Enum: EImpactDamageOverride
    /// </summary>
    public enum EImpactDamageOverride
    {
        IDO_None = 0,
        IDO_On = 1,
        IDO_Off = 2,
        IDO_MAX = 3,
    }
}
