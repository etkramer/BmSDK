#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTrailSpawn<br/>
/// (size = 64)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleTrailSpawn : BmSDK.Engine.ParticleModuleTrailBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleTrailSpawn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleTrailSpawn() { }

    /// <summary>
    /// Constructs a new ParticleModuleTrailSpawn
    /// </summary>
    public ParticleModuleTrailSpawn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleTrailSpawn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleTrailSpawn(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: SpawnDistanceMap
    /// </summary>
    public unsafe BmSDK.Engine.DistributionFloatParticleParameter SpawnDistanceMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DistributionFloatParticleParameter>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// FloatProperty: MinSpawnVelocity
    /// </summary>
    public unsafe float MinSpawnVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// Enum: ETrail2SpawnMethod
    /// </summary>
    public enum ETrail2SpawnMethod
    {
        PET2SM_Emitter = 0,
        PET2SM_Velocity = 1,
        PET2SM_Distance = 2,
        PET2SM_MAX = 3,
    }
}
