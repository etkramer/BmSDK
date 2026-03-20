#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMRoomAIState<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMRoomAIState : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMRoomAIState", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMRoomAIState() { }

    /// <summary>
    /// Constructs a new RBMRoomAIState
    /// </summary>
    public RBMRoomAIState(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMRoomAIState Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMRoomAIState(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: SpotableList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> SpotableList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: Snipers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> Snipers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: TargetPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer TargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: ThugPlayingRefuseOrder
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain ThugPlayingRefuseOrder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: RefuseOrderAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAlertEventCoordinatorBase RefuseOrderAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlertEventCoordinatorBase>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ObjectProperty: MineAssign
    /// </summary>
    public unsafe BmSDK.BmGame.RGargMineAssignmentPicker MineAssign
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGargMineAssignmentPicker>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ObjectProperty: GargSmashPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI GargSmashPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ObjectProperty: TargetGarg
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint TargetGarg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: GrateGrenadePawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI GrateGrenadePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: TargetGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase TargetGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ObjectProperty: GeneratorSmashPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI GeneratorSmashPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ObjectProperty: SentryKitAssign
    /// </summary>
    public unsafe BmSDK.BmGame.RSentryKitAssignmentPicker SentryKitAssign
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSentryKitAssignmentPicker>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ObjectProperty: BarkCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBarkCoordinator BarkCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBarkCoordinator>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ObjectProperty: BarkGroupContext
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkGroupContext_Pred BarkGroupContext
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkGroupContext_Pred>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ObjectProperty: CoordinatorParent
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Parent CoordinatorParent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Parent>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ObjectProperty: TargetTunnel
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel TargetTunnel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: TunnelGrenadePawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI TunnelGrenadePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ObjectProperty: CornerPointInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass CornerPointInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ObjectProperty: DMD_AEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_DetectiveModeDetector_Group DMD_AEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_DetectiveModeDetector_Group>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ObjectProperty: DMDClaimedBy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain DMDClaimedBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: DMDLatchedFullBy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain DMDLatchedFullBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ObjectProperty: BagCarrierDialogueAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_BagCarrierDialogue BagCarrierDialogueAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_BagCarrierDialogue>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ObjectProperty: DroneAbandonAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_AbandonDrone DroneAbandonAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_AbandonDrone>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: PanicLevel
    /// </summary>
    public unsafe int PanicLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StrProperty: PanicReasonText
    /// </summary>
    public unsafe BmSDK.FString PanicReasonText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// FloatProperty: LastUpdateTime
    /// </summary>
    public unsafe float LastUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// BoolProperty: bBatmanSeen
    /// </summary>
    public unsafe bool bBatmanSeen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bBatmanSeenInVantage
    /// </summary>
    public unsafe bool bBatmanSeenInVantage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneManDown
    /// </summary>
    public unsafe bool bHasDoneManDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneGunStartle
    /// </summary>
    public unsafe bool bHasDoneGunStartle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bHasSeenBatarangedExtinguisher
    /// </summary>
    public unsafe bool bHasSeenBatarangedExtinguisher
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bVoiceSynthUseDetected
    /// </summary>
    public unsafe bool bVoiceSynthUseDetected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForCommanderToStopSpeakingToPlayVoiceSynthesiserDisabledMessage
    /// </summary>
    public unsafe bool bWaitingForCommanderToStopSpeakingToPlayVoiceSynthesiserDisabledMessage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bHasStartedMissingThugCheckin
    /// </summary>
    public unsafe bool bHasStartedMissingThugCheckin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bShotInRoom
    /// </summary>
    public unsafe bool bShotInRoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bPlayerTookDamage
    /// </summary>
    public unsafe bool bPlayerTookDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bLastIsNoisy
    /// </summary>
    public unsafe bool bLastIsNoisy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bAllowARChallengesWhilePredatorActive
    /// </summary>
    public unsafe bool bAllowARChallengesWhilePredatorActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bSmashGenerators
    /// </summary>
    public unsafe bool bSmashGenerators
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bDoneBreakout
    /// </summary>
    public unsafe bool bDoneBreakout
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bCachedSightLostSeqEvents
    /// </summary>
    public unsafe bool bCachedSightLostSeqEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bPlayedMineDisabledBark
    /// </summary>
    public unsafe bool bPlayedMineDisabledBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bPlayedOddManOutBark
    /// </summary>
    public unsafe bool bPlayedOddManOutBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bFireSeenWhenSightLevelDecays
    /// </summary>
    public unsafe bool bFireSeenWhenSightLevelDecays
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bHostagePreviouslyTaken
    /// </summary>
    public unsafe bool bHostagePreviouslyTaken
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bCanLockDoors
    /// </summary>
    public unsafe bool bCanLockDoors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bSilentTakedownTakenPlace
    /// </summary>
    public unsafe bool bSilentTakedownTakenPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bLedgeTakedownTakenPlace
    /// </summary>
    public unsafe bool bLedgeTakedownTakenPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bVeryWeakWallTakedownTakenPlace
    /// </summary>
    public unsafe bool bVeryWeakWallTakedownTakenPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bThugHasBeenRevived
    /// </summary>
    public unsafe bool bThugHasBeenRevived
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bDetectiveModeOnAndDetectable
    /// </summary>
    public unsafe bool bDetectiveModeOnAndDetectable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bNoDMD
    /// </summary>
    public unsafe bool bNoDMD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: doneDMDAlertSinceLatch
    /// </summary>
    public unsafe bool doneDMDAlertSinceLatch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bAlsoRespectDefaultMaxLevelScriptingRules
    /// </summary>
    public unsafe bool bAlsoRespectDefaultMaxLevelScriptingRules
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bUnassignFromLevelScriptingImmediately
    /// </summary>
    public unsafe bool bUnassignFromLevelScriptingImmediately
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bBreakThugsOutOfBagCarrier
    /// </summary>
    public unsafe bool bBreakThugsOutOfBagCarrier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bBankBodySeen
    /// </summary>
    public unsafe bool bBankBodySeen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bNextChatAboutCash
    /// </summary>
    public unsafe bool bNextChatAboutCash
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bPlayedBankExitBark
    /// </summary>
    public unsafe bool bPlayedBankExitBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDrawMineLayingDebug
    /// </summary>
    public unsafe bool bDrawMineLayingDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bMiniDroneUsedInRoom
    /// </summary>
    public unsafe bool bMiniDroneUsedInRoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bThugNoticedDroneScanBefore
    /// </summary>
    public unsafe bool bThugNoticedDroneScanBefore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bScarecrowImpliedThreatToThugs
    /// </summary>
    public unsafe bool bScarecrowImpliedThreatToThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDoneSpecialAAIIntro
    /// </summary>
    public unsafe bool bDoneSpecialAAIIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bSeenThugEatenByPlant
    /// </summary>
    public unsafe bool bSeenThugEatenByPlant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDoneClockTowerCH9SpecialVoiceSynthAck
    /// </summary>
    public unsafe bool bDoneClockTowerCH9SpecialVoiceSynthAck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDontPropagateRoomAlert
    /// </summary>
    public unsafe bool bDontPropagateRoomAlert
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bMilitiaPresent
    /// </summary>
    public unsafe bool bMilitiaPresent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bGangPresent
    /// </summary>
    public unsafe bool bGangPresent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bBankDoneSpottedSlomo
    /// </summary>
    public unsafe bool bBankDoneSpottedSlomo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: RegisteredPredatorStart
    /// </summary>
    public unsafe bool RegisteredPredatorStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bMoneyHasBeenDumped
    /// </summary>
    public unsafe bool bMoneyHasBeenDumped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDoneStartTimerEvent
    /// </summary>
    public unsafe bool bDoneStartTimerEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: KnownTakedownCount
    /// </summary>
    public unsafe int KnownTakedownCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// IntProperty: HostileCount
    /// </summary>
    public unsafe int HostileCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// IntProperty: NumCasualtiesWhenSwitchedToFullPred
    /// </summary>
    public unsafe int NumCasualtiesWhenSwitchedToFullPred
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// IntProperty: MaxHostileCount
    /// </summary>
    public unsafe int MaxHostileCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StructProperty: XPInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FPredatorXPInfo XPInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FPredatorXPInfo>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// FloatProperty: MissingCheckinDialogueDelay
    /// </summary>
    public unsafe float MissingCheckinDialogueDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ArrayProperty: ControllerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIController> ControllerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIController>>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// IntProperty: IntimidationTakedownsPerformed
    /// </summary>
    public unsafe int IntimidationTakedownsPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// IntProperty: iNumberOfFearTakedownChainsCompleted
    /// </summary>
    public unsafe int iNumberOfFearTakedownChainsCompleted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ArrayProperty: DeadThugs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> DeadThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// IntProperty: NumSilentTakedowns
    /// </summary>
    public unsafe int NumSilentTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// IntProperty: ActiveJammerCount
    /// </summary>
    public unsafe int ActiveJammerCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// IntProperty: CurrentID
    /// </summary>
    public unsafe int CurrentID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ArrayProperty: GargsToBeMinedList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FGargToPoints> GargsToBeMinedList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FGargToPoints>>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StructProperty: TargetGargRefPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 TargetGargRefPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// ArrayProperty: IntactGratesUsedForTakedowns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase> IntactGratesUsedForTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase>>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// FloatProperty: CurrentSentryAssignChance
    /// </summary>
    public unsafe float CurrentSentryAssignChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ByteProperty: FearLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState.VillainFearLevel FearLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState.VillainFearLevel>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: GuardBarkTimer
    /// </summary>
    public unsafe float GuardBarkTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: RandMaxTerrified
    /// </summary>
    public unsafe int RandMaxTerrified
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastReloadBark
    /// </summary>
    public unsafe float TimeSinceLastReloadBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenReloadBarks
    /// </summary>
    public unsafe float MinTimeBetweenReloadBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ArrayProperty: SeenSeqEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> SeenSeqEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ArrayProperty: GrateToMine
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RThugMineablePointVent> GrateToMine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RThugMineablePointVent>>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ArrayProperty: ActiveMinePointList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RThugMineablePointBase> ActiveMinePointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RThugMineablePointBase>>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ArrayProperty: ActiveMines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RThugMineBase> ActiveMines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RThugMineBase>>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ArrayProperty: TunnelToGrenadeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTunnelFunnel> TunnelToGrenadeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTunnelFunnel>>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ArrayProperty: SentryGunThatNeedsPlacingList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSentryGunPlacementPoint> SentryGunThatNeedsPlacingList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSentryGunPlacementPoint>>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ArrayProperty: ThrownObjectList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject_Predator> ThrownObjectList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject_Predator>>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ArrayProperty: VantageCheckHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHidePoint> VantageCheckHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHidePoint>>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// FloatProperty: LastThermalCheckBarkTime
    /// </summary>
    public unsafe float LastThermalCheckBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: LastCornerExitBarkTime
    /// </summary>
    public unsafe float LastCornerExitBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: LastMineSafeReactionBarkTime
    /// </summary>
    public unsafe float LastMineSafeReactionBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// FloatProperty: LastPairedStopMoveTime
    /// </summary>
    public unsafe float LastPairedStopMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: LastLedgeSearchBarkTime
    /// </summary>
    public unsafe float LastLedgeSearchBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: LastGrateSearchBarkTime
    /// </summary>
    public unsafe float LastGrateSearchBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: LastFinishGuardPerimBarkTime
    /// </summary>
    public unsafe float LastFinishGuardPerimBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ArrayProperty: PNMMDVolList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPreventNonMedicManDownVolume> PNMMDVolList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPreventNonMedicManDownVolume>>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ArrayProperty: ActiveGuardVolList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGuardVolume> ActiveGuardVolList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGuardVolume>>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ArrayProperty: SentryGunDispenserList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootSourceBase> SentryGunDispenserList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootSourceBase>>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ArrayProperty: SentryGunPlacePointList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSentryGunPlacementPoint> SentryGunPlacePointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSentryGunPlacementPoint>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: PreDeployedSentryGuns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSentryGunBase> PreDeployedSentryGuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSentryGunBase>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ArrayProperty: PatrolList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPatrolPoint_LitePred> PatrolList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPatrolPoint_LitePred>>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: LiteAlertTime
    /// </summary>
    public unsafe float LiteAlertTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: ValidTakedownActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> ValidTakedownActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ArrayProperty: ValidTakedownNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ValidTakedownNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ArrayProperty: SilentTakedownActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> SilentTakedownActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ArrayProperty: TakedownGroups
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FTakedownGroup> TakedownGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FTakedownGroup>>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ArrayProperty: TakedownsPerformed
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> TakedownsPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ArrayProperty: RewardThresholds
    /// </summary>
    public unsafe BmSDK.TArray<int> RewardThresholds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ArrayProperty: CornersUsedForAttacks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCornerWallMarkerBase> CornersUsedForAttacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCornerWallMarkerBase>>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// IntProperty: numGrateTakedownsTakenPlace
    /// </summary>
    public unsafe int numGrateTakedownsTakenPlace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// IntProperty: NumGooMineTakedowns
    /// </summary>
    public unsafe int NumGooMineTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// FloatProperty: lastPairedCornerVariantTime
    /// </summary>
    public unsafe float lastPairedCornerVariantTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// ArrayProperty: KnownNavMeshObstacles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NavMeshObstacle> KnownNavMeshObstacles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavMeshObstacle>>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// FloatProperty: DMDProportion
    /// </summary>
    public unsafe float DMDProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// FloatProperty: DMDDecayRate
    /// </summary>
    public unsafe float DMDDecayRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// FloatProperty: DMDIncreaseRate
    /// </summary>
    public unsafe float DMDIncreaseRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// FloatProperty: DMD_HUDWarnThreshold
    /// </summary>
    public unsafe float DMD_HUDWarnThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// FloatProperty: timeTillCanAssignDMD
    /// </summary>
    public unsafe float timeTillCanAssignDMD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// FloatProperty: dmdAssignmentInterval
    /// </summary>
    public unsafe float dmdAssignmentInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// StructProperty: DMDLatchPlayerLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 DMDLatchPlayerLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// StructProperty: lastDMDAlertLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 lastDMDAlertLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// IntProperty: maxLevelScriptingInstances
    /// </summary>
    public unsafe int maxLevelScriptingInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: TimeSincePreviousLastStand
    /// </summary>
    public unsafe float TimeSincePreviousLastStand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenLastStands
    /// </summary>
    public unsafe float TimeBetweenLastStands
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: lastBankChatTime
    /// </summary>
    public unsafe float lastBankChatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// FloatProperty: bankChatInterval
    /// </summary>
    public unsafe float bankChatInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// FloatProperty: lastBankBodyDialogueTime
    /// </summary>
    public unsafe float lastBankBodyDialogueTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// FloatProperty: lastBMLostDialogueTime
    /// </summary>
    public unsafe float lastBMLostDialogueTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ArrayProperty: LevelScriptRootList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqEvent_LevelScripting> LevelScriptRootList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqEvent_LevelScripting>>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// ArrayProperty: LockinVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLockinVolume> LockinVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLockinVolume>>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// ArrayProperty: CasualtiesToBeCheckedList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> CasualtiesToBeCheckedList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// ArrayProperty: locationsForAdaptiveMinePlacement
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> locationsForAdaptiveMinePlacement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// IntProperty: iNumberOfFearTakedownsAvailable
    /// </summary>
    public unsafe int iNumberOfFearTakedownsAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// IntProperty: iMaximumNumberOfFearTakedowns
    /// </summary>
    public unsafe int iMaximumNumberOfFearTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// FloatProperty: LastDroneScanBarkTime
    /// </summary>
    public unsafe float LastDroneScanBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// FloatProperty: lastDMDUpdateTime
    /// </summary>
    public unsafe float lastDMDUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// IntProperty: UsedVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int UsedVoiceSynthesiserLethalTraps_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }
    /// <summary>
    /// IntProperty: UsedVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int UsedVoiceSynthesiserLethalTraps_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }
    /// <summary>
    /// IntProperty: UsedVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int UsedVoiceSynthesiserLethalTraps_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }
    /// <summary>
    /// IntProperty: UsedVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int UsedVoiceSynthesiserLethalTraps_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }
    /// <summary>
    /// IntProperty: UsedVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int UsedVoiceSynthesiserLethalTraps_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }
    /// <summary>
    /// IntProperty: UsedVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int UsedVoiceSynthesiserLethalTraps_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// IntProperty: ThugHasRefusedToUseVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int ThugHasRefusedToUseVoiceSynthesiserLethalTraps_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }
    /// <summary>
    /// IntProperty: ThugHasRefusedToUseVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int ThugHasRefusedToUseVoiceSynthesiserLethalTraps_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }
    /// <summary>
    /// IntProperty: ThugHasRefusedToUseVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int ThugHasRefusedToUseVoiceSynthesiserLethalTraps_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }
    /// <summary>
    /// IntProperty: ThugHasRefusedToUseVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int ThugHasRefusedToUseVoiceSynthesiserLethalTraps_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }
    /// <summary>
    /// IntProperty: ThugHasRefusedToUseVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int ThugHasRefusedToUseVoiceSynthesiserLethalTraps_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }
    /// <summary>
    /// IntProperty: ThugHasRefusedToUseVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int ThugHasRefusedToUseVoiceSynthesiserLethalTraps_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// IntProperty: CurrNavMeshVertUpdaterID
    /// </summary>
    public unsafe int CurrNavMeshVertUpdaterID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// FloatProperty: lastAssignToMinePlacementDialogueTime
    /// </summary>
    public unsafe float lastAssignToMinePlacementDialogueTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// FloatProperty: lastRepeatBatarangHitTime
    /// </summary>
    public unsafe float lastRepeatBatarangHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: LastPlantBombTime
    /// </summary>
    public unsafe float LastPlantBombTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// ArrayProperty: PotentialSpottedSloMoTarget
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> PotentialSpottedSloMoTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// FloatProperty: BankFirstPotentialSloMoTargetTime
    /// </summary>
    public unsafe float BankFirstPotentialSloMoTargetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// FloatProperty: BankDoneSpottedSlomoLatch
    /// </summary>
    public unsafe float BankDoneSpottedSlomoLatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// FloatProperty: LastSearchUDestSpecialCaseTime
    /// </summary>
    public unsafe float LastSearchUDestSpecialCaseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// FloatProperty: LastStealthThugLineTime
    /// </summary>
    public unsafe float LastStealthThugLineTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// IntProperty: AlertToMineLayersInFrames
    /// </summary>
    public unsafe int AlertToMineLayersInFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// FloatProperty: lastFearTakedownChainCompletionTime
    /// </summary>
    public unsafe float lastFearTakedownChainCompletionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// IntProperty: NumThugsTakenDownFromGrates
    /// </summary>
    public unsafe int NumThugsTakenDownFromGrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }
}
