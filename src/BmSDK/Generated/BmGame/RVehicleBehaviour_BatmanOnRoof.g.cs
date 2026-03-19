#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_BatmanOnRoof<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_BatmanOnRoof : BmSDK.BmGame.RVehicleBehaviour_RunAway, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_BatmanOnRoof", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_BatmanOnRoof() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_BatmanOnRoof
    /// </summary>
    public RVehicleBehaviour_BatmanOnRoof(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_BatmanOnRoof Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_BatmanOnRoof(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: StartWanderPoint
    /// </summary>
    public unsafe int StartWanderPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// IntProperty: EndWanderPoint
    /// </summary>
    public unsafe int EndWanderPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// StructProperty: CheatVsDistCurveNoEscorts
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_RunAway.CheatVsDistCurveWithEscorts CheatVsDistCurveNoEscorts_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_RunAway.CheatVsDistCurveWithEscorts>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
    /// <summary>
    /// StructProperty: CheatVsDistCurveNoEscorts
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_RunAway.CheatVsDistCurveWithEscorts CheatVsDistCurveNoEscorts_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_RunAway.CheatVsDistCurveWithEscorts>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }
    /// <summary>
    /// StructProperty: CheatVsDistCurveNoEscorts
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_RunAway.CheatVsDistCurveWithEscorts CheatVsDistCurveNoEscorts_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_RunAway.CheatVsDistCurveWithEscorts>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }
    /// <summary>
    /// StructProperty: CheatVsDistCurveNoEscorts
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_RunAway.CheatVsDistCurveWithEscorts CheatVsDistCurveNoEscorts_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_RunAway.CheatVsDistCurveWithEscorts>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }
    /// <summary>
    /// StructProperty: CheatVsDistCurveNoEscorts
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_RunAway.CheatVsDistCurveWithEscorts CheatVsDistCurveNoEscorts_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_RunAway.CheatVsDistCurveWithEscorts>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }
    /// <summary>
    /// StructProperty: CheatVsDistCurveNoEscorts
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_RunAway.CheatVsDistCurveWithEscorts CheatVsDistCurveNoEscorts_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_RunAway.CheatVsDistCurveWithEscorts>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StructProperty: CheatVsDistCurveWithEscorts
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_RunAway.PreferDirections CheatVsDistCurveWithEscorts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_RunAway.PreferDirections>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ArrayProperty: PreferDirections
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleBehaviour_RunAway.RoadLinkHistory> PreferDirections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleBehaviour_RunAway.RoadLinkHistory>>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: PrevPreferDirection
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PrevPreferDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: GotAwayBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_RunAway.RoadLinkHistory GotAwayBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_RunAway.RoadLinkHistory>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: PrimeRoads
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PrimeRoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: OnInitialRoute
    /// </summary>
    public unsafe bool OnInitialRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: InitialRouteUsed
    /// </summary>
    public unsafe bool InitialRouteUsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: MainRoadsOnly
    /// </summary>
    public unsafe bool MainRoadsOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: DriveOnCorrectSide
    /// </summary>
    public unsafe bool DriveOnCorrectSide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: DriveErratically
    /// </summary>
    public unsafe bool DriveErratically
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: TendToGoStraight
    /// </summary>
    public unsafe bool TendToGoStraight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: TendToGoStraightUphill
    /// </summary>
    public unsafe bool TendToGoStraightUphill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: AutoUpdateDriveSpeed
    /// </summary>
    public unsafe bool AutoUpdateDriveSpeed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: StopForObstacles
    /// </summary>
    public unsafe bool StopForObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: AllowShoot
    /// </summary>
    public unsafe bool AllowShoot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: AvoidObstaclesBetweenLanes
    /// </summary>
    public unsafe bool AvoidObstaclesBetweenLanes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: AutoUpdateSelfDriveLineLimits
    /// </summary>
    public unsafe bool AutoUpdateSelfDriveLineLimits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: HostVehicleDied
    /// </summary>
    public unsafe bool HostVehicleDied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: AlertFollowersWhenSeenBatman
    /// </summary>
    public unsafe bool AlertFollowersWhenSeenBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: bDeleteWhenAwayAndOOS
    /// </summary>
    public unsafe bool bDeleteWhenAwayAndOOS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: bUseFollowersForSpeedFudging
    /// </summary>
    public unsafe bool bUseFollowersForSpeedFudging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: bNoRubberBanding
    /// </summary>
    public unsafe bool bNoRubberBanding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: PassengersExitIfStuckNearBatmobile
    /// </summary>
    public unsafe bool PassengersExitIfStuckNearBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: PassengersRunIfNearBatmobileAfterExit
    /// </summary>
    public unsafe bool PassengersRunIfNearBatmobileAfterExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: RunAwayFromBatman
    /// </summary>
    public unsafe bool RunAwayFromBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: StopRunAwayFromBatmanWhenHesTailing
    /// </summary>
    public unsafe bool StopRunAwayFromBatmanWhenHesTailing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: bKeepOnRoadWhenDead
    /// </summary>
    public unsafe bool bKeepOnRoadWhenDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: PushBumpedCars
    /// </summary>
    public unsafe bool PushBumpedCars
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: PushBumpedBatmobile
    /// </summary>
    public unsafe bool PushBumpedBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: ChainFromPrevious
    /// </summary>
    public unsafe bool ChainFromPrevious
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: DoingUturnReverse
    /// </summary>
    public unsafe bool DoingUturnReverse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: AllowTakeoffWheelspin
    /// </summary>
    public unsafe bool AllowTakeoffWheelspin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: CanReverseFormation
    /// </summary>
    public unsafe bool CanReverseFormation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: SpeedFactor
    /// </summary>
    public unsafe float SpeedFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: SpeedFactorOffScreen
    /// </summary>
    public unsafe float SpeedFactorOffScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: GotAwayDistance
    /// </summary>
    public unsafe float GotAwayDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: GotAwayTimeLimit
    /// </summary>
    public unsafe float GotAwayTimeLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: GotAwayTime
    /// </summary>
    public unsafe float GotAwayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: BatmanTailingDuration
    /// </summary>
    public unsafe float BatmanTailingDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: BatmanTailingDistance
    /// </summary>
    public unsafe float BatmanTailingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// FloatProperty: BatmanTailingTime
    /// </summary>
    public unsafe float BatmanTailingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// IntProperty: MaxEscortRespawns
    /// </summary>
    public unsafe int MaxEscortRespawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// FloatProperty: MaxThrottleForSharpTurns
    /// </summary>
    public unsafe float MaxThrottleForSharpTurns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: MaxWaitForObstacleTime
    /// </summary>
    public unsafe float MaxWaitForObstacleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: MaxTurnAngleDegrees
    /// </summary>
    public unsafe float MaxTurnAngleDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// FloatProperty: HostVehicleDeadDrivingForce
    /// </summary>
    public unsafe float HostVehicleDeadDrivingForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// FloatProperty: SeeBatmanBarkDistance
    /// </summary>
    public unsafe float SeeBatmanBarkDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: TimeHidden
    /// </summary>
    public unsafe float TimeHidden
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ByteProperty: BehaviourWhenEscortsGone
    /// </summary>
    public unsafe byte BehaviourWhenEscortsGone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ByteProperty: ChaseDifficulty
    /// </summary>
    public unsafe byte ChaseDifficulty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 861); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 861); }
    }

    /// <summary>
    /// FloatProperty: StuckNearBatmobileDist
    /// </summary>
    public unsafe float StuckNearBatmobileDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// FloatProperty: AvoidBatmobileLocationRange
    /// </summary>
    public unsafe float AvoidBatmobileLocationRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// FloatProperty: AvoidBatmanLocationRange
    /// </summary>
    public unsafe float AvoidBatmanLocationRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: DistanceToPlanAhead
    /// </summary>
    public unsafe float DistanceToPlanAhead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: CurrentChaseDist
    /// </summary>
    public unsafe float CurrentChaseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// IntProperty: PrimedForLeaveFormationLink
    /// </summary>
    public unsafe int PrimedForLeaveFormationLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ArrayProperty: RoadLinkHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SequenceAction.Targets>>> RoadLinkHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SequenceAction.Targets>>>>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// IntProperty: RoadLinkHistoryMaxLength
    /// </summary>
    public unsafe int RoadLinkHistoryMaxLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// IntProperty: InJunction
    /// </summary>
    public unsafe int InJunction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// StructProperty: InJunctionExitDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InJunctionExitDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ArrayProperty: PrimeRoute
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SequenceAction.Targets>> PrimeRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SequenceAction.Targets>>>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }
}
