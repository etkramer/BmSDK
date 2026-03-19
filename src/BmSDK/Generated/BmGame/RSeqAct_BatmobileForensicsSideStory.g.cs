#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_BatmobileForensicsSideStory<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_BatmobileForensicsSideStory : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_BatmobileForensicsSideStory", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_BatmobileForensicsSideStory() { }

    /// <summary>
    /// Constructs a new RSeqAct_BatmobileForensicsSideStory
    /// </summary>
    public RSeqAct_BatmobileForensicsSideStory(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_BatmobileForensicsSideStory Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_BatmobileForensicsSideStory(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: CanBeActivatedIfThisFlagIsTrue
    /// </summary>
    public unsafe BmSDK.FString CanBeActivatedIfThisFlagIsTrue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: TrailNameForPdata
    /// </summary>
    public unsafe BmSDK.FString TrailNameForPdata
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ObjectProperty: StartPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: FinishPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FinishPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ObjectProperty: ForensicsScanParticle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ForensicsScanParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: ForensicsScanSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ForensicsScanSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ArrayProperty: TrailNodesUnsorted
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> TrailNodesUnsorted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ArrayProperty: TrailNodesSorted
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> TrailNodesSorted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: bIsEngaged
    /// </summary>
    public unsafe bool bIsEngaged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 456); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenCompleted
    /// </summary>
    public unsafe bool bHasBeenCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 456); }
    }

    /// <summary>
    /// BoolProperty: bFinishPointHasBeenCleared
    /// </summary>
    public unsafe bool bFinishPointHasBeenCleared
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 456); }
    }

    /// <summary>
    /// BoolProperty: CurrentlyInBatmobile
    /// </summary>
    public unsafe bool CurrentlyInBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 456); }
    }

    /// <summary>
    /// FloatProperty: CurrentDisplayIndex
    /// </summary>
    public unsafe float CurrentDisplayIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// FloatProperty: CurrentDisplayIndexInternal
    /// </summary>
    public unsafe float CurrentDisplayIndexInternal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// FloatProperty: TargetDisplayIndex
    /// </summary>
    public unsafe float TargetDisplayIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// FloatProperty: SecondsUntilDecay
    /// </summary>
    public unsafe float SecondsUntilDecay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// FloatProperty: SecondsBeforeDecay
    /// </summary>
    public unsafe float SecondsBeforeDecay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// FloatProperty: SecondsUntilAdvanceDisplay
    /// </summary>
    public unsafe float SecondsUntilAdvanceDisplay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: PulseRange
    /// </summary>
    public unsafe float PulseRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// FloatProperty: PulseConeHalfWidthRadians
    /// </summary>
    public unsafe float PulseConeHalfWidthRadians
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: RevealRateWhenDiscoveringNew
    /// </summary>
    public unsafe float RevealRateWhenDiscoveringNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// FloatProperty: DisappearRateWhenTimingOut
    /// </summary>
    public unsafe float DisappearRateWhenTimingOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// FloatProperty: DisappearRateWhenComplete
    /// </summary>
    public unsafe float DisappearRateWhenComplete
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// FloatProperty: Cos_PulseConeHalfWidthRadians
    /// </summary>
    public unsafe float Cos_PulseConeHalfWidthRadians
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: PulseRangeSquared
    /// </summary>
    public unsafe float PulseRangeSquared
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// StructProperty: PulseTempSource
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PulseTempSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// StructProperty: PulseTempAngle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PulseTempAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// IntProperty: TrailLength
    /// </summary>
    public unsafe int TrailLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// StructProperty: DebugLineTestVector
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugLineTestVector
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: LineofSightThresholdCentimetres
    /// </summary>
    public unsafe float LineofSightThresholdCentimetres
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// FloatProperty: LineofSightThresholdCentimetresSquared
    /// </summary>
    public unsafe float LineofSightThresholdCentimetresSquared
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }
}
