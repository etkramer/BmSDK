#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RAnimZip_Settings<br/>
/// (size = 404)
/// (flags = 134221970)
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

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimZip_Settings>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimZip_Settings>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimZip_Settings>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimZip_Settings>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimZip_Settings>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimZip_Settings>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimZip_Settings>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimZip_Settings>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// FloatProperty: CompressionAmount
    /// </summary>
    public unsafe float CompressionAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: StripTracksIfSameAsReferencePose
    /// </summary>
    public unsafe bool StripTracksIfSameAsReferencePose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: EnableAdaptiveDownsample
    /// </summary>
    public unsafe bool EnableAdaptiveDownsample
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: ForceDownsample_Enabled
    /// </summary>
    public unsafe bool ForceDownsample_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: EnableAdaptiveDownsampleEnergy
    /// </summary>
    public unsafe bool EnableAdaptiveDownsampleEnergy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: EnableRotationRetargeting
    /// </summary>
    public unsafe bool EnableRotationRetargeting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: ForceRotationCodec_Enabled
    /// </summary>
    public unsafe bool ForceRotationCodec_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: ForceTranslationScaleCodec_Enabled
    /// </summary>
    public unsafe bool ForceTranslationScaleCodec_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: EnableCharacterOptimisations
    /// </summary>
    public unsafe bool EnableCharacterOptimisations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: EnableCapeOptimisations
    /// </summary>
    public unsafe bool EnableCapeOptimisations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: Log
    /// </summary>
    public unsafe bool Log
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// ArrayProperty: AdaptiveDownsampleDivisors
    /// </summary>
    public unsafe BmSDK.TArray<int> AdaptiveDownsampleDivisors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// ArrayProperty: AdaptiveDownsampleNumbers
    /// </summary>
    public unsafe BmSDK.TArray<int> AdaptiveDownsampleNumbers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// FloatProperty: ForceDownsample
    /// </summary>
    public unsafe float ForceDownsample
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// FloatProperty: AdaptiveDownsampleEnergyLowScale
    /// </summary>
    public unsafe float AdaptiveDownsampleEnergyLowScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// FloatProperty: AdaptiveDownsampleEnergyHighScale
    /// </summary>
    public unsafe float AdaptiveDownsampleEnergyHighScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: AdaptiveDownsampleEnergyPower
    /// </summary>
    public unsafe float AdaptiveDownsampleEnergyPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// StructProperty: DefaultTrackSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings DefaultTrackSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 92);

    /// <summary>
    /// ArrayProperty: ForcedTrackSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RAnimZip_Settings.FAnimZipNamedTrackSettings> ForcedTrackSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RAnimZip_Settings.FAnimZipNamedTrackSettings>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// StructProperty: MotionTrackSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings MotionTrackSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 120);

    /// <summary>
    /// ByteProperty: ForceRotationCodec
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.EAnimZipRotationCodec ForceRotationCodec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.EAnimZipRotationCodec>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ByteProperty: ForceTranslationScaleCodec
    /// </summary>
    public unsafe BmSDK.Engine.RAnimZip_Settings.EAnimZipTranslationScaleCodec ForceTranslationScaleCodec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAnimZip_Settings.EAnimZipTranslationScaleCodec>(Ptr + 137); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 137); }
    }

    /// <summary>
    /// ArrayProperty: DisableRotationCodecs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RAnimZip_Settings.EAnimZipRotationCodec> DisableRotationCodecs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RAnimZip_Settings.EAnimZipRotationCodec>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: DisableTranslationScaleCodecs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RAnimZip_Settings.EAnimZipTranslationScaleCodec> DisableTranslationScaleCodecs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RAnimZip_Settings.EAnimZipTranslationScaleCodec>>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// StructProperty: CharacterTrackSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 164);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Bip01
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Bip01
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 180);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Pelvis
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Pelvis
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 196);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Spine
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Spine
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 212);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Face
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Face
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 228);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Head
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Head
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 244);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Clavicle
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Clavicle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 260);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Arm
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Arm
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 276);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Hand
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Hand
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 292);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Finger
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Finger
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 308);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Gundummy
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Gundummy
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 324);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Leg
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Leg
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 340);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Foot
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Foot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 356);

    /// <summary>
    /// StructProperty: CharacterTrackSettings_Toe
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CharacterTrackSettings_Toe
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 372);

    /// <summary>
    /// StructProperty: CapeTrackSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings CapeTrackSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAnimZip_Settings.FAnimZipTrackSettings>(Ptr + 388);

    /// <summary>
    /// Struct: FAnimZipNamedTrackSettings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
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
    [StructLayout(LayoutKind.Explicit, Size = 16)]
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
    [StructLayout(LayoutKind.Explicit, Size = 12)]
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
        AZP_Custom = 5,
        AZP_MAX = 6,
    }
}
