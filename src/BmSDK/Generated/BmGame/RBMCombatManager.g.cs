#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMCombatManager<br/>
/// (flags = 0)
/// </summary>
public partial class RBMCombatManager : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMCombatManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMCombatManager() { }

    /// <summary>
    /// Constructs a new RBMCombatManager
    /// </summary>
    public RBMCombatManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMCombatManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCombatManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: CombatPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatPoint> CombatPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatPoint>>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ArrayProperty: CombatAreas
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatArea> CombatAreas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatArea>>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ArrayProperty: GuardPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatArea_GuardPoint> GuardPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatArea_GuardPoint>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: ThrowTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RThrowTarget> ThrowTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RThrowTarget>>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ArrayProperty: CombatAttractors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatAttractor> CombatAttractors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatAttractor>>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ArrayProperty: DualplayZones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDualplayZone> DualplayZones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDualplayZone>>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ArrayProperty: CombatEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatEvent> CombatEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatEvent>>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: CurrTakedownObject
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatPoint_EnvironmentAttackObjectBase CurrTakedownObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatPoint_EnvironmentAttackObjectBase>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: CurrBatmobileTakedownTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain CurrBatmobileTakedownTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: CombatStepper
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat CombatStepper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_IntegratedChallengeBase ChallengeAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_IntegratedChallengeBase>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: CurrentChargingThug
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain CurrentChargingThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: SpecialCombatEventReceiver
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain SpecialCombatEventReceiver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: BarkGroupContext
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkGroupContext_Combat BarkGroupContext
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkGroupContext_Combat>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: PawnToKeepInView
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat PawnToKeepInView
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: GameRepInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI GameRepInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: CombatCamera2D
    /// </summary>
    public unsafe BmSDK.BmGame.R2DCombatCamera CombatCamera2D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R2DCombatCamera>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: PlayerVIPTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PlayerVIPTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: DisableCounterIconSequenceAction
    /// </summary>
    public unsafe BmSDK.Engine.SequenceAction DisableCounterIconSequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SequenceAction>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: TargetPlayerOverride
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat TargetPlayerOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: AttackerOverride
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain AttackerOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileTakedownHighlight
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance BatmobileTakedownHighlight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: RiotCombatWallahStart
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotCombatWallahStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: RiotCombatWallahStop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotCombatWallahStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: RiotStartCombatAkEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotStartCombatAkEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: RiotCombatWallahParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName RiotCombatWallahParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ObjectProperty: DestroyEnvironmentWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatPoint_EnvironmentWeapon DestroyEnvironmentWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatPoint_EnvironmentWeapon>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: LastJumpAlly
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastJumpAlly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bSuspendBatmobileTakedownTargetSearch
    /// </summary>
    public unsafe bool bSuspendBatmobileTakedownTargetSearch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bHasPotentialBatmobileTakedownTarget
    /// </summary>
    public unsafe bool bHasPotentialBatmobileTakedownTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bKismetIgnoreDDA
    /// </summary>
    public unsafe bool bKismetIgnoreDDA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bCanAttack
    /// </summary>
    public unsafe bool bCanAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bEnableAllAttacksByDefault
    /// </summary>
    public unsafe bool bEnableAllAttacksByDefault
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableNormalAttack
    /// </summary>
    public unsafe bool bDisableNormalAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableGrabAttack
    /// </summary>
    public unsafe bool bDisableGrabAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableChargeAttack
    /// </summary>
    public unsafe bool bDisableChargeAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableBeatdown
    /// </summary>
    public unsafe bool bDisableBeatdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bHeavyFloorStrike
    /// </summary>
    public unsafe bool bHeavyFloorStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableAdrenaline
    /// </summary>
    public unsafe bool bDisableAdrenaline
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableNinjaCounter
    /// </summary>
    public unsafe bool bDisableNinjaCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableNinjaDespawn
    /// </summary>
    public unsafe bool bDisableNinjaDespawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableCombatLock
    /// </summary>
    public unsafe bool bDisableCombatLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableCombatTakedownCheck
    /// </summary>
    public unsafe bool bDisableCombatTakedownCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableCombatExpertFuryAttack
    /// </summary>
    public unsafe bool bDisableCombatExpertFuryAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableMedicChargeUpThug
    /// </summary>
    public unsafe bool bDisableMedicChargeUpThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableMedicRevives
    /// </summary>
    public unsafe bool bDisableMedicRevives
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableBotDialogue
    /// </summary>
    public unsafe bool bDisableBotDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisableQuickGadgetPrompts
    /// </summary>
    public unsafe bool bDisableQuickGadgetPrompts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bSeperatedDualplay
    /// </summary>
    public unsafe bool bSeperatedDualplay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bForceFinalSimultaneousAttack
    /// </summary>
    public unsafe bool bForceFinalSimultaneousAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowKnifeThugTutorial
    /// </summary>
    public unsafe bool bShowKnifeThugTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowShieldThugTutorial
    /// </summary>
    public unsafe bool bShowShieldThugTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowArmouredThugTutorial
    /// </summary>
    public unsafe bool bShowArmouredThugTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowStunStickThugTutorial
    /// </summary>
    public unsafe bool bShowStunStickThugTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowMultiStageTutorial
    /// </summary>
    public unsafe bool bShowMultiStageTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowMedicBuffTutorial
    /// </summary>
    public unsafe bool bShowMedicBuffTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bShowWeaponPickupHelp
    /// </summary>
    public unsafe bool bShowWeaponPickupHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bExitCombatIfFarFromThugs
    /// </summary>
    public unsafe bool bExitCombatIfFarFromThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bDisplayDifficultyDebug
    /// </summary>
    public unsafe bool bDisplayDifficultyDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bMoreThanOneCombatantHasBeenActive
    /// </summary>
    public unsafe bool bMoreThanOneCombatantHasBeenActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bPlayerIsTargetted
    /// </summary>
    public unsafe bool bPlayerIsTargetted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bDisableCombatTakedownPoints
    /// </summary>
    public unsafe bool bDisableCombatTakedownPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: ImpactRampIn
    /// </summary>
    public unsafe bool ImpactRampIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: ImpactRampOut
    /// </summary>
    public unsafe bool ImpactRampOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bPlayedSeeCombatBark
    /// </summary>
    public unsafe bool bPlayedSeeCombatBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bKeepInViewLookAtPawnLocation
    /// </summary>
    public unsafe bool bKeepInViewLookAtPawnLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bDisableDDATracking
    /// </summary>
    public unsafe bool bDisableDDATracking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bSuspendCachingNumCombatants
    /// </summary>
    public unsafe bool bSuspendCachingNumCombatants
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bTriedToCacheNumCombatantsWhileSuspended
    /// </summary>
    public unsafe bool bTriedToCacheNumCombatantsWhileSuspended
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bPairedAnimLoadStartedThisFrame
    /// </summary>
    public unsafe bool bPairedAnimLoadStartedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bNinjaDodgedLastStrike
    /// </summary>
    public unsafe bool bNinjaDodgedLastStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bNewGamePlus
    /// </summary>
    public unsafe bool bNewGamePlus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bNoCameraAssistance
    /// </summary>
    public unsafe bool bNoCameraAssistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bVenomCameraOn
    /// </summary>
    public unsafe bool bVenomCameraOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bStayAwayFromPlayer
    /// </summary>
    public unsafe bool bStayAwayFromPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bDisableBot
    /// </summary>
    public unsafe bool bDisableBot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bBotTargetted
    /// </summary>
    public unsafe bool bBotTargetted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bCombatRiotWallahRunning
    /// </summary>
    public unsafe bool bCombatRiotWallahRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bMultiStageThrowActive
    /// </summary>
    public unsafe bool bMultiStageThrowActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bDualplayLOS
    /// </summary>
    public unsafe bool bDualplayLOS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bCrocFight
    /// </summary>
    public unsafe bool bCrocFight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 952); }
    }

    /// <summary>
    /// IntProperty: CombatStepperIndex
    /// </summary>
    public unsafe int CombatStepperIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// FloatProperty: LastTauntTime
    /// </summary>
    public unsafe float LastTauntTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// IntProperty: LastTauntID
    /// </summary>
    public unsafe int LastTauntID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: LastLocationSpecificTakedownTauntTime
    /// </summary>
    public unsafe float LastLocationSpecificTakedownTauntTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ArrayProperty: SuppressFinalBlowObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> SuppressFinalBlowObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ArrayProperty: SuppressXPObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> SuppressXPObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilNextMaxPawnsUpdate
    /// </summary>
    public unsafe float TimeUntilNextMaxPawnsUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// IntProperty: MaxCombatPawns
    /// </summary>
    public unsafe int MaxCombatPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: OverrideChapter
    /// </summary>
    public unsafe float OverrideChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ArrayProperty: ActiveDifficultyVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDifficultyOverrideVolume> ActiveDifficultyVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDifficultyOverrideVolume>>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: LastBMSightingTime
    /// </summary>
    public unsafe float LastBMSightingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// StructProperty: LastSightingLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastSightingLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: LastBatmobileSightingTime
    /// </summary>
    public unsafe float LastBatmobileSightingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// StructProperty: LastBatmobileSightingLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastBatmobileSightingLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ArrayProperty: VillainBlockerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBunkerDoorVillainBlocker> VillainBlockerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBunkerDoorVillainBlocker>>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ArrayProperty: RetreatFromBatmobilePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatRetreatFromBatmobilePoint> RetreatFromBatmobilePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatRetreatFromBatmobilePoint>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: LastFuryAttackTime
    /// </summary>
    public unsafe float LastFuryAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// FloatProperty: PawnHealthMultiplier
    /// </summary>
    public unsafe float PawnHealthMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// FloatProperty: SimultaneousAttackTimer
    /// </summary>
    public unsafe float SimultaneousAttackTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// FloatProperty: ForceFinalSimultaneousAttackTime
    /// </summary>
    public unsafe float ForceFinalSimultaneousAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ArrayProperty: AllowedSimultaneousTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat.SimultaneousCounterBehaviourType> AllowedSimultaneousTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat.SimultaneousCounterBehaviourType>>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithKnives
    /// </summary>
    public unsafe int NumCombatantsWithKnives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithShields
    /// </summary>
    public unsafe int NumCombatantsWithShields
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithArmour
    /// </summary>
    public unsafe int NumCombatantsWithArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithStunSticks
    /// </summary>
    public unsafe int NumCombatantsWithStunSticks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsMultiStage
    /// </summary>
    public unsafe int NumCombatantsMultiStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: MostDangerousMultiStageWeapon
    /// </summary>
    public unsafe int MostDangerousMultiStageWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithHeavyObjects
    /// </summary>
    public unsafe int NumCombatantsWithHeavyObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithGuns
    /// </summary>
    public unsafe int NumCombatantsWithGuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsStartedWithGuns
    /// </summary>
    public unsafe int NumCombatantsStartedWithGuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithWeapons
    /// </summary>
    public unsafe int NumCombatantsWithWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithBats
    /// </summary>
    public unsafe int NumCombatantsWithBats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsMedics
    /// </summary>
    public unsafe int NumCombatantsMedics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsMedicBuffs
    /// </summary>
    public unsafe int NumCombatantsMedicBuffs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// IntProperty: NumRiotersInCombat
    /// </summary>
    public unsafe int NumRiotersInCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// IntProperty: NumRobotsInCombat
    /// </summary>
    public unsafe int NumRobotsInCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// IntProperty: NumMilitiaInCombat
    /// </summary>
    public unsafe int NumMilitiaInCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// FloatProperty: LastCombatRollTime
    /// </summary>
    public unsafe float LastCombatRollTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ArrayProperty: CombatPylons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pylon> CombatPylons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pylon>>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// ArrayProperty: RiotCombatPylons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pylon> RiotCombatPylons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pylon>>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ArrayProperty: CombatantsJoining
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> CombatantsJoining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// FloatProperty: LastExplosivePickedUpTime
    /// </summary>
    public unsafe float LastExplosivePickedUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// FloatProperty: LastThrownObjectPickedUpTime
    /// </summary>
    public unsafe float LastThrownObjectPickedUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: LastGunDispenserUseTime
    /// </summary>
    public unsafe float LastGunDispenserUseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// FloatProperty: NextThugHelpThugTime
    /// </summary>
    public unsafe float NextThugHelpThugTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: NextThugPushThugTime
    /// </summary>
    public unsafe float NextThugPushThugTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// FloatProperty: ImpactEmoteChanceCombat
    /// </summary>
    public unsafe float ImpactEmoteChanceCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// FloatProperty: ImpactEmoteChancePredator
    /// </summary>
    public unsafe float ImpactEmoteChancePredator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// ArrayProperty: ThugPlayerPairedAnimsetPackageDefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FPairedAnimsetPackageDef> ThugPlayerPairedAnimsetPackageDefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FPairedAnimsetPackageDef>>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// ArrayProperty: CachedCombatAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedAnimset> CachedCombatAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedAnimset>>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// ArrayProperty: DifficultyProgressionDefines_Easy
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine> DifficultyProgressionDefines_Easy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine>>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// ArrayProperty: DifficultyProgressionDefines_Normal
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine> DifficultyProgressionDefines_Normal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine>>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// ArrayProperty: DifficultyProgressionDefines_Hard
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine> DifficultyProgressionDefines_Hard
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine>>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// ArrayProperty: MoveTypeScores
    /// </summary>
    public unsafe BmSDK.TArray<int> MoveTypeScores
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }

    /// <summary>
    /// ArrayProperty: CachedTaunts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedTauntAnims> CachedTaunts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedTauntAnims>>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// ArrayProperty: CachedSteps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedStepAnims> CachedSteps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedStepAnims>>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// ArrayProperty: CachedIdles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedIdleStances> CachedIdles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCachedIdleStances>>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// FloatProperty: LastGrabAttackTime
    /// </summary>
    public unsafe float LastGrabAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// IntProperty: NumCombatants
    /// </summary>
    public unsafe int NumCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// IntProperty: MaxCombatantsThisFight
    /// </summary>
    public unsafe int MaxCombatantsThisFight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// IntProperty: CombatKOsThisFight
    /// </summary>
    public unsafe int CombatKOsThisFight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// FloatProperty: TotalCombatHealth
    /// </summary>
    public unsafe float TotalCombatHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// IntProperty: CurrActiveCombatThugs
    /// </summary>
    public unsafe int CurrActiveCombatThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// FloatProperty: ActiveCombatTime
    /// </summary>
    public unsafe float ActiveCombatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// FloatProperty: InActiveCombatTime
    /// </summary>
    public unsafe float InActiveCombatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// FloatProperty: ClosestCombatPawnDistance
    /// </summary>
    public unsafe float ClosestCombatPawnDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// ArrayProperty: UniqueCombatantList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCombatantInfo> UniqueCombatantList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FCombatantInfo>>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// ArrayProperty: UniqueWeaponsCrates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatPoint> UniqueWeaponsCrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatPoint>>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// FloatProperty: ImpactMinSpeed
    /// </summary>
    public unsafe float ImpactMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// FloatProperty: ImpactPreTime
    /// </summary>
    public unsafe float ImpactPreTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// FloatProperty: ImpactPostTime
    /// </summary>
    public unsafe float ImpactPostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// FloatProperty: ImpactRampInEnd
    /// </summary>
    public unsafe float ImpactRampInEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1772); }
    }

    /// <summary>
    /// FloatProperty: ImpactRampOutStart
    /// </summary>
    public unsafe float ImpactRampOutStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// FloatProperty: LastPunishingAttackTime
    /// </summary>
    public unsafe float LastPunishingAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// FloatProperty: LastBarkTime
    /// </summary>
    public unsafe float LastBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// FloatProperty: LastJoinCombatBarkTime
    /// </summary>
    public unsafe float LastJoinCombatBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// StructProperty: LastJoinCombatBarkPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 LastJoinCombatBarkPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// IntProperty: FleeBarksRemaining
    /// </summary>
    public unsafe int FleeBarksRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenBarkMultiplier
    /// </summary>
    public unsafe float TimeBetweenBarkMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// FloatProperty: CanAttackTime
    /// </summary>
    public unsafe float CanAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// FloatProperty: MinCombatFOV
    /// </summary>
    public unsafe float MinCombatFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// IntProperty: MinCombatFOVNum
    /// </summary>
    public unsafe int MinCombatFOVNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// FloatProperty: MaxCombatFOV
    /// </summary>
    public unsafe float MaxCombatFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// IntProperty: MaxCombatFOVNum
    /// </summary>
    public unsafe int MaxCombatFOVNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// IntProperty: OverrideNumCombatants
    /// </summary>
    public unsafe int OverrideNumCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// NameProperty: FinishedCombatName
    /// </summary>
    public unsafe BmSDK.FName FinishedCombatName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// FloatProperty: MaxYawOffsetDeg
    /// </summary>
    public unsafe float MaxYawOffsetDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// FloatProperty: PitchOffsetDeg
    /// </summary>
    public unsafe float PitchOffsetDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// FloatProperty: PitchUpLimitDeg
    /// </summary>
    public unsafe float PitchUpLimitDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ByteProperty: KeepInViewSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtSpeed KeepInViewSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtSpeed>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// NameProperty: LastPickupClassName
    /// </summary>
    public unsafe BmSDK.FName LastPickupClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// FloatProperty: PickupBarkTime
    /// </summary>
    public unsafe float PickupBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// FloatProperty: MaxOnscreenCosAngleZ
    /// </summary>
    public unsafe float MaxOnscreenCosAngleZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// FloatProperty: MaxOnscreenCosAngleXY
    /// </summary>
    public unsafe float MaxOnscreenCosAngleXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// IntProperty: ProtectionStatus
    /// </summary>
    public unsafe int ProtectionStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// FloatProperty: LastThrowBrickTime
    /// </summary>
    public unsafe float LastThrowBrickTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ArrayProperty: TeleportPointList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatTeleport> TeleportPointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatTeleport>>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// IntProperty: Counter1
    /// </summary>
    public unsafe int Counter1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// IntProperty: Counter2
    /// </summary>
    public unsafe int Counter2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// IntProperty: Counter3
    /// </summary>
    public unsafe int Counter3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// IntProperty: NumberStrikesAgainstNinjas
    /// </summary>
    public unsafe int NumberStrikesAgainstNinjas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// IntProperty: NumberNinjaDodges
    /// </summary>
    public unsafe int NumberNinjaDodges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// FloatProperty: LastNinjaDodgeTime
    /// </summary>
    public unsafe float LastNinjaDodgeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// IntProperty: NumberNinjaCounters
    /// </summary>
    public unsafe int NumberNinjaCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// FloatProperty: FinishedCombatTime
    /// </summary>
    public unsafe float FinishedCombatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// IntProperty: NumCombatantVehicles
    /// </summary>
    public unsafe int NumCombatantVehicles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// IntProperty: MaxSimCounterersOverride
    /// </summary>
    public unsafe int MaxSimCounterersOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsForInterrogation
    /// </summary>
    public unsafe int NumCombatantsForInterrogation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsJoiningForInterrogation
    /// </summary>
    public unsafe int NumCombatantsJoiningForInterrogation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// FloatProperty: LastVillainChargeAttackTime
    /// </summary>
    public unsafe float LastVillainChargeAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// ArrayProperty: DamageProxyCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatDamageProxy> DamageProxyCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatDamageProxy>>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// ArrayProperty: ActiveDamageProxyCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatDamageProxy> ActiveDamageProxyCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatDamageProxy>>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// FloatProperty: LastThugChargeUpTime
    /// </summary>
    public unsafe float LastThugChargeUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// FloatProperty: LastThugChargeUpAttackTime
    /// </summary>
    public unsafe float LastThugChargeUpAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// FloatProperty: LastMultiStageThrowAttackTime
    /// </summary>
    public unsafe float LastMultiStageThrowAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// FloatProperty: LastJumpOffAllyTime
    /// </summary>
    public unsafe float LastJumpOffAllyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }
}
