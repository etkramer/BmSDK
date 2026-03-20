#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_JackBombedWhileSnared<br/>
/// (size = 380)
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_JackBombedWhileSnared : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_JackBombedWhileSnared", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_JackBombedWhileSnared() { }

    /// <summary>
    /// Constructs a new RSeqEvent_JackBombedWhileSnared
    /// </summary>
    public RSeqEvent_JackBombedWhileSnared(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_JackBombedWhileSnared Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_JackBombedWhileSnared(nint ptr) : base(ptr) { }

}
