#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: State<br/>
/// (size = 180)
/// (flags = 268435584)
/// </summary>
public partial class State : BmSDK.Struct, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.State", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal State() { }

    /// <summary>
    /// Constructs a new State
    /// </summary>
    public State(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, State Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected State(nint ptr) : base(ptr) { }

}
