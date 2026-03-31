#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RAnimUtil_PosePlayer<br/>
/// (size = 56)
/// (flags = 134217875)
/// </summary>
public partial class RAnimUtil_PosePlayer : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimUtil_PosePlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimUtil_PosePlayer() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimUtil_PosePlayer(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_PosePlayer>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_PosePlayer>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_PosePlayer>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_PosePlayer>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_PosePlayer>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_PosePlayer>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_PosePlayer>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_PosePlayer>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// DelegateProperty: __DummyOnPlayedQueuedTransition__Delegate
    /// </summary>
    public unsafe System.IntPtr __DummyOnPlayedQueuedTransition__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// Function: DummyOnPlayedQueuedTransition
    /// </summary>
    public unsafe virtual void DummyOnPlayedQueuedTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAnimUtil_PosePlayer.DummyOnPlayedQueuedTransition", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FPosePlayer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 932)]
    public partial record struct FPosePlayer
    {
        /// <summary>
        /// ArrayProperty: Changes
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChange> Changes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChange>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: CurrentWeapon
        /// </summary>
        public unsafe BmSDK.Engine.Inventory CurrentWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: PreviousWeapon
        /// </summary>
        public unsafe BmSDK.Engine.Inventory PreviousWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: LastTransitionId
        /// </summary>
        public unsafe int LastTransitionId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StructProperty: MoveToRequest
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToRequest MoveToRequest
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToRequest>((IntPtr)thisPtr + 24); } }
        }

        /// <summary>
        /// StructProperty: FaceAtRequest
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FFaceAtRequest FaceAtRequest
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FFaceAtRequest>((IntPtr)thisPtr + 72); } }
        }

        /// <summary>
        /// StructProperty: AimAtRequest
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtRequest AimAtRequest
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtRequest>((IntPtr)thisPtr + 112); } }
        }

        /// <summary>
        /// StructProperty: LookAtRequest
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FLookAtRequest LookAtRequest
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FLookAtRequest>((IntPtr)thisPtr + 180); } }
        }

        /// <summary>
        /// StructProperty: MoveToConfig
        /// </summary>
        public unsafe ref BmSDK.BmGame.RPoseConfig.FMoveToConfig MoveToConfig
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPoseConfig.FMoveToConfig>((IntPtr)thisPtr + 236); } }
        }

        /// <summary>
        /// StructProperty: AimAtState
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtState AimAtState
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtState>((IntPtr)thisPtr + 240); } }
        }

        /// <summary>
        /// StructProperty: LookAtState
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtState LookAtState
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtState>((IntPtr)thisPtr + 396); } }
        }

        /// <summary>
        /// StructProperty: MoveToState
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToState MoveToState
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToState>((IntPtr)thisPtr + 552); } }
        }

        /// <summary>
        /// FloatProperty: MoveToYawVelocityAppliedToRelativeTransition
        /// </summary>
        public unsafe float MoveToYawVelocityAppliedToRelativeTransition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 916); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }; }
        }

        /// <summary>
        /// StructProperty: Queue
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangeQueue Queue
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangeQueue>((IntPtr)thisPtr + 920); } }
        }
    }

    /// <summary>
    /// Struct: FStanceChangeQueue
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FStanceChangeQueue
    {
        /// <summary>
        /// ArrayProperty: Change
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChange> Change
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChange>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FStanceChange
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 3704)]
    public partial record struct FStanceChange
    {
        /// <summary>
        /// StructProperty: Pose
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangePose Pose
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangePose>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: PreviousPose
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangePreviousPose PreviousPose
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangePreviousPose>((IntPtr)thisPtr + 3144); } }
        }

        /// <summary>
        /// StructProperty: Transition
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangeTransition Transition
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangeTransition>((IntPtr)thisPtr + 3184); } }
        }

        /// <summary>
        /// StructProperty: Id
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>((IntPtr)thisPtr + 3512); } }
        }

        /// <summary>
        /// StructProperty: Time
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan Time
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan>((IntPtr)thisPtr + 3516); } }
        }

        /// <summary>
        /// StructProperty: DirectionalAnimState
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FDirectionalAnimState DirectionalAnimState
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FDirectionalAnimState>((IntPtr)thisPtr + 3528); } }
        }

        /// <summary>
        /// StructProperty: AdditiveStates
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAdditiveStates AdditiveStates
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAdditiveStates>((IntPtr)thisPtr + 3580); } }
        }

        /// <summary>
        /// StructProperty: IdleState
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FIdleState IdleState
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FIdleState>((IntPtr)thisPtr + 3616); } }
        }

        /// <summary>
        /// StructProperty: AdditiveIdleState
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAdditiveIdleState AdditiveIdleState
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAdditiveIdleState>((IntPtr)thisPtr + 3640); } }
        }

        /// <summary>
        /// StructProperty: Weight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FWeight Weight
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FWeight>((IntPtr)thisPtr + 3652); } }
        }

        /// <summary>
        /// StructProperty: WeightIgnoringBlendIn
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FWeight WeightIgnoringBlendIn
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FWeight>((IntPtr)thisPtr + 3656); } }
        }

        /// <summary>
        /// ObjectProperty: MatineeAnim
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence MatineeAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 3660); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3660); }; }
        }

        /// <summary>
        /// StructProperty: MatineeAnimTime
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan MatineeAnimTime
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan>((IntPtr)thisPtr + 3664); } }
        }

        /// <summary>
        /// StructProperty: MatineeMovementTargetPosition
        /// </summary>
        public unsafe ref System.Numerics.Vector3 MatineeMovementTargetPosition
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 3676); } }
        }

        /// <summary>
        /// StructProperty: MatineeMovementTargetRotation
        /// </summary>
        public unsafe ref BmSDK.Rotator MatineeMovementTargetRotation
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>((IntPtr)thisPtr + 3688); } }
        }

        /// <summary>
        /// BoolProperty: MatineeTeleport
        /// </summary>
        public unsafe bool MatineeTeleport
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3700) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3700); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3700); }; }
        }

        /// <summary>
        /// BoolProperty: MatineeAllowAutomaticTransitionOut
        /// </summary>
        public unsafe bool MatineeAllowAutomaticTransitionOut
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3700) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3700); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3700); }; }
        }

        /// <summary>
        /// BoolProperty: DisableTimeAdvanceForNumFrames
        /// </summary>
        public unsafe bool DisableTimeAdvanceForNumFrames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3700) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3700); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3700); }; }
        }
    }

    /// <summary>
    /// Struct: FAdditiveIdleState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FAdditiveIdleState
    {
        /// <summary>
        /// StructProperty: Time
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan Time
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan>((IntPtr)thisPtr + 0); } }
        }
    }

    /// <summary>
    /// Struct: FIdleState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FIdleState
    {
        /// <summary>
        /// StructProperty: Time
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan Time
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// FloatProperty: TimeScale
        /// </summary>
        public unsafe float TimeScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: RootBoneSubtractionMode
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.ERootBoneSubtractionMode RootBoneSubtractionMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.ERootBoneSubtractionMode>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: RootBoneExtraction
        /// </summary>
        public unsafe bool RootBoneExtraction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: IdleMirroredByFootPlacement
        /// </summary>
        public unsafe bool IdleMirroredByFootPlacement
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: Freeze
        /// </summary>
        public unsafe bool Freeze
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FStanceChangeTransition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 328)]
    public partial record struct FStanceChangeTransition
    {
        /// <summary>
        /// StructProperty: Input
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangeTransitionInput Input
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangeTransitionInput>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// ObjectProperty: PoseConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig PoseConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }; }
        }

        /// <summary>
        /// ObjectProperty: WeaponConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RWeaponConfig WeaponConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 228); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }; }
        }

        /// <summary>
        /// StructProperty: Anim
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FResolvedAnimConfig Anim
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FResolvedAnimConfig>((IntPtr)thisPtr + 232); } }
        }

        /// <summary>
        /// FloatProperty: MeetingPointBeginRotationYaw
        /// </summary>
        public unsafe float MeetingPointBeginRotationYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointBeginRotationPitch
        /// </summary>
        public unsafe float MeetingPointBeginRotationPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointBeginRotationRoll
        /// </summary>
        public unsafe float MeetingPointBeginRotationRoll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointEndRotationYaw
        /// </summary>
        public unsafe float MeetingPointEndRotationYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointEndRotationPitch
        /// </summary>
        public unsafe float MeetingPointEndRotationPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointEndRotationRoll
        /// </summary>
        public unsafe float MeetingPointEndRotationRoll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointBeginTranslationX
        /// </summary>
        public unsafe float MeetingPointBeginTranslationX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointBeginTranslationY
        /// </summary>
        public unsafe float MeetingPointBeginTranslationY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointBeginTranslationZ
        /// </summary>
        public unsafe float MeetingPointBeginTranslationZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 284); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointEndTranslationX
        /// </summary>
        public unsafe float MeetingPointEndTranslationX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointEndTranslationY
        /// </summary>
        public unsafe float MeetingPointEndTranslationY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 292); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointEndTranslationZ
        /// </summary>
        public unsafe float MeetingPointEndTranslationZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 296); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }; }
        }

        /// <summary>
        /// ByteProperty: FootSyncPoint
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.EFootSyncPoint FootSyncPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EFootSyncPoint>(Ptr + 300); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }; }
        }

        /// <summary>
        /// ByteProperty: BeginSpeed
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.EMovementSpeed BeginSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementSpeed>(Ptr + 301); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 301); }; }
        }

        /// <summary>
        /// ByteProperty: EndSpeed
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.EMovementSpeed EndSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementSpeed>(Ptr + 302); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 302); }; }
        }

        /// <summary>
        /// ByteProperty: AdditiveSubtractMode
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.EAdditiveSubtractMode AdditiveSubtractMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.EAdditiveSubtractMode>(Ptr + 303); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 303); }; }
        }

        /// <summary>
        /// FloatProperty: Duration
        /// </summary>
        public unsafe float Duration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 304); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }; }
        }

        /// <summary>
        /// FloatProperty: StartTime
        /// </summary>
        public unsafe float StartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 308); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }; }
        }

        /// <summary>
        /// BoolProperty: Mirrored
        /// </summary>
        public unsafe bool Mirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }; }
        }

        /// <summary>
        /// BoolProperty: Additive
        /// </summary>
        public unsafe bool Additive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }; }
        }

        /// <summary>
        /// BoolProperty: AllowTurningToAim
        /// </summary>
        public unsafe bool AllowTurningToAim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }; }
        }

        /// <summary>
        /// BoolProperty: CancelsMovement
        /// </summary>
        public unsafe bool CancelsMovement
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }; }
        }

        /// <summary>
        /// BoolProperty: CoversMovement
        /// </summary>
        public unsafe bool CoversMovement
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }; }
        }

        /// <summary>
        /// BoolProperty: AllowCheekyBlendIn
        /// </summary>
        public unsafe bool AllowCheekyBlendIn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }; }
        }

        /// <summary>
        /// BoolProperty: AllowCheekyBlendOut
        /// </summary>
        public unsafe bool AllowCheekyBlendOut
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }; }
        }

        /// <summary>
        /// FloatProperty: CanCancelBeforeHereTime
        /// </summary>
        public unsafe float CanCancelBeforeHereTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }; }
        }

        /// <summary>
        /// FloatProperty: CanCancelAfterHereTime
        /// </summary>
        public unsafe float CanCancelAfterHereTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }; }
        }

        /// <summary>
        /// FloatProperty: CanCorrectAfterHereTime
        /// </summary>
        public unsafe float CanCorrectAfterHereTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 324); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }; }
        }
    }

    /// <summary>
    /// Struct: FStanceChangePose
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 3144)]
    public partial record struct FStanceChangePose
    {
        /// <summary>
        /// StructProperty: Input
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangePoseInput Input
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangePoseInput>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// ObjectProperty: PoseConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig PoseConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// ObjectProperty: WeaponConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RWeaponConfig WeaponConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 124); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }; }
        }

        /// <summary>
        /// StructProperty: Pose
        /// </summary>
        public unsafe ref System.IntPtr Pose
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.IntPtr>((IntPtr)thisPtr + 128); } }
        }

        /// <summary>
        /// StructProperty: MovementAnims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedMovementAnims MovementAnims
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedMovementAnims>((IntPtr)thisPtr + 132); } }
        }

        /// <summary>
        /// StructProperty: IdleAnim
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FResolvedAnimConfig IdleAnim
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FResolvedAnimConfig>((IntPtr)thisPtr + 3076); } }
        }

        /// <summary>
        /// StructProperty: AdditiveIdleAnim
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FResolvedWeightedAdditiveAnimConfig AdditiveIdleAnim
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FResolvedWeightedAdditiveAnimConfig>((IntPtr)thisPtr + 3096); } }
        }

        /// <summary>
        /// BoolProperty: Falling
        /// </summary>
        public unsafe bool Falling
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3116) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3116); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3116); }; }
        }

        /// <summary>
        /// StructProperty: FallAnim
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FResolvedAnimConfig FallAnim
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FResolvedAnimConfig>((IntPtr)thisPtr + 3120); } }
        }

        /// <summary>
        /// BoolProperty: AllowTurningToAim
        /// </summary>
        public unsafe bool AllowTurningToAim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3140) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3140); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3140); }; }
        }
    }

    /// <summary>
    /// Struct: FAdditiveStates
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FAdditiveStates
    {
        /// <summary>
        /// StructProperty: States
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAdditiveState States_0
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAdditiveState>((IntPtr)thisPtr + 0); } }
        }
        /// <summary>
        /// StructProperty: States
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAdditiveState States_1
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAdditiveState>((IntPtr)thisPtr + 8); } }
        }
        /// <summary>
        /// StructProperty: States
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAdditiveState States_2
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAdditiveState>((IntPtr)thisPtr + 16); } }
        }
        /// <summary>
        /// StructProperty: States
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAdditiveState States_3
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAdditiveState>((IntPtr)thisPtr + 24); } }
        }

        /// <summary>
        /// FloatProperty: TotalWeight
        /// </summary>
        public unsafe float TotalWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FAdditiveState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FAdditiveState
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
        /// StructProperty: Weight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FWeight Weight
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FWeight>((IntPtr)thisPtr + 4); } }
        }
    }

    /// <summary>
    /// Struct: FStanceChangePreviousPose
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FStanceChangePreviousPose
    {
        /// <summary>
        /// StructProperty: Input
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangePreviousPoseInput Input
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FStanceChangePreviousPoseInput>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: Pose
        /// </summary>
        public unsafe ref System.IntPtr Pose
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.IntPtr>((IntPtr)thisPtr + 36); } }
        }
    }

    /// <summary>
    /// Struct: FResolvedMovementAnims
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 2944)]
    public partial record struct FResolvedMovementAnims
    {
        /// <summary>
        /// StructProperty: Forward
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedDirectionalMovementAnims Forward
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedDirectionalMovementAnims>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: Backward
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedDirectionalMovementAnims Backward
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedDirectionalMovementAnims>((IntPtr)thisPtr + 1472); } }
        }
    }

    /// <summary>
    /// Struct: FResolvedDirectionalMovementAnims
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 1472)]
    public partial record struct FResolvedDirectionalMovementAnims
    {
        /// <summary>
        /// StructProperty: Anims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedMovementAnim Anims_0
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedMovementAnim>((IntPtr)thisPtr + 0); } }
        }
        /// <summary>
        /// StructProperty: Anims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedMovementAnim Anims_1
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedMovementAnim>((IntPtr)thisPtr + 368); } }
        }
        /// <summary>
        /// StructProperty: Anims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedMovementAnim Anims_2
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedMovementAnim>((IntPtr)thisPtr + 736); } }
        }
        /// <summary>
        /// StructProperty: Anims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedMovementAnim Anims_3
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FResolvedMovementAnim>((IntPtr)thisPtr + 1104); } }
        }
    }

    /// <summary>
    /// Struct: FResolvedMovementAnim
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 368)]
    public partial record struct FResolvedMovementAnim
    {
        /// <summary>
        /// StructProperty: Anim
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FResolvedAnimConfig Anim
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FResolvedAnimConfig>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: Cycles
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FAnimCycles Cycles
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FAnimCycles>((IntPtr)thisPtr + 20); } }
        }

        /// <summary>
        /// FloatProperty: ActualSpeed
        /// </summary>
        public unsafe float ActualSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// StructProperty: LeftAnim
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FResolvedAnimConfig LeftAnim
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FResolvedAnimConfig>((IntPtr)thisPtr + 124); } }
        }

        /// <summary>
        /// StructProperty: LeftCycles
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FAnimCycles LeftCycles
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FAnimCycles>((IntPtr)thisPtr + 144); } }
        }

        /// <summary>
        /// StructProperty: RightAnim
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FResolvedAnimConfig RightAnim
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FResolvedAnimConfig>((IntPtr)thisPtr + 244); } }
        }

        /// <summary>
        /// StructProperty: RightCycles
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FAnimCycles RightCycles
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FAnimCycles>((IntPtr)thisPtr + 264); } }
        }

        /// <summary>
        /// FloatProperty: LeftRightYawAngle
        /// </summary>
        public unsafe float LeftRightYawAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 364); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }; }
        }
    }

    /// <summary>
    /// Struct: FMoveToState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 364)]
    public partial record struct FMoveToState
    {
        /// <summary>
        /// StructProperty: Transitions
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransitionArray Transitions
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransitionArray>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// FloatProperty: TargetFacingYaw
        /// </summary>
        public unsafe float TargetFacingYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 340); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }; }
        }

        /// <summary>
        /// FloatProperty: TargetExtractionYaw
        /// </summary>
        public unsafe float TargetExtractionYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }; }
        }

        /// <summary>
        /// FloatProperty: FacingYawVelocity
        /// </summary>
        public unsafe float FacingYawVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 348); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }; }
        }

        /// <summary>
        /// FloatProperty: BlendOutTimeRemaining
        /// </summary>
        public unsafe float BlendOutTimeRemaining
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 352); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }; }
        }

        /// <summary>
        /// StructProperty: Weight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FWeight Weight
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FWeight>((IntPtr)thisPtr + 356); } }
        }

        /// <summary>
        /// BoolProperty: RelativeTransitionHasOutputYaw
        /// </summary>
        public unsafe bool RelativeTransitionHasOutputYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }; }
        }

        /// <summary>
        /// BoolProperty: HackHackHackFirstPerson
        /// </summary>
        public unsafe bool HackHackHackFirstPerson
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }; }
        }
    }

    /// <summary>
    /// Struct: FMoveToTransitionArray
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 340)]
    public partial record struct FMoveToTransitionArray
    {
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransition Data_0
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransition>((IntPtr)thisPtr + 0); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransition Data_1
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransition>((IntPtr)thisPtr + 56); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransition Data_2
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransition>((IntPtr)thisPtr + 112); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransition Data_3
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransition>((IntPtr)thisPtr + 168); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransition Data_4
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransition>((IntPtr)thisPtr + 224); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransition Data_5
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FMoveToTransition>((IntPtr)thisPtr + 280); } }
        }

        /// <summary>
        /// IntProperty: Num
        /// </summary>
        public unsafe int Num
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }; }
        }
    }

    /// <summary>
    /// Struct: FMoveToTransition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial record struct FMoveToTransition
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
        /// ByteProperty: PreviousSpeed
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.EMovementSpeed PreviousSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementSpeed>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// BoolProperty: IsBackwards
        /// </summary>
        public unsafe bool IsBackwards
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: PreviousIsBackwards
        /// </summary>
        public unsafe bool PreviousIsBackwards
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: CarryOver
        /// </summary>
        public unsafe bool CarryOver
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: SpeedScale
        /// </summary>
        public unsafe float SpeedScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: ExtractionYaw
        /// </summary>
        public unsafe float ExtractionYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: ExtractionYawVelocity
        /// </summary>
        public unsafe float ExtractionYawVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: ExtractionDirection
        /// </summary>
        public unsafe ref System.Numerics.Vector3 ExtractionDirection
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 20); } }
        }

        /// <summary>
        /// StructProperty: ExtractionDirectionVelocity
        /// </summary>
        public unsafe ref System.Numerics.Vector3 ExtractionDirectionVelocity
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 32); } }
        }

        /// <summary>
        /// FloatProperty: Duration
        /// </summary>
        public unsafe float Duration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: OwnerId
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId OwnerId
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>((IntPtr)thisPtr + 52); } }
        }
    }

    /// <summary>
    /// Struct: FMoveToChange
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 21)]
    public partial record struct FMoveToChange
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
        /// BoolProperty: IsBackwards
        /// </summary>
        public unsafe bool IsBackwards
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: FacingYaw
        /// </summary>
        public unsafe float FacingYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: ExtractionYaw
        /// </summary>
        public unsafe float ExtractionYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: SpeedScale
        /// </summary>
        public unsafe float SpeedScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: Instigator
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.ETurnInstigator Instigator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.ETurnInstigator>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FMoveToRequest
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FMoveToRequest
    {
        /// <summary>
        /// StructProperty: Target
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FAnimTarget Target
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FAnimTarget>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// ByteProperty: TargetSpeed
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.EMovementSpeed TargetSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementSpeed>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: TargetSpeedScale
        /// </summary>
        public unsafe float TargetSpeedScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Struct: FFaceAtChange
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FFaceAtChange
    {
        /// <summary>
        /// BoolProperty: Enabled
        /// </summary>
        public unsafe bool Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Yaw
        /// </summary>
        public unsafe float Yaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FFaceAtRequest
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FFaceAtRequest
    {
        /// <summary>
        /// StructProperty: Target
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FAnimTarget Target
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FAnimTarget>((IntPtr)thisPtr + 0); } }
        }
    }

    /// <summary>
    /// Struct: FLookAtRequest
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial record struct FLookAtRequest
    {
        /// <summary>
        /// StructProperty: Target
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FAnimTarget Target
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FAnimTarget>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: Reference
        /// </summary>
        public unsafe ref System.Numerics.Vector3 Reference
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 40); } }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
    }

    /// <summary>
    /// Struct: FAimAtState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 156)]
    public partial record struct FAimAtState
    {
        /// <summary>
        /// ArrayProperty: Transitions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtTransition> Transitions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtTransition>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Samples
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSampleArray Samples
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSampleArray>((IntPtr)thisPtr + 12); } }
        }

        /// <summary>
        /// StructProperty: ResolvedAngle
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FYawPitch ResolvedAngle
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FYawPitch>((IntPtr)thisPtr + 144); } }
        }

        /// <summary>
        /// StructProperty: ResolvedWeight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FWeight ResolvedWeight
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FWeight>((IntPtr)thisPtr + 152); } }
        }
    }

    /// <summary>
    /// Struct: FAimAtSampleArray
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 132)]
    public partial record struct FAimAtSampleArray
    {
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample Data_0
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample>((IntPtr)thisPtr + 0); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample Data_1
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample>((IntPtr)thisPtr + 16); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample Data_2
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample>((IntPtr)thisPtr + 32); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample Data_3
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample>((IntPtr)thisPtr + 48); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample Data_4
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample>((IntPtr)thisPtr + 64); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample Data_5
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample>((IntPtr)thisPtr + 80); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample Data_6
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample>((IntPtr)thisPtr + 96); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample Data_7
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAimAtSample>((IntPtr)thisPtr + 112); } }
        }

        /// <summary>
        /// IntProperty: Num
        /// </summary>
        public unsafe int Num
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }
    }

    /// <summary>
    /// Struct: FAimAtSample
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FAimAtSample
    {
        /// <summary>
        /// StructProperty: Angle
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FYawPitch Angle
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FYawPitch>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// FloatProperty: LimitScale
        /// </summary>
        public unsafe float LimitScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: Weight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FWeight Weight
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FWeight>((IntPtr)thisPtr + 12); } }
        }
    }

    /// <summary>
    /// Struct: FAimAtTransition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FAimAtTransition
    {
        /// <summary>
        /// BoolProperty: Enabled
        /// </summary>
        public unsafe bool Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: Description
        /// </summary>
        public unsafe BmSDK.FName Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: Angle
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FYawPitch Angle
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FYawPitch>((IntPtr)thisPtr + 16); } }
        }

        /// <summary>
        /// FloatProperty: LimitScale
        /// </summary>
        public unsafe float LimitScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: TargetAngle
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FYawPitch TargetAngle
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FYawPitch>((IntPtr)thisPtr + 28); } }
        }

        /// <summary>
        /// StructProperty: AngleVelocity
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FYawPitch AngleVelocity
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FYawPitch>((IntPtr)thisPtr + 36); } }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Struct: FAimAtChange
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FAimAtChange
    {
        /// <summary>
        /// BoolProperty: Enabled
        /// </summary>
        public unsafe bool Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: Description
        /// </summary>
        public unsafe BmSDK.FName Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: Direction
        /// </summary>
        public unsafe ref System.Numerics.Vector3 Direction
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 16); } }
        }

        /// <summary>
        /// StructProperty: Angle
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FYawPitch Angle
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FYawPitch>((IntPtr)thisPtr + 28); } }
        }

        /// <summary>
        /// FloatProperty: LimitScale
        /// </summary>
        public unsafe float LimitScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: AllowTurningToAim
        /// </summary>
        public unsafe bool AllowTurningToAim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: Snap
        /// </summary>
        public unsafe bool Snap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FAimAtRequest
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FAimAtRequest
    {
        /// <summary>
        /// StructProperty: Target
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FAnimTarget Target
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FAnimTarget>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// ByteProperty: AllowTurningToAim
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.EYesNoDefault AllowTurningToAim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.EYesNoDefault>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: Reference
        /// </summary>
        public unsafe ref System.Numerics.Vector3 Reference
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 44); } }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: LimitScale
        /// </summary>
        public unsafe float LimitScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: Snap
        /// </summary>
        public unsafe bool Snap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FStanceChangeTransitionInput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public partial record struct FStanceChangeTransitionInput
    {
        /// <summary>
        /// BoolProperty: OverrideDurationEnabled
        /// </summary>
        public unsafe bool OverrideDurationEnabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Queued
        /// </summary>
        public unsafe bool Queued
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ForceBlend
        /// </summary>
        public unsafe bool ForceBlend
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: DontConsumeAdditiveWeight
        /// </summary>
        public unsafe bool DontConsumeAdditiveWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Type
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.EAnimTransitionType Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.EAnimTransitionType>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: TargetPosition
        /// </summary>
        public unsafe ref System.Numerics.Vector3 TargetPosition
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 8); } }
        }

        /// <summary>
        /// StructProperty: TargetRotation
        /// </summary>
        public unsafe ref BmSDK.Rotator TargetRotation
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>((IntPtr)thisPtr + 20); } }
        }

        /// <summary>
        /// NameProperty: Name
        /// </summary>
        public unsafe BmSDK.FName Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: OverrideDuration
        /// </summary>
        public unsafe float OverrideDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: DurationScale
        /// </summary>
        public unsafe float DurationScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointBegin
        /// </summary>
        public unsafe float MeetingPointBegin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingPointEnd
        /// </summary>
        public unsafe float MeetingPointEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// ByteProperty: Mirrored
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.EMirrorChoice Mirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// StructProperty: SlavedTo
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FSlavedToTransitionDescription SlavedTo
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FSlavedToTransitionDescription>((IntPtr)thisPtr + 60); } }
        }

        /// <summary>
        /// ObjectProperty: Weapon
        /// </summary>
        public unsafe BmSDK.Engine.Inventory Weapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// ObjectProperty: WeaponConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RWeaponConfig WeaponConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }

        /// <summary>
        /// StructProperty: CustomAnim
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FCustomAnimConfig CustomAnim
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>((IntPtr)thisPtr + 112); } }
        }

        /// <summary>
        /// StructProperty: AutomaticTransitionInstance
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FAutomaticTransitionInstance AutomaticTransitionInstance
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FAutomaticTransitionInstance>((IntPtr)thisPtr + 152); } }
        }

        /// <summary>
        /// FloatProperty: CanCancelBeforeHereTime
        /// </summary>
        public unsafe float CanCancelBeforeHereTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }

        /// <summary>
        /// FloatProperty: CanCancelAfterHereTime
        /// </summary>
        public unsafe float CanCancelAfterHereTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }; }
        }

        /// <summary>
        /// FloatProperty: CanCorrectAfterHereTime
        /// </summary>
        public unsafe float CanCorrectAfterHereTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }; }
        }

        /// <summary>
        /// FloatProperty: StartTime
        /// </summary>
        public unsafe float StartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }; }
        }

        /// <summary>
        /// DelegateProperty: OnPlayedQueuedTransition
        /// </summary>
        public unsafe System.IntPtr OnPlayedQueuedTransition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 212); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }; }
        }
    }

    /// <summary>
    /// Struct: FSlavedToTransitionDescription
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FSlavedToTransitionDescription
    {
        /// <summary>
        /// ObjectProperty: Actor
        /// </summary>
        public unsafe BmSDK.Engine.Actor Actor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Transition
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Transition
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>((IntPtr)thisPtr + 4); } }
        }

        /// <summary>
        /// ByteProperty: TimeSync
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.ESlavedTransitionTimeSync TimeSync
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.ESlavedTransitionTimeSync>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: FloorTakedownHack_Rotation
        /// </summary>
        public unsafe ref BmSDK.Rotator FloorTakedownHack_Rotation
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>((IntPtr)thisPtr + 12); } }
        }

        /// <summary>
        /// BoolProperty: FloorTakedownHack_Enabled
        /// </summary>
        public unsafe bool FloorTakedownHack_Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: OffsetPitch
        /// </summary>
        public unsafe int OffsetPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: OffsetRoll
        /// </summary>
        public unsafe int OffsetRoll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: OffsetZ
        /// </summary>
        public unsafe float OffsetZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: AlwaysInferReferencePointTarget
        /// </summary>
        public unsafe bool AlwaysInferReferencePointTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Enum: ESlavedTransitionTimeSync
    /// </summary>
    public enum ESlavedTransitionTimeSync
    {
        STTS_None = 0,
        STTS_SyncToStart = 1,
        STTS_SyncToEnd = 2,
        STTS_MAX = 3,
    }

    /// <summary>
    /// Struct: FStanceChangePreviousPoseInput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FStanceChangePreviousPoseInput
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
        /// BoolProperty: Mirrored
        /// </summary>
        public unsafe bool Mirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: Weapon
        /// </summary>
        public unsafe BmSDK.Engine.Inventory Weapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ObjectProperty: WeaponConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RWeaponConfig WeaponConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FStanceChangePoseInput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public partial record struct FStanceChangePoseInput
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
        /// ObjectProperty: MatineeInterpGroup
        /// </summary>
        public unsafe BmSDK.Engine.InterpGroup MatineeInterpGroup
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpGroup>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: Weapon
        /// </summary>
        public unsafe BmSDK.Engine.Inventory Weapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ObjectProperty: WeaponConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RWeaponConfig WeaponConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: CustomIdle
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FCustomAnimConfig CustomIdle
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>((IntPtr)thisPtr + 36); } }
        }

        /// <summary>
        /// StructProperty: IdleSlavedTo
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FSlavedToIdleDescription IdleSlavedTo
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FSlavedToIdleDescription>((IntPtr)thisPtr + 76); } }
        }

        /// <summary>
        /// FloatProperty: IdleStartTime
        /// </summary>
        public unsafe float IdleStartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// ByteProperty: IdleType
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.EAnimIdleType IdleType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.EAnimIdleType>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// BoolProperty: Mirrored
        /// </summary>
        public unsafe bool Mirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }; }
        }

        /// <summary>
        /// BoolProperty: Falling
        /// </summary>
        public unsafe bool Falling
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }; }
        }

        /// <summary>
        /// StructProperty: TargetPosition
        /// </summary>
        public unsafe ref System.Numerics.Vector3 TargetPosition
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 96); } }
        }

        /// <summary>
        /// StructProperty: TargetRotation
        /// </summary>
        public unsafe ref BmSDK.Rotator TargetRotation
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>((IntPtr)thisPtr + 108); } }
        }
    }

    /// <summary>
    /// Struct: FSlavedToIdleDescription
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSlavedToIdleDescription
    {
        /// <summary>
        /// ObjectProperty: Actor
        /// </summary>
        public unsafe BmSDK.Engine.Actor Actor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Transition
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Transition
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>((IntPtr)thisPtr + 4); } }
        }
    }

    /// <summary>
    /// Struct: FTransitionId
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FTransitionId
    {
        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FAutomaticTransitionInstance
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 43)]
    public partial record struct FAutomaticTransitionInstance
    {
        /// <summary>
        /// BoolProperty: Enabled
        /// </summary>
        public unsafe bool Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: AllowLowSpeedScale
        /// </summary>
        public unsafe bool AllowLowSpeedScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: AllowHighSpeedScale
        /// </summary>
        public unsafe bool AllowHighSpeedScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: BeginIsBackwards
        /// </summary>
        public unsafe bool BeginIsBackwards
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: EndIsBackwards
        /// </summary>
        public unsafe bool EndIsBackwards
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: IsEarlyCancel
        /// </summary>
        public unsafe bool IsEarlyCancel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: IsEarlyCancelOfAnimated
        /// </summary>
        public unsafe bool IsEarlyCancelOfAnimated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Falling
        /// </summary>
        public unsafe bool Falling
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Landing
        /// </summary>
        public unsafe bool Landing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Anim
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence Anim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: BeginYaw
        /// </summary>
        public unsafe float BeginYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: EndYaw
        /// </summary>
        public unsafe float EndYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: DeclaredYawDelta
        /// </summary>
        public unsafe float DeclaredYawDelta
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: ActualYawDelta
        /// </summary>
        public unsafe float ActualYawDelta
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: MinYawDelta
        /// </summary>
        public unsafe float MinYawDelta
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: MaxYawDelta
        /// </summary>
        public unsafe float MaxYawDelta
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: UndershootMarginAngle
        /// </summary>
        public unsafe float UndershootMarginAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: OvershootMarginAngle
        /// </summary>
        public unsafe float OvershootMarginAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ByteProperty: BeginSpeed
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.EMovementSpeed BeginSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementSpeed>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ByteProperty: EndSpeed
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.EMovementSpeed EndSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementSpeed>(Ptr + 41); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 41); }; }
        }

        /// <summary>
        /// ByteProperty: TurnInstigator
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.ETurnInstigator TurnInstigator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.ETurnInstigator>(Ptr + 42); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 42); }; }
        }
    }

    /// <summary>
    /// Enum: ETurnInstigator
    /// </summary>
    public enum ETurnInstigator
    {
        TI_AimAt = 0,
        TI_FaceAt = 1,
        TI_MoveTo = 2,
        TI_MAX = 3,
    }

    /// <summary>
    /// Enum: EAnimIdleType
    /// </summary>
    public enum EAnimIdleType
    {
        IDLE_Normal = 0,
        IDLE_Relative = 1,
        IDLE_Slaved = 2,
        IDLE_MAX = 3,
    }

    /// <summary>
    /// Enum: EAnimTransitionType
    /// </summary>
    public enum EAnimTransitionType
    {
        TRANSITION_Normal = 0,
        TRANSITION_Absolute = 1,
        TRANSITION_AbsoluteRotationOnly = 2,
        TRANSITION_Relative = 3,
        TRANSITION_RelativeRotationOnly = 4,
        TRANSITION_Slaved = 5,
        TRANSITION_MAX = 6,
    }

}
