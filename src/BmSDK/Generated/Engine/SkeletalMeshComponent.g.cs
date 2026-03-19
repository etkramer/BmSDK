#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkeletalMeshComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SkeletalMeshComponent : BmSDK.Engine.MeshComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkeletalMeshComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkeletalMeshComponent() { }

    /// <summary>
    /// Constructs a new SkeletalMeshComponent
    /// </summary>
    public SkeletalMeshComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkeletalMeshComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkeletalMeshComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SkeletalMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ComponentProperty: AttachedToSkelComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AttachedToSkelComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: AnimTreeTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimTreeTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: Animations
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.AnimTickArray Animations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.AnimTickArray>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ArrayProperty: AnimTickArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>>>>>>> AnimTickArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>>>>>>>>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ArrayProperty: AnimAlwaysTickArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>>>>>> AnimAlwaysTickArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>>>>>>>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ArrayProperty: AnimTickRelevancyArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>>>>> AnimTickRelevancyArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>>>>>>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ArrayProperty: AnimTickWeightsArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>>>> AnimTickWeightsArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>>>>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ArrayProperty: SkelControlTickArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>>> SkelControlTickArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>>>>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ArrayProperty: SkelControlInstances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>> SkelControlInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>>>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ArrayProperty: PostFixerUpdateBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>> PostFixerUpdateBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ArrayProperty: AnimNotifies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>> AnimNotifies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: AnimNodePose
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimNodePose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ArrayProperty: TrackedNotifies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance> TrackedNotifies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsAsset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsAssetInstance
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance PhysicsAssetInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.FlapsAssetInstance>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ObjectProperty: FlapsAssetInstance
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.ForceFieldComponents FlapsAssetInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.ForceFieldComponents>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// StructProperty: ApexClothing
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ApexClothing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ArrayProperty: ForceFieldComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>>>>>>> ForceFieldComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>>>>>>>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: ApexClothMaxDistanceStartScale
    /// </summary>
    public unsafe float ApexClothMaxDistanceStartScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: ApexClothMaxDistanceEndScale
    /// </summary>
    public unsafe float ApexClothMaxDistanceEndScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: ApexClothMaxDistanceStartTime
    /// </summary>
    public unsafe float ApexClothMaxDistanceStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: ApexClothMaxDistanceEndTime
    /// </summary>
    public unsafe float ApexClothMaxDistanceEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ByteProperty: ApexClothMaxDistanceScaleMode
    /// </summary>
    public unsafe byte ApexClothMaxDistanceScaleMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// FloatProperty: PhysicsWeight
    /// </summary>
    public unsafe float PhysicsWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// FloatProperty: MaxNearlyStillSpeed
    /// </summary>
    public unsafe float MaxNearlyStillSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ByteProperty: BoundsType
    /// </summary>
    public unsafe byte BoundsType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: FixedBounds
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FixedBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// StructProperty: OriginalBounds
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OriginalBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ArrayProperty: ExtraBounds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>>>>>> ExtraBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>>>>>>>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: ExtraBoundsInstances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>>>>> ExtraBoundsInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>>>>>>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: GlobalAnimRateScale
    /// </summary>
    public unsafe float GlobalAnimRateScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: StreamingDistanceMultiplier
    /// </summary>
    public unsafe float StreamingDistanceMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// StructProperty: MeshObject
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MeshObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// StructProperty: WireframeColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WireframeColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ArrayProperty: SpaceBases
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SpaceBases
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ArrayProperty: LocalAtoms
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT LocalAtoms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ArrayProperty: CachedLocalAtoms
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT CachedLocalAtoms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ArrayProperty: CachedSpaceBases
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT CachedSpaceBases
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// IntProperty: LowUpdateFrameRate
    /// </summary>
    public unsafe int LowUpdateFrameRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ArrayProperty: RequiredBones
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT RequiredBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: ComposeOrderedRequiredBones
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ComposeOrderedRequiredBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ComponentProperty: ParentAnimComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ParentAnimComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ByteProperty: ParentAnimComponentMode
    /// </summary>
    public unsafe byte ParentAnimComponentMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// NameProperty: ParentAnimComponentOverrideRoot
    /// </summary>
    public unsafe BmSDK.FName ParentAnimComponentOverrideRoot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ArrayProperty: ParentBoneMap
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ParentBoneMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ArrayProperty: AnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>>>> AnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>>>>>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ArrayProperty: TemporarySavedAnimSets
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT TemporarySavedAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// ArrayProperty: MorphSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>>> MorphSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>>>>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ArrayProperty: ActiveMorphs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>> ActiveMorphs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>>>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// ArrayProperty: ActiveCurveMorphs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>> ActiveCurveMorphs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// MapProperty: MorphTargetIndexMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ MorphTargetIndexMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// ArrayProperty: Attachments
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo> Attachments
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.LODInfo>>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// StructProperty: Stretches
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.LODInfo Stretches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.LODInfo>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// IntProperty: ForcedLodModel
    /// </summary>
    public unsafe int ForcedLodModel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// IntProperty: MinLodModel
    /// </summary>
    public unsafe int MinLodModel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// IntProperty: PredictedLODLevel
    /// </summary>
    public unsafe int PredictedLODLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// IntProperty: OldPredictedLODLevel
    /// </summary>
    public unsafe int OldPredictedLODLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// FloatProperty: AnimationLODDistanceFactor
    /// </summary>
    public unsafe float AnimationLODDistanceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// IntProperty: AnimationLODFrameRate
    /// </summary>
    public unsafe int AnimationLODFrameRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceFactor
    /// </summary>
    public unsafe float MaxDistanceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// IntProperty: ChunkIndexPreview
    /// </summary>
    public unsafe int ChunkIndexPreview
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// IntProperty: SectionIndexPreview
    /// </summary>
    public unsafe int SectionIndexPreview
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// IntProperty: bForceWireframe
    /// </summary>
    public unsafe int bForceWireframe
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// IntProperty: bForceRefpose
    /// </summary>
    public unsafe int bForceRefpose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// IntProperty: bOldForceRefPose
    /// </summary>
    public unsafe int bOldForceRefPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// BoolProperty: bNoSkeletonUpdate
    /// </summary>
    public unsafe bool bNoSkeletonUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1396) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1396); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1396); }
    }

    /// <summary>
    /// IntProperty: bDisplayBones
    /// </summary>
    public unsafe int bDisplayBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// IntProperty: bDisplayRFlaps
    /// </summary>
    public unsafe int bDisplayRFlaps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// IntProperty: bShowPrePhysBones
    /// </summary>
    public unsafe int bShowPrePhysBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// IntProperty: bHideSkin
    /// </summary>
    public unsafe int bHideSkin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// IntProperty: bForceRawOffset
    /// </summary>
    public unsafe int bForceRawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// IntProperty: bIgnoreControllers
    /// </summary>
    public unsafe int bIgnoreControllers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// IntProperty: bTransformFromAnimParent
    /// </summary>
    public unsafe int bTransformFromAnimParent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// IntProperty: TickTag
    /// </summary>
    public unsafe int TickTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// IntProperty: InitTag
    /// </summary>
    public unsafe int InitTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// IntProperty: CachedAtomsTag
    /// </summary>
    public unsafe int CachedAtomsTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// IntProperty: bUseSingleBodyPhysics
    /// </summary>
    public unsafe int bUseSingleBodyPhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// IntProperty: bRequiredBonesUpToDate
    /// </summary>
    public unsafe int bRequiredBonesUpToDate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// FloatProperty: MinDistFactorForKinematicUpdate
    /// </summary>
    public unsafe float MinDistFactorForKinematicUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// IntProperty: FramesPhysicsAsleep
    /// </summary>
    public unsafe int FramesPhysicsAsleep
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// BoolProperty: bHasValidBodies
    /// </summary>
    public unsafe bool bHasValidBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bSkipAllUpdateWhenPhysicsAsleep
    /// </summary>
    public unsafe bool bSkipAllUpdateWhenPhysicsAsleep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bComponentUseFixedSkelBounds
    /// </summary>
    public unsafe bool bComponentUseFixedSkelBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUseBoundsFromParentAnimComponent
    /// </summary>
    public unsafe bool bUseBoundsFromParentAnimComponent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bConsiderAllBodiesForBounds
    /// </summary>
    public unsafe bool bConsiderAllBodiesForBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUpdateSkelWhenNotRendered
    /// </summary>
    public unsafe bool bUpdateSkelWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreControllersWhenNotRendered
    /// </summary>
    public unsafe bool bIgnoreControllersWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bTickAnimNodesWhenNotRendered
    /// </summary>
    public unsafe bool bTickAnimNodesWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bNotUpdatingKinematicDueToDistance
    /// </summary>
    public unsafe bool bNotUpdatingKinematicDueToDistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bForceDiscardRootMotion
    /// </summary>
    public unsafe bool bForceDiscardRootMotion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bNotifyRootMotionProcessed
    /// </summary>
    public unsafe bool bNotifyRootMotionProcessed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bRootMotionModeChangeNotify
    /// </summary>
    public unsafe bool bRootMotionModeChangeNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bRootMotionExtractedNotify
    /// </summary>
    public unsafe bool bRootMotionExtractedNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bProcessingRootMotion
    /// </summary>
    public unsafe bool bProcessingRootMotion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bDisableFaceFXMaterialInstanceCreation
    /// </summary>
    public unsafe bool bDisableFaceFXMaterialInstanceCreation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bDisableFaceFX
    /// </summary>
    public unsafe bool bDisableFaceFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: EnableFaceFXLOD
    /// </summary>
    public unsafe bool EnableFaceFXLOD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: FaceFXNeedsUpdate
    /// </summary>
    public unsafe bool FaceFXNeedsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bAnimTreeInitialised
    /// </summary>
    public unsafe bool bAnimTreeInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bForceMeshObjectUpdate
    /// </summary>
    public unsafe bool bForceMeshObjectUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bHasPhysicsAssetInstance
    /// </summary>
    public unsafe bool bHasPhysicsAssetInstance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bAllowRFlapsAssetInstance
    /// </summary>
    public unsafe bool bAllowRFlapsAssetInstance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUpdateKinematicBonesFromAnimation
    /// </summary>
    public unsafe bool bUpdateKinematicBonesFromAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUpdateJointsFromAnimation
    /// </summary>
    public unsafe bool bUpdateJointsFromAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bSkelCompFixed
    /// </summary>
    public unsafe bool bSkelCompFixed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bHasHadPhysicsBlendedIn
    /// </summary>
    public unsafe bool bHasHadPhysicsBlendedIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: AllowPhysicsBlendOutsidePostTick
    /// </summary>
    public unsafe bool AllowPhysicsBlendOutsidePostTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bForceUpdateAttachmentsInTick
    /// </summary>
    public unsafe bool bForceUpdateAttachmentsInTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bEnableFullAnimWeightBodies
    /// </summary>
    public unsafe bool bEnableFullAnimWeightBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bPerBoneVolumeEffects
    /// </summary>
    public unsafe bool bPerBoneVolumeEffects
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bPerBoneMotionBlur
    /// </summary>
    public unsafe bool bPerBoneMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bSyncActorLocationToRootRigidBody
    /// </summary>
    public unsafe bool bSyncActorLocationToRootRigidBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUseRawData
    /// </summary>
    public unsafe bool bUseRawData
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bDisableWarningWhenAnimNotFound
    /// </summary>
    public unsafe bool bDisableWarningWhenAnimNotFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAttachmentOwnerVisibility
    /// </summary>
    public unsafe bool bOverrideAttachmentOwnerVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bNeedsToDeleteHitMask
    /// </summary>
    public unsafe bool bNeedsToDeleteHitMask
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bPauseAnims
    /// </summary>
    public unsafe bool bPauseAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bChartDistanceFactor
    /// </summary>
    public unsafe bool bChartDistanceFactor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bEnableLineCheckWithBounds
    /// </summary>
    public unsafe bool bEnableLineCheckWithBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bCanHighlightSelectedSections
    /// </summary>
    public unsafe bool bCanHighlightSelectedSections
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bUseAggressiveLODScale
    /// </summary>
    public unsafe bool bUseAggressiveLODScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bAutomaticEmbeddedFaceFXAnims
    /// </summary>
    public unsafe bool bAutomaticEmbeddedFaceFXAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bPhysicsAssetOverridesBoundsType
    /// </summary>
    public unsafe bool bPhysicsAssetOverridesBoundsType
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bUpdateMorphWhenParentAnimComponentExists
    /// </summary>
    public unsafe bool bUpdateMorphWhenParentAnimComponentExists
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// StructProperty: LineCheckBoundsScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LineCheckBoundsScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// BoolProperty: bAllowPermanentFixOnSleep
    /// </summary>
    public unsafe bool bAllowPermanentFixOnSleep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenPermanentlyFixed
    /// </summary>
    public unsafe bool bHasBeenPermanentlyFixed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bDisableRagdollCalmingMeasures
    /// </summary>
    public unsafe bool bDisableRagdollCalmingMeasures
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bDisableRagdollCalmingMeasures_FromAnimationSystem
    /// </summary>
    public unsafe bool bDisableRagdollCalmingMeasures_FromAnimationSystem
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bDebugDisableRagdollCalmingMeasures
    /// </summary>
    public unsafe bool bDebugDisableRagdollCalmingMeasures
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bDisableCollisionWhenPermanentlyFixed
    /// </summary>
    public unsafe bool bDisableCollisionWhenPermanentlyFixed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bForceJointProjection
    /// </summary>
    public unsafe bool bForceJointProjection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bForceUseRagdollPhysicsTranslation
    /// </summary>
    public unsafe bool bForceUseRagdollPhysicsTranslation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysBlendInKinematicBodies
    /// </summary>
    public unsafe bool bAlwaysBlendInKinematicBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bAllowAngularDampingRamping
    /// </summary>
    public unsafe bool bAllowAngularDampingRamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// FloatProperty: CurrDampingRampupTime
    /// </summary>
    public unsafe float CurrDampingRampupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// FloatProperty: DampingRampupMinTime
    /// </summary>
    public unsafe float DampingRampupMinTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// FloatProperty: DampingRampupMaxTime
    /// </summary>
    public unsafe float DampingRampupMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// FloatProperty: PermanentFixRampupTime
    /// </summary>
    public unsafe float PermanentFixRampupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// FloatProperty: AggressiveLODMultiplier
    /// </summary>
    public unsafe float AggressiveLODMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothSimulation
    /// </summary>
    public unsafe bool bEnableClothSimulation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bDisableClothCollision
    /// </summary>
    public unsafe bool bDisableClothCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothFrozen
    /// </summary>
    public unsafe bool bClothFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bAutoFreezeClothWhenNotRendered
    /// </summary>
    public unsafe bool bAutoFreezeClothWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothAwakeOnStartup
    /// </summary>
    public unsafe bool bClothAwakeOnStartup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothBaseVelClamp
    /// </summary>
    public unsafe bool bClothBaseVelClamp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothBaseVelInterp
    /// </summary>
    public unsafe bool bClothBaseVelInterp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bAttachClothVertsToBaseBody
    /// </summary>
    public unsafe bool bAttachClothVertsToBaseBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bIsClothOnStaticObject
    /// </summary>
    public unsafe bool bIsClothOnStaticObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bUpdatedFixedClothVerts
    /// </summary>
    public unsafe bool bUpdatedFixedClothVerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothPositionalDampening
    /// </summary>
    public unsafe bool bClothPositionalDampening
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothWindRelativeToOwner
    /// </summary>
    public unsafe bool bClothWindRelativeToOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bRecentlyRendered
    /// </summary>
    public unsafe bool bRecentlyRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bCacheAnimSequenceNodes
    /// </summary>
    public unsafe bool bCacheAnimSequenceNodes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bNeedsInstanceWeightUpdate
    /// </summary>
    public unsafe bool bNeedsInstanceWeightUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysUseInstanceWeights
    /// </summary>
    public unsafe bool bAlwaysUseInstanceWeights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bUpdateComposeSkeletonPasses
    /// </summary>
    public unsafe bool bUpdateComposeSkeletonPasses
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bValidTemporarySavedAnimSets
    /// </summary>
    public unsafe bool bValidTemporarySavedAnimSets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bUseParentAnimComponentLODLevel
    /// </summary>
    public unsafe bool bUseParentAnimComponentLODLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bDeferredUpdateAnimatedMaterialParameters
    /// </summary>
    public unsafe bool bDeferredUpdateAnimatedMaterialParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bDeferredTrackedNotifyTick
    /// </summary>
    public unsafe bool bDeferredTrackedNotifyTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bOnlyCollideWithRootBone
    /// </summary>
    public unsafe bool bOnlyCollideWithRootBone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bHasCachedLocalNavMeshBounds
    /// </summary>
    public unsafe bool bHasCachedLocalNavMeshBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// StructProperty: CachedLocalNavMeshBounds
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CachedLocalNavMeshBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// ArrayProperty: LODInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.PersistentSoundNotifies>>>>> LODInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.PersistentSoundNotifies>>>>>>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// StructProperty: FrozenLocalToWorldPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FrozenLocalToWorldPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// StructProperty: FrozenLocalToWorldRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FrozenLocalToWorldRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// StructProperty: ClothExternalForce
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ClothExternalForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// StructProperty: ClothWind
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ClothWind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// StructProperty: ClothBaseVelClampRange
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ClothBaseVelClampRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// FloatProperty: ClothBlendWeight
    /// </summary>
    public unsafe float ClothBlendWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// FloatProperty: ClothDynamicBlendWeight
    /// </summary>
    public unsafe float ClothDynamicBlendWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// FloatProperty: ClothBlendMinDistanceFactor
    /// </summary>
    public unsafe float ClothBlendMinDistanceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// FloatProperty: ClothBlendMaxDistanceFactor
    /// </summary>
    public unsafe float ClothBlendMaxDistanceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// StructProperty: MinPosDampRange
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MinPosDampRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// StructProperty: MaxPosDampRange
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MaxPosDampRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// StructProperty: MinPosDampScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MinPosDampScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// StructProperty: MaxPosDampScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MaxPosDampScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// StructProperty: ClothSim
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ClothSim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// IntProperty: SceneIndex
    /// </summary>
    public unsafe int SceneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshPosData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.PersistentSoundNotifies>>>> ClothMeshPosData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.PersistentSoundNotifies>>>>>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshNormalData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.PersistentSoundNotifies>>> ClothMeshNormalData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.PersistentSoundNotifies>>>>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshIndexData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.PersistentSoundNotifies>> ClothMeshIndexData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.PersistentSoundNotifies>>>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// IntProperty: NumClothMeshVerts
    /// </summary>
    public unsafe int NumClothMeshVerts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// IntProperty: NumClothMeshIndices
    /// </summary>
    public unsafe int NumClothMeshIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshParentData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.PersistentSoundNotifies> ClothMeshParentData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.PersistentSoundNotifies>>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// IntProperty: NumClothMeshParentIndices
    /// </summary>
    public unsafe int NumClothMeshParentIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshWeldedPosData
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ClothMeshWeldedPosData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshWeldedNormalData
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ClothMeshWeldedNormalData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshWeldedIndexData
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ClothMeshWeldedIndexData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// IntProperty: ClothDirtyBufferFlag
    /// </summary>
    public unsafe int ClothDirtyBufferFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// ByteProperty: ClothRBChannel
    /// </summary>
    public unsafe byte ClothRBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// StructProperty: ClothRBCollideWithChannels
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ClothRBCollideWithChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// FloatProperty: ClothForceScale
    /// </summary>
    public unsafe float ClothForceScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// FloatProperty: ClothImpulseScale
    /// </summary>
    public unsafe float ClothImpulseScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// FloatProperty: ClothAttachmentTearFactor
    /// </summary>
    public unsafe float ClothAttachmentTearFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// BoolProperty: bClothUseCompartment
    /// </summary>
    public unsafe bool bClothUseCompartment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1832) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1832); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1832); }
    }

    /// <summary>
    /// FloatProperty: MinDistanceForClothReset
    /// </summary>
    public unsafe float MinDistanceForClothReset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// StructProperty: LastClothLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastClothLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// ByteProperty: ApexClothingRBChannel
    /// </summary>
    public unsafe byte ApexClothingRBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// StructProperty: ApexClothingRBCollideWithChannels
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ApexClothingRBCollideWithChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// ByteProperty: ApexClothingCollisionRBChannel
    /// </summary>
    public unsafe byte ApexClothingCollisionRBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// BoolProperty: bAutoFreezeApexClothingWhenNotRendered
    /// </summary>
    public unsafe bool bAutoFreezeApexClothingWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1864); }
    }

    /// <summary>
    /// BoolProperty: bLocalSpaceWind
    /// </summary>
    public unsafe bool bLocalSpaceWind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1864); }
    }

    /// <summary>
    /// BoolProperty: bApexClothingBaseVelClamp
    /// </summary>
    public unsafe bool bApexClothingBaseVelClamp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1864); }
    }

    /// <summary>
    /// StructProperty: ApexClothingBaseVelClampRange
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ApexClothingBaseVelClampRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// StructProperty: WindVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WindVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// FloatProperty: WindVelocityBlendTime
    /// </summary>
    public unsafe float WindVelocityBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bClothingMaterialOverride
    /// </summary>
    public unsafe bool bClothingMaterialOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1896); }
    }

    /// <summary>
    /// ObjectProperty: ClothingMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ClothingMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// BoolProperty: bSkipInitClothing
    /// </summary>
    public unsafe bool bSkipInitClothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1908) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1908); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1908); }
    }

    /// <summary>
    /// StructProperty: AudioBonesToTrack
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.PersistentSoundNotifies AudioBonesToTrack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.PersistentSoundNotifies>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// StructProperty: PersistentSoundNotifies
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.FaceFXRegisterTransitions PersistentSoundNotifies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.FaceFXRegisterTransitions>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// ObjectProperty: LimitMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LimitMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// StructProperty: RootMotionDelta
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RootMotionDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// StructProperty: RootMotionVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RootMotionVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// StructProperty: RootMotionAccelScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RootMotionAccelScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// ByteProperty: RootMotionMode
    /// </summary>
    public unsafe byte RootMotionMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// ByteProperty: PreviousRMM
    /// </summary>
    public unsafe byte PreviousRMM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2025); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2025); }
    }

    /// <summary>
    /// ByteProperty: PendingRMM
    /// </summary>
    public unsafe byte PendingRMM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2026); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2026); }
    }

    /// <summary>
    /// ByteProperty: OldPendingRMM
    /// </summary>
    public unsafe byte OldPendingRMM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2027); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2027); }
    }

    /// <summary>
    /// IntProperty: bRMMOneFrameDelay
    /// </summary>
    public unsafe int bRMMOneFrameDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// ByteProperty: RootMotionRotationMode
    /// </summary>
    public unsafe byte RootMotionRotationMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// ByteProperty: AnimRotationOnly
    /// </summary>
    public unsafe byte AnimRotationOnly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2033); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2033); }
    }

    /// <summary>
    /// ByteProperty: FaceFXBlendMode
    /// </summary>
    public unsafe byte FaceFXBlendMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2034); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2034); }
    }

    /// <summary>
    /// StructProperty: FaceFXActorInstance
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FaceFXActorInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXRegisterTransitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> FaceFXRegisterTransitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXRegisterConstants
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> FaceFXRegisterConstants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXEmbeddedAnimSamples
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> FaceFXEmbeddedAnimSamples
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXBaseExpressionSamples
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> FaceFXBaseExpressionSamples
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXBoneAtoms
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> FaceFXBoneAtoms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// ObjectProperty: FaceFXPlayAnim_AnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FaceFXPlayAnim_AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// StrProperty: FaceFXPlayAnim_AnimName
    /// </summary>
    public unsafe BmSDK.FString FaceFXPlayAnim_AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// FloatProperty: FaceFXPlayAnim_Time
    /// </summary>
    public unsafe float FaceFXPlayAnim_Time
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ObjectProperty: FaceFXForceAnim_AnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FaceFXForceAnim_AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// StrProperty: FaceFXForceAnim_AnimName
    /// </summary>
    public unsafe BmSDK.FString FaceFXForceAnim_AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// FloatProperty: FaceFXForceAnim_Time
    /// </summary>
    public unsafe float FaceFXForceAnim_Time
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// IntProperty: EnableFaceFXAtLODIndex
    /// </summary>
    public unsafe int EnableFaceFXAtLODIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// StructProperty: MatineeLookAt
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.DrivenMaterialParameterInstanceErrors MatineeLookAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.DrivenMaterialParameterInstanceErrors>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: DrivenMaterialParameterInstance
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DrivenMaterialParameterInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// ArrayProperty: DrivenMaterialParameterInstanceErrors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.BoneVisibilityStates> DrivenMaterialParameterInstanceErrors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.BoneVisibilityStates>>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// StructProperty: AnimatedMaterialParameters
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.BoneVisibilityStates AnimatedMaterialParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.BoneVisibilityStates>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// ArrayProperty: BoneVisibilityStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.ExtraSocketMeshes>>>> BoneVisibilityStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.ExtraSocketMeshes>>>>>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// ArrayProperty: AlternativeBoneVisibilityStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.ExtraSocketMeshes>>> AlternativeBoneVisibilityStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.ExtraSocketMeshes>>>>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// StructProperty: LocalToWorldBoneAtom
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LocalToWorldBoneAtom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// StructProperty: DiscardedRootMotion
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DiscardedRootMotion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// StructProperty: CurrDepthBiasData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrDepthBiasData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// BoolProperty: bDisableColourWrites
    /// </summary>
    public unsafe bool bDisableColourWrites
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableTwistBoneFixers
    /// </summary>
    public unsafe bool bEnableTwistBoneFixers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableKneeElbowFixers
    /// </summary>
    public unsafe bool bEnableKneeElbowFixers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableNeckTwistFixer
    /// </summary>
    public unsafe bool bEnableNeckTwistFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableCollarTwistFixer
    /// </summary>
    public unsafe bool bEnableCollarTwistFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableBreathingFixer
    /// </summary>
    public unsafe bool bEnableBreathingFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableSkeletalMeshSkelControls
    /// </summary>
    public unsafe bool bEnableSkeletalMeshSkelControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableDrivenMaterialParameters
    /// </summary>
    public unsafe bool bEnableDrivenMaterialParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bInsideWindForceFieldVolume
    /// </summary>
    public unsafe bool bInsideWindForceFieldVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bAllowRagdollContainmentChecks
    /// </summary>
    public unsafe bool bAllowRagdollContainmentChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bStuckAsARagdoll
    /// </summary>
    public unsafe bool bStuckAsARagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// IntProperty: StuckBodyPartIndex
    /// </summary>
    public unsafe int StuckBodyPartIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// StructProperty: StuckStartTime
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StuckStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// FloatProperty: CurrRagdollTime
    /// </summary>
    public unsafe float CurrRagdollTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// FloatProperty: ContainmentTestDelay
    /// </summary>
    public unsafe float ContainmentTestDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// FloatProperty: MaxRagdollLiveTime
    /// </summary>
    public unsafe float MaxRagdollLiveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// FloatProperty: MinRagdollStuckTime
    /// </summary>
    public unsafe float MinRagdollStuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// FloatProperty: MinNearlyStillBodiesProportionForNearlyStillRagdoll
    /// </summary>
    public unsafe float MinNearlyStillBodiesProportionForNearlyStillRagdoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// ArrayProperty: BoneToBody
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.ExtraSocketMeshes>> BoneToBody
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.ExtraSocketMeshes>>>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// ArrayProperty: BodyToBone
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.ExtraSocketMeshes> BodyToBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.ExtraSocketMeshes>>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// StructProperty: Fixers
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.ExtraSocketMeshes Fixers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.ExtraSocketMeshes>(Ptr + 2508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2508); }
    }

    /// <summary>
    /// StructProperty: BreathingFixer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BreathingFixer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// ArrayProperty: ExtraSocketMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>> ExtraSocketMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// FloatProperty: ProgressiveDrawingFraction
    /// </summary>
    public unsafe float ProgressiveDrawingFraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// ByteProperty: CustomSortAlternateIndexMode
    /// </summary>
    public unsafe byte CustomSortAlternateIndexMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ArrayProperty: MorphTargetsQueried
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>> MorphTargetsQueried
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// StructProperty: PhysXAggregate
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PhysXAggregate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// StructProperty: AsyncJob
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AsyncJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// FloatProperty: RFlapsInitialBlendWeightOverride
    /// </summary>
    public unsafe float RFlapsInitialBlendWeightOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }
}
