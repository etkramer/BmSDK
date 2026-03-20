#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatmobileCannon<br/>
/// (flags = 0)
/// </summary>
public partial class RBatmobileCannon : BmSDK.BmGame.RVehicleWeapon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatmobileCannon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatmobileCannon() { }

    /// <summary>
    /// Constructs a new RBatmobileCannon
    /// </summary>
    public RBatmobileCannon(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatmobileCannon Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatmobileCannon(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileCannon>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bNonAimedCannonIsCameraRelative
    /// </summary>
    public unsafe bool bNonAimedCannonIsCameraRelative
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bHasRiotSurpressor
    /// </summary>
    public unsafe bool bHasRiotSurpressor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bCanHurtThugs
    /// </summary>
    public unsafe bool bCanHurtThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bUseRiotTargettingForChainGun
    /// </summary>
    public unsafe bool bUseRiotTargettingForChainGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bOverheating
    /// </summary>
    public unsafe bool bOverheating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bChainGunScreenShake
    /// </summary>
    public unsafe bool bChainGunScreenShake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bChaingunLocksOntoTanks
    /// </summary>
    public unsafe bool bChaingunLocksOntoTanks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bReloading
    /// </summary>
    public unsafe bool bReloading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bPerfectShot
    /// </summary>
    public unsafe bool bPerfectShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bLoseAccuracyOverTime
    /// </summary>
    public unsafe bool bLoseAccuracyOverTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: AudioTurrentMovingH
    /// </summary>
    public unsafe bool AudioTurrentMovingH
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: AudioTurrentMovingV
    /// </summary>
    public unsafe bool AudioTurrentMovingV
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bDisableCannonAimAtTargets
    /// </summary>
    public unsafe bool bDisableCannonAimAtTargets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// BoolProperty: bHalfFireRate
    /// </summary>
    public unsafe bool bHalfFireRate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2396); }
    }

    /// <summary>
    /// NameProperty: CannonYawBone
    /// </summary>
    public unsafe BmSDK.FName CannonYawBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// NameProperty: CannonPitchBone
    /// </summary>
    public unsafe BmSDK.FName CannonPitchBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// NameProperty: CannonSocket
    /// </summary>
    public unsafe BmSDK.FName CannonSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// ObjectProperty: GunFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GunFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// ObjectProperty: GunImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GunImpactFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorImpactEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RiotSuppressorImpactEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorMuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RiotSuppressorMuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorTracerSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RiotSuppressorTracerSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// ObjectProperty: ChainGunTracerSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChainGunTracerSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// ObjectProperty: ChainGunLoopingShells
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChainGunLoopingShells
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorShell
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RiotSuppressorShell
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorIndividualFireEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotSuppressorIndividualFireEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorHitSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotSuppressorHitSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// ObjectProperty: ChainGunOverheatSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChainGunOverheatSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// ObjectProperty: ChainGunCooledSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChainGunCooledSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// ObjectProperty: EMPTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor EMPTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// ObjectProperty: RiotSuppressorTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor RiotSuppressorTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// ObjectProperty: SuppressFireTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor SuppressFireTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// ObjectProperty: GunSpinController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone GunSpinController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// ObjectProperty: ComboFireStartEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ComboFireStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// ObjectProperty: ComboFireStopEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ComboFireStopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// ObjectProperty: ComboFireLoopingEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ComboFireLoopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// ObjectProperty: EnterComboSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EnterComboSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// ObjectProperty: ExitComboSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ExitComboSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// ObjectProperty: TankHeadShotFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform TankHeadShotFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ObjectProperty: RayCheckActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor RayCheckActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ComponentProperty: ChainGunShells
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ChainGunShells
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ClassProperty: DamageType
    /// </summary>
    public unsafe BmSDK.Class DamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// IntProperty: GunYawOffset
    /// </summary>
    public unsafe int GunYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// StructProperty: TargetGunRotation
    /// </summary>
    public unsafe BmSDK.Rotator TargetGunRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// StructProperty: TargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 TargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetRange
    /// </summary>
    public unsafe float AutoTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2652); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetAngle
    /// </summary>
    public unsafe float AutoTargetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetAngleAimed
    /// </summary>
    public unsafe float AutoTargetAngleAimed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2660); }
    }

    /// <summary>
    /// FloatProperty: ImpactMomentum
    /// </summary>
    public unsafe float ImpactMomentum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// FloatProperty: RecoilImpulse
    /// </summary>
    public unsafe float RecoilImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2668); }
    }

    /// <summary>
    /// FloatProperty: InaccuracyAngle
    /// </summary>
    public unsafe float InaccuracyAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// IntProperty: LaunchID
    /// </summary>
    public unsafe int LaunchID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2676); }
    }

    /// <summary>
    /// FloatProperty: HeatUpPerSecond
    /// </summary>
    public unsafe float HeatUpPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// FloatProperty: HeadDownPerSecond
    /// </summary>
    public unsafe float HeadDownPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2684); }
    }

    /// <summary>
    /// FloatProperty: OverheatOffValue
    /// </summary>
    public unsafe float OverheatOffValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// FloatProperty: CurrentHeatLevel
    /// </summary>
    public unsafe float CurrentHeatLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2692); }
    }

    /// <summary>
    /// StructProperty: HeatBarStart
    /// </summary>
    public unsafe System.Numerics.Vector2 HeatBarStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// StructProperty: HeatBarSize
    /// </summary>
    public unsafe System.Numerics.Vector2 HeatBarSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// FloatProperty: ChainGunMaxSpinSpeed
    /// </summary>
    public unsafe float ChainGunMaxSpinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2712); }
    }

    /// <summary>
    /// FloatProperty: ChainGunSpinAccel
    /// </summary>
    public unsafe float ChainGunSpinAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2716); }
    }

    /// <summary>
    /// FloatProperty: ChainGunSpinDecel
    /// </summary>
    public unsafe float ChainGunSpinDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// FloatProperty: CurrentChainGunSpin
    /// </summary>
    public unsafe float CurrentChainGunSpin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }

    /// <summary>
    /// FloatProperty: CurrentChainGunSpinSpeed
    /// </summary>
    public unsafe float CurrentChainGunSpinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }
    }

    /// <summary>
    /// FloatProperty: RiotSuppressorLockOnAngle
    /// </summary>
    public unsafe float RiotSuppressorLockOnAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }

    /// <summary>
    /// FloatProperty: RiotSuppressorRange
    /// </summary>
    public unsafe float RiotSuppressorRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// FloatProperty: RiotSuppressorFiringInterval
    /// </summary>
    public unsafe float RiotSuppressorFiringInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }

    /// <summary>
    /// FloatProperty: RiotSuppressorVillainImpulse
    /// </summary>
    public unsafe float RiotSuppressorVillainImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2744); }
    }

    /// <summary>
    /// StructProperty: RiotSuppressorFireScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct RiotSuppressorFireScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2748); }
    }

    /// <summary>
    /// FloatProperty: ComboFiringInterval
    /// </summary>
    public unsafe float ComboFiringInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2904); }
    }

    /// <summary>
    /// FloatProperty: MinTurretPitch
    /// </summary>
    public unsafe float MinTurretPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }

    /// <summary>
    /// FloatProperty: MaxTurretPitch
    /// </summary>
    public unsafe float MaxTurretPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2912); }
    }

    /// <summary>
    /// IntProperty: ChainGunDamage
    /// </summary>
    public unsafe int ChainGunDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2916); }
    }

    /// <summary>
    /// IntProperty: UpgradedDamage
    /// </summary>
    public unsafe int UpgradedDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2920); }
    }

    /// <summary>
    /// FloatProperty: EMPLockOnTime
    /// </summary>
    public unsafe float EMPLockOnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// FloatProperty: EMPLockOn
    /// </summary>
    public unsafe float EMPLockOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }
    }

    /// <summary>
    /// IntProperty: NumSuccessiveMisses
    /// </summary>
    public unsafe int NumSuccessiveMisses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2932); }
    }

    /// <summary>
    /// NameProperty: TracerLifetimeParamName
    /// </summary>
    public unsafe BmSDK.FName TracerLifetimeParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2936); }
    }

    /// <summary>
    /// FloatProperty: TracerFXMaxRange
    /// </summary>
    public unsafe float TracerFXMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

    /// <summary>
    /// NameProperty: ChainGunShellsSocket
    /// </summary>
    public unsafe BmSDK.FName ChainGunShellsSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2948); }
    }

    /// <summary>
    /// NameProperty: RiotSuppressorShellsSocket
    /// </summary>
    public unsafe BmSDK.FName RiotSuppressorShellsSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2956); }
    }

    /// <summary>
    /// ArrayProperty: RiotSuppressorImpactBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> RiotSuppressorImpactBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2964); }
    }

    /// <summary>
    /// StructProperty: ChainGunScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ChainGunScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2980); }
    }

    /// <summary>
    /// IntProperty: AmmoPerMagazine
    /// </summary>
    public unsafe int AmmoPerMagazine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3136); }
    }

    /// <summary>
    /// IntProperty: CurrentAmmo
    /// </summary>
    public unsafe int CurrentAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3140); }
    }

    /// <summary>
    /// FloatProperty: ReloadTime
    /// </summary>
    public unsafe float ReloadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3144); }
    }

    /// <summary>
    /// StructProperty: InaccuracyVsTime
    /// </summary>
    public unsafe BmSDK.GameObject.FInterpCurveFloat InaccuracyVsTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }

    /// <summary>
    /// FloatProperty: InaccuracyDropMultiplier
    /// </summary>
    public unsafe float InaccuracyDropMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }

    /// <summary>
    /// FloatProperty: MaxHeadshotAccuracyAngle
    /// </summary>
    public unsafe float MaxHeadshotAccuracyAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3172); }
    }

    /// <summary>
    /// StructProperty: InaccuracyVsTimeUpgrade
    /// </summary>
    public unsafe BmSDK.GameObject.FInterpCurveFloat InaccuracyVsTimeUpgrade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 3176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3176); }
    }

    /// <summary>
    /// FloatProperty: CurrentInaccuracyTime
    /// </summary>
    public unsafe float CurrentInaccuracyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3196); }
    }

    /// <summary>
    /// FloatProperty: CurrentAccuracyZeroToOne
    /// </summary>
    public unsafe float CurrentAccuracyZeroToOne
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }

    /// <summary>
    /// FloatProperty: InaccuracyMaxValueInverse
    /// </summary>
    public unsafe float InaccuracyMaxValueInverse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }

    /// <summary>
    /// IntProperty: AudioOldTurretPitch
    /// </summary>
    public unsafe int AudioOldTurretPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }
    }

    /// <summary>
    /// ByteProperty: CurrentMode
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileCannon.EBatmobileCannonMode CurrentMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileCannon.EBatmobileCannonMode>(Ptr + 3212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3212); }
    }

    /// <summary>
    /// ByteProperty: PendingMode
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileCannon.EBatmobileCannonMode PendingMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileCannon.EBatmobileCannonMode>(Ptr + 3213); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3213); }
    }

    /// <summary>
    /// FloatProperty: DamageRemainder
    /// </summary>
    public unsafe float DamageRemainder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3216); }
    }
}
