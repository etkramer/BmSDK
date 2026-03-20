#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkeletalMesh<br/>
/// (flags = 0)
/// </summary>
public partial class SkeletalMesh : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkeletalMesh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkeletalMesh() { }

    /// <summary>
    /// Constructs a new SkeletalMesh
    /// </summary>
    public SkeletalMesh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkeletalMesh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkeletalMesh(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Bounds
    /// </summary>
    public unsafe BmSDK.GameObject.FBoxSphereBounds Bounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoxSphereBounds>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: ConservativeBounds
    /// </summary>
    public unsafe float ConservativeBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ArrayProperty: PerBoneBounds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FBoneBounds> PerBoneBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FBoneBounds>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: Materials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> Materials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: ClothingAssets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ApexClothingAsset> ClothingAssets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ApexClothingAsset>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: ClothingTeleportRefBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ClothingTeleportRefBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: ClothingLodMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FApexClothingAssetInfo> ClothingLodMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FApexClothingAssetInfo>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: Origin
    /// </summary>
    public unsafe System.Numerics.Vector3 Origin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StructProperty: RotOrigin
    /// </summary>
    public unsafe BmSDK.Rotator RotOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// ArrayProperty: RefSkeleton
    /// </summary>
    public unsafe BmSDK.TArray<int> RefSkeleton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// IntProperty: SkeletalDepth
    /// </summary>
    public unsafe int SkeletalDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// MapProperty: NameIndexMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ NameIndexMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: LODModels
    /// </summary>
    public unsafe BmSDK.GameObject.FIndirectArray_Mirror LODModels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FIndirectArray_Mirror>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: SourceData
    /// </summary>
    public unsafe System.IntPtr SourceData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// ArrayProperty: RefBasesInvMatrix
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FBoneAtom> RefBasesInvMatrix
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FBoneAtom>>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXBoneToRefBone
    /// </summary>
    public unsafe BmSDK.TArray<int> FaceFXBoneToRefBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ArrayProperty: SkelMirrorTable
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FBoneMirrorInfo> SkelMirrorTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FBoneMirrorInfo>>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ByteProperty: SkelMirrorAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis SkelMirrorAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ByteProperty: SkelMirrorFlipAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis SkelMirrorFlipAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 385); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 385); }
    }

    /// <summary>
    /// ArrayProperty: CharacterMirrorBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FCharacterMirrorBone> CharacterMirrorBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FCharacterMirrorBone>>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ArrayProperty: CharacterUpperBodyBoneIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> CharacterUpperBodyBoneIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StructProperty: NormalizedBoneMasses
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.FNormalizedBoneMasses NormalizedBoneMasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.FNormalizedBoneMasses>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// IntProperty: InvestigateLocationBoneIndex
    /// </summary>
    public unsafe int InvestigateLocationBoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ArrayProperty: Sockets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshSocket> Sockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshSocket>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: BoneBreakNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BoneBreakNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ArrayProperty: BoneBreakOptions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.BoneBreakOption> BoneBreakOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.BoneBreakOption>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ArrayProperty: LODInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSkeletalMeshLODInfo> LODInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSkeletalMeshLODInfo>>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ArrayProperty: OptimizationSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSkeletalMeshOptimizationSettings> OptimizationSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSkeletalMeshOptimizationSettings>>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ArrayProperty: PerPolyCollisionBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PerPolyCollisionBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: AddToParentPerPolyCollisionBone
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> AddToParentPerPolyCollisionBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ArrayProperty: PerPolyBoneKDOPs
    /// </summary>
    public unsafe BmSDK.TArray<int> PerPolyBoneKDOPs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bPerPolyUseSoftWeighting
    /// </summary>
    public unsafe bool bPerPolyUseSoftWeighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bUseSimpleLineCollision
    /// </summary>
    public unsafe bool bUseSimpleLineCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bUseSimpleBoxCollision
    /// </summary>
    public unsafe bool bUseSimpleBoxCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bForceCPUSkinning
    /// </summary>
    public unsafe bool bForceCPUSkinning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithParticleVertexSpawn
    /// </summary>
    public unsafe bool bUsedWithParticleVertexSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bUseFullPrecisionUVs
    /// </summary>
    public unsafe bool bUseFullPrecisionUVs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bStripVertexColours
    /// </summary>
    public unsafe bool bStripVertexColours
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenSimplified
    /// </summary>
    public unsafe bool bHasBeenSimplified
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnablePerBoneBounds
    /// </summary>
    public unsafe bool EnablePerBoneBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableFaceFX
    /// </summary>
    public unsafe bool EnableFaceFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableFaceFXBoneScaling
    /// </summary>
    public unsafe bool EnableFaceFXBoneScaling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: RequiresMaxSolvers
    /// </summary>
    public unsafe bool RequiresMaxSolvers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableTwistBoneFixers
    /// </summary>
    public unsafe bool EnableTwistBoneFixers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableKneeElbowFixers
    /// </summary>
    public unsafe bool EnableKneeElbowFixers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableNeckTwistFixer
    /// </summary>
    public unsafe bool EnableNeckTwistFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableCollarTwistFixer
    /// </summary>
    public unsafe bool EnableCollarTwistFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableStretches
    /// </summary>
    public unsafe bool EnableStretches
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableSkelControls
    /// </summary>
    public unsafe bool EnableSkelControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: TEMP_EDITOR_HACK_ForceEulerFeedConstraints
    /// </summary>
    public unsafe bool TEMP_EDITOR_HACK_ForceEulerFeedConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: TEMP_EDITOR_HACK_ForceQuatFeedConstraints
    /// </summary>
    public unsafe bool TEMP_EDITOR_HACK_ForceQuatFeedConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: CollarTwistWeight
    /// </summary>
    public unsafe float CollarTwistWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: FaceFXAsset
    /// </summary>
    public unsafe BmSDK.Engine.FaceFXAsset FaceFXAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FaceFXAsset>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ObjectProperty: DrivenMaterialParameterConfig
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshDrivenMaterialParameterConfig DrivenMaterialParameterConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshDrivenMaterialParameterConfig>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ObjectProperty: PreviewBoundsPhysicsAsset
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset PreviewBoundsPhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ByteProperty: PreviewBoundsType
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.ESkeletalMeshComponentBoundsType PreviewBoundsType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.ESkeletalMeshComponentBoundsType>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ArrayProperty: PreviewMorphSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MorphTargetSet> PreviewMorphSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MorphTargetSet>>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// IntProperty: LODBiasPC
    /// </summary>
    public unsafe int LODBiasPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// IntProperty: LODBiasPS3
    /// </summary>
    public unsafe int LODBiasPS3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// IntProperty: LODBiasXbox360
    /// </summary>
    public unsafe int LODBiasXbox360
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// NameProperty: CachedPathName
    /// </summary>
    public unsafe BmSDK.FName CachedPathName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// StrProperty: SourceFilePath
    /// </summary>
    public unsafe BmSDK.FString SourceFilePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// StrProperty: SourceFileTimestamp
    /// </summary>
    public unsafe BmSDK.FString SourceFileTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ArrayProperty: ClothMesh
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ClothMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshScale
    /// </summary>
    public unsafe BmSDK.TArray<float> ClothMeshScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ArrayProperty: ClothToGraphicsVertMap
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothToGraphicsVertMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ArrayProperty: ClothMovementScale
    /// </summary>
    public unsafe BmSDK.TArray<float> ClothMovementScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ByteProperty: ClothMovementScaleGenMode
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh.ClothMovementScaleGen ClothMovementScaleGenMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh.ClothMovementScaleGen>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: ClothToAnimMeshMaxDist
    /// </summary>
    public unsafe float ClothToAnimMeshMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bLimitClothToAnimMesh
    /// </summary>
    public unsafe bool bLimitClothToAnimMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// ArrayProperty: ClothWeldingMap
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothWeldingMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// IntProperty: ClothWeldingDomain
    /// </summary>
    public unsafe int ClothWeldingDomain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ArrayProperty: ClothWeldedIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothWeldedIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bForceNoWelding
    /// </summary>
    public unsafe bool bForceNoWelding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// IntProperty: NumFreeClothVerts
    /// </summary>
    public unsafe int NumFreeClothVerts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ArrayProperty: ClothIndexBuffer
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothIndexBuffer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ArrayProperty: ClothBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ClothBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// IntProperty: ClothHierarchyLevels
    /// </summary>
    public unsafe int ClothHierarchyLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothBendConstraints
    /// </summary>
    public unsafe bool bEnableClothBendConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 844); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothDamping
    /// </summary>
    public unsafe bool bEnableClothDamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 844); }
    }

    /// <summary>
    /// BoolProperty: bUseClothCOMDamping
    /// </summary>
    public unsafe bool bUseClothCOMDamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 844); }
    }

    /// <summary>
    /// FloatProperty: ClothStretchStiffness
    /// </summary>
    public unsafe float ClothStretchStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// FloatProperty: ClothBendStiffness
    /// </summary>
    public unsafe float ClothBendStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: ClothDensity
    /// </summary>
    public unsafe float ClothDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: ClothThickness
    /// </summary>
    public unsafe float ClothThickness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// FloatProperty: ClothDamping
    /// </summary>
    public unsafe float ClothDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// IntProperty: ClothIterations
    /// </summary>
    public unsafe int ClothIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// IntProperty: ClothHierarchicalIterations
    /// </summary>
    public unsafe int ClothHierarchicalIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: ClothFriction
    /// </summary>
    public unsafe float ClothFriction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: ClothRelativeGridSpacing
    /// </summary>
    public unsafe float ClothRelativeGridSpacing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: ClothPressure
    /// </summary>
    public unsafe float ClothPressure
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// FloatProperty: ClothCollisionResponseCoefficient
    /// </summary>
    public unsafe float ClothCollisionResponseCoefficient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// FloatProperty: ClothAttachmentResponseCoefficient
    /// </summary>
    public unsafe float ClothAttachmentResponseCoefficient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// FloatProperty: ClothAttachmentTearFactor
    /// </summary>
    public unsafe float ClothAttachmentTearFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// FloatProperty: ClothSleepLinearVelocity
    /// </summary>
    public unsafe float ClothSleepLinearVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// FloatProperty: HardStretchLimitFactor
    /// </summary>
    public unsafe float HardStretchLimitFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: bHardStretchLimit
    /// </summary>
    public unsafe bool bHardStretchLimit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothOrthoBendConstraints
    /// </summary>
    public unsafe bool bEnableClothOrthoBendConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothSelfCollision
    /// </summary>
    public unsafe bool bEnableClothSelfCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothPressure
    /// </summary>
    public unsafe bool bEnableClothPressure
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothTwoWayCollision
    /// </summary>
    public unsafe bool bEnableClothTwoWayCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// ArrayProperty: ClothSpecialBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FClothSpecialBoneInfo> ClothSpecialBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FClothSpecialBoneInfo>>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothLineChecks
    /// </summary>
    public unsafe bool bEnableClothLineChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bClothMetal
    /// </summary>
    public unsafe bool bClothMetal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// FloatProperty: ClothMetalImpulseThreshold
    /// </summary>
    public unsafe float ClothMetalImpulseThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: ClothMetalPenetrationDepth
    /// </summary>
    public unsafe float ClothMetalPenetrationDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: ClothMetalMaxDeformationDistance
    /// </summary>
    public unsafe float ClothMetalMaxDeformationDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothTearing
    /// </summary>
    public unsafe bool bEnableClothTearing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// FloatProperty: ClothTearFactor
    /// </summary>
    public unsafe float ClothTearFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// IntProperty: ClothTearReserve
    /// </summary>
    public unsafe int ClothTearReserve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bEnableValidBounds
    /// </summary>
    public unsafe bool bEnableValidBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 956); }
    }

    /// <summary>
    /// StructProperty: ValidBoundsMin
    /// </summary>
    public unsafe System.Numerics.Vector3 ValidBoundsMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// StructProperty: ValidBoundsMax
    /// </summary>
    public unsafe System.Numerics.Vector3 ValidBoundsMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// StructProperty: ClothTornTriMap
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror ClothTornTriMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StrProperty: SourceAuthor
    /// </summary>
    public unsafe BmSDK.FString SourceAuthor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// StrProperty: MaxFilePath
    /// </summary>
    public unsafe BmSDK.FString MaxFilePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ArrayProperty: ExtraSocketMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh> ExtraSocketMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh>>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodySurfaceToGraphicsVertMap
    /// </summary>
    public unsafe BmSDK.TArray<int> SoftBodySurfaceToGraphicsVertMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodySurfaceIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> SoftBodySurfaceIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodyTetraVertsUnscaled
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> SoftBodyTetraVertsUnscaled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodyTetraIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> SoftBodyTetraIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodyTetraLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSoftBodyTetraLink> SoftBodyTetraLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSoftBodyTetraLink>>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ArrayProperty: CachedSoftBodyMeshes
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> CachedSoftBodyMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ArrayProperty: CachedSoftBodyMeshScales
    /// </summary>
    public unsafe BmSDK.TArray<float> CachedSoftBodyMeshScales
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodyBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> SoftBodyBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodySpecialBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSoftBodySpecialBoneInfo> SoftBodySpecialBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSoftBodySpecialBoneInfo>>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyVolumeStiffness
    /// </summary>
    public unsafe float SoftBodyVolumeStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyStretchingStiffness
    /// </summary>
    public unsafe float SoftBodyStretchingStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyDensity
    /// </summary>
    public unsafe float SoftBodyDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyParticleRadius
    /// </summary>
    public unsafe float SoftBodyParticleRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyDamping
    /// </summary>
    public unsafe float SoftBodyDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// IntProperty: SoftBodySolverIterations
    /// </summary>
    public unsafe int SoftBodySolverIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyFriction
    /// </summary>
    public unsafe float SoftBodyFriction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyRelativeGridSpacing
    /// </summary>
    public unsafe float SoftBodyRelativeGridSpacing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// FloatProperty: SoftBodySleepLinearVelocity
    /// </summary>
    public unsafe float SoftBodySleepLinearVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// BoolProperty: bEnableSoftBodySelfCollision
    /// </summary>
    public unsafe bool bEnableSoftBodySelfCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyAttachmentResponse
    /// </summary>
    public unsafe float SoftBodyAttachmentResponse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyCollisionResponse
    /// </summary>
    public unsafe float SoftBodyCollisionResponse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyDetailLevel
    /// </summary>
    public unsafe float SoftBodyDetailLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// IntProperty: SoftBodySubdivisionLevel
    /// </summary>
    public unsafe int SoftBodySubdivisionLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// BoolProperty: bSoftBodyIsoSurface
    /// </summary>
    public unsafe bool bSoftBodyIsoSurface
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1304); }
    }

    /// <summary>
    /// BoolProperty: bEnableSoftBodyDamping
    /// </summary>
    public unsafe bool bEnableSoftBodyDamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1304); }
    }

    /// <summary>
    /// BoolProperty: bUseSoftBodyCOMDamping
    /// </summary>
    public unsafe bool bUseSoftBodyCOMDamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1304); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyAttachmentThreshold
    /// </summary>
    public unsafe float SoftBodyAttachmentThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// BoolProperty: bEnableSoftBodyTwoWayCollision
    /// </summary>
    public unsafe bool bEnableSoftBodyTwoWayCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1312) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1312); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1312); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyAttachmentTearFactor
    /// </summary>
    public unsafe float SoftBodyAttachmentTearFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// BoolProperty: bEnableSoftBodyLineChecks
    /// </summary>
    public unsafe bool bEnableSoftBodyLineChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// BoolProperty: bHasVertexColors
    /// </summary>
    public unsafe bool bHasVertexColors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// ArrayProperty: GraphicsIndexIsCloth
    /// </summary>
    public unsafe BmSDK.TArray<bool> GraphicsIndexIsCloth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ArrayProperty: CachedStreamingTextureFactors
    /// </summary>
    public unsafe BmSDK.TArray<float> CachedStreamingTextureFactors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// FloatProperty: StreamingDistanceMultiplier
    /// </summary>
    public unsafe float StreamingDistanceMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// IntProperty: ReleaseResourcesFence
    /// </summary>
    public unsafe int ReleaseResourcesFence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// StructProperty: SkelMeshRUID
    /// </summary>
    public unsafe ulong SkelMeshRUID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ArrayProperty: Stretches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FStretchDescription> Stretches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FStretchDescription>>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ArrayProperty: SkelControls
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimTree> SkelControls
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimTree>>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// BoolProperty: bUseClothingAssetMaterial
    /// </summary>
    public unsafe bool bUseClothingAssetMaterial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1404) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1404); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1404); }
    }

    /// <summary>
    /// BoolProperty: bUseClothCollisionChannels
    /// </summary>
    public unsafe bool bUseClothCollisionChannels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1404) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1404); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1404); }
    }

    /// <summary>
    /// FloatProperty: DisplayFactorForFullySkinnedCloth
    /// </summary>
    public unsafe float DisplayFactorForFullySkinnedCloth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// FloatProperty: DisplayFactorForFullyPhysicalCloth
    /// </summary>
    public unsafe float DisplayFactorForFullyPhysicalCloth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// FloatProperty: ClothWindStrengthScale
    /// </summary>
    public unsafe float ClothWindStrengthScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// FloatProperty: ClothWindAdaptTime
    /// </summary>
    public unsafe float ClothWindAdaptTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// IntProperty: IndexBufferOptimisationVersion
    /// </summary>
    public unsafe int IndexBufferOptimisationVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }
}
