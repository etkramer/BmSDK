#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RVehicleBehaviour_Parked<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_Parked : BmSDK.BmGame.RVehicleBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RVehicleBehaviour_Parked", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_Parked() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_Parked
    /// </summary>
    public RVehicleBehaviour_Parked(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_Parked Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_Parked(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: GotoCombatBehaviourIfBatmobileInRange
    /// </summary>
    public unsafe float GotoCombatBehaviourIfBatmobileInRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }
}
