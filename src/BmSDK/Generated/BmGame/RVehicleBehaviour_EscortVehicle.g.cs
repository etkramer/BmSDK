#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_EscortVehicle<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_EscortVehicle : BmSDK.BmGame.RVehicleBehaviour_FollowVehicle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_EscortVehicle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_EscortVehicle() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_EscortVehicle
    /// </summary>
    public RVehicleBehaviour_EscortVehicle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_EscortVehicle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_EscortVehicle(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: AlongsideTime
    /// </summary>
    public unsafe float AlongsideTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: AlongsidePos
    /// </summary>
    public unsafe float AlongsidePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: AlongsideBatmobileOffset
    /// </summary>
    public unsafe float AlongsideBatmobileOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: FollowVehicleIsDead
    /// </summary>
    public unsafe bool FollowVehicleIsDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: AlertLeadVehicleWhenSeenBatman
    /// </summary>
    public unsafe bool AlertLeadVehicleWhenSeenBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: AllowShoot
    /// </summary>
    public unsafe bool AllowShoot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: DisallowSelfDriveRescue
    /// </summary>
    public unsafe bool DisallowSelfDriveRescue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: BatmobileInPursuit
    /// </summary>
    public unsafe bool BatmobileInPursuit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: PassengersRunAfterDeathExit
    /// </summary>
    public unsafe bool PassengersRunAfterDeathExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: WasPassengersExitWhenDestroyed
    /// </summary>
    public unsafe bool WasPassengersExitWhenDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: RamBatmobileDelay
    /// </summary>
    public unsafe float RamBatmobileDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: FollowOffsetBase
    /// </summary>
    public unsafe float FollowOffsetBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: FollowOffsetExtra
    /// </summary>
    public unsafe float FollowOffsetExtra
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// FloatProperty: MaxAttackPlayerRange
    /// </summary>
    public unsafe float MaxAttackPlayerRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// FloatProperty: DamagedErraticDrivingTime
    /// </summary>
    public unsafe float DamagedErraticDrivingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }
}
