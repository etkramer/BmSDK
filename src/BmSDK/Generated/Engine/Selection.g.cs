#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Selection<br/>
/// (size = 128)
/// (flags = 0)
/// </summary>
public partial class Selection : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Selection", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Selection() { }

    /// <summary>
    /// Constructs a new Selection
    /// </summary>
    public Selection(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Selection Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Selection(nint ptr) : base(ptr) { }

}
