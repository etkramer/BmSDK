#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleOrbit<br/>
/// (flags = 0)
/// </summary>
public partial class ParticleModuleOrbit : BmSDK.Engine.ParticleModuleOrbitBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleOrbit", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleOrbit() { }

    /// <summary>
    /// Constructs a new ParticleModuleOrbit
    /// </summary>
    public ParticleModuleOrbit(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleOrbit Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleOrbit(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: ChainMode
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleOrbit.EOrbitChainMode ChainMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleOrbit.EOrbitChainMode>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: OffsetAmount
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector OffsetAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: OffsetOptions
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleOrbit.FOrbitOptions OffsetOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleOrbit.FOrbitOptions>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StructProperty: RotationAmount
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector RotationAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: RotationOptions
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleOrbit.FOrbitOptions RotationOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleOrbit.FOrbitOptions>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// StructProperty: RotationRateAmount
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector RotationRateAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: RotationRateOptions
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleOrbit.FOrbitOptions RotationRateOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleOrbit.FOrbitOptions>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// Enum: EOrbitChainMode
    /// </summary>
    public enum EOrbitChainMode
    {
        EOChainMode_Add = 0,
        EOChainMode_Scale = 1,
        EOChainMode_Link = 2,
        EOChainMode_MAX = 3,
    }
}
