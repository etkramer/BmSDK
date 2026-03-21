#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryFogVolumeSphericalDensityInfo<br/>
/// (size = 100)
/// (flags = 134230166)
/// </summary>
public partial class ActorFactoryFogVolumeSphericalDensityInfo : BmSDK.Engine.ActorFactoryFogVolumeConstantDensityInfo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryFogVolumeSphericalDensityInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryFogVolumeSphericalDensityInfo() { }

    /// <summary>
    /// Constructs a new ActorFactoryFogVolumeSphericalDensityInfo
    /// </summary>
    public ActorFactoryFogVolumeSphericalDensityInfo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryFogVolumeSphericalDensityInfo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryFogVolumeSphericalDensityInfo(nint ptr) : base(ptr) { }

}
