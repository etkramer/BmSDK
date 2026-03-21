#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: ArrayProperty<br/>
/// (size = 92)
/// (flags = 268435584)
/// </summary>
public partial class ArrayProperty : BmSDK.Property, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.ArrayProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ArrayProperty() { }

    /// <summary>
    /// Constructs a new ArrayProperty
    /// </summary>
    public ArrayProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ArrayProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ArrayProperty(nint ptr) : base(ptr) { }

}
