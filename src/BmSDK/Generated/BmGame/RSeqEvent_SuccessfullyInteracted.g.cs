#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_SuccessfullyInteracted<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_SuccessfullyInteracted : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_SuccessfullyInteracted", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_SuccessfullyInteracted() { }

    /// <summary>
    /// Constructs a new RSeqEvent_SuccessfullyInteracted
    /// </summary>
    public RSeqEvent_SuccessfullyInteracted(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_SuccessfullyInteracted Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_SuccessfullyInteracted(nint ptr) : base(ptr) { }

}
