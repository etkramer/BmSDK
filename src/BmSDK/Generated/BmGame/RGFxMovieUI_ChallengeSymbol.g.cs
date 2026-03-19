#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_ChallengeSymbol<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_ChallengeSymbol : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_ChallengeSymbol", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_ChallengeSymbol() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_ChallengeSymbol
    /// </summary>
    public RGFxMovieUI_ChallengeSymbol(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_ChallengeSymbol Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_ChallengeSymbol(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: CMan
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: ActivePopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ActivePopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: AssociatedActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AssociatedActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: ChallengeID
    /// </summary>
    public unsafe int ChallengeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// IntProperty: LocalScore
    /// </summary>
    public unsafe int LocalScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// IntProperty: LocalMedals
    /// </summary>
    public unsafe int LocalMedals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// IntProperty: LocalRivals
    /// </summary>
    public unsafe int LocalRivals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// IntProperty: CurrentScore
    /// </summary>
    public unsafe int CurrentScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// IntProperty: CurrentMedals
    /// </summary>
    public unsafe int CurrentMedals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// IntProperty: CurrentRivals
    /// </summary>
    public unsafe int CurrentRivals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: NewBest
    /// </summary>
    public unsafe bool NewBest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: ChallengeFailed
    /// </summary>
    public unsafe bool ChallengeFailed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bRequestedData
    /// </summary>
    public unsafe bool bRequestedData
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// ByteProperty: Mode
    /// </summary>
    public unsafe byte Mode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ByteProperty: ChallengeScreenMode
    /// </summary>
    public unsafe byte ChallengeScreenMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1129); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1129); }
    }

    /// <summary>
    /// IntProperty: LB_Offset
    /// </summary>
    public unsafe int LB_Offset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// StrProperty: CustomDebriefMessage
    /// </summary>
    public unsafe BmSDK.FString CustomDebriefMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// Enum: LBMode
    /// </summary>
    public enum LBMode
    {
        LBMode_Friends = 0,
        LBMode_Ranked = 1,
        LBMode_Top100 = 2,
        LBMode_MAX = 3,
    }
}
