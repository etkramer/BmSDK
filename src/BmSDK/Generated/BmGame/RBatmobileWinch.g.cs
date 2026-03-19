#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatmobileWinch<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBatmobileWinch : BmSDK.BmGame.RVehicleWeapon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatmobileWinch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatmobileWinch() { }

    /// <summary>
    /// Constructs a new RBatmobileWinch
    /// </summary>
    public RBatmobileWinch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatmobileWinch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatmobileWinch(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileWinch>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileWinch>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileWinch>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileWinch>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileWinch>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileWinch>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileWinch>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: Range
    /// </summary>
    public unsafe float Range
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// FloatProperty: AbseilRange
    /// </summary>
    public unsafe float AbseilRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// FloatProperty: WinchPullSpeed
    /// </summary>
    public unsafe float WinchPullSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// FloatProperty: TargetingCone
    /// </summary>
    public unsafe float TargetingCone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// FloatProperty: AbseilTargetingCone
    /// </summary>
    public unsafe float AbseilTargetingCone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// BoolProperty: ActuallyAbseiling
    /// </summary>
    public unsafe bool ActuallyAbseiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: CameraHasLineOfSightToTarget
    /// </summary>
    public unsafe bool CameraHasLineOfSightToTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: InAttachToSpecificThing
    /// </summary>
    public unsafe bool InAttachToSpecificThing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: DoFireScreenShake
    /// </summary>
    public unsafe bool DoFireScreenShake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: TensionStarted
    /// </summary>
    public unsafe bool TensionStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: RopeTooLong
    /// </summary>
    public unsafe bool RopeTooLong
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredAbseilSwingCam
    /// </summary>
    public unsafe bool bTriggeredAbseilSwingCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: DontAutoReattach
    /// </summary>
    public unsafe bool DontAutoReattach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: IsHelpSuppressed
    /// </summary>
    public unsafe bool IsHelpSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: DragStarted
    /// </summary>
    public unsafe bool DragStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: ElectrifyHudShown
    /// </summary>
    public unsafe bool ElectrifyHudShown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: InAbseilTutorialMode
    /// </summary>
    public unsafe bool InAbseilTutorialMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: AbseilTutorialEventFired
    /// </summary>
    public unsafe bool AbseilTutorialEventFired
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: AbseilFrontWheelsOnWall
    /// </summary>
    public unsafe bool AbseilFrontWheelsOnWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: AbseilRearWheelsOnWall
    /// </summary>
    public unsafe bool AbseilRearWheelsOnWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// BoolProperty: ForceInEncounter
    /// </summary>
    public unsafe bool ForceInEncounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2416); }
    }

    /// <summary>
    /// FloatProperty: CantLowerAbseilTimer
    /// </summary>
    public unsafe float CantLowerAbseilTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// FloatProperty: WinchChange
    /// </summary>
    public unsafe float WinchChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// StructProperty: WinchTargetLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WinchTargetLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// ObjectProperty: WinchTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WinchTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// ObjectProperty: FireEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// ObjectProperty: ImpactEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImpactEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// ObjectProperty: ImpactSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// ObjectProperty: ReleaseSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReleaseSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// ObjectProperty: TensionStartSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TensionStartSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// ObjectProperty: WinchTensionParam
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WinchTensionParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// ObjectProperty: TensionParam
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TensionParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// ObjectProperty: WinchLoopingSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WinchLoopingSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// ObjectProperty: Projectile
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Projectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// ObjectProperty: RevRumble
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RevRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// ObjectProperty: FireRumble
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// ObjectProperty: CurrentRevRumble
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentRevRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// ObjectProperty: AbseilRopeSplinePath
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AbseilRopeSplinePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileHidePoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmobileHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// ClassProperty: BatmobileHidePointClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmobileHidePointClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// ComponentProperty: StubRope
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StubRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// ComponentProperty: ProjectileRope
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ProjectileRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// ComponentProperty: BeamElectricityComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BeamElectricityComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ComponentProperty: FireElectricityComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireElectricityComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ComponentProperty: WinchTargetComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WinchTargetComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// IntProperty: WinchTargetSubIndex
    /// </summary>
    public unsafe int WinchTargetSubIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// ArrayProperty: ValidTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> ValidTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }

    /// <summary>
    /// FloatProperty: ShowClearTheAreaText
    /// </summary>
    public unsafe float ShowClearTheAreaText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// StructProperty: BatmobileLockedToPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmobileLockedToPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// StructProperty: BatmobileLockedToRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmobileLockedToRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2652); }
    }

    /// <summary>
    /// ByteProperty: WheelsOnGroundFilter
    /// </summary>
    public unsafe byte WheelsOnGroundFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// ByteProperty: WinchPullType
    /// </summary>
    public unsafe byte WinchPullType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2665); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2665); }
    }

    /// <summary>
    /// ArrayProperty: InvalidTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> InvalidTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2668); }
    }

    /// <summary>
    /// StructProperty: FireScreenShake
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FireScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2684); }
    }

    /// <summary>
    /// FloatProperty: RopeInitialLength
    /// </summary>
    public unsafe float RopeInitialLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }

    /// <summary>
    /// FloatProperty: AbseilRopeMinLength
    /// </summary>
    public unsafe float AbseilRopeMinLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }

    /// <summary>
    /// FloatProperty: AbseilRopeMaxLength
    /// </summary>
    public unsafe float AbseilRopeMaxLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2848); }
    }

    /// <summary>
    /// FloatProperty: AbseilRopeReleaseLength
    /// </summary>
    public unsafe float AbseilRopeReleaseLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2852); }
    }

    /// <summary>
    /// FloatProperty: AbseilRopeReelInLength
    /// </summary>
    public unsafe float AbseilRopeReelInLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2856); }
    }

    /// <summary>
    /// FloatProperty: audioOldRopeLength
    /// </summary>
    public unsafe float audioOldRopeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2860); }
    }

    /// <summary>
    /// FloatProperty: OldRopeLength
    /// </summary>
    public unsafe float OldRopeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2864); }
    }

    /// <summary>
    /// FloatProperty: Wiggle
    /// </summary>
    public unsafe float Wiggle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2868); }
    }

    /// <summary>
    /// FloatProperty: ElectrifyRevs
    /// </summary>
    public unsafe float ElectrifyRevs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2872); }
    }

    /// <summary>
    /// FloatProperty: ElectrifyRevsVel
    /// </summary>
    public unsafe float ElectrifyRevsVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2876); }
    }

    /// <summary>
    /// FloatProperty: ElectrifyRevsSensitivity
    /// </summary>
    public unsafe float ElectrifyRevsSensitivity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2880); }
    }

    /// <summary>
    /// FloatProperty: ElectrifyRevsMax
    /// </summary>
    public unsafe float ElectrifyRevsMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2884); }
    }

    /// <summary>
    /// FloatProperty: ElectrifyRevsVelMax
    /// </summary>
    public unsafe float ElectrifyRevsVelMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2888); }
    }

    /// <summary>
    /// StructProperty: CurTargetPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurTargetPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }

    /// <summary>
    /// StructProperty: AbseilTutorialDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AbseilTutorialDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2904); }
    }

    /// <summary>
    /// FloatProperty: TutorialRopeMinLength
    /// </summary>
    public unsafe float TutorialRopeMinLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2916); }
    }

    /// <summary>
    /// FloatProperty: AbseilRopeLength
    /// </summary>
    public unsafe float AbseilRopeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2920); }
    }
}
