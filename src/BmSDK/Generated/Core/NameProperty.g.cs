#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: NameProperty<br/>
/// (size = 148)
/// (flags = 0)
/// </summary>
public partial class NameProperty : BmSDK.Property, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.NameProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NameProperty() { }

    /// <summary>
    /// Constructs a new NameProperty
    /// </summary>
    public NameProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NameProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NameProperty(nint ptr) : base(ptr) { }

}
