#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: Const<br/>
/// (size = 60)
/// (flags = 268435584)
/// </summary>
public partial class Const : BmSDK.Field, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.Const", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Const() { }

    /// <summary>
    /// Constructs a new Const
    /// </summary>
    public Const(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Const Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Const(nint ptr) : base(ptr) { }

}
