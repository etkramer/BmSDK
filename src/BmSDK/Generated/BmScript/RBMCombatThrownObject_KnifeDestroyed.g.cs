#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMCombatThrownObject_KnifeDestroyed<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMCombatThrownObject_KnifeDestroyed : BmSDK.BmGame.RBMCombatThrownObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMCombatThrownObject_KnifeDestroyed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMCombatThrownObject_KnifeDestroyed() { }

    /// <summary>
    /// Constructs a new RBMCombatThrownObject_KnifeDestroyed
    /// </summary>
    public RBMCombatThrownObject_KnifeDestroyed(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMCombatThrownObject_KnifeDestroyed Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCombatThrownObject_KnifeDestroyed(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_KnifeDestroyed>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_KnifeDestroyed>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_KnifeDestroyed>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_KnifeDestroyed>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_KnifeDestroyed>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_KnifeDestroyed>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_KnifeDestroyed>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ByteProperty: CounterType
    /// </summary>
    public unsafe byte CounterType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ByteProperty: PickupWeaponType
    /// </summary>
    public unsafe byte PickupWeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 709); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 709); }
    }

    /// <summary>
    /// ByteProperty: StrikeWeaponType
    /// </summary>
    public unsafe byte StrikeWeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 710); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 710); }
    }

    /// <summary>
    /// BoolProperty: bCanHitPawn
    /// </summary>
    public unsafe bool bCanHitPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bCanBePickedUp
    /// </summary>
    public unsafe bool bCanBePickedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bBeingHeld
    /// </summary>
    public unsafe bool bBeingHeld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bPlayedDropSound
    /// </summary>
    public unsafe bool bPlayedDropSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bDisableForPlayerPickup
    /// </summary>
    public unsafe bool bDisableForPlayerPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bCanBePickedUpInCombat
    /// </summary>
    public unsafe bool bCanBePickedUpInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bCanBePickedUpWhileTaunting
    /// </summary>
    public unsafe bool bCanBePickedUpWhileTaunting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bDestroyWhenOffscreen
    /// </summary>
    public unsafe bool bDestroyWhenOffscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bReactsToMagneticBlast
    /// </summary>
    public unsafe bool bReactsToMagneticBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bDisarmAndDestroyed
    /// </summary>
    public unsafe bool bDisarmAndDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bThrown
    /// </summary>
    public unsafe bool bThrown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bTriggerProjectileCounter
    /// </summary>
    public unsafe bool bTriggerProjectileCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bUsedByPlayer
    /// </summary>
    public unsafe bool bUsedByPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bIncreasedCombatPower
    /// </summary>
    public unsafe bool bIncreasedCombatPower
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bTurnOffRigidBodyCollisionOnHit
    /// </summary>
    public unsafe bool bTurnOffRigidBodyCollisionOnHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bCanBeDestroyedWhenOffScreenAndNotInCombat
    /// </summary>
    public unsafe bool bCanBeDestroyedWhenOffScreenAndNotInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bNotInCombatWhenOutOfRange
    /// </summary>
    public unsafe bool bNotInCombatWhenOutOfRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bThrowCounterAlwaysHitsTarget
    /// </summary>
    public unsafe bool bThrowCounterAlwaysHitsTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bThrowCounterAtHead
    /// </summary>
    public unsafe bool bThrowCounterAtHead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bRighthandPickup
    /// </summary>
    public unsafe bool bRighthandPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bPickUpOn
    /// </summary>
    public unsafe bool bPickUpOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bWeaponJammed
    /// </summary>
    public unsafe bool bWeaponJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bWeaponDoubleJammed
    /// </summary>
    public unsafe bool bWeaponDoubleJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bScatterWeaponPartsOnExplosion
    /// </summary>
    public unsafe bool bScatterWeaponPartsOnExplosion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bAddRandomRotationToParts
    /// </summary>
    public unsafe bool bAddRandomRotationToParts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bFirstCollision
    /// </summary>
    public unsafe bool bFirstCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bWeaponSnatchAuraAttached
    /// </summary>
    public unsafe bool bWeaponSnatchAuraAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bCanBeUsedAgainstBatmobile
    /// </summary>
    public unsafe bool bCanBeUsedAgainstBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bCheckLevelDPG
    /// </summary>
    public unsafe bool bCheckLevelDPG
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: CanOnlyBePickedUpBy
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CanOnlyBePickedUpBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: ThrownBy
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThrownBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: OnlyHitThisPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OnlyHitThisPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: ImpactEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImpactEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: BeingPickedUpBy
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BeingPickedUpBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: SmashFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SmashFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: SmashFX2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SmashFX2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: SegmentMaterialOverride
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SegmentMaterialOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: ForceTargetPlayer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ForceTargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: MagBlastPlayer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MagBlastPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorTakedownAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorTakedownAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainCounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerCounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: CounterAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: ShatterFx
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShatterFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: MultiplayerAuraMIC
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject.SegmentMeshs MultiplayerAuraMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject.SegmentMeshs>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ComponentProperty: MultiplayerAuraMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MultiplayerAuraMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ClassProperty: CounterClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CounterClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ComponentProperty: MeshFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MeshFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ClassProperty: WeaponType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ClassProperty: DamageType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 892); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HeldByPlayer_Translation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// StructProperty: HeldByPlayer_Rotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HeldByPlayer_Rotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 916); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MagneticForceLastFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ArrayProperty: SegmentMeshs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> SegmentMeshs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 960); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowCollisionExtents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StructProperty: ThrowCollisionOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowCollisionOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 996); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BasePickupLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// StructProperty: PickupLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PickupLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// StructProperty: PrevLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PrevLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// StructProperty: PrevRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PrevRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1048); }
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
    public unsafe BmSDK.TArray<BmSDK.FString> DetachableParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1092); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> AdditionalBarksets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 1136); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> PreviousAllComponentsList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 1160); }
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
