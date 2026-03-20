#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_BatmanOnRoof<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_BatmanOnRoof : BmSDK.BmGame.RVehicleBehaviour_RunAway, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_BatmanOnRoof", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_BatmanOnRoof() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_BatmanOnRoof
    /// </summary>
    public RVehicleBehaviour_BatmanOnRoof(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_BatmanOnRoof Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_BatmanOnRoof(nint ptr) : base(ptr) { }

}
