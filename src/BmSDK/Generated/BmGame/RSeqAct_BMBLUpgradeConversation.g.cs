#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_BMBLUpgradeConversation<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_BMBLUpgradeConversation : BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_BMBLUpgradeConversation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_BMBLUpgradeConversation() { }

    /// <summary>
    /// Constructs a new RSeqAct_BMBLUpgradeConversation
    /// </summary>
    public RSeqAct_BMBLUpgradeConversation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_BMBLUpgradeConversation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_BMBLUpgradeConversation(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: introConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech introConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ObjectProperty: outroConversations
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech outroConversations_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }
    /// <summary>
    /// ObjectProperty: outroConversations
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech outroConversations_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }
    /// <summary>
    /// ObjectProperty: outroConversations
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech outroConversations_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }
    /// <summary>
    /// ObjectProperty: outroConversations
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech outroConversations_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ByteProperty: upgradeConvState
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_BMBLUpgradeConversation.eBMBLUpgradeConvState upgradeConvState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_BMBLUpgradeConversation.eBMBLUpgradeConvState>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }
}
