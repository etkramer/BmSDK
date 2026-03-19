#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnCombat<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnCombat : BmSDK.BmGame.RPawnCharacter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnCombat() { }

    /// <summary>
    /// Constructs a new RPawnCombat
    /// </summary>
    public RPawnCombat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnCombat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnCombat(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnCombat>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCombat>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnCombat>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCombat>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCombat>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnCombat>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCombat>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: DebugOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2660); }
    }

    /// <summary>
    /// ObjectProperty: CombatManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// ObjectProperty: CombatMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// ObjectProperty: CombatPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// ObjectProperty: RemovingCombatMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RemovingCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// ObjectProperty: DamageProxy
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DamageProxy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// ObjectProperty: DamageProxy2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DamageProxy2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2712); }
    }

    /// <summary>
    /// ObjectProperty: CollisionProxy
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CollisionProxy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// ObjectProperty: CannotBeTargettedByPlayer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CannotBeTargettedByPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }
    }

    /// <summary>
    /// ObjectProperty: FocusAura
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FocusAura
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// ObjectProperty: RagdollProcessor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RagdollProcessor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2744); }
    }

    /// <summary>
    /// ObjectProperty: CurrentPylon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// ObjectProperty: AudioCombatantSwitch
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AudioCombatantSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSpecialMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// ObjectProperty: PunchedInFaceSFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PunchedInFaceSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2776); }
    }

    /// <summary>
    /// ObjectProperty: KickedInStomachSFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KickedInStomachSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }

    /// <summary>
    /// ObjectProperty: BattleModeViewMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BattleModeViewMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2792); }
    }

    /// <summary>
    /// ComponentProperty: BatmobileViewSecondaryMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmobileViewSecondaryMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2800); }
    }

    /// <summary>
    /// ComponentProperty: BatmobileViewHeadMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmobileViewHeadMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2808); }
    }

    /// <summary>
    /// ComponentProperty: BatmobileThreatComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmobileThreatComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// ClassProperty: OverrideUnarmedAttackClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverrideUnarmedAttackClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }
    }

    /// <summary>
    /// ClassProperty: TargettedDamageType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargettedDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2832); }
    }

    /// <summary>
    /// ClassProperty: CombatRedirectMoveClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatRedirectMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }

    /// <summary>
    /// BoolProperty: bRequires2DamageProxies
    /// </summary>
    public unsafe bool bRequires2DamageProxies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bIsValidCombatant
    /// </summary>
    public unsafe bool bIsValidCombatant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bCanBeHitInCombat
    /// </summary>
    public unsafe bool bCanBeHitInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bHostile
    /// </summary>
    public unsafe bool bHostile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bCanBeTakenDown
    /// </summary>
    public unsafe bool bCanBeTakenDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bCanBeThrown
    /// </summary>
    public unsafe bool bCanBeThrown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bCanBeTakenDownOnFloor
    /// </summary>
    public unsafe bool bCanBeTakenDownOnFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysRagdollWhenHit
    /// </summary>
    public unsafe bool bAlwaysRagdollWhenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bNeverRagdollWhenHit
    /// </summary>
    public unsafe bool bNeverRagdollWhenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bQuickKOIfLastEnemy
    /// </summary>
    public unsafe bool bQuickKOIfLastEnemy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysHitTarget
    /// </summary>
    public unsafe bool bAlwaysHitTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bForceAllowToHitThugs
    /// </summary>
    public unsafe bool bForceAllowToHitThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bForceHeavyCounter
    /// </summary>
    public unsafe bool bForceHeavyCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bKnockbackAttackingThugs
    /// </summary>
    public unsafe bool bKnockbackAttackingThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bFullOnAttack
    /// </summary>
    public unsafe bool bFullOnAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bProcessedDiedNotification
    /// </summary>
    public unsafe bool bProcessedDiedNotification
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bLastTarget
    /// </summary>
    public unsafe bool bLastTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bCanWritheWhenRagdoll
    /// </summary>
    public unsafe bool bCanWritheWhenRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bIsBreakable
    /// </summary>
    public unsafe bool bIsBreakable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bIsCurrentCombatant
    /// </summary>
    public unsafe bool bIsCurrentCombatant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bDoNotRemove
    /// </summary>
    public unsafe bool bDoNotRemove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreBlockingPlayer
    /// </summary>
    public unsafe bool bIgnoreBlockingPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: StandingOffEdge
    /// </summary>
    public unsafe bool StandingOffEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bInInterrogation
    /// </summary>
    public unsafe bool bInInterrogation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bPreserveSpecialMoveOnSwitch
    /// </summary>
    public unsafe bool bPreserveSpecialMoveOnSwitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bRiddlerPlayerSwitch
    /// </summary>
    public unsafe bool bRiddlerPlayerSwitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bNeedsToSpawnCombatHitProxies
    /// </summary>
    public unsafe bool bNeedsToSpawnCombatHitProxies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bNeedsToSetValidCombatant
    /// </summary>
    public unsafe bool bNeedsToSetValidCombatant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bNeedsToSpawnRagdollProcessor
    /// </summary>
    public unsafe bool bNeedsToSpawnRagdollProcessor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bBlockBatmobileFire
    /// </summary>
    public unsafe bool bBlockBatmobileFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// FloatProperty: CollisionProxyRadius
    /// </summary>
    public unsafe float CollisionProxyRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2852); }
    }

    /// <summary>
    /// FloatProperty: CollisionProxyHeight
    /// </summary>
    public unsafe float CollisionProxyHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2856); }
    }

    /// <summary>
    /// NameProperty: NotHostileReason
    /// </summary>
    public unsafe BmSDK.FName NotHostileReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2860); }
    }

    /// <summary>
    /// StrProperty: FullOnAttackSetterString
    /// </summary>
    public unsafe BmSDK.FString FullOnAttackSetterString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2868); }
    }

    /// <summary>
    /// ArrayProperty: TargettedByPawnList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> TargettedByPawnList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2884); }
    }

    /// <summary>
    /// FloatProperty: TargettedTime
    /// </summary>
    public unsafe float TargettedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2900); }
    }

    /// <summary>
    /// IntProperty: TargettedByBatarang
    /// </summary>
    public unsafe int TargettedByBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2904); }
    }

    /// <summary>
    /// StrProperty: CombatantName
    /// </summary>
    public unsafe BmSDK.FString CombatantName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }

    /// <summary>
    /// FloatProperty: LastCurrentCombatantTime
    /// </summary>
    public unsafe float LastCurrentCombatantTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// FloatProperty: RagdollStunTimeMultiplier
    /// </summary>
    public unsafe float RagdollStunTimeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }
    }

    /// <summary>
    /// StructProperty: MovementDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MovementDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2932); }
    }

    /// <summary>
    /// StructProperty: OverridableTransition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OverridableTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

    /// <summary>
    /// FloatProperty: SpecialMoveLeftFootCycleStartTime
    /// </summary>
    public unsafe float SpecialMoveLeftFootCycleStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2948); }
    }

    /// <summary>
    /// FloatProperty: SpecialMoveRightPassingCycleStartTime
    /// </summary>
    public unsafe float SpecialMoveRightPassingCycleStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2952); }
    }

    /// <summary>
    /// StructProperty: StandingOffEdgeDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StandingOffEdgeDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2956); }
    }

    /// <summary>
    /// IntProperty: MaxHealth
    /// </summary>
    public unsafe int MaxHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2968); }
    }

    /// <summary>
    /// ByteProperty: CombatPawnType
    /// </summary>
    public unsafe byte CombatPawnType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2972); }
    }

    /// <summary>
    /// ByteProperty: SummaryScreenCombatPawnType
    /// </summary>
    public unsafe byte SummaryScreenCombatPawnType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2973); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2973); }
    }
}
