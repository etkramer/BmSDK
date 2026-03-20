#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPathGateComponent<br/>
/// (size = 124)
/// (flags = 33554450)
/// </summary>
public partial class RPathGateComponent : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPathGateComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPathGateComponent() { }

    /// <summary>
    /// Constructs a new RPathGateComponent
    /// </summary>
    public RPathGateComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPathGateComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPathGateComponent(nint ptr) : base(ptr) { }

}
