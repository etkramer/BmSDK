#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_RunAwayCop<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_RunAwayCop : BmSDK.BmGame.RVehicleBehaviour_RunAway, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_RunAwayCop", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_RunAwayCop() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_RunAwayCop
    /// </summary>
    public RVehicleBehaviour_RunAwayCop(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_RunAwayCop Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_RunAwayCop(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: AvoidedBatmanDelay
    /// </summary>
    public unsafe float AvoidedBatmanDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: ReturnToGcpdDelay
    /// </summary>
    public unsafe float ReturnToGcpdDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
}
