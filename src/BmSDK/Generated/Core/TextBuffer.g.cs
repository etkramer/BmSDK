#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: TextBuffer<br/>
/// (size = 72)
/// (flags = 268435584)
/// </summary>
public partial class TextBuffer : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.TextBuffer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TextBuffer() { }

    /// <summary>
    /// Constructs a new TextBuffer
    /// </summary>
    public TextBuffer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TextBuffer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TextBuffer(nint ptr) : base(ptr) { }

}
