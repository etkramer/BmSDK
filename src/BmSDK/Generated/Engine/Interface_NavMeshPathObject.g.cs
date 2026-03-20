#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Interface_NavMeshPathObject<br/>
/// (flags = 0)
/// </summary>
public partial class Interface_NavMeshPathObject : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Interface_NavMeshPathObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Interface_NavMeshPathObject() { }

    /// <summary>
    /// Constructs a new Interface_NavMeshPathObject
    /// </summary>
    public Interface_NavMeshPathObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Interface_NavMeshPathObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Interface_NavMeshPathObject(nint ptr) : base(ptr) { }

}
