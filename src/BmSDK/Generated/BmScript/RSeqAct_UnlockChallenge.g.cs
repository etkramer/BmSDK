#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_UnlockChallenge<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_UnlockChallenge : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_UnlockChallenge", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_UnlockChallenge() { }

    /// <summary>
    /// Constructs a new RSeqAct_UnlockChallenge
    /// </summary>
    public RSeqAct_UnlockChallenge(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_UnlockChallenge Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_UnlockChallenge(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: ChallengeAction
    /// </summary>
    public unsafe byte ChallengeAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ChallengeIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// BoolProperty: MessageThePlayer
    /// </summary>
    public unsafe bool MessageThePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// BoolProperty: EnablePrerequisite
    /// </summary>
    public unsafe bool EnablePrerequisite
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// IntProperty: MaxMessageCount
    /// </summary>
    public unsafe int MaxMessageCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// IntProperty: DisplaySeconds
    /// </summary>
    public unsafe int DisplaySeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// IntProperty: NumChallengesRevealed
    /// </summary>
    public unsafe int NumChallengesRevealed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// StrProperty: ChallengeGroup
    /// </summary>
    public unsafe BmSDK.FString ChallengeGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// StrProperty: ChallengeGroupCached
    /// </summary>
    public unsafe BmSDK.FString ChallengeGroupCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// IntProperty: SingleChallengeRevealedId
    /// </summary>
    public unsafe int SingleChallengeRevealedId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// Enum: UnlockChallengeAction
    /// </summary>
    public enum UnlockChallengeAction
    {
        UCA_Reveal = 0,
        UCA_Unlock = 1,
        UCA_RevealAndUnlock = 2,
        UCA_Hide = 3,
        UCA_Lock = 4,
        UCA_HideAndLock = 5,
        UCA_MAX = 6,
    }
}
