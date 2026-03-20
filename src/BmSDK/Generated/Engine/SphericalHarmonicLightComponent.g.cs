#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SphericalHarmonicLightComponent<br/>
/// (flags = 0)
/// </summary>
public partial class SphericalHarmonicLightComponent : BmSDK.Engine.LightComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SphericalHarmonicLightComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SphericalHarmonicLightComponent() { }

    /// <summary>
    /// Constructs a new SphericalHarmonicLightComponent
    /// </summary>
    public SphericalHarmonicLightComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SphericalHarmonicLightComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SphericalHarmonicLightComponent(nint ptr) : base(ptr) { }

}
