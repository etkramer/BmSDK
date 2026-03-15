#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: Linker<br/>
/// (size = 324)
/// (flags = 268435592)
/// </summary>
public partial class Linker : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.Linker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Linker() { }

    /// <summary>
    /// Constructs a new Linker
    /// </summary>
    public Linker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Linker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Linker(nint ptr) : base(ptr) { }

}
