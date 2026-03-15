#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMSeqEvent_PredEnd_HostageFree<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RBMSeqEvent_PredEnd_HostageFree : BmSDK.BmGame.RBMSeqEvent_BehaviourRoot, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMSeqEvent_PredEnd_HostageFree", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMSeqEvent_PredEnd_HostageFree() { }

    /// <summary>
    /// Constructs a new RBMSeqEvent_PredEnd_HostageFree
    /// </summary>
    public RBMSeqEvent_PredEnd_HostageFree(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMSeqEvent_PredEnd_HostageFree Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMSeqEvent_PredEnd_HostageFree(nint ptr) : base(ptr) { }

}
