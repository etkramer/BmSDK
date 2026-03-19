#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleFieldSamplerHeatSource<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleFieldSamplerHeatSource : BmSDK.Engine.ParticleModuleFieldSamplerBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleFieldSamplerHeatSource", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleFieldSamplerHeatSource() { }

    /// <summary>
    /// Constructs a new ParticleModuleFieldSamplerHeatSource
    /// </summary>
    public ParticleModuleFieldSamplerHeatSource(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleFieldSamplerHeatSource Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleFieldSamplerHeatSource(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: FieldSamplerComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FieldSamplerComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
