#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: LinkerLoad<br/>
/// (size = 2040)
/// (flags = 268435592)
/// </summary>
public partial class LinkerLoad : BmSDK.Linker, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.LinkerLoad", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LinkerLoad() { }

    /// <summary>
    /// Constructs a new LinkerLoad
    /// </summary>
    public LinkerLoad(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LinkerLoad Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LinkerLoad(nint ptr) : base(ptr) { }

}
