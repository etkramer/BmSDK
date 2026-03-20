#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RVehicleBehaviour_DriveToRiotPoint<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_DriveToRiotPoint : BmSDK.BmGame.RVehicleBehaviour_DriveToGoalPoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RVehicleBehaviour_DriveToRiotPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_DriveToRiotPoint() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_DriveToRiotPoint
    /// </summary>
    public RVehicleBehaviour_DriveToRiotPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_DriveToRiotPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_DriveToRiotPoint(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: GoalActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor GoalActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: DriveAtSpeed
    /// </summary>
    public unsafe float DriveAtSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: DriveAtSpeedOffScreen
    /// </summary>
    public unsafe float DriveAtSpeedOffScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// BoolProperty: DriveErratically
    /// </summary>
    public unsafe bool DriveErratically
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 624); }
    }

    /// <summary>
    /// BoolProperty: TankTurnOnSpot
    /// </summary>
    public unsafe bool TankTurnOnSpot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 624); }
    }

    /// <summary>
    /// BoolProperty: DriveOnCorrectSide
    /// </summary>
    public unsafe bool DriveOnCorrectSide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 624); }
    }

    /// <summary>
    /// BoolProperty: TreatAsRunawayBehaviour
    /// </summary>
    public unsafe bool TreatAsRunawayBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 624); }
    }

    /// <summary>
    /// BoolProperty: PushBumpedCars
    /// </summary>
    public unsafe bool PushBumpedCars
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 624); }
    }

    /// <summary>
    /// BoolProperty: PushBumpedBatmobile
    /// </summary>
    public unsafe bool PushBumpedBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 624); }
    }

    /// <summary>
    /// BoolProperty: DisallowUturnAtStart
    /// </summary>
    public unsafe bool DisallowUturnAtStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 624); }
    }

    /// <summary>
    /// BoolProperty: ReversingForBatmobile
    /// </summary>
    public unsafe bool ReversingForBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 624); }
    }

    /// <summary>
    /// BoolProperty: AllowNoGoalActor
    /// </summary>
    public unsafe bool AllowNoGoalActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 624); }
    }

    /// <summary>
    /// FloatProperty: MaxThrottleForSharpTurns
    /// </summary>
    public unsafe float MaxThrottleForSharpTurns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: OriginalTankSteerScale
    /// </summary>
    public unsafe float OriginalTankSteerScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: SeeBatmanDistance
    /// </summary>
    public unsafe float SeeBatmanDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// FloatProperty: AwareOfBatmobileDuration
    /// </summary>
    public unsafe float AwareOfBatmobileDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// FloatProperty: EarlyCompleteDistance
    /// </summary>
    public unsafe float EarlyCompleteDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// StructProperty: DestLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 DestLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }
}
