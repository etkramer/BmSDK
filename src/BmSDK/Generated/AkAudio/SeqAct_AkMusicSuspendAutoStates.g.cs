#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkMusicSuspendAutoStates<br/>
/// (size = 352)
/// (flags = 33562642)
/// </summary>
public partial class SeqAct_AkMusicSuspendAutoStates : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkMusicSuspendAutoStates", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkMusicSuspendAutoStates() { }

    /// <summary>
    /// Constructs a new SeqAct_AkMusicSuspendAutoStates
    /// </summary>
    public SeqAct_AkMusicSuspendAutoStates(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkMusicSuspendAutoStates Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkMusicSuspendAutoStates(nint ptr) : base(ptr) { }

}
