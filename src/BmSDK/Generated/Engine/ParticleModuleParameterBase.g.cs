#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: ParticleModuleParameterBase<br/>
/// (size = 56)
/// (flags = 134221971)
/// </summary>
public partial class ParticleModuleParameterBase : BmSDK.Engine.ParticleModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleParameterBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleParameterBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleParameterBase(nint ptr) : base(ptr) { }

}
