#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_MoveToNavMesh<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_MoveToNavMesh : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_MoveToNavMesh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_MoveToNavMesh() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_MoveToNavMesh
    /// </summary>
    public RBMBehaviour_MoveToNavMesh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_MoveToNavMesh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_MoveToNavMesh(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DestinationActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DestinationActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: ActualDestinationActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ActualDestinationActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ObjectProperty: NavHandle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ObjectProperty: APS
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT APS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ObjectProperty: TargetActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ObjectProperty: ExitPoints
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExitPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// ObjectProperty: ChaseSearch
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChaseSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ObjectProperty: ChasePointRoot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChasePointRoot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ObjectProperty: ChasePointIntersection
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChasePointIntersection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// ArrayProperty: RandomDestinationActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>> RandomDestinationActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ArrayProperty: ActorNavHandles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> ActorNavHandles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// NameProperty: NewMovementStance
    /// </summary>
    public unsafe BmSDK.FName NewMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// NameProperty: NewWeaponStance
    /// </summary>
    public unsafe BmSDK.FName NewWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: FoundTimer
    /// </summary>
    public unsafe float FoundTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: ReleaseTimer
    /// </summary>
    public unsafe float ReleaseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// StructProperty: StoredTargetPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StoredTargetPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StructProperty: RandPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RandPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bPathFound
    /// </summary>
    public unsafe bool bPathFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: RepathTimer
    /// </summary>
    public unsafe float RepathTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ByteProperty: Speed
    /// </summary>
    public unsafe byte Speed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }
}
