#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkVehicleSound<br/>
/// (size = 124)
/// (flags = 18)
/// </summary>
public partial class AkVehicleSound : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkVehicleSound", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkVehicleSound() { }

    /// <summary>
    /// Constructs a new AkVehicleSound
    /// </summary>
    public AkVehicleSound(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkVehicleSound Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkVehicleSound(nint ptr) : base(ptr) { }

}
