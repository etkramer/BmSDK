#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_JackInTheBoxTakeDown<br/>
/// (size = 380)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_JackInTheBoxTakeDown : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_JackInTheBoxTakeDown", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_JackInTheBoxTakeDown() { }

    /// <summary>
    /// Constructs a new RSeqEvent_JackInTheBoxTakeDown
    /// </summary>
    public RSeqEvent_JackInTheBoxTakeDown(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_JackInTheBoxTakeDown Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_JackInTheBoxTakeDown(nint ptr) : base(ptr) { }

}
