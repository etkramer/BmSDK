#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: ByteProperty<br/>
/// (size = 156)
/// (flags = 0)
/// </summary>
public partial class ByteProperty : BmSDK.Property, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.ByteProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ByteProperty() { }

    /// <summary>
    /// Constructs a new ByteProperty
    /// </summary>
    public ByteProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ByteProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ByteProperty(nint ptr) : base(ptr) { }

}
