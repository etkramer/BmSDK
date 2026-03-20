#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRocketLauncherEdgeRenderingComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RRocketLauncherEdgeRenderingComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRocketLauncherEdgeRenderingComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRocketLauncherEdgeRenderingComponent() { }

    /// <summary>
    /// Constructs a new RRocketLauncherEdgeRenderingComponent
    /// </summary>
    public RRocketLauncherEdgeRenderingComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRocketLauncherEdgeRenderingComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRocketLauncherEdgeRenderingComponent(nint ptr) : base(ptr) { }

}
