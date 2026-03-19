#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleRotationRateMultiplyLife<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleRotationRateMultiplyLife : BmSDK.Engine.ParticleModuleRotationRateBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleRotationRateMultiplyLife", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleRotationRateMultiplyLife() { }

    /// <summary>
    /// Constructs a new ParticleModuleRotationRateMultiplyLife
    /// </summary>
    public ParticleModuleRotationRateMultiplyLife(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleRotationRateMultiplyLife Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleRotationRateMultiplyLife(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: LifeMultiplier
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LifeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
