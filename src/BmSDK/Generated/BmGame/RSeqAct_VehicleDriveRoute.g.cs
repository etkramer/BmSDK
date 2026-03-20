#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_VehicleDriveRoute<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_VehicleDriveRoute : BmSDK.BmGame.RSeqAct_VehicleSelfDrive, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_VehicleDriveRoute", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_VehicleDriveRoute() { }

    /// <summary>
    /// Constructs a new RSeqAct_VehicleDriveRoute
    /// </summary>
    public RSeqAct_VehicleDriveRoute(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_VehicleDriveRoute Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_VehicleDriveRoute(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TargetVehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle TargetVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: PatrolRoute
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint PatrolRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
}
