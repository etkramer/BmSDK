#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMSeqEvent_DualTakedownStateChange<br/>
/// (flags = 0)
/// </summary>
public partial class RBMSeqEvent_DualTakedownStateChange : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMSeqEvent_DualTakedownStateChange", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMSeqEvent_DualTakedownStateChange() { }

    /// <summary>
    /// Constructs a new RBMSeqEvent_DualTakedownStateChange
    /// </summary>
    public RBMSeqEvent_DualTakedownStateChange(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMSeqEvent_DualTakedownStateChange Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMSeqEvent_DualTakedownStateChange(nint ptr) : base(ptr) { }

}
