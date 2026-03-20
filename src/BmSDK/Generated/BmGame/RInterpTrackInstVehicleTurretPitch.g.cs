#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RInterpTrackInstVehicleTurretPitch<br/>
/// (size = 84)
/// (flags = 134217874)
/// </summary>
public partial class RInterpTrackInstVehicleTurretPitch : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RInterpTrackInstVehicleTurretPitch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInterpTrackInstVehicleTurretPitch() { }

    /// <summary>
    /// Constructs a new RInterpTrackInstVehicleTurretPitch
    /// </summary>
    public RInterpTrackInstVehicleTurretPitch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInterpTrackInstVehicleTurretPitch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInterpTrackInstVehicleTurretPitch(nint ptr) : base(ptr) { }

}
