#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavigationManager<br/>
/// (flags = 0)
/// </summary>
public partial class RNavigationManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavigationManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RNavigationManager() { }

    /// <summary>
    /// Constructs a new RNavigationManager
    /// </summary>
    public RNavigationManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavigationManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavigationManager(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AllNavHandles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle> AllNavHandles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: PendingSearchRequests
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle> PendingSearchRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: NavigationActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationActor> NavigationActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationActor>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: AttackPointSearches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAttackPointSearch> AttackPointSearches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAttackPointSearch>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: PendingAttackPointSearches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAttackPointSearch> PendingAttackPointSearches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAttackPointSearch>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: AttackEdgeSearches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAttackEdgeSearch> AttackEdgeSearches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAttackEdgeSearch>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: PendingAttackEdgeSearches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAttackEdgeSearch> PendingAttackEdgeSearches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAttackEdgeSearch>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: PendingChaseLocationSearches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChaseLocationSearch> PendingChaseLocationSearches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChaseLocationSearch>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ArrayProperty: TraceCheckVertsQueries
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIAction_PauseCheckVerts> TraceCheckVertsQueries
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIAction_PauseCheckVerts>>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ArrayProperty: UninformedSearchSuppressionVol
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RUninformedSearchSuppressionVolume> UninformedSearchSuppressionVol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RUninformedSearchSuppressionVolume>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ArrayProperty: PendingGroupAssignmentPickerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGroupAssignmentPicker> PendingGroupAssignmentPickerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGroupAssignmentPicker>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: CurrShortener
    /// </summary>
    public unsafe int CurrShortener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ArrayProperty: ShortenHandleIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> ShortenHandleIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// IntProperty: MaxShortensPerFrame
    /// </summary>
    public unsafe int MaxShortensPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// IntProperty: OverridePathSearchesPerFrame
    /// </summary>
    public unsafe int OverridePathSearchesPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ObjectProperty: GRI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI GRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// ArrayProperty: FireChaseInvalidatedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChaseLocationSearch> FireChaseInvalidatedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChaseLocationSearch>>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// MapProperty: NavMeshPathGoalPool
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ NavMeshPathGoalPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// MapProperty: NavMeshPathConstraintPool
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ NavMeshPathConstraintPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: UsedGoalList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NavMeshPathGoalEvaluator> UsedGoalList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavMeshPathGoalEvaluator>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: UsedConstraintList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NavMeshPathConstraint> UsedConstraintList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavMeshPathConstraint>>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ArrayProperty: RebuildkDOPRequests
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationManager.FRebuildObstacleMeshkDOPInfo> RebuildkDOPRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationManager.FRebuildObstacleMeshkDOPInfo>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }
}
