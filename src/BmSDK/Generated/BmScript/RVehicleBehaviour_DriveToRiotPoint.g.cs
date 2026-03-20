#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RVehicleBehaviour_DriveToRiotPoint<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_DriveToRiotPoint : BmSDK.BmGame.RVehicleBehaviour_DriveToGoalPoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RVehicleBehaviour_DriveToRiotPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_DriveToRiotPoint() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_DriveToRiotPoint
    /// </summary>
    public RVehicleBehaviour_DriveToRiotPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_DriveToRiotPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_DriveToRiotPoint(nint ptr) : base(ptr) { }

}
