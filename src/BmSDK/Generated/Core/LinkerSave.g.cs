#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: LinkerSave<br/>
/// (flags = 0)
/// </summary>
public partial class LinkerSave : BmSDK.Linker, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.LinkerSave", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LinkerSave() { }

    /// <summary>
    /// Constructs a new LinkerSave
    /// </summary>
    public LinkerSave(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LinkerSave Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LinkerSave(nint ptr) : base(ptr) { }

}
