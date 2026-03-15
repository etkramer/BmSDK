#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: ObjectRedirector<br/>
/// (size = 48)
/// (flags = 268435584)
/// </summary>
public partial class ObjectRedirector : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.ObjectRedirector", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ObjectRedirector() { }

    /// <summary>
    /// Constructs a new ObjectRedirector
    /// </summary>
    public ObjectRedirector(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ObjectRedirector Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ObjectRedirector(nint ptr) : base(ptr) { }

}
