#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleMeshRotationRateMultiplyLife<br/>
/// (size = 84)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleMeshRotationRateMultiplyLife : BmSDK.Engine.ParticleModuleRotationRateBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleMeshRotationRateMultiplyLife", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleMeshRotationRateMultiplyLife() { }

    /// <summary>
    /// Constructs a new ParticleModuleMeshRotationRateMultiplyLife
    /// </summary>
    public ParticleModuleMeshRotationRateMultiplyLife(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleMeshRotationRateMultiplyLife Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleMeshRotationRateMultiplyLife(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: LifeMultiplier
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector LifeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }
}
