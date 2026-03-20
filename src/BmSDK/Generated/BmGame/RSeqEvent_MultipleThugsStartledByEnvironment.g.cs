#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_MultipleThugsStartledByEnvironment<br/>
/// (size = 380)
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_MultipleThugsStartledByEnvironment : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_MultipleThugsStartledByEnvironment", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_MultipleThugsStartledByEnvironment() { }

    /// <summary>
    /// Constructs a new RSeqEvent_MultipleThugsStartledByEnvironment
    /// </summary>
    public RSeqEvent_MultipleThugsStartledByEnvironment(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_MultipleThugsStartledByEnvironment Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_MultipleThugsStartledByEnvironment(nint ptr) : base(ptr) { }

}
