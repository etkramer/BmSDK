#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleSystem<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleSystem : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleSystem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleSystem() { }

    /// <summary>
    /// Constructs a new ParticleSystem
    /// </summary>
    public ParticleSystem(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleSystem Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleSystem(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: SystemUpdateMode
    /// </summary>
    public unsafe byte SystemUpdateMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ByteProperty: LODMethod
    /// </summary>
    public unsafe byte LODMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 85); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 85); }
    }

    /// <summary>
    /// ByteProperty: OcclusionBoundsMethod
    /// </summary>
    public unsafe byte OcclusionBoundsMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 86); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 86); }
    }

    /// <summary>
    /// ByteProperty: MinimumPhysXLevelOverride
    /// </summary>
    public unsafe byte MinimumPhysXLevelOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 87); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 87); }
    }

    /// <summary>
    /// FloatProperty: UpdateTime_FPS
    /// </summary>
    public unsafe float UpdateTime_FPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// FloatProperty: UpdateTime_Delta
    /// </summary>
    public unsafe float UpdateTime_Delta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: WarmupTime
    /// </summary>
    public unsafe float WarmupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: WarmupTickRate
    /// </summary>
    public unsafe float WarmupTickRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: Emitters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> Emitters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ComponentProperty: PreviewComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviewComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// StructProperty: ThumbnailAngle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThumbnailAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: ThumbnailDistance
    /// </summary>
    public unsafe float ThumbnailDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: ThumbnailWarmup
    /// </summary>
    public unsafe float ThumbnailWarmup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: bLit
    /// </summary>
    public unsafe bool bLit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bOrientZAxisTowardCamera
    /// </summary>
    public unsafe bool bOrientZAxisTowardCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bRegenerateLODDuplicate
    /// </summary>
    public unsafe bool bRegenerateLODDuplicate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bEnableParticleDistanceCulling
    /// </summary>
    public unsafe bool bEnableParticleDistanceCulling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bUseFixedRelativeBoundingBox
    /// </summary>
    public unsafe bool bUseFixedRelativeBoundingBox
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bShouldResetPeakCounts
    /// </summary>
    public unsafe bool bShouldResetPeakCounts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bIsLooping
    /// </summary>
    public unsafe bool bIsLooping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bHasPhysics
    /// </summary>
    public unsafe bool bHasPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bHasApex
    /// </summary>
    public unsafe bool bHasApex
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bUseRealtimeThumbnail
    /// </summary>
    public unsafe bool bUseRealtimeThumbnail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: ThumbnailImageOutOfDate
    /// </summary>
    public unsafe bool ThumbnailImageOutOfDate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bSkipSpawnCountCheck
    /// </summary>
    public unsafe bool bSkipSpawnCountCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bHighPriorityPoolEffect
    /// </summary>
    public unsafe bool bHighPriorityPoolEffect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bUseDelayRange
    /// </summary>
    public unsafe bool bUseDelayRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: CurveEdSetup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurveEdSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ObjectProperty: ThumbnailImage
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThumbnailImage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// ObjectProperty: PhysxParticleSystemRef
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysxParticleSystemRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// FloatProperty: LODDistanceCheckTime
    /// </summary>
    public unsafe float LODDistanceCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ArrayProperty: LODDistances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> LODDistances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: EditorLODSetting
    /// </summary>
    public unsafe int EditorLODSetting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ArrayProperty: LODSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LODSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: particleDistanceCullMul
    /// </summary>
    public unsafe float particleDistanceCullMul
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// FloatProperty: particleDistanceCullFarMul
    /// </summary>
    public unsafe float particleDistanceCullFarMul
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StructProperty: FixedRelativeBoundingBox
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FixedRelativeBoundingBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// FloatProperty: SecondsBeforeInactive
    /// </summary>
    public unsafe float SecondsBeforeInactive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// StrProperty: FloorMesh
    /// </summary>
    public unsafe BmSDK.FString FloorMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StructProperty: FloorPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FloorPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StructProperty: FloorRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FloorRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: FloorScale
    /// </summary>
    public unsafe float FloorScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// StructProperty: FloorScale3D
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FloorScale3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// StructProperty: BackgroundColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BackgroundColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// FloatProperty: Delay
    /// </summary>
    public unsafe float Delay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// FloatProperty: DelayLow
    /// </summary>
    public unsafe float DelayLow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StructProperty: MacroUVPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MacroUVPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// FloatProperty: MacroUVRadius
    /// </summary>
    public unsafe float MacroUVRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// StructProperty: CustomOcclusionBounds
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CustomOcclusionBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// ArrayProperty: SoloTracking
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SoloTracking
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// Enum: EParticleSystemUpdateMode
    /// </summary>
    public enum EParticleSystemUpdateMode
    {
        EPSUM_RealTime = 0,
        EPSUM_FixedTime = 1,
        EPSUM_MAX = 2,
    }
}
