#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: K2Node_Func_NewComp<br/>
/// (size = 84)
/// (flags = 142606482)
/// </summary>
public partial class K2Node_Func_NewComp : BmSDK.Engine.K2Node_Func, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.K2Node_Func_NewComp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal K2Node_Func_NewComp() { }

    /// <summary>
    /// Constructs a new K2Node_Func_NewComp
    /// </summary>
    public K2Node_Func_NewComp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, K2Node_Func_NewComp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected K2Node_Func_NewComp(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: ComponentTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ActorComponent ComponentTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ActorComponent>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }
}
