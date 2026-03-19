#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleLocationPrimitiveSphere_Seeded<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleLocationPrimitiveSphere_Seeded : BmSDK.Engine.ParticleModuleLocationPrimitiveSphere, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleLocationPrimitiveSphere_Seeded", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleLocationPrimitiveSphere_Seeded() { }

    /// <summary>
    /// Constructs a new ParticleModuleLocationPrimitiveSphere_Seeded
    /// </summary>
    public ParticleModuleLocationPrimitiveSphere_Seeded(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleLocationPrimitiveSphere_Seeded Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleLocationPrimitiveSphere_Seeded(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: RandomSeedInfo
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleLocationPrimitiveSphere.StartRadius RandomSeedInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleLocationPrimitiveSphere.StartRadius>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }
}
