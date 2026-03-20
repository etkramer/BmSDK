#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSearchRoutingWrapper<br/>
/// (size = 384)
/// (flags = 0)
/// </summary>
public partial class RSearchRoutingWrapper : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSearchRoutingWrapper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSearchRoutingWrapper() { }

    /// <summary>
    /// Constructs a new RSearchRoutingWrapper
    /// </summary>
    public RSearchRoutingWrapper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSearchRoutingWrapper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSearchRoutingWrapper(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: RefinePullbackPoint
    /// </summary>
    public unsafe bool RefinePullbackPoint(System.Numerics.Vector3 TestSidePoint, System.Numerics.Vector3 PathSegmentStart, System.Numerics.Vector3 PathSegmentEnd, float PullbackDist, out System.Numerics.Vector3 BranchStart)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.RefinePullbackPoint", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestSidePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathSegmentStart, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathSegmentEnd, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PullbackDist, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BranchStart = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 52);
    }

    /// <summary>
    /// Function: PullBackEndPoint
    /// </summary>
    public unsafe void PullBackEndPoint(float MaxPullBackDist, System.Numerics.Vector3 EndLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.PullBackEndPoint", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxPullBackDist, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLoc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetChaseNodesForPathTo
    /// </summary>
    public unsafe BmSDK.BmGame.RSearchRoutingWrapper.CPProcessResult GetChaseNodesForPathTo(BmSDK.BmGame.RChasePoint EndPoint, out BmSDK.TArray<BmSDK.BmGame.RChasePoint> TempCPPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.GetChaseNodesForPathTo", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TempCPPath = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChasePoint>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSearchRoutingWrapper.CPProcessResult>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: RecursiveChaseNodeChecker
    /// </summary>
    public unsafe bool RecursiveChaseNodeChecker(BmSDK.BmGame.RChasePoint TestNode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.RecursiveChaseNodeChecker", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestNode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: BuildChaseNodePath
    /// </summary>
    public unsafe BmSDK.BmGame.RSearchRoutingWrapper.CPProcessResult BuildChaseNodePath(out BmSDK.TArray<BmSDK.BmGame.RChasePoint> TempCPPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.BuildChaseNodePath", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TempCPPath = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChasePoint>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSearchRoutingWrapper.CPProcessResult>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: BuildChaseNodePathForTreeFailRecoverWorkaround
    /// </summary>
    public unsafe BmSDK.BmGame.RSearchRoutingWrapper.CPProcessResult BuildChaseNodePathForTreeFailRecoverWorkaround(out BmSDK.TArray<BmSDK.BmGame.RChasePoint> TempCPPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.BuildChaseNodePathForTreeFailRecoverWorkaround", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TempCPPath = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChasePoint>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSearchRoutingWrapper.CPProcessResult>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: FindStandPosAndChasePointThatHaveReachabilityToTestPoint
    /// </summary>
    public unsafe bool FindStandPosAndChasePointThatHaveReachabilityToTestPoint(int FirstIndexOnMainPath, BmSDK.BmGame.RChasePoint TestSideNode, out BmSDK.BmGame.RChasePoint MainPathBranchStart, out System.Numerics.Vector3 StartStandPos, float MaxTestDist = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.FindStandPosAndChasePointThatHaveReachabilityToTestPoint", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstIndexOnMainPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestSideNode, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxTestDist, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MainPathBranchStart = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChasePoint>(paramsPtr + 12);
        StartStandPos = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: RecursiveFindBranch
    /// </summary>
    public unsafe void RecursiveFindBranch(int CPPathIndex, BmSDK.BmGame.RChasePoint CurrentTestPoint, out BmSDK.TArray<BmSDK.BmGame.RSearchRoutingWrapper.FSideBranchStruct> BranchList, out int bHasValidEndsWithoutBranchStarts)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.RecursiveFindBranch", true);
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPPathIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentTestPoint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BranchList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSearchRoutingWrapper.FSideBranchStruct>>(paramsPtr + 12);
        bHasValidEndsWithoutBranchStarts = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
        return;
    }

    /// <summary>
    /// Function: FindSidePath
    /// </summary>
    public unsafe BmSDK.BmGame.RSearchRoutingWrapper.CPProcessResult FindSidePath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.FindSidePath", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSearchRoutingWrapper.CPProcessResult>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDistFromSearchStartForBranchFromPoint
    /// </summary>
    public unsafe float GetDistFromSearchStartForBranchFromPoint(BmSDK.BmGame.RSearchRoutingWrapper.FSideBranchStruct TestBranch)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.GetDistFromSearchStartForBranchFromPoint", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestBranch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: GetPositionOfDeepestNodeThatCanSeeStart
    /// </summary>
    public unsafe System.Numerics.Vector3 GetPositionOfDeepestNodeThatCanSeeStart(BmSDK.BmGame.RChasePoint TestNode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.GetPositionOfDeepestNodeThatCanSeeStart", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestNode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetFurthestVisibleDirs
    /// </summary>
    public unsafe void GetFurthestVisibleDirs(System.Numerics.Vector3 CentrePoint, out BmSDK.TArray<System.Numerics.Vector3> ValidDirList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.GetFurthestVisibleDirs", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CentrePoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ValidDirList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: GetAllValidBranchDirs
    /// </summary>
    public unsafe void GetAllValidBranchDirs(out BmSDK.TArray<System.Numerics.Vector3> OutDirList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.GetAllValidBranchDirs", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutDirList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetLandPosForLastLadderDownInPath
    /// </summary>
    public unsafe bool GetLandPosForLastLadderDownInPath(out int Index, out System.Numerics.Vector3 LandPos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.GetLandPosForLastLadderDownInPath", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Index = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        LandPos = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe bool Update()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.Update", true);
        byte* paramsPtr = stackalloc byte[204];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: InitTestBranchEnds
    /// </summary>
    public unsafe void InitTestBranchEnds()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.InitTestBranchEnds", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CollapseDeadEnds
    /// </summary>
    public unsafe void CollapseDeadEnds(BmSDK.BmGame.RChasePoint TestNode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.CollapseDeadEnds", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestNode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ProcessUninformedSearchResults
    /// </summary>
    public unsafe void ProcessUninformedSearchResults()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.ProcessUninformedSearchResults", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DirectFinished
    /// </summary>
    public unsafe void DirectFinished(BmSDK.BmGame.RNavigationHandle NavHandle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.DirectFinished", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChaseSearchFailed
    /// </summary>
    public unsafe void ChaseSearchFailed(BmSDK.BmGame.RChaseLocationSearch CompletedSearch)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.ChaseSearchFailed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompletedSearch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChaseSearchDone
    /// </summary>
    public unsafe void ChaseSearchDone(BmSDK.BmGame.RChaseLocationSearch CompletedSearch)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.ChaseSearchDone", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompletedSearch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddRejectedLedge
    /// </summary>
    public unsafe void AddRejectedLedge(BmSDK.BmGame.RLedgeLookDangerAreaInfo NewReject, System.Numerics.Vector3 NewLocRejectedAt)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.AddRejectedLedge", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewReject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocRejectedAt, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartSearch
    /// </summary>
    public unsafe void StartSearch(System.Numerics.Vector3 NewStartLoc, System.Numerics.Vector3 NewTargetLoc, System.Numerics.Vector3 NewLastArriveDir, float NewTreeSearchDist, bool bNewDoAntiBacktracking, bool bNewForceDirectPath, BmSDK.BmGame.RBMAIController NewCornerLockCon, bool bNewCheckCorners, bool bNewCheckGrates, bool bNewCheckLedges, bool bNewCheckWeakWalls, bool bNewCheckSideRooms)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.StartSearch", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStartLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTargetLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLastArriveDir, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTreeSearchDist, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewDoAntiBacktracking, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewForceDirectPath, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCornerLockCon, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewCheckCorners, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewCheckGrates, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewCheckLedges, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewCheckWeakWalls, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewCheckSideRooms, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Cleanup
    /// </summary>
    public unsafe void Cleanup()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.Cleanup", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe void Init(BmSDK.Engine.Actor NewOwningActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.Init", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwningActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanFindBranchStartFor
    /// </summary>
    public unsafe bool CanFindBranchStartFor(System.Numerics.Vector3 TestSidePoint, System.Numerics.Vector3 PathSegmentStart, System.Numerics.Vector3 PathSegmentEnd, out System.Numerics.Vector3 BranchStart)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.CanFindBranchStartFor", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestSidePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathSegmentStart, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathSegmentEnd, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BranchStart = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: CanSeeBetween
    /// </summary>
    public unsafe bool CanSeeBetween(BmSDK.BmGame.RChasePoint StartPoint, BmSDK.BmGame.RChasePoint EndPoint, bool bAssumeVisibleForDynamic)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.CanSeeBetween", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAssumeVisibleForDynamic, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: IsVisibleFromChosenPath
    /// </summary>
    public unsafe bool IsVisibleFromChosenPath(BmSDK.BmGame.RChasePoint TargetPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.IsVisibleFromChosenPath", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPoint, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsFarEnoughFromChosenPath
    /// </summary>
    public unsafe bool IsFarEnoughFromChosenPath(BmSDK.BmGame.RChasePoint TargetPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSearchRoutingWrapper.IsFarEnoughFromChosenPath", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPoint, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Enum: CPProcessResult
    /// </summary>
    public enum CPProcessResult
    {
        CPPR_Fail = 0,
        CPPR_NeedRestart = 1,
        CPPR_Done = 2,
        CPPR_MAX = 3,
    }

    /// <summary>
    /// Struct: FRejectedLedgeInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FRejectedLedgeInfo
    {
        /// <summary>
        /// ObjectProperty: LedgeDanger
        /// </summary>
        public unsafe BmSDK.BmGame.RLedgeLookDangerAreaInfo LedgeDanger
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLedgeLookDangerAreaInfo>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: LocRejectedAt
        /// </summary>
        public unsafe System.Numerics.Vector3 LocRejectedAt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: SearchResultType
    /// </summary>
    public enum SearchResultType
    {
        SRT_Normal = 0,
        SRT_UDest = 1,
        SRT_Corner = 2,
        SRT_Grate = 3,
        SRT_Ledge = 4,
        SRT_WeakWall = 5,
        SRT_SidePath = 6,
        SRT_MAX = 7,
    }

    /// <summary>
    /// ByteProperty: WorkState
    /// </summary>
    public unsafe BmSDK.BmGame.RSearchRoutingWrapper.SearchRoutingWorkState WorkState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSearchRoutingWrapper.SearchRoutingWorkState>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ByteProperty: ResultType
    /// </summary>
    public unsafe BmSDK.BmGame.RSearchRoutingWrapper.SearchResultType ResultType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSearchRoutingWrapper.SearchResultType>(Ptr + 85); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 85); }
    }

    /// <summary>
    /// ObjectProperty: ChaseLocSearch
    /// </summary>
    public unsafe BmSDK.BmGame.RChaseLocationSearch ChaseLocSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChaseLocationSearch>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ObjectProperty: EndPathWrapper
    /// </summary>
    public unsafe BmSDK.BmGame.RUninformedTreeEndPathWrapper EndPathWrapper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RUninformedTreeEndPathWrapper>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ObjectProperty: DirectPathUnshortened
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle DirectPathUnshortened
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: CornerLockCon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController CornerLockCon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ObjectProperty: OwningActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor OwningActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ObjectProperty: BestTreeEnd
    /// </summary>
    public unsafe BmSDK.BmGame.RChasePoint BestTreeEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChasePoint>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ObjectProperty: CornerStartPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerWallMarker CornerStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerWallMarker>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ObjectProperty: CornerEndPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerWallMarker CornerEndPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerWallMarker>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ObjectProperty: FirstGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase FirstGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ObjectProperty: LastGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase LastGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// ObjectProperty: LedgeDangerInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RLedgeLookDangerAreaInfo LedgeDangerInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLedgeLookDangerAreaInfo>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// ObjectProperty: WeakWall
    /// </summary>
    public unsafe BmSDK.BmGame.RDestructibleProp_FractureWall WeakWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDestructibleProp_FractureWall>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ObjectProperty: SideSearchVol
    /// </summary>
    public unsafe BmSDK.BmGame.RSideRoomVolume SideSearchVol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSideRoomVolume>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// ArrayProperty: CPPath
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChasePoint> CPPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChasePoint>>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// BoolProperty: bTreeFinished
    /// </summary>
    public unsafe bool bTreeFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bDirectPathFinished
    /// </summary>
    public unsafe bool bDirectPathFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bDoAntiBacktracking
    /// </summary>
    public unsafe bool bDoAntiBacktracking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bForceDirectPath
    /// </summary>
    public unsafe bool bForceDirectPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bCheckCorners
    /// </summary>
    public unsafe bool bCheckCorners
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bCheckGrates
    /// </summary>
    public unsafe bool bCheckGrates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bCheckLedges
    /// </summary>
    public unsafe bool bCheckLedges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bCheckWeakWalls
    /// </summary>
    public unsafe bool bCheckWeakWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bCheckSideRooms
    /// </summary>
    public unsafe bool bCheckSideRooms
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bIsGoingDownDeadEnd
    /// </summary>
    public unsafe bool bIsGoingDownDeadEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// StructProperty: StartLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 StartLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StructProperty: TargetLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 TargetLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: LastArriveDir
    /// </summary>
    public unsafe System.Numerics.Vector3 LastArriveDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// FloatProperty: TreeSearchDist
    /// </summary>
    public unsafe float TreeSearchDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// StructProperty: ResultLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 ResultLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// StructProperty: ResultFaceAt
    /// </summary>
    public unsafe System.Numerics.Vector3 ResultFaceAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// ArrayProperty: SideBranches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSearchRoutingWrapper.FSideBranchStruct> SideBranches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSearchRoutingWrapper.FSideBranchStruct>>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ArrayProperty: DeadEndList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChasePoint> DeadEndList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChasePoint>>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// StructProperty: StandAtGrateEndPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 StandAtGrateEndPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// StructProperty: LedgeLookStart
    /// </summary>
    public unsafe System.Numerics.Vector3 LedgeLookStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StructProperty: LedgeLookEnd
    /// </summary>
    public unsafe System.Numerics.Vector3 LedgeLookEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// StructProperty: WallStart
    /// </summary>
    public unsafe System.Numerics.Vector3 WallStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// StructProperty: SideSearchPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 SideSearchPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// ArrayProperty: RejectedLedgeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSearchRoutingWrapper.FRejectedLedgeInfo> RejectedLedgeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSearchRoutingWrapper.FRejectedLedgeInfo>>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// Struct: FSideBranchStruct
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FSideBranchStruct
    {
        /// <summary>
        /// ObjectProperty: BranchesFrom
        /// </summary>
        public unsafe BmSDK.BmGame.RChasePoint BranchesFrom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChasePoint>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: BranchTo
        /// </summary>
        public unsafe BmSDK.BmGame.RChasePoint BranchTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChasePoint>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: BranchFromPoint
        /// </summary>
        public unsafe System.Numerics.Vector3 BranchFromPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: BranchPointDist
        /// </summary>
        public unsafe float BranchPointDist
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Enum: SearchRoutingWorkState
    /// </summary>
    public enum SearchRoutingWorkState
    {
        SRWS_None = 0,
        SRWS_WaitForInitialPathFind = 1,
        SRWS_WaitForEndPaths = 2,
        SRWS_SidePath = 3,
        SRWS_CheckSpecials = 4,
        SRWS_MAX = 5,
    }
}
