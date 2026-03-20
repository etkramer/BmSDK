#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleLocationWorldOffset<br/>
/// (size = 168)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleLocationWorldOffset : BmSDK.Engine.ParticleModuleLocation, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleLocationWorldOffset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleLocationWorldOffset() { }

    /// <summary>
    /// Constructs a new ParticleModuleLocationWorldOffset
    /// </summary>
    public ParticleModuleLocationWorldOffset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleLocationWorldOffset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleLocationWorldOffset(nint ptr) : base(ptr) { }

}
