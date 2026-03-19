#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnHarleyChokePointBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnHarleyChokePointBase : BmSDK.BmGame.RPawnVillain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnHarleyChokePointBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnHarleyChokePointBase() { }

    /// <summary>
    /// Constructs a new RPawnHarleyChokePointBase
    /// </summary>
    public RPawnHarleyChokePointBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnHarleyChokePointBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnHarleyChokePointBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnHarleyChokePointBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnHarleyChokePointBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnHarleyChokePointBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnHarleyChokePointBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnHarleyChokePointBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnHarleyChokePointBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnHarleyChokePointBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IRSpotableInterface
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_IRSpotableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4676); }
    }

    /// <summary>
    /// ByteProperty: StuckRagdollSolution
    /// </summary>
    public unsafe byte StuckRagdollSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4684); }
    }

    /// <summary>
    /// ByteProperty: BeatdownTargetType
    /// </summary>
    public unsafe byte BeatdownTargetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4685); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4685); }
    }

    /// <summary>
    /// ByteProperty: AllowCounterAfterExitLimb
    /// </summary>
    public unsafe byte AllowCounterAfterExitLimb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4686); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4686); }
    }

    /// <summary>
    /// ByteProperty: CombatReadiness
    /// </summary>
    public unsafe byte CombatReadiness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4687); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4687); }
    }

    /// <summary>
    /// ByteProperty: CombatReadinessBot
    /// </summary>
    public unsafe byte CombatReadinessBot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4688); }
    }

    /// <summary>
    /// ByteProperty: SimultaneousAttackCounterLimb
    /// </summary>
    public unsafe byte SimultaneousAttackCounterLimb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4689); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4689); }
    }

    /// <summary>
    /// ByteProperty: InteractButton
    /// </summary>
    public unsafe byte InteractButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4690); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4690); }
    }

    /// <summary>
    /// ByteProperty: PreChargeUpRagVsNav
    /// </summary>
    public unsafe byte PreChargeUpRagVsNav
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4691); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4691); }
    }

    /// <summary>
    /// ObjectProperty: V2TakenDownCoordinator
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT V2TakenDownCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4692); }
    }

    /// <summary>
    /// ObjectProperty: IceBreakerCoordinator
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT IceBreakerCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4700); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Ragdoll
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PoseConfig_Ragdoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4708); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Writhe
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PoseConfig_Writhe
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4716); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Attacked
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PoseConfig_Attacked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4724); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_HitReaction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PoseConfig_HitReaction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4732); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_HitReaction_Standing
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PoseConfig_HitReaction_Standing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4740); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_HitReaction_Combat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PoseConfig_HitReaction_Combat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4748); }
    }

    /// <summary>
    /// ObjectProperty: TauntAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TauntAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4756); }
    }

    /// <summary>
    /// ObjectProperty: TauntMovementAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TauntMovementAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4764); }
    }

    /// <summary>
    /// ObjectProperty: CombatMovementAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatMovementAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4772); }
    }

    /// <summary>
    /// ObjectProperty: ThugInteractionAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThugInteractionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4780); }
    }

    /// <summary>
    /// ObjectProperty: DisableAIAlertsVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DisableAIAlertsVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4788); }
    }

    /// <summary>
    /// ObjectProperty: SavedKiller
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SavedKiller
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4796); }
    }

    /// <summary>
    /// ObjectProperty: PlayerHitReactionAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }

    /// <summary>
    /// ObjectProperty: RECHitReactionAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RECHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4812); }
    }

    /// <summary>
    /// ObjectProperty: PlayerRedirectAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerRedirectAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4820); }
    }

    /// <summary>
    /// ObjectProperty: OverrideTargetPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverrideTargetPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }

    /// <summary>
    /// ObjectProperty: PawnEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PawnEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickPS
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GlideKickPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4844); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickMat_M
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GlideKickMat_M
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4852); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickMat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GlideKickMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4860); }
    }

    /// <summary>
    /// ObjectProperty: BatDistractPS
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatDistractPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4868); }
    }

    /// <summary>
    /// ObjectProperty: StoredCounterIconPlayerController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StoredCounterIconPlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4876); }
    }

    /// <summary>
    /// ObjectProperty: CurrentMedic
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentMedic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4884); }
    }

    /// <summary>
    /// ObjectProperty: CurrentThrower
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentThrower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4892); }
    }

    /// <summary>
    /// ObjectProperty: CriticalHitPS
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CriticalHitPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4900); }
    }

    /// <summary>
    /// ObjectProperty: TrackTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TrackTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4908); }
    }

    /// <summary>
    /// ObjectProperty: DamageTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DamageTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4916); }
    }

    /// <summary>
    /// ObjectProperty: ForceMissTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ForceMissTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4924); }
    }

    /// <summary>
    /// ObjectProperty: RelatedHidePoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RelatedHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4932); }
    }

    /// <summary>
    /// ObjectProperty: PrimaryBarkCharDef
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PrimaryBarkCharDef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4940); }
    }

    /// <summary>
    /// ObjectProperty: MyLevelVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyLevelVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4948); }
    }

    /// <summary>
    /// ObjectProperty: VillainTargetPlayer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainTargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4956); }
    }

    /// <summary>
    /// ObjectProperty: CombatTargetActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatTargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4964); }
    }

    /// <summary>
    /// ObjectProperty: ForceTargetPlayer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ForceTargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4972); }
    }

    /// <summary>
    /// ObjectProperty: TargetPlayerOverride
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetPlayerOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4980); }
    }

    /// <summary>
    /// ObjectProperty: ProcessKickedNoisePlayer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ProcessKickedNoisePlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4988); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InterrogationEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4996); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationAction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InterrogationAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5004); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationAura
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InterrogationAura
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5012); }
    }

    /// <summary>
    /// ObjectProperty: XrayInterrogationAura
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XrayInterrogationAura
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5020); }
    }

    /// <summary>
    /// ObjectProperty: BlockAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BlockAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5028); }
    }

    /// <summary>
    /// ObjectProperty: WalkCycleVariationAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WalkCycleVariationAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5036); }
    }

    /// <summary>
    /// ObjectProperty: PauseCheckAreaAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PauseCheckAreaAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5044); }
    }

    /// <summary>
    /// ObjectProperty: StoredCannotBeTargettedByPlayer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StoredCannotBeTargettedByPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5052); }
    }

    /// <summary>
    /// ObjectProperty: SpriteMatIC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpriteMatIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5060); }
    }

    /// <summary>
    /// ObjectProperty: OverridenGlideKickMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverridenGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5068); }
    }

    /// <summary>
    /// ObjectProperty: CarryingTrophy
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CarryingTrophy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5076); }
    }

    /// <summary>
    /// ObjectProperty: ControllingRobin
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ControllingRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5084); }
    }

    /// <summary>
    /// ObjectProperty: GrateTakenDownFrom
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrateTakenDownFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5092); }
    }

    /// <summary>
    /// ObjectProperty: TunnelTakenDownFrom
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TunnelTakenDownFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5100); }
    }

    /// <summary>
    /// ObjectProperty: ChargedUpBy
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChargedUpBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5108); }
    }

    /// <summary>
    /// ObjectProperty: ChargedUpShootPS
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChargedUpShootPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5116); }
    }

    /// <summary>
    /// ObjectProperty: ChargedUpHitPS
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChargedUpHitPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5124); }
    }

    /// <summary>
    /// ObjectProperty: MiniDroneTargetingMe
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MiniDroneTargetingMe
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5132); }
    }

    /// <summary>
    /// ObjectProperty: MyMiniDrone
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyMiniDrone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5140); }
    }

    /// <summary>
    /// ObjectProperty: SpecialGearDisruptedVFXTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpecialGearDisruptedVFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5148); }
    }

    /// <summary>
    /// ObjectProperty: CombatLOSCheckVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatLOSCheckVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5156); }
    }

    /// <summary>
    /// ObjectProperty: BombThugController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BombThugController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5164); }
    }

    /// <summary>
    /// ObjectProperty: KnockBackIfShotVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KnockBackIfShotVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5172); }
    }

    /// <summary>
    /// ObjectProperty: KnockBackPlayerConfig
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KnockBackPlayerConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5180); }
    }

    /// <summary>
    /// ObjectProperty: VillainBatclawSlamAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainBatclawSlamAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5188); }
    }

    /// <summary>
    /// ObjectProperty: DMDAECForBark
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DMDAECForBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5196); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractInteraction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerInteractInteraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5204); }
    }

    /// <summary>
    /// ComponentProperty: DLCXtraMaskHeadMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DLCXtraMaskHeadMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5212); }
    }

    /// <summary>
    /// ComponentProperty: DLCXtraMaskBodyMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DLCXtraMaskBodyMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5220); }
    }

    /// <summary>
    /// ClassProperty: BeatdownCombatMoveClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BeatdownCombatMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5228); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInterrogationPredatorInteractions
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerInterrogationPredatorInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5236); }
    }

    /// <summary>
    /// ComponentProperty: RHDInteractions
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RHDInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5244); }
    }

    /// <summary>
    /// ComponentProperty: CatVisionParticleFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatVisionParticleFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5252); }
    }

    /// <summary>
    /// ComponentProperty: DeadParticleFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DeadParticleFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5260); }
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5268); }
    }

    /// <summary>
    /// ComponentProperty: CriticalPfxComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CriticalPfxComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5276); }
    }

    /// <summary>
    /// ClassProperty: WeaponSwitchCallbackToNoneDamageType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeaponSwitchCallbackToNoneDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5284); }
    }

    /// <summary>
    /// ClassProperty: LastDamageType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5292); }
    }

    /// <summary>
    /// ClassProperty: DeathDamageType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DeathDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5300); }
    }

    /// <summary>
    /// ComponentProperty: HeadPSC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HeadPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5308); }
    }

    /// <summary>
    /// ClassProperty: FreezeBlastHitBehaviourClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FreezeBlastHitBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 5316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5316); }
    }

    /// <summary>
    /// BoolProperty: bPlayedFallingSound
    /// </summary>
    public unsafe bool bPlayedFallingSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bUsesCustomCounterAnims
    /// </summary>
    public unsafe bool bUsesCustomCounterAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bDiedAlready
    /// </summary>
    public unsafe bool bDiedAlready
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bBeingTakenDown
    /// </summary>
    public unsafe bool bBeingTakenDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bAwardedRingOut
    /// </summary>
    public unsafe bool bAwardedRingOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bAwardedXP
    /// </summary>
    public unsafe bool bAwardedXP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bCanDieByFalling
    /// </summary>
    public unsafe bool bCanDieByFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bStopSpeechOnDeath
    /// </summary>
    public unsafe bool bStopSpeechOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bCanCombatBark
    /// </summary>
    public unsafe bool bCanCombatBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bStopDialogueWhenHit
    /// </summary>
    public unsafe bool bStopDialogueWhenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bAwardDeathScore
    /// </summary>
    public unsafe bool bAwardDeathScore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bFlee
    /// </summary>
    public unsafe bool bFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bNeverFlee
    /// </summary>
    public unsafe bool bNeverFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bDontAlertPawnsInOtherPylons
    /// </summary>
    public unsafe bool bDontAlertPawnsInOtherPylons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bForceNonCombatSilentTakedown
    /// </summary>
    public unsafe bool bForceNonCombatSilentTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bPreventPredatorTakedownCam
    /// </summary>
    public unsafe bool bPreventPredatorTakedownCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bArmoured
    /// </summary>
    public unsafe bool bArmoured
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bBeatdownCountEqualsHealth
    /// </summary>
    public unsafe bool bBeatdownCountEqualsHealth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bCanPlayEnterCombatBark
    /// </summary>
    public unsafe bool bCanPlayEnterCombatBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bShouldPreventFinalBlowCam
    /// </summary>
    public unsafe bool bShouldPreventFinalBlowCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bWearingExplosiveVest
    /// </summary>
    public unsafe bool bWearingExplosiveVest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bCanTargetBatmobile
    /// </summary>
    public unsafe bool bCanTargetBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bHiddenInXray
    /// </summary>
    public unsafe bool bHiddenInXray
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bHasRegisteredBatmobileKillBonus
    /// </summary>
    public unsafe bool bHasRegisteredBatmobileKillBonus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bGlideKickPSActive
    /// </summary>
    public unsafe bool bGlideKickPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bAttackingPSActive
    /// </summary>
    public unsafe bool bAttackingPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bAttackingPSShouldBeActive
    /// </summary>
    public unsafe bool bAttackingPSShouldBeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bSuspendCombatStasisUntilBeenInView
    /// </summary>
    public unsafe bool bSuspendCombatStasisUntilBeenInView
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bSuspendCombatStasis
    /// </summary>
    public unsafe bool bSuspendCombatStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bReduceGelForce
    /// </summary>
    public unsafe bool bReduceGelForce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bForceCombatTaunt
    /// </summary>
    public unsafe bool bForceCombatTaunt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bImmuneToBatclawDisarm
    /// </summary>
    public unsafe bool bImmuneToBatclawDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5324); }
    }

    /// <summary>
    /// BoolProperty: bInfiniteBeatdown
    /// </summary>
    public unsafe bool bInfiniteBeatdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bInfiniteBeatdownAlways
    /// </summary>
    public unsafe bool bInfiniteBeatdownAlways
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bNoBeatdownComboInc
    /// </summary>
    public unsafe bool bNoBeatdownComboInc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bUseSideStepsInCombat
    /// </summary>
    public unsafe bool bUseSideStepsInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bStartedWithGun
    /// </summary>
    public unsafe bool bStartedWithGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bMedic
    /// </summary>
    public unsafe bool bMedic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bPrioritiseReviving
    /// </summary>
    public unsafe bool bPrioritiseReviving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanBeRevived
    /// </summary>
    public unsafe bool bCanBeRevived
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bBypassStrikeCollisionChecks
    /// </summary>
    public unsafe bool bBypassStrikeCollisionChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanHelpUpThugs
    /// </summary>
    public unsafe bool bCanHelpUpThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bDiveAwayCollisionChecks
    /// </summary>
    public unsafe bool bDiveAwayCollisionChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanDiveAwayFromCars
    /// </summary>
    public unsafe bool bCanDiveAwayFromCars
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanBeZappedByBatmobile
    /// </summary>
    public unsafe bool bCanBeZappedByBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bHitDamageTarget
    /// </summary>
    public unsafe bool bHitDamageTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bGoodAsDead
    /// </summary>
    public unsafe bool bGoodAsDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bAddedTakedownInvestigateInfo
    /// </summary>
    public unsafe bool bAddedTakedownInvestigateInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bHasContributedToFearLevel
    /// </summary>
    public unsafe bool bHasContributedToFearLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bStrungUp
    /// </summary>
    public unsafe bool bStrungUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bStrungUpBark
    /// </summary>
    public unsafe bool bStrungUpBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCutDown
    /// </summary>
    public unsafe bool bCutDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bDontUseEmotes
    /// </summary>
    public unsafe bool bDontUseEmotes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bPlayedImpactEmote
    /// </summary>
    public unsafe bool bPlayedImpactEmote
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanBeatdown
    /// </summary>
    public unsafe bool bCanBeatdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bLoadPairedAnims
    /// </summary>
    public unsafe bool bLoadPairedAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bLoadPairedAnimsBot
    /// </summary>
    public unsafe bool bLoadPairedAnimsBot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bLoadedPairedAnimsets
    /// </summary>
    public unsafe bool bLoadedPairedAnimsets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: RiotSurpressorCanKill
    /// </summary>
    public unsafe bool RiotSurpressorCanKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: JustClimbedLadder
    /// </summary>
    public unsafe bool JustClimbedLadder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bDoPostCutNotify
    /// </summary>
    public unsafe bool bDoPostCutNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bSelfManageTargetSelection
    /// </summary>
    public unsafe bool bSelfManageTargetSelection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bHasThermalGoggles
    /// </summary>
    public unsafe bool bHasThermalGoggles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bIsMobileJammer
    /// </summary>
    public unsafe bool bIsMobileJammer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bJammerDisabled
    /// </summary>
    public unsafe bool bJammerDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bJammerDestroyed
    /// </summary>
    public unsafe bool bJammerDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bDetectiveModeDetector
    /// </summary>
    public unsafe bool bDetectiveModeDetector
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bWearingHeadset
    /// </summary>
    public unsafe bool bWearingHeadset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bHasMines
    /// </summary>
    public unsafe bool bHasMines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bHasVantageMines
    /// </summary>
    public unsafe bool bHasVantageMines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bIsNearThugMine
    /// </summary>
    public unsafe bool bIsNearThugMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bIsMinigunner
    /// </summary>
    public unsafe bool bIsMinigunner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bHasStealthSuit
    /// </summary>
    public unsafe bool bHasStealthSuit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bHasPredDrone
    /// </summary>
    public unsafe bool bHasPredDrone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bIsInformant
    /// </summary>
    public unsafe bool bIsInformant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bIsRiddlerTutorial
    /// </summary>
    public unsafe bool bIsRiddlerTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bInterrogateable
    /// </summary>
    public unsafe bool bInterrogateable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bBeingInterrogated
    /// </summary>
    public unsafe bool bBeingInterrogated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bCanInterrogateFromFront
    /// </summary>
    public unsafe bool bCanInterrogateFromFront
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bDontTriggerDynamicTutorial
    /// </summary>
    public unsafe bool bDontTriggerDynamicTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bShownInterrogationTutorial
    /// </summary>
    public unsafe bool bShownInterrogationTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bCreatedInterrogateSpriteMat
    /// </summary>
    public unsafe bool bCreatedInterrogateSpriteMat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bIsPickPocketTarget
    /// </summary>
    public unsafe bool bIsPickPocketTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bDisableSimultaneousAttacks
    /// </summary>
    public unsafe bool bDisableSimultaneousAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bInvulnerableToAnitFirearmGel
    /// </summary>
    public unsafe bool bInvulnerableToAnitFirearmGel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bAirStrikeable
    /// </summary>
    public unsafe bool bAirStrikeable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bAirPickupable
    /// </summary>
    public unsafe bool bAirPickupable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bCanCheckFalling
    /// </summary>
    public unsafe bool bCanCheckFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bForceAllowGroundTakedown
    /// </summary>
    public unsafe bool bForceAllowGroundTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bLastRECProjectileWasFromGarg
    /// </summary>
    public unsafe bool bLastRECProjectileWasFromGarg
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bReceiveSoftPawnCollision_Old
    /// </summary>
    public unsafe bool bReceiveSoftPawnCollision_Old
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDodgesWhip
    /// </summary>
    public unsafe bool bAlwaysDodgesWhip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bEnteredCombatFromRange
    /// </summary>
    public unsafe bool bEnteredCombatFromRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bCanTakeFreezeHit
    /// </summary>
    public unsafe bool bCanTakeFreezeHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bCanTakeFreezeClusterHit
    /// </summary>
    public unsafe bool bCanTakeFreezeClusterHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bFocusAuraFlashing
    /// </summary>
    public unsafe bool bFocusAuraFlashing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bStickyBombAttached
    /// </summary>
    public unsafe bool bStickyBombAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bGooMineAttached
    /// </summary>
    public unsafe bool bGooMineAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bNoStrikeTargettingCollisionChecks
    /// </summary>
    public unsafe bool bNoStrikeTargettingCollisionChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCanBeTargettedForCombatTakedown
    /// </summary>
    public unsafe bool bCanBeTargettedForCombatTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bImmuneToLineLaunchTakedown
    /// </summary>
    public unsafe bool bImmuneToLineLaunchTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bReportKOTypeGameAction
    /// </summary>
    public unsafe bool bReportKOTypeGameAction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCantTakeSuperBatclawSlam
    /// </summary>
    public unsafe bool bCantTakeSuperBatclawSlam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bDisableBatarangHitReaction
    /// </summary>
    public unsafe bool bDisableBatarangHitReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bDoNotStopDialogueOnActivate
    /// </summary>
    public unsafe bool bDoNotStopDialogueOnActivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bOverrideGlideKick
    /// </summary>
    public unsafe bool bOverrideGlideKick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDropAttack
    /// </summary>
    public unsafe bool bOverrideDropAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: isBagCarrier
    /// </summary>
    public unsafe bool isBagCarrier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bBagCarrierDistStartleSpecialCase
    /// </summary>
    public unsafe bool bBagCarrierDistStartleSpecialCase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPredAttackWhitelist
    /// </summary>
    public unsafe bool bPredAttackWhitelist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCanBeShoved
    /// </summary>
    public unsafe bool bCanBeShoved
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCanThrowCounter
    /// </summary>
    public unsafe bool bCanThrowCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bDontReactToAntiWeaponGel
    /// </summary>
    public unsafe bool bDontReactToAntiWeaponGel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bLowDamage
    /// </summary>
    public unsafe bool bLowDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreBatmobileThreat
    /// </summary>
    public unsafe bool bIgnoreBatmobileThreat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bEnterCombatWhenNextRunAway
    /// </summary>
    public unsafe bool bEnterCombatWhenNextRunAway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bUpdateChain
    /// </summary>
    public unsafe bool bUpdateChain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bAllowFearTakedown
    /// </summary>
    public unsafe bool bAllowFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bWasTakendownByAFearTakedown
    /// </summary>
    public unsafe bool bWasTakendownByAFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCurrentFearTakedownTarget
    /// </summary>
    public unsafe bool bCurrentFearTakedownTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bNotScaredOfBatmobile
    /// </summary>
    public unsafe bool bNotScaredOfBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bDLCIsPlantTarget
    /// </summary>
    public unsafe bool bDLCIsPlantTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bIsDLCSniper
    /// </summary>
    public unsafe bool bIsDLCSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bIsOnLadder
    /// </summary>
    public unsafe bool bIsOnLadder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bIsPuzzleRobot
    /// </summary>
    public unsafe bool bIsPuzzleRobot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCanInteract
    /// </summary>
    public unsafe bool bCanInteract
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bCanInteractWhenDead
    /// </summary>
    public unsafe bool bCanInteractWhenDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bInteractPromptOverridePreviousLines
    /// </summary>
    public unsafe bool bInteractPromptOverridePreviousLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bNoInteractPrompt
    /// </summary>
    public unsafe bool bNoInteractPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bDontAnnounceManDown
    /// </summary>
    public unsafe bool bDontAnnounceManDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bForceIntoTauntASAP
    /// </summary>
    public unsafe bool bForceIntoTauntASAP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bSpecialGearIsDisrupted
    /// </summary>
    public unsafe bool bSpecialGearIsDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bInDMDOutTransition
    /// </summary>
    public unsafe bool bInDMDOutTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bCanUseEnvironmentPickup
    /// </summary>
    public unsafe bool bCanUseEnvironmentPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bBombThugAuraActive
    /// </summary>
    public unsafe bool bBombThugAuraActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bCanThrowGrenadesIfUnarmed
    /// </summary>
    public unsafe bool bCanThrowGrenadesIfUnarmed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bHasSeenBatman
    /// </summary>
    public unsafe bool bHasSeenBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bHasSeenBatmobile
    /// </summary>
    public unsafe bool bHasSeenBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bKilledByLedgeTakedown
    /// </summary>
    public unsafe bool bKilledByLedgeTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// FloatProperty: FallingTime
    /// </summary>
    public unsafe float FallingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5344); }
    }

    /// <summary>
    /// StructProperty: FallingPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FallingPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5348); }
    }

    /// <summary>
    /// FloatProperty: FallingStartHeight
    /// </summary>
    public unsafe float FallingStartHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5360); }
    }

    /// <summary>
    /// IntProperty: RetrySplashAndDestroyCount
    /// </summary>
    public unsafe int RetrySplashAndDestroyCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5364); }
    }

    /// <summary>
    /// FloatProperty: AntiDodgeFactor
    /// </summary>
    public unsafe float AntiDodgeFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5368); }
    }

    /// <summary>
    /// IntProperty: KillFallSpeed
    /// </summary>
    public unsafe int KillFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5372); }
    }

    /// <summary>
    /// IntProperty: DestroyFallSpeed
    /// </summary>
    public unsafe int DestroyFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5376); }
    }

    /// <summary>
    /// StructProperty: AvoidanceLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AvoidanceLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5380); }
    }

    /// <summary>
    /// ArrayProperty: OverlayAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> OverlayAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 5392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5392); }
    }

    /// <summary>
    /// ArrayProperty: ArmouredOverlayAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> ArmouredOverlayAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 5408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5408); }
    }

    /// <summary>
    /// NameProperty: CanOnlyBeHitBy
    /// </summary>
    public unsafe BmSDK.FName CanOnlyBeHitBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5424); }
    }

    /// <summary>
    /// IntProperty: TauntSetID
    /// </summary>
    public unsafe int TauntSetID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5432); }
    }

    /// <summary>
    /// ArrayProperty: TauntAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> TauntAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 5436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5436); }
    }

    /// <summary>
    /// ArrayProperty: TauntMovementAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> TauntMovementAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 5452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5452); }
    }

    /// <summary>
    /// IntProperty: ForceTauntSetID
    /// </summary>
    public unsafe int ForceTauntSetID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5468); }
    }

    /// <summary>
    /// ArrayProperty: StepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> StepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 5472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5472); }
    }

    /// <summary>
    /// FloatProperty: StepLength
    /// </summary>
    public unsafe float StepLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5488); }
    }

    /// <summary>
    /// ArrayProperty: LongStepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> LongStepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 5492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5492); }
    }

    /// <summary>
    /// NameProperty: ForwardStepName
    /// </summary>
    public unsafe BmSDK.FName ForwardStepName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5508); }
    }

    /// <summary>
    /// FloatProperty: DelayBeforeActiveCombat
    /// </summary>
    public unsafe float DelayBeforeActiveCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5516); }
    }

    /// <summary>
    /// IntProperty: LastComboSizeWhenHit
    /// </summary>
    public unsafe int LastComboSizeWhenHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5520); }
    }

    /// <summary>
    /// FloatProperty: MonitorRagdollForHighVelocityTimer
    /// </summary>
    public unsafe float MonitorRagdollForHighVelocityTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5524); }
    }

    /// <summary>
    /// IntProperty: RingOutCombo
    /// </summary>
    public unsafe int RingOutCombo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5528); }
    }

    /// <summary>
    /// FloatProperty: PostHitNoTakedownTimer
    /// </summary>
    public unsafe float PostHitNoTakedownTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5532); }
    }

    /// <summary>
    /// FloatProperty: CombatDistance
    /// </summary>
    public unsafe float CombatDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5536); }
    }

    /// <summary>
    /// IntProperty: StoredCounterIconType
    /// </summary>
    public unsafe int StoredCounterIconType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5540); }
    }

    /// <summary>
    /// FloatProperty: RagdollForceMultiplier
    /// </summary>
    public unsafe float RagdollForceMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5544); }
    }

    /// <summary>
    /// IntProperty: MedicRevivesRemaining
    /// </summary>
    public unsafe int MedicRevivesRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5548); }
    }

    /// <summary>
    /// FloatProperty: DelayWeaponPickupTime
    /// </summary>
    public unsafe float DelayWeaponPickupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5552); }
    }

    /// <summary>
    /// ArrayProperty: SavedPositions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SavedPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 5556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5556); }
    }

    /// <summary>
    /// FloatProperty: TrackHistoryTime
    /// </summary>
    public unsafe float TrackHistoryTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5572); }
    }

    /// <summary>
    /// FloatProperty: StoredFearLevel
    /// </summary>
    public unsafe float StoredFearLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5576); }
    }

    /// <summary>
    /// FloatProperty: DodgeCurrent
    /// </summary>
    public unsafe float DodgeCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5580); }
    }

    /// <summary>
    /// StructProperty: HangGrabLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HangGrabLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5584); }
    }

    /// <summary>
    /// StructProperty: HangRopeEndLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HangRopeEndLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5596); }
    }

    /// <summary>
    /// StructProperty: HangFloorBelowLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HangFloorBelowLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5608); }
    }

    /// <summary>
    /// FloatProperty: PawnBatarangStunModifier
    /// </summary>
    public unsafe float PawnBatarangStunModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5620); }
    }

    /// <summary>
    /// StrProperty: PrimaryBCDstring
    /// </summary>
    public unsafe BmSDK.FString PrimaryBCDstring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5624); }
    }

    /// <summary>
    /// ArrayProperty: PreferredBarkSet
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> PreferredBarkSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 5640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5640); }
    }

    /// <summary>
    /// FloatProperty: JewelleryValue
    /// </summary>
    public unsafe float JewelleryValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5656); }
    }

    /// <summary>
    /// IntProperty: JewelleryIndex
    /// </summary>
    public unsafe int JewelleryIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }

    /// <summary>
    /// ArrayProperty: PlayerPairedAnimsetPackageDefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> PlayerPairedAnimsetPackageDefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 5664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5664); }
    }

    /// <summary>
    /// IntProperty: CurrPairedAnimsetIndex
    /// </summary>
    public unsafe int CurrPairedAnimsetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5680); }
    }

    /// <summary>
    /// IntProperty: CurrPairedAnimsetIndexBot
    /// </summary>
    public unsafe int CurrPairedAnimsetIndexBot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5684); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredPairedAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> RegisteredPairedAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 5688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5688); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredDualStrikeTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RegisteredDualStrikeTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 5704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5704); }
    }

    /// <summary>
    /// StrProperty: LoadingPairedAnimsetPackage
    /// </summary>
    public unsafe BmSDK.FString LoadingPairedAnimsetPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5720); }
    }

    /// <summary>
    /// StrProperty: LoadingPairedAnimsetPackageBot
    /// </summary>
    public unsafe BmSDK.FString LoadingPairedAnimsetPackageBot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5736); }
    }

    /// <summary>
    /// ArrayProperty: CombatAnimsetRefHolders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CombatAnimsetRefHolders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 5752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5752); }
    }

    /// <summary>
    /// IntProperty: HitRatioCounter
    /// </summary>
    public unsafe int HitRatioCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5768); }
    }

    /// <summary>
    /// FloatProperty: CustomAntiPersonelStunTime
    /// </summary>
    public unsafe float CustomAntiPersonelStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5772); }
    }

    /// <summary>
    /// IntProperty: GetUpAttempts
    /// </summary>
    public unsafe int GetUpAttempts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5776); }
    }

    /// <summary>
    /// StructProperty: StoredCasPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StoredCasPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5780); }
    }

    /// <summary>
    /// FloatProperty: StoredCasPosTime
    /// </summary>
    public unsafe float StoredCasPosTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5792); }
    }

    /// <summary>
    /// NameProperty: RagdollRestTestBone
    /// </summary>
    public unsafe BmSDK.FName RagdollRestTestBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5796); }
    }

    /// <summary>
    /// FloatProperty: LinearRestThreshold
    /// </summary>
    public unsafe float LinearRestThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5804); }
    }

    /// <summary>
    /// FloatProperty: AngularRestThreshold
    /// </summary>
    public unsafe float AngularRestThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5808); }
    }

    /// <summary>
    /// StructProperty: ServerLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ServerLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5812); }
    }

    /// <summary>
    /// StructProperty: ServerRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ServerRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5824); }
    }

    /// <summary>
    /// StructProperty: StateAtTimeOfKick
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateAtTimeOfKick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5836); }
    }

    /// <summary>
    /// FloatProperty: InterrogateTutorialTime
    /// </summary>
    public unsafe float InterrogateTutorialTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5964); }
    }

    /// <summary>
    /// StrProperty: InteractPrompt
    /// </summary>
    public unsafe BmSDK.FString InteractPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5968); }
    }

    /// <summary>
    /// NameProperty: AerialAttackAnimName
    /// </summary>
    public unsafe BmSDK.FName AerialAttackAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5984); }
    }

    /// <summary>
    /// ArrayProperty: OverrideStealthTakedown
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> OverrideStealthTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>(Ptr + 5992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5992); }
    }

    /// <summary>
    /// ArrayProperty: DualTeamTakedowns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> DualTeamTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>(Ptr + 6008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6008); }
    }

    /// <summary>
    /// FloatProperty: BatclawReleaseTime
    /// </summary>
    public unsafe float BatclawReleaseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6024); }
    }

    /// <summary>
    /// ArrayProperty: BatclawSocketTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> BatclawSocketTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>(Ptr + 6028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6028); }
    }

    /// <summary>
    /// FloatProperty: FreezeTime
    /// </summary>
    public unsafe float FreezeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6044); }
    }

    /// <summary>
    /// FloatProperty: FloorFreezeTime
    /// </summary>
    public unsafe float FloorFreezeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6048); }
    }

    /// <summary>
    /// FloatProperty: GooSprayImpulseMultiplier
    /// </summary>
    public unsafe float GooSprayImpulseMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6052); }
    }

    /// <summary>
    /// StructProperty: LastBeatdownInfo
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastBeatdownInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6056); }
    }

    /// <summary>
    /// StructProperty: MagnetisedWeaponHitTransition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MagnetisedWeaponHitTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6072); }
    }

    /// <summary>
    /// ArrayProperty: MFAAttractReceivers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> MFAAttractReceivers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>(Ptr + 6076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6076); }
    }

    /// <summary>
    /// ArrayProperty: MFAStuckWeapons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>>> MFAStuckWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>(Ptr + 6092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6092); }
    }

    /// <summary>
    /// StructProperty: FearGasHitTransition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FearGasHitTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6108); }
    }

    /// <summary>
    /// FloatProperty: LastBlockTime
    /// </summary>
    public unsafe float LastBlockTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6112); }
    }

    /// <summary>
    /// IntProperty: SurprisedByBatarang
    /// </summary>
    public unsafe int SurprisedByBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6116); }
    }

    /// <summary>
    /// StructProperty: LastRECProjectileSourcePos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastRECProjectileSourcePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6120); }
    }

    /// <summary>
    /// StructProperty: StartCombatLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StartCombatLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6132); }
    }

    /// <summary>
    /// NameProperty: RECTargetBone
    /// </summary>
    public unsafe BmSDK.FName RECTargetBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6144); }
    }

    /// <summary>
    /// FloatProperty: LastCowerTime
    /// </summary>
    public unsafe float LastCowerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6152); }
    }

    /// <summary>
    /// ArrayProperty: DropPropsArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>> DropPropsArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>>>(Ptr + 6156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6156); }
    }

    /// <summary>
    /// FloatProperty: FocusAuraFlashTimer
    /// </summary>
    public unsafe float FocusAuraFlashTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6172); }
    }

    /// <summary>
    /// IntProperty: CowerProjectileID
    /// </summary>
    public unsafe int CowerProjectileID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6176); }
    }

    /// <summary>
    /// FloatProperty: GettingUpFromRagdollTimer
    /// </summary>
    public unsafe float GettingUpFromRagdollTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6180); }
    }

    /// <summary>
    /// FloatProperty: fOverrideGlideKickStartDuration
    /// </summary>
    public unsafe float fOverrideGlideKickStartDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6184); }
    }

    /// <summary>
    /// FloatProperty: fOverrideDropAttackHeight
    /// </summary>
    public unsafe float fOverrideDropAttackHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6188); }
    }

    /// <summary>
    /// FloatProperty: fOverrideDropAttackMaxHorzDist
    /// </summary>
    public unsafe float fOverrideDropAttackMaxHorzDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6192); }
    }

    /// <summary>
    /// FloatProperty: BatmobileThreatTime
    /// </summary>
    public unsafe float BatmobileThreatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6196); }
    }

    /// <summary>
    /// FloatProperty: timeOfDeath
    /// </summary>
    public unsafe float timeOfDeath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6200); }
    }

    /// <summary>
    /// ArrayProperty: DamageAllowed
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>> DamageAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>>(Ptr + 6204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6204); }
    }

    /// <summary>
    /// ArrayProperty: TakedownAllowed
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>> TakedownAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>>(Ptr + 6220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6220); }
    }

    /// <summary>
    /// FloatProperty: InteractPriority
    /// </summary>
    public unsafe float InteractPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6236); }
    }

    /// <summary>
    /// ArrayProperty: GadgetProjHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>> GadgetProjHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>>(Ptr + 6240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6240); }
    }

    /// <summary>
    /// StructProperty: vJammedVFXPivotParameter
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT vJammedVFXPivotParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6256); }
    }

    /// <summary>
    /// FloatProperty: fJammedVFXRadiusParameter
    /// </summary>
    public unsafe float fJammedVFXRadiusParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6268); }
    }

    /// <summary>
    /// FloatProperty: fJammedVFXLengthParameter
    /// </summary>
    public unsafe float fJammedVFXLengthParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6272); }
    }

    /// <summary>
    /// StructProperty: DMDOutAnimId
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DMDOutAnimId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6276); }
    }

    /// <summary>
    /// FloatProperty: DistForMediumThugPickup
    /// </summary>
    public unsafe float DistForMediumThugPickup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6280); }
    }

    /// <summary>
    /// FloatProperty: DistForFarThugPickup
    /// </summary>
    public unsafe float DistForFarThugPickup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6284); }
    }

    /// <summary>
    /// StructProperty: LastGrateWatchPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastGrateWatchPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6288); }
    }

    /// <summary>
    /// StructProperty: LastValidBatmobileTakedownPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastValidBatmobileTakedownPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6300); }
    }

    /// <summary>
    /// FloatProperty: AttackDelay
    /// </summary>
    public unsafe float AttackDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6312); }
    }

    /// <summary>
    /// StructProperty: KnockBackDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT KnockBackDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6316); }
    }

    /// <summary>
    /// ArrayProperty: CounterAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>> CounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>>(Ptr + 6328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6328); }
    }

    /// <summary>
    /// ArrayProperty: BMCounterAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>> BMCounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>>(Ptr + 6344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6344); }
    }

    /// <summary>
    /// ArrayProperty: BeatdownHitReactionAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>> BeatdownHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>>(Ptr + 6360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6360); }
    }

    /// <summary>
    /// ArrayProperty: VillainAerialAttackAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>> VillainAerialAttackAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>>(Ptr + 6376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6376); }
    }

    /// <summary>
    /// ArrayProperty: PlayerAerialAttackAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>> PlayerAerialAttackAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>>(Ptr + 6392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6392); }
    }

    /// <summary>
    /// ArrayProperty: VillainFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>> VillainFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>>(Ptr + 6408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6408); }
    }

    /// <summary>
    /// ArrayProperty: PlayerFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>> PlayerFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>>(Ptr + 6424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6424); }
    }

    /// <summary>
    /// ArrayProperty: CameraAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>> CameraAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>>(Ptr + 6440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6440); }
    }

    /// <summary>
    /// ArrayProperty: GrabAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>> GrabAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>>(Ptr + 6456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6456); }
    }

    /// <summary>
    /// ArrayProperty: BMGrabAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>> BMGrabAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>>(Ptr + 6472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6472); }
    }

    /// <summary>
    /// ArrayProperty: ChargeAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>> ChargeAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>>(Ptr + 6488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6488); }
    }

    /// <summary>
    /// ArrayProperty: PlayerChargeAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>> PlayerChargeAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>>(Ptr + 6504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6504); }
    }

    /// <summary>
    /// ArrayProperty: PlayerDualPlayAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>> PlayerDualPlayAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>>(Ptr + 6520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6520); }
    }

    /// <summary>
    /// ArrayProperty: VillainDualPlayAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>> VillainDualPlayAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>>(Ptr + 6536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6536); }
    }

    /// <summary>
    /// ArrayProperty: VillainEnvTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>> VillainEnvTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>(Ptr + 6552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6552); }
    }

    /// <summary>
    /// ArrayProperty: PlayerEnvTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>> PlayerEnvTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>(Ptr + 6568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6568); }
    }

    /// <summary>
    /// ArrayProperty: VillainPredTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>> VillainPredTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>(Ptr + 6584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6584); }
    }

    /// <summary>
    /// ArrayProperty: PlayerPredTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> PlayerPredTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 6600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6600); }
    }

    /// <summary>
    /// ArrayProperty: VillainFloorPickupAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> VillainFloorPickupAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 6616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6616); }
    }

    /// <summary>
    /// ArrayProperty: PlayerFloorPickupAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> PlayerFloorPickupAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 6632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6632); }
    }

    /// <summary>
    /// NameProperty: DMDAttackFailBarkFlag
    /// </summary>
    public unsafe BmSDK.FName DMDAttackFailBarkFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6648); }
    }

    /// <summary>
    /// NameProperty: DMDAttackSuccessBarkFlag
    /// </summary>
    public unsafe BmSDK.FName DMDAttackSuccessBarkFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6656); }
    }
}
