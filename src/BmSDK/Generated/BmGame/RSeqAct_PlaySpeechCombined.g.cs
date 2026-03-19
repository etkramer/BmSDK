#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_PlaySpeechCombined<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_PlaySpeechCombined : BmSDK.BmGame.RSeqAct_PlaySpeechBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_PlaySpeechCombined", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_PlaySpeechCombined() { }

    /// <summary>
    /// Constructs a new RSeqAct_PlaySpeechCombined
    /// </summary>
    public RSeqAct_PlaySpeechCombined(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_PlaySpeechCombined Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_PlaySpeechCombined(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_AkDialogueListener
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_AkDialogueListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// StrProperty: SpeechCleanupReasonStrings
    /// </summary>
    public unsafe BmSDK.FString SpeechCleanupReasonStrings_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
    /// <summary>
    /// StrProperty: SpeechCleanupReasonStrings
    /// </summary>
    public unsafe BmSDK.FString SpeechCleanupReasonStrings_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
    /// <summary>
    /// StrProperty: SpeechCleanupReasonStrings
    /// </summary>
    public unsafe BmSDK.FString SpeechCleanupReasonStrings_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }
    /// <summary>
    /// StrProperty: SpeechCleanupReasonStrings
    /// </summary>
    public unsafe BmSDK.FString SpeechCleanupReasonStrings_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }
    /// <summary>
    /// StrProperty: SpeechCleanupReasonStrings
    /// </summary>
    public unsafe BmSDK.FString SpeechCleanupReasonStrings_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }
    /// <summary>
    /// StrProperty: SpeechCleanupReasonStrings
    /// </summary>
    public unsafe BmSDK.FString SpeechCleanupReasonStrings_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDialogueDefaultInterruptResponse
    /// </summary>
    public unsafe bool bOverrideDialogueDefaultInterruptResponse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDialogueDefaultBusyResponse
    /// </summary>
    public unsafe bool bOverrideDialogueDefaultBusyResponse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bSkippable
    /// </summary>
    public unsafe bool bSkippable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bLockBarksWhileActive
    /// </summary>
    public unsafe bool bLockBarksWhileActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bAutomaticallyAddPlayerAsSpeaker
    /// </summary>
    public unsafe bool bAutomaticallyAddPlayerAsSpeaker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForRadioMode
    /// </summary>
    public unsafe bool bWaitingForRadioMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForDialogueManager
    /// </summary>
    public unsafe bool bWaitingForDialogueManager
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bMoviePresent
    /// </summary>
    public unsafe bool bMoviePresent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: anythingConnectedToFinished
    /// </summary>
    public unsafe bool anythingConnectedToFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: anythingConnectedToBusy
    /// </summary>
    public unsafe bool anythingConnectedToBusy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bSpeechInProgress
    /// </summary>
    public unsafe bool bSpeechInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bDialogueAllowedMovieStart
    /// </summary>
    public unsafe bool bDialogueAllowedMovieStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredMovie
    /// </summary>
    public unsafe bool bTriggeredMovie
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bHasFoundSpeechSinceTriggering
    /// </summary>
    public unsafe bool bHasFoundSpeechSinceTriggering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bUseAllVideoBillboardsAsSpeaker
    /// </summary>
    public unsafe bool bUseAllVideoBillboardsAsSpeaker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bDrawMultiPointDebug
    /// </summary>
    public unsafe bool bDrawMultiPointDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bCheckedOutputLinks
    /// </summary>
    public unsafe bool bCheckedOutputLinks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bDontPlayIfAnyoneSpokeRecently
    /// </summary>
    public unsafe bool bDontPlayIfAnyoneSpokeRecently
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForSpeakersToSpawn
    /// </summary>
    public unsafe bool bWaitingForSpeakersToSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// ByteProperty: interruptResponse
    /// </summary>
    public unsafe byte interruptResponse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ByteProperty: busyResponse
    /// </summary>
    public unsafe byte busyResponse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 485); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 485); }
    }

    /// <summary>
    /// ByteProperty: playSpeechState
    /// </summary>
    public unsafe byte playSpeechState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 486); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 486); }
    }

    /// <summary>
    /// ObjectProperty: Speech
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Speech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ObjectProperty: PC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSpeaker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentSpeaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ObjectProperty: PreviousSpeaker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviousSpeaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ObjectProperty: predVolImLockingDialogueOn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT predVolImLockingDialogueOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StrProperty: MovieToPlayIfNoSpeechPresent
    /// </summary>
    public unsafe BmSDK.FString MovieToPlayIfNoSpeechPresent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// StructProperty: Options
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_PlaySpeechBase.Speakers Options
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_PlaySpeechBase.Speakers>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ArrayProperty: Speakers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> Speakers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ArrayProperty: CustomOutputLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> CustomOutputLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ArrayProperty: SpeakingActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> SpeakingActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: SilentNPCs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SilentNPCs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// IntProperty: CurrentSpeechIndex
    /// </summary>
    public unsafe int CurrentSpeechIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ArrayProperty: speakerMap
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT speakerMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// IntProperty: PlayingSpeechId
    /// </summary>
    public unsafe int PlayingSpeechId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StrProperty: DebugString
    /// </summary>
    public unsafe BmSDK.FString DebugString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: timeSinceDialogueTrigger
    /// </summary>
    public unsafe float timeSinceDialogueTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: timeSpentWaitingForNotify
    /// </summary>
    public unsafe float timeSpentWaitingForNotify
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// FloatProperty: maxNotifyWaitTime
    /// </summary>
    public unsafe float maxNotifyWaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: onStoppedFadeoutTime
    /// </summary>
    public unsafe float onStoppedFadeoutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ArrayProperty: SpeechQueue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>> SpeechQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ArrayProperty: MovieToPlayIfNoSpeechPresentQueue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> MovieToPlayIfNoSpeechPresentQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// StructProperty: multipointBillboardSpeaker
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT multipointBillboardSpeaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }
}
