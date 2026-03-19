#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleAccelerationOverLifetime<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleAccelerationOverLifetime : BmSDK.Engine.ParticleModuleAccelerationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleAccelerationOverLifetime", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleAccelerationOverLifetime() { }

    /// <summary>
    /// Constructs a new ParticleModuleAccelerationOverLifetime
    /// </summary>
    public ParticleModuleAccelerationOverLifetime(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleAccelerationOverLifetime Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleAccelerationOverLifetime(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: AccelOverLife
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AccelOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
