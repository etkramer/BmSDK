#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RInterpTrackInstVehicleTurretYaw<br/>
/// (size = 84)
/// (flags = 134217874)
/// </summary>
public partial class RInterpTrackInstVehicleTurretYaw : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RInterpTrackInstVehicleTurretYaw", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInterpTrackInstVehicleTurretYaw() { }

    /// <summary>
    /// Constructs a new RInterpTrackInstVehicleTurretYaw
    /// </summary>
    public RInterpTrackInstVehicleTurretYaw(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInterpTrackInstVehicleTurretYaw Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInterpTrackInstVehicleTurretYaw(nint ptr) : base(ptr) { }

}
