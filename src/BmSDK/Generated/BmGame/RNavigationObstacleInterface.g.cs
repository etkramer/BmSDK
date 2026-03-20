#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavigationObstacleInterface<br/>
/// (flags = 0)
/// </summary>
public partial class RNavigationObstacleInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavigationObstacleInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RNavigationObstacleInterface() { }

    /// <summary>
    /// Constructs a new RNavigationObstacleInterface
    /// </summary>
    public RNavigationObstacleInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavigationObstacleInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavigationObstacleInterface(nint ptr) : base(ptr) { }

}
