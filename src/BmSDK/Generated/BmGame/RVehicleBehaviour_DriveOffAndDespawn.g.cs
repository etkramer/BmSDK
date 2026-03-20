#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_DriveOffAndDespawn<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_DriveOffAndDespawn : BmSDK.BmGame.RVehicleBehaviour_RunAway, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_DriveOffAndDespawn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_DriveOffAndDespawn() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_DriveOffAndDespawn
    /// </summary>
    public RVehicleBehaviour_DriveOffAndDespawn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_DriveOffAndDespawn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_DriveOffAndDespawn(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DriveAwayFromVehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC DriveAwayFromVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: DespawnMinDistanceFromBatman
    /// </summary>
    public unsafe float DespawnMinDistanceFromBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// FloatProperty: DespawnMinTimeOffCamera
    /// </summary>
    public unsafe float DespawnMinTimeOffCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: DriveOffImmediately
    /// </summary>
    public unsafe bool DriveOffImmediately
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 956); }
    }
}
