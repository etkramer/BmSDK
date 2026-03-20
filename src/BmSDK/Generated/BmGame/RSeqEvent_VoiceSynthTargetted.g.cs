#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_VoiceSynthTargetted<br/>
/// (size = 380)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_VoiceSynthTargetted : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_VoiceSynthTargetted", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_VoiceSynthTargetted() { }

    /// <summary>
    /// Constructs a new RSeqEvent_VoiceSynthTargetted
    /// </summary>
    public RSeqEvent_VoiceSynthTargetted(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_VoiceSynthTargetted Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_VoiceSynthTargetted(nint ptr) : base(ptr) { }

}
