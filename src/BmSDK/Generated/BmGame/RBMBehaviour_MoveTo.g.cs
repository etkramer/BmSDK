#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_MoveTo<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_MoveTo : BmSDK.BmGame.RBMBehaviour_MoveToBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_MoveTo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_MoveTo() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_MoveTo
    /// </summary>
    public RBMBehaviour_MoveTo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_MoveTo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_MoveTo(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DestinationActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor DestinationActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: ActualDestinationActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor ActualDestinationActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: AlwaysLookAtActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor AlwaysLookAtActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ObjectProperty: FinalLookAtActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor FinalLookAtActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ObjectProperty: NavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle NavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// NameProperty: NewMovementStance
    /// </summary>
    public unsafe BmSDK.FName NewMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// NameProperty: NewWeaponStance
    /// </summary>
    public unsafe BmSDK.FName NewWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bCheckDestinationActor
    /// </summary>
    public unsafe bool bCheckDestinationActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bLookAtPlayer
    /// </summary>
    public unsafe bool bLookAtPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bExitIfPathFindFails
    /// </summary>
    public unsafe bool bExitIfPathFindFails
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bTrackTarget
    /// </summary>
    public unsafe bool bTrackTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bRepathIfInterrupted
    /// </summary>
    public unsafe bool bRepathIfInterrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bMoveInStraightLine
    /// </summary>
    public unsafe bool bMoveInStraightLine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bCanBeHitInCombat
    /// </summary>
    public unsafe bool bCanBeHitInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bCanBeGrabbed
    /// </summary>
    public unsafe bool bCanBeGrabbed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bStoredRouterCanTraverse
    /// </summary>
    public unsafe bool bStoredRouterCanTraverse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bStoredPawnCanTraverse
    /// </summary>
    public unsafe bool bStoredPawnCanTraverse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bCanJumpFences
    /// </summary>
    public unsafe bool bCanJumpFences
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bRunActionQueueEndInterruptCall
    /// </summary>
    public unsafe bool bRunActionQueueEndInterruptCall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// FloatProperty: CloseToGoalDist
    /// </summary>
    public unsafe float CloseToGoalDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }
}
