#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleSizeScaleOverDensity<br/>
/// (size = 160)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleSizeScaleOverDensity : BmSDK.Engine.ParticleModuleSizeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleSizeScaleOverDensity", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleSizeScaleOverDensity() { }

    /// <summary>
    /// Constructs a new ParticleModuleSizeScaleOverDensity
    /// </summary>
    public ParticleModuleSizeScaleOverDensity(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleSizeScaleOverDensity Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleSizeScaleOverDensity(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SizeScaleOverDensity
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector SizeScaleOverDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
