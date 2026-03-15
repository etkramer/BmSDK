#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDynamicFieldProvider<br/>
/// (size = 76)
/// (flags = 134218898)
/// </summary>
public partial class UIDynamicFieldProvider : BmSDK.Engine.UIDataProvider, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDynamicFieldProvider", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIDynamicFieldProvider() { }

    /// <summary>
    /// Constructs a new UIDynamicFieldProvider
    /// </summary>
    public UIDynamicFieldProvider(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDynamicFieldProvider Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDynamicFieldProvider(nint ptr) : base(ptr) { }

}
