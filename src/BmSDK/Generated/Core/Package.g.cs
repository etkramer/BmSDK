#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: Package<br/>
/// (size = 244)
/// (flags = 268435584)
/// </summary>
public partial class Package : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.Package", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Package() { }

    /// <summary>
    /// Constructs a new Package
    /// </summary>
    public Package(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Package Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Package(nint ptr) : base(ptr) { }

}
