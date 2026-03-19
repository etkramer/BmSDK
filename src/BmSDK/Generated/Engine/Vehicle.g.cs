#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Vehicle<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class Vehicle : BmSDK.Engine.Pawn, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Vehicle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Vehicle() { }

    /// <summary>
    /// Constructs a new Vehicle
    /// </summary>
    public Vehicle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Vehicle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Vehicle(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Vehicle>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Vehicle>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Vehicle>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Vehicle>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Vehicle>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Vehicle>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Vehicle>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Driver
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Driver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// ClassProperty: CrushedDamageType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CrushedDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// BoolProperty: bDriving
    /// </summary>
    public unsafe bool bDriving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bDriverIsVisible
    /// </summary>
    public unsafe bool bDriverIsVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bAttachDriver
    /// </summary>
    public unsafe bool bAttachDriver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bTurnInPlace
    /// </summary>
    public unsafe bool bTurnInPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bSeparateTurretFocus
    /// </summary>
    public unsafe bool bSeparateTurretFocus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bFollowLookDir
    /// </summary>
    public unsafe bool bFollowLookDir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bHasHandbrake
    /// </summary>
    public unsafe bool bHasHandbrake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bScriptedRise
    /// </summary>
    public unsafe bool bScriptedRise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bDuckObstacles
    /// </summary>
    public unsafe bool bDuckObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bAvoidReversing
    /// </summary>
    public unsafe bool bAvoidReversing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bRetryPathfindingWithDriver
    /// </summary>
    public unsafe bool bRetryPathfindingWithDriver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreStallZ
    /// </summary>
    public unsafe bool bIgnoreStallZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: bDoExtraNetRelevancyTraces
    /// </summary>
    public unsafe bool bDoExtraNetRelevancyTraces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// BoolProperty: AllowDriveWithoutDriver
    /// </summary>
    public unsafe bool AllowDriveWithoutDriver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1496); }
    }

    /// <summary>
    /// ArrayProperty: ExitPositions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ExitPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// FloatProperty: ExitRadius
    /// </summary>
    public unsafe float ExitRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// StructProperty: ExitOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExitOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// FloatProperty: Steering
    /// </summary>
    public unsafe float Steering
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// FloatProperty: Throttle
    /// </summary>
    public unsafe float Throttle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// FloatProperty: Rise
    /// </summary>
    public unsafe float Rise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// StructProperty: TargetLocationAdjustment
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TargetLocationAdjustment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// FloatProperty: DriverDamageMult
    /// </summary>
    public unsafe float DriverDamageMult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// FloatProperty: MomentumMult
    /// </summary>
    public unsafe float MomentumMult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// FloatProperty: MinCrushSpeed
    /// </summary>
    public unsafe float MinCrushSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// FloatProperty: ForceCrushPenetration
    /// </summary>
    public unsafe float ForceCrushPenetration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// ByteProperty: StuckCount
    /// </summary>
    public unsafe byte StuckCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// FloatProperty: ThrottleTime
    /// </summary>
    public unsafe float ThrottleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// FloatProperty: StuckTime
    /// </summary>
    public unsafe float StuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// FloatProperty: OldSteering
    /// </summary>
    public unsafe float OldSteering
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// FloatProperty: OnlySteeringStartTime
    /// </summary>
    public unsafe float OnlySteeringStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// FloatProperty: OldThrottle
    /// </summary>
    public unsafe float OldThrottle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// FloatProperty: AIMoveCheckTime
    /// </summary>
    public unsafe float AIMoveCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// FloatProperty: VehicleMovingTime
    /// </summary>
    public unsafe float VehicleMovingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// FloatProperty: TurnTime
    /// </summary>
    public unsafe float TurnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }
}
