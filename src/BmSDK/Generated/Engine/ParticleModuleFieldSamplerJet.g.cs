#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleFieldSamplerJet<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleFieldSamplerJet : BmSDK.Engine.ParticleModuleFieldSamplerBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleFieldSamplerJet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleFieldSamplerJet() { }

    /// <summary>
    /// Constructs a new ParticleModuleFieldSamplerJet
    /// </summary>
    public ParticleModuleFieldSamplerJet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleFieldSamplerJet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleFieldSamplerJet(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: FieldSamplerComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FieldSamplerComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
