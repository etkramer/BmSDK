#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_MonitorPlayer<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_MonitorPlayer : BmSDK.BmGame.RVehicleBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_MonitorPlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_MonitorPlayer() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_MonitorPlayer
    /// </summary>
    public RVehicleBehaviour_MonitorPlayer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_MonitorPlayer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_MonitorPlayer(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: MonitorPlayerRange
    /// </summary>
    public unsafe float MonitorPlayerRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: MonitorInterval
    /// </summary>
    public unsafe float MonitorInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: MonitorTimer
    /// </summary>
    public unsafe float MonitorTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
}
