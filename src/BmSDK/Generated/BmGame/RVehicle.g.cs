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
    public unsafe System.IntPtr VfTable_IInterface_NavMeshPathObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObject
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavMeshPathObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2136); }
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
    public unsafe BmSDK.BmGame.RVehicle.EWanderAudioState WanderAudioState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.EWanderAudioState>(Ptr + 2153); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2153); }
    }

    /// <summary>
    /// ByteProperty: SelfDriveMode
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.ESelfDriveMode SelfDriveMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.ESelfDriveMode>(Ptr + 2154); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2154); }
    }

    /// <summary>
    /// ByteProperty: LocalRadarTargetType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.ELocalRadarTargetType LocalRadarTargetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.ELocalRadarTargetType>(Ptr + 2155); }
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
    public unsafe BmSDK.BmGame.RGameInfo.EClimbEdgeFailReason ClimbEdgeFailReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EClimbEdgeFailReason>(Ptr + 2158); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2158); }
    }

    /// <summary>
    /// ByteProperty: EdgeJumpType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FenceJumpEdgeType EdgeJumpType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FenceJumpEdgeType>(Ptr + 2159); }
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
    public unsafe BmSDK.BmGame.RVisualDamageComponent VisualDamageComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVisualDamageComponent>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ComponentProperty: HitMaskComp
    /// </summary>
    public unsafe BmSDK.Engine.SceneCapture2DHitMaskComponent HitMaskComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SceneCapture2DHitMaskComponent>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// BoolProperty: bShowOnLocalRadarInBatmobile
    /// </summary>
    public unsafe bool bShowOnLocalRadarInBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveLoop
    /// </summary>
    public unsafe bool SelfDriveLoop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveStopForObstacles
    /// </summary>
    public unsafe bool SelfDriveStopForObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveUseFootpathToAvoidObstacles
    /// </summary>
    public unsafe bool SelfDriveUseFootpathToAvoidObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveTurnOnSpot
    /// </summary>
    public unsafe bool SelfDriveTurnOnSpot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveCanDriveBackwards
    /// </summary>
    public unsafe bool SelfDriveCanDriveBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveBackwards
    /// </summary>
    public unsafe bool SelfDriveBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveErratic
    /// </summary>
    public unsafe bool SelfDriveErratic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveSplineDontStopAtEnd
    /// </summary>
    public unsafe bool SelfDriveSplineDontStopAtEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveCanJumpUp
    /// </summary>
    public unsafe bool SelfDriveCanJumpUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveCanJumpDown
    /// </summary>
    public unsafe bool SelfDriveCanJumpDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveIsSpline
    /// </summary>
    public unsafe bool SelfDriveIsSpline
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: AllowDriveOnFootpath
    /// </summary>
    public unsafe bool AllowDriveOnFootpath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: DriveOnCorrectSide
    /// </summary>
    public unsafe bool DriveOnCorrectSide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveUseTightArea
    /// </summary>
    public unsafe bool SelfDriveUseTightArea
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: GiveVehiclesWideBerth
    /// </summary>
    public unsafe bool GiveVehiclesWideBerth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: IsHeavyTank
    /// </summary>
    public unsafe bool IsHeavyTank
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: IsRigidBodyFixed
    /// </summary>
    public unsafe bool IsRigidBodyFixed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: IsRigidBodyFixedNPC
    /// </summary>
    public unsafe bool IsRigidBodyFixedNPC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bDoXrayLevelFadeCheck
    /// </summary>
    public unsafe bool bDoXrayLevelFadeCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: FakeRoadCollisionStatic
    /// </summary>
    public unsafe bool FakeRoadCollisionStatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: HasFakeRoadCollision
    /// </summary>
    public unsafe bool HasFakeRoadCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawBreadCrumbs
    /// </summary>
    public unsafe bool bDebugDrawBreadCrumbs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bObstacleRegistered
    /// </summary>
    public unsafe bool bObstacleRegistered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bAddNavMeshObstacle
    /// </summary>
    public unsafe bool bAddNavMeshObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bForceUpdateObstacle
    /// </summary>
    public unsafe bool bForceUpdateObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: PawnCollision_DebugVisualisation
    /// </summary>
    public unsafe bool PawnCollision_DebugVisualisation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bInterVehicleCollisionDisabled
    /// </summary>
    public unsafe bool bInterVehicleCollisionDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bBeingTracked
    /// </summary>
    public unsafe bool bBeingTracked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawRoute
    /// </summary>
    public unsafe bool bDebugDrawRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bWasDebugDrawRoute
    /// </summary>
    public unsafe bool bWasDebugDrawRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: bForensicsLightActive
    /// </summary>
    public unsafe bool bForensicsLightActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2180); }
    }

    /// <summary>
    /// BoolProperty: IsHackedFriendly
    /// </summary>
    public unsafe bool IsHackedFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: HeadlightsSwitchedOn
    /// </summary>
    public unsafe bool HeadlightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: RoofLightsSwitchedOn
    /// </summary>
    public unsafe bool RoofLightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: BootLightsSwitchedOn
    /// </summary>
    public unsafe bool BootLightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: PartyingOn
    /// </summary>
    public unsafe bool PartyingOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: TankLightsSwitchedOn
    /// </summary>
    public unsafe bool TankLightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: bHasDamagedLightState
    /// </summary>
    public unsafe bool bHasDamagedLightState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: MatineeFullyAnimated
    /// </summary>
    public unsafe bool MatineeFullyAnimated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: MatineeBlendAllAxes
    /// </summary>
    public unsafe bool MatineeBlendAllAxes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: MatineeSimpleBlendFromBattleMode
    /// </summary>
    public unsafe bool MatineeSimpleBlendFromBattleMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: MatineeUseCustomAnimNode
    /// </summary>
    public unsafe bool MatineeUseCustomAnimNode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: MatineeDisableFakeWheelUpdate
    /// </summary>
    public unsafe bool MatineeDisableFakeWheelUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: HeavyArmouredVehicle
    /// </summary>
    public unsafe bool HeavyArmouredVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: CivilianVehicle
    /// </summary>
    public unsafe bool CivilianVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: bHasBonnetJump
    /// </summary>
    public unsafe bool bHasBonnetJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: bHasRoofJump
    /// </summary>
    public unsafe bool bHasRoofJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: bRebuildSpecialNavEdges
    /// </summary>
    public unsafe bool bRebuildSpecialNavEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// BoolProperty: bHasAPCStyleWeakSpot
    /// </summary>
    public unsafe bool bHasAPCStyleWeakSpot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: SelfDriveRoads
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork SelfDriveRoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// ObjectProperty: SelfDriveArrived
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour SelfDriveArrived
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// ObjectProperty: SelfDriveAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_VehicleSelfDrive SelfDriveAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_VehicleSelfDrive>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// ObjectProperty: ObstacleRoads
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork ObstacleRoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 2212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2212); }
    }

    /// <summary>
    /// ObjectProperty: SelfDriveAvoidedObstacle
    /// </summary>
    public unsafe BmSDK.Engine.Actor SelfDriveAvoidedObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// ObjectProperty: StartElectricalOverloadEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StartElectricalOverloadEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2228); }
    }

    /// <summary>
    /// ObjectProperty: StartElectricalOverloadEvent2
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StartElectricalOverloadEvent2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// ObjectProperty: ProxiedToCinematic
    /// </summary>
    public unsafe BmSDK.BmGame.RCinematicVehicle ProxiedToCinematic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCinematicVehicle>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// ObjectProperty: KeepyUpActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor KeepyUpActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// ObjectProperty: VehicleAggressor
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle VehicleAggressor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// ObjectProperty: XRayRotorMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayRotorMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// ObjectProperty: LightsMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant LightsMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// ComponentProperty: DestructibleDustTrails
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DestructibleDustTrails_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }
    /// <summary>
    /// ComponentProperty: DestructibleDustTrails
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DestructibleDustTrails_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// ComponentProperty: Interactions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent Interactions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// ArrayProperty: SelfDriveRoute
    /// </summary>
    public unsafe BmSDK.TArray<int> SelfDriveRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// ArrayProperty: SelfDriveRouteSpans
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan> SelfDriveRouteSpans
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan>>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// ArrayProperty: SelfDriveRouteLine
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRacingLineSeg> SelfDriveRouteLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRacingLineSeg>>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// ArrayProperty: SelfDriveRouteSplinePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadSplinePoint> SelfDriveRouteSplinePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadSplinePoint>>(Ptr + 2364); }
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
    public unsafe System.Numerics.Vector3 SelfDriveForwardTargetLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// StructProperty: SelfDriveForwardRoadDir
    /// </summary>
    public unsafe System.Numerics.Vector3 SelfDriveForwardRoadDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2404); }
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
    public unsafe System.Numerics.Vector3 SelfDriveStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// StructProperty: SelfDriveTargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 SelfDriveTargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// StructProperty: SelfDriveTightAreaDest
    /// </summary>
    public unsafe System.Numerics.Vector3 SelfDriveTightAreaDest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// ArrayProperty: SelfDriveTightAreaRoute
    /// </summary>
    public unsafe BmSDK.TArray<int> SelfDriveTightAreaRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2500); }
    }

    /// <summary>
    /// StructProperty: SelfDriveTightArea
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork.FRoadNetworkTightArea SelfDriveTightArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadNetworkTightArea>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// StructProperty: RoadObstacleType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FRoadObstacleTypes RoadObstacleType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FRoadObstacleTypes>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// StructProperty: RoadObstacleAvoidTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FRoadObstacleTypes RoadObstacleAvoidTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FRoadObstacleTypes>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// StructProperty: RoadObstacleStopForTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FRoadObstacleTypes RoadObstacleStopForTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FRoadObstacleTypes>(Ptr + 2548); }
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
    public unsafe System.Numerics.Vector3 RoadObstacleExtraBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2564); }
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
    public unsafe BmSDK.TArray<byte> CachedRoadPhysxShapeData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 2596); }
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
    public unsafe System.Numerics.Vector3 FakeRoadNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2616); }
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
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicle.FBreadCrumb> DebugBreadCrumbs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicle.FBreadCrumb>>(Ptr + 2632); }
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
    public unsafe System.Numerics.Vector3 PreviousObstacleLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2656); }
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
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicle.FLocationHistoryInfo> LocationHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicle.FLocationHistoryInfo>>(Ptr + 2700); }
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
    public unsafe System.Numerics.Vector3 JumpOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2720); }
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
    public unsafe System.Numerics.Vector3 WinchAttachLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2736); }
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
    public unsafe BmSDK.GameObject.FLinearColor CachedLightMat1234
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 2764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2764); }
    }

    /// <summary>
    /// StructProperty: CachedLightMat5678
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor CachedLightMat5678
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }

    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 2796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2796); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 2988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2988); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3036); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3084); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3132); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3228); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3276); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3324); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3372); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3420); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3468); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3516); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3564); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3612); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3660); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3708); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3756); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3804); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3852); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3900); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3948); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 3996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3996); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 4092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4092); }
    }

    /// <summary>
    /// ArrayProperty: LightsMaterialInst
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> LightsMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 4140); }
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
    public unsafe System.Numerics.Vector3 MatineePrevLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4192); }
    }

    /// <summary>
    /// StructProperty: MatineePrevRot
    /// </summary>
    public unsafe BmSDK.Rotator MatineePrevRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 4204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4204); }
    }

    /// <summary>
    /// StructProperty: MatineeBindLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 MatineeBindLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }

    /// <summary>
    /// StructProperty: MatineeBindRot
    /// </summary>
    public unsafe BmSDK.Rotator MatineeBindRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// StructProperty: MatineeAnimLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 MatineeAnimLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4240); }
    }

    /// <summary>
    /// StructProperty: MatineeAnimRot
    /// </summary>
    public unsafe BmSDK.GameObject.FQuat MatineeAnimRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FQuat>(Ptr + 4256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4256); }
    }

    /// <summary>
    /// StructProperty: MatineeInitialLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 MatineeInitialLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// StructProperty: MatineeInitialRot
    /// </summary>
    public unsafe BmSDK.Rotator MatineeInitialRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 4284); }
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
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> RainMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 4308); }
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
    public unsafe BmSDK.GameObject.FLinearColor LastRainParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }

    /// <summary>
    /// StructProperty: TorqueToApply
    /// </summary>
    public unsafe System.Numerics.Vector3 TorqueToApply
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4356); }
    }

    /// <summary>
    /// StructProperty: ForceToApply
    /// </summary>
    public unsafe System.Numerics.Vector3 ForceToApply
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// StructProperty: ForceToApplyPos
    /// </summary>
    public unsafe System.Numerics.Vector3 ForceToApplyPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4380); }
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
    public unsafe BmSDK.TArray<System.IntPtr> SpecialNavEdgeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 4408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4408); }
    }

    /// <summary>
    /// ArrayProperty: SpecialNavEdgeList_SubMesh
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> SpecialNavEdgeList_SubMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 4424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4424); }
    }

    /// <summary>
    /// ArrayProperty: EdgeTraversers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> EdgeTraversers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }

    /// <summary>
    /// StructProperty: SeaWallPhysxActor0
    /// </summary>
    public unsafe System.IntPtr SeaWallPhysxActor0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }

    /// <summary>
    /// StructProperty: SeaWallPhysxShape0
    /// </summary>
    public unsafe System.IntPtr SeaWallPhysxShape0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4464); }
    }

    /// <summary>
    /// StructProperty: SeaWallPhysxActor1
    /// </summary>
    public unsafe System.IntPtr SeaWallPhysxActor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }

    /// <summary>
    /// StructProperty: SeaWallPhysxShape1
    /// </summary>
    public unsafe System.IntPtr SeaWallPhysxShape1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }

    /// <summary>
    /// StructProperty: CapeCollisionPhysXActor
    /// </summary>
    public unsafe System.IntPtr CapeCollisionPhysXActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4488); }
    }

    /// <summary>
    /// StructProperty: AsyncJob
    /// </summary>
    public unsafe System.IntPtr AsyncJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4496); }
    }

    /// <summary>
    /// StructProperty: NPCCheckExtents
    /// </summary>
    public unsafe System.Numerics.Vector3 NPCCheckExtents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4504); }
    }

    /// <summary>
    /// StructProperty: NPCCheckOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 NPCCheckOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4516); }
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
