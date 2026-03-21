#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: ClassProperty<br/>
/// (size = 96)
/// (flags = 268435584)
/// </summary>
public partial class ClassProperty : BmSDK.ObjectProperty, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.ClassProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ClassProperty() { }

    /// <summary>
    /// Constructs a new ClassProperty
    /// </summary>
    public ClassProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ClassProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ClassProperty(nint ptr) : base(ptr) { }

}
