#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkDialogueResetSpeechLimit<br/>
/// (size = 352)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_AkDialogueResetSpeechLimit : BmSDK.AkAudio.SeqAct_AkBaseSimple, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkDialogueResetSpeechLimit", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkDialogueResetSpeechLimit() { }

    /// <summary>
    /// Constructs a new SeqAct_AkDialogueResetSpeechLimit
    /// </summary>
    public SeqAct_AkDialogueResetSpeechLimit(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkDialogueResetSpeechLimit Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkDialogueResetSpeechLimit(nint ptr) : base(ptr) { }

}
