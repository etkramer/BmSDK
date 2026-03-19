#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHelicopterBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHelicopterBase : BmSDK.Engine.Pawn, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHelicopterBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHelicopterBase() { }

    /// <summary>
    /// Constructs a new RHelicopterBase
    /// </summary>
    public RHelicopterBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHelicopterBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHelicopterBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: RouteCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> RouteCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// FloatProperty: RouteLifeTime
    /// </summary>
    public unsafe float RouteLifeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// FloatProperty: LinearAcceleration
    /// </summary>
    public unsafe float LinearAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// FloatProperty: TurningSpeed
    /// </summary>
    public unsafe float TurningSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// FloatProperty: maxPatrolVelocity
    /// </summary>
    public unsafe float maxPatrolVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// FloatProperty: maxChaseVelocity
    /// </summary>
    public unsafe float maxChaseVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: maxStrafeVelocity
    /// </summary>
    public unsafe float maxStrafeVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// FloatProperty: LinearVelocity
    /// </summary>
    public unsafe float LinearVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// FloatProperty: SlowDownDistance
    /// </summary>
    public unsafe float SlowDownDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// FloatProperty: TurningDistance
    /// </summary>
    public unsafe float TurningDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// FloatProperty: TurningDistanceRemaining
    /// </summary>
    public unsafe float TurningDistanceRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// BoolProperty: bHasBegunTurning
    /// </summary>
    public unsafe bool bHasBegunTurning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bForcePursuitSpeed
    /// </summary>
    public unsafe bool bForcePursuitSpeed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bHoldPositionUntilBoarded
    /// </summary>
    public unsafe bool bHoldPositionUntilBoarded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: CanSeeThroughSmoke
    /// </summary>
    public unsafe bool CanSeeThroughSmoke
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: DisableSweep
    /// </summary>
    public unsafe bool DisableSweep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: LimitlessVisionRange
    /// </summary>
    public unsafe bool LimitlessVisionRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bInLowDetail
    /// </summary>
    public unsafe bool bInLowDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bHasVisualContact
    /// </summary>
    public unsafe bool bHasVisualContact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bLineOfSightToBatman
    /// </summary>
    public unsafe bool bLineOfSightToBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bBatmanInSearchLight
    /// </summary>
    public unsafe bool bBatmanInSearchLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bOnScreenLastFrame
    /// </summary>
    public unsafe bool bOnScreenLastFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bActivelyAvoidBatman
    /// </summary>
    public unsafe bool bActivelyAvoidBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bAvoidGettingTooCloseToBatman
    /// </summary>
    public unsafe bool bAvoidGettingTooCloseToBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bBatmanOnBoard
    /// </summary>
    public unsafe bool bBatmanOnBoard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bSubjectToFlightControl
    /// </summary>
    public unsafe bool bSubjectToFlightControl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bHasRotors
    /// </summary>
    public unsafe bool bHasRotors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bAllowedToChatter
    /// </summary>
    public unsafe bool bAllowedToChatter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: IsFriendly
    /// </summary>
    public unsafe bool IsFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bHeliTimeSliceVisionCheckAllowed
    /// </summary>
    public unsafe bool bHeliTimeSliceVisionCheckAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: playerCanBeSeenByHelicopter
    /// </summary>
    public unsafe bool playerCanBeSeenByHelicopter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bAlertedToBatmansPosition
    /// </summary>
    public unsafe bool bAlertedToBatmansPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: HasLostSightOfBatman
    /// </summary>
    public unsafe bool HasLostSightOfBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bIsAggro
    /// </summary>
    public unsafe bool bIsAggro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: new_lineofsight
    /// </summary>
    public unsafe bool new_lineofsight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bBlocksRECHits
    /// </summary>
    public unsafe bool bBlocksRECHits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bHasCustomLightCode
    /// </summary>
    public unsafe bool bHasCustomLightCode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bAbseiling
    /// </summary>
    public unsafe bool bAbseiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bAbseilingHasBegun
    /// </summary>
    public unsafe bool bAbseilingHasBegun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: AudioSuspended
    /// </summary>
    public unsafe bool AudioSuspended
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bFixedCombatCameraWhenPlayerIsBasedOn
    /// </summary>
    public unsafe bool bFixedCombatCameraWhenPlayerIsBasedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bDisrupted
    /// </summary>
    public unsafe bool bDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bDeleteWhenOffscreen
    /// </summary>
    public unsafe bool bDeleteWhenOffscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1536); }
    }

    /// <summary>
    /// BoolProperty: bFriendly
    /// </summary>
    public unsafe bool bFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// BoolProperty: bIsGunship
    /// </summary>
    public unsafe bool bIsGunship
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// BoolProperty: bCanDoHeliChatter
    /// </summary>
    public unsafe bool bCanDoHeliChatter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// BoolProperty: bLastBMPOIWasPriority
    /// </summary>
    public unsafe bool bLastBMPOIWasPriority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// BoolProperty: DrivingAndOutOfRangeStasisActive
    /// </summary>
    public unsafe bool DrivingAndOutOfRangeStasisActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// BoolProperty: bApplyWindToCape
    /// </summary>
    public unsafe bool bApplyWindToCape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// BoolProperty: PPEnabled
    /// </summary>
    public unsafe bool PPEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1540); }
    }

    /// <summary>
    /// StructProperty: PrevPointLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PrevPointLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// StructProperty: ActualVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ActualVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// StructProperty: ActualAcceleration
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ActualAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// FloatProperty: ActualRotationalVelocity
    /// </summary>
    public unsafe float ActualRotationalVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// StructProperty: VirtualLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VirtualLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// StructProperty: VirtualRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VirtualRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// FloatProperty: PitchAndRollMultiplier
    /// </summary>
    public unsafe float PitchAndRollMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// ObjectProperty: LookAtTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LookAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// ObjectProperty: HelicopterPassengerAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HelicopterPassengerAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }

    /// <summary>
    /// ObjectProperty: FixedCamOverlayAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FixedCamOverlayAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// ObjectProperty: chinookSeqAct
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT chinookSeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// ObjectProperty: PointOfInterestActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PointOfInterestActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }

    /// <summary>
    /// ObjectProperty: PreviousPointOfInterestActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviousPointOfInterestActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// ObjectProperty: BarkData
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BarkData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// ObjectProperty: BarkDataInstance
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BarkDataInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// ComponentProperty: WindComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WindComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// ComponentProperty: PlayerBlocker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerBlocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// ComponentProperty: DisruptedVFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DisruptedVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// ComponentProperty: LensFlareFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LensFlareFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// ComponentProperty: SearchLightMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SearchLightMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// ComponentProperty: TheSpotLightComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TheSpotLightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// FloatProperty: RubberBandingPeriod
    /// </summary>
    public unsafe float RubberBandingPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// FloatProperty: RubberBandingMaxAcceleration
    /// </summary>
    public unsafe float RubberBandingMaxAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// FloatProperty: RubberBandingJerkPeriod
    /// </summary>
    public unsafe float RubberBandingJerkPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxSpeed
    /// </summary>
    public unsafe float CurrentMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// FloatProperty: MaximumPitchForwardDegrees
    /// </summary>
    public unsafe float MaximumPitchForwardDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// FloatProperty: MaximumBankSidewaysDegrees
    /// </summary>
    public unsafe float MaximumBankSidewaysDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// FloatProperty: MaximumBankFromTurnDegrees
    /// </summary>
    public unsafe float MaximumBankFromTurnDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// FloatProperty: RotationalVelocityMaxDegrees
    /// </summary>
    public unsafe float RotationalVelocityMaxDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// FloatProperty: RotationalAccelerationDegrees
    /// </summary>
    public unsafe float RotationalAccelerationDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// ArrayProperty: WhooshBys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> WhooshBys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// FloatProperty: DistanceToCutAudio
    /// </summary>
    public unsafe float DistanceToCutAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// StructProperty: GustNormalStart
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GustNormalStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// StructProperty: GustNormalFinish
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GustNormalFinish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }
    }

    /// <summary>
    /// FloatProperty: GustMagnitude
    /// </summary>
    public unsafe float GustMagnitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// FloatProperty: GustTimer
    /// </summary>
    public unsafe float GustTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// FloatProperty: GustDuration
    /// </summary>
    public unsafe float GustDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// FloatProperty: GustCalmPeriodDuration
    /// </summary>
    public unsafe float GustCalmPeriodDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// StructProperty: CurrentGustVector
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentGustVector
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// FloatProperty: RotationBankingMagnitude
    /// </summary>
    public unsafe float RotationBankingMagnitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// FloatProperty: WobbleTime
    /// </summary>
    public unsafe float WobbleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// FloatProperty: RecImpactTimestamp
    /// </summary>
    public unsafe float RecImpactTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// FloatProperty: RecImpactImmunityPeriod
    /// </summary>
    public unsafe float RecImpactImmunityPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// FloatProperty: RecImpactDisorientPeriod
    /// </summary>
    public unsafe float RecImpactDisorientPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// StructProperty: WobbleVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WobbleVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// FloatProperty: GustStrengthBase
    /// </summary>
    public unsafe float GustStrengthBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// FloatProperty: GustStrengthRange
    /// </summary>
    public unsafe float GustStrengthRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// FloatProperty: GustDurationMin
    /// </summary>
    public unsafe float GustDurationMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// FloatProperty: GustDurationRange
    /// </summary>
    public unsafe float GustDurationRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// FloatProperty: GustCalmPeriod
    /// </summary>
    public unsafe float GustCalmPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// FloatProperty: BobUpAndDownVelocity
    /// </summary>
    public unsafe float BobUpAndDownVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// FloatProperty: BobStartTime
    /// </summary>
    public unsafe float BobStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }
    }

    /// <summary>
    /// FloatProperty: searchLightDetectionRadius
    /// </summary>
    public unsafe float searchLightDetectionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// FloatProperty: searchLightRadius
    /// </summary>
    public unsafe float searchLightRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// FloatProperty: trackingLightRadius
    /// </summary>
    public unsafe float trackingLightRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// FloatProperty: searchLightRangeCM
    /// </summary>
    public unsafe float searchLightRangeCM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// FloatProperty: searchSweepPeriod
    /// </summary>
    public unsafe float searchSweepPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// FloatProperty: searchSweepDegrees
    /// </summary>
    public unsafe float searchSweepDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// FloatProperty: VisionRangeExtended
    /// </summary>
    public unsafe float VisionRangeExtended
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// FloatProperty: searchLightTrackingRate_Idle
    /// </summary>
    public unsafe float searchLightTrackingRate_Idle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// FloatProperty: searchLightTrackingRate_Alert
    /// </summary>
    public unsafe float searchLightTrackingRate_Alert
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// FloatProperty: searchLightGiveUpTime
    /// </summary>
    public unsafe float searchLightGiveUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// StructProperty: lightTargetOrientation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT lightTargetOrientation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// FloatProperty: fOverrideSpeed
    /// </summary>
    public unsafe float fOverrideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// StructProperty: LightFloorPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LightFloorPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// StructProperty: lightPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT lightPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// FloatProperty: HoldPositionDistance
    /// </summary>
    public unsafe float HoldPositionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// FloatProperty: HoldPositionDistanceBeginElevation
    /// </summary>
    public unsafe float HoldPositionDistanceBeginElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }

    /// <summary>
    /// FloatProperty: HoldPositionElevation
    /// </summary>
    public unsafe float HoldPositionElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// StructProperty: lightOrientation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT lightOrientation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// ArrayProperty: RemoveMaterialsFromDisruptorMeshList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RemoveMaterialsFromDisruptorMeshList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2004); }
    }

    /// <summary>
    /// FloatProperty: fDisruptorAimMaximumHeight
    /// </summary>
    public unsafe float fDisruptorAimMaximumHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// FloatProperty: fDisruptorAimMaximumRearDistance
    /// </summary>
    public unsafe float fDisruptorAimMaximumRearDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// StrProperty: sRHDScreenTitle
    /// </summary>
    public unsafe BmSDK.FString sRHDScreenTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// ArrayProperty: HelicopterDifficultyLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> HelicopterDifficultyLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceVisualContactLost
    /// </summary>
    public unsafe float TimeSinceVisualContactLost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// NameProperty: DroneCombatEvTag
    /// </summary>
    public unsafe BmSDK.FName DroneCombatEvTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// ArrayProperty: HeliTimeSliceFrameCounts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> HeliTimeSliceFrameCounts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// ArrayProperty: HeliTimeSliceFeatureQueued
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> HeliTimeSliceFeatureQueued
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// IntProperty: framesBetweenDustFXUpdates_Active
    /// </summary>
    public unsafe int framesBetweenDustFXUpdates_Active
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// IntProperty: framesBetweenDustFXUpdates_Inactive
    /// </summary>
    public unsafe int framesBetweenDustFXUpdates_Inactive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// IntProperty: framesBetweenSearchLightTraces
    /// </summary>
    public unsafe int framesBetweenSearchLightTraces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// IntProperty: framesBetweenCrowScares
    /// </summary>
    public unsafe int framesBetweenCrowScares
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// IntProperty: framesBetweenWindGustUpdates
    /// </summary>
    public unsafe int framesBetweenWindGustUpdates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// FloatProperty: windGustDeltaTime
    /// </summary>
    public unsafe float windGustDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// StructProperty: BMLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BMLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// FloatProperty: LastSpottedTime
    /// </summary>
    public unsafe float LastSpottedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ArrayProperty: HelicopterPassengerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> HelicopterPassengerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// ArrayProperty: HelicopterRocketPassengerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> HelicopterRocketPassengerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ArrayProperty: HelicopterAbseilSlots
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> HelicopterAbseilSlots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// FloatProperty: MaxAbseilHeight
    /// </summary>
    public unsafe float MaxAbseilHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// StructProperty: FixedCamLocationOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FixedCamLocationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// StructProperty: FixedCamLocationRange
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FixedCamLocationRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// StructProperty: FixedCamRotationOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FixedCamRotationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// StructProperty: FixedCamRotationRange
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FixedCamRotationRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// FloatProperty: FixedCamFOV
    /// </summary>
    public unsafe float FixedCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// FloatProperty: FixedCamFOVRange
    /// </summary>
    public unsafe float FixedCamFOVRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// FloatProperty: FixedCamMinDist
    /// </summary>
    public unsafe float FixedCamMinDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// FloatProperty: FixedCamMaxDist
    /// </summary>
    public unsafe float FixedCamMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// FloatProperty: FixedCamYawFollowPercent
    /// </summary>
    public unsafe float FixedCamYawFollowPercent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// NameProperty: FixedCamOverlayName
    /// </summary>
    public unsafe BmSDK.FName FixedCamOverlayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// FloatProperty: BoundsRadius
    /// </summary>
    public unsafe float BoundsRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// FloatProperty: BoundsHeight
    /// </summary>
    public unsafe float BoundsHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// StrProperty: sDisruptorHUDDescription
    /// </summary>
    public unsafe BmSDK.FString sDisruptorHUDDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// FloatProperty: BlindedDuration
    /// </summary>
    public unsafe float BlindedDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// ByteProperty: PointOfInterestType
    /// </summary>
    public unsafe byte PointOfInterestType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// FloatProperty: lastBMPOITime
    /// </summary>
    public unsafe float lastBMPOITime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// FloatProperty: PointOfInterestIgnoreTimer
    /// </summary>
    public unsafe float PointOfInterestIgnoreTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// NameProperty: lastBMPOIBarkFlag
    /// </summary>
    public unsafe BmSDK.FName lastBMPOIBarkFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// FloatProperty: PointOfInterestTryTimer
    /// </summary>
    public unsafe float PointOfInterestTryTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// IntProperty: PointOfInterestTimeSliceInt
    /// </summary>
    public unsafe int PointOfInterestTimeSliceInt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// StructProperty: QueuedFinalRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT QueuedFinalRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// FloatProperty: PPSpeed
    /// </summary>
    public unsafe float PPSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// FloatProperty: PPMax
    /// </summary>
    public unsafe float PPMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }
}
