#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RAnimZip_Settings<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimZip_Settings : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RAnimZip_Settings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimZip_Settings() { }

    /// <summary>
    /// Constructs a new RAnimZip_Settings
    /// </summary>
    public RAnimZip_Settings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimZip_Settings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimZip_Settings(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: CompressionAmount
    /// </summary>
    public unsafe float CompressionAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: StripTracksIfSameAsReferencePose
    /// </summary>
    public unsafe bool StripTracksIfSameAsReferencePose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: EnableAdaptiveDownsample
    /// </summary>
    public unsafe bool EnableAdaptiveDownsample
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: ForceDownsample_Enabled
    /// </summary>
    public unsafe bool ForceDownsample_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: EnableAdaptiveDownsampleEnergy
    /// </summary>
    public unsafe bool EnableAdaptiveDownsampleEnergy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: EnableRotationRetargeting
    /// </summary>
    public unsafe bool EnableRotationRetargeting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: ForceRotationCodec_Enabled
    /// </summary>
    public unsafe bool ForceRotationCodec_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: ForceTranslationScaleCodec_Enabled
    /// </summary>
    public unsafe bool ForceTranslationScaleCodec_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: EnableCharacterOptimisations
    /// </summary>
    public unsafe bool EnableCharacterOptimisations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: EnableCapeOptimisations
    /// </summary>
    public unsafe bool EnableCapeOptimisations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: Log
    /// </summary>
    public unsafe bool Log
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// ArrayProperty: AdaptiveDownsampleDivisors
    /// </summary>
    public unsafe BmSDK.TArray<int> AdaptiveDownsampleDivisors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: AdaptiveDownsampleNumbers
    /// </summary>
    public unsafe BmSDK.TArray<int> AdaptiveDownsampleNumbers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: ForceDownsample
    /// </summary>
    public unsafe float ForceDownsample
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: AdaptiveDownsampleEnergyLowScale
    /// </summary>
    public unsafe float AdaptiveDownsampleEnergyLowScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: AdaptiveDownsampleEnergyHighScale
    /// </summary>
    public unsafe float AdaptiveDownsampleEnergyHighScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: AdaptiveDownsampleEnergyPower
    /// </summary>
    public unsafe float AdaptiveDownsampleEnergyPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// StructProperty: DefaultTrackSettings
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings DefaultTrackSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: ForcedTrackSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RAnimZip_Settings.FAnimZipNamedTrackSettings> ForcedTrackSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RAnimZip_Settings.FAnimZipNamedTrackSettings>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// StructProperty: MotionTrackSettings
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings MotionTrackSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ByteProperty: ForceRotationCodec
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.EAnimZipRotationCodec ForceRotationCodec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.EAnimZipRotationCodec>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ByteProperty: ForceTranslationScaleCodec
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.EAnimZipTranslationScaleCodec ForceTranslationScaleCodec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.EAnimZipTranslationScaleCodec>(Ptr + 189); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 189); }
    }

    /// <summary>
    /// ArrayProperty: DisableRotationCodecs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RAnimZip_Settings.EAnimZipRotationCodec> DisableRotationCodecs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RAnimZip_Settings.EAnimZipRotationCodec>>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ArrayProperty: DisableTranslationScaleCodecs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RAnimZip_Settings.EAnimZipTranslationScaleCodec> DisableTranslationScaleCodecs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RAnimZip_Settings.EAnimZipTranslationScaleCodec>>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Bip01
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Bip01
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Pelvis
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Pelvis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Spine
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Spine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Face
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Face
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Head
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Head
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Clavicle
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Clavicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Arm
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Arm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Hand
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Hand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Finger
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Finger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Gundummy
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Gundummy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Leg
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Leg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Foot
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Foot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Toe
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Toe
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// StructProperty: CapeTrackSettings
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CapeTrackSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// StructProperty: CameraTrackSettings
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CameraTrackSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// Struct: FAnimZipNamedTrackSettings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FAnimZipNamedTrackSettings
    {
        /// <summary>
        /// NameProperty: TrackName
        /// </summary>
        public unsafe BmSDK.FName TrackName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Settings
        /// </summary>
        public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings Settings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FAnimZipTrackSettings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FAnimZipTrackSettings
    {
        /// <summary>
        /// StructProperty: ErrorBounds
        /// </summary>
        public unsafe BmSDK.Engine.RAnimZip_Settings.FAnimZipErrorBounds ErrorBounds
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.FAnimZipErrorBounds>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: AllowRotationRetargeting
        /// </summary>
        public unsafe bool AllowRotationRetargeting
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FAnimZipErrorBounds
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FAnimZipErrorBounds
    {
        /// <summary>
        /// FloatProperty: Rotation
        /// </summary>
        public unsafe float Rotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Translation
        /// </summary>
        public unsafe float Translation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Scale
        /// </summary>
        public unsafe float Scale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EAnimZipTranslationScaleCodec
    /// </summary>
    public enum EAnimZipTranslationScaleCodec
    {
        AZTSC_Float = 0,
        AZTSC_NoScale_Float = 1,
        AZTSC_NoScale_Interval_Fixed = 2,
        AZTSC_NoScale_Interval_Fixed_2 = 3,
        AZTSC_MAX = 4,
    }

    /// <summary>
    /// Enum: EAnimZipRotationCodec
    /// </summary>
    public enum EAnimZipRotationCodec
    {
        AZRC_QuatMax = 0,
        AZRC_QuatMax_2 = 1,
        AZRC_QuatRelative = 2,
        AZRC_QuatRelative_2 = 3,
        AZRC_QuatRelative_3 = 4,
        AZRC_FixedAxis = 5,
        AZRC_FixedAxis_2 = 6,
        AZRC_MAX = 7,
    }

    /// <summary>
    /// Enum: EAnimZipPreset
    /// </summary>
    public enum EAnimZipPreset
    {
        AZP_Default = 0,
        AZP_Default50 = 1,
        AZP_Default25 = 2,
        AZP_Default10 = 3,
        AZP_AlmostNone = 4,
        AZP_Default200 = 5,
        AZP_Default500 = 6,
        AZP_Default1000 = 7,
        AZP_Custom = 8,
        AZP_MAX = 9,
    }
}
