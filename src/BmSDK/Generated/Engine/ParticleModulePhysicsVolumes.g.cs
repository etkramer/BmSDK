#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModulePhysicsVolumes<br/>
/// (flags = 0)
/// </summary>
public partial class ParticleModulePhysicsVolumes : BmSDK.Engine.ParticleModuleWorldForcesBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModulePhysicsVolumes", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModulePhysicsVolumes() { }

    /// <summary>
    /// Constructs a new ParticleModulePhysicsVolumes
    /// </summary>
    public ParticleModulePhysicsVolumes(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModulePhysicsVolumes Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModulePhysicsVolumes(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: GlobalInfluence
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat GlobalInfluence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: LevelInfluenceType
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModulePhysicsVolumes.EParticleLevelInfluenceType LevelInfluenceType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModulePhysicsVolumes.EParticleLevelInfluenceType>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
}
