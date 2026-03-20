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
    public unsafe BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId CombatAnimRecord
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 3052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3052); }
    }

    /// <summary>
    /// ComponentProperty: ChargeFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ChargeFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3060); }
    }

    /// <summary>
    /// BoolProperty: bChargingFXActive
    /// </summary>
    public unsafe bool bChargingFXActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bHas2Evades
    /// </summary>
    public unsafe bool bHas2Evades
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bHandcuffed
    /// </summary>
    public unsafe bool bHandcuffed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bCanDoStun
    /// </summary>
    public unsafe bool bCanDoStun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bCanDoCounter
    /// </summary>
    public unsafe bool bCanDoCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bCanDoSpecials
    /// </summary>
    public unsafe bool bCanDoSpecials
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bBreakHandcuffsNextCounter
    /// </summary>
    public unsafe bool bBreakHandcuffsNextCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bAutoSetAllowMovementExit
    /// </summary>
    public unsafe bool bAutoSetAllowMovementExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bCanDoAerialJump
    /// </summary>
    public unsafe bool bCanDoAerialJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bCausesOutcastsToFlee
    /// </summary>
    public unsafe bool bCausesOutcastsToFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bCanDoComboTakedownOnPredator
    /// </summary>
    public unsafe bool bCanDoComboTakedownOnPredator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bIncreasedCombatPower
    /// </summary>
    public unsafe bool bIncreasedCombatPower
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreNextFinishedCombatMove
    /// </summary>
    public unsafe bool bIgnoreNextFinishedCombatMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredVenom
    /// </summary>
    public unsafe bool bRegisteredVenom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bUpgradedBatsuit
    /// </summary>
    public unsafe bool bUpgradedBatsuit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bSuspendKeepInView
    /// </summary>
    public unsafe bool bSuspendKeepInView
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bStrikeShouldMiss
    /// </summary>
    public unsafe bool bStrikeShouldMiss
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bShouldCancelFloorTakedown
    /// </summary>
    public unsafe bool bShouldCancelFloorTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bSpecialMovesDisabled
    /// </summary>
    public unsafe bool bSpecialMovesDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bDisplayTargettingLogs
    /// </summary>
    public unsafe bool bDisplayTargettingLogs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bIsBot
    /// </summary>
    public unsafe bool bIsBot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// BoolProperty: bDualMoveQueued
    /// </summary>
    public unsafe bool bDualMoveQueued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3068); }
    }

    /// <summary>
    /// ObjectProperty: ChargeRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ChargeRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 3072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3072); }
    }

    /// <summary>
    /// ObjectProperty: StunMoveProp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh StunMoveProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 3080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3080); }
    }

    /// <summary>
    /// ObjectProperty: PreStrikeHitAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PreStrikeHitAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3088); }
    }

    /// <summary>
    /// ObjectProperty: LastBatclawTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastBatclawTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 3096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3096); }
    }

    /// <summary>
    /// ObjectProperty: LastDmgCauser
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastDmgCauser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3104); }
    }

    /// <summary>
    /// ObjectProperty: CheckCameraTargetActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CheckCameraTargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3112); }
    }

    /// <summary>
    /// ObjectProperty: QuickStrike1
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove_BatmanQuickStrike QuickStrike1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove_BatmanQuickStrike>(Ptr + 3120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3120); }
    }

    /// <summary>
    /// ObjectProperty: QuickStrike2
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove_BatmanQuickStrike QuickStrike2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove_BatmanQuickStrike>(Ptr + 3128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3128); }
    }

    /// <summary>
    /// ObjectProperty: HeavyStrike1
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove_BatmanHeavyStrike HeavyStrike1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove_BatmanHeavyStrike>(Ptr + 3136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3136); }
    }

    /// <summary>
    /// ObjectProperty: HeavyStrike2
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove_BatmanHeavyStrike HeavyStrike2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove_BatmanHeavyStrike>(Ptr + 3144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3144); }
    }

    /// <summary>
    /// ObjectProperty: WeaponGrabbedLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject WeaponGrabbedLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(Ptr + 3152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3152); }
    }

    /// <summary>
    /// ObjectProperty: WeaponGrabbedRight
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject WeaponGrabbedRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// ObjectProperty: StunSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StunSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }

    /// <summary>
    /// ObjectProperty: CurrWeaponSwitchName
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName CurrWeaponSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 3176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3176); }
    }

    /// <summary>
    /// ObjectProperty: CombatBotVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatBotVolume CombatBotVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatBotVolume>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }

    /// <summary>
    /// ObjectProperty: StrikeWoosh
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StrikeWoosh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3192); }
    }

    /// <summary>
    /// ObjectProperty: StrikeWooshWeak
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StrikeWooshWeak
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }

    /// <summary>
    /// ObjectProperty: DualPlayTargetAura
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance DualPlayTargetAura
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 3208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }
    }

    /// <summary>
    /// ObjectProperty: AfterCombatAnimCustomAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AfterCombatAnimCustomAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3216); }
    }

    /// <summary>
    /// ObjectProperty: DualStrikeInitiateLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualStrikeInitiateLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 3224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3224); }
    }

    /// <summary>
    /// ObjectProperty: DualStrikeJoinLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualStrikeJoinLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 3232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3232); }
    }

    /// <summary>
    /// ObjectProperty: DualTakedownInitiateLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualTakedownInitiateLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 3240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }
    }

    /// <summary>
    /// ObjectProperty: DualPlayTalk
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualPlayTalk
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 3248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3248); }
    }

    /// <summary>
    /// ObjectProperty: DualPlayGotHitLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualPlayGotHitLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 3256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3256); }
    }

    /// <summary>
    /// ObjectProperty: DualPlayPraiseLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualPlayPraiseLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 3264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3264); }
    }

    /// <summary>
    /// ObjectProperty: BeatdownHitReactionAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BeatdownHitReactionAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3272); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAerialAttackAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerAerialAttackAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3280); }
    }

    /// <summary>
    /// ObjectProperty: VillainAerialAttackAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainAerialAttackAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3288); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorTakedownAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerFloorTakedownAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3296); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorTakedownAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainFloorTakedownAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3304); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerCounterAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3312); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainCounterAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimsets_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraAnimsets_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3328); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorPickupAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerFloorPickupAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3336); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorPickupAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainFloorPickupAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3344); }
    }

    /// <summary>
    /// ObjectProperty: PlayerEnvTakedownAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerEnvTakedownAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3352); }
    }

    /// <summary>
    /// ObjectProperty: VillainEnvTakedownAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainEnvTakedownAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3360); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDualPlayAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerDualPlayAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3368); }
    }

    /// <summary>
    /// ObjectProperty: VillainDualPlayAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainDualPlayAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3376); }
    }

    /// <summary>
    /// ObjectProperty: ChargeAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ChargeAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3384); }
    }

    /// <summary>
    /// ObjectProperty: PlayerChargeAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerChargeAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3392); }
    }

    /// <summary>
    /// ObjectProperty: PlayerGrabAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerGrabAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3400); }
    }

    /// <summary>
    /// ObjectProperty: VillainGrabAnimset_TG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainGrabAnimset_TG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3408); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimset_Pipe
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraAnimset_Pipe
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3416); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset_Knife
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerCounterAnimset_Knife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3424); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset_Knife
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainCounterAnimset_Knife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3432); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAerialAnimset_Shield
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerAerialAnimset_Shield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3440); }
    }

    /// <summary>
    /// ObjectProperty: VillainAerialAnimset_Shield
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainAerialAnimset_Shield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3448); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCombatAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerCombatAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3456); }
    }

    /// <summary>
    /// ObjectProperty: VillainCombatAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainCombatAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3464); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDualPlayAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerDualPlayAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3472); }
    }

    /// <summary>
    /// ObjectProperty: VillainDualPlayAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainDualPlayAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3488); }
    }

    /// <summary>
    /// ObjectProperty: BeatdownHitReactionAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BeatdownHitReactionAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3496); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAerialAttackAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerAerialAttackAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }
    }

    /// <summary>
    /// ObjectProperty: VillainAerialAttackAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainAerialAttackAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorTakedownAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerFloorTakedownAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3520); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorTakedownAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainFloorTakedownAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3528); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerCounterAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3536); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainCounterAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3544); }
    }

    /// <summary>
    /// ObjectProperty: BatclawAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BatclawAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3552); }
    }

    /// <summary>
    /// ObjectProperty: PlayerEnvTakedownAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerEnvTakedownAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }

    /// <summary>
    /// ObjectProperty: VillainEnvTakedownAnimset_CE
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainEnvTakedownAnimset_CE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// ObjectProperty: BeatdownHitReactionAnimset_Robot
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BeatdownHitReactionAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAerialAnimset_Robot
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerAerialAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }

    /// <summary>
    /// ObjectProperty: VillainAerialAnimset_Robot
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainAerialAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorTakedownAnimset_Robot
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerFloorTakedownAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorTakedownAnimset_Robot
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainFloorTakedownAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset_Robot
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerCounterAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset_Robot
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainCounterAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimset_Robot
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorPickupAnimset_Robot
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerFloorPickupAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorPickupAnimset_Robot
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainFloorPickupAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3648); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDualPlayAnimset_Robot
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerDualPlayAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }
    }

    /// <summary>
    /// ObjectProperty: VillainDualPlayAnimset_Robot
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainDualPlayAnimset_Robot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3664); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimset_MW
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3672); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDualPlayAnimset_MW
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerDualPlayAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }
    }

    /// <summary>
    /// ObjectProperty: VillainDualPlayAnimset_MW
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainDualPlayAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }

    /// <summary>
    /// ObjectProperty: PlayerEnvTakedownAnimset_MW
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerEnvTakedownAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// ObjectProperty: VillainEnvTakedownAnimset_MW
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainEnvTakedownAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3704); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAerialAnimset_MW
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerAerialAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }
    }

    /// <summary>
    /// ObjectProperty: VillainAerialAnimset_MW
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainAerialAnimset_MW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3720); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimset_MG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraAnimset_MG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3728); }
    }

    /// <summary>
    /// ObjectProperty: PlayerEnvTakedownAnimset_MG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerEnvTakedownAnimset_MG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3736); }
    }

    /// <summary>
    /// ObjectProperty: VillainEnvTakedownAnimset_MG
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainEnvTakedownAnimset_MG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3744); }
    }

    /// <summary>
    /// ClassProperty: GFxMovieOmnitronClass
    /// </summary>
    public unsafe BmSDK.Class GFxMovieOmnitronClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }
    }

    /// <summary>
    /// ClassProperty: GFxMovieRadialGadgetSelectClass
    /// </summary>
    public unsafe BmSDK.Class GFxMovieRadialGadgetSelectClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3760); }
    }

    /// <summary>
    /// ClassProperty: HudModuleSurveillanceClass
    /// </summary>
    public unsafe BmSDK.Class HudModuleSurveillanceClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3768); }
    }

    /// <summary>
    /// ClassProperty: HudModuleStoryModeClass
    /// </summary>
    public unsafe BmSDK.Class HudModuleStoryModeClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3776); }
    }

    /// <summary>
    /// ClassProperty: HudModuleObjectivesClass
    /// </summary>
    public unsafe BmSDK.Class HudModuleObjectivesClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3784); }
    }

    /// <summary>
    /// ClassProperty: HudModuleTargetsClass
    /// </summary>
    public unsafe BmSDK.Class HudModuleTargetsClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3792); }
    }

    /// <summary>
    /// ClassProperty: HudModuleRoomNameClass
    /// </summary>
    public unsafe BmSDK.Class HudModuleRoomNameClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3800); }
    }

    /// <summary>
    /// ClassProperty: HudModuleHealthBarClass
    /// </summary>
    public unsafe BmSDK.Class HudModuleHealthBarClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3808); }
    }

    /// <summary>
    /// ClassProperty: HudModuleHackingModeClass
    /// </summary>
    public unsafe BmSDK.Class HudModuleHackingModeClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3816); }
    }

    /// <summary>
    /// ClassProperty: HudModuleExtraSequenceClass
    /// </summary>
    public unsafe BmSDK.Class HudModuleExtraSequenceClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3824); }
    }

    /// <summary>
    /// ClassProperty: HudModuleDetectiveModeClass
    /// </summary>
    public unsafe BmSDK.Class HudModuleDetectiveModeClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3832); }
    }

    /// <summary>
    /// ClassProperty: SecondaryGroupCombatMove
    /// </summary>
    public unsafe BmSDK.Class SecondaryGroupCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }
    }

    /// <summary>
    /// ClassProperty: PrimaryGroupCombatMove
    /// </summary>
    public unsafe BmSDK.Class PrimaryGroupCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3848); }
    }

    /// <summary>
    /// ComponentProperty: StunFXComponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StunFXComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3856); }
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
    public unsafe System.Numerics.Vector3 LastPylonCheckLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3896); }
    }

    /// <summary>
    /// ArrayProperty: BoneNameListConversion
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BoneNameListConversion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3908); }
    }

    /// <summary>
    /// ByteProperty: OverrideInterrogationPose
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2IdleConfig.EInterrogationPose OverrideInterrogationPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2IdleConfig.EInterrogationPose>(Ptr + 3924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3924); }
    }

    /// <summary>
    /// ByteProperty: PlayerType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.EPlayerVariableType PlayerType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.EPlayerVariableType>(Ptr + 3925); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3925); }
    }

    /// <summary>
    /// ByteProperty: CheckCameraLookAtSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtSpeed CheckCameraLookAtSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtSpeed>(Ptr + 3926); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3926); }
    }

    /// <summary>
    /// ArrayProperty: PipeGunDummyAdditiveDisablers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PipeGunDummyAdditiveDisablers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3928); }
    }

    /// <summary>
    /// ArrayProperty: AutoStrikeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo> AutoStrikeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo>>(Ptr + 3944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3944); }
    }

    /// <summary>
    /// StructProperty: PrevStrikeInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo PrevStrikeInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo>(Ptr + 3960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3960); }
    }

    /// <summary>
    /// ArrayProperty: PrevStrikeTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> PrevStrikeTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// ArrayProperty: PairedAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> PairedAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }

    /// <summary>
    /// ArrayProperty: CounterList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FCounterInfo> CounterList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FCounterInfo>>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// ArrayProperty: SimultaneousCounterList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FSimultaneousCounterInfo> SimultaneousCounterList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FSimultaneousCounterInfo>>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// ArrayProperty: TakedownList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FTakedownInfo> TakedownList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FTakedownInfo>>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }

    /// <summary>
    /// ArrayProperty: ThrowList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FThrowInfo> ThrowList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FThrowInfo>>(Ptr + 4180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4180); }
    }

    /// <summary>
    /// ArrayProperty: WeaponDestroyList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FWeaponDestroyInfo> WeaponDestroyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FWeaponDestroyInfo>>(Ptr + 4196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4196); }
    }

    /// <summary>
    /// ArrayProperty: WeaponSnatchList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FWeaponSnatchInfo> WeaponSnatchList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FWeaponSnatchInfo>>(Ptr + 4212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4212); }
    }

    /// <summary>
    /// ArrayProperty: DualStrikeTypeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FDualStrikeType> DualStrikeTypeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FDualStrikeType>>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// ArrayProperty: DualStrikeInfoList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FDualStrikeInfo> DualStrikeInfoList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FDualStrikeInfo>>(Ptr + 4244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4244); }
    }

    /// <summary>
    /// StructProperty: LastDmgImpulse
    /// </summary>
    public unsafe System.Numerics.Vector3 LastDmgImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4260); }
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
    public unsafe BmSDK.TArray<BmSDK.FName> BeforeCombatAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// ArrayProperty: AfterCombatAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> AfterCombatAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// StructProperty: CheckCameraTargetOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 CheckCameraTargetOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4312); }
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
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> EnemiesAttacking
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 4332); }
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
