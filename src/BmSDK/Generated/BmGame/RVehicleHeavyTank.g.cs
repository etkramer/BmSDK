#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleHeavyTank<br/>
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
    public unsafe BmSDK.Engine.PrimitiveComponent WeakPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 8112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8112); }
    }

    /// <summary>
    /// BoolProperty: HideWeakPointWhenPatrolling
    /// </summary>
    public unsafe bool HideWeakPointWhenPatrolling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: DisableLaserCollision
    /// </summary>
    public unsafe bool DisableLaserCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: Shielded
    /// </summary>
    public unsafe bool Shielded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bDrawScanLaserDebug
    /// </summary>
    public unsafe bool bDrawScanLaserDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: WeakPointRevealed
    /// </summary>
    public unsafe bool WeakPointRevealed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: DisallowEngageTarget
    /// </summary>
    public unsafe bool DisallowEngageTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bCloudburstVulnerable
    /// </summary>
    public unsafe bool bCloudburstVulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bNoScanLasers
    /// </summary>
    public unsafe bool bNoScanLasers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bWeakPointsTargettable
    /// </summary>
    public unsafe bool bWeakPointsTargettable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bVulnderableOnStartup
    /// </summary>
    public unsafe bool bVulnderableOnStartup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bLockedOnToPlayer
    /// </summary>
    public unsafe bool bLockedOnToPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: PlayedLostDialogueThisStage
    /// </summary>
    public unsafe bool PlayedLostDialogueThisStage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
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
    public unsafe BmSDK.Engine.SpotLightComponent ScannerLightSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpotLightComponent>(Ptr + 8128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8128); }
    }

    /// <summary>
    /// StructProperty: SearchLightColour
    /// </summary>
    public unsafe BmSDK.GameObject.FColor SearchLightColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 8136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8136); }
    }

    /// <summary>
    /// StructProperty: Sweep360LightColour
    /// </summary>
    public unsafe BmSDK.GameObject.FColor Sweep360LightColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 8140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8140); }
    }

    /// <summary>
    /// StructProperty: AttackLightColour
    /// </summary>
    public unsafe BmSDK.GameObject.FColor AttackLightColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 8144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8144); }
    }

    /// <summary>
    /// ObjectProperty: ScanLaser
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleScanLaser ScanLaser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleScanLaser>(Ptr + 8148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8148); }
    }

    /// <summary>
    /// ObjectProperty: BattleViewMaterialInst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BattleViewMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8156); }
    }

    /// <summary>
    /// ObjectProperty: LightMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant LightMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8164); }
    }

    /// <summary>
    /// ObjectProperty: LaserAudible
    /// </summary>
    public unsafe BmSDK.Engine.RAkAudible LaserAudible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAkAudible>(Ptr + 8172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8172); }
    }

    /// <summary>
    /// ObjectProperty: LaserEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LaserEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8180); }
    }

    /// <summary>
    /// ObjectProperty: DisableShieldMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DisableShieldMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8188); }
    }

    /// <summary>
    /// ObjectProperty: ShieldImpactMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ShieldImpactMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8196); }
    }

    /// <summary>
    /// ObjectProperty: ShieldFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ShieldFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8204); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleWarningFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MuzzleWarningFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8212); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileContactParticles
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BatmobileContactParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8220); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileContactSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BatmobileContactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8228); }
    }

    /// <summary>
    /// ObjectProperty: BossMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie BossMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 8236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8236); }
    }

    /// <summary>
    /// ObjectProperty: TurretDestroyedMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh TurretDestroyedMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 8244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8244); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstOverheatedLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CloudburstOverheatedLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 8252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8252); }
    }

    /// <summary>
    /// ObjectProperty: PostScanLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech PostScanLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 8260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8260); }
    }

    /// <summary>
    /// ObjectProperty: PostPowerDownLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech PostPowerDownLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 8268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8268); }
    }

    /// <summary>
    /// ObjectProperty: EMPIneffectiveLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech EMPIneffectiveLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 8276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8276); }
    }

    /// <summary>
    /// ObjectProperty: CachedShutDownBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour CachedShutDownBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 8284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8284); }
    }

    /// <summary>
    /// ObjectProperty: WeakPointTarget
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WeakPointTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8292); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstCriticalOn
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CloudburstCriticalOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8300); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstCriticalOff
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CloudburstCriticalOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8308); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstCriticalValue
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName CloudburstCriticalValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 8316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8316); }
    }

    /// <summary>
    /// ObjectProperty: MainWeaponChargeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent MainWeaponChargeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8324); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant CloudburstMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8332); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosionWaveform
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform DeathExplosionWaveform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 8340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8340); }
    }

    /// <summary>
    /// ComponentProperty: CloudburstPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent CloudburstPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }

    /// <summary>
    /// ComponentProperty: TurretDestroyedPersistentPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent TurretDestroyedPersistentPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8356); }
    }

    /// <summary>
    /// ComponentProperty: TurretDestroyedPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent TurretDestroyedPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8364); }
    }

    /// <summary>
    /// ComponentProperty: TurretMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent TurretMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 8372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8372); }
    }

    /// <summary>
    /// ComponentProperty: Cloudburst
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Cloudburst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 8380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8380); }
    }

    /// <summary>
    /// ComponentProperty: WeakPointMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent WeakPointMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 8388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8388); }
    }

    /// <summary>
    /// ComponentProperty: ShieldImpactComp
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent ShieldImpactComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 8396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8396); }
    }

    /// <summary>
    /// ComponentProperty: ShieldMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent ShieldMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 8404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8404); }
    }

    /// <summary>
    /// ComponentProperty: Shield
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent Shield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 8412); }
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
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleScanLaser> ActualLasers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleScanLaser>>(Ptr + 8432); }
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
    public unsafe BmSDK.TArray<BmSDK.Engine.AkWwise.FAkSourceSpatial> LaserSoundPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkWwise.FAkSourceSpatial>>(Ptr + 8460); }
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
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer> AllWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer>>(Ptr + 8504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8504); }
    }

    /// <summary>
    /// ArrayProperty: BossStages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.FCommanderTankStage> BossStages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.FCommanderTankStage>>(Ptr + 8520); }
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
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.FCommanderTankWeakPoint> WeakPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.FCommanderTankWeakPoint>>(Ptr + 8552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8552); }
    }

    /// <summary>
    /// ArrayProperty: WeakPointsDestroyedGotoStage
    /// </summary>
    public unsafe BmSDK.TArray<int> WeakPointsDestroyedGotoStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 8568); }
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
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8588); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8604); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8620); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8636); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8652); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8668); }
    }

    /// <summary>
    /// ArrayProperty: CloudburstDamageTemplate
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystem> CloudburstDamageTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystem>>(Ptr + 8684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8684); }
    }

    /// <summary>
    /// ArrayProperty: MaterialHeatValues
    /// </summary>
    public unsafe BmSDK.TArray<float> MaterialHeatValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8700); }
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
