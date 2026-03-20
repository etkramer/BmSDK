#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_PlayNPCDialogue<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_PlayNPCDialogue : BmSDK.BmGame.RSeqAct_PlaySpeechBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_PlayNPCDialogue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_PlayNPCDialogue() { }

    /// <summary>
    /// Constructs a new RSeqAct_PlayNPCDialogue
    /// </summary>
    public RSeqAct_PlayNPCDialogue(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_PlayNPCDialogue Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_PlayNPCDialogue(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bUseAiming
    /// </summary>
    public unsafe bool bUseAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 828); }
    }

    /// <summary>
    /// BoolProperty: bOutputCurrentSpeaker
    /// </summary>
    public unsafe bool bOutputCurrentSpeaker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 828); }
    }

    /// <summary>
    /// BoolProperty: bDontPlayInCinematicMode
    /// </summary>
    public unsafe bool bDontPlayInCinematicMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 828); }
    }

    /// <summary>
    /// BoolProperty: bAutoRetryIfSpeakersNotSpawnedYet
    /// </summary>
    public unsafe bool bAutoRetryIfSpeakersNotSpawnedYet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 828); }
    }
}
