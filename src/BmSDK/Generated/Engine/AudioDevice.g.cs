#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AudioDevice<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AudioDevice : BmSDK.Subsystem, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AudioDevice", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AudioDevice() { }

    /// <summary>
    /// Constructs a new AudioDevice
    /// </summary>
    public AudioDevice(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AudioDevice Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AudioDevice(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: MaxChannels
    /// </summary>
    public unsafe int MaxChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// IntProperty: CommonAudioPoolSize
    /// </summary>
    public unsafe int CommonAudioPoolSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: LowPassFilterResonance
    /// </summary>
    public unsafe float LowPassFilterResonance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: MinCompressedDurationEditor
    /// </summary>
    public unsafe float MinCompressedDurationEditor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: MinCompressedDurationGame
    /// </summary>
    public unsafe float MinCompressedDurationGame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// StrProperty: ChirpInSoundNodeWaveName
    /// </summary>
    public unsafe BmSDK.FString ChirpInSoundNodeWaveName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ObjectProperty: ChirpInSoundNodeWave
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChirpInSoundNodeWave
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ObjectProperty: ChirpOutSoundNodeWave
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChirpOutSoundNodeWave
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ComponentProperty: TestAudioComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TestAudioComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// StrProperty: ChirpOutSoundNodeWaveName
    /// </summary>
    public unsafe BmSDK.FString ChirpOutSoundNodeWaveName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// StructProperty: CommonAudioPool
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CommonAudioPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// IntProperty: CommonAudioPoolFreeBytes
    /// </summary>
    public unsafe int CommonAudioPoolFreeBytes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ArrayProperty: AudioComponents
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT AudioComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: Sources
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Sources
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ArrayProperty: FreeSources
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT FreeSources
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// MapProperty: WaveInstanceSourceMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ WaveInstanceSourceMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// BoolProperty: bGameWasTicking
    /// </summary>
    public unsafe bool bGameWasTicking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: DialogueOcclusionEnabled
    /// </summary>
    public unsafe bool DialogueOcclusionEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: SFXOcclusionEnabled
    /// </summary>
    public unsafe bool SFXOcclusionEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: CompressorEnabled
    /// </summary>
    public unsafe bool CompressorEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: bSoundSpawningEnabled
    /// </summary>
    public unsafe bool bSoundSpawningEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// ArrayProperty: Listeners
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Listeners
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StructProperty: CurrentTick
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentTick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StructProperty: Effects
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Effects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// StructProperty: TextToSpeech
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TextToSpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// ByteProperty: DebugState
    /// </summary>
    public unsafe byte DebugState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// FloatProperty: TransientMasterVolume
    /// </summary>
    public unsafe float TransientMasterVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// FloatProperty: DialogueOcclusionExample
    /// </summary>
    public unsafe float DialogueOcclusionExample
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: DialogueOcclusionReverbExample
    /// </summary>
    public unsafe float DialogueOcclusionReverbExample
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: SFXOcclusionExample
    /// </summary>
    public unsafe float SFXOcclusionExample
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: SFXOcclusionReverbExample
    /// </summary>
    public unsafe float SFXOcclusionReverbExample
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// FloatProperty: CompressorAttack
    /// </summary>
    public unsafe float CompressorAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// FloatProperty: CompressorRelease
    /// </summary>
    public unsafe float CompressorRelease
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// FloatProperty: CompressorThreshold
    /// </summary>
    public unsafe float CompressorThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: CompressorGain
    /// </summary>
    public unsafe float CompressorGain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// FloatProperty: OccStartValueM
    /// </summary>
    public unsafe float OccStartValueM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// FloatProperty: OccFloor
    /// </summary>
    public unsafe float OccFloor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// FloatProperty: OccDistanceFloor
    /// </summary>
    public unsafe float OccDistanceFloor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// FloatProperty: OccLerp
    /// </summary>
    public unsafe float OccLerp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// FloatProperty: OccSlowLerp
    /// </summary>
    public unsafe float OccSlowLerp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// FloatProperty: OccDistanceLerp
    /// </summary>
    public unsafe float OccDistanceLerp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: OccUncontestedFloor
    /// </summary>
    public unsafe float OccUncontestedFloor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: OccCloseMin
    /// </summary>
    public unsafe float OccCloseMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// FloatProperty: OccCloseMax
    /// </summary>
    public unsafe float OccCloseMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// FloatProperty: OccCloseMinPercent
    /// </summary>
    public unsafe float OccCloseMinPercent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// FloatProperty: LastUpdateTime
    /// </summary>
    public unsafe float LastUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// Struct: FListener
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FListener
    {
        /// <summary>
        /// ObjectProperty: PortalVolume
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PortalVolume
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: Up
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Up
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StructProperty: Right
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Right
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: Front
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Front
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StructProperty: Velocity
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Velocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// StructProperty: MicLocation
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MicLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: FOV
        /// </summary>
        public unsafe float FOV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: ZoomMagnification
        /// </summary>
        public unsafe float ZoomMagnification
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }
    }

    /// <summary>
    /// Enum: ETTSSpeaker
    /// </summary>
    public enum ETTSSpeaker
    {
        TTSSPEAKER_Paul = 0,
        TTSSPEAKER_Harry = 1,
        TTSSPEAKER_Frank = 2,
        TTSSPEAKER_Dennis = 3,
        TTSSPEAKER_Kit = 4,
        TTSSPEAKER_Betty = 5,
        TTSSPEAKER_Ursula = 6,
        TTSSPEAKER_Rita = 7,
        TTSSPEAKER_Wendy = 8,
        TTSSPEAKER_MAX = 9,
    }

    /// <summary>
    /// Enum: EDebugState
    /// </summary>
    public enum EDebugState
    {
        DEBUGSTATE_None = 0,
        DEBUGSTATE_IsolateDryAudio = 1,
        DEBUGSTATE_IsolateReverb = 2,
        DEBUGSTATE_TestLPF = 3,
        DEBUGSTATE_TestStereoBleed = 4,
        DEBUGSTATE_TestLFEBleed = 5,
        DEBUGSTATE_DisableLPF = 6,
        DEBUGSTATE_DisableRadio = 7,
        DEBUGSTATE_MAX = 8,
    }

    /// <summary>
    /// Enum: ESoundClassName
    /// </summary>
    public enum ESoundClassName
    {
        Master = 0,
        ESoundClassName_MAX = 1,
    }
}
