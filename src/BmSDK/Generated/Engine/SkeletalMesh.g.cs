#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkeletalMesh<br/>
/// (size = 0)
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Bounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
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
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT PerBoneBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: Materials
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Materials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: ClothingAssets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>>>>>>> ClothingAssets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>>>>>>>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: ClothingTeleportRefBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>>>>>> ClothingTeleportRefBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>>>>>>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: ClothingLodMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>>>>> ClothingLodMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>>>>>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: Origin
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Origin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StructProperty: RotOrigin
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RotOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// ArrayProperty: RefSkeleton
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT RefSkeleton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 220); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LODModels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: SourceData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SourceData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// ArrayProperty: RefBasesInvMatrix
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT RefBasesInvMatrix
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXBoneToRefBone
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>>>> FaceFXBoneToRefBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>>>>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ArrayProperty: SkelMirrorTable
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>>> SkelMirrorTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>>>>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ByteProperty: SkelMirrorAxis
    /// </summary>
    public unsafe byte SkelMirrorAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ByteProperty: SkelMirrorFlipAxis
    /// </summary>
    public unsafe byte SkelMirrorFlipAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 385); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 385); }
    }

    /// <summary>
    /// ArrayProperty: CharacterMirrorBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>> CharacterMirrorBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>>>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ArrayProperty: CharacterUpperBodyBoneIndices
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets> CharacterUpperBodyBoneIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.Sockets>>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StructProperty: NormalizedBoneMasses
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh.Sockets NormalizedBoneMasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh.Sockets>(Ptr + 420); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> Sockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: BoneBreakNames
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT BoneBreakNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ArrayProperty: BoneBreakOptions
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT BoneBreakOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ArrayProperty: LODInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> LODInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ArrayProperty: OptimizationSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> OptimizationSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ArrayProperty: PerPolyCollisionBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> PerPolyCollisionBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: AddToParentPerPolyCollisionBone
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> AddToParentPerPolyCollisionBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ArrayProperty: PerPolyBoneKDOPs
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT PerPolyBoneKDOPs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bPerPolyUseSoftWeighting
    /// </summary>
    public unsafe bool bPerPolyUseSoftWeighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bUseSimpleLineCollision
    /// </summary>
    public unsafe bool bUseSimpleLineCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bUseSimpleBoxCollision
    /// </summary>
    public unsafe bool bUseSimpleBoxCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bForceCPUSkinning
    /// </summary>
    public unsafe bool bForceCPUSkinning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithParticleVertexSpawn
    /// </summary>
    public unsafe bool bUsedWithParticleVertexSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bUseFullPrecisionUVs
    /// </summary>
    public unsafe bool bUseFullPrecisionUVs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bStripVertexColours
    /// </summary>
    public unsafe bool bStripVertexColours
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenSimplified
    /// </summary>
    public unsafe bool bHasBeenSimplified
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnablePerBoneBounds
    /// </summary>
    public unsafe bool EnablePerBoneBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableFaceFX
    /// </summary>
    public unsafe bool EnableFaceFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableFaceFXBoneScaling
    /// </summary>
    public unsafe bool EnableFaceFXBoneScaling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: RequiresMaxSolvers
    /// </summary>
    public unsafe bool RequiresMaxSolvers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableTwistBoneFixers
    /// </summary>
    public unsafe bool EnableTwistBoneFixers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableKneeElbowFixers
    /// </summary>
    public unsafe bool EnableKneeElbowFixers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableNeckTwistFixer
    /// </summary>
    public unsafe bool EnableNeckTwistFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableCollarTwistFixer
    /// </summary>
    public unsafe bool EnableCollarTwistFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableStretches
    /// </summary>
    public unsafe bool EnableStretches
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: EnableSkelControls
    /// </summary>
    public unsafe bool EnableSkelControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: TEMP_EDITOR_HACK_ForceEulerFeedConstraints
    /// </summary>
    public unsafe bool TEMP_EDITOR_HACK_ForceEulerFeedConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: TEMP_EDITOR_HACK_ForceQuatFeedConstraints
    /// </summary>
    public unsafe bool TEMP_EDITOR_HACK_ForceQuatFeedConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 584); }
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
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FaceFXAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ObjectProperty: DrivenMaterialParameterConfig
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DrivenMaterialParameterConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ObjectProperty: PreviewBoundsPhysicsAsset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviewBoundsPhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ByteProperty: PreviewBoundsType
    /// </summary>
    public unsafe byte PreviewBoundsType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ArrayProperty: PreviewMorphSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PreviewMorphSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 620); }
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
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ClothMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshScale
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ClothMeshScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ArrayProperty: ClothToGraphicsVertMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> ClothToGraphicsVertMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ArrayProperty: ClothMovementScale
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> ClothMovementScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ByteProperty: ClothMovementScaleGenMode
    /// </summary>
    public unsafe byte ClothMovementScaleGenMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 752); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// ArrayProperty: ClothWeldingMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> ClothWeldingMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 764); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> ClothWeldedIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bForceNoWelding
    /// </summary>
    public unsafe bool bForceNoWelding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> ClothIndexBuffer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ArrayProperty: ClothBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> ClothBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 824); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 844); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothDamping
    /// </summary>
    public unsafe bool bEnableClothDamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 844); }
    }

    /// <summary>
    /// BoolProperty: bUseClothCOMDamping
    /// </summary>
    public unsafe bool bUseClothCOMDamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 844); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothOrthoBendConstraints
    /// </summary>
    public unsafe bool bEnableClothOrthoBendConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothSelfCollision
    /// </summary>
    public unsafe bool bEnableClothSelfCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothPressure
    /// </summary>
    public unsafe bool bEnableClothPressure
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothTwoWayCollision
    /// </summary>
    public unsafe bool bEnableClothTwoWayCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// ArrayProperty: ClothSpecialBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ClothSpecialBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothLineChecks
    /// </summary>
    public unsafe bool bEnableClothLineChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: bClothMetal
    /// </summary>
    public unsafe bool bClothMetal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 956); }
    }

    /// <summary>
    /// StructProperty: ValidBoundsMin
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ValidBoundsMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// StructProperty: ValidBoundsMax
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ValidBoundsMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// StructProperty: ClothTornTriMap
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ClothTornTriMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 984); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>>> ExtraSocketMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>>>>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodySurfaceToGraphicsVertMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>> SoftBodySurfaceToGraphicsVertMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodySurfaceIndices
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>> SoftBodySurfaceIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodyTetraVertsUnscaled
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>> SoftBodyTetraVertsUnscaled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodyTetraIndices
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>> SoftBodyTetraIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodyTetraLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>> SoftBodyTetraLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ArrayProperty: CachedSoftBodyMeshes
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT CachedSoftBodyMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ArrayProperty: CachedSoftBodyMeshScales
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT CachedSoftBodyMeshScales
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodyBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>> SoftBodyBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodySpecialBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>> SoftBodySpecialBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>(Ptr + 1232); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1304); }
    }

    /// <summary>
    /// BoolProperty: bEnableSoftBodyDamping
    /// </summary>
    public unsafe bool bEnableSoftBodyDamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1304); }
    }

    /// <summary>
    /// BoolProperty: bUseSoftBodyCOMDamping
    /// </summary>
    public unsafe bool bUseSoftBodyCOMDamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1304); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1312) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1312); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1312); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// BoolProperty: bHasVertexColors
    /// </summary>
    public unsafe bool bHasVertexColors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// ArrayProperty: GraphicsIndexIsCloth
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT GraphicsIndexIsCloth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ArrayProperty: CachedStreamingTextureFactors
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT CachedStreamingTextureFactors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1340); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SkelMeshRUID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ArrayProperty: Stretches
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> Stretches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ArrayProperty: SkelControls
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SkelControls
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// BoolProperty: bUseClothingAssetMaterial
    /// </summary>
    public unsafe bool bUseClothingAssetMaterial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1404) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1404); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1404); }
    }

    /// <summary>
    /// BoolProperty: bUseClothCollisionChannels
    /// </summary>
    public unsafe bool bUseClothCollisionChannels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1404) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1404); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1404); }
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
