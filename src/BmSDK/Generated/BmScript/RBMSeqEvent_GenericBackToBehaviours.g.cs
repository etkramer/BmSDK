#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMSeqEvent_GenericBackToBehaviours<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RBMSeqEvent_GenericBackToBehaviours : BmSDK.BmGame.RBMSeqEvent_BehaviourRoot, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMSeqEvent_GenericBackToBehaviours", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMSeqEvent_GenericBackToBehaviours() { }

    /// <summary>
    /// Constructs a new RBMSeqEvent_GenericBackToBehaviours
    /// </summary>
    public RBMSeqEvent_GenericBackToBehaviours(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMSeqEvent_GenericBackToBehaviours Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMSeqEvent_GenericBackToBehaviours(nint ptr) : base(ptr) { }

}
