#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_TankGuard<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_TankGuard : BmSDK.BmGame.RVehicleBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_TankGuard", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_TankGuard() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_TankGuard
    /// </summary>
    public RVehicleBehaviour_TankGuard(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_TankGuard Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_TankGuard(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bForRiot
    /// </summary>
    public unsafe bool bForRiot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 608); }
    }

    /// <summary>
    /// BoolProperty: ClampTurretToScanRange
    /// </summary>
    public unsafe bool ClampTurretToScanRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 608); }
    }

    /// <summary>
    /// BoolProperty: Scan
    /// </summary>
    public unsafe bool Scan
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 608); }
    }

    /// <summary>
    /// BoolProperty: DisableDeathBarks
    /// </summary>
    public unsafe bool DisableDeathBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 608); }
    }

    /// <summary>
    /// BoolProperty: ThisIsCombatBehaviour
    /// </summary>
    public unsafe bool ThisIsCombatBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 608); }
    }

    /// <summary>
    /// ObjectProperty: RiotZone
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RiotZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// IntProperty: AlertNumTanksIfAttacked
    /// </summary>
    public unsafe int AlertNumTanksIfAttacked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: AlertTanksInRangeIfAttacked
    /// </summary>
    public unsafe float AlertTanksInRangeIfAttacked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// IntProperty: ScanningTheRoom
    /// </summary>
    public unsafe int ScanningTheRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: ScanningTheRoomPause
    /// </summary>
    public unsafe float ScanningTheRoomPause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: ScanMinYaw
    /// </summary>
    public unsafe float ScanMinYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// FloatProperty: ScanMaxYaw
    /// </summary>
    public unsafe float ScanMaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// FloatProperty: ScanSpeed
    /// </summary>
    public unsafe float ScanSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// FloatProperty: ScanPause
    /// </summary>
    public unsafe float ScanPause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: ScanPauseRandomExtra
    /// </summary>
    public unsafe float ScanPauseRandomExtra
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }
}
