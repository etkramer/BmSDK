#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LandscapeGizmoRenderComponent<br/>
/// (flags = 0)
/// </summary>
public partial class LandscapeGizmoRenderComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LandscapeGizmoRenderComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LandscapeGizmoRenderComponent() { }

    /// <summary>
    /// Constructs a new LandscapeGizmoRenderComponent
    /// </summary>
    public LandscapeGizmoRenderComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LandscapeGizmoRenderComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LandscapeGizmoRenderComponent(nint ptr) : base(ptr) { }

}
