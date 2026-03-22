#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleEventReceiverKillParticles<br/>
/// (size = 72)
/// (flags = 134221970)
/// </summary>
public partial class ParticleModuleEventReceiverKillParticles : BmSDK.Engine.ParticleModuleEventReceiverBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleEventReceiverKillParticles", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleEventReceiverKillParticles() { }

    /// <summary>
    /// Constructs a new ParticleModuleEventReceiverKillParticles
    /// </summary>
    public ParticleModuleEventReceiverKillParticles(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleEventReceiverKillParticles Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleEventReceiverKillParticles(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bStopSpawning
    /// </summary>
    public unsafe bool bStopSpawning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }
}
