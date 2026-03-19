#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_VehicleDriveSpline<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_VehicleDriveSpline : BmSDK.BmGame.RSeqAct_VehicleSelfDrive, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_VehicleDriveSpline", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_VehicleDriveSpline() { }

    /// <summary>
    /// Constructs a new RSeqAct_VehicleDriveSpline
    /// </summary>
    public RSeqAct_VehicleDriveSpline(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_VehicleDriveSpline Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_VehicleDriveSpline(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TargetVehicle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: TargetSpline
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetSpline
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: TeleportToStartPoint
    /// </summary>
    public unsafe bool TeleportToStartPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: ControlsThrottle
    /// </summary>
    public unsafe bool ControlsThrottle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: DontStopAtEnd
    /// </summary>
    public unsafe bool DontStopAtEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }
}
