#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicle<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicle : BmSDK.Engine.AkVehicle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicle() { }

    /// <summary>
    /// Constructs a new RVehicle
    /// </summary>
    public RVehicle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicle(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicle>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicle>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicle>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicle>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicle>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicle>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicle>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObstacle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_IInterface_NavMeshPathObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObject
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_IInterface_NavMeshPathObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// FloatProperty: PhysicsSleepingTime
    /// </summary>
    public unsafe float PhysicsSleepingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// IntProperty: MaxHealth
    /// </summary>
    public unsafe int MaxHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ByteProperty: CityDistrict
    /// </summary>
    public unsafe byte CityDistrict
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// ByteProperty: WanderAudioState
    /// </summary>
    public unsafe byte WanderAudioState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2153); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2153); }
    }

    /// <summary>
    /// ByteProperty: SelfDriveMode
    /// </summary>
    public unsafe byte SelfDriveMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2154); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2154); }
    }

    /// <summary>
    /// ByteProperty: LocalRadarTargetType
    /// </summary>
    public unsafe byte LocalRadarTargetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2155); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2155); }
    }

    /// <summary>
    /// ByteProperty: CachedTankLightsOn
    /// </summary>
    public unsafe byte CachedTankLightsOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// ByteProperty: InteriorLightsSwitchedOn
    /// </summary>
    public unsafe byte InteriorLightsSwitchedOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2157); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2157); }
    }

    /// <summary>
    /// ByteProperty: ClimbEdgeFailReason
    /// </summary>
    public unsafe byte ClimbEdgeFailReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2158); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2158); }
    }

    /// <summary>
    /// ByteProperty: EdgeJumpType
    /// </summary>
    public unsafe byte EdgeJumpType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2159); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2159); }
    }

    /// <summary>
    /// ByteProperty: BehaviourRoundRobin
    /// </summary>
    public unsafe byte BehaviourRoundRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ComponentProperty: VisualDamageComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VisualDamageComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ComponentProperty: HitMaskComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HitMaskComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// BoolProperty: bShowOnLocalRadarInBatmobile
    /// </summary>
    public unsafe bool bShowOnLocalRadarInBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveLoop
    /// </summary>
    public unsafe bool SelfDriveLoop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveStopForObstacles
    /// </summary>
    public unsafe bool SelfDriveStopForObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveUseFootpathToAvoidObstacles
    /// </summary>
    public unsafe bool SelfDriveUseFootpathToAvoidObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveTurnOnSpot
    /// </summary>
    public unsafe bool SelfDriveTurnOnSpot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveCanDriveBackwards
    /// </summary>
    public unsafe bool SelfDriveCanDriveBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveBackwards
    /// </summary>
    public unsafe bool SelfDriveBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveErratic
    /// </summary>
    public unsafe bool SelfDriveErratic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveSplineDontStopAtEnd
    /// </summary>
    public unsafe bool SelfDriveSplineDontStopAtEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveCanJumpUp
    /// </summary>
    public unsafe bool SelfDriveCanJumpUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveCanJumpDown
    /// </summary>
    public unsafe bool SelfDriveCanJumpDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveIsSpline
    /// </summary>
    public unsafe bool SelfDriveIsSpline
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: AllowDriveOnFootpath
    /// </summary>
    public unsafe bool AllowDriveOnFootpath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: DriveOnCorrectSide
    /// </summary>
    public unsafe bool DriveOnCorrectSide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveUseTightArea
    /// </summary>
    public unsafe bool SelfDriveUseTightArea
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: GiveVehiclesWideBerth
    /// </summary>
    public unsafe bool GiveVehiclesWideBerth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: IsHeavyTank
    /// </summary>
    public unsafe bool IsHeavyTank
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: IsRigidBodyFixed
    /// </summary>
    public unsafe bool IsRigidBodyFixed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: IsRigidBodyFixedNPC
    /// </summary>
    public unsafe bool IsRigidBodyFixedNPC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bDoXrayLevelFadeCheck
    /// </summary>
    public unsafe bool bDoXrayLevelFadeCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: FakeRoadCollisionStatic
    /// </summary>
    public unsafe bool FakeRoadCollisionStatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: HasFakeRoadCollision
    /// </summary>
    public unsafe bool HasFakeRoadCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawBreadCrumbs
    /// </summary>
    public unsafe bool bDebugDrawBreadCrumbs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bObstacleRegistered
    /// </summary>
    public unsafe bool bObstacleRegistered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bAddNavMeshObstacle
    /// </summary>
    public unsafe bool bAddNavMeshObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bForceUpdateObstacle
    /// </summary>
    public unsafe bool bForceUpdateObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: PawnCollision_DebugVisualisation
    /// </summary>
    public unsafe bool PawnCollision_DebugVisualisation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bInterVehicleCollisionDisabled
    /// </summary>
    public unsafe bool bInterVehicleCollisionDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bBeingTracked
    /// </summary>
    public unsafe bool bBeingTracked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawRoute
    /// </summary>
    public unsafe bool bDebugDrawRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bWasDebugDrawRoute
    /// </summary>
    public unsafe bool bWasDebugDrawRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bForensicsLightActive
    /// </summary>
    public unsafe bool bForensicsLightActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: IsHackedFriendly
    /// </summary>
    public unsafe bool IsHackedFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: HeadlightsSwitchedOn
    /// </summary>
    public unsafe bool HeadlightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: RoofLightsSwitchedOn
    /// </summary>
    public unsafe bool RoofLightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: BootLightsSwitchedOn
    /// </summary>
    public unsafe bool BootLightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: PartyingOn
    /// </summary>
    public unsafe bool PartyingOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: TankLightsSwitchedOn
    /// </summary>
    public unsafe bool TankLightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: bHasDamagedLightState
    /// </summary>
    public unsafe bool bHasDamagedLightState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: MatineeFullyAnimated
    /// </summary>
    public unsafe bool MatineeFullyAnimated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: MatineeBlendAllAxes
    /// </summary>
    public unsafe bool MatineeBlendAllAxes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: MatineeSimpleBlendFromBattleMode
    /// </summary>
    public unsafe bool MatineeSimpleBlendFromBattleMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: MatineeUseCustomAnimNode
    /// </summary>
    public unsafe bool MatineeUseCustomAnimNode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: MatineeDisableFakeWheelUpdate
    /// </summary>
    public unsafe bool MatineeDisableFakeWheelUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: HeavyArmouredVehicle
    /// </summary>
    public unsafe bool HeavyArmouredVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: CivilianVehicle
    /// </summary>
    public unsafe bool CivilianVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: bHasBonnetJump
    /// </summary>
    public unsafe bool bHasBonnetJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: bHasRoofJump
    /// </summary>
    public unsafe bool bHasRoofJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: bRebuildSpecialNavEdges
    /// </summary>
    public unsafe bool bRebuildSpecialNavEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: bHasAPCStyleWeakSpot
    /// </summary>
    public unsafe bool bHasAPCStyleWeakSpot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: SelfDriveRoads
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SelfDriveRoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// ObjectProperty: SelfDriveArrived
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SelfDriveArrived
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// ObjectProperty: SelfDriveAction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SelfDriveAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// ObjectProperty: ObstacleRoads
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ObstacleRoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2212); }
    }

    /// <summary>
    /// ObjectProperty: SelfDriveAvoidedObstacle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SelfDriveAvoidedObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// ObjectProperty: StartElectricalOverloadEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StartElectricalOverloadEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2228); }
    }

    /// <summary>
    /// ObjectProperty: StartElectricalOverloadEvent2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StartElectricalOverloadEvent2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// ObjectProperty: ProxiedToCinematic
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ProxiedToCinematic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// ObjectProperty: KeepyUpActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KeepyUpActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// ObjectProperty: VehicleAggressor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VehicleAggressor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterialMIC
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.XRayRotorMaterialMIC XRayMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.XRayRotorMaterialMIC>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// ObjectProperty: XRayRotorMaterialMIC
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.SelfDriveRoute XRayRotorMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.SelfDriveRoute>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// ObjectProperty: LightsMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LightsMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// ComponentProperty: DestructibleDustTrails
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DestructibleDustTrails_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }
    /// <summary>
    /// ComponentProperty: DestructibleDustTrails
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DestructibleDustTrails_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// ComponentProperty: Interactions
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Interactions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// ArrayProperty: SelfDriveRoute
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>>>>>>> SelfDriveRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>>>>>>>>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// ArrayProperty: SelfDriveRouteSpans
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>>>>>> SelfDriveRouteSpans
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>>>>>>>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// ArrayProperty: SelfDriveRouteLine
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>>>>> SelfDriveRouteLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>>>>>>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// ArrayProperty: SelfDriveRouteSplinePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>>>> SelfDriveRouteSplinePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>>>>>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// IntProperty: SelfDriveNextSpan
    /// </summary>
    public unsafe int SelfDriveNextSpan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveEndPointDist
    /// </summary>
    public unsafe float SelfDriveEndPointDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveKinkDist
    /// </summary>
    public unsafe float SelfDriveKinkDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2388); }
    }

    /// <summary>
    /// StructProperty: SelfDriveForwardTargetLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SelfDriveForwardTargetLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// StructProperty: SelfDriveForwardRoadDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SelfDriveForwardRoadDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveThrottleScale
    /// </summary>
    public unsafe float SelfDriveThrottleScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveThrottleMin
    /// </summary>
    public unsafe float SelfDriveThrottleMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveLineMin
    /// </summary>
    public unsafe float SelfDriveLineMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveLineMax
    /// </summary>
    public unsafe float SelfDriveLineMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveEndPointDistNeutralLine
    /// </summary>
    public unsafe float SelfDriveEndPointDistNeutralLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveMinSpanWidth
    /// </summary>
    public unsafe float SelfDriveMinSpanWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveThrottleEaseDistance
    /// </summary>
    public unsafe float SelfDriveThrottleEaseDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// IntProperty: SelfDriveKeepToSide
    /// </summary>
    public unsafe int SelfDriveKeepToSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveWheelspinTime
    /// </summary>
    public unsafe float SelfDriveWheelspinTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveBrakeLights
    /// </summary>
    public unsafe float SelfDriveBrakeLights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveSkidToStopTime
    /// </summary>
    public unsafe float SelfDriveSkidToStopTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveExtraWidth
    /// </summary>
    public unsafe float SelfDriveExtraWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// StructProperty: SelfDriveStartLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SelfDriveStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// StructProperty: SelfDriveTargetLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SelfDriveTargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// StructProperty: SelfDriveTightAreaDest
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SelfDriveTightAreaDest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// ArrayProperty: SelfDriveTightAreaRoute
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>>> SelfDriveTightAreaRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>>>>(Ptr + 2500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2500); }
    }

    /// <summary>
    /// StructProperty: SelfDriveTightArea
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SelfDriveTightArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// StructProperty: RoadObstacleType
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RoadObstacleType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// StructProperty: RoadObstacleAvoidTypes
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RoadObstacleAvoidTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// StructProperty: RoadObstacleStopForTypes
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RoadObstacleStopForTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// IntProperty: RoadObstacleAvoidBits
    /// </summary>
    public unsafe int RoadObstacleAvoidBits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// IntProperty: RoadObstacleStopForBits
    /// </summary>
    public unsafe int RoadObstacleStopForBits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// IntProperty: ObstacleIndex
    /// </summary>
    public unsafe int ObstacleIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// StructProperty: RoadObstacleExtraBounds
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RoadObstacleExtraBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// FloatProperty: RoadLevelSearchBias
    /// </summary>
    public unsafe float RoadLevelSearchBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// FloatProperty: ObstacleAhead
    /// </summary>
    public unsafe float ObstacleAhead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// FloatProperty: ObstacleAheadStopThreshold
    /// </summary>
    public unsafe float ObstacleAheadStopThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// FloatProperty: ObstacleAheadTime
    /// </summary>
    public unsafe float ObstacleAheadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// FloatProperty: SmashAbandonedVehicleSpeedThreshold
    /// </summary>
    public unsafe float SmashAbandonedVehicleSpeedThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ArrayProperty: CachedRoadPhysxShapeData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>> CachedRoadPhysxShapeData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>>>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }

    /// <summary>
    /// FloatProperty: FakeRoadOffsetZ
    /// </summary>
    public unsafe float FakeRoadOffsetZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// StructProperty: FakeRoadNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FakeRoadNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// FloatProperty: FakeRoadStickyTime
    /// </summary>
    public unsafe float FakeRoadStickyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// ArrayProperty: DebugBreadCrumbs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>> DebugBreadCrumbs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// IntProperty: MaxBreadCrumbs
    /// </summary>
    public unsafe int MaxBreadCrumbs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// FloatProperty: DynamicNavMeshShapeHeightOffset
    /// </summary>
    public unsafe float DynamicNavMeshShapeHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2652); }
    }

    /// <summary>
    /// StructProperty: PreviousObstacleLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PreviousObstacleLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_SideCheckDist_Min
    /// </summary>
    public unsafe float PawnCollision_SideCheckDist_Min
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2668); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_SideCheckDist_Max
    /// </summary>
    public unsafe float PawnCollision_SideCheckDist_Max
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_CosCheck_Front
    /// </summary>
    public unsafe float PawnCollision_CosCheck_Front
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2676); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_CosCheck_Side
    /// </summary>
    public unsafe float PawnCollision_CosCheck_Side
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_LookAhead_SpeedMultiplier
    /// </summary>
    public unsafe float PawnCollision_LookAhead_SpeedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2684); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_LookAhead_BaseDist
    /// </summary>
    public unsafe float PawnCollision_LookAhead_BaseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_LookAhead_Min
    /// </summary>
    public unsafe float PawnCollision_LookAhead_Min
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2692); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_BackAdjustment
    /// </summary>
    public unsafe float PawnCollision_BackAdjustment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// ArrayProperty: LocationHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>> LocationHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>>(Ptr + 2700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2700); }
    }

    /// <summary>
    /// IntProperty: LocationHistorySize
    /// </summary>
    public unsafe int LocationHistorySize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2716); }
    }

    /// <summary>
    /// StructProperty: JumpOrigin
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JumpOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// IntProperty: JumpYaw
    /// </summary>
    public unsafe int JumpYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }

    /// <summary>
    /// StructProperty: WinchAttachLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WinchAttachLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// FloatProperty: DriftSteeringAssist
    /// </summary>
    public unsafe float DriftSteeringAssist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2748); }
    }

    /// <summary>
    /// FloatProperty: DriftSteeringBias
    /// </summary>
    public unsafe float DriftSteeringBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// FloatProperty: DriftSteeringBiasSign
    /// </summary>
    public unsafe float DriftSteeringBiasSign
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2756); }
    }

    /// <summary>
    /// FloatProperty: ShootAtLocationZOffset
    /// </summary>
    public unsafe float ShootAtLocationZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }

    /// <summary>
    /// StructProperty: CachedLightMat1234
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CachedLightMat1234
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2764); }
    }

    /// <summary>
    /// StructProperty: CachedLightMat5678
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CachedLightMat5678
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }

    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2796); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2988); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3036); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3084); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3132); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3228); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3276); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3324); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3372); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3420); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3468); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3516); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3564); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3612); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3660); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3708); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3756); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3804); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3852); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3900); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3948); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3996); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VehicleLights_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4092); }
    }

    /// <summary>
    /// ArrayProperty: LightsMaterialInst
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>> LightsMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>>(Ptr + 4140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4140); }
    }

    /// <summary>
    /// FloatProperty: CarElectricalOverloadTime
    /// </summary>
    public unsafe float CarElectricalOverloadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }

    /// <summary>
    /// FloatProperty: LightsBrightness
    /// </summary>
    public unsafe float LightsBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4160); }
    }

    /// <summary>
    /// IntProperty: UseIndoorLights
    /// </summary>
    public unsafe int UseIndoorLights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }

    /// <summary>
    /// FloatProperty: IndoorLightsFade
    /// </summary>
    public unsafe float IndoorLightsFade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4168); }
    }

    /// <summary>
    /// FloatProperty: FrontWheelsExtraSpinVel
    /// </summary>
    public unsafe float FrontWheelsExtraSpinVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4172); }
    }

    /// <summary>
    /// FloatProperty: RearWheelsExtraSpinVel
    /// </summary>
    public unsafe float RearWheelsExtraSpinVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4176); }
    }

    /// <summary>
    /// FloatProperty: MatineeTurretPitch
    /// </summary>
    public unsafe float MatineeTurretPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4180); }
    }

    /// <summary>
    /// FloatProperty: MatineeTurretYaw
    /// </summary>
    public unsafe float MatineeTurretYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4184); }
    }

    /// <summary>
    /// FloatProperty: MatineeDeltaTime
    /// </summary>
    public unsafe float MatineeDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4188); }
    }

    /// <summary>
    /// StructProperty: MatineePrevLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MatineePrevLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4192); }
    }

    /// <summary>
    /// StructProperty: MatineePrevRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MatineePrevRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4204); }
    }

    /// <summary>
    /// StructProperty: MatineeBindLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MatineeBindLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }

    /// <summary>
    /// StructProperty: MatineeBindRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MatineeBindRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// StructProperty: MatineeAnimLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MatineeAnimLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4240); }
    }

    /// <summary>
    /// StructProperty: MatineeAnimRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MatineeAnimRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4256); }
    }

    /// <summary>
    /// StructProperty: MatineeInitialLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MatineeInitialLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// StructProperty: MatineeInitialRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MatineeInitialRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4284); }
    }

    /// <summary>
    /// FloatProperty: MatineeBlendDuration
    /// </summary>
    public unsafe float MatineeBlendDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// FloatProperty: MatineeForwardVel
    /// </summary>
    public unsafe float MatineeForwardVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// FloatProperty: MatineeForwardAcc
    /// </summary>
    public unsafe float MatineeForwardAcc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4304); }
    }

    /// <summary>
    /// ArrayProperty: RainMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>> RainMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>>(Ptr + 4308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4308); }
    }

    /// <summary>
    /// FloatProperty: RainAccumulationAlpha
    /// </summary>
    public unsafe float RainAccumulationAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4324); }
    }

    /// <summary>
    /// FloatProperty: WetnessAccumulationAlpha
    /// </summary>
    public unsafe float WetnessAccumulationAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// NameProperty: RainParameterName
    /// </summary>
    public unsafe BmSDK.FName RainParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4332); }
    }

    /// <summary>
    /// StructProperty: LastRainParam
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastRainParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }

    /// <summary>
    /// StructProperty: TorqueToApply
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TorqueToApply
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4356); }
    }

    /// <summary>
    /// StructProperty: ForceToApply
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ForceToApply
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// StructProperty: ForceToApplyPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ForceToApplyPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4380); }
    }

    /// <summary>
    /// FloatProperty: KeepyUpVelocityFactor
    /// </summary>
    public unsafe float KeepyUpVelocityFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4392); }
    }

    /// <summary>
    /// IntProperty: MatineeControlRefCount
    /// </summary>
    public unsafe int MatineeControlRefCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4396); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceSparks
    /// </summary>
    public unsafe float TimeSinceSparks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4400); }
    }

    /// <summary>
    /// FloatProperty: DestructiblesImpactDamageMultiplier
    /// </summary>
    public unsafe float DestructiblesImpactDamageMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4404); }
    }

    /// <summary>
    /// ArrayProperty: SpecialNavEdgeList
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SpecialNavEdgeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 4408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4408); }
    }

    /// <summary>
    /// ArrayProperty: SpecialNavEdgeList_SubMesh
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SpecialNavEdgeList_SubMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 4424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4424); }
    }

    /// <summary>
    /// ArrayProperty: EdgeTraversers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys> EdgeTraversers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkVehicle.WhooshBys>>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }

    /// <summary>
    /// StructProperty: SeaWallPhysxActor0
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SeaWallPhysxActor0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }

    /// <summary>
    /// StructProperty: SeaWallPhysxShape0
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SeaWallPhysxShape0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4464); }
    }

    /// <summary>
    /// StructProperty: SeaWallPhysxActor1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SeaWallPhysxActor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }

    /// <summary>
    /// StructProperty: SeaWallPhysxShape1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SeaWallPhysxShape1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }

    /// <summary>
    /// StructProperty: CapeCollisionPhysXActor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CapeCollisionPhysXActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4488); }
    }

    /// <summary>
    /// StructProperty: AsyncJob
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AsyncJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4496); }
    }

    /// <summary>
    /// StructProperty: NPCCheckExtents
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NPCCheckExtents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4504); }
    }

    /// <summary>
    /// StructProperty: NPCCheckOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NPCCheckOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }

    /// <summary>
    /// FloatProperty: RoundRobinAccumulationTime
    /// </summary>
    public unsafe float RoundRobinAccumulationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4528); }
    }

    /// <summary>
    /// IntProperty: VehicleListIndex
    /// </summary>
    public unsafe int VehicleListIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4532); }
    }

    /// <summary>
    /// FloatProperty: LastXrayMatUpdateTime
    /// </summary>
    public unsafe float LastXrayMatUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4536); }
    }

    /// <summary>
    /// FloatProperty: CurrentXRayAlpha
    /// </summary>
    public unsafe float CurrentXRayAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4540); }
    }

    /// <summary>
    /// IntProperty: iXrayMaterialExcludeIndex
    /// </summary>
    public unsafe int iXrayMaterialExcludeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4544); }
    }

    /// <summary>
    /// IntProperty: iXrayMaterialExcludeIndex2
    /// </summary>
    public unsafe int iXrayMaterialExcludeIndex2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4548); }
    }

    /// <summary>
    /// FloatProperty: MinDetectiveModeFadeDist
    /// </summary>
    public unsafe float MinDetectiveModeFadeDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4552); }
    }

    /// <summary>
    /// FloatProperty: MaxDetectiveModeFadeDist
    /// </summary>
    public unsafe float MaxDetectiveModeFadeDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4556); }
    }
}
