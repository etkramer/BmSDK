#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleApexEmitterShareVolume<br/>
/// (size = 96)
/// (flags = 134221970)
/// </summary>
public partial class ParticleModuleApexEmitterShareVolume : BmSDK.Engine.ParticleModuleApexEmitterBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleApexEmitterShareVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleApexEmitterShareVolume() { }

    /// <summary>
    /// Constructs a new ParticleModuleApexEmitterShareVolume
    /// </summary>
    public ParticleModuleApexEmitterShareVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleApexEmitterShareVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleApexEmitterShareVolume(nint ptr) : base(ptr) { }

}
