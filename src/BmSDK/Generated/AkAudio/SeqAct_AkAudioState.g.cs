#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkAudioState<br/>
/// (size = 208)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_AkAudioState : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkAudioState", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkAudioState() { }

    /// <summary>
    /// Constructs a new SeqAct_AkAudioState
    /// </summary>
    public SeqAct_AkAudioState(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkAudioState Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkAudioState(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: StateName
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName StateName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
}
