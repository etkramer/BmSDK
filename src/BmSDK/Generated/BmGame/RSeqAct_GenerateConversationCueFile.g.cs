#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_GenerateConversationCueFile<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_GenerateConversationCueFile : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_GenerateConversationCueFile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_GenerateConversationCueFile() { }

    /// <summary>
    /// Constructs a new RSeqAct_GenerateConversationCueFile
    /// </summary>
    public RSeqAct_GenerateConversationCueFile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_GenerateConversationCueFile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_GenerateConversationCueFile(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Conversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech Conversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: ConversationAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ConversationAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
}
