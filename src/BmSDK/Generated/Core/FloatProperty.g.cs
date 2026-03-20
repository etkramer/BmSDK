#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: FloatProperty<br/>
/// (size = 148)
/// (flags = 268435584)
/// </summary>
public partial class FloatProperty : BmSDK.Property, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.FloatProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal FloatProperty() { }

    /// <summary>
    /// Constructs a new FloatProperty
    /// </summary>
    public FloatProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, FloatProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FloatProperty(nint ptr) : base(ptr) { }

}
