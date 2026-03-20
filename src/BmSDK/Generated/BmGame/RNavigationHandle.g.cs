#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavigationHandle<br/>
/// (flags = 0)
/// </summary>
public partial class RNavigationHandle : BmSDK.Engine.NavigationHandle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavigationHandle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RNavigationHandle() { }

    /// <summary>
    /// Constructs a new RNavigationHandle
    /// </summary>
    public RNavigationHandle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavigationHandle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavigationHandle(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bCanPathFind
    /// </summary>
    public unsafe bool bCanPathFind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bSettingUpPathFind
    /// </summary>
    public unsafe bool bSettingUpPathFind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreKnownPathObstacles
    /// </summary>
    public unsafe bool bIgnoreKnownPathObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreGuardVolumeConstraints
    /// </summary>
    public unsafe bool bIgnoreGuardVolumeConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bBeenFollowed
    /// </summary>
    public unsafe bool bBeenFollowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bHasPath
    /// </summary>
    public unsafe bool bHasPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bAtPathGoal
    /// </summary>
    public unsafe bool bAtPathGoal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bAvoidPlayers
    /// </summary>
    public unsafe bool bAvoidPlayers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bCanUseLadders
    /// </summary>
    public unsafe bool bCanUseLadders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bCanTraverse
    /// </summary>
    public unsafe bool bCanTraverse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bPathToSafety
    /// </summary>
    public unsafe bool bPathToSafety
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bUseCheapSupportCheck
    /// </summary>
    public unsafe bool bUseCheapSupportCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bCanDoPathShortening
    /// </summary>
    public unsafe bool bCanDoPathShortening
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bCanDoRandomTeleport
    /// </summary>
    public unsafe bool bCanDoRandomTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bTimeSliceGetNextMoveLocation
    /// </summary>
    public unsafe bool bTimeSliceGetNextMoveLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bUseLastFramesPathTarget
    /// </summary>
    public unsafe bool bUseLastFramesPathTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bStuck
    /// </summary>
    public unsafe bool bStuck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bUsedPathObject
    /// </summary>
    public unsafe bool bUsedPathObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneFollowOnThisPath
    /// </summary>
    public unsafe bool bHasDoneFollowOnThisPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: LatentDelegate_PathSuccess
    /// </summary>
    public unsafe bool LatentDelegate_PathSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: LatentDelegate_PathFailure
    /// </summary>
    public unsafe bool LatentDelegate_PathFailure
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: LatentDelegate_ReachedGoal
    /// </summary>
    public unsafe bool LatentDelegate_ReachedGoal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }

    /// <summary>
    /// ByteProperty: CurrState
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle.PathStatus CurrState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle.PathStatus>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ObjectProperty: HostActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor HostActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ObjectProperty: HostNavActor
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationActor HostNavActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationActor>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ObjectProperty: HostPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI HostPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ObjectProperty: NavigationManager
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationManager NavigationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationManager>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// ObjectProperty: PathToActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor PathToActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ObjectProperty: LastSafeAnchorPylon
    /// </summary>
    public unsafe BmSDK.Engine.Pylon LastSafeAnchorPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// ObjectProperty: HandleToBeAppended
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle HandleToBeAppended
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// ObjectProperty: HandleToAppendTo
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle HandleToAppendTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// NameProperty: ClaimName
    /// </summary>
    public unsafe BmSDK.FName ClaimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: PathFindPriority
    /// </summary>
    public unsafe int PathFindPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// IntProperty: CurrPathCacheID
    /// </summary>
    public unsafe int CurrPathCacheID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// FloatProperty: CachedPathLength
    /// </summary>
    public unsafe float CachedPathLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// StructProperty: PathToPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 PathToPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// IntProperty: ForcedShortenAttempts
    /// </summary>
    public unsafe int ForcedShortenAttempts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StructProperty: TempMoveLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 TempMoveLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// StructProperty: LastSafeLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastSafeLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// IntProperty: LastSafeAnchorID
    /// </summary>
    public unsafe int LastSafeAnchorID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// FloatProperty: PathShortenProportion
    /// </summary>
    public unsafe float PathShortenProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// StructProperty: LastMoveLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastMoveLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: LastMoveLocationUpdateTime
    /// </summary>
    public unsafe float LastMoveLocationUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: LastMoveInDirectionFallbackTime
    /// </summary>
    public unsafe float LastMoveInDirectionFallbackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// StructProperty: StuckTestLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 StuckTestLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: StuckTestTime
    /// </summary>
    public unsafe float StuckTestTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ArrayProperty: PathShortens
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FPathShortenInstance> PathShortens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FPathShortenInstance>>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ArrayProperty: EdgesReached
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FEdgeReachedInstance> EdgesReached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FEdgeReachedInstance>>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ArrayProperty: PathTraversalHistory
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> PathTraversalHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalGoalList
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> AdditionalGoalList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: PreviousPathLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 PreviousPathLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ArrayProperty: AvoidPathObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> AvoidPathObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ArrayProperty: BlockedPolyList
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> BlockedPolyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// StructProperty: StartStateDebug
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle.FStartStateDebugInfo StartStateDebug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle.FStartStateDebugInfo>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ArrayProperty: NavHandleHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FNavHandleHistoryInfo> NavHandleHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FNavHandleHistoryInfo>>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ArrayProperty: LatentDelegate_ReachedEdges
    /// </summary>
    public unsafe BmSDK.TArray<int> LatentDelegate_ReachedEdges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// DelegateProperty: __PathSuccess__Delegate
    /// </summary>
    public unsafe System.IntPtr __PathSuccess__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// DelegateProperty: __PathFailure__Delegate
    /// </summary>
    public unsafe System.IntPtr __PathFailure__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// DelegateProperty: __ReachedGoal__Delegate
    /// </summary>
    public unsafe System.IntPtr __ReachedGoal__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// DelegateProperty: __ReachedEdge__Delegate
    /// </summary>
    public unsafe System.IntPtr __ReachedEdge__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// Struct: FComputedPathPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FComputedPathPoint
    {
        /// <summary>
        /// StructProperty: Loc
        /// </summary>
        public unsafe System.Numerics.Vector3 Loc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Edge
        /// </summary>
        public unsafe System.IntPtr Edge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
