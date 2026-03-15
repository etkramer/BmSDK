#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_JokerBoxBataranged<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_JokerBoxBataranged : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_JokerBoxBataranged", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_JokerBoxBataranged() { }

    /// <summary>
    /// Constructs a new RSeqEvent_JokerBoxBataranged
    /// </summary>
    public RSeqEvent_JokerBoxBataranged(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_JokerBoxBataranged Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_JokerBoxBataranged(nint ptr) : base(ptr) { }

}
