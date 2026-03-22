#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleBeamNoise<br/>
/// (size = 228)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleBeamNoise : BmSDK.Engine.ParticleModuleBeamBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleBeamNoise", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleBeamNoise() { }

    /// <summary>
    /// Constructs a new ParticleModuleBeamNoise
    /// </summary>
    public ParticleModuleBeamNoise(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleBeamNoise Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleBeamNoise(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bLowFreq_Enabled
    /// </summary>
    public unsafe bool bLowFreq_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bNRScaleEmitterTime
    /// </summary>
    public unsafe bool bNRScaleEmitterTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bSmooth
    /// </summary>
    public unsafe bool bSmooth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bNoiseLock
    /// </summary>
    public unsafe bool bNoiseLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bOscillate
    /// </summary>
    public unsafe bool bOscillate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bUseNoiseTangents
    /// </summary>
    public unsafe bool bUseNoiseTangents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bTargetNoise
    /// </summary>
    public unsafe bool bTargetNoise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bApplyNoiseScale
    /// </summary>
    public unsafe bool bApplyNoiseScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// IntProperty: Frequency
    /// </summary>
    public unsafe int Frequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// IntProperty: Frequency_LowRange
    /// </summary>
    public unsafe int Frequency_LowRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// StructProperty: NoiseRange
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector NoiseRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// StructProperty: NoiseRangeScale
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat NoiseRangeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: NoiseSpeed
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector NoiseSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: NoiseLockRadius
    /// </summary>
    public unsafe float NoiseLockRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: NoiseLockTime
    /// </summary>
    public unsafe float NoiseLockTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: NoiseTension
    /// </summary>
    public unsafe float NoiseTension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// StructProperty: NoiseTangentStrength
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat NoiseTangentStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// IntProperty: NoiseTessellation
    /// </summary>
    public unsafe int NoiseTessellation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// FloatProperty: FrequencyDistance
    /// </summary>
    public unsafe float FrequencyDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StructProperty: NoiseScale
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat NoiseScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }
}
