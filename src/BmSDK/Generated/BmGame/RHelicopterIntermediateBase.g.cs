#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHelicopterIntermediateBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHelicopterIntermediateBase : BmSDK.BmGame.RHelicopterBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHelicopterIntermediateBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHelicopterIntermediateBase() { }

    /// <summary>
    /// Constructs a new RHelicopterIntermediateBase
    /// </summary>
    public RHelicopterIntermediateBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHelicopterIntermediateBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHelicopterIntermediateBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediateBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediateBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediateBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediateBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediateBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediateBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediateBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: NextPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NextPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// ObjectProperty: PursuitTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PursuitTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2356); }
    }

    /// <summary>
    /// ObjectProperty: TracerFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TracerFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// ObjectProperty: ImpactFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImpactFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// ObjectProperty: TurrentBoneControllerUpDown
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TurrentBoneControllerUpDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// ObjectProperty: TurrentBoneControllerLeftRight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TurrentBoneControllerLeftRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2388); }
    }

    /// <summary>
    /// ComponentProperty: FlashingLightComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FlashingLightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// ComponentProperty: DustComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DustComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlashComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MuzzleFlashComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// BoolProperty: bWalkBackwards
    /// </summary>
    public unsafe bool bWalkBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// BoolProperty: bPingPong
    /// </summary>
    public unsafe bool bPingPong
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// BoolProperty: MoveTowardModeIsPath
    /// </summary>
    public unsafe bool MoveTowardModeIsPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// BoolProperty: MoveTowardSlowdownOnApproach
    /// </summary>
    public unsafe bool MoveTowardSlowdownOnApproach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// BoolProperty: bHasMovedThisFrame
    /// </summary>
    public unsafe bool bHasMovedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// BoolProperty: bEnableLightFX
    /// </summary>
    public unsafe bool bEnableLightFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// BoolProperty: bEnableDust
    /// </summary>
    public unsafe bool bEnableDust
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// BoolProperty: bEnableFlashingLight
    /// </summary>
    public unsafe bool bEnableFlashingLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// BoolProperty: bSpawnBulletFX
    /// </summary>
    public unsafe bool bSpawnBulletFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// BoolProperty: bWasVolumetricLightingEnabled
    /// </summary>
    public unsafe bool bWasVolumetricLightingEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// BoolProperty: bWasLightEnabled
    /// </summary>
    public unsafe bool bWasLightEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// BoolProperty: bWasLightCastingShadows
    /// </summary>
    public unsafe bool bWasLightCastingShadows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// BoolProperty: bWasSearchLightMeshEnabled
    /// </summary>
    public unsafe bool bWasSearchLightMeshEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2420); }
    }

    /// <summary>
    /// StructProperty: MoveTowardLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MoveTowardLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// StructProperty: MoveTowardPathLocation1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MoveTowardPathLocation1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// StructProperty: MoveTowardPathLocation2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MoveTowardPathLocation2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// FloatProperty: MoveTowardSpeed
    /// </summary>
    public unsafe float MoveTowardSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// FloatProperty: FireTimer
    /// </summary>
    public unsafe float FireTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// FloatProperty: RocketFireTimer
    /// </summary>
    public unsafe float RocketFireTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// FloatProperty: GunShotDeviance
    /// </summary>
    public unsafe float GunShotDeviance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// FloatProperty: DustTraceDistance
    /// </summary>
    public unsafe float DustTraceDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// FloatProperty: OldSpotlightBrightness
    /// </summary>
    public unsafe float OldSpotlightBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// StructProperty: SearchLightMeshScale3D
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SearchLightMeshScale3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2484); }
    }

    /// <summary>
    /// Struct: FSearchLightSourceLocationInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FSearchLightSourceLocationInfo
    {
        /// <summary>
        /// StructProperty: vSearchLightSourcePosition
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT vSearchLightSourcePosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: rSearchLightSourceRotation
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT rSearchLightSourceRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: fSearchLightScanTiltCurrent
        /// </summary>
        public unsafe float fSearchLightScanTiltCurrent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: fSearchLightScanRotateSpeedCurrent
        /// </summary>
        public unsafe float fSearchLightScanRotateSpeedCurrent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: fSearchLightScanSpreadCurrent
        /// </summary>
        public unsafe float fSearchLightScanSpreadCurrent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: rSearchLightSourceDirection
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT rSearchLightSourceDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: fSearchLightScanTiltDesired
        /// </summary>
        public unsafe float fSearchLightScanTiltDesired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: fSearchLightScanRotateSpeedDesired
        /// </summary>
        public unsafe float fSearchLightScanRotateSpeedDesired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: fSearchLightScanSpreadDesired
        /// </summary>
        public unsafe float fSearchLightScanSpreadDesired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FTargetData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FTargetData
    {
        /// <summary>
        /// ObjectProperty: hActor
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT hActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: fDistanceSq
        /// </summary>
        public unsafe float fDistanceSq
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bIsPlayer
        /// </summary>
        public unsafe bool bIsPlayer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSearchLightData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FSearchLightData
    {
        /// <summary>
        /// ObjectProperty: hTarget
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT hTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: vTargetPositionDesired
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT vTargetPositionDesired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: vTargetPositionCurrent
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT vTargetPositionCurrent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: fTargetValidateDelay
        /// </summary>
        public unsafe float fTargetValidateDelay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: fTargetInvisibleTime
        /// </summary>
        public unsafe float fTargetInvisibleTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ComponentProperty: hLightDynamic
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT hLightDynamic
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ComponentProperty: hLightConeMesh
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT hLightConeMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: vLightConeScale
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT vLightConeScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// ObjectProperty: hLightConeMaterialConstant
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT hLightConeMaterialConstant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// StructProperty: vLightColorDesired
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT vLightColorDesired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// StructProperty: vLightColorCurrent
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT vLightColorCurrent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// ComponentProperty: hWeaponEffect
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT hWeaponEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }

        /// <summary>
        /// BoolProperty: bWeaponOverridePosition
        /// </summary>
        public unsafe bool bWeaponOverridePosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }; }
        }

        /// <summary>
        /// StructProperty: vWeaponOverridePosition
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT vWeaponOverridePosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }
    }
}
