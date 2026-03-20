#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_ChallengeSelect<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_ChallengeSelect : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_ChallengeSelect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_ChallengeSelect() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_ChallengeSelect
    /// </summary>
    public RGFxMovieUI_ChallengeSelect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_ChallengeSelect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_ChallengeSelect(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: m_sMoviePath
    /// </summary>
    public unsafe BmSDK.FString m_sMoviePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StrProperty: m_sOverridePlayers
    /// </summary>
    public unsafe BmSDK.FString m_sOverridePlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// StrProperty: m_sOverrideBatmobiles
    /// </summary>
    public unsafe BmSDK.FString m_sOverrideBatmobiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ByteProperty: m_eLeaderboardFetchType
    /// </summary>
    public unsafe BmSDK.Engine.UIDataStore_OnlineStats.EStatsFetchType m_eLeaderboardFetchType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataStore_OnlineStats.EStatsFetchType>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// IntProperty: m_nLeaderboardChallengeId
    /// </summary>
    public unsafe int m_nLeaderboardChallengeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// IntProperty: m_nLeaderboardId
    /// </summary>
    public unsafe int m_nLeaderboardId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bBeatenByActive
    /// </summary>
    public unsafe bool bBeatenByActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bRePollingLeaderboard
    /// </summary>
    public unsafe bool bRePollingLeaderboard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bSaveOptions
    /// </summary>
    public unsafe bool bSaveOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bAllowCharacterFilter
    /// </summary>
    public unsafe bool bAllowCharacterFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bExtremeModeToggle
    /// </summary>
    public unsafe bool bExtremeModeToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bLastFetchEmpty
    /// </summary>
    public unsafe bool bLastFetchEmpty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// Enum: CSLBMode
    /// </summary>
    public enum CSLBMode
    {
        CSLBMode_Friends = 0,
        CSLBMode_Ranked = 1,
        CSLBMode_Top100 = 2,
        CSLBMode_MAX = 3,
    }
}
