#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMCombatThrownObject_RocketLauncher<br/>
/// (flags = 0)
/// </summary>
public partial class RBMCombatThrownObject_RocketLauncher : BmSDK.BmGame.RBMCombatThrownObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMCombatThrownObject_RocketLauncher", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMCombatThrownObject_RocketLauncher() { }

    /// <summary>
    /// Constructs a new RBMCombatThrownObject_RocketLauncher
    /// </summary>
    public RBMCombatThrownObject_RocketLauncher(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMCombatThrownObject_RocketLauncher Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCombatThrownObject_RocketLauncher(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_RocketLauncher>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_RocketLauncher>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_RocketLauncher>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_RocketLauncher>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_RocketLauncher>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_RocketLauncher>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_RocketLauncher>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ByteProperty: CounterType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject.EThrownWeaonCounterType CounterType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject.EThrownWeaonCounterType>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ByteProperty: PickupWeaponType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.PickupWeaponType PickupWeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.PickupWeaponType>(Ptr + 709); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 709); }
    }

    /// <summary>
    /// ByteProperty: StrikeWeaponType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeWeaponGrabbed StrikeWeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeWeaponGrabbed>(Ptr + 710); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 710); }
    }

    /// <summary>
    /// BoolProperty: bCanHitPawn
    /// </summary>
    public unsafe bool bCanHitPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bCanBePickedUp
    /// </summary>
    public unsafe bool bCanBePickedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bBeingHeld
    /// </summary>
    public unsafe bool bBeingHeld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bPlayedDropSound
    /// </summary>
    public unsafe bool bPlayedDropSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bDisableForPlayerPickup
    /// </summary>
    public unsafe bool bDisableForPlayerPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bCanBePickedUpInCombat
    /// </summary>
    public unsafe bool bCanBePickedUpInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bCanBePickedUpWhileTaunting
    /// </summary>
    public unsafe bool bCanBePickedUpWhileTaunting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bDestroyWhenOffscreen
    /// </summary>
    public unsafe bool bDestroyWhenOffscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bReactsToMagneticBlast
    /// </summary>
    public unsafe bool bReactsToMagneticBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bDisarmAndDestroyed
    /// </summary>
    public unsafe bool bDisarmAndDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bThrown
    /// </summary>
    public unsafe bool bThrown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bTriggerProjectileCounter
    /// </summary>
    public unsafe bool bTriggerProjectileCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bUsedByPlayer
    /// </summary>
    public unsafe bool bUsedByPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bIncreasedCombatPower
    /// </summary>
    public unsafe bool bIncreasedCombatPower
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bTurnOffRigidBodyCollisionOnHit
    /// </summary>
    public unsafe bool bTurnOffRigidBodyCollisionOnHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bCanBeDestroyedWhenOffScreenAndNotInCombat
    /// </summary>
    public unsafe bool bCanBeDestroyedWhenOffScreenAndNotInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bNotInCombatWhenOutOfRange
    /// </summary>
    public unsafe bool bNotInCombatWhenOutOfRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bThrowCounterAlwaysHitsTarget
    /// </summary>
    public unsafe bool bThrowCounterAlwaysHitsTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bThrowCounterAtHead
    /// </summary>
    public unsafe bool bThrowCounterAtHead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bRighthandPickup
    /// </summary>
    public unsafe bool bRighthandPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bPickUpOn
    /// </summary>
    public unsafe bool bPickUpOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bWeaponJammed
    /// </summary>
    public unsafe bool bWeaponJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bWeaponDoubleJammed
    /// </summary>
    public unsafe bool bWeaponDoubleJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bScatterWeaponPartsOnExplosion
    /// </summary>
    public unsafe bool bScatterWeaponPartsOnExplosion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bAddRandomRotationToParts
    /// </summary>
    public unsafe bool bAddRandomRotationToParts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bFirstCollision
    /// </summary>
    public unsafe bool bFirstCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bWeaponSnatchAuraAttached
    /// </summary>
    public unsafe bool bWeaponSnatchAuraAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bCanBeUsedAgainstBatmobile
    /// </summary>
    public unsafe bool bCanBeUsedAgainstBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bCheckLevelDPG
    /// </summary>
    public unsafe bool bCheckLevelDPG
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: CanOnlyBePickedUpBy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat CanOnlyBePickedUpBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: ThrownBy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat ThrownBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: OnlyHitThisPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat OnlyHitThisPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: ImpactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: BeingPickedUpBy
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI BeingPickedUpBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: SmashFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SmashFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: SmashFX2
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SmashFX2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: SegmentMaterialOverride
    /// </summary>
    public unsafe BmSDK.Engine.Material SegmentMaterialOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: ForceTargetPlayer
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController ForceTargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: MagBlastPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer MagBlastPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainCounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerCounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: CounterAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: ShatterFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ShatterFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: MultiplayerAuraMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MultiplayerAuraMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ComponentProperty: MultiplayerAuraMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent MultiplayerAuraMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ClassProperty: CounterClass
    /// </summary>
    public unsafe BmSDK.Class CounterClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ComponentProperty: MeshFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MeshFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ClassProperty: WeaponType
    /// </summary>
    public unsafe BmSDK.Class WeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ClassProperty: DamageType
    /// </summary>
    public unsafe BmSDK.Class DamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// IntProperty: DestroyFrameCount
    /// </summary>
    public unsafe int DestroyFrameCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: HeldByPlayer_Translation
    /// </summary>
    public unsafe System.Numerics.Vector3 HeldByPlayer_Translation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// StructProperty: HeldByPlayer_Rotation
    /// </summary>
    public unsafe BmSDK.Rotator HeldByPlayer_Rotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// IntProperty: PickupOnFails
    /// </summary>
    public unsafe int PickupOnFails
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// FloatProperty: UpForce
    /// </summary>
    public unsafe float UpForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: SmashPartsMaxRandRotationSpeed
    /// </summary>
    public unsafe float SmashPartsMaxRandRotationSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: ImpactSmashChance
    /// </summary>
    public unsafe float ImpactSmashChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// IntProperty: PickupPriority
    /// </summary>
    public unsafe int PickupPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// StructProperty: MagneticForceLastFrame
    /// </summary>
    public unsafe System.Numerics.Vector3 MagneticForceLastFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ArrayProperty: SegmentMeshs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.StaticMesh> SegmentMeshs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.StaticMesh>>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// NameProperty: PhysicsBoneName
    /// </summary>
    public unsafe BmSDK.FName PhysicsBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// StructProperty: ThrowCollisionExtents
    /// </summary>
    public unsafe System.Numerics.Vector3 ThrowCollisionExtents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StructProperty: ThrowCollisionOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 ThrowCollisionOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: IgnoreCollisionTimer
    /// </summary>
    public unsafe float IgnoreCollisionTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// StructProperty: BasePickupLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 BasePickupLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// StructProperty: PickupLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 PickupLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// StructProperty: PrevLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 PrevLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// StructProperty: PrevRotation
    /// </summary>
    public unsafe BmSDK.Rotator PrevRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: DropVelMultiplier
    /// </summary>
    public unsafe float DropVelMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: DropAngVelMultiplier
    /// </summary>
    public unsafe float DropAngVelMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// NameProperty: CatchAnimName
    /// </summary>
    public unsafe BmSDK.FName CatchAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// NameProperty: ThrowAnimName
    /// </summary>
    public unsafe BmSDK.FName ThrowAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// NameProperty: DeflectAnimName
    /// </summary>
    public unsafe BmSDK.FName DeflectAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ArrayProperty: DetachableParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject> DetachableParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject>>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// NameProperty: AttachBoneName
    /// </summary>
    public unsafe BmSDK.FName AttachBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// IntProperty: NumDetached
    /// </summary>
    public unsafe int NumDetached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// StrProperty: sDisruptorHUDDescription
    /// </summary>
    public unsafe BmSDK.FString sDisruptorHUDDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalBarksets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkSet> AdditionalBarksets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkSet>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: MagnetStickTimeMod
    /// </summary>
    public unsafe float MagnetStickTimeMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// FloatProperty: LastPickupFailedTime
    /// </summary>
    public unsafe float LastPickupFailedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// ArrayProperty: PreviousAllComponentsList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PreviousAllComponentsList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// FloatProperty: TurnOnPickupTime
    /// </summary>
    public unsafe float TurnOnPickupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// IntProperty: NumTimesUsedByPlayer
    /// </summary>
    public unsafe int NumTimesUsedByPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// Enum: EThrownWeaonCounterType
    /// </summary>
    public enum EThrownWeaonCounterType
    {
        TOCT_None = 0,
        TOCT_Catch = 1,
        TOCT_Deflect = 2,
        TOCT_MAX = 3,
    }
}
