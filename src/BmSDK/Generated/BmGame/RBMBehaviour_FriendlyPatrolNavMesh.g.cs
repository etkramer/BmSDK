#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_FriendlyPatrolNavMesh<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_FriendlyPatrolNavMesh : BmSDK.BmGame.RBMBehaviour_MoveToBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_FriendlyPatrolNavMesh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_FriendlyPatrolNavMesh() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_FriendlyPatrolNavMesh
    /// </summary>
    public RBMBehaviour_FriendlyPatrolNavMesh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_FriendlyPatrolNavMesh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_FriendlyPatrolNavMesh(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: StartPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint StartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: NextPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint NextPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: NavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle NavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ObjectProperty: APS
    /// </summary>
    public unsafe BmSDK.BmGame.RAttackPointSearch APS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAttackPointSearch>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ObjectProperty: TargetActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor TargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// ObjectProperty: ExitPoints
    /// </summary>
    public unsafe BmSDK.BmGame.RNavMeshPath_ExitPoints ExitPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavMeshPath_ExitPoints>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: LookTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor LookTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: WaitAtPointOverlayAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet WaitAtPointOverlayAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// FloatProperty: FoundTimer
    /// </summary>
    public unsafe float FoundTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: ReleaseTimer
    /// </summary>
    public unsafe float ReleaseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StructProperty: StoredTargetPos
    /// </summary>
    public unsafe System.Numerics.Vector3 StoredTargetPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bStartFromCurrentPosition
    /// </summary>
    public unsafe bool bStartFromCurrentPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 732); }
    }

    /// <summary>
    /// BoolProperty: bDoAimAt
    /// </summary>
    public unsafe bool bDoAimAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 732); }
    }

    /// <summary>
    /// BoolProperty: bOutputIfAtPatrolPoint
    /// </summary>
    public unsafe bool bOutputIfAtPatrolPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 732); }
    }

    /// <summary>
    /// BoolProperty: bHasSetupOutputArray
    /// </summary>
    public unsafe bool bHasSetupOutputArray
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 732); }
    }

    /// <summary>
    /// FloatProperty: PauseTime
    /// </summary>
    public unsafe float PauseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: WaitTime
    /// </summary>
    public unsafe float WaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: LookAtTime
    /// </summary>
    public unsafe float LookAtTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// IntProperty: LastIdle
    /// </summary>
    public unsafe int LastIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ArrayProperty: CanNotifyThisEndPoint
    /// </summary>
    public unsafe BmSDK.TArray<int> CanNotifyThisEndPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: TalkStateTime
    /// </summary>
    public unsafe float TalkStateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// StructProperty: ProximityAndSightOptions
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_FriendlyPatrolNavMesh.FProximityAndSightPatrol ProximityAndSightOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_FriendlyPatrolNavMesh.FProximityAndSightPatrol>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: WaitAtPointOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_MoveToBase.FMoveToRandomAnimation> WaitAtPointOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_MoveToBase.FMoveToRandomAnimation>>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenWalks
    /// </summary>
    public unsafe float TimeBetweenWalks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceWalk
    /// </summary>
    public unsafe float TimeSinceWalk
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// StructProperty: DirectionOfFocus
    /// </summary>
    public unsafe System.Numerics.Vector3 DirectionOfFocus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }
}
