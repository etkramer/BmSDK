#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleMeshRotationRateOverLife<br/>
/// (flags = 0)
/// </summary>
public partial class ParticleModuleMeshRotationRateOverLife : BmSDK.Engine.ParticleModuleRotationRateBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleMeshRotationRateOverLife", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleMeshRotationRateOverLife() { }

    /// <summary>
    /// Constructs a new ParticleModuleMeshRotationRateOverLife
    /// </summary>
    public ParticleModuleMeshRotationRateOverLife(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleMeshRotationRateOverLife Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleMeshRotationRateOverLife(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: RotRate
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector RotRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bScaleRotRate
    /// </summary>
    public unsafe bool bScaleRotRate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }
}
