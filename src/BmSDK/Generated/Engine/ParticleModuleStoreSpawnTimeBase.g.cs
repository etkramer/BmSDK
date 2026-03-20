#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleStoreSpawnTimeBase<br/>
/// (flags = 0)
/// </summary>
public partial class ParticleModuleStoreSpawnTimeBase : BmSDK.Engine.ParticleModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleStoreSpawnTimeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleStoreSpawnTimeBase() { }

    /// <summary>
    /// Constructs a new ParticleModuleStoreSpawnTimeBase
    /// </summary>
    public ParticleModuleStoreSpawnTimeBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleStoreSpawnTimeBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleStoreSpawnTimeBase(nint ptr) : base(ptr) { }

}
