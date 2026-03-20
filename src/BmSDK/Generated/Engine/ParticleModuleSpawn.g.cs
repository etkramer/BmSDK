#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleSpawn<br/>
/// (flags = 0)
/// </summary>
public partial class ParticleModuleSpawn : BmSDK.Engine.ParticleModuleSpawnBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleSpawn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleSpawn() { }

    /// <summary>
    /// Constructs a new ParticleModuleSpawn
    /// </summary>
    public ParticleModuleSpawn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleSpawn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleSpawn(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Rate
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat Rate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: RateScale
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat RateScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ByteProperty: ParticleBurstMethod
    /// </summary>
    public unsafe BmSDK.Engine.ParticleEmitter.EParticleBurstMethod ParticleBurstMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleEmitter.EParticleBurstMethod>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ArrayProperty: BurstList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleEmitter.FParticleBurst> BurstList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleEmitter.FParticleBurst>>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: ParticleAudio
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.FAkParticleEvents ParticleAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkParticleEvents>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
}
