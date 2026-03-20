#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPlayerControllerCombat<br/>
/// (flags = 0)
/// </summary>
public partial class RPlayerControllerCombat : BmSDK.BmGame.RPlayerController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPlayerControllerCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPlayerControllerCombat() { }

    /// <summary>
    /// Constructs a new RPlayerControllerCombat
    /// </summary>
    public RPlayerControllerCombat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPlayerControllerCombat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPlayerControllerCombat(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: CombatManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager CombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(Ptr + 7440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7440); }
    }

    /// <summary>
    /// ObjectProperty: ImpactRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ImpactRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 7448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7448); }
    }

    /// <summary>
    /// ObjectProperty: LastAttackTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastAttackTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 7456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7456); }
    }

    /// <summary>
    /// ObjectProperty: DifficultyOverrideVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RDifficultyOverrideVolume DifficultyOverrideVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDifficultyOverrideVolume>(Ptr + 7464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7464); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLookAtTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat CurrentLookAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 7472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7472); }
    }

    /// <summary>
    /// ObjectProperty: SniperPP
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess SniperPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 7480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7480); }
    }

    /// <summary>
    /// ObjectProperty: FinalBlowPP
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess FinalBlowPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 7488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7488); }
    }

    /// <summary>
    /// ObjectProperty: FixedCombatCam
    /// </summary>
    public unsafe BmSDK.BmGame.RCameraActor FixedCombatCam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCameraActor>(Ptr + 7496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7496); }
    }

    /// <summary>
    /// ObjectProperty: FixedCombatCam_HeliBase
    /// </summary>
    public unsafe BmSDK.BmGame.RHelicopterBase FixedCombatCam_HeliBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase>(Ptr + 7504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7504); }
    }

    /// <summary>
    /// ComponentProperty: ComboIncAC
    /// </summary>
    public unsafe BmSDK.Engine.AudioComponent ComboIncAC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AudioComponent>(Ptr + 7512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7512); }
    }

    /// <summary>
    /// ComponentProperty: XPBonusRoom
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState XPBonusRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 7520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7520); }
    }

    /// <summary>
    /// IntProperty: ComboSize
    /// </summary>
    public unsafe int ComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7528); }
    }

    /// <summary>
    /// IntProperty: CurrMaxComboSize
    /// </summary>
    public unsafe int CurrMaxComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7532); }
    }

    /// <summary>
    /// IntProperty: TotalMaxComboSize
    /// </summary>
    public unsafe int TotalMaxComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7536); }
    }

    /// <summary>
    /// IntProperty: NumTimesHit
    /// </summary>
    public unsafe int NumTimesHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7540); }
    }

    /// <summary>
    /// FloatProperty: AdrenalineValue
    /// </summary>
    public unsafe float AdrenalineValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7544); }
    }

    /// <summary>
    /// FloatProperty: AdrenalineSpecialLimit
    /// </summary>
    public unsafe float AdrenalineSpecialLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7548); }
    }

    /// <summary>
    /// FloatProperty: AdrenalineSuperSpecialLimit
    /// </summary>
    public unsafe float AdrenalineSuperSpecialLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7552); }
    }

    /// <summary>
    /// BoolProperty: bFirstSpecialMoveUsed
    /// </summary>
    public unsafe bool bFirstSpecialMoveUsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: AdrenalineBarActive
    /// </summary>
    public unsafe bool AdrenalineBarActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bSuppressCombatCameraInCorridor
    /// </summary>
    public unsafe bool bSuppressCombatCameraInCorridor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bPlayFinishedCombatMoveWhenAble
    /// </summary>
    public unsafe bool bPlayFinishedCombatMoveWhenAble
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bForceSpecialCombo
    /// </summary>
    public unsafe bool bForceSpecialCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHit
    /// </summary>
    public unsafe bool bBeenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bEverBeenHit
    /// </summary>
    public unsafe bool bEverBeenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bShownDesignTutorial
    /// </summary>
    public unsafe bool bShownDesignTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByStunStick
    /// </summary>
    public unsafe bool bBeenHitByStunStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByKnife
    /// </summary>
    public unsafe bool bBeenHitByKnife
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitBySword
    /// </summary>
    public unsafe bool bBeenHitBySword
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByCombatGun
    /// </summary>
    public unsafe bool bBeenHitByCombatGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByChargedUpThug
    /// </summary>
    public unsafe bool bBeenHitByChargedUpThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByMultiWeaponFist
    /// </summary>
    public unsafe bool bBeenHitByMultiWeaponFist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByMultiWeaponShield
    /// </summary>
    public unsafe bool bBeenHitByMultiWeaponShield
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitBySimultaneousAttack
    /// </summary>
    public unsafe bool bBeenHitBySimultaneousAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByArmouredThug
    /// </summary>
    public unsafe bool bBeenHitByArmouredThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByShieldThug
    /// </summary>
    public unsafe bool bBeenHitByShieldThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByLieutenant
    /// </summary>
    public unsafe bool bBeenHitByLieutenant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByTitanHenchman
    /// </summary>
    public unsafe bool bBeenHitByTitanHenchman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByProjectile
    /// </summary>
    public unsafe bool bBeenHitByProjectile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitBySniper
    /// </summary>
    public unsafe bool bBeenHitBySniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByMine
    /// </summary>
    public unsafe bool bBeenHitByMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bSpottedByThermal
    /// </summary>
    public unsafe bool bSpottedByThermal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bVantageMineWasUsedInPredatorSection
    /// </summary>
    public unsafe bool bVantageMineWasUsedInPredatorSection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bTryingToSetDialogueMode
    /// </summary>
    public unsafe bool bTryingToSetDialogueMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bShowEvadePrompt
    /// </summary>
    public unsafe bool bShowEvadePrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bShowQuickBatarangPrompt
    /// </summary>
    public unsafe bool bShowQuickBatarangPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bCanDoComboBatarang
    /// </summary>
    public unsafe bool bCanDoComboBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bMirroredFailAnim
    /// </summary>
    public unsafe bool bMirroredFailAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bStoredNoHitBonus
    /// </summary>
    public unsafe bool bStoredNoHitBonus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bStoredPerfectFreeflow
    /// </summary>
    public unsafe bool bStoredPerfectFreeflow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: StoredPredatorSeen
    /// </summary>
    public unsafe bool StoredPredatorSeen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bUseComboIncCue
    /// </summary>
    public unsafe bool bUseComboIncCue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bLieutenantStrikeHelp
    /// </summary>
    public unsafe bool bLieutenantStrikeHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bDisallowCombat
    /// </summary>
    public unsafe bool bDisallowCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bAllowCombatWithNoMovement
    /// </summary>
    public unsafe bool bAllowCombatWithNoMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bCapeStunDisabled
    /// </summary>
    public unsafe bool bCapeStunDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bInFreeflowFocus
    /// </summary>
    public unsafe bool bInFreeflowFocus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bSniperPPActive
    /// </summary>
    public unsafe bool bSniperPPActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bAllowInteractionMidCombat
    /// </summary>
    public unsafe bool bAllowInteractionMidCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bCouldDoCombatWhenCounterPressed
    /// </summary>
    public unsafe bool bCouldDoCombatWhenCounterPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bUnderAttackFromGunshipHomingMissiles
    /// </summary>
    public unsafe bool bUnderAttackFromGunshipHomingMissiles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bPrevCanDoDualPlayTakedown
    /// </summary>
    public unsafe bool bPrevCanDoDualPlayTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bCanDoReadyGadgetOrCounter
    /// </summary>
    public unsafe bool bCanDoReadyGadgetOrCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bNoGroundTakedown
    /// </summary>
    public unsafe bool bNoGroundTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bGroundTakedownDone
    /// </summary>
    public unsafe bool bGroundTakedownDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// FloatProperty: DualPlayAdrenalineValue
    /// </summary>
    public unsafe float DualPlayAdrenalineValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7564); }
    }

    /// <summary>
    /// FloatProperty: DualPlayAdrenalineSpecialLimit
    /// </summary>
    public unsafe float DualPlayAdrenalineSpecialLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7568); }
    }

    /// <summary>
    /// FloatProperty: BatmobileTakedownAdrenalineValue
    /// </summary>
    public unsafe float BatmobileTakedownAdrenalineValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7572); }
    }

    /// <summary>
    /// FloatProperty: BatmobileTakedownAdrenalineSpecialLimit
    /// </summary>
    public unsafe float BatmobileTakedownAdrenalineSpecialLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7576); }
    }

    /// <summary>
    /// IntProperty: CombatScore
    /// </summary>
    public unsafe int CombatScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7580); }
    }

    /// <summary>
    /// ArrayProperty: TargettedBy
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> TargettedBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 7584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7584); }
    }

    /// <summary>
    /// FloatProperty: LastAttackTargetTime
    /// </summary>
    public unsafe float LastAttackTargetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7600); }
    }

    /// <summary>
    /// StructProperty: LastStrikeDir
    /// </summary>
    public unsafe System.Numerics.Vector3 LastStrikeDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7604); }
    }

    /// <summary>
    /// FloatProperty: FinishedCombatSpecialMoveTimeout
    /// </summary>
    public unsafe float FinishedCombatSpecialMoveTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7616); }
    }

    /// <summary>
    /// IntProperty: MovesSinceSpecial
    /// </summary>
    public unsafe int MovesSinceSpecial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7620); }
    }

    /// <summary>
    /// IntProperty: CombosStarted
    /// </summary>
    public unsafe int CombosStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7624); }
    }

    /// <summary>
    /// IntProperty: CombosAchieved
    /// </summary>
    public unsafe int CombosAchieved
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7628); }
    }

    /// <summary>
    /// IntProperty: CummulativeComboAchieved
    /// </summary>
    public unsafe int CummulativeComboAchieved
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7632); }
    }

    /// <summary>
    /// IntProperty: CounterPrompt
    /// </summary>
    public unsafe int CounterPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7636); }
    }

    /// <summary>
    /// FloatProperty: CounterPromptTimer
    /// </summary>
    public unsafe float CounterPromptTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7640); }
    }

    /// <summary>
    /// FloatProperty: LastFailTime
    /// </summary>
    public unsafe float LastFailTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7644); }
    }

    /// <summary>
    /// NameProperty: LastFailAnimName
    /// </summary>
    public unsafe BmSDK.FName LastFailAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7648); }
    }

    /// <summary>
    /// IntProperty: MaxComboSize
    /// </summary>
    public unsafe int MaxComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7656); }
    }

    /// <summary>
    /// IntProperty: MaxCombatants
    /// </summary>
    public unsafe int MaxCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7660); }
    }

    /// <summary>
    /// IntProperty: MaxComboVariation
    /// </summary>
    public unsafe int MaxComboVariation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7664); }
    }

    /// <summary>
    /// IntProperty: MaxComboVariationNoGadgets
    /// </summary>
    public unsafe int MaxComboVariationNoGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7668); }
    }

    /// <summary>
    /// IntProperty: TimesHitInThisFight
    /// </summary>
    public unsafe int TimesHitInThisFight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7672); }
    }

    /// <summary>
    /// StructProperty: StoredCombatXPInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FCombatXPInfo StoredCombatXPInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FCombatXPInfo>(Ptr + 7676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7676); }
    }

    /// <summary>
    /// IntProperty: StoredComboBonus
    /// </summary>
    public unsafe int StoredComboBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7776); }
    }

    /// <summary>
    /// IntProperty: StoredMaxCombatants
    /// </summary>
    public unsafe int StoredMaxCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7780); }
    }

    /// <summary>
    /// IntProperty: StoredVariationBonus
    /// </summary>
    public unsafe int StoredVariationBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7784); }
    }

    /// <summary>
    /// IntProperty: StoredGadgetVariationBonus
    /// </summary>
    public unsafe int StoredGadgetVariationBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7788); }
    }

    /// <summary>
    /// IntProperty: StoredNumberOfCombos
    /// </summary>
    public unsafe int StoredNumberOfCombos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7792); }
    }

    /// <summary>
    /// IntProperty: StoredNumCombatants
    /// </summary>
    public unsafe int StoredNumCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7796); }
    }

    /// <summary>
    /// IntProperty: StoredNumThugs
    /// </summary>
    public unsafe int StoredNumThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7800); }
    }

    /// <summary>
    /// IntProperty: StoredNumCombatExperts
    /// </summary>
    public unsafe int StoredNumCombatExperts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7804); }
    }

    /// <summary>
    /// IntProperty: StoredNumBrutes
    /// </summary>
    public unsafe int StoredNumBrutes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7808); }
    }

    /// <summary>
    /// IntProperty: StoredNumMedics
    /// </summary>
    public unsafe int StoredNumMedics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7812); }
    }

    /// <summary>
    /// IntProperty: StoredNumRobots
    /// </summary>
    public unsafe int StoredNumRobots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7816); }
    }

    /// <summary>
    /// IntProperty: StoredNumDollotrons
    /// </summary>
    public unsafe int StoredNumDollotrons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7820); }
    }

    /// <summary>
    /// IntProperty: StoredNumJokerBoxer
    /// </summary>
    public unsafe int StoredNumJokerBoxer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7824); }
    }

    /// <summary>
    /// IntProperty: StoredNumRiddlerMech
    /// </summary>
    public unsafe int StoredNumRiddlerMech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7828); }
    }

    /// <summary>
    /// IntProperty: StoredNumPyg
    /// </summary>
    public unsafe int StoredNumPyg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7832); }
    }

    /// <summary>
    /// IntProperty: StoredNumBlackfire
    /// </summary>
    public unsafe int StoredNumBlackfire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7836); }
    }

    /// <summary>
    /// IntProperty: StoredNumBats
    /// </summary>
    public unsafe int StoredNumBats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7840); }
    }

    /// <summary>
    /// IntProperty: StoredNumKnives
    /// </summary>
    public unsafe int StoredNumKnives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7844); }
    }

    /// <summary>
    /// IntProperty: StoredNumShields
    /// </summary>
    public unsafe int StoredNumShields
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7848); }
    }

    /// <summary>
    /// IntProperty: StoredNumStunSticks
    /// </summary>
    public unsafe int StoredNumStunSticks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7852); }
    }

    /// <summary>
    /// IntProperty: StoredNumGuns
    /// </summary>
    public unsafe int StoredNumGuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7856); }
    }

    /// <summary>
    /// IntProperty: StoredNumCrates
    /// </summary>
    public unsafe int StoredNumCrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7860); }
    }

    /// <summary>
    /// StructProperty: StoredPredatorXPInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FPredatorXPInfo StoredPredatorXPInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FPredatorXPInfo>(Ptr + 7864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7864); }
    }

    /// <summary>
    /// IntProperty: HitsSinceCounter
    /// </summary>
    public unsafe int HitsSinceCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7936); }
    }

    /// <summary>
    /// IntProperty: ChargesSinceBatarang
    /// </summary>
    public unsafe int ChargesSinceBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7940); }
    }

    /// <summary>
    /// IntProperty: SetComboFrames
    /// </summary>
    public unsafe int SetComboFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7944); }
    }

    /// <summary>
    /// IntProperty: ShowCriticalFrames
    /// </summary>
    public unsafe int ShowCriticalFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7948); }
    }

    /// <summary>
    /// IntProperty: CriticalComboChain
    /// </summary>
    public unsafe int CriticalComboChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7952); }
    }

    /// <summary>
    /// FloatProperty: NotInCombatTimer
    /// </summary>
    public unsafe float NotInCombatTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7956); }
    }

    /// <summary>
    /// IntProperty: BlockedByArmouredSinceBeatdown
    /// </summary>
    public unsafe int BlockedByArmouredSinceBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7960); }
    }

    /// <summary>
    /// IntProperty: BlockedByMultiStageSinceBeatdown
    /// </summary>
    public unsafe int BlockedByMultiStageSinceBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7964); }
    }

    /// <summary>
    /// IntProperty: RepelledByMultiStageSinceBeatdown
    /// </summary>
    public unsafe int RepelledByMultiStageSinceBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7968); }
    }

    /// <summary>
    /// IntProperty: BlockedByShieldSinceAerial
    /// </summary>
    public unsafe int BlockedByShieldSinceAerial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7972); }
    }

    /// <summary>
    /// IntProperty: BlockedByTitanSinceSuperStun
    /// </summary>
    public unsafe int BlockedByTitanSinceSuperStun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7976); }
    }

    /// <summary>
    /// IntProperty: StunStickHits
    /// </summary>
    public unsafe int StunStickHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7980); }
    }

    /// <summary>
    /// IntProperty: BladeHits
    /// </summary>
    public unsafe int BladeHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7984); }
    }

    /// <summary>
    /// ArrayProperty: ComboValueReachedActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_ComboValueReached> ComboValueReachedActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_ComboValueReached>>(Ptr + 7988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7988); }
    }

    /// <summary>
    /// IntProperty: ConsecutiveBatarangsOrRedirects
    /// </summary>
    public unsafe int ConsecutiveBatarangsOrRedirects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8004); }
    }

    /// <summary>
    /// StrProperty: CombatBonusSummaryString
    /// </summary>
    public unsafe BmSDK.FString CombatBonusSummaryString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8008); }
    }

    /// <summary>
    /// FloatProperty: CombatBonusDelayTime
    /// </summary>
    public unsafe float CombatBonusDelayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8024); }
    }

    /// <summary>
    /// StructProperty: LastAttacked
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerControllerCombat.FStruckInfo LastAttacked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerControllerCombat.FStruckInfo>(Ptr + 8028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8028); }
    }

    /// <summary>
    /// ArrayProperty: ComboMoves
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerControllerCombat.FComboMoveInfo> ComboMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerControllerCombat.FComboMoveInfo>>(Ptr + 8040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8040); }
    }

    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8056); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8060); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8064); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8068); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8072); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8076); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8080); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8084); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8088); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8092); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8096); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8100); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8104); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8108); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8112); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8116); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8120); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8124); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8128); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8132); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8136); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8140); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8144); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8148); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8152); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8156); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8160); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8164); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8168); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8172); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8176); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8180); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8184); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8188); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8192); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8196); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8200); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8204); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8208); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8212); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8216); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8220); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8224); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8228); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8232); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8236); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8240); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8244); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8248); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8252); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8256); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8260); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8264); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8268); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8272); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8276); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8280); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8284); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8288); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8292); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8296); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8300); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8304); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8308); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8312); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8316); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8320); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8324); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8328); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8332); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8336); }
    }

    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8340); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8344); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8352); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8356); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8360); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8364); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8368); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8372); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8376); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8380); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8384); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8388); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8392); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8396); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8400); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8404); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8408); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8412); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8416); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8420); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8424); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8428); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8432); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8436); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8440); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8444); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8448); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8452); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8456); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8460); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8464); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8468); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8472); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8476); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8484); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8488); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8492); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8496); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8500); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8504); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8508); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8512); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8516); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8520); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8524); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8528); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8532); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8536); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8540); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8544); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8548); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8552); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8556); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8560); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8564); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8568); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8572); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8576); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8580); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8584); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8588); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8592); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8596); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8600); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8604); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8608); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8612); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8616); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8620); }
    }

    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8624); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8628); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8632); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8636); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8640); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8644); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8648); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8652); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8656); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8660); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8664); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8668); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8672); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8676); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8680); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8684); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8688); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8692); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8696); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8700); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8704); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8708); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8712); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8716); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8720); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8724); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8728); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8732); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8736); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8740); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8744); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8748); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8752); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8756); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8760); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8764); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8768); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8772); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8776); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8780); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8784); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8788); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8792); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8796); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8800); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8804); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8808); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8812); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8816); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8820); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8824); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8828); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8832); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8836); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8840); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8844); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8848); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8852); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8856); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8860); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8864); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8868); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8872); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8876); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8880); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8884); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8888); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8892); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8896); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8900); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8904); }
    }

    /// <summary>
    /// FloatProperty: CurrentLookAtTargetTime
    /// </summary>
    public unsafe float CurrentLookAtTargetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8908); }
    }

    /// <summary>
    /// IntProperty: FrontCounters
    /// </summary>
    public unsafe int FrontCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8912); }
    }

    /// <summary>
    /// IntProperty: BackCounters
    /// </summary>
    public unsafe int BackCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8916); }
    }

    /// <summary>
    /// FloatProperty: CurrCombatCamDistModifier
    /// </summary>
    public unsafe float CurrCombatCamDistModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8920); }
    }

    /// <summary>
    /// FloatProperty: CurrSuperComboPPAmount
    /// </summary>
    public unsafe float CurrSuperComboPPAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8924); }
    }

    /// <summary>
    /// FloatProperty: SniperPPVal
    /// </summary>
    public unsafe float SniperPPVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8928); }
    }

    /// <summary>
    /// FloatProperty: lastSniperPPUpdateTime
    /// </summary>
    public unsafe float lastSniperPPUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8932); }
    }

    /// <summary>
    /// FloatProperty: MaxVariationSpeedMulti
    /// </summary>
    public unsafe float MaxVariationSpeedMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8936); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastStrikeRequest
    /// </summary>
    public unsafe float TimeSinceLastStrikeRequest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8940); }
    }

    /// <summary>
    /// FloatProperty: FixedCombatCam_NoBaseTimer
    /// </summary>
    public unsafe float FixedCombatCam_NoBaseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8944); }
    }

    /// <summary>
    /// StrProperty: OverridenDeathTip
    /// </summary>
    public unsafe BmSDK.FString OverridenDeathTip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8948); }
    }

    /// <summary>
    /// ArrayProperty: ClearComboReasons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ClearComboReasons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8964); }
    }

    /// <summary>
    /// StrProperty: LastClearComboReason
    /// </summary>
    public unsafe BmSDK.FString LastClearComboReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8980); }
    }

    /// <summary>
    /// FloatProperty: lastFlashBangHitTime
    /// </summary>
    public unsafe float lastFlashBangHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8996); }
    }
}
