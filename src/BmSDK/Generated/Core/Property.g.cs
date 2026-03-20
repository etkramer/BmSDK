#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: Property<br/>
/// (flags = 0)
/// </summary>
public partial class Property : BmSDK.Field, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.Property", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Property() { }

    /// <summary>
    /// Constructs a new Property
    /// </summary>
    public Property(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Property Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Property(nint ptr) : base(ptr) { }

}
