#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: MapProperty<br/>
/// (flags = 0)
/// </summary>
public partial class MapProperty : BmSDK.Property, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.MapProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MapProperty() { }

    /// <summary>
    /// Constructs a new MapProperty
    /// </summary>
    public MapProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MapProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MapProperty(nint ptr) : base(ptr) { }

}
