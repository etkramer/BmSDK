#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleHeavyTank<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleHeavyTank : BmSDK.BmGame.RVehicleTank, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleHeavyTank", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleHeavyTank() { }

    /// <summary>
    /// Constructs a new RVehicleHeavyTank
    /// </summary>
    public RVehicleHeavyTank(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleHeavyTank Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleHeavyTank(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: WeakPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeakPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8112); }
    }

    /// <summary>
    /// BoolProperty: HideWeakPointWhenPatrolling
    /// </summary>
    public unsafe bool HideWeakPointWhenPatrolling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: DisableLaserCollision
    /// </summary>
    public unsafe bool DisableLaserCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: Shielded
    /// </summary>
    public unsafe bool Shielded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bDrawScanLaserDebug
    /// </summary>
    public unsafe bool bDrawScanLaserDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: WeakPointRevealed
    /// </summary>
    public unsafe bool WeakPointRevealed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: DisallowEngageTarget
    /// </summary>
    public unsafe bool DisallowEngageTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bCloudburstVulnerable
    /// </summary>
    public unsafe bool bCloudburstVulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bNoScanLasers
    /// </summary>
    public unsafe bool bNoScanLasers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bWeakPointsTargettable
    /// </summary>
    public unsafe bool bWeakPointsTargettable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bVulnderableOnStartup
    /// </summary>
    public unsafe bool bVulnderableOnStartup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bLockedOnToPlayer
    /// </summary>
    public unsafe bool bLockedOnToPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: PlayedLostDialogueThisStage
    /// </summary>
    public unsafe bool PlayedLostDialogueThisStage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// FloatProperty: ScanRange
    /// </summary>
    public unsafe float ScanRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8124); }
    }

    /// <summary>
    /// ComponentProperty: ScannerLightSource
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ScannerLightSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8128); }
    }

    /// <summary>
    /// StructProperty: SearchLightColour
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SearchLightColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8136); }
    }

    /// <summary>
    /// StructProperty: Sweep360LightColour
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Sweep360LightColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8140); }
    }

    /// <summary>
    /// StructProperty: AttackLightColour
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AttackLightColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8144); }
    }

    /// <summary>
    /// ObjectProperty: ScanLaser
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ScanLaser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8148); }
    }

    /// <summary>
    /// ObjectProperty: BattleViewMaterialInst
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BattleViewMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8156); }
    }

    /// <summary>
    /// ObjectProperty: LightMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LightMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8164); }
    }

    /// <summary>
    /// ObjectProperty: LaserAudible
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.ActualLasers LaserAudible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.ActualLasers>(Ptr + 8172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8172); }
    }

    /// <summary>
    /// ObjectProperty: LaserEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LaserEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8180); }
    }

    /// <summary>
    /// ObjectProperty: DisableShieldMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DisableShieldMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8188); }
    }

    /// <summary>
    /// ObjectProperty: ShieldImpactMat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShieldImpactMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8196); }
    }

    /// <summary>
    /// ObjectProperty: ShieldFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShieldFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8204); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleWarningFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MuzzleWarningFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8212); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileContactParticles
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmobileContactParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8220); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileContactSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmobileContactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8228); }
    }

    /// <summary>
    /// ObjectProperty: BossMovieInstance
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BossMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8236); }
    }

    /// <summary>
    /// ObjectProperty: TurretDestroyedMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TurretDestroyedMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8244); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstOverheatedLine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CloudburstOverheatedLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8252); }
    }

    /// <summary>
    /// ObjectProperty: PostScanLine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PostScanLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8260); }
    }

    /// <summary>
    /// ObjectProperty: PostPowerDownLine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PostPowerDownLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8268); }
    }

    /// <summary>
    /// ObjectProperty: EMPIneffectiveLine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EMPIneffectiveLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8276); }
    }

    /// <summary>
    /// ObjectProperty: CachedShutDownBehaviour
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CachedShutDownBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8284); }
    }

    /// <summary>
    /// ObjectProperty: WeakPointTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeakPointTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8292); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstCriticalOn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CloudburstCriticalOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8300); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstCriticalOff
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CloudburstCriticalOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8308); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstCriticalValue
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CloudburstCriticalValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8316); }
    }

    /// <summary>
    /// ObjectProperty: MainWeaponChargeSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MainWeaponChargeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8324); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CloudburstMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8332); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosionWaveform
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DeathExplosionWaveform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8340); }
    }

    /// <summary>
    /// ComponentProperty: CloudburstPS
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CloudburstPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }

    /// <summary>
    /// ComponentProperty: TurretDestroyedPersistentPfx
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TurretDestroyedPersistentPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8356); }
    }

    /// <summary>
    /// ComponentProperty: TurretDestroyedPfx
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TurretDestroyedPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8364); }
    }

    /// <summary>
    /// ComponentProperty: TurretMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TurretMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8372); }
    }

    /// <summary>
    /// ComponentProperty: Cloudburst
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Cloudburst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8380); }
    }

    /// <summary>
    /// ComponentProperty: WeakPointMeshComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeakPointMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8388); }
    }

    /// <summary>
    /// ComponentProperty: ShieldImpactComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShieldImpactComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8396); }
    }

    /// <summary>
    /// ComponentProperty: ShieldMeshComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShieldMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8404); }
    }

    /// <summary>
    /// ComponentProperty: Shield
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Shield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8412); }
    }

    /// <summary>
    /// NameProperty: ScannerSocker
    /// </summary>
    public unsafe BmSDK.FName ScannerSocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8420); }
    }

    /// <summary>
    /// IntProperty: NumScanLasers
    /// </summary>
    public unsafe int NumScanLasers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8428); }
    }

    /// <summary>
    /// ArrayProperty: ActualLasers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>>>>>> ActualLasers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>>>>>>>(Ptr + 8432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8432); }
    }

    /// <summary>
    /// IntProperty: CurrentCollisionLaser
    /// </summary>
    public unsafe int CurrentCollisionLaser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8448); }
    }

    /// <summary>
    /// FloatProperty: WeakPointRadius
    /// </summary>
    public unsafe float WeakPointRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8452); }
    }

    /// <summary>
    /// FloatProperty: MaxLaserSoundVelocity
    /// </summary>
    public unsafe float MaxLaserSoundVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8456); }
    }

    /// <summary>
    /// ArrayProperty: LaserSoundPositions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>>>>> LaserSoundPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>>>>>>(Ptr + 8460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8460); }
    }

    /// <summary>
    /// FloatProperty: MuzzleWarningDuration
    /// </summary>
    public unsafe float MuzzleWarningDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8476); }
    }

    /// <summary>
    /// FloatProperty: BatmobileContactDamagePerSecond
    /// </summary>
    public unsafe float BatmobileContactDamagePerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }

    /// <summary>
    /// FloatProperty: BatmobileContactImpulse
    /// </summary>
    public unsafe float BatmobileContactImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8484); }
    }

    /// <summary>
    /// FloatProperty: ContactDamageDelay
    /// </summary>
    public unsafe float ContactDamageDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8488); }
    }

    /// <summary>
    /// FloatProperty: ScanForBatmanAngle
    /// </summary>
    public unsafe float ScanForBatmanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8492); }
    }

    /// <summary>
    /// FloatProperty: VisibilityTimeMod
    /// </summary>
    public unsafe float VisibilityTimeMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8496); }
    }

    /// <summary>
    /// IntProperty: NumNonTurretLightMaterialInst
    /// </summary>
    public unsafe int NumNonTurretLightMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8500); }
    }

    /// <summary>
    /// ArrayProperty: AllWeapons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>>>> AllWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>>>>>(Ptr + 8504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8504); }
    }

    /// <summary>
    /// ArrayProperty: BossStages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>>> BossStages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>>>>(Ptr + 8520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8520); }
    }

    /// <summary>
    /// FloatProperty: CloudburstHeat
    /// </summary>
    public unsafe float CloudburstHeat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8536); }
    }

    /// <summary>
    /// IntProperty: CurrentBossStage
    /// </summary>
    public unsafe int CurrentBossStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8540); }
    }

    /// <summary>
    /// FloatProperty: StartingHealth
    /// </summary>
    public unsafe float StartingHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8544); }
    }

    /// <summary>
    /// FloatProperty: CurrentStageTimeout
    /// </summary>
    public unsafe float CurrentStageTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8548); }
    }

    /// <summary>
    /// ArrayProperty: WeakPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>> WeakPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>>>(Ptr + 8552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8552); }
    }

    /// <summary>
    /// ArrayProperty: WeakPointsDestroyedGotoStage
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate> WeakPointsDestroyedGotoStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>>(Ptr + 8568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8568); }
    }

    /// <summary>
    /// FloatProperty: PostPowerDownLineDelay
    /// </summary>
    public unsafe float PostPowerDownLineDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8584); }
    }

    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate StageBasedDialogue_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>(Ptr + 8588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8588); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate StageBasedDialogue_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>(Ptr + 8604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8604); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate StageBasedDialogue_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>(Ptr + 8620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8620); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate StageBasedDialogue_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>(Ptr + 8636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8636); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate StageBasedDialogue_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>(Ptr + 8652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8652); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate StageBasedDialogue_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.CloudburstDamageTemplate>(Ptr + 8668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8668); }
    }

    /// <summary>
    /// ArrayProperty: CloudburstDamageTemplate
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.VehicleCustomisation>>>>> CloudburstDamageTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.VehicleCustomisation>>>>>>(Ptr + 8684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8684); }
    }

    /// <summary>
    /// ArrayProperty: MaterialHeatValues
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.VehicleCustomisation>>>> MaterialHeatValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.VehicleCustomisation>>>>>(Ptr + 8700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8700); }
    }

    /// <summary>
    /// FloatProperty: PowerDownPowerBackUpDelay
    /// </summary>
    public unsafe float PowerDownPowerBackUpDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8716); }
    }

    /// <summary>
    /// NameProperty: LastAimSocket
    /// </summary>
    public unsafe BmSDK.FName LastAimSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8720); }
    }
}
