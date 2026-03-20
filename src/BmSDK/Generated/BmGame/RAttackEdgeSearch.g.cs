#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAttackEdgeSearch<br/>
/// (flags = 0)
/// </summary>
public partial class RAttackEdgeSearch : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAttackEdgeSearch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAttackEdgeSearch() { }

    /// <summary>
    /// Constructs a new RAttackEdgeSearch
    /// </summary>
    public RAttackEdgeSearch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAttackEdgeSearch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAttackEdgeSearch(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: TargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 TargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: AttackRadius
    /// </summary>
    public unsafe float AttackRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ArrayProperty: AttackPointList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAttackEdgeSearch.FEdgePoint> AttackPointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAttackEdgeSearch.FEdgePoint>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: UsablePointsFound
    /// </summary>
    public unsafe int UsablePointsFound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: TotalChecksDone
    /// </summary>
    public unsafe int TotalChecksDone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ObjectProperty: NavigationManager
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationManager NavigationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationManager>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// NameProperty: ClaimName
    /// </summary>
    public unsafe BmSDK.FName ClaimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ByteProperty: CurrState
    /// </summary>
    public unsafe BmSDK.BmGame.RAttackEdgeSearch.AttackEdgeSearchState CurrState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAttackEdgeSearch.AttackEdgeSearchState>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: PylonList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pylon> PylonList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pylon>>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// IntProperty: VisCheckIndex
    /// </summary>
    public unsafe int VisCheckIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// FloatProperty: SearchStartTime
    /// </summary>
    public unsafe float SearchStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
}
