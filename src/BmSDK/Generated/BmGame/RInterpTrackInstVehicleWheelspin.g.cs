#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RInterpTrackInstVehicleWheelspin<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class RInterpTrackInstVehicleWheelspin : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RInterpTrackInstVehicleWheelspin", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInterpTrackInstVehicleWheelspin() { }

    /// <summary>
    /// Constructs a new RInterpTrackInstVehicleWheelspin
    /// </summary>
    public RInterpTrackInstVehicleWheelspin(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInterpTrackInstVehicleWheelspin Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInterpTrackInstVehicleWheelspin(nint ptr) : base(ptr) { }

}
