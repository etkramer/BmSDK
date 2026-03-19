#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleSpawn<br/>
/// (size = 0)
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
    public unsafe BmSDK.Engine.ParticleModuleSpawn.RateScale Rate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleSpawn.RateScale>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: RateScale
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleSpawn.BurstList RateScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleSpawn.BurstList>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ByteProperty: ParticleBurstMethod
    /// </summary>
    public unsafe byte ParticleBurstMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ArrayProperty: BurstList
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT BurstList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: ParticleAudio
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ParticleAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
}
