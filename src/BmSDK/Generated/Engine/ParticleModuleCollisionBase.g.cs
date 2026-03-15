#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: ParticleModuleCollisionBase<br/>
/// (size = 56)
/// (flags = 134221971)
/// </summary>
public partial class ParticleModuleCollisionBase : BmSDK.Engine.ParticleModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleCollisionBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleCollisionBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleCollisionBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: EParticleCollisionComplete
    /// </summary>
    public enum EParticleCollisionComplete
    {
        EPCC_Kill = 0,
        EPCC_Freeze = 1,
        EPCC_HaltCollisions = 2,
        EPCC_FreezeTranslation = 3,
        EPCC_FreezeRotation = 4,
        EPCC_FreezeMovement = 5,
        EPCC_MAX = 6,
    }
}
