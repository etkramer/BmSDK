#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTypeDataApexSprite<br/>
/// (size = 112)
/// (flags = 134230162)
/// </summary>
public partial class ParticleModuleTypeDataApexSprite : BmSDK.Engine.ParticleModuleTypeDataApex, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleTypeDataApexSprite", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleTypeDataApexSprite() { }

    /// <summary>
    /// Constructs a new ParticleModuleTypeDataApexSprite
    /// </summary>
    public ParticleModuleTypeDataApexSprite(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleTypeDataApexSprite Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleTypeDataApexSprite(nint ptr) : base(ptr) { }

}
