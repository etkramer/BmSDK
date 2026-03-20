#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkDialogueSetSpeechLimit<br/>
/// (size = 356)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_AkDialogueSetSpeechLimit : BmSDK.AkAudio.SeqAct_AkBaseSimple, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkDialogueSetSpeechLimit", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkDialogueSetSpeechLimit() { }

    /// <summary>
    /// Constructs a new SeqAct_AkDialogueSetSpeechLimit
    /// </summary>
    public SeqAct_AkDialogueSetSpeechLimit(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkDialogueSetSpeechLimit Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkDialogueSetSpeechLimit(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: MaxSimultaneousSpeechInstances
    /// </summary>
    public unsafe int MaxSimultaneousSpeechInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
