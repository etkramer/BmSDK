#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_ActorFactoryEx<br/>
/// (size = 300)
/// (flags = 136323218)
/// </summary>
public partial class SeqAct_ActorFactoryEx : BmSDK.Engine.SeqAct_ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_ActorFactoryEx", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_ActorFactoryEx() { }

    /// <summary>
    /// Constructs a new SeqAct_ActorFactoryEx
    /// </summary>
    public SeqAct_ActorFactoryEx(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_ActorFactoryEx Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_ActorFactoryEx(nint ptr) : base(ptr) { }

}
