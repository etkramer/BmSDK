#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRagdollProcessor<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RRagdollProcessor : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRagdollProcessor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRagdollProcessor() { }

    /// <summary>
    /// Constructs a new RRagdollProcessor
    /// </summary>
    public RRagdollProcessor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRagdollProcessor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRagdollProcessor(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: StunTime
    /// </summary>
    public unsafe float StunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: TotalRagdollTime
    /// </summary>
    public unsafe float TotalRagdollTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// FloatProperty: TurnOffPawnCollisionTimer
    /// </summary>
    public unsafe float TurnOffPawnCollisionTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bGetUpWhenHitFloor
    /// </summary>
    public unsafe bool bGetUpWhenHitFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bPlayedEmote
    /// </summary>
    public unsafe bool bPlayedEmote
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bKillWhenFinished
    /// </summary>
    public unsafe bool bKillWhenFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bHitWall
    /// </summary>
    public unsafe bool bHitWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShouldPlayHitWallImpactSFX
    /// </summary>
    public unsafe bool bShouldPlayHitWallImpactSFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bDamagedTarget
    /// </summary>
    public unsafe bool bDamagedTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bTickMe
    /// </summary>
    public unsafe bool bTickMe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bFrozen
    /// </summary>
    public unsafe bool bFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bFullMotorWeightWhenHitWall
    /// </summary>
    public unsafe bool bFullMotorWeightWhenHitWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bForceHitWallNextImpact
    /// </summary>
    public unsafe bool bForceHitWallNextImpact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bFacingUp
    /// </summary>
    public unsafe bool bFacingUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bRevertTempPhysicsWalkingOnExit
    /// </summary>
    public unsafe bool bRevertTempPhysicsWalkingOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bTempDeactivated
    /// </summary>
    public unsafe bool bTempDeactivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: WritheDmgInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RRagdollProcessor.HitPawns WritheDmgInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRagdollProcessor.HitPawns>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// NameProperty: Writhe_HitWorldAnimName
    /// </summary>
    public unsafe BmSDK.FName Writhe_HitWorldAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// FloatProperty: ARFMulti
    /// </summary>
    public unsafe float ARFMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: RandomARFTime
    /// </summary>
    public unsafe float RandomARFTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: RandomARFPower
    /// </summary>
    public unsafe float RandomARFPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ArrayProperty: HitPawns
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> HitPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// FloatProperty: CancelKnockOverPawnsTimer
    /// </summary>
    public unsafe float CancelKnockOverPawnsTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// NameProperty: RagdollStackName
    /// </summary>
    public unsafe BmSDK.FName RagdollStackName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ObjectProperty: HostPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HostPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// FloatProperty: FrozenTimer
    /// </summary>
    public unsafe float FrozenTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: MotorWeight
    /// </summary>
    public unsafe float MotorWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: MotorBlendInTime
    /// </summary>
    public unsafe float MotorBlendInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// FloatProperty: StartMotorTimer
    /// </summary>
    public unsafe float StartMotorTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// FloatProperty: ForceHitWallNextImpactTimer
    /// </summary>
    public unsafe float ForceHitWallNextImpactTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// FloatProperty: ForceHitWallTimer
    /// </summary>
    public unsafe float ForceHitWallTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ArrayProperty: DefaultWritheDescriptions
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT DefaultWritheDescriptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// StructProperty: CurrWrithePhase
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrWrithePhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// StructProperty: HitWallWrithePhase
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HitWallWrithePhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// FloatProperty: FacingOtherDirTimer
    /// </summary>
    public unsafe float FacingOtherDirTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// FloatProperty: UnFreezeTime
    /// </summary>
    public unsafe float UnFreezeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ByteProperty: CurrState
    /// </summary>
    public unsafe byte CurrState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }
}
