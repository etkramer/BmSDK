#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPoseConfig<br/>
/// (size = 68)
/// (flags = 134217874)
/// </summary>
public partial class RPoseConfig : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPoseConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPoseConfig() { }

    /// <summary>
    /// Constructs a new RPoseConfig
    /// </summary>
    public RPoseConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPoseConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPoseConfig(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPoseConfig>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPoseConfig>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPoseConfig>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPoseConfig>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPoseConfig>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPoseConfig>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPoseConfig>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPoseConfig>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: AddTransitionRelaxed
    /// </summary>
    public unsafe virtual void AddTransitionRelaxed(BmSDK.FName MovementStanceA, BmSDK.FName MovementStanceB, BmSDK.FName FullBodyAnim, BmSDK.FName TransitionName = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPoseConfig.AddTransitionRelaxed", true);
        byte* paramsPtr = stackalloc byte[168];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStanceA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStanceB, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FullBodyAnim, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddPoseRelaxed
    /// </summary>
    public unsafe virtual void AddPoseRelaxed(BmSDK.FName MovementStance, BmSDK.FName IdleFullBodyAnim, BmSDK.BmGame.RAimingConfig IdleAimingConfig = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPoseConfig.AddPoseRelaxed", true);
        byte* paramsPtr = stackalloc byte[360];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdleFullBodyAnim, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdleAimingConfig, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddPose
    /// </summary>
    public unsafe virtual void AddPose(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, BmSDK.FName IdleFullBodyAnim, BmSDK.BmGame.RAimingConfig IdleAimingConfig = default, bool AllowTurningToAim = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPoseConfig.AddPose", true);
        byte* paramsPtr = stackalloc byte[372];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdleFullBodyAnim, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdleAimingConfig, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowTurningToAim, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FTransition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public partial record struct FTransition
    {
        /// <summary>
        /// NameProperty: Name
        /// </summary>
        public unsafe BmSDK.FName Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: MovementStanceA
        /// </summary>
        public unsafe BmSDK.FName MovementStanceA
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: MovementStanceB
        /// </summary>
        public unsafe BmSDK.FName MovementStanceB
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// NameProperty: WeaponStanceA
        /// </summary>
        public unsafe BmSDK.FName WeaponStanceA
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// NameProperty: WeaponStanceB
        /// </summary>
        public unsafe BmSDK.FName WeaponStanceB
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// NameProperty: IdleStanceA
        /// </summary>
        public unsafe BmSDK.FName IdleStanceA
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// NameProperty: IdleStanceB
        /// </summary>
        public unsafe BmSDK.FName IdleStanceB
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ByteProperty: MirroredA
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.EMirroredYesNoMaybe MirroredA
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMirroredYesNoMaybe>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// ByteProperty: MirroredB
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.EMirroredYesNoMaybe MirroredB
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMirroredYesNoMaybe>(Ptr + 57); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 57); }; }
        }

        /// <summary>
        /// StructProperty: A2B
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FAnimConfig A2B
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FAnimConfig>((IntPtr)thisPtr + 60); } }
        }

        /// <summary>
        /// StructProperty: B2A
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FAnimConfig B2A
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FAnimConfig>((IntPtr)thisPtr + 96); } }
        }

        /// <summary>
        /// BoolProperty: Additive
        /// </summary>
        public unsafe bool Additive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }; }
        }

        /// <summary>
        /// BoolProperty: AllowTurningToAim
        /// </summary>
        public unsafe bool AllowTurningToAim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }; }
        }
    }

    /// <summary>
    /// Enum: EMirroredYesNoMaybe
    /// </summary>
    public enum EMirroredYesNoMaybe
    {
        MYNM_No = 0,
        MYNM_Yes = 1,
        MYNM_Maybe = 2,
        MYNM_MAX = 3,
    }

    /// <summary>
    /// ArrayProperty: Poses
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPoseConfig.FPose> Poses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPoseConfig.FPose>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: Transitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPoseConfig.FTransition> Transitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPoseConfig.FTransition>>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// Struct: FPose
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 340)]
    public partial record struct FPose
    {
        /// <summary>
        /// NameProperty: MovementStance
        /// </summary>
        public unsafe BmSDK.FName MovementStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: WeaponStance
        /// </summary>
        public unsafe BmSDK.FName WeaponStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: IdleStance
        /// </summary>
        public unsafe BmSDK.FName IdleStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: Idle
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FAnimConfig Idle
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FAnimConfig>((IntPtr)thisPtr + 24); } }
        }

        /// <summary>
        /// StructProperty: AdditiveIdle
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FAdditiveAnimConfig AdditiveIdle
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FAdditiveAnimConfig>((IntPtr)thisPtr + 60); } }
        }

        /// <summary>
        /// BoolProperty: AllowTurningToAim
        /// </summary>
        public unsafe bool AllowTurningToAim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: AllowIndependentAiming
        /// </summary>
        public unsafe bool AllowIndependentAiming
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: AllowCatchUpToAimAtWhileTurning
        /// </summary>
        public unsafe bool AllowCatchUpToAimAtWhileTurning
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: UseAlternativeMovementTransitionDurations
        /// </summary>
        public unsafe bool UseAlternativeMovementTransitionDurations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// ByteProperty: AllowAutomaticMirroring
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.EYesNoDefault AllowAutomaticMirroring
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.EYesNoDefault>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// ArrayProperty: Overlays
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RPoseConfig.FOverlayDescription> Overlays
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPoseConfig.FOverlayDescription>>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// StructProperty: Movement
        /// </summary>
        public unsafe ref BmSDK.BmGame.RPoseConfig.FMovement Movement
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPoseConfig.FMovement>((IntPtr)thisPtr + 104); } }
        }

        /// <summary>
        /// ArrayProperty: AdditiveAnims
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RPoseConfig.FAdditiveDescription> AdditiveAnims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPoseConfig.FAdditiveDescription>>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }

        /// <summary>
        /// StructProperty: RandomIdleOverlays
        /// </summary>
        public unsafe ref BmSDK.BmGame.RPoseConfig.FRandomIdleOverlays RandomIdleOverlays
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPoseConfig.FRandomIdleOverlays>((IntPtr)thisPtr + 208); } }
        }

        /// <summary>
        /// StructProperty: LegYawConfig
        /// </summary>
        public unsafe ref BmSDK.BmGame.RPoseConfig.FChaserConfig LegYawConfig
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPoseConfig.FChaserConfig>((IntPtr)thisPtr + 220); } }
        }

        /// <summary>
        /// StructProperty: RunLegYawConfig
        /// </summary>
        public unsafe ref BmSDK.BmGame.RPoseConfig.FChaserConfig RunLegYawConfig
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPoseConfig.FChaserConfig>((IntPtr)thisPtr + 232); } }
        }

        /// <summary>
        /// StructProperty: LegDirectionConfig
        /// </summary>
        public unsafe ref BmSDK.BmGame.RPoseConfig.FChaserConfig LegDirectionConfig
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPoseConfig.FChaserConfig>((IntPtr)thisPtr + 244); } }
        }

        /// <summary>
        /// StructProperty: AimAtTiming
        /// </summary>
        public unsafe ref BmSDK.BmGame.RPoseConfig.FAimingTransitionTiming AimAtTiming
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPoseConfig.FAimingTransitionTiming>((IntPtr)thisPtr + 256); } }
        }

        /// <summary>
        /// StructProperty: LookAtTiming
        /// </summary>
        public unsafe ref BmSDK.BmGame.RPoseConfig.FAimingTransitionTiming LookAtTiming
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPoseConfig.FAimingTransitionTiming>((IntPtr)thisPtr + 268); } }
        }

        /// <summary>
        /// StructProperty: RootBoneTranslationOffset
        /// </summary>
        public unsafe ref System.Numerics.Vector3 RootBoneTranslationOffset
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 280); } }
        }

        /// <summary>
        /// StructProperty: FloorCorrection
        /// </summary>
        public unsafe ref BmSDK.BmGame.RGameInfo.FFloorCorrectionConfig FloorCorrection
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FFloorCorrectionConfig>((IntPtr)thisPtr + 292); } }
        }

        /// <summary>
        /// BoolProperty: IdleMirrordnessMatchesFootStepPhase
        /// </summary>
        public unsafe bool IdleMirrordnessMatchesFootStepPhase
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }; }
        }

        /// <summary>
        /// BoolProperty: ForceTurnsAtLowSpeedScale
        /// </summary>
        public unsafe bool ForceTurnsAtLowSpeedScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }; }
        }

        /// <summary>
        /// BoolProperty: FallAnimDoesntConsumeMotionWeight
        /// </summary>
        public unsafe bool FallAnimDoesntConsumeMotionWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }; }
        }
    }

    /// <summary>
    /// Struct: FAimingTransitionTiming
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FAimingTransitionTiming
    {
        /// <summary>
        /// FloatProperty: InDuration
        /// </summary>
        public unsafe float InDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: OutDuration
        /// </summary>
        public unsafe float OutDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: SpringStrength
        /// </summary>
        public unsafe float SpringStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FChaserConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FChaserConfig
    {
        /// <summary>
        /// FloatProperty: Strength
        /// </summary>
        public unsafe float Strength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxVelocity
        /// </summary>
        public unsafe float MaxVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: MaxAccel
        /// </summary>
        public unsafe float MaxAccel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FMoveToConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FMoveToConfig
    {
        /// <summary>
        /// FloatProperty: DecelDistance
        /// </summary>
        public unsafe float DecelDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FTurnConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FTurnConfig
    {
        /// <summary>
        /// FloatProperty: AllowedToTurnUnderSpeed
        /// </summary>
        public unsafe float AllowedToTurnUnderSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: AllowedToStopOverSpeed
        /// </summary>
        public unsafe float AllowedToStopOverSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: FaceAtTurnThreshold
        /// </summary>
        public unsafe float FaceAtTurnThreshold
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: AimAtTurnThreshold
        /// </summary>
        public unsafe float AimAtTurnThreshold
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: TurnCancelThreshold
        /// </summary>
        public unsafe float TurnCancelThreshold
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: MinAutomaticTurnDuration
        /// </summary>
        public unsafe float MinAutomaticTurnDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: MaxAutomaticTurnDuration
        /// </summary>
        public unsafe float MaxAutomaticTurnDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FRandomIdleOverlays
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FRandomIdleOverlays
    {
        /// <summary>
        /// ObjectProperty: AnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet AnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MinTime
        /// </summary>
        public unsafe float MinTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: MaxTime
        /// </summary>
        public unsafe float MaxTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FAdditiveDescription
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FAdditiveDescription
    {
        /// <summary>
        /// NameProperty: Add
        /// </summary>
        public unsafe BmSDK.FName Add
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: Subtract
        /// </summary>
        public unsafe BmSDK.FName Subtract
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FOverlayDescription
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FOverlayDescription
    {
        /// <summary>
        /// NameProperty: Name
        /// </summary>
        public unsafe BmSDK.FName Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Anims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FAnimConfig Anims
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FAnimConfig>((IntPtr)thisPtr + 8); } }
        }
    }

    /// <summary>
    /// Struct: FMovement
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public partial record struct FMovement
    {
        /// <summary>
        /// ArrayProperty: Anims
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RPoseConfig.FMovementAnim> Anims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPoseConfig.FMovementAnim>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Fall
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FAnimConfig Fall
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FAnimConfig>((IntPtr)thisPtr + 12); } }
        }

        /// <summary>
        /// StructProperty: Land
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FAnimConfig Land
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FAnimConfig>((IntPtr)thisPtr + 48); } }
        }

        /// <summary>
        /// ByteProperty: Style
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.EMovementStyle Style
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementStyle>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// ObjectProperty: AnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet AnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }
    }

    /// <summary>
    /// Enum: EMovementStyle
    /// </summary>
    public enum EMovementStyle
    {
        MTS_Yaw = 0,
        MTS_Direction = 1,
        MTS_DirectionFromFaceAt = 2,
        MTS_MAX = 3,
    }

    /// <summary>
    /// Struct: FMovementAnim
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public partial record struct FMovementAnim
    {
        /// <summary>
        /// ByteProperty: Speed
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.EMovementSpeed Speed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementSpeed>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Anims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FAnimConfig Anims
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FAnimConfig>((IntPtr)thisPtr + 4); } }
        }

        /// <summary>
        /// StructProperty: LeftAnims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FAnimConfig LeftAnims
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FAnimConfig>((IntPtr)thisPtr + 40); } }
        }

        /// <summary>
        /// StructProperty: RightAnims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FAnimConfig RightAnims
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FAnimConfig>((IntPtr)thisPtr + 76); } }
        }

        /// <summary>
        /// FloatProperty: LeftRightYawAngle
        /// </summary>
        public unsafe float LeftRightYawAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// BoolProperty: Optional
        /// </summary>
        public unsafe bool Optional
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }; }
        }
    }

    /// <summary>
    /// Enum: EMovementSpeed
    /// </summary>
    public enum EMovementSpeed
    {
        MS_WalkSlow = 0,
        MS_Walk = 1,
        MS_Run = 2,
        MS_Sprint = 3,
        MS_MAX = 4,
    }
}
