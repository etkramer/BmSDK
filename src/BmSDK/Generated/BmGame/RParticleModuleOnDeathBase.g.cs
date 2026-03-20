#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RParticleModuleOnDeathBase<br/>
/// (size = 96)
/// (flags = 0)
/// </summary>
public partial class RParticleModuleOnDeathBase : BmSDK.Engine.ParticleModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RParticleModuleOnDeathBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RParticleModuleOnDeathBase() { }

    /// <summary>
    /// Constructs a new RParticleModuleOnDeathBase
    /// </summary>
    public RParticleModuleOnDeathBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RParticleModuleOnDeathBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RParticleModuleOnDeathBase(nint ptr) : base(ptr) { }

}
