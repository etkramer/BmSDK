#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: ParticleModuleTypeDataBase<br/>
/// (size = 56)
/// (flags = 134221971)
/// </summary>
public partial class ParticleModuleTypeDataBase : BmSDK.Engine.ParticleModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleTypeDataBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleTypeDataBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleTypeDataBase(nint ptr) : base(ptr) { }

}
