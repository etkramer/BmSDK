#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleStoreSpawnTime<br/>
/// (flags = 0)
/// </summary>
public partial class ParticleModuleStoreSpawnTime : BmSDK.Engine.ParticleModuleStoreSpawnTimeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleStoreSpawnTime", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleStoreSpawnTime() { }

    /// <summary>
    /// Constructs a new ParticleModuleStoreSpawnTime
    /// </summary>
    public ParticleModuleStoreSpawnTime(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleStoreSpawnTime Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleStoreSpawnTime(nint ptr) : base(ptr) { }

}
