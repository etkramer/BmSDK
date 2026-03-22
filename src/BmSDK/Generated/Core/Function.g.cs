#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: Function<br/>
/// (size = 140)
/// (flags = 268435584)
/// </summary>
public partial class Function : BmSDK.Struct, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.Function", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Function() { }

    /// <summary>
    /// Constructs a new Function
    /// </summary>
    public Function(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Function Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Function(nint ptr) : base(ptr) { }

}
