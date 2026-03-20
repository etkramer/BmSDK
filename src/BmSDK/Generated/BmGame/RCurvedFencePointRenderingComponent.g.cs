#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCurvedFencePointRenderingComponent<br/>
/// (size = 540)
/// (flags = 0)
/// </summary>
public partial class RCurvedFencePointRenderingComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCurvedFencePointRenderingComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCurvedFencePointRenderingComponent() { }

    /// <summary>
    /// Constructs a new RCurvedFencePointRenderingComponent
    /// </summary>
    public RCurvedFencePointRenderingComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCurvedFencePointRenderingComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCurvedFencePointRenderingComponent(nint ptr) : base(ptr) { }

}
