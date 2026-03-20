#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RParticleModuleGPURecycleSpawn<br/>
/// (flags = 0)
/// </summary>
public partial class RParticleModuleGPURecycleSpawn : BmSDK.Engine.ParticleModuleSpawnBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RParticleModuleGPURecycleSpawn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RParticleModuleGPURecycleSpawn() { }

    /// <summary>
    /// Constructs a new RParticleModuleGPURecycleSpawn
    /// </summary>
    public RParticleModuleGPURecycleSpawn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RParticleModuleGPURecycleSpawn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RParticleModuleGPURecycleSpawn(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: MaxNumSpawnedPerFrame
    /// </summary>
    public unsafe int MaxNumSpawnedPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: ParticleBehaviourRandomisation
    /// </summary>
    public unsafe float ParticleBehaviourRandomisation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: RandomisationMultiplier
    /// </summary>
    public unsafe float RandomisationMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: RefreshPercentage
    /// </summary>
    public unsafe float RefreshPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
