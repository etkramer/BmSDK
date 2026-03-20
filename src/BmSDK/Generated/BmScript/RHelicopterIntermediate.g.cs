#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RHelicopterIntermediate<br/>
/// (flags = 0)
/// </summary>
public partial class RHelicopterIntermediate : BmSDK.BmGame.RHelicopterIntermediateBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RHelicopterIntermediate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHelicopterIntermediate() { }

    /// <summary>
    /// Constructs a new RHelicopterIntermediate
    /// </summary>
    public RHelicopterIntermediate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHelicopterIntermediate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHelicopterIntermediate(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediate>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediate>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediate>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediate>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediate>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediate>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterIntermediate>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: StartPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint StartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// ObjectProperty: ChaseVolumeBounds
    /// </summary>
    public unsafe BmSDK.BmGame.RDroneChaseVolume ChaseVolumeBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDroneChaseVolume>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// ObjectProperty: CurrentRiotZone
    /// </summary>
    public unsafe BmSDK.BmScript.RRiotZoneVolume CurrentRiotZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RRiotZoneVolume>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// ObjectProperty: DialogueTriggerEvent
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqEvent_HelicopterDialogueTrigger DialogueTriggerEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqEvent_HelicopterDialogueTrigger>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// ObjectProperty: HelicopterHangPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHangPointSpawnable HelicopterHangPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHangPointSpawnable>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// ObjectProperty: CurrentControlVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RHelicopterControlVolume CurrentControlVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterControlVolume>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// ObjectProperty: ChaingunFiringEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChaingunFiringEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// ObjectProperty: RocketLockonEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RocketLockonEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// ObjectProperty: RocketLockonEventStop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RocketLockonEventStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// ObjectProperty: ChaingunSpinUpEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChaingunSpinUpEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// ObjectProperty: ChaingunSpinDownEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChaingunSpinDownEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// ObjectProperty: BlindedLoop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BlindedLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// ObjectProperty: SpottedEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SpottedEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ObjectProperty: HitByRECFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitByRECFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ObjectProperty: SearchLightMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SearchLightMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ObjectProperty: BatmanKnockbackMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BatmanKnockbackMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// ObjectProperty: KnockbackSentryLookAtDefault
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget KnockbackSentryLookAtDefault
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// ObjectProperty: DeadVehicleArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle DeadVehicleArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// ArrayProperty: HighPriorityTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RHelicopterIntermediate.FHelicopterHighPriorityTarget> HighPriorityTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RHelicopterIntermediate.FHelicopterHighPriorityTarget>>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// IntProperty: CurrentHighPriorityTarget
    /// </summary>
    public unsafe int CurrentHighPriorityTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// BoolProperty: bHasMachineGun
    /// </summary>
    public unsafe bool bHasMachineGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bWatchBatmanFight
    /// </summary>
    public unsafe bool bWatchBatmanFight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bAttackBatman
    /// </summary>
    public unsafe bool bAttackBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bHasRockets
    /// </summary>
    public unsafe bool bHasRockets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bAllowGrappleTo
    /// </summary>
    public unsafe bool bAllowGrappleTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreGadgets
    /// </summary>
    public unsafe bool bIgnoreGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bWatchRiotZones
    /// </summary>
    public unsafe bool bWatchRiotZones
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bBlindFireEnabled
    /// </summary>
    public unsafe bool bBlindFireEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: RocketLeftRightToggle
    /// </summary>
    public unsafe bool RocketLeftRightToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bTemporarilyAllowedToAttack
    /// </summary>
    public unsafe bool bTemporarilyAllowedToAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: CollisionAlwaysOn
    /// </summary>
    public unsafe bool CollisionAlwaysOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: ChaseMovementPathingFailed
    /// </summary>
    public unsafe bool ChaseMovementPathingFailed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bForceHighDetail
    /// </summary>
    public unsafe bool bForceHighDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bWasWaitingWhenBatmanSpotted
    /// </summary>
    public unsafe bool bWasWaitingWhenBatmanSpotted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: BatmanHasBeenSeenEver
    /// </summary>
    public unsafe bool BatmanHasBeenSeenEver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: ChaingunJammed
    /// </summary>
    public unsafe bool ChaingunJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: HiddenLastUpdate
    /// </summary>
    public unsafe bool HiddenLastUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: BlindedLastUpdate
    /// </summary>
    public unsafe bool BlindedLastUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: BlindedFlicker
    /// </summary>
    public unsafe bool BlindedFlicker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: ChainGunEffectsActive
    /// </summary>
    public unsafe bool ChainGunEffectsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: ChainGunJammingEffectsActive
    /// </summary>
    public unsafe bool ChainGunJammingEffectsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: RocketLockonActive
    /// </summary>
    public unsafe bool RocketLockonActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: ChaingunIsSpinning
    /// </summary>
    public unsafe bool ChaingunIsSpinning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: AnnouncedBatmanKilled
    /// </summary>
    public unsafe bool AnnouncedBatmanKilled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: SearchlightViewingBatman
    /// </summary>
    public unsafe bool SearchlightViewingBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bSavedAttackEnabled
    /// </summary>
    public unsafe bool bSavedAttackEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bHandleLightsInChild
    /// </summary>
    public unsafe bool bHandleLightsInChild
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: HighSpeedPursuit
    /// </summary>
    public unsafe bool HighSpeedPursuit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: StrafeGunsOn
    /// </summary>
    public unsafe bool StrafeGunsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: InitialiseInGuardAndKnockbackState
    /// </summary>
    public unsafe bool InitialiseInGuardAndKnockbackState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bInXrayMode
    /// </summary>
    public unsafe bool bInXrayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// FloatProperty: GunShotTime
    /// </summary>
    public unsafe float GunShotTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// FloatProperty: RocketShotTime
    /// </summary>
    public unsafe float RocketShotTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2676); }
    }

    /// <summary>
    /// FloatProperty: RocketShotTimeDoubleShot
    /// </summary>
    public unsafe float RocketShotTimeDoubleShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// StrProperty: InvestigateTitle
    /// </summary>
    public unsafe BmSDK.FString InvestigateTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2684); }
    }

    /// <summary>
    /// StrProperty: InvestigateDetail
    /// </summary>
    public unsafe BmSDK.FString InvestigateDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2700); }
    }

    /// <summary>
    /// FloatProperty: RiotLostContactTimer
    /// </summary>
    public unsafe float RiotLostContactTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2716); }
    }

    /// <summary>
    /// FloatProperty: TimeWatchingRiot
    /// </summary>
    public unsafe float TimeWatchingRiot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// FloatProperty: TimeWatchingRioter
    /// </summary>
    public unsafe float TimeWatchingRioter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }

    /// <summary>
    /// FloatProperty: GunDamage
    /// </summary>
    public unsafe float GunDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }
    }

    /// <summary>
    /// FloatProperty: RocketDamage
    /// </summary>
    public unsafe float RocketDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }

    /// <summary>
    /// FloatProperty: RocketDamageRadius
    /// </summary>
    public unsafe float RocketDamageRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// IntProperty: RocketSalvoSize
    /// </summary>
    public unsafe int RocketSalvoSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }

    /// <summary>
    /// FloatProperty: fAnnoyedByGadget
    /// </summary>
    public unsafe float fAnnoyedByGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2744); }
    }

    /// <summary>
    /// FloatProperty: WindFrequency
    /// </summary>
    public unsafe float WindFrequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2748); }
    }

    /// <summary>
    /// FloatProperty: WindStrength
    /// </summary>
    public unsafe float WindStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// StructProperty: WindDirection
    /// </summary>
    public unsafe BmSDK.Rotator WindDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 2756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2756); }
    }

    /// <summary>
    /// FloatProperty: PauseTime
    /// </summary>
    public unsafe float PauseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// FloatProperty: LastSeenTime
    /// </summary>
    public unsafe float LastSeenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2772); }
    }

    /// <summary>
    /// FloatProperty: TimeWatchingBatman
    /// </summary>
    public unsafe float TimeWatchingBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2776); }
    }

    /// <summary>
    /// FloatProperty: LookAtTime
    /// </summary>
    public unsafe float LookAtTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }

    /// <summary>
    /// ArrayProperty: LookAtOrder
    /// </summary>
    public unsafe BmSDK.TArray<int> LookAtOrder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }

    /// <summary>
    /// IntProperty: LookAtIndex
    /// </summary>
    public unsafe int LookAtIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2800); }
    }

    /// <summary>
    /// FloatProperty: LastTimeWatchingBatman
    /// </summary>
    public unsafe float LastTimeWatchingBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2804); }
    }

    /// <summary>
    /// FloatProperty: DialogueTimeStamp
    /// </summary>
    public unsafe float DialogueTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2808); }
    }

    /// <summary>
    /// FloatProperty: MinPeriodBetweenDialogue
    /// </summary>
    public unsafe float MinPeriodBetweenDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2812); }
    }

    /// <summary>
    /// ByteProperty: MostRecentDialogueEnum
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqEvent_HelicopterDialogueTrigger.HeliDialogue MostRecentDialogueEnum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqEvent_HelicopterDialogueTrigger.HeliDialogue>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// ByteProperty: CurrentAttackMode
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopterIntermediate.HeliAttackMode CurrentAttackMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopterIntermediate.HeliAttackMode>(Ptr + 2817); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2817); }
    }

    /// <summary>
    /// ByteProperty: TargetAttackMode
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopterIntermediate.HeliAttackMode TargetAttackMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopterIntermediate.HeliAttackMode>(Ptr + 2818); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2818); }
    }

    /// <summary>
    /// ByteProperty: UnawareColour
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopterIntermediate.ELightColour UnawareColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopterIntermediate.ELightColour>(Ptr + 2819); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2819); }
    }

    /// <summary>
    /// FloatProperty: LastSniperEventTime
    /// </summary>
    public unsafe float LastSniperEventTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2820); }
    }

    /// <summary>
    /// FloatProperty: ChaingunRepairTimestamp
    /// </summary>
    public unsafe float ChaingunRepairTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }
    }

    /// <summary>
    /// FloatProperty: ChaingunRepairPeriod
    /// </summary>
    public unsafe float ChaingunRepairPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2828); }
    }

    /// <summary>
    /// FloatProperty: JammingImmunityPeriod
    /// </summary>
    public unsafe float JammingImmunityPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2832); }
    }

    /// <summary>
    /// IntProperty: UniqueIndex
    /// </summary>
    public unsafe int UniqueIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2836); }
    }

    /// <summary>
    /// ArrayProperty: OldMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> OldMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }

    /// <summary>
    /// FloatProperty: BlindedTransitionTimer
    /// </summary>
    public unsafe float BlindedTransitionTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2856); }
    }

    /// <summary>
    /// FloatProperty: DistSquaredForHighDetail
    /// </summary>
    public unsafe float DistSquaredForHighDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2860); }
    }

    /// <summary>
    /// FloatProperty: CannotChangeAttackModeTimer
    /// </summary>
    public unsafe float CannotChangeAttackModeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2864); }
    }

    /// <summary>
    /// ArrayProperty: AudioMovementLoops
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> AudioMovementLoops
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 2868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2868); }
    }

    /// <summary>
    /// FloatProperty: ChainGunDeployPeriod
    /// </summary>
    public unsafe float ChainGunDeployPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2884); }
    }

    /// <summary>
    /// FloatProperty: RocketDeployPeriod
    /// </summary>
    public unsafe float RocketDeployPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2888); }
    }

    /// <summary>
    /// FloatProperty: RocketLockonTime
    /// </summary>
    public unsafe float RocketLockonTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }

    /// <summary>
    /// IntProperty: MaterialStartIndex
    /// </summary>
    public unsafe int MaterialStartIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2896); }
    }

    /// <summary>
    /// IntProperty: MaterialEndIndex
    /// </summary>
    public unsafe int MaterialEndIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2900); }
    }

    /// <summary>
    /// IntProperty: MaterialExclude
    /// </summary>
    public unsafe int MaterialExclude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2904); }
    }

    /// <summary>
    /// IntProperty: MaterialExclude2
    /// </summary>
    public unsafe int MaterialExclude2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }

    /// <summary>
    /// FloatProperty: PursuitAltitude
    /// </summary>
    public unsafe float PursuitAltitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2912); }
    }

    /// <summary>
    /// FloatProperty: PursuitDistance
    /// </summary>
    public unsafe float PursuitDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2916); }
    }

    /// <summary>
    /// FloatProperty: StrafeAngle
    /// </summary>
    public unsafe float StrafeAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2920); }
    }

    /// <summary>
    /// FloatProperty: StrafeAngleCos
    /// </summary>
    public unsafe float StrafeAngleCos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// FloatProperty: StrafeAngleSin
    /// </summary>
    public unsafe float StrafeAngleSin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }
    }

    /// <summary>
    /// FloatProperty: KnockbackThreatenRange
    /// </summary>
    public unsafe float KnockbackThreatenRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2932); }
    }

    /// <summary>
    /// FloatProperty: KnockbackShootRange
    /// </summary>
    public unsafe float KnockbackShootRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2936); }
    }

    /// <summary>
    /// FloatProperty: KnockbackGrappleRange
    /// </summary>
    public unsafe float KnockbackGrappleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }

    /// <summary>
    /// FloatProperty: KnockbackSpread
    /// </summary>
    public unsafe float KnockbackSpread
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

    /// <summary>
    /// StructProperty: KnockbackInitialLookAt
    /// </summary>
    public unsafe BmSDK.Rotator KnockbackInitialLookAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 2948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2948); }
    }

    /// <summary>
    /// IntProperty: KnockbackInitialPitch
    /// </summary>
    public unsafe int KnockbackInitialPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2960); }
    }

    /// <summary>
    /// StructProperty: KnockbackInitialPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 KnockbackInitialPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2964); }
    }

    /// <summary>
    /// FloatProperty: maxGuardVelocity
    /// </summary>
    public unsafe float maxGuardVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2976); }
    }

    /// <summary>
    /// FloatProperty: DeathImpulse
    /// </summary>
    public unsafe float DeathImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2980); }
    }

    /// <summary>
    /// FloatProperty: DeathImpulseRadius
    /// </summary>
    public unsafe float DeathImpulseRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2984); }
    }

    /// <summary>
    /// StructProperty: ExplosionScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ExplosionScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2988); }
    }

    /// <summary>
    /// IntProperty: BatmanVehicleState
    /// </summary>
    public unsafe int BatmanVehicleState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3144); }
    }
}
