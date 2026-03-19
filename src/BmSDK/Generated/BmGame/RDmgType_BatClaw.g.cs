#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_BatClaw<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RDmgType_BatClaw : BmSDK.BmGame.RDamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_BatClaw", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_BatClaw() { }

    /// <summary>
    /// Constructs a new RDmgType_BatClaw
    /// </summary>
    public RDmgType_BatClaw(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_BatClaw Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_BatClaw(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bStunOnHit
    /// </summary>
    public unsafe bool bStunOnHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bZapOnHit
    /// </summary>
    public unsafe bool bZapOnHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bLaserOnHit
    /// </summary>
    public unsafe bool bLaserOnHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bForceRagdoll
    /// </summary>
    public unsafe bool bForceRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bForceNoRagdoll
    /// </summary>
    public unsafe bool bForceNoRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bDisableStunStars
    /// </summary>
    public unsafe bool bDisableStunStars
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCanBeBlockedByWeapon
    /// </summary>
    public unsafe bool bCanBeBlockedByWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCanBeBlockedByArmour
    /// </summary>
    public unsafe bool bCanBeBlockedByArmour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bStumblesArmouredThugs
    /// </summary>
    public unsafe bool bStumblesArmouredThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCanAlwaysBeBlockedByWeapon
    /// </summary>
    public unsafe bool bCanAlwaysBeBlockedByWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCanBeRepelled
    /// </summary>
    public unsafe bool bCanBeRepelled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCannotBeUsedIfBlocked
    /// </summary>
    public unsafe bool bCannotBeUsedIfBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bTriggerPlayerDealthReaction
    /// </summary>
    public unsafe bool bTriggerPlayerDealthReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bStopPlayerRunning
    /// </summary>
    public unsafe bool bStopPlayerRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreHitReaction
    /// </summary>
    public unsafe bool bIgnoreHitReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCancelVelocityOnRagdoll
    /// </summary>
    public unsafe bool bCancelVelocityOnRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bInvalidateFlawlessFreeflow
    /// </summary>
    public unsafe bool bInvalidateFlawlessFreeflow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bAwardBasicTakedownOnKO
    /// </summary>
    public unsafe bool bAwardBasicTakedownOnKO
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCanTargetIfTargettedByBatarang
    /// </summary>
    public unsafe bool bCanTargetIfTargettedByBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCheckForMaxVelocityCap
    /// </summary>
    public unsafe bool bCheckForMaxVelocityCap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bSilentDamage
    /// </summary>
    public unsafe bool bSilentDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bRequiresPairedAnim
    /// </summary>
    public unsafe bool bRequiresPairedAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bDisableDetectiveMode
    /// </summary>
    public unsafe bool bDisableDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCanUseCloseTargetCheck
    /// </summary>
    public unsafe bool bCanUseCloseTargetCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bForceFinalBlowCamIfLastCombatant
    /// </summary>
    public unsafe bool bForceFinalBlowCamIfLastCombatant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bKnifeBladeComboAttack
    /// </summary>
    public unsafe bool bKnifeBladeComboAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bNinjaBladeComboAttack
    /// </summary>
    public unsafe bool bNinjaBladeComboAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bDamageMakesAwareOfPlayer
    /// </summary>
    public unsafe bool bDamageMakesAwareOfPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCantIgnoreHitReaction
    /// </summary>
    public unsafe bool bCantIgnoreHitReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bDelayWeaponPickup
    /// </summary>
    public unsafe bool bDelayWeaponPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCauseExplosionVisualDamage
    /// </summary>
    public unsafe bool bCauseExplosionVisualDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreStunTimeMultiplier
    /// </summary>
    public unsafe bool bIgnoreStunTimeMultiplier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bStopSpeechOnRagdoll
    /// </summary>
    public unsafe bool bStopSpeechOnRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bDefuseRiotBombThugs
    /// </summary>
    public unsafe bool bDefuseRiotBombThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bRemoveMedicChargeWhenRagdoll
    /// </summary>
    public unsafe bool bRemoveMedicChargeWhenRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bCanHitLaserGridDuringHitReaction
    /// </summary>
    public unsafe bool bCanHitLaserGridDuringHitReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bForceConstrainRagdollToNavMesh
    /// </summary>
    public unsafe bool bForceConstrainRagdollToNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bApplyRagdollImpulseToAllBones
    /// </summary>
    public unsafe bool bApplyRagdollImpulseToAllBones
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bDestroysWeaponOnDisarm
    /// </summary>
    public unsafe bool bDestroysWeaponOnDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bAwardXP
    /// </summary>
    public unsafe bool bAwardXP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bBreaksGlassFractureWalls
    /// </summary>
    public unsafe bool bBreaksGlassFractureWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bBreaksWoodenFractureWalls
    /// </summary>
    public unsafe bool bBreaksWoodenFractureWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bBreaksBrickFractureWalls
    /// </summary>
    public unsafe bool bBreaksBrickFractureWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bBreaksHeavyFractureWalls
    /// </summary>
    public unsafe bool bBreaksHeavyFractureWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreTankArmour
    /// </summary>
    public unsafe bool bIgnoreTankArmour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bCanRagdollImpactsDoDamage
    /// </summary>
    public unsafe bool bCanRagdollImpactsDoDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bKnockoutIsNoisyTakedown
    /// </summary>
    public unsafe bool bKnockoutIsNoisyTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bDestructibleChunksInheritDamageCauserVelocity
    /// </summary>
    public unsafe bool bDestructibleChunksInheritDamageCauserVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bDestructibleDamageCanBeDeferred
    /// </summary>
    public unsafe bool bDestructibleDamageCanBeDeferred
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// IntProperty: ForceDamageEffectsAmount
    /// </summary>
    public unsafe int ForceDamageEffectsAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// IntProperty: DamageToShield
    /// </summary>
    public unsafe int DamageToShield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// FloatProperty: BatmanDamageScale
    /// </summary>
    public unsafe float BatmanDamageScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// FloatProperty: MaxStrikeDist
    /// </summary>
    public unsafe float MaxStrikeDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// FloatProperty: MaxVenomStrikeDist
    /// </summary>
    public unsafe float MaxVenomStrikeDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// FloatProperty: OverridePlayerHitDelayTime
    /// </summary>
    public unsafe float OverridePlayerHitDelayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ByteProperty: KOGameAction
    /// </summary>
    public unsafe byte KOGameAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ByteProperty: MoveType
    /// </summary>
    public unsafe byte MoveType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 193); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 193); }
    }

    /// <summary>
    /// ByteProperty: RamDamageLevel
    /// </summary>
    public unsafe byte RamDamageLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 194); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 194); }
    }

    /// <summary>
    /// ByteProperty: ArmourType
    /// </summary>
    public unsafe byte ArmourType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 195); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 195); }
    }

    /// <summary>
    /// IntProperty: Priority
    /// </summary>
    public unsafe int Priority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: ShockedVFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShockedVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorPowerMod
    /// </summary>
    public unsafe float WeaponGeneratorPowerMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: NonPlayerVehicleDamageMod
    /// </summary>
    public unsafe int NonPlayerVehicleDamageMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }
}
