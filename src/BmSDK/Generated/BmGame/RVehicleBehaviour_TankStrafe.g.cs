#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_TankStrafe<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_TankStrafe : BmSDK.BmGame.RVehicleBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_TankStrafe", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_TankStrafe() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_TankStrafe
    /// </summary>
    public RVehicleBehaviour_TankStrafe(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_TankStrafe Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_TankStrafe(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TargetActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ObjectProperty: MyGuardPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyGuardPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ObjectProperty: CombatManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// IntProperty: ChaseEndLink
    /// </summary>
    public unsafe int ChaseEndLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: ChaseRePlanDelay
    /// </summary>
    public unsafe float ChaseRePlanDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// IntProperty: StartWanderPoint
    /// </summary>
    public unsafe int StartWanderPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// IntProperty: EndWanderPoint
    /// </summary>
    public unsafe int EndWanderPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveThrottleScale
    /// </summary>
    public unsafe float SelfDriveThrottleScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: OriginalSelfDriveExtraWidth
    /// </summary>
    public unsafe float OriginalSelfDriveExtraWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: OriginalObstacleAheadStopThreshold
    /// </summary>
    public unsafe float OriginalObstacleAheadStopThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// FloatProperty: FullThrottleRange
    /// </summary>
    public unsafe float FullThrottleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: ChaseMinRange
    /// </summary>
    public unsafe float ChaseMinRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bAllOutAttack
    /// </summary>
    public unsafe bool bAllOutAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: IsTargetOnMainRoad
    /// </summary>
    public unsafe bool IsTargetOnMainRoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: ReachedDeadEnd
    /// </summary>
    public unsafe bool ReachedDeadEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: ChosenAttackLocation
    /// </summary>
    public unsafe bool ChosenAttackLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: DisableDeathBarks
    /// </summary>
    public unsafe bool DisableDeathBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: PointBlank
    /// </summary>
    public unsafe bool PointBlank
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: ReachedDest
    /// </summary>
    public unsafe bool ReachedDest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCanAttack
    /// </summary>
    public unsafe bool bCanAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bMovingToFlank
    /// </summary>
    public unsafe bool bMovingToFlank
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bDoneFlankCheck
    /// </summary>
    public unsafe bool bDoneFlankCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bHasValidRouteToTarget
    /// </summary>
    public unsafe bool bHasValidRouteToTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bDebugTankSphereRouting
    /// </summary>
    public unsafe bool bDebugTankSphereRouting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: AttackLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AttackLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StructProperty: LastAttackLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastAttackLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// FloatProperty: TimeCanSeeTarget
    /// </summary>
    public unsafe float TimeCanSeeTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: ChasingToUnknownDestTimer
    /// </summary>
    public unsafe float ChasingToUnknownDestTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ByteProperty: CurrentPhase
    /// </summary>
    public unsafe byte CurrentPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }
}
