#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleWorldAttractor<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleWorldAttractor : BmSDK.Engine.ParticleModuleWorldForcesBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleWorldAttractor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleWorldAttractor() { }

    /// <summary>
    /// Constructs a new ParticleModuleWorldAttractor
    /// </summary>
    public ParticleModuleWorldAttractor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleWorldAttractor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleWorldAttractor(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bParticleLifeRelative
    /// </summary>
    public unsafe bool bParticleLifeRelative
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: AttractorInfluence
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AttractorInfluence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
