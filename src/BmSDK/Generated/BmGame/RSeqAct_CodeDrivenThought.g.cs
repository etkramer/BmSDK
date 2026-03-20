#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_CodeDrivenThought<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_CodeDrivenThought : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_CodeDrivenThought", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_CodeDrivenThought() { }

    /// <summary>
    /// Constructs a new RSeqAct_CodeDrivenThought
    /// </summary>
    public RSeqAct_CodeDrivenThought(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_CodeDrivenThought Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_CodeDrivenThought(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SpeechAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue SpeechAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: speechAsset
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech speechAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
}
