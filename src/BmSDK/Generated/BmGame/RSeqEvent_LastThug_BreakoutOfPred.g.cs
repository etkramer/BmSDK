#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_LastThug_BreakoutOfPred<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_LastThug_BreakoutOfPred : BmSDK.BmGame.RBMSeqEvent_BehaviourRoot, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_LastThug_BreakoutOfPred", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_LastThug_BreakoutOfPred() { }

    /// <summary>
    /// Constructs a new RSeqEvent_LastThug_BreakoutOfPred
    /// </summary>
    public RSeqEvent_LastThug_BreakoutOfPred(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_LastThug_BreakoutOfPred Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_LastThug_BreakoutOfPred(nint ptr) : base(ptr) { }

}
