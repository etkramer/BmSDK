#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: StrProperty<br/>
/// (size = 148)
/// (flags = 0)
/// </summary>
public partial class StrProperty : BmSDK.Property, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.StrProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal StrProperty() { }

    /// <summary>
    /// Constructs a new StrProperty
    /// </summary>
    public StrProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, StrProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected StrProperty(nint ptr) : base(ptr) { }

}
