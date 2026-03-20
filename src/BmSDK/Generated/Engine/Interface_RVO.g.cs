#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Interface_RVO<br/>
/// (flags = 0)
/// </summary>
public partial class Interface_RVO : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Interface_RVO", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Interface_RVO() { }

    /// <summary>
    /// Constructs a new Interface_RVO
    /// </summary>
    public Interface_RVO(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Interface_RVO Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Interface_RVO(nint ptr) : base(ptr) { }

}
