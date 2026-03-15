#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_JokerBoxOpened<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_JokerBoxOpened : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_JokerBoxOpened", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_JokerBoxOpened() { }

    /// <summary>
    /// Constructs a new RSeqEvent_JokerBoxOpened
    /// </summary>
    public RSeqEvent_JokerBoxOpened(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_JokerBoxOpened Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_JokerBoxOpened(nint ptr) : base(ptr) { }

}
