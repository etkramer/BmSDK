#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMSeqEvent_BehaviourRoot<br/>
/// (size = 380)
/// (flags = 0)
/// </summary>
public partial class RBMSeqEvent_BehaviourRoot : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMSeqEvent_BehaviourRoot", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMSeqEvent_BehaviourRoot() { }

    /// <summary>
    /// Constructs a new RBMSeqEvent_BehaviourRoot
    /// </summary>
    public RBMSeqEvent_BehaviourRoot(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMSeqEvent_BehaviourRoot Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMSeqEvent_BehaviourRoot(nint ptr) : base(ptr) { }

}
