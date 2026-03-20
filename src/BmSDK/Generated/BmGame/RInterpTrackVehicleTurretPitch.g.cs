#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RInterpTrackVehicleTurretPitch<br/>
/// (size = 256)
/// (flags = 0)
/// </summary>
public partial class RInterpTrackVehicleTurretPitch : BmSDK.Engine.InterpTrackFloatBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RInterpTrackVehicleTurretPitch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInterpTrackVehicleTurretPitch() { }

    /// <summary>
    /// Constructs a new RInterpTrackVehicleTurretPitch
    /// </summary>
    public RInterpTrackVehicleTurretPitch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInterpTrackVehicleTurretPitch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInterpTrackVehicleTurretPitch(nint ptr) : base(ptr) { }

}
