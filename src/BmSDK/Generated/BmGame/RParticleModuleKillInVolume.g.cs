#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RParticleModuleKillInVolume<br/>
/// (size = 96)
/// (flags = 134221970)
/// </summary>
public partial class RParticleModuleKillInVolume : BmSDK.Engine.ParticleModuleKillBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RParticleModuleKillInVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RParticleModuleKillInVolume() { }

    /// <summary>
    /// Constructs a new RParticleModuleKillInVolume
    /// </summary>
    public RParticleModuleKillInVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RParticleModuleKillInVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RParticleModuleKillInVolume(nint ptr) : base(ptr) { }

}
