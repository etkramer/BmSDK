#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnCombat<br/>
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
    public unsafe System.Numerics.Vector3 DebugOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2660); }
    }

    /// <summary>
    /// ObjectProperty: CombatManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager CombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// ObjectProperty: CombatMove
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove CombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// ObjectProperty: CombatPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatPoint CombatPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatPoint>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// ObjectProperty: RemovingCombatMove
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove RemovingCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// ObjectProperty: DamageProxy
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatDamageProxy DamageProxy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatDamageProxy>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// ObjectProperty: DamageProxy2
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatDamageProxy DamageProxy2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatDamageProxy>(Ptr + 2712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2712); }
    }

    /// <summary>
    /// ObjectProperty: CollisionProxy
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatCollisionProxy CollisionProxy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatCollisionProxy>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// ObjectProperty: CannotBeTargettedByPlayer
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController CannotBeTargettedByPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 2728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }
    }

    /// <summary>
    /// ObjectProperty: FocusAura
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant FocusAura
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// ObjectProperty: RagdollProcessor
    /// </summary>
    public unsafe BmSDK.BmGame.RRagdollProcessor RagdollProcessor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRagdollProcessor>(Ptr + 2744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2744); }
    }

    /// <summary>
    /// ObjectProperty: CurrentPylon
    /// </summary>
    public unsafe BmSDK.Engine.Pylon CurrentPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// ObjectProperty: AudioCombatantSwitch
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName AudioCombatantSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveInstance CurrentSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveInstance>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// ObjectProperty: PunchedInFaceSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PunchedInFaceSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2776); }
    }

    /// <summary>
    /// ObjectProperty: KickedInStomachSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent KickedInStomachSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }

    /// <summary>
    /// ObjectProperty: BattleModeViewMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface BattleModeViewMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2792); }
    }

    /// <summary>
    /// ComponentProperty: BatmobileViewSecondaryMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BatmobileViewSecondaryMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 2800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2800); }
    }

    /// <summary>
    /// ComponentProperty: BatmobileViewHeadMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BatmobileViewHeadMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 2808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2808); }
    }

    /// <summary>
    /// ComponentProperty: BatmobileThreatComp
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleThreatComponent BatmobileThreatComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleThreatComponent>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// ClassProperty: OverrideUnarmedAttackClass
    /// </summary>
    public unsafe BmSDK.Class OverrideUnarmedAttackClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }
    }

    /// <summary>
    /// ClassProperty: TargettedDamageType
    /// </summary>
    public unsafe BmSDK.Class TargettedDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2832); }
    }

    /// <summary>
    /// ClassProperty: CombatRedirectMoveClass
    /// </summary>
    public unsafe BmSDK.Class CombatRedirectMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }

    /// <summary>
    /// BoolProperty: bRequires2DamageProxies
    /// </summary>
    public unsafe bool bRequires2DamageProxies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bIsValidCombatant
    /// </summary>
    public unsafe bool bIsValidCombatant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bCanBeHitInCombat
    /// </summary>
    public unsafe bool bCanBeHitInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bHostile
    /// </summary>
    public unsafe bool bHostile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bCanBeTakenDown
    /// </summary>
    public unsafe bool bCanBeTakenDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bCanBeThrown
    /// </summary>
    public unsafe bool bCanBeThrown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bCanBeTakenDownOnFloor
    /// </summary>
    public unsafe bool bCanBeTakenDownOnFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysRagdollWhenHit
    /// </summary>
    public unsafe bool bAlwaysRagdollWhenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bNeverRagdollWhenHit
    /// </summary>
    public unsafe bool bNeverRagdollWhenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bQuickKOIfLastEnemy
    /// </summary>
    public unsafe bool bQuickKOIfLastEnemy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysHitTarget
    /// </summary>
    public unsafe bool bAlwaysHitTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bForceAllowToHitThugs
    /// </summary>
    public unsafe bool bForceAllowToHitThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bForceHeavyCounter
    /// </summary>
    public unsafe bool bForceHeavyCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bKnockbackAttackingThugs
    /// </summary>
    public unsafe bool bKnockbackAttackingThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bFullOnAttack
    /// </summary>
    public unsafe bool bFullOnAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bProcessedDiedNotification
    /// </summary>
    public unsafe bool bProcessedDiedNotification
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bLastTarget
    /// </summary>
    public unsafe bool bLastTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bCanWritheWhenRagdoll
    /// </summary>
    public unsafe bool bCanWritheWhenRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bIsBreakable
    /// </summary>
    public unsafe bool bIsBreakable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bIsCurrentCombatant
    /// </summary>
    public unsafe bool bIsCurrentCombatant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bDoNotRemove
    /// </summary>
    public unsafe bool bDoNotRemove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreBlockingPlayer
    /// </summary>
    public unsafe bool bIgnoreBlockingPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: StandingOffEdge
    /// </summary>
    public unsafe bool StandingOffEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bInInterrogation
    /// </summary>
    public unsafe bool bInInterrogation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bPreserveSpecialMoveOnSwitch
    /// </summary>
    public unsafe bool bPreserveSpecialMoveOnSwitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bRiddlerPlayerSwitch
    /// </summary>
    public unsafe bool bRiddlerPlayerSwitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bNeedsToSpawnCombatHitProxies
    /// </summary>
    public unsafe bool bNeedsToSpawnCombatHitProxies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bNeedsToSetValidCombatant
    /// </summary>
    public unsafe bool bNeedsToSetValidCombatant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bNeedsToSpawnRagdollProcessor
    /// </summary>
    public unsafe bool bNeedsToSpawnRagdollProcessor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
    }

    /// <summary>
    /// BoolProperty: bBlockBatmobileFire
    /// </summary>
    public unsafe bool bBlockBatmobileFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2848); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2848); }
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
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> TargettedByPawnList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 2884); }
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
    public unsafe System.Numerics.Vector3 MovementDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2932); }
    }

    /// <summary>
    /// StructProperty: OverridableTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId OverridableTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 2944); }
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
    public unsafe System.Numerics.Vector3 StandingOffEdgeDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2956); }
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
    public unsafe BmSDK.BmGame.RPawnCombat.ECombatPawnType CombatPawnType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.ECombatPawnType>(Ptr + 2972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2972); }
    }

    /// <summary>
    /// ByteProperty: SummaryScreenCombatPawnType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat.ECombatPawnType SummaryScreenCombatPawnType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.ECombatPawnType>(Ptr + 2973); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2973); }
    }
}
