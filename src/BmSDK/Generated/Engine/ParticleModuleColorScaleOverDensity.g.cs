#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleColorScaleOverDensity<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleColorScaleOverDensity : BmSDK.Engine.ParticleModuleColorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleColorScaleOverDensity", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleColorScaleOverDensity() { }

    /// <summary>
    /// Constructs a new ParticleModuleColorScaleOverDensity
    /// </summary>
    public ParticleModuleColorScaleOverDensity(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleColorScaleOverDensity Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleColorScaleOverDensity(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ColorScaleOverDensity
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleColorScaleOverDensity.AlphaScaleOverDensity ColorScaleOverDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleColorScaleOverDensity.AlphaScaleOverDensity>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: AlphaScaleOverDensity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AlphaScaleOverDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
}
