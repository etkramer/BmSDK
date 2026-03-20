#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_BatmobileRiddlerButton<br/>
/// (size = 380)
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_BatmobileRiddlerButton : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_BatmobileRiddlerButton", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_BatmobileRiddlerButton() { }

    /// <summary>
    /// Constructs a new RSeqEvent_BatmobileRiddlerButton
    /// </summary>
    public RSeqEvent_BatmobileRiddlerButton(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_BatmobileRiddlerButton Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_BatmobileRiddlerButton(nint ptr) : base(ptr) { }

}
