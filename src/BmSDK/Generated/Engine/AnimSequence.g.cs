#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimSequence<br/>
/// (flags = 0)
/// </summary>
public partial class AnimSequence : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimSequence", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimSequence() { }

    /// <summary>
    /// Constructs a new AnimSequence
    /// </summary>
    public AnimSequence(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimSequence Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimSequence(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: SequenceName
    /// </summary>
    public unsafe BmSDK.FName SequenceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: Notifies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSequence.FAnimNotifyEvent> Notifies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSequence.FAnimNotifyEvent>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: ReferencePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 ReferencePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: ReferencePointYaw
    /// </summary>
    public unsafe float ReferencePointYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// StructProperty: ReferencePointRotation
    /// </summary>
    public unsafe BmSDK.Rotator ReferencePointRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// NameProperty: PreviewReferencePointMeshName
    /// </summary>
    public unsafe BmSDK.FName PreviewReferencePointMeshName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ByteProperty: AudioStatus
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.EAnimAudioStatus AudioStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.EAnimAudioStatus>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ByteProperty: CombatStatus
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.EAnimAudioStatus CombatStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.EAnimAudioStatus>(Ptr + 145); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 145); }
    }

    /// <summary>
    /// ByteProperty: TranslationCompressionFormat
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.AnimationCompressionFormat TranslationCompressionFormat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.AnimationCompressionFormat>(Ptr + 146); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 146); }
    }

    /// <summary>
    /// ByteProperty: RotationCompressionFormat
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.AnimationCompressionFormat RotationCompressionFormat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.AnimationCompressionFormat>(Ptr + 147); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 147); }
    }

    /// <summary>
    /// ByteProperty: FaceFXBaseExpression
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.EFaceFXBaseExpression FaceFXBaseExpression
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.EFaceFXBaseExpression>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ByteProperty: FootSyncOut
    /// </summary>
    public unsafe BmSDK.Engine.RAutomaticTransitions.EFootSyncPoint FootSyncOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAutomaticTransitions.EFootSyncPoint>(Ptr + 149); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 149); }
    }

    /// <summary>
    /// ByteProperty: FootSyncOutSpeed
    /// </summary>
    public unsafe BmSDK.Engine.RAutomaticTransitions.EMovementSpeed FootSyncOutSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAutomaticTransitions.EMovementSpeed>(Ptr + 150); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 150); }
    }

    /// <summary>
    /// ByteProperty: FootSyncOutDirection
    /// </summary>
    public unsafe BmSDK.Engine.RAutomaticTransitions.EDirectionBlendGroup FootSyncOutDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAutomaticTransitions.EDirectionBlendGroup>(Ptr + 151); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 151); }
    }

    /// <summary>
    /// ByteProperty: Compression_Preset
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.EAnimZipPreset Compression_Preset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.EAnimZipPreset>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ByteProperty: KeyEncodingFormat
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.AnimationKeyFormat KeyEncodingFormat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.AnimationKeyFormat>(Ptr + 153); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 153); }
    }

    /// <summary>
    /// FloatProperty: SequenceLength
    /// </summary>
    public unsafe float SequenceLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// IntProperty: NumFrames
    /// </summary>
    public unsafe int NumFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// FloatProperty: RateScale
    /// </summary>
    public unsafe float RateScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// FloatProperty: RawFramerate
    /// </summary>
    public unsafe float RawFramerate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// FloatProperty: OverrideFramerate
    /// </summary>
    public unsafe float OverrideFramerate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: OverrideFramerate_Enabled
    /// </summary>
    public unsafe bool OverrideFramerate_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: AllowCheekyBlendIn
    /// </summary>
    public unsafe bool AllowCheekyBlendIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: AllowCheekyBlendOut
    /// </summary>
    public unsafe bool AllowCheekyBlendOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: AllowAdditiveTransitionBlendIn
    /// </summary>
    public unsafe bool AllowAdditiveTransitionBlendIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: AllowAdditiveTransitionBlendOut
    /// </summary>
    public unsafe bool AllowAdditiveTransitionBlendOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bUseSimpleForwardYaw
    /// </summary>
    public unsafe bool bUseSimpleForwardYaw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bUseSimpleFloorHeight
    /// </summary>
    public unsafe bool bUseSimpleFloorHeight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bUseSimpleRootMotionXY
    /// </summary>
    public unsafe bool bUseSimpleRootMotionXY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bInheritRootMotionFromVelocity
    /// </summary>
    public unsafe bool bInheritRootMotionFromVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: DisableProportionalMotionDuringBlendOut
    /// </summary>
    public unsafe bool DisableProportionalMotionDuringBlendOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: EmbeddedFaceFXAnim_AllowAutomaticBlinks
    /// </summary>
    public unsafe bool EmbeddedFaceFXAnim_AllowAutomaticBlinks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: FaceFXBaseExpression_Enabled
    /// </summary>
    public unsafe bool FaceFXBaseExpression_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: FaceOverlayHoldsLastFrame
    /// </summary>
    public unsafe bool FaceOverlayHoldsLastFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: IdleMatchEnabled
    /// </summary>
    public unsafe bool IdleMatchEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: DisableAutomaticBlinks
    /// </summary>
    public unsafe bool DisableAutomaticBlinks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: WeaponSwitchPointEnabled
    /// </summary>
    public unsafe bool WeaponSwitchPointEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: Compression_UseLinearInterpolation
    /// </summary>
    public unsafe bool Compression_UseLinearInterpolation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: Compression_ModelspaceGundummy
    /// </summary>
    public unsafe bool Compression_ModelspaceGundummy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: AnimZip_RelativeToReferencePose
    /// </summary>
    public unsafe bool AnimZip_RelativeToReferencePose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: AnimZip_IsPlaceholder
    /// </summary>
    public unsafe bool AnimZip_IsPlaceholder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: FootCyclesValid
    /// </summary>
    public unsafe bool FootCyclesValid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bDoNotOverrideCompression
    /// </summary>
    public unsafe bool bDoNotOverrideCompression
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenUsed
    /// </summary>
    public unsafe bool bHasBeenUsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bWasCompressedWithoutTranslations
    /// </summary>
    public unsafe bool bWasCompressedWithoutTranslations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: MetricWasRecorded
    /// </summary>
    public unsafe bool MetricWasRecorded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// ArrayProperty: RawAnimData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSequence.FRawAnimSequenceTrack> RawAnimData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSequence.FRawAnimSequenceTrack>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: RawAnimationData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSequence.FRawAnimSequenceTrack> RawAnimationData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSequence.FRawAnimSequenceTrack>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ArrayProperty: RawAnimationDataAfterFixup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSequence.FRawAnimSequenceTrack> RawAnimationDataAfterFixup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSequence.FRawAnimSequenceTrack>>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ArrayProperty: CameraFOV
    /// </summary>
    public unsafe BmSDK.TArray<float> CameraFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ArrayProperty: CurveData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSequence.FCurveTrack> CurveData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSequence.FCurveTrack>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ObjectProperty: CompressionScheme
    /// </summary>
    public unsafe BmSDK.Engine.AnimationCompressionAlgorithm CompressionScheme
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimationCompressionAlgorithm>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: EmbeddedFaceFXAnim
    /// </summary>
    public unsafe BmSDK.Engine.FaceFXAnimSet EmbeddedFaceFXAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FaceFXAnimSet>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ObjectProperty: FaceOverlayAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet FaceOverlayAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ObjectProperty: IdleMatchAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet IdleMatchAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ObjectProperty: AimingConfig
    /// </summary>
    public unsafe BmSDK.Engine.RAimingConfig AimingConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAimingConfig>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: Compression_CustomSettings
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings Compression_CustomSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ArrayProperty: CompressedTrackOffsets
    /// </summary>
    public unsafe BmSDK.TArray<int> CompressedTrackOffsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ArrayProperty: CompressedByteStream
    /// </summary>
    public unsafe BmSDK.TArray<byte> CompressedByteStream
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StrProperty: MaxFilePath
    /// </summary>
    public unsafe BmSDK.FString MaxFilePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// StrProperty: MaxAuthor
    /// </summary>
    public unsafe BmSDK.FString MaxAuthor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// StrProperty: RootSourceFilePath
    /// </summary>
    public unsafe BmSDK.FString RootSourceFilePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// StrProperty: SourceFilePath
    /// </summary>
    public unsafe BmSDK.FString SourceFilePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// StrProperty: SourceApplication
    /// </summary>
    public unsafe BmSDK.FString SourceApplication
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StrProperty: SourceFileTimestamp
    /// </summary>
    public unsafe BmSDK.FString SourceFileTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// StrProperty: SourceAuthor
    /// </summary>
    public unsafe BmSDK.FString SourceAuthor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// StrProperty: SourceRootBoneName
    /// </summary>
    public unsafe BmSDK.FString SourceRootBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// StrProperty: SourceTake
    /// </summary>
    public unsafe BmSDK.FString SourceTake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// StructProperty: ReferenceOptions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.FAnimReferencePeriods ReferenceOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.FAnimReferencePeriods>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// StructProperty: MotionOptions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.FAnimReferencePeriods MotionOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.FAnimReferencePeriods>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// StructProperty: CollisionOptions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.FAnimCollisionPeriods CollisionOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.FAnimCollisionPeriods>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// StructProperty: CollisionOptions2
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.FAnimCollisionOptions CollisionOptions2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.FAnimCollisionOptions>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: BlendInDuration
    /// </summary>
    public unsafe float BlendInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// FloatProperty: BlendOutDuration
    /// </summary>
    public unsafe float BlendOutDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// NameProperty: FaceOverlayAnimName
    /// </summary>
    public unsafe BmSDK.FName FaceOverlayAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// NameProperty: IdleMatchAnimName
    /// </summary>
    public unsafe BmSDK.FName IdleMatchAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ArrayProperty: CachedDialogue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSequence.FAnimCachedDialogue> CachedDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSequence.FAnimCachedDialogue>>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ArrayProperty: CachedDialogueWarnings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CachedDialogueWarnings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ArrayProperty: CachedDialogueErrors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CachedDialogueErrors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// StructProperty: AutoTriggeredDialogue
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.FAutoTriggeredDialogueStruct AutoTriggeredDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.FAutoTriggeredDialogueStruct>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// FloatProperty: BlendInPoint
    /// </summary>
    public unsafe float BlendInPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// FloatProperty: BlendOutPoint
    /// </summary>
    public unsafe float BlendOutPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// FloatProperty: ClippedStart
    /// </summary>
    public unsafe float ClippedStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// FloatProperty: ClippedLength
    /// </summary>
    public unsafe float ClippedLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// FloatProperty: CanCancelBeforeHerePoint
    /// </summary>
    public unsafe float CanCancelBeforeHerePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// FloatProperty: CanCancelAfterHerePoint
    /// </summary>
    public unsafe float CanCancelAfterHerePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// FloatProperty: CanCorrectAfterHerePoint
    /// </summary>
    public unsafe float CanCorrectAfterHerePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: RootBoneTranslationOffsetInPoint
    /// </summary>
    public unsafe float RootBoneTranslationOffsetInPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: RootBoneTranslationOffsetOutPoint
    /// </summary>
    public unsafe float RootBoneTranslationOffsetOutPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: WeaponSwitchPoint
    /// </summary>
    public unsafe float WeaponSwitchPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ArrayProperty: UpdateSequenceDependentVariableErrors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> UpdateSequenceDependentVariableErrors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ArrayProperty: AnimZip_Data
    /// </summary>
    public unsafe BmSDK.TArray<byte> AnimZip_Data
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// StructProperty: AnimZip_LinearMotion
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.FAnimLinearMotion AnimZip_LinearMotion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.FAnimLinearMotion>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ArrayProperty: AnimZip_Errors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> AnimZip_Errors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ArrayProperty: FootCycles
    /// </summary>
    public unsafe BmSDK.TArray<float> FootCycles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// StructProperty: TranslationCodec
    /// </summary>
    public unsafe System.IntPtr TranslationCodec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StructProperty: RotationCodec
    /// </summary>
    public unsafe System.IntPtr RotationCodec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// IntProperty: EncodingPkgVersion
    /// </summary>
    public unsafe int EncodingPkgVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: CompressCommandletVersion
    /// </summary>
    public unsafe int CompressCommandletVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// FloatProperty: UseScore
    /// </summary>
    public unsafe float UseScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// IntProperty: EditVersion
    /// </summary>
    public unsafe int EditVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// Struct: FRawAnimSequenceTrack
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRawAnimSequenceTrack
    {
        /// <summary>
        /// ArrayProperty: PosKeys
        /// </summary>
        public unsafe BmSDK.TArray<System.Numerics.Vector3> PosKeys
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: RotKeys
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.GameObject.FQuat> RotKeys
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FQuat>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: ScaleKeys
        /// </summary>
        public unsafe BmSDK.TArray<float> ScaleKeys
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ArrayProperty: PosMinusScaleKeys
        /// </summary>
        public unsafe BmSDK.TArray<System.Numerics.Vector3> PosMinusScaleKeys
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Struct: FAnimNotifyEvent
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FAnimNotifyEvent
    {
        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Notify
        /// </summary>
        public unsafe BmSDK.Engine.AnimNotify Notify
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNotify>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
