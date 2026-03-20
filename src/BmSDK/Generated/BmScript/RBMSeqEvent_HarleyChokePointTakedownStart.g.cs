#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMSeqEvent_HarleyChokePointTakedownStart<br/>
/// (size = 380)
/// (flags = 18)
/// </summary>
public partial class RBMSeqEvent_HarleyChokePointTakedownStart : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMSeqEvent_HarleyChokePointTakedownStart", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMSeqEvent_HarleyChokePointTakedownStart() { }

    /// <summary>
    /// Constructs a new RBMSeqEvent_HarleyChokePointTakedownStart
    /// </summary>
    public RBMSeqEvent_HarleyChokePointTakedownStart(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMSeqEvent_HarleyChokePointTakedownStart Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMSeqEvent_HarleyChokePointTakedownStart(nint ptr) : base(ptr) { }

}
