#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_SideStory_Update<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SideStory_Update : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_SideStory_Update", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SideStory_Update() { }

    /// <summary>
    /// Constructs a new RSeqAct_SideStory_Update
    /// </summary>
    public RSeqAct_SideStory_Update(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SideStory_Update Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SideStory_Update(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: SideStoryName
    /// </summary>
    public unsafe BmSDK.FString SideStoryName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bAllowAddIfNew
    /// </summary>
    public unsafe bool bAllowAddIfNew
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: bAddToPercent
    /// </summary>
    public unsafe bool bAddToPercent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// IntProperty: Percentage
    /// </summary>
    public unsafe int Percentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// IntProperty: Optional_VariableProgressionThreshold
    /// </summary>
    public unsafe int Optional_VariableProgressionThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// IntProperty: PercentageGainedWhenBelowThreshold
    /// </summary>
    public unsafe int PercentageGainedWhenBelowThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// IntProperty: PercentageGainedFromThresholdOnwards
    /// </summary>
    public unsafe int PercentageGainedFromThresholdOnwards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: SynopsisTextId
    /// </summary>
    public unsafe int SynopsisTextId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// IntProperty: ProgressTextId
    /// </summary>
    public unsafe int ProgressTextId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ByteProperty: bLocked
    /// </summary>
    public unsafe byte bLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ByteProperty: bIdentityUnknown
    /// </summary>
    public unsafe byte bIdentityUnknown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 397); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 397); }
    }

    /// <summary>
    /// StrProperty: VideoProgressName
    /// </summary>
    public unsafe BmSDK.FString VideoProgressName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StrProperty: JokerVideoProgressName
    /// </summary>
    public unsafe BmSDK.FString JokerVideoProgressName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// IntProperty: BoardTitleId
    /// </summary>
    public unsafe int BoardTitleId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// IntProperty: BoardSynopsisId
    /// </summary>
    public unsafe int BoardSynopsisId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// IntProperty: BoardImageId
    /// </summary>
    public unsafe int BoardImageId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// IntProperty: BoardTickerId
    /// </summary>
    public unsafe int BoardTickerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// StrProperty: WaynetechMessageTitle
    /// </summary>
    public unsafe BmSDK.FString WaynetechMessageTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// StrProperty: WaynetechMessagePrefix
    /// </summary>
    public unsafe BmSDK.FString WaynetechMessagePrefix
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// StrProperty: WaynetechMessagePrefixMultiple
    /// </summary>
    public unsafe BmSDK.FString WaynetechMessagePrefixMultiple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// StrProperty: WaynetechPromptString
    /// </summary>
    public unsafe BmSDK.FString WaynetechPromptString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// Enum: SS_TriBool
    /// </summary>
    public enum SS_TriBool
    {
        SS_TB_Ignore = 0,
        SS_TB_False = 1,
        SS_TB_True = 2,
        SS_TB_MAX = 3,
    }
}
