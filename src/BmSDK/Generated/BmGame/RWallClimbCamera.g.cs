#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RWallClimbCamera<br/>
/// (flags = 0)
/// </summary>
public partial class RWallClimbCamera : BmSDK.BmGame.RCameraActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RWallClimbCamera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RWallClimbCamera() { }

    /// <summary>
    /// Constructs a new RWallClimbCamera
    /// </summary>
    public RWallClimbCamera(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RWallClimbCamera Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RWallClimbCamera(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RWallClimbCamera>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RWallClimbCamera>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RWallClimbCamera>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RWallClimbCamera>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RWallClimbCamera>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RWallClimbCamera>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RWallClimbCamera>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: InitialRot
    /// </summary>
    public unsafe BmSDK.Rotator InitialRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: maxPitch
    /// </summary>
    public unsafe float maxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// FloatProperty: MaxYaw
    /// </summary>
    public unsafe float MaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// FloatProperty: BlendInTimeFromSwing
    /// </summary>
    public unsafe float BlendInTimeFromSwing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// FloatProperty: BlendInTimeFromGround
    /// </summary>
    public unsafe float BlendInTimeFromGround
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// FloatProperty: BlendOutTime
    /// </summary>
    public unsafe float BlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// FloatProperty: NormalBlendOutTime
    /// </summary>
    public unsafe float NormalBlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// FloatProperty: LedgeBlendOutTime
    /// </summary>
    public unsafe float LedgeBlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// FloatProperty: TimeToBlendout
    /// </summary>
    public unsafe float TimeToBlendout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: PlayerTargetWeight
    /// </summary>
    public unsafe float PlayerTargetWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// StructProperty: CameraRoot
    /// </summary>
    public unsafe System.Numerics.Vector3 CameraRoot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// StructProperty: TargetLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 TargetLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// FloatProperty: CamDistance
    /// </summary>
    public unsafe float CamDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// FloatProperty: CamHeight
    /// </summary>
    public unsafe float CamHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// FloatProperty: ExtraVantageDistance
    /// </summary>
    public unsafe float ExtraVantageDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// StructProperty: LastRootSpeed
    /// </summary>
    public unsafe System.Numerics.Vector3 LastRootSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// StructProperty: LastTargetSpeed
    /// </summary>
    public unsafe System.Numerics.Vector3 LastTargetSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// StructProperty: LastDesiredPosSpeed
    /// </summary>
    public unsafe System.Numerics.Vector3 LastDesiredPosSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: InitialLookAtSpeed
    /// </summary>
    public unsafe float InitialLookAtSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// FloatProperty: LookAtSpeed
    /// </summary>
    public unsafe float LookAtSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// FloatProperty: FinalLookAtSpeed
    /// </summary>
    public unsafe float FinalLookAtSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// FloatProperty: FromSwingLookAtFactor
    /// </summary>
    public unsafe float FromSwingLookAtFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// FloatProperty: MoveSpeed
    /// </summary>
    public unsafe float MoveSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// FloatProperty: FinalMoveSpeed
    /// </summary>
    public unsafe float FinalMoveSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// FloatProperty: FastCollidedMoveSpeed
    /// </summary>
    public unsafe float FastCollidedMoveSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// ObjectProperty: Target
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCatwomanBase Target
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCatwomanBase>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ObjectProperty: GrappleGun
    /// </summary>
    public unsafe BmSDK.BmGame.RCwGrappleGunBase GrappleGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// ObjectProperty: PC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController PC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCamera
    /// </summary>
    public unsafe BmSDK.BmGame.R3rdPersonCamera PlayerCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R3rdPersonCamera>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bInitialised
    /// </summary>
    public unsafe bool bInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bFirstPoint
    /// </summary>
    public unsafe bool bFirstPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bFinalLocation
    /// </summary>
    public unsafe bool bFinalLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bBlendingOut
    /// </summary>
    public unsafe bool bBlendingOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bStartedFromSwing
    /// </summary>
    public unsafe bool bStartedFromSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bOvershot
    /// </summary>
    public unsafe bool bOvershot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bUseOvershotParams
    /// </summary>
    public unsafe bool bUseOvershotParams
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bSuspendMoveUpdates
    /// </summary>
    public unsafe bool bSuspendMoveUpdates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bStepMoveUpdates
    /// </summary>
    public unsafe bool bStepMoveUpdates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bDebugCameraUpdates
    /// </summary>
    public unsafe bool bDebugCameraUpdates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bDebugCameraCollision
    /// </summary>
    public unsafe bool bDebugCameraCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bDebugDisableSmoothing
    /// </summary>
    public unsafe bool bDebugDisableSmoothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bRotationFixedOnTarget
    /// </summary>
    public unsafe bool bRotationFixedOnTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bWideFOVAngle
    /// </summary>
    public unsafe bool bWideFOVAngle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// BoolProperty: bFirstTick
    /// </summary>
    public unsafe bool bFirstTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1428); }
    }

    /// <summary>
    /// IntProperty: MinClimbPointIndex
    /// </summary>
    public unsafe int MinClimbPointIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// IntProperty: NextClimbIndex
    /// </summary>
    public unsafe int NextClimbIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// StructProperty: LastWallLandLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastWallLandLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// StructProperty: ExtraCameraRot
    /// </summary>
    public unsafe BmSDK.Rotator ExtraCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// FloatProperty: LookModeScale
    /// </summary>
    public unsafe float LookModeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// FloatProperty: MaxExtraPitch
    /// </summary>
    public unsafe float MaxExtraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// FloatProperty: MinExtraPitch
    /// </summary>
    public unsafe float MinExtraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// FloatProperty: MaxExtraYaw
    /// </summary>
    public unsafe float MaxExtraYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// FloatProperty: MinExtraYaw
    /// </summary>
    public unsafe float MinExtraYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// StructProperty: FinalLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 FinalLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// StructProperty: FinalNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 FinalNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// FloatProperty: Spring
    /// </summary>
    public unsafe float Spring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// FloatProperty: Spring2
    /// </summary>
    public unsafe float Spring2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: Damper
    /// </summary>
    public unsafe float Damper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// FloatProperty: Damper2
    /// </summary>
    public unsafe float Damper2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// FloatProperty: Mass
    /// </summary>
    public unsafe float Mass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// FloatProperty: Mass2
    /// </summary>
    public unsafe float Mass2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// FloatProperty: MaxSpeed
    /// </summary>
    public unsafe float MaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// FloatProperty: MaxDampingRange
    /// </summary>
    public unsafe float MaxDampingRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// FloatProperty: SwingBlendInForwardOffset
    /// </summary>
    public unsafe float SwingBlendInForwardOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// FloatProperty: BlendFactor
    /// </summary>
    public unsafe float BlendFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// StructProperty: Smoother
    /// </summary>
    public unsafe BmSDK.BmGame.R3rdPersonCamera.FCameraSmoother Smoother
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R3rdPersonCamera.FCameraSmoother>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// StructProperty: TargetOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 TargetOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }
}
