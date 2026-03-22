#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RWaterFlowTargetEditorRenderingComponent<br/>
/// (size = 404)
/// (flags = 2290094226)
/// </summary>
public partial class RWaterFlowTargetEditorRenderingComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RWaterFlowTargetEditorRenderingComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RWaterFlowTargetEditorRenderingComponent() { }

    /// <summary>
    /// Constructs a new RWaterFlowTargetEditorRenderingComponent
    /// </summary>
    public RWaterFlowTargetEditorRenderingComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RWaterFlowTargetEditorRenderingComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RWaterFlowTargetEditorRenderingComponent(nint ptr) : base(ptr) { }

}
