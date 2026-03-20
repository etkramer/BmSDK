#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSkeletalMeshComponentNoLights<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSkeletalMeshComponentNoLights : BmSDK.Engine.SkeletalMeshComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSkeletalMeshComponentNoLights", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSkeletalMeshComponentNoLights() { }

    /// <summary>
    /// Constructs a new RSkeletalMeshComponentNoLights
    /// </summary>
    public RSkeletalMeshComponentNoLights(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSkeletalMeshComponentNoLights Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSkeletalMeshComponentNoLights(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh SkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ComponentProperty: AttachedToSkelComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent AttachedToSkelComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: AnimTreeTemplate
    /// </summary>
    public unsafe BmSDK.Engine.AnimTree AnimTreeTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimTree>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: Animations
    /// </summary>
    public unsafe BmSDK.Engine.AnimNode Animations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNode>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ArrayProperty: AnimTickArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimNode> AnimTickArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimNode>>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ArrayProperty: AnimAlwaysTickArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimNode> AnimAlwaysTickArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimNode>>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ArrayProperty: AnimTickRelevancyArray
    /// </summary>
    public unsafe BmSDK.TArray<int> AnimTickRelevancyArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ArrayProperty: AnimTickWeightsArray
    /// </summary>
    public unsafe BmSDK.TArray<float> AnimTickWeightsArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ArrayProperty: SkelControlTickArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkelControlBase> SkelControlTickArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkelControlBase>>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ArrayProperty: SkelControlInstances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FSkelControlInstance> SkelControlInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FSkelControlInstance>>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ArrayProperty: PostFixerUpdateBones
    /// </summary>
    public unsafe BmSDK.TArray<int> PostFixerUpdateBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ArrayProperty: AnimNotifies
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AnimNotifies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: AnimNodePose
    /// </summary>
    public unsafe BmSDK.Engine.AnimNode AnimNodePose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNode>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ArrayProperty: TrackedNotifies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FTrackedNotify> TrackedNotifies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FTrackedNotify>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsAsset
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset PhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsAssetInstance
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAssetInstance PhysicsAssetInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAssetInstance>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ObjectProperty: FlapsAssetInstance
    /// </summary>
    public unsafe BmSDK.Engine.RFlapsAssetInstance FlapsAssetInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlapsAssetInstance>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// StructProperty: ApexClothing
    /// </summary>
    public unsafe System.IntPtr ApexClothing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ArrayProperty: ForceFieldComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NxForceFieldComponent> ForceFieldComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NxForceFieldComponent>>(Ptr + 856); }
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
    public unsafe BmSDK.Engine.SkeletalMeshComponent.EApexClothMaxDistanceScaleMode ApexClothMaxDistanceScaleMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.EApexClothMaxDistanceScaleMode>(Ptr + 888); }
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
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.ESkeletalMeshComponentBoundsType BoundsType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.ESkeletalMeshComponentBoundsType>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: FixedBounds
    /// </summary>
    public unsafe BmSDK.GameObject.FBoxSphereBounds FixedBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoxSphereBounds>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// StructProperty: OriginalBounds
    /// </summary>
    public unsafe BmSDK.GameObject.FBoxSphereBounds OriginalBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoxSphereBounds>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ArrayProperty: ExtraBounds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FSkeletalMeshComponentExtraBounds> ExtraBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FSkeletalMeshComponentExtraBounds>>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: ExtraBoundsInstances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FSkeletalMeshComponentExtraBoundsInstance> ExtraBoundsInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FSkeletalMeshComponentExtraBoundsInstance>>(Ptr + 976); }
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
    public unsafe System.IntPtr MeshObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// StructProperty: WireframeColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor WireframeColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ArrayProperty: SpaceBases
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FBoneAtom> SpaceBases
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FBoneAtom>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ArrayProperty: LocalAtoms
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FBoneAtom> LocalAtoms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FBoneAtom>>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ArrayProperty: CachedLocalAtoms
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FBoneAtom> CachedLocalAtoms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FBoneAtom>>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ArrayProperty: CachedSpaceBases
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FBoneAtom> CachedSpaceBases
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FBoneAtom>>(Ptr + 1060); }
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
    public unsafe BmSDK.TArray<int> RequiredBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: ComposeOrderedRequiredBones
    /// </summary>
    public unsafe BmSDK.TArray<int> ComposeOrderedRequiredBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ComponentProperty: ParentAnimComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ParentAnimComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ByteProperty: ParentAnimComponentMode
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.EParentAnimComponentMode ParentAnimComponentMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.EParentAnimComponentMode>(Ptr + 1120); }
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
    public unsafe BmSDK.TArray<int> ParentBoneMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ArrayProperty: AnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ArrayProperty: TemporarySavedAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> TemporarySavedAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// ArrayProperty: MorphSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MorphTargetSet> MorphSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MorphTargetSet>>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ArrayProperty: ActiveMorphs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FActiveMorph> ActiveMorphs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FActiveMorph>>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// ArrayProperty: ActiveCurveMorphs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FActiveMorph> ActiveCurveMorphs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FActiveMorph>>(Ptr + 1212); }
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
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FAttachment> Attachments
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FAttachment>>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// StructProperty: Stretches
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.FStretchInstances Stretches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.FStretchInstances>(Ptr + 1316); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1396) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1396); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1396); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bSkipAllUpdateWhenPhysicsAsleep
    /// </summary>
    public unsafe bool bSkipAllUpdateWhenPhysicsAsleep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bComponentUseFixedSkelBounds
    /// </summary>
    public unsafe bool bComponentUseFixedSkelBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUseBoundsFromParentAnimComponent
    /// </summary>
    public unsafe bool bUseBoundsFromParentAnimComponent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bConsiderAllBodiesForBounds
    /// </summary>
    public unsafe bool bConsiderAllBodiesForBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUpdateSkelWhenNotRendered
    /// </summary>
    public unsafe bool bUpdateSkelWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreControllersWhenNotRendered
    /// </summary>
    public unsafe bool bIgnoreControllersWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bTickAnimNodesWhenNotRendered
    /// </summary>
    public unsafe bool bTickAnimNodesWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bNotUpdatingKinematicDueToDistance
    /// </summary>
    public unsafe bool bNotUpdatingKinematicDueToDistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bForceDiscardRootMotion
    /// </summary>
    public unsafe bool bForceDiscardRootMotion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bNotifyRootMotionProcessed
    /// </summary>
    public unsafe bool bNotifyRootMotionProcessed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bRootMotionModeChangeNotify
    /// </summary>
    public unsafe bool bRootMotionModeChangeNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bRootMotionExtractedNotify
    /// </summary>
    public unsafe bool bRootMotionExtractedNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bProcessingRootMotion
    /// </summary>
    public unsafe bool bProcessingRootMotion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bDisableFaceFXMaterialInstanceCreation
    /// </summary>
    public unsafe bool bDisableFaceFXMaterialInstanceCreation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bDisableFaceFX
    /// </summary>
    public unsafe bool bDisableFaceFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: EnableFaceFXLOD
    /// </summary>
    public unsafe bool EnableFaceFXLOD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: FaceFXNeedsUpdate
    /// </summary>
    public unsafe bool FaceFXNeedsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bAnimTreeInitialised
    /// </summary>
    public unsafe bool bAnimTreeInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bForceMeshObjectUpdate
    /// </summary>
    public unsafe bool bForceMeshObjectUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bHasPhysicsAssetInstance
    /// </summary>
    public unsafe bool bHasPhysicsAssetInstance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bAllowRFlapsAssetInstance
    /// </summary>
    public unsafe bool bAllowRFlapsAssetInstance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUpdateKinematicBonesFromAnimation
    /// </summary>
    public unsafe bool bUpdateKinematicBonesFromAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUpdateJointsFromAnimation
    /// </summary>
    public unsafe bool bUpdateJointsFromAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bSkelCompFixed
    /// </summary>
    public unsafe bool bSkelCompFixed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bHasHadPhysicsBlendedIn
    /// </summary>
    public unsafe bool bHasHadPhysicsBlendedIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: AllowPhysicsBlendOutsidePostTick
    /// </summary>
    public unsafe bool AllowPhysicsBlendOutsidePostTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bForceUpdateAttachmentsInTick
    /// </summary>
    public unsafe bool bForceUpdateAttachmentsInTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bEnableFullAnimWeightBodies
    /// </summary>
    public unsafe bool bEnableFullAnimWeightBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bPerBoneVolumeEffects
    /// </summary>
    public unsafe bool bPerBoneVolumeEffects
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bPerBoneMotionBlur
    /// </summary>
    public unsafe bool bPerBoneMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bSyncActorLocationToRootRigidBody
    /// </summary>
    public unsafe bool bSyncActorLocationToRootRigidBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1456); }
    }

    /// <summary>
    /// BoolProperty: bUseRawData
    /// </summary>
    public unsafe bool bUseRawData
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bDisableWarningWhenAnimNotFound
    /// </summary>
    public unsafe bool bDisableWarningWhenAnimNotFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAttachmentOwnerVisibility
    /// </summary>
    public unsafe bool bOverrideAttachmentOwnerVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bNeedsToDeleteHitMask
    /// </summary>
    public unsafe bool bNeedsToDeleteHitMask
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bPauseAnims
    /// </summary>
    public unsafe bool bPauseAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bChartDistanceFactor
    /// </summary>
    public unsafe bool bChartDistanceFactor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bEnableLineCheckWithBounds
    /// </summary>
    public unsafe bool bEnableLineCheckWithBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bCanHighlightSelectedSections
    /// </summary>
    public unsafe bool bCanHighlightSelectedSections
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bUseAggressiveLODScale
    /// </summary>
    public unsafe bool bUseAggressiveLODScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bAutomaticEmbeddedFaceFXAnims
    /// </summary>
    public unsafe bool bAutomaticEmbeddedFaceFXAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bPhysicsAssetOverridesBoundsType
    /// </summary>
    public unsafe bool bPhysicsAssetOverridesBoundsType
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// BoolProperty: bUpdateMorphWhenParentAnimComponentExists
    /// </summary>
    public unsafe bool bUpdateMorphWhenParentAnimComponentExists
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1460); }
    }

    /// <summary>
    /// StructProperty: LineCheckBoundsScale
    /// </summary>
    public unsafe System.Numerics.Vector3 LineCheckBoundsScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// BoolProperty: bAllowPermanentFixOnSleep
    /// </summary>
    public unsafe bool bAllowPermanentFixOnSleep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenPermanentlyFixed
    /// </summary>
    public unsafe bool bHasBeenPermanentlyFixed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bDisableRagdollCalmingMeasures
    /// </summary>
    public unsafe bool bDisableRagdollCalmingMeasures
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bDisableRagdollCalmingMeasures_FromAnimationSystem
    /// </summary>
    public unsafe bool bDisableRagdollCalmingMeasures_FromAnimationSystem
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bDebugDisableRagdollCalmingMeasures
    /// </summary>
    public unsafe bool bDebugDisableRagdollCalmingMeasures
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bDisableCollisionWhenPermanentlyFixed
    /// </summary>
    public unsafe bool bDisableCollisionWhenPermanentlyFixed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bForceJointProjection
    /// </summary>
    public unsafe bool bForceJointProjection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bForceUseRagdollPhysicsTranslation
    /// </summary>
    public unsafe bool bForceUseRagdollPhysicsTranslation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysBlendInKinematicBodies
    /// </summary>
    public unsafe bool bAlwaysBlendInKinematicBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
    }

    /// <summary>
    /// BoolProperty: bAllowAngularDampingRamping
    /// </summary>
    public unsafe bool bAllowAngularDampingRamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1476); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bDisableClothCollision
    /// </summary>
    public unsafe bool bDisableClothCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothFrozen
    /// </summary>
    public unsafe bool bClothFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bAutoFreezeClothWhenNotRendered
    /// </summary>
    public unsafe bool bAutoFreezeClothWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothAwakeOnStartup
    /// </summary>
    public unsafe bool bClothAwakeOnStartup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothBaseVelClamp
    /// </summary>
    public unsafe bool bClothBaseVelClamp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothBaseVelInterp
    /// </summary>
    public unsafe bool bClothBaseVelInterp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bAttachClothVertsToBaseBody
    /// </summary>
    public unsafe bool bAttachClothVertsToBaseBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bIsClothOnStaticObject
    /// </summary>
    public unsafe bool bIsClothOnStaticObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bUpdatedFixedClothVerts
    /// </summary>
    public unsafe bool bUpdatedFixedClothVerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothPositionalDampening
    /// </summary>
    public unsafe bool bClothPositionalDampening
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bClothWindRelativeToOwner
    /// </summary>
    public unsafe bool bClothWindRelativeToOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bRecentlyRendered
    /// </summary>
    public unsafe bool bRecentlyRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bCacheAnimSequenceNodes
    /// </summary>
    public unsafe bool bCacheAnimSequenceNodes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bNeedsInstanceWeightUpdate
    /// </summary>
    public unsafe bool bNeedsInstanceWeightUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysUseInstanceWeights
    /// </summary>
    public unsafe bool bAlwaysUseInstanceWeights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bUpdateComposeSkeletonPasses
    /// </summary>
    public unsafe bool bUpdateComposeSkeletonPasses
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bValidTemporarySavedAnimSets
    /// </summary>
    public unsafe bool bValidTemporarySavedAnimSets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bUseParentAnimComponentLODLevel
    /// </summary>
    public unsafe bool bUseParentAnimComponentLODLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bDeferredUpdateAnimatedMaterialParameters
    /// </summary>
    public unsafe bool bDeferredUpdateAnimatedMaterialParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bDeferredTrackedNotifyTick
    /// </summary>
    public unsafe bool bDeferredTrackedNotifyTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bOnlyCollideWithRootBone
    /// </summary>
    public unsafe bool bOnlyCollideWithRootBone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// BoolProperty: bHasCachedLocalNavMeshBounds
    /// </summary>
    public unsafe bool bHasCachedLocalNavMeshBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1500); }
    }

    /// <summary>
    /// StructProperty: CachedLocalNavMeshBounds
    /// </summary>
    public unsafe BmSDK.GameObject.FBox CachedLocalNavMeshBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBox>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// ArrayProperty: LODInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FSkelMeshComponentLODInfo> LODInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.FSkelMeshComponentLODInfo>>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// StructProperty: FrozenLocalToWorldPos
    /// </summary>
    public unsafe System.Numerics.Vector3 FrozenLocalToWorldPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// StructProperty: FrozenLocalToWorldRot
    /// </summary>
    public unsafe BmSDK.Rotator FrozenLocalToWorldRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// StructProperty: ClothExternalForce
    /// </summary>
    public unsafe System.Numerics.Vector3 ClothExternalForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// StructProperty: ClothWind
    /// </summary>
    public unsafe System.Numerics.Vector3 ClothWind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// StructProperty: ClothBaseVelClampRange
    /// </summary>
    public unsafe System.Numerics.Vector3 ClothBaseVelClampRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1596); }
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
    public unsafe System.Numerics.Vector3 MinPosDampRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// StructProperty: MaxPosDampRange
    /// </summary>
    public unsafe System.Numerics.Vector3 MaxPosDampRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// StructProperty: MinPosDampScale
    /// </summary>
    public unsafe System.Numerics.Vector3 MinPosDampScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// StructProperty: MaxPosDampScale
    /// </summary>
    public unsafe System.Numerics.Vector3 MaxPosDampScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// StructProperty: ClothSim
    /// </summary>
    public unsafe System.IntPtr ClothSim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1672); }
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
    public unsafe BmSDK.TArray<System.Numerics.Vector3> ClothMeshPosData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshNormalData
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> ClothMeshNormalData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshIndexData
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothMeshIndexData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1716); }
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
    public unsafe BmSDK.TArray<int> ClothMeshParentData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1740); }
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
    public unsafe BmSDK.TArray<System.Numerics.Vector3> ClothMeshWeldedPosData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshWeldedNormalData
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> ClothMeshWeldedNormalData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshWeldedIndexData
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothMeshWeldedIndexData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1792); }
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
    public unsafe BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel ClothRBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// StructProperty: ClothRBCollideWithChannels
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer ClothRBCollideWithChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer>(Ptr + 1816); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1832) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1832); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1832); }
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
    public unsafe System.Numerics.Vector3 LastClothLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// ByteProperty: ApexClothingRBChannel
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel ApexClothingRBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// StructProperty: ApexClothingRBCollideWithChannels
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer ApexClothingRBCollideWithChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// ByteProperty: ApexClothingCollisionRBChannel
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel ApexClothingCollisionRBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// BoolProperty: bAutoFreezeApexClothingWhenNotRendered
    /// </summary>
    public unsafe bool bAutoFreezeApexClothingWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1864); }
    }

    /// <summary>
    /// BoolProperty: bLocalSpaceWind
    /// </summary>
    public unsafe bool bLocalSpaceWind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1864); }
    }

    /// <summary>
    /// BoolProperty: bApexClothingBaseVelClamp
    /// </summary>
    public unsafe bool bApexClothingBaseVelClamp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1864); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1864); }
    }

    /// <summary>
    /// StructProperty: ApexClothingBaseVelClampRange
    /// </summary>
    public unsafe System.Numerics.Vector3 ApexClothingBaseVelClampRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// StructProperty: WindVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 WindVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1880); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1896); }
    }

    /// <summary>
    /// ObjectProperty: ClothingMaterial
    /// </summary>
    public unsafe BmSDK.Engine.ClothingMaterial ClothingMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ClothingMaterial>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// BoolProperty: bSkipInitClothing
    /// </summary>
    public unsafe bool bSkipInitClothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1908) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1908); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1908); }
    }

    /// <summary>
    /// StructProperty: AudioBonesToTrack
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.FAudioBoneTracking AudioBonesToTrack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.FAudioBoneTracking>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// StructProperty: PersistentSoundNotifies
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.FPersistentSoundData PersistentSoundNotifies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.FPersistentSoundData>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// ObjectProperty: LimitMaterial
    /// </summary>
    public unsafe BmSDK.Engine.Material LimitMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// StructProperty: RootMotionDelta
    /// </summary>
    public unsafe BmSDK.GameObject.FBoneAtom RootMotionDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoneAtom>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// StructProperty: RootMotionVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 RootMotionVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// StructProperty: RootMotionAccelScale
    /// </summary>
    public unsafe System.Numerics.Vector3 RootMotionAccelScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// ByteProperty: RootMotionMode
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode RootMotionMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// ByteProperty: PreviousRMM
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode PreviousRMM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode>(Ptr + 2025); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2025); }
    }

    /// <summary>
    /// ByteProperty: PendingRMM
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode PendingRMM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode>(Ptr + 2026); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2026); }
    }

    /// <summary>
    /// ByteProperty: OldPendingRMM
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode OldPendingRMM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.ERootMotionMode>(Ptr + 2027); }
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
    public unsafe BmSDK.Engine.SkeletalMeshComponent.ERootMotionRotationMode RootMotionRotationMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.ERootMotionRotationMode>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// ByteProperty: AnimRotationOnly
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.EAnimRotationOnly AnimRotationOnly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.EAnimRotationOnly>(Ptr + 2033); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2033); }
    }

    /// <summary>
    /// ByteProperty: FaceFXBlendMode
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.EFaceFXBlendMode FaceFXBlendMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.EFaceFXBlendMode>(Ptr + 2034); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2034); }
    }

    /// <summary>
    /// StructProperty: FaceFXActorInstance
    /// </summary>
    public unsafe System.IntPtr FaceFXActorInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXRegisterTransitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXRegisterTransition> FaceFXRegisterTransitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXRegisterTransition>>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXRegisterConstants
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXRegisterConstant> FaceFXRegisterConstants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXRegisterConstant>>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXEmbeddedAnimSamples
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXEmbeddedAnimSample> FaceFXEmbeddedAnimSamples
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXEmbeddedAnimSample>>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXBaseExpressionSamples
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXBaseExpressionSample> FaceFXBaseExpressionSamples
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXBaseExpressionSample>>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXBoneAtoms
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FBoneAtom> FaceFXBoneAtoms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FBoneAtom>>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// ObjectProperty: FaceFXPlayAnim_AnimSet
    /// </summary>
    public unsafe BmSDK.Engine.FaceFXAnimSet FaceFXPlayAnim_AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FaceFXAnimSet>(Ptr + 2124); }
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
    public unsafe BmSDK.Engine.FaceFXAnimSet FaceFXForceAnim_AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FaceFXAnimSet>(Ptr + 2152); }
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
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXMatineeLookAt MatineeLookAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.FFaceFXMatineeLookAt>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: DrivenMaterialParameterInstance
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshDrivenMaterialParameterInstance DrivenMaterialParameterInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshDrivenMaterialParameterInstance>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// ArrayProperty: DrivenMaterialParameterInstanceErrors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DrivenMaterialParameterInstanceErrors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// StructProperty: AnimatedMaterialParameters
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.FAnimatedMaterialParameters AnimatedMaterialParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.FAnimatedMaterialParameters>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// ArrayProperty: BoneVisibilityStates
    /// </summary>
    public unsafe BmSDK.TArray<byte> BoneVisibilityStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// ArrayProperty: AlternativeBoneVisibilityStates
    /// </summary>
    public unsafe BmSDK.TArray<bool> AlternativeBoneVisibilityStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// StructProperty: LocalToWorldBoneAtom
    /// </summary>
    public unsafe BmSDK.GameObject.FBoneAtom LocalToWorldBoneAtom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoneAtom>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// StructProperty: DiscardedRootMotion
    /// </summary>
    public unsafe BmSDK.GameObject.FBoneAtom DiscardedRootMotion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoneAtom>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// StructProperty: CurrDepthBiasData
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.FDepthBiasData CurrDepthBiasData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.FDepthBiasData>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// BoolProperty: bDisableColourWrites
    /// </summary>
    public unsafe bool bDisableColourWrites
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableTwistBoneFixers
    /// </summary>
    public unsafe bool bEnableTwistBoneFixers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableKneeElbowFixers
    /// </summary>
    public unsafe bool bEnableKneeElbowFixers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableNeckTwistFixer
    /// </summary>
    public unsafe bool bEnableNeckTwistFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableCollarTwistFixer
    /// </summary>
    public unsafe bool bEnableCollarTwistFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableBreathingFixer
    /// </summary>
    public unsafe bool bEnableBreathingFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableSkeletalMeshSkelControls
    /// </summary>
    public unsafe bool bEnableSkeletalMeshSkelControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bEnableDrivenMaterialParameters
    /// </summary>
    public unsafe bool bEnableDrivenMaterialParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bInsideWindForceFieldVolume
    /// </summary>
    public unsafe bool bInsideWindForceFieldVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bAllowRagdollContainmentChecks
    /// </summary>
    public unsafe bool bAllowRagdollContainmentChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bStuckAsARagdoll
    /// </summary>
    public unsafe bool bStuckAsARagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
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
    public unsafe double StuckStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 2448); }
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
    public unsafe BmSDK.TArray<int> BoneToBody
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// ArrayProperty: BodyToBone
    /// </summary>
    public unsafe BmSDK.TArray<int> BodyToBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// StructProperty: Fixers
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.FFixers Fixers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.FFixers>(Ptr + 2508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2508); }
    }

    /// <summary>
    /// StructProperty: BreathingFixer
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.FBreathingFixer BreathingFixer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.FBreathingFixer>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// ArrayProperty: ExtraSocketMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh> ExtraSocketMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh>>(Ptr + 2588); }
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
    public unsafe BmSDK.TArray<BmSDK.FName> MorphTargetsQueried
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// StructProperty: PhysXAggregate
    /// </summary>
    public unsafe System.IntPtr PhysXAggregate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// StructProperty: AsyncJob
    /// </summary>
    public unsafe System.IntPtr AsyncJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2636); }
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
