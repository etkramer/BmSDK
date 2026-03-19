#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleMeshRotation_Seeded<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleMeshRotation_Seeded : BmSDK.Engine.ParticleModuleMeshRotation, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleMeshRotation_Seeded", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleMeshRotation_Seeded() { }

    /// <summary>
    /// Constructs a new ParticleModuleMeshRotation_Seeded
    /// </summary>
    public ParticleModuleMeshRotation_Seeded(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleMeshRotation_Seeded Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleMeshRotation_Seeded(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: RandomSeedInfo
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleMeshRotation.StartRotation RandomSeedInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleMeshRotation.StartRotation>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
}
