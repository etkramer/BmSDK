#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: ObjectProperty<br/>
/// (size = 156)
/// (flags = 0)
/// </summary>
public partial class ObjectProperty : BmSDK.Property, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.ObjectProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ObjectProperty() { }

    /// <summary>
    /// Constructs a new ObjectProperty
    /// </summary>
    public ObjectProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ObjectProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ObjectProperty(nint ptr) : base(ptr) { }

}
