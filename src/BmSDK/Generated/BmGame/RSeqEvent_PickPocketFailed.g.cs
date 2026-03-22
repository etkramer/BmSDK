#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_PickPocketFailed<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_PickPocketFailed : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_PickPocketFailed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_PickPocketFailed() { }

    /// <summary>
    /// Constructs a new RSeqEvent_PickPocketFailed
    /// </summary>
    public RSeqEvent_PickPocketFailed(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_PickPocketFailed Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_PickPocketFailed(nint ptr) : base(ptr) { }

}
