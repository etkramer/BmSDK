#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatarangProjectile<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBatarangProjectile : BmSDK.BmGame.RProjectile, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatarangProjectile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatarangProjectile() { }

    /// <summary>
    /// Constructs a new RBatarangProjectile
    /// </summary>
    public RBatarangProjectile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatarangProjectile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatarangProjectile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: BatarangMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatarangMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: SpinAngularVelocity
    /// </summary>
    public unsafe float SpinAngularVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// FloatProperty: BatarangMass
    /// </summary>
    public unsafe float BatarangMass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: CosRicochetAngle
    /// </summary>
    public unsafe float CosRicochetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: TurnRate
    /// </summary>
    public unsafe float TurnRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// FloatProperty: DefaultRoll
    /// </summary>
    public unsafe float DefaultRoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// FloatProperty: StunMod
    /// </summary>
    public unsafe float StunMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// FloatProperty: ImpactMod
    /// </summary>
    public unsafe float ImpactMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ArrayProperty: CurrentTargetList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> CurrentTargetList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: WallRicochetFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WallRicochetFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: WeaponRicochetFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeaponRicochetFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: ComboBatarangTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ComboBatarangTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: GlidingBatarangTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GlidingBatarangTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: BatarangTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatarangTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ObjectProperty: TrackingCam
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TrackingCam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: MyLauncher
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyLauncher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ObjectProperty: FuseBoxHitEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FuseBoxHitEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ObjectProperty: OverrideWallHitEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverrideWallHitEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: OverrideEnemyHitEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverrideEnemyHitEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ObjectProperty: ElectrifySoundPlay
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ElectrifySoundPlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ObjectProperty: ElectrifySoundStop
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ElectrifySoundStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ObjectProperty: DodgedActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DodgedActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// ObjectProperty: RCBatarangLevelVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RCBatarangLevelVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ObjectProperty: ExplosionSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExplosionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ClassProperty: StealthBatarangDmgType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StealthBatarangDmgType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ComponentProperty: ElectrifyParticles
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ElectrifyParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ComponentProperty: ElectrifiedLoopParticles
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ElectrifiedLoopParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ComponentProperty: RightWingTrail
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RightWingTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ComponentProperty: LeftWingTrail
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LeftWingTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ComponentProperty: BatarangTrail
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatarangTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// NameProperty: TargetBoneName
    /// </summary>
    public unsafe BmSDK.FName TargetBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: TargetRopePosition
    /// </summary>
    public unsafe float TargetRopePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// FloatProperty: IdealThrowYaw
    /// </summary>
    public unsafe float IdealThrowYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// FloatProperty: IdealImpactYaw
    /// </summary>
    public unsafe float IdealImpactYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// FloatProperty: IdealThrowPitch
    /// </summary>
    public unsafe float IdealThrowPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: IdealImpactPitch
    /// </summary>
    public unsafe float IdealImpactPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// FloatProperty: IdealThrowLength
    /// </summary>
    public unsafe float IdealThrowLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// FloatProperty: ThrowSpeed
    /// </summary>
    public unsafe float ThrowSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// FloatProperty: IdealFlightTime
    /// </summary>
    public unsafe float IdealFlightTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// FloatProperty: MinimumFlightTime
    /// </summary>
    public unsafe float MinimumFlightTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// StructProperty: LaunchPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LaunchPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// BoolProperty: bLaunchedFromGarg
    /// </summary>
    public unsafe bool bLaunchedFromGarg
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bHoming
    /// </summary>
    public unsafe bool bHoming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bHitTarget
    /// </summary>
    public unsafe bool bHitTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: StopsOnPawns
    /// </summary>
    public unsafe bool StopsOnPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bComboBatarang
    /// </summary>
    public unsafe bool bComboBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bHitVillain
    /// </summary>
    public unsafe bool bHitVillain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bForceSlowSlowMoCamera
    /// </summary>
    public unsafe bool bForceSlowSlowMoCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bThrownAtMaximumRange
    /// </summary>
    public unsafe bool bThrownAtMaximumRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bHasStartedHoming
    /// </summary>
    public unsafe bool bHasStartedHoming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: CantDoGadgetCamera
    /// </summary>
    public unsafe bool CantDoGadgetCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bElectrified
    /// </summary>
    public unsafe bool bElectrified
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: Boosting
    /// </summary>
    public unsafe bool Boosting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: MaximumBoost
    /// </summary>
    public unsafe bool MaximumBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: CanFlyRoundTheBack
    /// </summary>
    public unsafe bool CanFlyRoundTheBack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bUpdateBatarangMeshRotation
    /// </summary>
    public unsafe bool bUpdateBatarangMeshRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bElectrifySoundPlaying
    /// </summary>
    public unsafe bool bElectrifySoundPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: RCBatarang
    /// </summary>
    public unsafe bool RCBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bFixCeilingCameraRoll
    /// </summary>
    public unsafe bool bFixCeilingCameraRoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bDisableTouchLogic
    /// </summary>
    public unsafe bool bDisableTouchLogic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bPreventFinalBlowCamChanged
    /// </summary>
    public unsafe bool bPreventFinalBlowCamChanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: ExplosiveBatarang
    /// </summary>
    public unsafe bool ExplosiveBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: bPreCalculatedNoiseTarget
    /// </summary>
    public unsafe bool bPreCalculatedNoiseTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1116); }
    }

    /// <summary>
    /// StructProperty: LaunchTangent
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LaunchTangent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// StructProperty: ImpactTangent
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ImpactTangent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// StructProperty: CurrentImpactLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentImpactLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// FloatProperty: OneOverFlightTime
    /// </summary>
    public unsafe float OneOverFlightTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// FloatProperty: FlightTime
    /// </summary>
    public unsafe float FlightTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// FloatProperty: ProportionAlongPath
    /// </summary>
    public unsafe float ProportionAlongPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// StructProperty: NewTargetLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NewTargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// StructProperty: PreviousLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PreviousLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// FloatProperty: DefaultDamage
    /// </summary>
    public unsafe float DefaultDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// IntProperty: LaunchID
    /// </summary>
    public unsafe int LaunchID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// StructProperty: MeshYaw
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MeshYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// StructProperty: MeshPitch
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MeshPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// IntProperty: DamageGiven
    /// </summary>
    public unsafe int DamageGiven
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// IntProperty: NumEnemiesHit
    /// </summary>
    public unsafe int NumEnemiesHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// ArrayProperty: NoisyTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> NoisyTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// StructProperty: m_DbgOldPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT m_DbgOldPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }
}
