#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_FailsafeBatmanSeen<br/>
/// (size = 380)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_FailsafeBatmanSeen : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_FailsafeBatmanSeen", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_FailsafeBatmanSeen() { }

    /// <summary>
    /// Constructs a new RSeqEvent_FailsafeBatmanSeen
    /// </summary>
    public RSeqEvent_FailsafeBatmanSeen(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_FailsafeBatmanSeen Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_FailsafeBatmanSeen(nint ptr) : base(ptr) { }

}
