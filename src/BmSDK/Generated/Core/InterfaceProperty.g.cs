#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: InterfaceProperty<br/>
/// (flags = 0)
/// </summary>
public partial class InterfaceProperty : BmSDK.Property, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.InterfaceProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterfaceProperty() { }

    /// <summary>
    /// Constructs a new InterfaceProperty
    /// </summary>
    public InterfaceProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterfaceProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterfaceProperty(nint ptr) : base(ptr) { }

}
