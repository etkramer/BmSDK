#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LevelGridVolumeRenderingComponent<br/>
/// (size = 404)
/// (flags = 2290094226)
/// </summary>
public partial class LevelGridVolumeRenderingComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LevelGridVolumeRenderingComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LevelGridVolumeRenderingComponent() { }

    /// <summary>
    /// Constructs a new LevelGridVolumeRenderingComponent
    /// </summary>
    public LevelGridVolumeRenderingComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LevelGridVolumeRenderingComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LevelGridVolumeRenderingComponent(nint ptr) : base(ptr) { }

}
