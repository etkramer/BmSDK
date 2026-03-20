#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RChaseLocationSearch<br/>
/// (flags = 0)
/// </summary>
public partial class RChaseLocationSearch : BmSDK.BmGame.RSearchTreeFinder, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RChaseLocationSearch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RChaseLocationSearch() { }

    /// <summary>
    /// Constructs a new RChaseLocationSearch
    /// </summary>
    public RChaseLocationSearch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RChaseLocationSearch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RChaseLocationSearch(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: ChaseState
    /// </summary>
    public unsafe BmSDK.BmGame.RChaseLocationSearch.ChaseSearchState ChaseState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChaseLocationSearch.ChaseSearchState>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: FoundPathsTime
    /// </summary>
    public unsafe float FoundPathsTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// ObjectProperty: NavigationManager
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationManager NavigationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationManager>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: ParamProxy
    /// </summary>
    public unsafe BmSDK.Engine.Pawn ParamProxy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ObjectProperty: AvoidActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor AvoidActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ObjectProperty: GuardVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RGuardVolume GuardVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGuardVolume>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// DelegateProperty: __ChaseLocationsFound__Delegate
    /// </summary>
    public unsafe System.IntPtr __ChaseLocationsFound__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// DelegateProperty: __ChaseSearchFailed__Delegate
    /// </summary>
    public unsafe System.IntPtr __ChaseSearchFailed__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// DelegateProperty: __ChaseSearchInvalidated__Delegate
    /// </summary>
    public unsafe System.IntPtr __ChaseSearchInvalidated__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// Enum: ChaseSearchState
    /// </summary>
    public enum ChaseSearchState
    {
        ECSS_None = 0,
        ECSS_WaitingForPaths = 1,
        ECSS_ConnectVisitedEdges = 2,
        ECSS_AddingUnseenVerts = 3,
        ECSS_AntiBacktracking = 4,
        ECSS_ReducingBranches = 5,
        ECSS_BuildingSearchPaths = 6,
        ECSS_RemoveDuplicateUnseenVerts = 7,
        ECSS_CountingBranchPoints = 8,
        ECSS_CalculatingBranchLengths = 9,
        ECSS_MAX = 10,
    }
}
