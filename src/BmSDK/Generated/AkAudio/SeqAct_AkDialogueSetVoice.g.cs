#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkDialogueSetVoice<br/>
/// (flags = 0)
/// </summary>
public partial class SeqAct_AkDialogueSetVoice : BmSDK.AkAudio.SeqAct_AkBaseSimple, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkDialogueSetVoice", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkDialogueSetVoice() { }

    /// <summary>
    /// Constructs a new SeqAct_AkDialogueSetVoice
    /// </summary>
    public SeqAct_AkDialogueSetVoice(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkDialogueSetVoice Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkDialogueSetVoice(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Speakers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> Speakers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: Voice
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueVoice Voice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueVoice>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
}
