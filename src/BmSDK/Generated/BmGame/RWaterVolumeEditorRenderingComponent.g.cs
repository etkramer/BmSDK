#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RWaterVolumeEditorRenderingComponent<br/>
/// (size = 404)
/// (flags = 2290094226)
/// </summary>
public partial class RWaterVolumeEditorRenderingComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RWaterVolumeEditorRenderingComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RWaterVolumeEditorRenderingComponent() { }

    /// <summary>
    /// Constructs a new RWaterVolumeEditorRenderingComponent
    /// </summary>
    public RWaterVolumeEditorRenderingComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RWaterVolumeEditorRenderingComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RWaterVolumeEditorRenderingComponent(nint ptr) : base(ptr) { }

}
