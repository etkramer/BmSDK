#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: DelegateProperty<br/>
/// (size = 164)
/// (flags = 268435584)
/// </summary>
public partial class DelegateProperty : BmSDK.Property, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.DelegateProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DelegateProperty() { }

    /// <summary>
    /// Constructs a new DelegateProperty
    /// </summary>
    public DelegateProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DelegateProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DelegateProperty(nint ptr) : base(ptr) { }

}
