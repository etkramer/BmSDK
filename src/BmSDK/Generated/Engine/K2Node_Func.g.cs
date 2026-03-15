#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: K2Node_Func<br/>
/// (size = 80)
/// (flags = 134217874)
/// </summary>
public partial class K2Node_Func : BmSDK.Engine.K2Node_FuncBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.K2Node_Func", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal K2Node_Func() { }

    /// <summary>
    /// Constructs a new K2Node_Func
    /// </summary>
    public K2Node_Func(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, K2Node_Func Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected K2Node_Func(nint ptr) : base(ptr) { }

}
