#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Controller<br/>
/// (flags = 0)
/// </summary>
public partial class Controller : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Controller", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Controller() { }

    /// <summary>
    /// Constructs a new Controller
    /// </summary>
    public Controller(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Controller Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Controller(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Controller>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Controller>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Controller>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Controller>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Controller>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Controller>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Controller>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Pawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn Pawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: PlayerReplicationInfo
    /// </summary>
    public unsafe BmSDK.Engine.PlayerReplicationInfo PlayerReplicationInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerReplicationInfo>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: NextController
    /// </summary>
    public unsafe BmSDK.Engine.Controller NextController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: MoveTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor MoveTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: Focus
    /// </summary>
    public unsafe BmSDK.Engine.Actor Focus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: GoalList
    /// </summary>
    public unsafe BmSDK.Engine.Actor GoalList_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }
    /// <summary>
    /// ObjectProperty: GoalList
    /// </summary>
    public unsafe BmSDK.Engine.Actor GoalList_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }
    /// <summary>
    /// ObjectProperty: GoalList
    /// </summary>
    public unsafe BmSDK.Engine.Actor GoalList_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }
    /// <summary>
    /// ObjectProperty: GoalList
    /// </summary>
    public unsafe BmSDK.Engine.Actor GoalList_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: StartSpot
    /// </summary>
    public unsafe BmSDK.Engine.NavigationPoint StartSpot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavigationPoint>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: CurrentPath
    /// </summary>
    public unsafe BmSDK.Engine.ReachSpec CurrentPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ReachSpec>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: NextRoutePath
    /// </summary>
    public unsafe BmSDK.Engine.ReachSpec NextRoutePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ReachSpec>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: RouteGoal
    /// </summary>
    public unsafe BmSDK.Engine.Actor RouteGoal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: PendingMover
    /// </summary>
    public unsafe BmSDK.Engine.InterpActor PendingMover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpActor>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: FailedMoveTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor FailedMoveTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: ShotTarget
    /// </summary>
    public unsafe BmSDK.Engine.Pawn ShotTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: LastFailedReach
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastFailedReach
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: Enemy
    /// </summary>
    public unsafe BmSDK.Engine.Pawn Enemy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// IntProperty: PlayerNum
    /// </summary>
    public unsafe int PlayerNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// BoolProperty: bIsPlayer
    /// </summary>
    public unsafe bool bIsPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bGodMode
    /// </summary>
    public unsafe bool bGodMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bSoaking
    /// </summary>
    public unsafe bool bSoaking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bSlowerZAcquire
    /// </summary>
    public unsafe bool bSlowerZAcquire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bNotifyPostLanded
    /// </summary>
    public unsafe bool bNotifyPostLanded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bNotifyApex
    /// </summary>
    public unsafe bool bNotifyApex
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bOverrideSearchStart
    /// </summary>
    public unsafe bool bOverrideSearchStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bAdvancedTactics
    /// </summary>
    public unsafe bool bAdvancedTactics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bCanDoSpecial
    /// </summary>
    public unsafe bool bCanDoSpecial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bAdjusting
    /// </summary>
    public unsafe bool bAdjusting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bPreparingMove
    /// </summary>
    public unsafe bool bPreparingMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bForceStrafe
    /// </summary>
    public unsafe bool bForceStrafe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bLOSflag
    /// </summary>
    public unsafe bool bLOSflag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bSkipExtraLOSChecks
    /// </summary>
    public unsafe bool bSkipExtraLOSChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bNotifyFallingHitWall
    /// </summary>
    public unsafe bool bNotifyFallingHitWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bEarlyOutOfSighTestsForSameType
    /// </summary>
    public unsafe bool bEarlyOutOfSighTestsForSameType
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bPreciseDestination
    /// </summary>
    public unsafe bool bPreciseDestination
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bSeeFriendly
    /// </summary>
    public unsafe bool bSeeFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// BoolProperty: bUsingPathLanes
    /// </summary>
    public unsafe bool bUsingPathLanes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 816); }
    }

    /// <summary>
    /// ByteProperty: bFire
    /// </summary>
    public unsafe byte bFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ByteProperty: bAltFire
    /// </summary>
    public unsafe byte bAltFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 821); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 821); }
    }

    /// <summary>
    /// FloatProperty: MinHitWall
    /// </summary>
    public unsafe float MinHitWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// StructProperty: OverrideSearchStart
    /// </summary>
    public unsafe System.Numerics.Vector3 OverrideSearchStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// FloatProperty: MoveTimer
    /// </summary>
    public unsafe float MoveTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// StructProperty: DestinationPosition
    /// </summary>
    public unsafe BmSDK.Engine.Actor.FBasedPosition DestinationPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.FBasedPosition>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// StructProperty: FocalPosition
    /// </summary>
    public unsafe BmSDK.Engine.Actor.FBasedPosition FocalPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.FBasedPosition>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: AdjustPosition
    /// </summary>
    public unsafe BmSDK.Engine.Actor.FBasedPosition AdjustPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.FBasedPosition>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ArrayProperty: RouteCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NavigationPoint> RouteCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavigationPoint>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// StructProperty: CurrentPathDir
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentPathDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: RouteDist
    /// </summary>
    public unsafe float RouteDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: LastRouteFind
    /// </summary>
    public unsafe float LastRouteFind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// IntProperty: MoveFailureCount
    /// </summary>
    public unsafe int MoveFailureCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: GroundPitchTime
    /// </summary>
    public unsafe float GroundPitchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: FailedReachTime
    /// </summary>
    public unsafe float FailedReachTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// StructProperty: FailedReachLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 FailedReachLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: SightCounter
    /// </summary>
    public unsafe float SightCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// FloatProperty: SightCounterInterval
    /// </summary>
    public unsafe float SightCounterInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// FloatProperty: InUseNodeCostMultiplier
    /// </summary>
    public unsafe float InUseNodeCostMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// IntProperty: HighJumpNodeCostModifier
    /// </summary>
    public unsafe int HighJumpNodeCostModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// FloatProperty: MaxMoveTowardPawnTargetTime
    /// </summary>
    public unsafe float MaxMoveTowardPawnTargetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ArrayProperty: VisiblePortals
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Controller.FVisiblePortalInfo> VisiblePortals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Controller.FVisiblePortalInfo>>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// FloatProperty: LaneOffset
    /// </summary>
    public unsafe float LaneOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// StructProperty: OldBasedRotation
    /// </summary>
    public unsafe BmSDK.Rotator OldBasedRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// StructProperty: NavMeshPath_SearchExtent_Modifier
    /// </summary>
    public unsafe System.Numerics.Vector3 NavMeshPath_SearchExtent_Modifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }
}
