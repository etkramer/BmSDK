#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleBeamNoise<br/>
/// (size = 0)
/// (flags = 0)
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bNRScaleEmitterTime
    /// </summary>
    public unsafe bool bNRScaleEmitterTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bSmooth
    /// </summary>
    public unsafe bool bSmooth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bNoiseLock
    /// </summary>
    public unsafe bool bNoiseLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bOscillate
    /// </summary>
    public unsafe bool bOscillate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bUseNoiseTangents
    /// </summary>
    public unsafe bool bUseNoiseTangents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bTargetNoise
    /// </summary>
    public unsafe bool bTargetNoise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bApplyNoiseScale
    /// </summary>
    public unsafe bool bApplyNoiseScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// IntProperty: Frequency
    /// </summary>
    public unsafe int Frequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: Frequency_LowRange
    /// </summary>
    public unsafe int Frequency_LowRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: NoiseRange
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleBeamNoise.NoiseRangeScale NoiseRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleBeamNoise.NoiseRangeScale>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// StructProperty: NoiseRangeScale
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleBeamNoise.NoiseSpeed NoiseRangeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleBeamNoise.NoiseSpeed>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: NoiseSpeed
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleBeamNoise.NoiseTangentStrength NoiseSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleBeamNoise.NoiseTangentStrength>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: NoiseLockRadius
    /// </summary>
    public unsafe float NoiseLockRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// FloatProperty: NoiseLockTime
    /// </summary>
    public unsafe float NoiseLockTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// FloatProperty: NoiseTension
    /// </summary>
    public unsafe float NoiseTension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// StructProperty: NoiseTangentStrength
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleBeamNoise.NoiseScale NoiseTangentStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleBeamNoise.NoiseScale>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// IntProperty: NoiseTessellation
    /// </summary>
    public unsafe int NoiseTessellation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// FloatProperty: FrequencyDistance
    /// </summary>
    public unsafe float FrequencyDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StructProperty: NoiseScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NoiseScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
}
