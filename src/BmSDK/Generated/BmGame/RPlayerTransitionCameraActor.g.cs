#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPlayerTransitionCameraActor<br/>
/// (flags = 0)
/// </summary>
public partial class RPlayerTransitionCameraActor : BmSDK.BmGame.RCameraActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPlayerTransitionCameraActor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPlayerTransitionCameraActor() { }

    /// <summary>
    /// Constructs a new RPlayerTransitionCameraActor
    /// </summary>
    public RPlayerTransitionCameraActor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPlayerTransitionCameraActor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPlayerTransitionCameraActor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerTransitionCameraActor>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerTransitionCameraActor>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerTransitionCameraActor>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerTransitionCameraActor>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerTransitionCameraActor>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerTransitionCameraActor>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerTransitionCameraActor>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: SplineTension
    /// </summary>
    public unsafe float SplineTension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: CamSplineTime
    /// </summary>
    public unsafe float CamSplineTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// FloatProperty: CamSplineEndTimePerc
    /// </summary>
    public unsafe float CamSplineEndTimePerc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: CameraSpeed
    /// </summary>
    public unsafe float CameraSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// FloatProperty: IdealCameraTime
    /// </summary>
    public unsafe float IdealCameraTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// FloatProperty: CameraSpeedMin
    /// </summary>
    public unsafe float CameraSpeedMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// FloatProperty: CameraSpeedMax
    /// </summary>
    public unsafe float CameraSpeedMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// ObjectProperty: CameraNodes
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass CameraNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// ObjectProperty: TrackingActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor TrackingActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// ObjectProperty: CustomCam
    /// </summary>
    public unsafe BmSDK.Engine.Actor CustomCam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// ObjectProperty: ActorToFollow
    /// </summary>
    public unsafe BmSDK.Engine.Pawn ActorToFollow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// FloatProperty: CurrentSplineTime
    /// </summary>
    public unsafe float CurrentSplineTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// FloatProperty: RotationSpringStrength
    /// </summary>
    public unsafe float RotationSpringStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// FloatProperty: CameraLookAheadTime
    /// </summary>
    public unsafe float CameraLookAheadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// BoolProperty: StartedMoving
    /// </summary>
    public unsafe bool StartedMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// BoolProperty: DebugRoute
    /// </summary>
    public unsafe bool DebugRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// BoolProperty: bOverrideMatineeTarget
    /// </summary>
    public unsafe bool bOverrideMatineeTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// BoolProperty: bUseFullCollision
    /// </summary>
    public unsafe bool bUseFullCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// BoolProperty: bResetCameraOnEndIfPlayer
    /// </summary>
    public unsafe bool bResetCameraOnEndIfPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// BoolProperty: bBlendingBack
    /// </summary>
    public unsafe bool bBlendingBack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// BoolProperty: bForceEndLocation
    /// </summary>
    public unsafe bool bForceEndLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// BoolProperty: bVehicleTransition
    /// </summary>
    public unsafe bool bVehicleTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// BoolProperty: bInterpolateRotation
    /// </summary>
    public unsafe bool bInterpolateRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// BoolProperty: TransitionFromBonnetCam
    /// </summary>
    public unsafe bool TransitionFromBonnetCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1320); }
    }

    /// <summary>
    /// FloatProperty: BlendBackCharacterTime
    /// </summary>
    public unsafe float BlendBackCharacterTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// FloatProperty: BlendBackVehicleTime
    /// </summary>
    public unsafe float BlendBackVehicleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// StructProperty: FollowOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 FollowOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// StructProperty: FollowOffsetMin
    /// </summary>
    public unsafe System.Numerics.Vector3 FollowOffsetMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: FollowCorrectionSpeed
    /// </summary>
    public unsafe float FollowCorrectionSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// StructProperty: ForceEndLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 ForceEndLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// StructProperty: ForceEndRotation
    /// </summary>
    public unsafe BmSDK.Rotator ForceEndRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// FloatProperty: BlendToFinalCamTime
    /// </summary>
    public unsafe float BlendToFinalCamTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// FloatProperty: DestinationFOV
    /// </summary>
    public unsafe float DestinationFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// FloatProperty: StartingFOV
    /// </summary>
    public unsafe float StartingFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// ByteProperty: CurrentRouteType
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerTransitionCameraActor.ECameraRouteType CurrentRouteType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerTransitionCameraActor.ECameraRouteType>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ArrayProperty: CameraSplinePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerTransitionCameraActor.FCamSplineSegment> CameraSplinePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerTransitionCameraActor.FCamSplineSegment>>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }
}
