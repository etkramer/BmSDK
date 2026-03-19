#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_FlyingDeathSpiral<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_FlyingDeathSpiral : BmSDK.BmGame.RVehicleBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_FlyingDeathSpiral", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_FlyingDeathSpiral() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_FlyingDeathSpiral
    /// </summary>
    public RVehicleBehaviour_FlyingDeathSpiral(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_FlyingDeathSpiral Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_FlyingDeathSpiral(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: Age
    /// </summary>
    public unsafe float Age
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// StructProperty: Spin
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Spin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// StructProperty: Vel
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Vel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }
}
