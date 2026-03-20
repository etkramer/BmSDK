#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: StructProperty<br/>
/// (size = 156)
/// (flags = 0)
/// </summary>
public partial class StructProperty : BmSDK.Property, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.StructProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal StructProperty() { }

    /// <summary>
    /// Constructs a new StructProperty
    /// </summary>
    public StructProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, StructProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected StructProperty(nint ptr) : base(ptr) { }

}
