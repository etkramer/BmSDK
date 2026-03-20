#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavigationMeshBase<br/>
/// (size = 848)
/// (flags = 268435584)
/// </summary>
public partial class NavigationMeshBase : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavigationMeshBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavigationMeshBase() { }

    /// <summary>
    /// Constructs a new NavigationMeshBase
    /// </summary>
    public NavigationMeshBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavigationMeshBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavigationMeshBase(nint ptr) : base(ptr) { }

}
