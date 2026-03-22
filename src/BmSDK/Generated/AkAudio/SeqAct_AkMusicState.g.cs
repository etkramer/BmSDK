#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkMusicState<br/>
/// (size = 216)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_AkMusicState : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkMusicState", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkMusicState() { }

    /// <summary>
    /// Constructs a new SeqAct_AkMusicState
    /// </summary>
    public SeqAct_AkMusicState(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkMusicState Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkMusicState(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: MusicStateNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkStateName> MusicStateNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkStateName>>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
}
