#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Interface_NavigationHandle<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class Interface_NavigationHandle : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Interface_NavigationHandle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Interface_NavigationHandle() { }

    /// <summary>
    /// Constructs a new Interface_NavigationHandle
    /// </summary>
    public Interface_NavigationHandle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Interface_NavigationHandle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Interface_NavigationHandle(nint ptr) : base(ptr) { }

}
