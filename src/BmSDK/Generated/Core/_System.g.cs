#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: _System<br/>
/// (size = 260)
/// (flags = 268435596)
/// </summary>
public partial class _System : BmSDK.Subsystem, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.System", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal _System() { }

    /// <summary>
    /// Constructs a new _System
    /// </summary>
    public _System(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, _System Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected _System(nint ptr) : base(ptr) { }

}
