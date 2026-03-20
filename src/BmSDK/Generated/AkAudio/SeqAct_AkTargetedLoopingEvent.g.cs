#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkTargetedLoopingEvent<br/>
/// (flags = 0)
/// </summary>
public partial class SeqAct_AkTargetedLoopingEvent : BmSDK.AkAudio.SeqAct_AkBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkTargetedLoopingEvent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkTargetedLoopingEvent() { }

    /// <summary>
    /// Constructs a new SeqAct_AkTargetedLoopingEvent
    /// </summary>
    public SeqAct_AkTargetedLoopingEvent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkTargetedLoopingEvent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkTargetedLoopingEvent(nint ptr) : base(ptr) { }

}
