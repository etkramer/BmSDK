#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RInterpTrackInstVehicleSteering<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class RInterpTrackInstVehicleSteering : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RInterpTrackInstVehicleSteering", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInterpTrackInstVehicleSteering() { }

    /// <summary>
    /// Constructs a new RInterpTrackInstVehicleSteering
    /// </summary>
    public RInterpTrackInstVehicleSteering(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInterpTrackInstVehicleSteering Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInterpTrackInstVehicleSteering(nint ptr) : base(ptr) { }

}
