#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RHelicopterIntermediate<br/>
/// (size = 0)
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
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// ObjectProperty: ChaseVolumeBounds
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChaseVolumeBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// ObjectProperty: CurrentRiotZone
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentRiotZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// ObjectProperty: DialogueTriggerEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DialogueTriggerEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// ObjectProperty: HelicopterHangPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HelicopterHangPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// ObjectProperty: CurrentControlVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentControlVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// ObjectProperty: ChaingunFiringEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChaingunFiringEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// ObjectProperty: RocketLockonEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RocketLockonEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// ObjectProperty: RocketLockonEventStop
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RocketLockonEventStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// ObjectProperty: ChaingunSpinUpEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChaingunSpinUpEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// ObjectProperty: ChaingunSpinDownEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChaingunSpinDownEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// ObjectProperty: BlindedLoop
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BlindedLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// ObjectProperty: SpottedEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpottedEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ObjectProperty: HitByRECFx
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HitByRECFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ObjectProperty: SearchLightMIC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SearchLightMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ObjectProperty: BatmanKnockbackMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmanKnockbackMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// ObjectProperty: KnockbackSentryLookAtDefault
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KnockbackSentryLookAtDefault
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// ObjectProperty: DeadVehicleArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DeadVehicleArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// ArrayProperty: HighPriorityTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> HighPriorityTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2648); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bWatchBatmanFight
    /// </summary>
    public unsafe bool bWatchBatmanFight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bAttackBatman
    /// </summary>
    public unsafe bool bAttackBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bHasRockets
    /// </summary>
    public unsafe bool bHasRockets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bAllowGrappleTo
    /// </summary>
    public unsafe bool bAllowGrappleTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreGadgets
    /// </summary>
    public unsafe bool bIgnoreGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bWatchRiotZones
    /// </summary>
    public unsafe bool bWatchRiotZones
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bBlindFireEnabled
    /// </summary>
    public unsafe bool bBlindFireEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: RocketLeftRightToggle
    /// </summary>
    public unsafe bool RocketLeftRightToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bTemporarilyAllowedToAttack
    /// </summary>
    public unsafe bool bTemporarilyAllowedToAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: CollisionAlwaysOn
    /// </summary>
    public unsafe bool CollisionAlwaysOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: ChaseMovementPathingFailed
    /// </summary>
    public unsafe bool ChaseMovementPathingFailed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bForceHighDetail
    /// </summary>
    public unsafe bool bForceHighDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bWasWaitingWhenBatmanSpotted
    /// </summary>
    public unsafe bool bWasWaitingWhenBatmanSpotted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: BatmanHasBeenSeenEver
    /// </summary>
    public unsafe bool BatmanHasBeenSeenEver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: ChaingunJammed
    /// </summary>
    public unsafe bool ChaingunJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: HiddenLastUpdate
    /// </summary>
    public unsafe bool HiddenLastUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: BlindedLastUpdate
    /// </summary>
    public unsafe bool BlindedLastUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: BlindedFlicker
    /// </summary>
    public unsafe bool BlindedFlicker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: ChainGunEffectsActive
    /// </summary>
    public unsafe bool ChainGunEffectsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: ChainGunJammingEffectsActive
    /// </summary>
    public unsafe bool ChainGunJammingEffectsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: RocketLockonActive
    /// </summary>
    public unsafe bool RocketLockonActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: ChaingunIsSpinning
    /// </summary>
    public unsafe bool ChaingunIsSpinning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: AnnouncedBatmanKilled
    /// </summary>
    public unsafe bool AnnouncedBatmanKilled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: SearchlightViewingBatman
    /// </summary>
    public unsafe bool SearchlightViewingBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bSavedAttackEnabled
    /// </summary>
    public unsafe bool bSavedAttackEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bHandleLightsInChild
    /// </summary>
    public unsafe bool bHandleLightsInChild
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: HighSpeedPursuit
    /// </summary>
    public unsafe bool HighSpeedPursuit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: StrafeGunsOn
    /// </summary>
    public unsafe bool StrafeGunsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: InitialiseInGuardAndKnockbackState
    /// </summary>
    public unsafe bool InitialiseInGuardAndKnockbackState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
    }

    /// <summary>
    /// BoolProperty: bInXrayMode
    /// </summary>
    public unsafe bool bInXrayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2668); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WindDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2756); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> LookAtOrder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 2784); }
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
    public unsafe byte MostRecentDialogueEnum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// ByteProperty: CurrentAttackMode
    /// </summary>
    public unsafe byte CurrentAttackMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2817); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2817); }
    }

    /// <summary>
    /// ByteProperty: TargetAttackMode
    /// </summary>
    public unsafe byte TargetAttackMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2818); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2818); }
    }

    /// <summary>
    /// ByteProperty: UnawareColour
    /// </summary>
    public unsafe byte UnawareColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2819); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> OldMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 2840); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> AudioMovementLoops
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 2868); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT KnockbackInitialLookAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2948); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT KnockbackInitialPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2964); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExplosionScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2988); }
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
