#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_PlayRadioOrThoughtDialogue<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_PlayRadioOrThoughtDialogue : BmSDK.BmGame.RSeqAct_PlaySpeechBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_PlayRadioOrThoughtDialogue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_PlayRadioOrThoughtDialogue() { }

    /// <summary>
    /// Constructs a new RSeqAct_PlayRadioOrThoughtDialogue
    /// </summary>
    public RSeqAct_PlayRadioOrThoughtDialogue(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_PlayRadioOrThoughtDialogue Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_PlayRadioOrThoughtDialogue(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: DialogueType
    /// </summary>
    public unsafe byte DialogueType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ByteProperty: gotTOC
    /// </summary>
    public unsafe byte gotTOC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 829); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 829); }
    }

    /// <summary>
    /// ObjectProperty: LineToReturnToNormalPoseOn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LineToReturnToNormalPoseOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ObjectProperty: CustomPoseAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CustomPoseAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ObjectProperty: MovieCameraAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MovieCameraAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ObjectProperty: TVMovieTextureRenderTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TVMovieTextureRenderTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ObjectProperty: TheSwfMovie
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TheSwfMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ObjectProperty: TVMovieUI
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TVMovieUI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// BoolProperty: bLastLineIsIncedental
    /// </summary>
    public unsafe bool bLastLineIsIncedental
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bHasCustomPose
    /// </summary>
    public unsafe bool bHasCustomPose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bDontPutFingerToEar
    /// </summary>
    public unsafe bool bDontPutFingerToEar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bPreventPlayerMovement
    /// </summary>
    public unsafe bool bPreventPlayerMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bPreventCameraMovement
    /// </summary>
    public unsafe bool bPreventCameraMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bUseDefaultWalkCamera
    /// </summary>
    public unsafe bool bUseDefaultWalkCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bMovieHasCamera
    /// </summary>
    public unsafe bool bMovieHasCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bNoBleep
    /// </summary>
    public unsafe bool bNoBleep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bDontChangePose
    /// </summary>
    public unsafe bool bDontChangePose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bInAnimIsSpecialMoveOrMatinee
    /// </summary>
    public unsafe bool bInAnimIsSpecialMoveOrMatinee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bDontPlayTransIn
    /// </summary>
    public unsafe bool bDontPlayTransIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bStillPlayCameraIfNotChangingPose
    /// </summary>
    public unsafe bool bStillPlayCameraIfNotChangingPose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bIncomingCall
    /// </summary>
    public unsafe bool bIncomingCall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bForceOpaque
    /// </summary>
    public unsafe bool bForceOpaque
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bTappingGauntlet
    /// </summary>
    public unsafe bool bTappingGauntlet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bSetCamera
    /// </summary>
    public unsafe bool bSetCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForAnim
    /// </summary>
    public unsafe bool bWaitingForAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bSpeechFinished
    /// </summary>
    public unsafe bool bSpeechFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bMovieFinished
    /// </summary>
    public unsafe bool bMovieFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bMovieCancelling
    /// </summary>
    public unsafe bool bMovieCancelling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bAllowHudDuringMovie
    /// </summary>
    public unsafe bool bAllowHudDuringMovie
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bWaitForLoadingScreenOver
    /// </summary>
    public unsafe bool bWaitForLoadingScreenOver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: startNextMovieInstantly
    /// </summary>
    public unsafe bool startNextMovieInstantly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bLoopFinalSpeech
    /// </summary>
    public unsafe bool bLoopFinalSpeech
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bConnectionLost
    /// </summary>
    public unsafe bool bConnectionLost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bHasEverCheckedWaitForNotifiesSetInEditor
    /// </summary>
    public unsafe bool bHasEverCheckedWaitForNotifiesSetInEditor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bWaitForNotifiesSetInEditor
    /// </summary>
    public unsafe bool bWaitForNotifiesSetInEditor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bRemainInRadioModeAfterThisConversation
    /// </summary>
    public unsafe bool bRemainInRadioModeAfterThisConversation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 880); }
    }

    /// <summary>
    /// NameProperty: CustomPoseName
    /// </summary>
    public unsafe BmSDK.FName CustomPoseName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// NameProperty: CustomTransInName
    /// </summary>
    public unsafe BmSDK.FName CustomTransInName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// StrProperty: gauntletMovieHeaderText
    /// </summary>
    public unsafe BmSDK.FString gauntletMovieHeaderText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// NameProperty: MovieCameraName
    /// </summary>
    public unsafe BmSDK.FName MovieCameraName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// FloatProperty: MovieCameraFov
    /// </summary>
    public unsafe float MovieCameraFov
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ArrayProperty: LinesWithGauntletTaps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> LinesWithGauntletTaps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// NameProperty: OverrideGauntletPoseName
    /// </summary>
    public unsafe BmSDK.FName OverrideGauntletPoseName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// FloatProperty: gauntletTapStartTime
    /// </summary>
    public unsafe float gauntletTapStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ArrayProperty: TVMovieAudioSources
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> TVMovieAudioSources
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// StrProperty: lastPlayedMovieName
    /// </summary>
    public unsafe BmSDK.FString lastPlayedMovieName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// IntProperty: lineSkippedTo
    /// </summary>
    public unsafe int lineSkippedTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// ArrayProperty: TOCLineTimes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> TOCLineTimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// IntProperty: lineNumberAccordingToMovieCues
    /// </summary>
    public unsafe int lineNumberAccordingToMovieCues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: movieSkipToTime
    /// </summary>
    public unsafe float movieSkipToTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// FloatProperty: movieTriggerTime
    /// </summary>
    public unsafe float movieTriggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// Enum: eRadioThoughtDialogueType
    /// </summary>
    public enum eRadioThoughtDialogueType
    {
        eRTDT_Thought = 0,
        eRTDT_GauntletMovie = 1,
        eRTDT_TVMovie = 2,
        eRTDT_EarPieceRadio = 3,
        eRTDT_MAX = 4,
    }
}
