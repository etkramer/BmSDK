#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkMusicSync<br/>
/// (size = 384)
/// (flags = 0)
/// </summary>
public partial class SeqAct_AkMusicSync : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkMusicSync", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkMusicSync() { }

    /// <summary>
    /// Constructs a new SeqAct_AkMusicSync
    /// </summary>
    public SeqAct_AkMusicSync(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkMusicSync Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkMusicSync(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: MarkerName
    /// </summary>
    public unsafe BmSDK.FString MarkerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: WaitTimeout
    /// </summary>
    public unsafe float WaitTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// FloatProperty: WaitTime
    /// </summary>
    public unsafe float WaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// IntProperty: WaitResult
    /// </summary>
    public unsafe int WaitResult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: Waiting
    /// </summary>
    public unsafe bool Waiting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// Enum: EMusicSyncOutputs
    /// </summary>
    public enum EMusicSyncOutputs
    {
        MUSIC_SYNC_STOPPED = 0,
        MUSIC_SYNC_STARTED = 1,
        MUSIC_SYNC_BEAT = 2,
        MUSIC_SYNC_BAR = 3,
        MUSIC_SYNC_CUE = 4,
        MUSIC_SYNC_MARKER = 5,
        MUSIC_SYNC_CANCEL = 6,
        MUSIC_SYNC_TIMEOUT = 7,
        MUSIC_SYNC_MAX = 8,
    }
}
