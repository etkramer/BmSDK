#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimationCompressionAlgorithm_PerTrackCompression<br/>
/// (flags = 0)
/// </summary>
public partial class AnimationCompressionAlgorithm_PerTrackCompression : BmSDK.Engine.AnimationCompressionAlgorithm_RemoveLinearKeys, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimationCompressionAlgorithm_PerTrackCompression", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimationCompressionAlgorithm_PerTrackCompression() { }

    /// <summary>
    /// Constructs a new AnimationCompressionAlgorithm_PerTrackCompression
    /// </summary>
    public AnimationCompressionAlgorithm_PerTrackCompression(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimationCompressionAlgorithm_PerTrackCompression Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimationCompressionAlgorithm_PerTrackCompression(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: MaxZeroingThreshold
    /// </summary>
    public unsafe float MaxZeroingThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: MaxPosDiffBitwise
    /// </summary>
    public unsafe float MaxPosDiffBitwise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: MaxAngleDiffBitwise
    /// </summary>
    public unsafe float MaxAngleDiffBitwise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ArrayProperty: AllowedRotationFormats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSequence.AnimationCompressionFormat> AllowedRotationFormats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSequence.AnimationCompressionFormat>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: AllowedTranslationFormats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSequence.AnimationCompressionFormat> AllowedTranslationFormats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSequence.AnimationCompressionFormat>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bResampleAnimation
    /// </summary>
    public unsafe bool bResampleAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bUseAdaptiveError
    /// </summary>
    public unsafe bool bUseAdaptiveError
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bUseOverrideForEndEffectors
    /// </summary>
    public unsafe bool bUseOverrideForEndEffectors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bUseAdaptiveError2
    /// </summary>
    public unsafe bool bUseAdaptiveError2
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// FloatProperty: ResampledFramerate
    /// </summary>
    public unsafe float ResampledFramerate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// IntProperty: MinKeysForResampling
    /// </summary>
    public unsafe int MinKeysForResampling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// IntProperty: TrackHeightBias
    /// </summary>
    public unsafe int TrackHeightBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// FloatProperty: ParentingDivisor
    /// </summary>
    public unsafe float ParentingDivisor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// FloatProperty: ParentingDivisorExponent
    /// </summary>
    public unsafe float ParentingDivisorExponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: RotationErrorSourceRatio
    /// </summary>
    public unsafe float RotationErrorSourceRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// FloatProperty: TranslationErrorSourceRatio
    /// </summary>
    public unsafe float TranslationErrorSourceRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: MaxErrorPerTrackRatio
    /// </summary>
    public unsafe float MaxErrorPerTrackRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// FloatProperty: PerturbationProbeSize
    /// </summary>
    public unsafe float PerturbationProbeSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// StructProperty: PerReductionCachedData
    /// </summary>
    public unsafe System.IntPtr PerReductionCachedData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
}
