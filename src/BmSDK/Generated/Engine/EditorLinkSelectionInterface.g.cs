#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: EditorLinkSelectionInterface<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class EditorLinkSelectionInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.EditorLinkSelectionInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal EditorLinkSelectionInterface() { }

    /// <summary>
    /// Constructs a new EditorLinkSelectionInterface
    /// </summary>
    public EditorLinkSelectionInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, EditorLinkSelectionInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected EditorLinkSelectionInterface(nint ptr) : base(ptr) { }

}
