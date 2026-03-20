#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RTimeTrialWaypointRenderingComponent<br/>
/// (size = 540)
/// (flags = 2290094290)
/// </summary>
public partial class RTimeTrialWaypointRenderingComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RTimeTrialWaypointRenderingComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RTimeTrialWaypointRenderingComponent() { }

    /// <summary>
    /// Constructs a new RTimeTrialWaypointRenderingComponent
    /// </summary>
    public RTimeTrialWaypointRenderingComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RTimeTrialWaypointRenderingComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RTimeTrialWaypointRenderingComponent(nint ptr) : base(ptr) { }

}
