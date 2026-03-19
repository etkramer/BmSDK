#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RParticleEffectComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RParticleEffectComponent : BmSDK.BmGame.RPawnEffectComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RParticleEffectComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RParticleEffectComponent() { }

    /// <summary>
    /// Constructs a new RParticleEffectComponent
    /// </summary>
    public RParticleEffectComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RParticleEffectComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RParticleEffectComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: Particle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Particle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ObjectProperty: ParticleSystem
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
}
