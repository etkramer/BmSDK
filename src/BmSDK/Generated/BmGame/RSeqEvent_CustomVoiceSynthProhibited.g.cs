#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_CustomVoiceSynthProhibited<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_CustomVoiceSynthProhibited : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_CustomVoiceSynthProhibited", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_CustomVoiceSynthProhibited() { }

    /// <summary>
    /// Constructs a new RSeqEvent_CustomVoiceSynthProhibited
    /// </summary>
    public RSeqEvent_CustomVoiceSynthProhibited(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_CustomVoiceSynthProhibited Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_CustomVoiceSynthProhibited(nint ptr) : base(ptr) { }

}
