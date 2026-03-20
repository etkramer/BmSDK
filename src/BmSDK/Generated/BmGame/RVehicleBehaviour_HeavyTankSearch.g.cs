#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_HeavyTankSearch<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_HeavyTankSearch : BmSDK.BmGame.RVehicleBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_HeavyTankSearch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_HeavyTankSearch() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_HeavyTankSearch
    /// </summary>
    public RVehicleBehaviour_HeavyTankSearch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_HeavyTankSearch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_HeavyTankSearch(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: CurrentPhase
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase CurrentPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ByteProperty: OldPhase
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase OldPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch.ETankSearchPhase>(Ptr + 609); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 609); }
    }

    /// <summary>
    /// BoolProperty: SearchLastKnownPositionByKismet
    /// </summary>
    public unsafe bool SearchLastKnownPositionByKismet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: b360ScansActive
    /// </summary>
    public unsafe bool b360ScansActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: bConstant360Scan
    /// </summary>
    public unsafe bool bConstant360Scan
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: bDrawScanLines
    /// </summary>
    public unsafe bool bDrawScanLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: InstantAttack
    /// </summary>
    public unsafe bool InstantAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: StayStill
    /// </summary>
    public unsafe bool StayStill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: CanSeePlayer
    /// </summary>
    public unsafe bool CanSeePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// BoolProperty: DisableDeathBarks
    /// </summary>
    public unsafe bool DisableDeathBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: ScanAngle
    /// </summary>
    public unsafe float ScanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: ScanPeriod
    /// </summary>
    public unsafe float ScanPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: CurrentScanAng
    /// </summary>
    public unsafe float CurrentScanAng
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// FloatProperty: ScanAng360
    /// </summary>
    public unsafe float ScanAng360
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: LostPlayerTime
    /// </summary>
    public unsafe float LostPlayerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: LostPlayerTimer
    /// </summary>
    public unsafe float LostPlayerTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// FloatProperty: SeenPlayerTime
    /// </summary>
    public unsafe float SeenPlayerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// FloatProperty: SeenPlayerTimeToStopMoving
    /// </summary>
    public unsafe float SeenPlayerTimeToStopMoving
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// IntProperty: ChaseEndLink
    /// </summary>
    public unsafe int ChaseEndLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: ChaseRePlanDelay
    /// </summary>
    public unsafe float ChaseRePlanDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// IntProperty: StartWanderPoint
    /// </summary>
    public unsafe int StartWanderPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// IntProperty: EndWanderPoint
    /// </summary>
    public unsafe int EndWanderPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveThrottleScale
    /// </summary>
    public unsafe float SelfDriveThrottleScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// StructProperty: LastKnownPos
    /// </summary>
    public unsafe System.Numerics.Vector3 LastKnownPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: SearchDirectionToAvoid
    /// </summary>
    public unsafe System.Numerics.Vector3 SearchDirectionToAvoid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// StructProperty: InitialLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 InitialLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: FullThrottleRange
    /// </summary>
    public unsafe float FullThrottleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// FloatProperty: ChaseMinRange
    /// </summary>
    public unsafe float ChaseMinRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: MinStopAndTurnTime
    /// </summary>
    public unsafe float MinStopAndTurnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: MaxStopAndTurnTime
    /// </summary>
    public unsafe float MaxStopAndTurnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: StopAndScanTime
    /// </summary>
    public unsafe float StopAndScanTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// FloatProperty: ScanWarningTime
    /// </summary>
    public unsafe float ScanWarningTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// FloatProperty: ScanRoundPeriod
    /// </summary>
    public unsafe float ScanRoundPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: PlayerRangeRestricition
    /// </summary>
    public unsafe float PlayerRangeRestricition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// FloatProperty: NoiseAlertRange
    /// </summary>
    public unsafe float NoiseAlertRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: DamageAlertRange
    /// </summary>
    public unsafe float DamageAlertRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: Scan360Timer
    /// </summary>
    public unsafe float Scan360Timer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: AlertOtherEnemiesTime
    /// </summary>
    public unsafe float AlertOtherEnemiesTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// StructProperty: CurrentScanDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentScanDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceReport
    /// </summary>
    public unsafe float TimeSinceReport
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// FloatProperty: ReportInterval
    /// </summary>
    public unsafe float ReportInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: FutureLandCheckTime
    /// </summary>
    public unsafe float FutureLandCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: MaxVelocityDiff
    /// </summary>
    public unsafe float MaxVelocityDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// FloatProperty: MaxPositionDiff
    /// </summary>
    public unsafe float MaxPositionDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: PatrolSpeedScale
    /// </summary>
    public unsafe float PatrolSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: CachedTargetActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CachedTargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: CombatMan
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleCombatManager CombatMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleCombatManager>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: HostTank
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank HostTank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// StructProperty: ChaseRestrictions
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction ChaseRestrictions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: ChasePlanPeriod
    /// </summary>
    public unsafe float ChasePlanPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// StructProperty: LastSeenPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 LastSeenPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StructProperty: LastSafePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 LastSafePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// Enum: ETankSearchPhase
    /// </summary>
    public enum ETankSearchPhase
    {
        ETSP_RandomSearch = 0,
        ETSP_360Scan = 1,
        ETSP_SearchLastKnownPosition = 2,
        ETSP_EngagingTarget = 3,
        ETSP_NULLPhase = 4,
        ETSP_MAX = 5,
    }
}
