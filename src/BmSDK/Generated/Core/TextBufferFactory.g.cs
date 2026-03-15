#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: TextBufferFactory<br/>
/// (size = 96)
/// (flags = 268435592)
/// </summary>
public partial class TextBufferFactory : BmSDK.Factory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.TextBufferFactory", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TextBufferFactory() { }

    /// <summary>
    /// Constructs a new TextBufferFactory
    /// </summary>
    public TextBufferFactory(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TextBufferFactory Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TextBufferFactory(nint ptr) : base(ptr) { }

}
