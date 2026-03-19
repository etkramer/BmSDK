#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerCombat<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnPlayerCombat : BmSDK.BmGame.RPawnPlayerAnim, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerCombat() { }

    /// <summary>
    /// Constructs a new RPawnPlayerCombat
    /// </summary>
    public RPawnPlayerCombat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayerCombat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerCombat(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: CombatAnimRecord
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CombatAnimRecord
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3052); }
    }

    /// <summary>
    /// ComponentProperty: ChargeFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChargeFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3060); }
    }

    /// <summary>
    /// BoolProperty: bChargingFXActive
    /// </summary>
    public unsafe bool bChargingFXActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bHas2Evades
    /// </summary>
    public unsafe bool bHas2Evades
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bHandcuffed
    /// </summary>
    public unsafe bool bHandcuffed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bCanDoStun
    /// </summary>
    public unsafe bool bCanDoStun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bCanDoCounter
    /// </summary>
    public unsafe bool bCanDoCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bCanDoSpecials
    /// </summary>
    public unsafe bool bCanDoSpecials
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bBreakHandcuffsNextCounter
    /// </summary>
    public unsafe bool bBreakHandcuffsNextCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bAutoSetAllowMovementExit
    /// </summary>
    public unsafe bool bAutoSetAllowMovementExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bCanDoAerialJump
    /// </summary>
    public unsafe bool bCanDoAerialJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bCausesOutcastsToFlee
    /// </summary>
    public unsafe bool bCausesOutcastsToFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bCanDoComboTakedownOnPredator
    /// </summary>
    public unsafe bool bCanDoComboTakedownOnPredator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bIncreasedCombatPower
    /// </summary>
    public unsafe bool bIncreasedCombatPower
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreNextFinishedCombatMove
    /// </summary>
    public unsafe bool bIgnoreNextFinishedCombatMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredVenom
    /// </summary>
    public unsafe bool bRegisteredVenom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bUpgradedBatsuit
    /// </summary>
    public unsafe bool bUpgradedBatsuit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bSuspendKeepInView
    /// </summary>
    public unsafe bool bSuspendKeepInView
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bStrikeShouldMiss
    /// </summary>
    public unsafe bool bStrikeShouldMiss
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bShouldCancelFloorTakedown
    /// </summary>
    public unsafe bool bShouldCancelFloorTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bSpecialMovesDisabled
    /// </summary>
    public unsafe bool bSpecialMovesDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bDisplayTargettingLogs
    /// </summary>
    public unsafe bool bDisplayTargettingLogs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bIsBot
    /// </summary>
    public unsafe bool bIsBot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bDualMoveQueued
    /// </summary>
    public unsafe bool bDualMoveQueued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// ObjectProperty: ChargeRumble
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChargeRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3072); }
    }

    /// <summary>
    /// ObjectProperty: StunMoveProp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StunMoveProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3080); }
    }

    /// <summary>
    /// ObjectProperty: PreStrikeHitAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreStrikeHitAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3088); }
    }

    /// <summary>
    /// ObjectProperty: LastBatclawTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastBatclawTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3096); }
    }

    /// <summary>
    /// ObjectProperty: LastDmgCauser
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastDmgCauser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3104); }
    }

    /// <summary>
    /// ObjectProperty: CheckCameraTargetActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CheckCameraTargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3112); }
    }

    /// <summary>
    /// ObjectProperty: QuickStrike1
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT QuickStrike1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3120); }
    }

    /// <summary>
    /// ObjectProperty: QuickStrike2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT QuickStrike2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3128); }
    }

    /// <summary>
    /// ObjectProperty: HeavyStrike1
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HeavyStrike1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3136); }
    }

    /// <summary>
    /// ObjectProperty: HeavyStrike2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HeavyStrike2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3144); }
    }

    /// <summary>
    /// ObjectProperty: WeaponGrabbedLeft
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeaponGrabbedLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3152); }
    }

    /// <summary>
    /// ObjectProperty: WeaponGrabbedRight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeaponGrabbedRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// ObjectProperty: StunSoundEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StunSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }

    /// <summary>
    /// ObjectProperty: CurrWeaponSwitchName
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrWeaponSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3176); }
    }

    /// <summary>
    /// ObjectProperty: CombatBotVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatBotVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }

    /// <summary>
    /// ObjectProperty: StrikeWoosh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StrikeWoosh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3192); }
    }

    /// <summary>
    /// ObjectProperty: StrikeWooshWeak
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StrikeWooshWeak
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }

    /// <summary>
    /// ObjectProperty: DualPlayTargetAura
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DualPlayTargetAura
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }
    }

    /// <summary>
    /// ObjectProperty: AfterCombatAnimCustomAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AfterCombatAnimCustomAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3216); }
    }

    /// <summary>
    /// ObjectProperty: DualStrikeInitiateLine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DualStrikeInitiateLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3224); }
    }

    /// <summary>
    /// ObjectProperty: DualStrikeJoinLine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DualStrikeJoinLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3232); }
    }

    /// <summary>
    /// ObjectProperty: DualTakedownInitiateLine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DualTakedownInitiateLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }
    }

    /// <summary>
    /// ObjectProperty: DualPlayTalk
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DualPlayTalk
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3248); }
    }

    /// <summary>
    /// ObjectProperty: DualPlayGotHitLine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DualPlayGotHitLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3256); }
    }

    /// <summary>
    /// ObjectProperty: DualPlayPraiseLine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DualPlayPraiseLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3264); }
    }

    /// <summary>
    /// ObjectProperty: BeatdownHitReactionAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BeatdownHitReactionAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3272); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAerialAttackAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerAerialAttackAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3280); }
    }

    /// <summary>
    /// ObjectProperty: VillainAerialAttackAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainAerialAttackAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3288); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorTakedownAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerFloorTakedownAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3296); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorTakedownAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainFloorTakedownAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3304); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerCounterAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3312); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainCounterAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimsets_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraAnimsets_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3328); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorPickupAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerFloorPickupAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3336); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorPickupAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainFloorPickupAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3344); }
    }

    /// <summary>
    /// ObjectProperty: PlayerEnvTakedownAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerEnvTakedownAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3352); }
    }

    /// <summary>
    /// ObjectProperty: VillainEnvTakedownAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainEnvTakedownAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3360); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDualPlayAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerDualPlayAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3368); }
    }

    /// <summary>
    /// ObjectProperty: VillainDualPlayAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainDualPlayAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3376); }
    }

    /// <summary>
    /// ObjectProperty: ChargeAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChargeAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3384); }
    }

    /// <summary>
    /// ObjectProperty: PlayerChargeAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerChargeAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3392); }
    }

    /// <summary>
    /// ObjectProperty: PlayerGrabAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerGrabAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3400); }
    }

    /// <summary>
    /// ObjectProperty: VillainGrabAnimset_TG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainGrabAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3408); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimset_Pipe
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraAnimset_Pipe
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3416); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset_Knife
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerCounterAnimset_Knife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3424); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset_Knife
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainCounterAnimset_Knife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3432); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAerialAnimset_Shield
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerAerialAnimset_Shield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3440); }
    }

    /// <summary>
    /// ObjectProperty: VillainAerialAnimset_Shield
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainAerialAnimset_Shield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3448); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCombatAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerCombatAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3456); }
    }

    /// <summary>
    /// ObjectProperty: VillainCombatAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainCombatAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3464); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDualPlayAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerDualPlayAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3472); }
    }

    /// <summary>
    /// ObjectProperty: VillainDualPlayAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainDualPlayAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3488); }
    }

    /// <summary>
    /// ObjectProperty: BeatdownHitReactionAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BeatdownHitReactionAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3496); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAerialAttackAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerAerialAttackAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }
    }

    /// <summary>
    /// ObjectProperty: VillainAerialAttackAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainAerialAttackAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorTakedownAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerFloorTakedownAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3520); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorTakedownAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainFloorTakedownAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3528); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerCounterAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3536); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainCounterAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3544); }
    }

    /// <summary>
    /// ObjectProperty: BatclawAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatclawAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3552); }
    }

    /// <summary>
    /// ObjectProperty: PlayerEnvTakedownAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerEnvTakedownAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }

    /// <summary>
    /// ObjectProperty: VillainEnvTakedownAnimset_CE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainEnvTakedownAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// ObjectProperty: BeatdownHitReactionAnimset_Robot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BeatdownHitReactionAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAerialAnimset_Robot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerAerialAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }

    /// <summary>
    /// ObjectProperty: VillainAerialAnimset_Robot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainAerialAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorTakedownAnimset_Robot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerFloorTakedownAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorTakedownAnimset_Robot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainFloorTakedownAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset_Robot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerCounterAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset_Robot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainCounterAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimset_Robot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorPickupAnimset_Robot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerFloorPickupAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorPickupAnimset_Robot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainFloorPickupAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3648); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDualPlayAnimset_Robot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerDualPlayAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }
    }

    /// <summary>
    /// ObjectProperty: VillainDualPlayAnimset_Robot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainDualPlayAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3664); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimset_MW
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3672); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDualPlayAnimset_MW
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerDualPlayAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }
    }

    /// <summary>
    /// ObjectProperty: VillainDualPlayAnimset_MW
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainDualPlayAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }

    /// <summary>
    /// ObjectProperty: PlayerEnvTakedownAnimset_MW
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerEnvTakedownAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// ObjectProperty: VillainEnvTakedownAnimset_MW
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainEnvTakedownAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3704); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAerialAnimset_MW
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerAerialAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }
    }

    /// <summary>
    /// ObjectProperty: VillainAerialAnimset_MW
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainAerialAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3720); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimset_MG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraAnimset_MG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3728); }
    }

    /// <summary>
    /// ObjectProperty: PlayerEnvTakedownAnimset_MG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerEnvTakedownAnimset_MG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3736); }
    }

    /// <summary>
    /// ObjectProperty: VillainEnvTakedownAnimset_MG
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainEnvTakedownAnimset_MG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3744); }
    }

    /// <summary>
    /// ClassProperty: GFxMovieOmnitronClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GFxMovieOmnitronClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }
    }

    /// <summary>
    /// ClassProperty: GFxMovieRadialGadgetSelectClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GFxMovieRadialGadgetSelectClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3760); }
    }

    /// <summary>
    /// ClassProperty: HudModuleSurveillanceClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HudModuleSurveillanceClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3768); }
    }

    /// <summary>
    /// ClassProperty: HudModuleStoryModeClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HudModuleStoryModeClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3776); }
    }

    /// <summary>
    /// ClassProperty: HudModuleObjectivesClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HudModuleObjectivesClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3784); }
    }

    /// <summary>
    /// ClassProperty: HudModuleTargetsClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HudModuleTargetsClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3792); }
    }

    /// <summary>
    /// ClassProperty: HudModuleRoomNameClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HudModuleRoomNameClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3800); }
    }

    /// <summary>
    /// ClassProperty: HudModuleHealthBarClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HudModuleHealthBarClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3808); }
    }

    /// <summary>
    /// ClassProperty: HudModuleHackingModeClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HudModuleHackingModeClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3816); }
    }

    /// <summary>
    /// ClassProperty: HudModuleExtraSequenceClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HudModuleExtraSequenceClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3824); }
    }

    /// <summary>
    /// ClassProperty: HudModuleDetectiveModeClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HudModuleDetectiveModeClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3832); }
    }

    /// <summary>
    /// ClassProperty: SecondaryGroupCombatMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SecondaryGroupCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }
    }

    /// <summary>
    /// ClassProperty: PrimaryGroupCombatMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PrimaryGroupCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3848); }
    }

    /// <summary>
    /// ComponentProperty: StunFXComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StunFXComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3856); }
    }

    /// <summary>
    /// NameProperty: LastAttackMoveClassName
    /// </summary>
    public unsafe BmSDK.FName LastAttackMoveClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3864); }
    }

    /// <summary>
    /// NameProperty: CharacterName
    /// </summary>
    public unsafe BmSDK.FName CharacterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3872); }
    }

    /// <summary>
    /// NameProperty: CharacterNameFlag
    /// </summary>
    public unsafe BmSDK.FName CharacterNameFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3880); }
    }

    /// <summary>
    /// NameProperty: CharacterGender
    /// </summary>
    public unsafe BmSDK.FName CharacterGender
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3888); }
    }

    /// <summary>
    /// StructProperty: LastPylonCheckLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastPylonCheckLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3896); }
    }

    /// <summary>
    /// ArrayProperty: BoneNameListConversion
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>> BoneNameListConversion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>(Ptr + 3908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3908); }
    }

    /// <summary>
    /// ByteProperty: OverrideInterrogationPose
    /// </summary>
    public unsafe byte OverrideInterrogationPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3924); }
    }

    /// <summary>
    /// ByteProperty: PlayerType
    /// </summary>
    public unsafe byte PlayerType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3925); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3925); }
    }

    /// <summary>
    /// ByteProperty: CheckCameraLookAtSpeed
    /// </summary>
    public unsafe byte CheckCameraLookAtSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3926); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3926); }
    }

    /// <summary>
    /// ArrayProperty: PipeGunDummyAdditiveDisablers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>> PipeGunDummyAdditiveDisablers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>(Ptr + 3928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3928); }
    }

    /// <summary>
    /// ArrayProperty: AutoStrikeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>> AutoStrikeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>(Ptr + 3944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3944); }
    }

    /// <summary>
    /// StructProperty: PrevStrikeInfo
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PrevStrikeInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3960); }
    }

    /// <summary>
    /// ArrayProperty: PrevStrikeTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>> PrevStrikeTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// ArrayProperty: PairedAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>> PairedAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }

    /// <summary>
    /// ArrayProperty: CounterList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>> CounterList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// ArrayProperty: SimultaneousCounterList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>> SimultaneousCounterList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// ArrayProperty: TakedownList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>> TakedownList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }

    /// <summary>
    /// ArrayProperty: ThrowList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>> ThrowList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>(Ptr + 4180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4180); }
    }

    /// <summary>
    /// ArrayProperty: WeaponDestroyList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>> WeaponDestroyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>(Ptr + 4196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4196); }
    }

    /// <summary>
    /// ArrayProperty: WeaponSnatchList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> WeaponSnatchList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 4212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4212); }
    }

    /// <summary>
    /// ArrayProperty: DualStrikeTypeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> DualStrikeTypeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// ArrayProperty: DualStrikeInfoList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> DualStrikeInfoList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 4244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4244); }
    }

    /// <summary>
    /// StructProperty: LastDmgImpulse
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastDmgImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4260); }
    }

    /// <summary>
    /// NameProperty: LastDmgBoneName
    /// </summary>
    public unsafe BmSDK.FName LastDmgBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// ArrayProperty: BeforeCombatAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> BeforeCombatAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// ArrayProperty: AfterCombatAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> AfterCombatAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// StructProperty: CheckCameraTargetOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CheckCameraTargetOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4312); }
    }

    /// <summary>
    /// FloatProperty: CurrFOV
    /// </summary>
    public unsafe float CurrFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4324); }
    }

    /// <summary>
    /// FloatProperty: CurrMaxYawOffset
    /// </summary>
    public unsafe float CurrMaxYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// ArrayProperty: EnemiesAttacking
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> EnemiesAttacking
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 4332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4332); }
    }

    /// <summary>
    /// FloatProperty: BeatdownMinDelay
    /// </summary>
    public unsafe float BeatdownMinDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4348); }
    }

    /// <summary>
    /// FloatProperty: BeatdownDelayMod
    /// </summary>
    public unsafe float BeatdownDelayMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4352); }
    }

    /// <summary>
    /// IntProperty: BeatdownNoDamageHits
    /// </summary>
    public unsafe int BeatdownNoDamageHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4356); }
    }

    /// <summary>
    /// IntProperty: BeatdownDamageMultiplier
    /// </summary>
    public unsafe int BeatdownDamageMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4360); }
    }

    /// <summary>
    /// FloatProperty: JokerfiedAttacks
    /// </summary>
    public unsafe float JokerfiedAttacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4364); }
    }

    /// <summary>
    /// IntProperty: DeathMoves
    /// </summary>
    public unsafe int DeathMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// NameProperty: AfterCombatAnimCustom
    /// </summary>
    public unsafe BmSDK.FName AfterCombatAnimCustom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4372); }
    }

    /// <summary>
    /// FloatProperty: LastDualPlaySpeech
    /// </summary>
    public unsafe float LastDualPlaySpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4380); }
    }

    /// <summary>
    /// FloatProperty: DualPlaySpeechInterval
    /// </summary>
    public unsafe float DualPlaySpeechInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4384); }
    }
}
