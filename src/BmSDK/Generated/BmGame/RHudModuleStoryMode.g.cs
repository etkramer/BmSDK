#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleStoryMode<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHudModuleStoryMode : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleStoryMode", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleStoryMode() { }

    /// <summary>
    /// Constructs a new RHudModuleStoryMode
    /// </summary>
    public RHudModuleStoryMode(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleStoryMode Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleStoryMode(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: CachedFunction_ClearPrompts
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ClearPrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_BatchAddPrompts
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_BatchAddPrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetClockTimer
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetClockTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_PauseClockTimer
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_PauseClockTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_OffsetClockTimer
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_OffsetClockTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ClockTimerExpired
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ClockTimerExpired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetInfoText
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetInfoText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetZoomMode
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetZoomMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ShowRiddle
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ShowRiddle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetWarningMessage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetWarningMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetWarningBar
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetWarningBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCommandBeaconCharge
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCommandBeaconCharge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetLapCount
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetLapCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_ToggleLapCount
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_ToggleLapCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetIntelVisible
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetIntelVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_QueueDiscovery
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_QueueDiscovery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetThreatLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetThreatLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideThreatLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideThreatLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// StrProperty: Cached_ShowExplosiveGelCount
    /// </summary>
    public unsafe BmSDK.FString Cached_ShowExplosiveGelCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetGenericHudMessage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetGenericHudMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// IntProperty: ExplosiveGelCount
    /// </summary>
    public unsafe int ExplosiveGelCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// StrProperty: CurrentWarningMessage
    /// </summary>
    public unsafe BmSDK.FString CurrentWarningMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: CurrentBarValue
    /// </summary>
    public unsafe float CurrentBarValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: CurrentPercentage
    /// </summary>
    public unsafe float CurrentPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// IntProperty: CurrentLap
    /// </summary>
    public unsafe int CurrentLap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: lapCountOn
    /// </summary>
    public unsafe bool lapCountOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: ThreatLevelDirty
    /// </summary>
    public unsafe bool ThreatLevelDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: RequestHideThreatLevel
    /// </summary>
    public unsafe bool RequestHideThreatLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: CachedThreat_bBatmobileAvailable
    /// </summary>
    public unsafe bool CachedThreat_bBatmobileAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: CachedThreat_bTutorialMode
    /// </summary>
    public unsafe bool CachedThreat_bTutorialMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: ThreatLevelVisible
    /// </summary>
    public unsafe bool ThreatLevelVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: SurveillanceSuppressedByThreatLevel
    /// </summary>
    public unsafe bool SurveillanceSuppressedByThreatLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: IntelSystemSuppressed
    /// </summary>
    public unsafe bool IntelSystemSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: IntelSystemVisuallySuppressed
    /// </summary>
    public unsafe bool IntelSystemVisuallySuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: StandardIntelAvailable
    /// </summary>
    public unsafe bool StandardIntelAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: PenguinIntelAvailable
    /// </summary>
    public unsafe bool PenguinIntelAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: ApcIntelAvailable
    /// </summary>
    public unsafe bool ApcIntelAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: HudIntelVisible
    /// </summary>
    public unsafe bool HudIntelVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: IntelRequested
    /// </summary>
    public unsafe bool IntelRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: bThreatLevelActuallyOnscreen
    /// </summary>
    public unsafe bool bThreatLevelActuallyOnscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: bExclusivePromptsMode
    /// </summary>
    public unsafe bool bExclusivePromptsMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: bIsZoomed
    /// </summary>
    public unsafe bool bIsZoomed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: PromptsMightBeDirty
    /// </summary>
    public unsafe bool PromptsMightBeDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// StrProperty: CachedThreat_sCityName
    /// </summary>
    public unsafe BmSDK.FString CachedThreat_sCityName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// StrProperty: CachedThreat_sThreats
    /// </summary>
    public unsafe BmSDK.FString CachedThreat_sThreats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// IntProperty: ThreatLevelNumIcons
    /// </summary>
    public unsafe int ThreatLevelNumIcons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: IntelRequestCountdown
    /// </summary>
    public unsafe float IntelRequestCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// StrProperty: CurrentBatchPromptsString
    /// </summary>
    public unsafe BmSDK.FString CurrentBatchPromptsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// StrProperty: PendingBatchPromptsString
    /// </summary>
    public unsafe BmSDK.FString PendingBatchPromptsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// StrProperty: GenericHudMessage
    /// </summary>
    public unsafe BmSDK.FString GenericHudMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StrProperty: LastThingToSetPrompts
    /// </summary>
    public unsafe BmSDK.FString LastThingToSetPrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }
}
