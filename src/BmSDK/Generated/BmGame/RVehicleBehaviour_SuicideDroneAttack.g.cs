#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_SuicideDroneAttack<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_SuicideDroneAttack : BmSDK.BmGame.RVehicleBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_SuicideDroneAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_SuicideDroneAttack() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_SuicideDroneAttack
    /// </summary>
    public RVehicleBehaviour_SuicideDroneAttack(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_SuicideDroneAttack Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_SuicideDroneAttack(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: SuicideAttackRange
    /// </summary>
    public unsafe float SuicideAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: ThrusterForce
    /// </summary>
    public unsafe float ThrusterForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: RamMaxSteeringAngle
    /// </summary>
    public unsafe float RamMaxSteeringAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: TrailingTime
    /// </summary>
    public unsafe float TrailingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: RamTimer
    /// </summary>
    public unsafe float RamTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// FloatProperty: DetonateTimer
    /// </summary>
    public unsafe float DetonateTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: TimeInRange
    /// </summary>
    public unsafe float TimeInRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// BoolProperty: bHitBatmobile
    /// </summary>
    public unsafe bool bHitBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 636); }
    }

    /// <summary>
    /// BoolProperty: bDoneExplosion
    /// </summary>
    public unsafe bool bDoneExplosion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 636); }
    }

    /// <summary>
    /// BoolProperty: HasLineOfSightToBatmobile
    /// </summary>
    public unsafe bool HasLineOfSightToBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 636); }
    }

    /// <summary>
    /// ObjectProperty: Batmobile
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ComponentProperty: Thruster
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Thruster
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: FollowOffsetBase
    /// </summary>
    public unsafe float FollowOffsetBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// FloatProperty: FollowOffsetExtra
    /// </summary>
    public unsafe float FollowOffsetExtra
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// StructProperty: LastBatmobileVisibleLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastBatmobileVisibleLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLineOfSight
    /// </summary>
    public unsafe float TimeSinceLineOfSight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// FloatProperty: FindPlanDelay
    /// </summary>
    public unsafe float FindPlanDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// FloatProperty: totalTimeInRangeRequired
    /// </summary>
    public unsafe float totalTimeInRangeRequired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ByteProperty: SuicideMode
    /// </summary>
    public unsafe byte SuicideMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }
}
