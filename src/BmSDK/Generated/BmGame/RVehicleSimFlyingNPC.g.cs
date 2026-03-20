#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleSimFlyingNPC<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleSimFlyingNPC : BmSDK.BmGame.RVehicleSimNPC, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleSimFlyingNPC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleSimFlyingNPC() { }

    /// <summary>
    /// Constructs a new RVehicleSimFlyingNPC
    /// </summary>
    public RVehicleSimFlyingNPC(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleSimFlyingNPC Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleSimFlyingNPC(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: MaxThrust
    /// </summary>
    public unsafe float MaxThrust
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: MaxWanderAccel
    /// </summary>
    public unsafe float MaxWanderAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: WanderPeriod
    /// </summary>
    public unsafe System.Numerics.Vector3 WanderPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// StructProperty: WanderTimer
    /// </summary>
    public unsafe System.Numerics.Vector3 WanderTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
}
