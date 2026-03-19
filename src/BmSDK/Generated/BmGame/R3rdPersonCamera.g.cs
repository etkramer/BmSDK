#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: R3rdPersonCamera<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class R3rdPersonCamera : BmSDK.Engine.Camera, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.R3rdPersonCamera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal R3rdPersonCamera() { }

    /// <summary>
    /// Constructs a new R3rdPersonCamera
    /// </summary>
    public R3rdPersonCamera(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, R3rdPersonCamera Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected R3rdPersonCamera(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bDelayCameraUpdate
    /// </summary>
    public unsafe bool bDelayCameraUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bTurnedInTunnel
    /// </summary>
    public unsafe bool bTurnedInTunnel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bOverrideCameraFOV
    /// </summary>
    public unsafe bool bOverrideCameraFOV
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: LockInPlace
    /// </summary>
    public unsafe bool LockInPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bHidePlayer
    /// </summary>
    public unsafe bool bHidePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bInterpPos
    /// </summary>
    public unsafe bool bInterpPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bDisallowRoll
    /// </summary>
    public unsafe bool bDisallowRoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bAffectsControllerRotation
    /// </summary>
    public unsafe bool bAffectsControllerRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bTemporarilyDisableCameraDrag
    /// </summary>
    public unsafe bool bTemporarilyDisableCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bStatePermanentlyDragsCamera
    /// </summary>
    public unsafe bool bStatePermanentlyDragsCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bDragOnlyFollowsDeliberateDirection
    /// </summary>
    public unsafe bool bDragOnlyFollowsDeliberateDirection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bStatePermanentlyDisablesCameraDrag
    /// </summary>
    public unsafe bool bStatePermanentlyDisablesCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bUseTightFocusPoints
    /// </summary>
    public unsafe bool bUseTightFocusPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraSmoothing
    /// </summary>
    public unsafe bool bDisableCameraSmoothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bFollowPelvis
    /// </summary>
    public unsafe bool bFollowPelvis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bOnlyFollowPelvisZ
    /// </summary>
    public unsafe bool bOnlyFollowPelvisZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraCollision
    /// </summary>
    public unsafe bool bDisableCameraCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bSwayWithPelvis
    /// </summary>
    public unsafe bool bSwayWithPelvis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bDisableCamerCollisionDuringBlend
    /// </summary>
    public unsafe bool bDisableCamerCollisionDuringBlend
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bBlendFollowsOldRotationRules
    /// </summary>
    public unsafe bool bBlendFollowsOldRotationRules
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bCameraDebug
    /// </summary>
    public unsafe bool bCameraDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bCameraDebugCollision
    /// </summary>
    public unsafe bool bCameraDebugCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bDebugPlayerPath
    /// </summary>
    public unsafe bool bDebugPlayerPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bDebugCameraSmoothing
    /// </summary>
    public unsafe bool bDebugCameraSmoothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bForce3rdPersonCamera
    /// </summary>
    public unsafe bool bForce3rdPersonCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bDontModifySitOffsetWhenLookingUp
    /// </summary>
    public unsafe bool bDontModifySitOffsetWhenLookingUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bUseAbsoluteHeadOffset
    /// </summary>
    public unsafe bool bUseAbsoluteHeadOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bActuallyUsingAbsoluteHeadRot
    /// </summary>
    public unsafe bool bActuallyUsingAbsoluteHeadRot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bInterpingHeadRot
    /// </summary>
    public unsafe bool bInterpingHeadRot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bAlternativeCam
    /// </summary>
    public unsafe bool bAlternativeCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bDontClipPlayer
    /// </summary>
    public unsafe bool bDontClipPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bCameraWandering
    /// </summary>
    public unsafe bool bCameraWandering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1684); }
    }

    /// <summary>
    /// BoolProperty: bUseWorldSpaceCameraWander
    /// </summary>
    public unsafe bool bUseWorldSpaceCameraWander
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bCamOverrideDof
    /// </summary>
    public unsafe bool bCamOverrideDof
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bEnableMotionBlur
    /// </summary>
    public unsafe bool bEnableMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bForceZoom
    /// </summary>
    public unsafe bool bForceZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: CameraLocked
    /// </summary>
    public unsafe bool CameraLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: CameraBlendBatmanRelativePosition
    /// </summary>
    public unsafe bool CameraBlendBatmanRelativePosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bIsCombatCamera
    /// </summary>
    public unsafe bool bIsCombatCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: EnableCameraAssist
    /// </summary>
    public unsafe bool EnableCameraAssist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bForceCameraDragOn
    /// </summary>
    public unsafe bool bForceCameraDragOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bCombatDisableCameraDrag
    /// </summary>
    public unsafe bool bCombatDisableCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bOverrideTransitionIn
    /// </summary>
    public unsafe bool bOverrideTransitionIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: PawnHiddenByCamera
    /// </summary>
    public unsafe bool PawnHiddenByCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bUseAnchorRotForPivotOffset
    /// </summary>
    public unsafe bool bUseAnchorRotForPivotOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: LookAtUsesDefaultOffset
    /// </summary>
    public unsafe bool LookAtUsesDefaultOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: UsePitchForLookAt
    /// </summary>
    public unsafe bool UsePitchForLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: UseYawForLookAt
    /// </summary>
    public unsafe bool UseYawForLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bCeilingRetainOffsetDuringZoom
    /// </summary>
    public unsafe bool bCeilingRetainOffsetDuringZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: DontDrawClosePawns
    /// </summary>
    public unsafe bool DontDrawClosePawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bPauseAndPanCamera
    /// </summary>
    public unsafe bool bPauseAndPanCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bModifyPPForResonatorSreen
    /// </summary>
    public unsafe bool bModifyPPForResonatorSreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bWantsToLookBack
    /// </summary>
    public unsafe bool bWantsToLookBack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: JumpCamera
    /// </summary>
    public unsafe bool JumpCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bLookingBackwards
    /// </summary>
    public unsafe bool bLookingBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: VehicleReversing
    /// </summary>
    public unsafe bool VehicleReversing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bUseFullSway
    /// </summary>
    public unsafe bool bUseFullSway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bUseFancySniperZoomFocus
    /// </summary>
    public unsafe bool bUseFancySniperZoomFocus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bRetainOffsetDuringZoom
    /// </summary>
    public unsafe bool bRetainOffsetDuringZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bUseHeadOffsetCheck
    /// </summary>
    public unsafe bool bUseHeadOffsetCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bOverrideCrouchHeadCheck
    /// </summary>
    public unsafe bool bOverrideCrouchHeadCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bBatmanFacesCamera
    /// </summary>
    public unsafe bool bBatmanFacesCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bCustomCameraZoomAllowed
    /// </summary>
    public unsafe bool bCustomCameraZoomAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bCustomCameraDisablesDrag
    /// </summary>
    public unsafe bool bCustomCameraDisablesDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bDontSaveConfig
    /// </summary>
    public unsafe bool bDontSaveConfig
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1692); }
    }

    /// <summary>
    /// BoolProperty: Debug_TurnOffZoomDof
    /// </summary>
    public unsafe bool Debug_TurnOffZoomDof
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1692); }
    }

    /// <summary>
    /// BoolProperty: bForceFollowFullPelvisZ
    /// </summary>
    public unsafe bool bForceFollowFullPelvisZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1692); }
    }

    /// <summary>
    /// BoolProperty: BonnetCamera
    /// </summary>
    public unsafe bool BonnetCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1692); }
    }

    /// <summary>
    /// BoolProperty: bDrivingLookBackDisabled
    /// </summary>
    public unsafe bool bDrivingLookBackDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1692); }
    }

    /// <summary>
    /// BoolProperty: DoAdamsCrazyCam
    /// </summary>
    public unsafe bool DoAdamsCrazyCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1692); }
    }

    /// <summary>
    /// BoolProperty: CanToggleDrivingCam
    /// </summary>
    public unsafe bool CanToggleDrivingCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1692); }
    }

    /// <summary>
    /// BoolProperty: CanDoBonnetCam
    /// </summary>
    public unsafe bool CanDoBonnetCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1692); }
    }

    /// <summary>
    /// BoolProperty: bCameraDragging
    /// </summary>
    public unsafe bool bCameraDragging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1692); }
    }

    /// <summary>
    /// BoolProperty: JumpCameraLeft
    /// </summary>
    public unsafe bool JumpCameraLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1692); }
    }

    /// <summary>
    /// StructProperty: CameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// FloatProperty: CameraFOVAngle
    /// </summary>
    public unsafe float CameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// FloatProperty: OverrideCameraFOVAngle
    /// </summary>
    public unsafe float OverrideCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// FloatProperty: OverrideCameraFOVTime
    /// </summary>
    public unsafe float OverrideCameraFOVTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// FloatProperty: OverrideCameraFOVTimer
    /// </summary>
    public unsafe float OverrideCameraFOVTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// FloatProperty: LastOverrideCameraFOVAngle
    /// </summary>
    public unsafe float LastOverrideCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// FloatProperty: CurrentOverrideCameraFOVAngle
    /// </summary>
    public unsafe float CurrentOverrideCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// FloatProperty: OverrideMotionBlurBlendTime
    /// </summary>
    public unsafe float OverrideMotionBlurBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// FloatProperty: OverrideMotionBlurAmount
    /// </summary>
    public unsafe float OverrideMotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// FloatProperty: OldMotionBlurBlendTime
    /// </summary>
    public unsafe float OldMotionBlurBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// FloatProperty: OldMotionBlurAmount
    /// </summary>
    public unsafe float OldMotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// FloatProperty: bOverrideMotionBlurSettings
    /// </summary>
    public unsafe float bOverrideMotionBlurSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// StructProperty: ExtraCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExtraCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// StructProperty: DefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// StructProperty: CameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// StructProperty: HeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// FloatProperty: ExtraCameraZ
    /// </summary>
    public unsafe float ExtraCameraZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }
    }

    /// <summary>
    /// StructProperty: CurrentHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// StructProperty: CurrentExtraCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentExtraCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// FloatProperty: CurrentExtraCameraZ
    /// </summary>
    public unsafe float CurrentExtraCameraZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// ObjectProperty: DOFManager
    /// </summary>
    public unsafe BmSDK.BmGame.R3rdPersonCamera.ScreenShakeModifier DOFManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R3rdPersonCamera.ScreenShakeModifier>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// ObjectProperty: ScreenShakeModifier
    /// </summary>
    public unsafe BmSDK.BmGame.R3rdPersonCamera.BatarangViewPP ScreenShakeModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R3rdPersonCamera.BatarangViewPP>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// ObjectProperty: MotionBlurEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MotionBlurEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// ObjectProperty: UberEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT UberEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// ObjectProperty: DesiredLookActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DesiredLookActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// ObjectProperty: InterpBase
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InterpBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// ObjectProperty: BatarangViewPP
    /// </summary>
    public unsafe BmSDK.BmGame.R3rdPersonCamera.RemoteBatmobilePP BatarangViewPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R3rdPersonCamera.RemoteBatmobilePP>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// ObjectProperty: RemoteBatmobilePP
    /// </summary>
    public unsafe BmSDK.BmGame.R3rdPersonCamera.DisruptorZoomPP RemoteBatmobilePP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R3rdPersonCamera.DisruptorZoomPP>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// ObjectProperty: DisruptorZoomPP
    /// </summary>
    public unsafe BmSDK.BmGame.R3rdPersonCamera.OverlayPlayer DisruptorZoomPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R3rdPersonCamera.OverlayPlayer>(Ptr + 1896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }
    }

    /// <summary>
    /// ObjectProperty: OverlayPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.R3rdPersonCamera.PreCulledActors OverlayPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R3rdPersonCamera.PreCulledActors>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// ObjectProperty: CinematicPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CinematicPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// ObjectProperty: SpecialActorToHide
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpecialActorToHide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// ArrayProperty: PreCulledActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>>>>>>> PreCulledActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>>>>>>>>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// FloatProperty: TargetFOV
    /// </summary>
    public unsafe float TargetFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// ArrayProperty: CameraEmitters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>>>>>> CameraEmitters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>>>>>>>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentCameraPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentCameraRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraFOVAngle
    /// </summary>
    public unsafe float CurrentCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// FloatProperty: FinalCameraFOVAngle
    /// </summary>
    public unsafe float FinalCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// StructProperty: ActualCameraPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ActualCameraPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// StructProperty: ActualCameraRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ActualCameraRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// StructProperty: LastVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// FloatProperty: TimeInCurrentState
    /// </summary>
    public unsafe float TimeInCurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// FloatProperty: TransitionTime
    /// </summary>
    public unsafe float TransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// IntProperty: maxPitch
    /// </summary>
    public unsafe int maxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// IntProperty: MinPitch
    /// </summary>
    public unsafe int MinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// IntProperty: MaxYaw
    /// </summary>
    public unsafe int MaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// IntProperty: MinYaw
    /// </summary>
    public unsafe int MinYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxYaw
    /// </summary>
    public unsafe float CurrentMaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// FloatProperty: CurrentMinYaw
    /// </summary>
    public unsafe float CurrentMinYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxPitch
    /// </summary>
    public unsafe float CurrentMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// FloatProperty: CurrentMinPitch
    /// </summary>
    public unsafe float CurrentMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// StructProperty: RotationSpeed
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RotationSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// FloatProperty: YawAccel
    /// </summary>
    public unsafe float YawAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// FloatProperty: PitchAccel
    /// </summary>
    public unsafe float PitchAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// FloatProperty: YawDecel
    /// </summary>
    public unsafe float YawDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// FloatProperty: PitchDecel
    /// </summary>
    public unsafe float PitchDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// FloatProperty: CameraCeilingLimit
    /// </summary>
    public unsafe float CameraCeilingLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// FloatProperty: CameraFloorLimit
    /// </summary>
    public unsafe float CameraFloorLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// StructProperty: WalkStateCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WalkStateCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// FloatProperty: WalkStateCameraFOVAngle
    /// </summary>
    public unsafe float WalkStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// StructProperty: WalkStateDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WalkStateDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// StructProperty: WalkCanisterStateCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WalkCanisterStateCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// FloatProperty: WalkCanisterStateCameraFOVAngle
    /// </summary>
    public unsafe float WalkCanisterStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// StructProperty: WalkCanisterStateDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WalkCanisterStateDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// StructProperty: DialogueStateCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DialogueStateCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// FloatProperty: DialogueStateCameraFOVAngle
    /// </summary>
    public unsafe float DialogueStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// StructProperty: DialogueStateDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DialogueStateDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// StructProperty: ForensicsScanStateCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ForensicsScanStateCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// FloatProperty: ForensicsScanStateCameraFOVAngle
    /// </summary>
    public unsafe float ForensicsScanStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// StructProperty: ForensicsScanStateDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ForensicsScanStateDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// StructProperty: UsingSpotlightStateCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT UsingSpotlightStateCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// FloatProperty: UsingSpotlightStateCameraFOVAngle
    /// </summary>
    public unsafe float UsingSpotlightStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// StructProperty: UsingSpotlightStateDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT UsingSpotlightStateDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// StructProperty: ForensicsFilterStateCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ForensicsFilterStateCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// FloatProperty: ForensicsFilterStateCameraFOVAngle
    /// </summary>
    public unsafe float ForensicsFilterStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// StructProperty: ForensicsFilterStateDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ForensicsFilterStateDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// StructProperty: RunStateCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RunStateCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// FloatProperty: RunStateCameraFOVAngle
    /// </summary>
    public unsafe float RunStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// FloatProperty: BoostRunFOVAngle
    /// </summary>
    public unsafe float BoostRunFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// StructProperty: RunStateDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RunStateDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// StructProperty: PairedAnimationStateCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PairedAnimationStateCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// FloatProperty: PairedAnimationStateCameraFOVAngle
    /// </summary>
    public unsafe float PairedAnimationStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// StructProperty: PairedAnimationStateDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PairedAnimationStateDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// StructProperty: StealthStateCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StealthStateCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// FloatProperty: StealthStateCameraFOVAngle
    /// </summary>
    public unsafe float StealthStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// FloatProperty: OverworldStealthStateCameraFOVAngle
    /// </summary>
    public unsafe float OverworldStealthStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// StructProperty: StealthStateDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StealthStateDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// StructProperty: TunnelStateCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TunnelStateCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// FloatProperty: TunnelStateCameraFOVAngle
    /// </summary>
    public unsafe float TunnelStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// StructProperty: TunnelStateDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TunnelStateDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// StructProperty: TunnelStateCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TunnelStateCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// FloatProperty: ScarecrowTakedownCameraFOVAngle
    /// </summary>
    public unsafe float ScarecrowTakedownCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// StructProperty: JokerFpsOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JokerFpsOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// StructProperty: JokerFpsPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JokerFpsPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// StructProperty: JokerFpsHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JokerFpsHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// FloatProperty: JokerFPSFov
    /// </summary>
    public unsafe float JokerFPSFov
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// FloatProperty: JokerFPSZoomFov
    /// </summary>
    public unsafe float JokerFPSZoomFov
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// StructProperty: GrappleDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// StructProperty: FallingStateCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FallingStateCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// FloatProperty: FallingStateCameraFOVAngle
    /// </summary>
    public unsafe float FallingStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// StructProperty: FallingDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FallingDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// FloatProperty: FallingStateSwingSmoothingStrength
    /// </summary>
    public unsafe float FallingStateSwingSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2508); }
    }

    /// <summary>
    /// FloatProperty: FallingStateSwingTransitionTime
    /// </summary>
    public unsafe float FallingStateSwingTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// StructProperty: GrappleAimCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleAimCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// FloatProperty: GrappleAimCameraFOVAngle
    /// </summary>
    public unsafe float GrappleAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// StructProperty: GrappleAimDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleAimDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// IntProperty: GrappleAimMaxPitch
    /// </summary>
    public unsafe int GrappleAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// IntProperty: GrappleAimMinPitch
    /// </summary>
    public unsafe int GrappleAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// StructProperty: HarpoonAimCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HarpoonAimCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// FloatProperty: HarpoonAimCameraFOVAngle
    /// </summary>
    public unsafe float HarpoonAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// StructProperty: HarpoonAimDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HarpoonAimDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// IntProperty: HarpoonAimMaxPitch
    /// </summary>
    public unsafe int HarpoonAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// IntProperty: HarpoonAimMinPitch
    /// </summary>
    public unsafe int HarpoonAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// StructProperty: MagneticBlastAimCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MagneticBlastAimCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// FloatProperty: MagneticBlastAimCameraFOVAngle
    /// </summary>
    public unsafe float MagneticBlastAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// StructProperty: MagneticBlastAimDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MagneticBlastAimDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// IntProperty: MagneticBlastAimMaxPitch
    /// </summary>
    public unsafe int MagneticBlastAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// IntProperty: MagneticBlastAimMinPitch
    /// </summary>
    public unsafe int MagneticBlastAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }

    /// <summary>
    /// StructProperty: OmnitronAimCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OmnitronAimCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// StructProperty: OmnitronAimCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OmnitronAimCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// FloatProperty: OmnitronAimCameraFOVAngle
    /// </summary>
    public unsafe float OmnitronAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// StructProperty: OmnitronAimDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OmnitronAimDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2652); }
    }

    /// <summary>
    /// IntProperty: OmnitronAimMaxPitch
    /// </summary>
    public unsafe int OmnitronAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// IntProperty: OmnitronAimMinPitch
    /// </summary>
    public unsafe int OmnitronAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2668); }
    }

    /// <summary>
    /// StructProperty: OmnitronCornerLeftStateOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OmnitronCornerLeftStateOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// StructProperty: OmnitronCornerRightStateOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OmnitronCornerRightStateOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2684); }
    }

    /// <summary>
    /// FloatProperty: OmnitronCornerStateFOVAngle
    /// </summary>
    public unsafe float OmnitronCornerStateFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// StructProperty: OmnitronCornerStateDefaultRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OmnitronCornerStateDefaultRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2700); }
    }

    /// <summary>
    /// StructProperty: OmnitronCornerLeftStateCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OmnitronCornerLeftStateCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2712); }
    }

    /// <summary>
    /// StructProperty: OmnitronCornerRightStateCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OmnitronCornerRightStateCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }

    /// <summary>
    /// StructProperty: RHDAimCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDAimCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// StructProperty: RHDAimCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDAimCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2748); }
    }

    /// <summary>
    /// FloatProperty: RHDAimCameraFOVAngle
    /// </summary>
    public unsafe float RHDAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }

    /// <summary>
    /// StructProperty: RHDAimDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDAimDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2764); }
    }

    /// <summary>
    /// IntProperty: RHDAimMaxPitch
    /// </summary>
    public unsafe int RHDAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2776); }
    }

    /// <summary>
    /// IntProperty: RHDAimMinPitch
    /// </summary>
    public unsafe int RHDAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }

    /// <summary>
    /// StructProperty: RHDCornerLeftStateOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDCornerLeftStateOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }

    /// <summary>
    /// StructProperty: RHDCornerRightStateOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDCornerRightStateOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2796); }
    }

    /// <summary>
    /// FloatProperty: RHDCornerStateFOVAngle
    /// </summary>
    public unsafe float RHDCornerStateFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2808); }
    }

    /// <summary>
    /// StructProperty: RHDCornerStateDefaultRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDCornerStateDefaultRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2812); }
    }

    /// <summary>
    /// StructProperty: RHDCornerLeftStateCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDCornerLeftStateCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }
    }

    /// <summary>
    /// StructProperty: RHDCornerRightStateCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDCornerRightStateCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2836); }
    }

    /// <summary>
    /// StructProperty: FreezeJammerAimCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FreezeJammerAimCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2848); }
    }

    /// <summary>
    /// FloatProperty: FreezeJammerAimCameraFOVAngle
    /// </summary>
    public unsafe float FreezeJammerAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2860); }
    }

    /// <summary>
    /// StructProperty: FreezeJammerAimDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FreezeJammerAimDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2864); }
    }

    /// <summary>
    /// IntProperty: FreezeJammerAimMaxPitch
    /// </summary>
    public unsafe int FreezeJammerAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2876); }
    }

    /// <summary>
    /// IntProperty: FreezeJammerAimMinPitch
    /// </summary>
    public unsafe int FreezeJammerAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2880); }
    }

    /// <summary>
    /// StructProperty: JokerGunAimCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JokerGunAimCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2884); }
    }

    /// <summary>
    /// FloatProperty: JokerGunAimCameraFOVAngle
    /// </summary>
    public unsafe float JokerGunAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2896); }
    }

    /// <summary>
    /// IntProperty: JokerGunAimMaxPitch
    /// </summary>
    public unsafe int JokerGunAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2900); }
    }

    /// <summary>
    /// IntProperty: JokerGunAimMinPitch
    /// </summary>
    public unsafe int JokerGunAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2904); }
    }

    /// <summary>
    /// StructProperty: JokerGunZoomAimCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JokerGunZoomAimCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }

    /// <summary>
    /// FloatProperty: JokerGunZoomAimCameraFOVAngle
    /// </summary>
    public unsafe float JokerGunZoomAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2920); }
    }

    /// <summary>
    /// IntProperty: JokerGunZoomAimMaxPitch
    /// </summary>
    public unsafe int JokerGunZoomAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// IntProperty: JokerGunZoomAimMinPitch
    /// </summary>
    public unsafe int JokerGunZoomAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }
    }

    /// <summary>
    /// StructProperty: JokerGunZoomRoom3AimCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JokerGunZoomRoom3AimCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2932); }
    }

    /// <summary>
    /// FloatProperty: JokerGunZoomRoom3AimCameraFOVAngle
    /// </summary>
    public unsafe float JokerGunZoomRoom3AimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

    /// <summary>
    /// IntProperty: JokerGunZoomRoom3AimMaxPitch
    /// </summary>
    public unsafe int JokerGunZoomRoom3AimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2948); }
    }

    /// <summary>
    /// IntProperty: JokerGunZoomRoom3AimMinPitch
    /// </summary>
    public unsafe int JokerGunZoomRoom3AimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2952); }
    }

    /// <summary>
    /// FloatProperty: JokerGunSmoothingStrength
    /// </summary>
    public unsafe float JokerGunSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2956); }
    }

    /// <summary>
    /// StructProperty: LineLauncherAimCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LineLauncherAimCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2960); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherAimCameraFOVAngle
    /// </summary>
    public unsafe float LineLauncherAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2972); }
    }

    /// <summary>
    /// StructProperty: LineLauncherAimDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LineLauncherAimDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2976); }
    }

    /// <summary>
    /// IntProperty: LineLauncherAimMaxPitch
    /// </summary>
    public unsafe int LineLauncherAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2988); }
    }

    /// <summary>
    /// IntProperty: LineLauncherAimMinPitch
    /// </summary>
    public unsafe int LineLauncherAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2992); }
    }

    /// <summary>
    /// StructProperty: BatarangAimCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatarangAimCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2996); }
    }

    /// <summary>
    /// FloatProperty: BatarangAimCameraFOVAngle
    /// </summary>
    public unsafe float BatarangAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3008); }
    }

    /// <summary>
    /// StructProperty: BatarangAimDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatarangAimDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3012); }
    }

    /// <summary>
    /// IntProperty: BatarangAimMaxPitch
    /// </summary>
    public unsafe int BatarangAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3024); }
    }

    /// <summary>
    /// IntProperty: BatarangAimMinPitch
    /// </summary>
    public unsafe int BatarangAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3028); }
    }

    /// <summary>
    /// StructProperty: WallClimbStartCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WallClimbStartCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3032); }
    }

    /// <summary>
    /// FloatProperty: WallClimbStartCameraFOVAngle
    /// </summary>
    public unsafe float WallClimbStartCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3044); }
    }

    /// <summary>
    /// StructProperty: WallClimbHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WallClimbHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3048); }
    }

    /// <summary>
    /// StructProperty: PounceCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PounceCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3060); }
    }

    /// <summary>
    /// FloatProperty: PounceCameraFOVAngle
    /// </summary>
    public unsafe float PounceCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3072); }
    }

    /// <summary>
    /// StructProperty: PounceHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PounceHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3076); }
    }

    /// <summary>
    /// StructProperty: VantageClimbHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VantageClimbHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3088); }
    }

    /// <summary>
    /// StructProperty: BatTrackerAimCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatTrackerAimCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3100); }
    }

    /// <summary>
    /// FloatProperty: BatTrackerAimCameraFOVAngle
    /// </summary>
    public unsafe float BatTrackerAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3112); }
    }

    /// <summary>
    /// StructProperty: BatTrackerAimDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatTrackerAimDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3116); }
    }

    /// <summary>
    /// StructProperty: BatTrackerAimTargetOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatTrackerAimTargetOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3128); }
    }

    /// <summary>
    /// FloatProperty: CorridorCombatStateCameraFOVAngle
    /// </summary>
    public unsafe float CorridorCombatStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3140); }
    }

    /// <summary>
    /// FloatProperty: NightwingBossFightCameraFOVAngle
    /// </summary>
    public unsafe float NightwingBossFightCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3144); }
    }

    /// <summary>
    /// FloatProperty: HighCombatStateCameraFOVAngle
    /// </summary>
    public unsafe float HighCombatStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }

    /// <summary>
    /// StructProperty: LookStateCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LookStateCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3152); }
    }

    /// <summary>
    /// FloatProperty: LookStateCameraFOVAngle
    /// </summary>
    public unsafe float LookStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// StructProperty: LookStateDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LookStateDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }

    /// <summary>
    /// IntProperty: LookStateMaxPitch
    /// </summary>
    public unsafe int LookStateMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }

    /// <summary>
    /// IntProperty: LookStateMinPitch
    /// </summary>
    public unsafe int LookStateMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }

    /// <summary>
    /// FloatProperty: LookModeScale
    /// </summary>
    public unsafe float LookModeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3188); }
    }

    /// <summary>
    /// FloatProperty: LookSpringBack
    /// </summary>
    public unsafe float LookSpringBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3192); }
    }

    /// <summary>
    /// FloatProperty: GrappleLookSpringBack
    /// </summary>
    public unsafe float GrappleLookSpringBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3196); }
    }

    /// <summary>
    /// FloatProperty: GrappleCameraFOVAngle
    /// </summary>
    public unsafe float GrappleCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }

    /// <summary>
    /// FloatProperty: ZoomStateCameraFOVAngle
    /// </summary>
    public unsafe float ZoomStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }

    /// <summary>
    /// StructProperty: CoverRightCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CoverRightCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }
    }

    /// <summary>
    /// FloatProperty: CoverRightCameraFOVAngle
    /// </summary>
    public unsafe float CoverRightCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3220); }
    }

    /// <summary>
    /// StructProperty: CoverRightCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CoverRightCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3224); }
    }

    /// <summary>
    /// StructProperty: AlcoveCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AlcoveCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3236); }
    }

    /// <summary>
    /// FloatProperty: AlcoveCameraFOVAngle
    /// </summary>
    public unsafe float AlcoveCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3248); }
    }

    /// <summary>
    /// StructProperty: AlcoveCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AlcoveCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3252); }
    }

    /// <summary>
    /// StructProperty: AlcoveCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AlcoveCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3264); }
    }

    /// <summary>
    /// StructProperty: GlidingCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GlidingCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3276); }
    }

    /// <summary>
    /// FloatProperty: GlidingCameraFOVAngle
    /// </summary>
    public unsafe float GlidingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3288); }
    }

    /// <summary>
    /// FloatProperty: GlidingCameraExtraFOVAngle
    /// </summary>
    public unsafe float GlidingCameraExtraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3292); }
    }

    /// <summary>
    /// StructProperty: GlidingCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GlidingCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3296); }
    }

    /// <summary>
    /// FloatProperty: GlideLagStrength
    /// </summary>
    public unsafe float GlideLagStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3308); }
    }

    /// <summary>
    /// FloatProperty: GlideLagBoostStrength
    /// </summary>
    public unsafe float GlideLagBoostStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3312); }
    }

    /// <summary>
    /// FloatProperty: GlideLagStrengthBlendTime
    /// </summary>
    public unsafe float GlideLagStrengthBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3316); }
    }

    /// <summary>
    /// FloatProperty: DiveCameraOrientationTime
    /// </summary>
    public unsafe float DiveCameraOrientationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }

    /// <summary>
    /// StructProperty: GlideKickOffWallHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GlideKickOffWallHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3324); }
    }

    /// <summary>
    /// StructProperty: BoostGlidingCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BoostGlidingCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3336); }
    }

    /// <summary>
    /// FloatProperty: BoostGlidingCameraFOVAngle
    /// </summary>
    public unsafe float BoostGlidingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3348); }
    }

    /// <summary>
    /// StructProperty: BoostGlidingCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BoostGlidingCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3352); }
    }

    /// <summary>
    /// StructProperty: PouncingCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PouncingCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3364); }
    }

    /// <summary>
    /// FloatProperty: SilentPredCameraFOVAngle
    /// </summary>
    public unsafe float SilentPredCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3376); }
    }

    /// <summary>
    /// FloatProperty: SilentPredOverworldCameraFOVAngle
    /// </summary>
    public unsafe float SilentPredOverworldCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3380); }
    }

    /// <summary>
    /// FloatProperty: PerchLedgeCameraFOVAngle
    /// </summary>
    public unsafe float PerchLedgeCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3384); }
    }

    /// <summary>
    /// StructProperty: PerchLedgeHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PerchLedgeHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3388); }
    }

    /// <summary>
    /// FloatProperty: PerchLedgeSwingCameraFOVAngle
    /// </summary>
    public unsafe float PerchLedgeSwingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3400); }
    }

    /// <summary>
    /// StructProperty: PerchLedgeSwingHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PerchLedgeSwingHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3404); }
    }

    /// <summary>
    /// StructProperty: HangCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HangCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3416); }
    }

    /// <summary>
    /// FloatProperty: HangCameraFOVAngle
    /// </summary>
    public unsafe float HangCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3428); }
    }

    /// <summary>
    /// StructProperty: HangDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HangDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3432); }
    }

    /// <summary>
    /// FloatProperty: MinFreeCameraDistance
    /// </summary>
    public unsafe float MinFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3444); }
    }

    /// <summary>
    /// FloatProperty: MaxFreeCameraDistance
    /// </summary>
    public unsafe float MaxFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3448); }
    }

    /// <summary>
    /// FloatProperty: ShortCamSpringConst
    /// </summary>
    public unsafe float ShortCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3452); }
    }

    /// <summary>
    /// FloatProperty: LongCamSpringConst
    /// </summary>
    public unsafe float LongCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3456); }
    }

    /// <summary>
    /// StructProperty: LastLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3460); }
    }

    /// <summary>
    /// FloatProperty: CurrentShortCamSpringConst
    /// </summary>
    public unsafe float CurrentShortCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3472); }
    }

    /// <summary>
    /// FloatProperty: CurrentLongCamSpringConst
    /// </summary>
    public unsafe float CurrentLongCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3476); }
    }

    /// <summary>
    /// StructProperty: CameraPivotOffsetDef
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraPivotOffsetDef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// IntProperty: MaxFreeCameraPitch
    /// </summary>
    public unsafe int MaxFreeCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3492); }
    }

    /// <summary>
    /// IntProperty: MinFreeCameraPitch
    /// </summary>
    public unsafe int MinFreeCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3496); }
    }

    /// <summary>
    /// FloatProperty: ZoomSensitivityMod
    /// </summary>
    public unsafe float ZoomSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// FloatProperty: LookSensitivityMod
    /// </summary>
    public unsafe float LookSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }
    }

    /// <summary>
    /// FloatProperty: fGadgetVariableLookSensitivityMod
    /// </summary>
    public unsafe float fGadgetVariableLookSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3508); }
    }

    /// <summary>
    /// FloatProperty: HarpoonSensitivityMod
    /// </summary>
    public unsafe float HarpoonSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// FloatProperty: JokerGunSensitivityMod
    /// </summary>
    public unsafe float JokerGunSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3516); }
    }

    /// <summary>
    /// FloatProperty: JokerGunZoomSensitivityMod
    /// </summary>
    public unsafe float JokerGunZoomSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3520); }
    }

    /// <summary>
    /// FloatProperty: JokerGunZoomRoom3SensitivityMod
    /// </summary>
    public unsafe float JokerGunZoomRoom3SensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3524); }
    }

    /// <summary>
    /// FloatProperty: SensitivityModZ
    /// </summary>
    public unsafe float SensitivityModZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3528); }
    }

    /// <summary>
    /// StructProperty: BaseCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BaseCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3532); }
    }

    /// <summary>
    /// StructProperty: ExtraCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExtraCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3544); }
    }

    /// <summary>
    /// StructProperty: FreeCamBobLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FreeCamBobLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3556); }
    }

    /// <summary>
    /// StructProperty: LastDesiredCamPositionForDrag
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastDesiredCamPositionForDrag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// StructProperty: ZipLineCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZipLineCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3580); }
    }

    /// <summary>
    /// FloatProperty: ZipLineCameraFOVAngle
    /// </summary>
    public unsafe float ZipLineCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// StructProperty: ZipLineDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZipLineDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3596); }
    }

    /// <summary>
    /// StructProperty: ZipLineTargetOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZipLineTargetOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// StructProperty: HarpoonPullCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HarpoonPullCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3620); }
    }

    /// <summary>
    /// FloatProperty: HarpoonPullCameraFOVAngle
    /// </summary>
    public unsafe float HarpoonPullCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// StructProperty: HarpoonPullDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HarpoonPullDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3636); }
    }

    /// <summary>
    /// StructProperty: HarpoonPullTargetOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HarpoonPullTargetOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3648); }
    }

    /// <summary>
    /// StructProperty: FixedCameraHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FixedCameraHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3660); }
    }

    /// <summary>
    /// StructProperty: FreeCameraHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FreeCameraHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3672); }
    }

    /// <summary>
    /// StructProperty: AlcoveCameraHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AlcoveCameraHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3684); }
    }

    /// <summary>
    /// StructProperty: SwingingFromAboveCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SwingingFromAboveCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// FloatProperty: SwingingFromAboveCameraFOVAngle
    /// </summary>
    public unsafe float SwingingFromAboveCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3708); }
    }

    /// <summary>
    /// StructProperty: SwingingFromAboveCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SwingingFromAboveCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }
    }

    /// <summary>
    /// FloatProperty: CeilingClimbCamFOVAngle
    /// </summary>
    public unsafe float CeilingClimbCamFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3724); }
    }

    /// <summary>
    /// StructProperty: CeilingClimbCamHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CeilingClimbCamHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3728); }
    }

    /// <summary>
    /// StructProperty: CeilingClimbCamRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CeilingClimbCamRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3740); }
    }

    /// <summary>
    /// FloatProperty: ZoomFOV
    /// </summary>
    public unsafe float ZoomFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }
    }

    /// <summary>
    /// FloatProperty: ExtraZoomFOV
    /// </summary>
    public unsafe float ExtraZoomFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3756); }
    }

    /// <summary>
    /// FloatProperty: ZoomTime
    /// </summary>
    public unsafe float ZoomTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3760); }
    }

    /// <summary>
    /// FloatProperty: RaftPullFOVAngle
    /// </summary>
    public unsafe float RaftPullFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3764); }
    }

    /// <summary>
    /// FloatProperty: DiveToBatmobilePickupFOVAngle
    /// </summary>
    public unsafe float DiveToBatmobilePickupFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3768); }
    }

    /// <summary>
    /// StructProperty: DiveToBatmobilePickupRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DiveToBatmobilePickupRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3772); }
    }

    /// <summary>
    /// FloatProperty: DiveToBatmobilePickupPivotMax
    /// </summary>
    public unsafe float DiveToBatmobilePickupPivotMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3784); }
    }

    /// <summary>
    /// FloatProperty: FearTakedownFOVAngle
    /// </summary>
    public unsafe float FearTakedownFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3788); }
    }

    /// <summary>
    /// IntProperty: ForcedPitch
    /// </summary>
    public unsafe int ForcedPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3792); }
    }

    /// <summary>
    /// StructProperty: TransitionOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TransitionOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3796); }
    }

    /// <summary>
    /// StructProperty: TransitionRotatorOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TransitionRotatorOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3808); }
    }

    /// <summary>
    /// FloatProperty: TransitionFOV
    /// </summary>
    public unsafe float TransitionFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3820); }
    }

    /// <summary>
    /// FloatProperty: CurrentMinFreeCameraDistance
    /// </summary>
    public unsafe float CurrentMinFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3824); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxFreeCameraDistance
    /// </summary>
    public unsafe float CurrentMaxFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3828); }
    }

    /// <summary>
    /// StructProperty: GrateCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrateCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3832); }
    }

    /// <summary>
    /// StructProperty: FreeCameraSitOffsetMin
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FreeCameraSitOffsetMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3844); }
    }

    /// <summary>
    /// StructProperty: FreeCameraSitOffsetUp
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FreeCameraSitOffsetUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3856); }
    }

    /// <summary>
    /// StructProperty: FreeCameraSitOffsetDown
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FreeCameraSitOffsetDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3868); }
    }

    /// <summary>
    /// StructProperty: FreeCameraPullOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FreeCameraPullOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3880); }
    }

    /// <summary>
    /// FloatProperty: CurrentSitOffsetPower
    /// </summary>
    public unsafe float CurrentSitOffsetPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3892); }
    }

    /// <summary>
    /// FloatProperty: CurrentSitOffsetMin
    /// </summary>
    public unsafe float CurrentSitOffsetMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3896); }
    }

    /// <summary>
    /// FloatProperty: CurrentSitOffsetMax
    /// </summary>
    public unsafe float CurrentSitOffsetMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3900); }
    }

    /// <summary>
    /// StructProperty: StateFreeCameraSitOffsetMin
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateFreeCameraSitOffsetMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3904); }
    }

    /// <summary>
    /// StructProperty: StateFreeCameraSitOffsetUp
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateFreeCameraSitOffsetUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3916); }
    }

    /// <summary>
    /// StructProperty: StateFreeCameraSitOffsetDown
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateFreeCameraSitOffsetDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3928); }
    }

    /// <summary>
    /// StructProperty: StateFreeCameraPullOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateFreeCameraPullOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3940); }
    }

    /// <summary>
    /// FloatProperty: StateSitOffsetPower
    /// </summary>
    public unsafe float StateSitOffsetPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3952); }
    }

    /// <summary>
    /// FloatProperty: StateSitOffsetMin
    /// </summary>
    public unsafe float StateSitOffsetMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3956); }
    }

    /// <summary>
    /// FloatProperty: StateSitOffsetMax
    /// </summary>
    public unsafe float StateSitOffsetMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3960); }
    }

    /// <summary>
    /// FloatProperty: StateDefaultCameraPitch
    /// </summary>
    public unsafe float StateDefaultCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3964); }
    }

    /// <summary>
    /// FloatProperty: CurrentDefaultCameraPitch
    /// </summary>
    public unsafe float CurrentDefaultCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3968); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraFollowPelvisXY
    /// </summary>
    public unsafe float CurrentCameraFollowPelvisXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3972); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraFollowPelvisZ
    /// </summary>
    public unsafe float CurrentCameraFollowPelvisZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3976); }
    }

    /// <summary>
    /// FloatProperty: CurrentPelvisSway
    /// </summary>
    public unsafe float CurrentPelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3980); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EdgeSwingCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3984); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingCameraFOVAngle
    /// </summary>
    public unsafe float EdgeSwingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3996); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EdgeSwingCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4000); }
    }

    /// <summary>
    /// StructProperty: CurrentAbsoluteHeadRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentAbsoluteHeadRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4012); }
    }

    /// <summary>
    /// StructProperty: LastAnchorRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastAnchorRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }
    }

    /// <summary>
    /// FloatProperty: ZoomExtraCameraPitch
    /// </summary>
    public unsafe float ZoomExtraCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4036); }
    }

    /// <summary>
    /// FloatProperty: CrosshairAngleOffset
    /// </summary>
    public unsafe float CrosshairAngleOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }

    /// <summary>
    /// FloatProperty: CrosshairAngleOffsetFactor
    /// </summary>
    public unsafe float CrosshairAngleOffsetFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// StructProperty: BaseZoomDOFSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BaseZoomDOFSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4048); }
    }

    /// <summary>
    /// FloatProperty: MinZoomFarApertureStop
    /// </summary>
    public unsafe float MinZoomFarApertureStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4068); }
    }

    /// <summary>
    /// StructProperty: ZoomedDOFSetting
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomedDOFSetting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4072); }
    }

    /// <summary>
    /// FloatProperty: ThugCameraFOVAngle
    /// </summary>
    public unsafe float ThugCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4092); }
    }

    /// <summary>
    /// FloatProperty: ThugZoomCameraFOVAngle
    /// </summary>
    public unsafe float ThugZoomCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// StructProperty: WalkCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WalkCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// StructProperty: WalkCanisterCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WalkCanisterCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// StructProperty: AgilityWalkCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AgilityWalkCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4436); }
    }

    /// <summary>
    /// StructProperty: RunCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RunCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4604); }
    }

    /// <summary>
    /// StructProperty: RooftopRunCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RooftopRunCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4772); }
    }

    /// <summary>
    /// StructProperty: DemonTrialsCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DemonTrialsCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4940); }
    }

    /// <summary>
    /// StructProperty: CombatWalkCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CombatWalkCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5108); }
    }

    /// <summary>
    /// StructProperty: StandingHoldCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StandingHoldCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5276); }
    }

    /// <summary>
    /// StructProperty: FearTakedownCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FearTakedownCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5444); }
    }

    /// <summary>
    /// StructProperty: StandingGrabCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StandingGrabCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5612); }
    }

    /// <summary>
    /// StructProperty: GrappleCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5780); }
    }

    /// <summary>
    /// StructProperty: GrappleRescueCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleRescueCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 5948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5948); }
    }

    /// <summary>
    /// StructProperty: HqGrappleStartCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HqGrappleStartCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6116); }
    }

    /// <summary>
    /// StructProperty: CapeChuteConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CapeChuteConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6284); }
    }

    /// <summary>
    /// StructProperty: LedgeHangCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LedgeHangCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6452); }
    }

    /// <summary>
    /// StructProperty: LedgeHangKickedByThugCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LedgeHangKickedByThugCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6620); }
    }

    /// <summary>
    /// StructProperty: LedgeHangTakedownStartCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LedgeHangTakedownStartCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6788); }
    }

    /// <summary>
    /// StructProperty: LedgeHangTakedownCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LedgeHangTakedownCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 6956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6956); }
    }

    /// <summary>
    /// StructProperty: QuickTakedownCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT QuickTakedownCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 7124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7124); }
    }

    /// <summary>
    /// StructProperty: GenericFarFreeCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GenericFarFreeCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 7292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7292); }
    }

    /// <summary>
    /// StructProperty: AirshipControlCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AirshipControlCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 7460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7460); }
    }

    /// <summary>
    /// StructProperty: RaftPullCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RaftPullCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 7628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7628); }
    }

    /// <summary>
    /// StructProperty: HangPointCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HangPointCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 7796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7796); }
    }

    /// <summary>
    /// StructProperty: StealthCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StealthCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 7964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7964); }
    }

    /// <summary>
    /// StructProperty: StealthWallCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StealthWallCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8132); }
    }

    /// <summary>
    /// StructProperty: CrouchUnderObstacleCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CrouchUnderObstacleCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8300); }
    }

    /// <summary>
    /// StructProperty: RailingCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RailingCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8468); }
    }

    /// <summary>
    /// StructProperty: FloorAttackCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FloorAttackCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8636); }
    }

    /// <summary>
    /// StructProperty: IntroCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT IntroCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8804); }
    }

    /// <summary>
    /// StructProperty: SwingingCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SwingingCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8972); }
    }

    /// <summary>
    /// StructProperty: WallClimbCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WallClimbCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 9140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9140); }
    }

    /// <summary>
    /// StructProperty: WallClimbStartCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WallClimbStartCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 9308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9308); }
    }

    /// <summary>
    /// StructProperty: PounceCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PounceCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 9476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9476); }
    }

    /// <summary>
    /// StructProperty: VantageClimbCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VantageClimbCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 9644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9644); }
    }

    /// <summary>
    /// StructProperty: SwingingFromAboveCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SwingingFromAboveCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 9812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9812); }
    }

    /// <summary>
    /// StructProperty: TakedownFromAboveCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TakedownFromAboveCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 9980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9980); }
    }

    /// <summary>
    /// StructProperty: SilentPredatorCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SilentPredatorCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10148); }
    }

    /// <summary>
    /// StructProperty: PerchLedgeCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PerchLedgeCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10316); }
    }

    /// <summary>
    /// StructProperty: PerchLedgeSwingCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PerchLedgeSwingCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10484); }
    }

    /// <summary>
    /// StructProperty: CorridorCombatCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CorridorCombatCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10652); }
    }

    /// <summary>
    /// StructProperty: NightwingBossFightCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NightwingBossFightCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10820); }
    }

    /// <summary>
    /// StructProperty: HighCombatCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HighCombatCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10988); }
    }

    /// <summary>
    /// StructProperty: LookDownCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LookDownCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 11156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11156); }
    }

    /// <summary>
    /// StructProperty: LineLauncherCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LineLauncherCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 11324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11324); }
    }

    /// <summary>
    /// StructProperty: BatarangCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatarangCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 11492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11492); }
    }

    /// <summary>
    /// StructProperty: WhipRappelBolaCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WhipRappelBolaCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 11660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11660); }
    }

    /// <summary>
    /// StructProperty: HarpoonAimConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HarpoonAimConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 11828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11828); }
    }

    /// <summary>
    /// StructProperty: MagneticBlastAimConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MagneticBlastAimConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 11996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11996); }
    }

    /// <summary>
    /// StructProperty: OmnitronAimConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OmnitronAimConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 12164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12164); }
    }

    /// <summary>
    /// StructProperty: OmnitronStealthAimConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OmnitronStealthAimConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 12332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12332); }
    }

    /// <summary>
    /// StructProperty: RHDAimConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDAimConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 12500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12500); }
    }

    /// <summary>
    /// StructProperty: RHDStealthAimConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDStealthAimConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 12668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12668); }
    }

    /// <summary>
    /// StructProperty: FreezeJammerAimConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FreezeJammerAimConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 12836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12836); }
    }

    /// <summary>
    /// StructProperty: JokerGunAimConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JokerGunAimConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 13004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13004); }
    }

    /// <summary>
    /// StructProperty: JokerGunZoomAimConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JokerGunZoomAimConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 13172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13172); }
    }

    /// <summary>
    /// StructProperty: JokerGunZoomRoom3AimConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JokerGunZoomRoom3AimConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 13340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13340); }
    }

    /// <summary>
    /// StructProperty: GrateCameraConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrateCameraConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 13508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13508); }
    }

    /// <summary>
    /// StructProperty: HighGrateCameraConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HighGrateCameraConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 13676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13676); }
    }

    /// <summary>
    /// StructProperty: SlideCameraConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SlideCameraConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 13844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13844); }
    }

    /// <summary>
    /// StructProperty: CeilingClimbCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CeilingClimbCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 14012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14012); }
    }

    /// <summary>
    /// StructProperty: CeilingToLedgeHangCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CeilingToLedgeHangCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 14180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14180); }
    }

    /// <summary>
    /// StructProperty: CeilingToCatwalkCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CeilingToCatwalkCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 14348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14348); }
    }

    /// <summary>
    /// StructProperty: CeilingBatarangCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CeilingBatarangCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 14516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14516); }
    }

    /// <summary>
    /// StructProperty: LedgeSwingCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LedgeSwingCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 14684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14684); }
    }

    /// <summary>
    /// StructProperty: DeepFallLandCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DeepFallLandCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 14852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14852); }
    }

    /// <summary>
    /// StructProperty: HelicopterCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HelicopterCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 15020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 15020); }
    }

    /// <summary>
    /// StructProperty: DrivingCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DrivingCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 15188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 15188); }
    }

    /// <summary>
    /// StructProperty: FleeingCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FleeingCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 15356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 15356); }
    }

    /// <summary>
    /// StructProperty: BoostingCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BoostingCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 15524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 15524); }
    }

    /// <summary>
    /// StructProperty: BarrelRollCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BarrelRollCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 15692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 15692); }
    }

    /// <summary>
    /// StructProperty: BattleModeCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BattleModeCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 15860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 15860); }
    }

    /// <summary>
    /// StructProperty: BattleModeWinchCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BattleModeWinchCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16028); }
    }

    /// <summary>
    /// StructProperty: BattleModeAbseilingCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BattleModeAbseilingCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16196); }
    }

    /// <summary>
    /// StructProperty: ChasingCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ChasingCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16364); }
    }

    /// <summary>
    /// StructProperty: GlideInBatmobileCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GlideInBatmobileCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16532); }
    }

    /// <summary>
    /// StructProperty: ThugCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThugCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16700); }
    }

    /// <summary>
    /// StructProperty: DiveToBatmobilePickupCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DiveToBatmobilePickupCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16868); }
    }

    /// <summary>
    /// StructProperty: DisruptorSniperStandingCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DisruptorSniperStandingCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 17036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17036); }
    }

    /// <summary>
    /// StructProperty: DisruptorSniperVantageCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DisruptorSniperVantageCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 17204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17204); }
    }

    /// <summary>
    /// StructProperty: DisruptorSniperRailingCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DisruptorSniperRailingCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 17372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17372); }
    }

    /// <summary>
    /// StructProperty: DisruptorSniperCornerCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DisruptorSniperCornerCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 17540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17540); }
    }

    /// <summary>
    /// StructProperty: BatmobileConversationCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmobileConversationCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 17708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17708); }
    }

    /// <summary>
    /// StructProperty: RidingCarCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RidingCarCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 17876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17876); }
    }

    /// <summary>
    /// StructProperty: ScarerowBossCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ScarerowBossCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18044); }
    }

    /// <summary>
    /// FloatProperty: MinFleeCameraDist
    /// </summary>
    public unsafe float MinFleeCameraDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 18212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18212); }
    }

    /// <summary>
    /// FloatProperty: MaxFleeCameraDist
    /// </summary>
    public unsafe float MaxFleeCameraDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 18216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18216); }
    }

    /// <summary>
    /// FloatProperty: FleeCameraDistOffset
    /// </summary>
    public unsafe float FleeCameraDistOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 18220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18220); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentCameraConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18224); }
    }

    /// <summary>
    /// FloatProperty: LookDownVantageCamFOVAngle
    /// </summary>
    public unsafe float LookDownVantageCamFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 18392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18392); }
    }

    /// <summary>
    /// StructProperty: LookDownDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LookDownDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18396); }
    }

    /// <summary>
    /// StructProperty: AlternativeWalkCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AlternativeWalkCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18408); }
    }

    /// <summary>
    /// FloatProperty: AlternativeWalkCamFOV
    /// </summary>
    public unsafe float AlternativeWalkCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 18576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18576); }
    }

    /// <summary>
    /// FloatProperty: SlideStateCameraFOVAngle
    /// </summary>
    public unsafe float SlideStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 18580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18580); }
    }

    /// <summary>
    /// StructProperty: DiveOverRailingPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DiveOverRailingPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18584); }
    }

    /// <summary>
    /// FloatProperty: DiveOverRailingPitch
    /// </summary>
    public unsafe float DiveOverRailingPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 18596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18596); }
    }

    /// <summary>
    /// FloatProperty: BatmobileConversationCamFOV
    /// </summary>
    public unsafe float BatmobileConversationCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 18600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18600); }
    }

    /// <summary>
    /// StructProperty: ScarecrowOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ScarecrowOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18604); }
    }

    /// <summary>
    /// StructProperty: ScarecrowPivot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ScarecrowPivot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18616); }
    }

    /// <summary>
    /// FloatProperty: CameraWanderTimer
    /// </summary>
    public unsafe float CameraWanderTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 18628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18628); }
    }

    /// <summary>
    /// StructProperty: CameraWander
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraWander
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18632); }
    }

    /// <summary>
    /// StructProperty: CameraWanderRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraWanderRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18644); }
    }

    /// <summary>
    /// FloatProperty: CameraWanderFOV
    /// </summary>
    public unsafe float CameraWanderFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 18656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18656); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraWanderSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentCameraWanderSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18660); }
    }

    /// <summary>
    /// StructProperty: WorldSpaceCameraWander
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WorldSpaceCameraWander
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18736); }
    }

    /// <summary>
    /// StructProperty: WorldSpaceWanderBase
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WorldSpaceWanderBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18800); }
    }

    /// <summary>
    /// ByteProperty: BlimpRenderingDPG
    /// </summary>
    public unsafe byte BlimpRenderingDPG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 18864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18864); }
    }

    /// <summary>
    /// ByteProperty: LookAtSpeed
    /// </summary>
    public unsafe byte LookAtSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 18865); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18865); }
    }

    /// <summary>
    /// ByteProperty: LookAtType
    /// </summary>
    public unsafe byte LookAtType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 18866); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18866); }
    }

    /// <summary>
    /// ByteProperty: LookAtStrength
    /// </summary>
    public unsafe byte LookAtStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 18867); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18867); }
    }

    /// <summary>
    /// ByteProperty: CurrentZoomPoint
    /// </summary>
    public unsafe byte CurrentZoomPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 18868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18868); }
    }

    /// <summary>
    /// ByteProperty: DrivingCameraSetup
    /// </summary>
    public unsafe byte DrivingCameraSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 18869); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18869); }
    }

    /// <summary>
    /// StructProperty: BlimpUnrotatedViewRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BlimpUnrotatedViewRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18872); }
    }

    /// <summary>
    /// StructProperty: BlimpUnrotatedViewLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BlimpUnrotatedViewLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18884); }
    }

    /// <summary>
    /// StructProperty: ResonatorWanderSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ResonatorWanderSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18896); }
    }

    /// <summary>
    /// StructProperty: RHDWanderSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDWanderSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 18964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18964); }
    }

    /// <summary>
    /// StructProperty: ScarecrowWanderSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ScarecrowWanderSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 19032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19032); }
    }

    /// <summary>
    /// StructProperty: GlideWanderSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GlideWanderSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 19100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19100); }
    }

    /// <summary>
    /// StructProperty: GlideCameraShake
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GlideCameraShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 19168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19168); }
    }

    /// <summary>
    /// StructProperty: BoostGlideCameraShake
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BoostGlideCameraShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 19324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19324); }
    }

    /// <summary>
    /// StructProperty: GrappleCameraShake
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleCameraShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 19480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19480); }
    }

    /// <summary>
    /// StructProperty: BatmobileBoostCameraShake
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmobileBoostCameraShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 19636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19636); }
    }

    /// <summary>
    /// StructProperty: BatmobileWheelSpinCameraShake
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmobileWheelSpinCameraShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 19792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19792); }
    }

    /// <summary>
    /// StructProperty: BatmobileWheelSpinCameraCamOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmobileWheelSpinCameraCamOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 19948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19948); }
    }

    /// <summary>
    /// IntProperty: GlideShakeId
    /// </summary>
    public unsafe int GlideShakeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 19960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19960); }
    }

    /// <summary>
    /// FloatProperty: Test
    /// </summary>
    public unsafe float Test
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 19964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19964); }
    }

    /// <summary>
    /// StructProperty: CameraBlendRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraBlendRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 19968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19968); }
    }

    /// <summary>
    /// StructProperty: CameraBlendInitialRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraBlendInitialRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 19980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19980); }
    }

    /// <summary>
    /// StructProperty: ExtraDeltaRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExtraDeltaRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 19992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19992); }
    }

    /// <summary>
    /// StructProperty: CornerStateOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CornerStateOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20004); }
    }

    /// <summary>
    /// FloatProperty: CornerStateFOVAngle
    /// </summary>
    public unsafe float CornerStateFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20016); }
    }

    /// <summary>
    /// StructProperty: CornerStateDefaultRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CornerStateDefaultRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20020); }
    }

    /// <summary>
    /// StructProperty: CornerStateCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CornerStateCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20032); }
    }

    /// <summary>
    /// FloatProperty: ZoomedFOVAngle
    /// </summary>
    public unsafe float ZoomedFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20044); }
    }

    /// <summary>
    /// FloatProperty: ZoomProp
    /// </summary>
    public unsafe float ZoomProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20048); }
    }

    /// <summary>
    /// FloatProperty: ForceZoomFOVAngle
    /// </summary>
    public unsafe float ForceZoomFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20052); }
    }

    /// <summary>
    /// FloatProperty: MotionBlurAmount
    /// </summary>
    public unsafe float MotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20056); }
    }

    /// <summary>
    /// FloatProperty: MotionBlurBlendTime
    /// </summary>
    public unsafe float MotionBlurBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20060); }
    }

    /// <summary>
    /// FloatProperty: InitialMotionBlurAmount
    /// </summary>
    public unsafe float InitialMotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20064); }
    }

    /// <summary>
    /// FloatProperty: InitialMotionBlurMaxVelocity
    /// </summary>
    public unsafe float InitialMotionBlurMaxVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20068); }
    }

    /// <summary>
    /// FloatProperty: MinCameraMotionBlur
    /// </summary>
    public unsafe float MinCameraMotionBlur
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20072); }
    }

    /// <summary>
    /// StructProperty: ResonatorCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ResonatorCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20076); }
    }

    /// <summary>
    /// FloatProperty: ResonatorFOVAngle
    /// </summary>
    public unsafe float ResonatorFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20088); }
    }

    /// <summary>
    /// StructProperty: ResonatorCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ResonatorCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20092); }
    }

    /// <summary>
    /// StructProperty: RHDPasswordCrackCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDPasswordCrackCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20104); }
    }

    /// <summary>
    /// FloatProperty: RHDPasswordCrackFOVAngle
    /// </summary>
    public unsafe float RHDPasswordCrackFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20116); }
    }

    /// <summary>
    /// FloatProperty: RHDPasswordCrack43FOVAngle
    /// </summary>
    public unsafe float RHDPasswordCrack43FOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20120); }
    }

    /// <summary>
    /// StructProperty: RHDPasswordCrackCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDPasswordCrackCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20124); }
    }

    /// <summary>
    /// StructProperty: LastCameraPivotPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastCameraPivotPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20136); }
    }

    /// <summary>
    /// FloatProperty: OverrideBloomValue
    /// </summary>
    public unsafe float OverrideBloomValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20148); }
    }

    /// <summary>
    /// FloatProperty: LoadedAspectRatio
    /// </summary>
    public unsafe float LoadedAspectRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20152); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraAssistStrength
    /// </summary>
    public unsafe float CurrentCameraAssistStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20156); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraAssistStrengthScale
    /// </summary>
    public unsafe float CurrentCameraAssistStrengthScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20160); }
    }

    /// <summary>
    /// FloatProperty: CameraAssistBuildUpTime
    /// </summary>
    public unsafe float CameraAssistBuildUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20164); }
    }

    /// <summary>
    /// StructProperty: CurrentDefaultPelvisDiff
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentDefaultPelvisDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20168); }
    }

    /// <summary>
    /// StructProperty: DefaultPelvisDiff
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DefaultPelvisDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20180); }
    }

    /// <summary>
    /// FloatProperty: LastStepUpOffset
    /// </summary>
    public unsafe float LastStepUpOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20192); }
    }

    /// <summary>
    /// ArrayProperty: RetainZoomStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>>>>> RetainZoomStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>>>>>>(Ptr + 20196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20196); }
    }

    /// <summary>
    /// ArrayProperty: ForceUnZoomStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>>>> ForceUnZoomStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>>>>>(Ptr + 20212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20212); }
    }

    /// <summary>
    /// FloatProperty: OverrideTransitionInDuration
    /// </summary>
    public unsafe float OverrideTransitionInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20228); }
    }

    /// <summary>
    /// ArrayProperty: LookAtSpeeds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>>> LookAtSpeeds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>>>>(Ptr + 20232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20232); }
    }

    /// <summary>
    /// StructProperty: DesiredLookRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DesiredLookRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20248); }
    }

    /// <summary>
    /// StructProperty: DesiredLookLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DesiredLookLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20260); }
    }

    /// <summary>
    /// StructProperty: ZoomOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20272); }
    }

    /// <summary>
    /// StructProperty: ZoomCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20284); }
    }

    /// <summary>
    /// StructProperty: CeilingZoomOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CeilingZoomOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20296); }
    }

    /// <summary>
    /// StructProperty: CeilingCameraZoomOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CeilingCameraZoomOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20308); }
    }

    /// <summary>
    /// FloatProperty: ZoomFocusSpeed
    /// </summary>
    public unsafe float ZoomFocusSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20320); }
    }

    /// <summary>
    /// FloatProperty: MaxZoomFocusDistance
    /// </summary>
    public unsafe float MaxZoomFocusDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20324); }
    }

    /// <summary>
    /// ArrayProperty: CameraHiddenActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>> CameraHiddenActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>>>(Ptr + 20328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20328); }
    }

    /// <summary>
    /// ArrayProperty: CameraHideClasses
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Camera.ModifierList> CameraHideClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Camera.ModifierList>>(Ptr + 20344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20344); }
    }

    /// <summary>
    /// NameProperty: RunOverlayName
    /// </summary>
    public unsafe BmSDK.FName RunOverlayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 20360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20360); }
    }

    /// <summary>
    /// FloatProperty: RunOverlayStrength
    /// </summary>
    public unsafe float RunOverlayStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20368); }
    }

    /// <summary>
    /// FloatProperty: RunOverlayZeroFrame
    /// </summary>
    public unsafe float RunOverlayZeroFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20372); }
    }

    /// <summary>
    /// FloatProperty: HelicopterCameraFOVAngle
    /// </summary>
    public unsafe float HelicopterCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20376); }
    }

    /// <summary>
    /// FloatProperty: ResonatorPPFactor
    /// </summary>
    public unsafe float ResonatorPPFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20380); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_HighlightsMod
    /// </summary>
    public unsafe float ResonatorScreenScene_HighlightsMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20384); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_MidTonesMod
    /// </summary>
    public unsafe float ResonatorScreenScene_MidTonesMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20388); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_ShadowsMod
    /// </summary>
    public unsafe float ResonatorScreenScene_ShadowsMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20392); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFApertureStop
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFApertureStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20396); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFDistance
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20400); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamFOVInterpMaxSpeed
    /// </summary>
    public unsafe float DrivingCamFOVInterpMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20404); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamFOV
    /// </summary>
    public unsafe float DrivingCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20408); }
    }

    /// <summary>
    /// FloatProperty: BoostingCamFOV
    /// </summary>
    public unsafe float BoostingCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20412); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamMaxExtraFOV
    /// </summary>
    public unsafe float DrivingCamMaxExtraFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20416); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamMaxExtraTranslation
    /// </summary>
    public unsafe float DrivingCamMaxExtraTranslation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20420); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamMaxExtraSpringStrength
    /// </summary>
    public unsafe float DrivingCamMaxExtraSpringStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20424); }
    }

    /// <summary>
    /// FloatProperty: DrivingCameraJumpSmootherInterpolant
    /// </summary>
    public unsafe float DrivingCameraJumpSmootherInterpolant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20428); }
    }

    /// <summary>
    /// FloatProperty: BattleModeCamFOV
    /// </summary>
    public unsafe float BattleModeCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20432); }
    }

    /// <summary>
    /// FloatProperty: BattleModeWinchCamFOV
    /// </summary>
    public unsafe float BattleModeWinchCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20436); }
    }

    /// <summary>
    /// FloatProperty: AntiPersonelBattleModeCamFOV
    /// </summary>
    public unsafe float AntiPersonelBattleModeCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20440); }
    }

    /// <summary>
    /// StructProperty: BattleModeHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BattleModeHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20444); }
    }

    /// <summary>
    /// StructProperty: DrivingModeHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DrivingModeHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20456); }
    }

    /// <summary>
    /// FloatProperty: DrivingModeSteeringCamFactor
    /// </summary>
    public unsafe float DrivingModeSteeringCamFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20468); }
    }

    /// <summary>
    /// StructProperty: BattleModeWinchHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BattleModeWinchHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20472); }
    }

    /// <summary>
    /// FloatProperty: DrivingCameraLeanFactor
    /// </summary>
    public unsafe float DrivingCameraLeanFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20484); }
    }

    /// <summary>
    /// FloatProperty: DrivingCameraPitchFactor
    /// </summary>
    public unsafe float DrivingCameraPitchFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20488); }
    }

    /// <summary>
    /// FloatProperty: ChasingCamFOV
    /// </summary>
    public unsafe float ChasingCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20492); }
    }

    /// <summary>
    /// StructProperty: ChasingCamExtraCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ChasingCamExtraCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20496); }
    }

    /// <summary>
    /// FloatProperty: JumpSmoothingStrength
    /// </summary>
    public unsafe float JumpSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20508); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamSmoothingStrength
    /// </summary>
    public unsafe float DrivingCamSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20512); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamDriftOrientationFactor
    /// </summary>
    public unsafe float DrivingCamDriftOrientationFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20516); }
    }

    /// <summary>
    /// FloatProperty: BoostingCamSmoothingStrength
    /// </summary>
    public unsafe float BoostingCamSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20520); }
    }

    /// <summary>
    /// FloatProperty: AirborneCamSmoothingStrength
    /// </summary>
    public unsafe float AirborneCamSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20524); }
    }

    /// <summary>
    /// FloatProperty: ActualDrivingSmoothingStrength
    /// </summary>
    public unsafe float ActualDrivingSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20528); }
    }

    /// <summary>
    /// StructProperty: BattleModeAbseilingExtraCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BattleModeAbseilingExtraCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20532); }
    }

    /// <summary>
    /// FloatProperty: CurrentDrivingSpeedFactor
    /// </summary>
    public unsafe float CurrentDrivingSpeedFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20544); }
    }

    /// <summary>
    /// StructProperty: GauntletCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GauntletCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20548); }
    }

    /// <summary>
    /// FloatProperty: GauntletCameraFOVAngle
    /// </summary>
    public unsafe float GauntletCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20560); }
    }

    /// <summary>
    /// StructProperty: GauntletDefaultCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GauntletDefaultCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20564); }
    }

    /// <summary>
    /// StructProperty: GauntletCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GauntletCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20576); }
    }

    /// <summary>
    /// StructProperty: GauntletPerchCamConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GauntletPerchCamConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20744); }
    }

    /// <summary>
    /// StructProperty: CurrentRailingOffsetSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentRailingOffsetSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20912); }
    }

    /// <summary>
    /// StructProperty: DefaultRailingOffsetSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DefaultRailingOffsetSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20936); }
    }

    /// <summary>
    /// StructProperty: DisruptorRailingOffsetSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DisruptorRailingOffsetSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20960); }
    }

    /// <summary>
    /// StructProperty: RHDRailingOffsetSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RHDRailingOffsetSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 20984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20984); }
    }

    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraSmoothingBuffer_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21008); }
    }
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraSmoothingBuffer_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21024); }
    }
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraSmoothingBuffer_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21040); }
    }
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraSmoothingBuffer_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21056); }
    }
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraSmoothingBuffer_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21072); }
    }
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraSmoothingBuffer_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21088); }
    }
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraSmoothingBuffer_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21104); }
    }
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraSmoothingBuffer_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21120); }
    }
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraSmoothingBuffer_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21136); }
    }
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraSmoothingBuffer_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21152); }
    }

    /// <summary>
    /// IntProperty: CameraSmoothingCount
    /// </summary>
    public unsafe int CameraSmoothingCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 21168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21168); }
    }

    /// <summary>
    /// FloatProperty: SmoothingConfigMaxVelocity
    /// </summary>
    public unsafe float SmoothingConfigMaxVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21172); }
    }

    /// <summary>
    /// FloatProperty: SmoothingConfigStrength
    /// </summary>
    public unsafe float SmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21176); }
    }

    /// <summary>
    /// FloatProperty: SmoothingConfigMaxAccel
    /// </summary>
    public unsafe float SmoothingConfigMaxAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21180); }
    }

    /// <summary>
    /// FloatProperty: CurrentSmoothingConfigStrength
    /// </summary>
    public unsafe float CurrentSmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21184); }
    }

    /// <summary>
    /// FloatProperty: OverworldRunningConfigStrength
    /// </summary>
    public unsafe float OverworldRunningConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21188); }
    }

    /// <summary>
    /// FloatProperty: NormalConfigStrength
    /// </summary>
    public unsafe float NormalConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21192); }
    }

    /// <summary>
    /// StructProperty: ChasePosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ChasePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21196); }
    }

    /// <summary>
    /// StructProperty: ChaseVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ChaseVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21208); }
    }

    /// <summary>
    /// FloatProperty: LastCameraMoveTime
    /// </summary>
    public unsafe float LastCameraMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21220); }
    }

    /// <summary>
    /// FloatProperty: PelvisFollowZ
    /// </summary>
    public unsafe float PelvisFollowZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21224); }
    }

    /// <summary>
    /// FloatProperty: PelvisFollowXY
    /// </summary>
    public unsafe float PelvisFollowXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21228); }
    }

    /// <summary>
    /// FloatProperty: PelvisSway
    /// </summary>
    public unsafe float PelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21232); }
    }

    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21236); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21240); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21244); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21248); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21252); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21256); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21260); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21264); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21268); }
    }

    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomPointDir_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21272); }
    }
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomPointDir_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21284); }
    }
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomPointDir_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21296); }
    }
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomPointDir_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21308); }
    }
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomPointDir_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21320); }
    }
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomPointDir_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21332); }
    }
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomPointDir_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21344); }
    }
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomPointDir_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21356); }
    }
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomPointDir_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21368); }
    }

    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TightZoomPointDir_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21380); }
    }
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TightZoomPointDir_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21392); }
    }
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TightZoomPointDir_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21404); }
    }
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TightZoomPointDir_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21416); }
    }
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TightZoomPointDir_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21428); }
    }
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TightZoomPointDir_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21440); }
    }
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TightZoomPointDir_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21452); }
    }
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TightZoomPointDir_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21464); }
    }
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TightZoomPointDir_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21476); }
    }

    /// <summary>
    /// FloatProperty: ZoomPointAngle
    /// </summary>
    public unsafe float ZoomPointAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21488); }
    }

    /// <summary>
    /// FloatProperty: TightZoomPointAngle
    /// </summary>
    public unsafe float TightZoomPointAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21492); }
    }

    /// <summary>
    /// FloatProperty: FancySniperZoomPointValues
    /// </summary>
    public unsafe float FancySniperZoomPointValues_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21496); }
    }
    /// <summary>
    /// FloatProperty: FancySniperZoomPointValues
    /// </summary>
    public unsafe float FancySniperZoomPointValues_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21500); }
    }
    /// <summary>
    /// FloatProperty: FancySniperZoomPointValues
    /// </summary>
    public unsafe float FancySniperZoomPointValues_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21504); }
    }
    /// <summary>
    /// FloatProperty: FancySniperZoomPointValues
    /// </summary>
    public unsafe float FancySniperZoomPointValues_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21508); }
    }
    /// <summary>
    /// FloatProperty: FancySniperZoomPointValues
    /// </summary>
    public unsafe float FancySniperZoomPointValues_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21512); }
    }
    /// <summary>
    /// FloatProperty: FancySniperZoomPointValues
    /// </summary>
    public unsafe float FancySniperZoomPointValues_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21516); }
    }
    /// <summary>
    /// FloatProperty: FancySniperZoomPointValues
    /// </summary>
    public unsafe float FancySniperZoomPointValues_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21520); }
    }
    /// <summary>
    /// FloatProperty: FancySniperZoomPointValues
    /// </summary>
    public unsafe float FancySniperZoomPointValues_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21524); }
    }
    /// <summary>
    /// FloatProperty: FancySniperZoomPointValues
    /// </summary>
    public unsafe float FancySniperZoomPointValues_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21528); }
    }

    /// <summary>
    /// StructProperty: LastCameraTargetPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastCameraTargetPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21532); }
    }

    /// <summary>
    /// FloatProperty: StateMinCameraSmoothingAngle
    /// </summary>
    public unsafe float StateMinCameraSmoothingAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21544); }
    }

    /// <summary>
    /// FloatProperty: StateMaxCameraSmoothingAngle
    /// </summary>
    public unsafe float StateMaxCameraSmoothingAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21548); }
    }

    /// <summary>
    /// StructProperty: Smoother
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Smoother
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21552); }
    }

    /// <summary>
    /// FloatProperty: RunStatePelvisXY
    /// </summary>
    public unsafe float RunStatePelvisXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21588); }
    }

    /// <summary>
    /// FloatProperty: RunStatePelvisZ
    /// </summary>
    public unsafe float RunStatePelvisZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21592); }
    }

    /// <summary>
    /// FloatProperty: RunStatePelvisSway
    /// </summary>
    public unsafe float RunStatePelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21596); }
    }

    /// <summary>
    /// FloatProperty: DefaultPelvisFollowZ
    /// </summary>
    public unsafe float DefaultPelvisFollowZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21600); }
    }

    /// <summary>
    /// FloatProperty: DefaultPelvisFollowXY
    /// </summary>
    public unsafe float DefaultPelvisFollowXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21604); }
    }

    /// <summary>
    /// FloatProperty: DefaultPelvisSway
    /// </summary>
    public unsafe float DefaultPelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21608); }
    }

    /// <summary>
    /// FloatProperty: LastCollisionDistSqr
    /// </summary>
    public unsafe float LastCollisionDistSqr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21612); }
    }

    /// <summary>
    /// FloatProperty: MaxCollisionDist
    /// </summary>
    public unsafe float MaxCollisionDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21616); }
    }

    /// <summary>
    /// StructProperty: CustomCameraConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CustomCameraConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21620); }
    }

    /// <summary>
    /// StructProperty: CustomCameraExtraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CustomCameraExtraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21788); }
    }

    /// <summary>
    /// FloatProperty: CustomCameraFOV
    /// </summary>
    public unsafe float CustomCameraFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21800); }
    }

    /// <summary>
    /// FloatProperty: CustomCameraZoomFOV
    /// </summary>
    public unsafe float CustomCameraZoomFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21804); }
    }

    /// <summary>
    /// StructProperty: CustomCameraRotationSpeed
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CustomCameraRotationSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21808); }
    }

    /// <summary>
    /// FloatProperty: CustomCameraTransitionTime
    /// </summary>
    public unsafe float CustomCameraTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21820); }
    }

    /// <summary>
    /// StructProperty: DefaultRotationSpeed
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DefaultRotationSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21824); }
    }

    /// <summary>
    /// FloatProperty: BatarangOutOfRangeFXStrength
    /// </summary>
    public unsafe float BatarangOutOfRangeFXStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21836); }
    }

    /// <summary>
    /// FloatProperty: PitchDragSpeed
    /// </summary>
    public unsafe float PitchDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21840); }
    }

    /// <summary>
    /// FloatProperty: DefaultPitchDragSpeed
    /// </summary>
    public unsafe float DefaultPitchDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21844); }
    }

    /// <summary>
    /// FloatProperty: FallingPitchDragSpeed
    /// </summary>
    public unsafe float FallingPitchDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21848); }
    }

    /// <summary>
    /// FloatProperty: BlendPct
    /// </summary>
    public unsafe float BlendPct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21852); }
    }

    /// <summary>
    /// FloatProperty: DisruptorSniperFOVAngle
    /// </summary>
    public unsafe float DisruptorSniperFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21856); }
    }

    /// <summary>
    /// FloatProperty: DisruptorSniperZoomedFOVAngle
    /// </summary>
    public unsafe float DisruptorSniperZoomedFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21860); }
    }

    /// <summary>
    /// StructProperty: vDisruptorCornerCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT vDisruptorCornerCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21864); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21876); }
    }

    /// <summary>
    /// StructProperty: CockpitCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CockpitCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21888); }
    }

    /// <summary>
    /// StructProperty: LoopTheLoopCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LoopTheLoopCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21900); }
    }

    /// <summary>
    /// StructProperty: FixedCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FixedCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21912); }
    }

    /// <summary>
    /// FloatProperty: FixedCameraInterpolant
    /// </summary>
    public unsafe float FixedCameraInterpolant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 21924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21924); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraAccelFactor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraAccelFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21928); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraSpringPower
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraSpringPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21940); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraSpringConst
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21952); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraSpringDampingFactor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraSpringDampingFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21964); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraSpringDampingPower
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraSpringDampingPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21976); }
    }

    /// <summary>
    /// StructProperty: BonnetCamMax
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCamMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 21988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21988); }
    }

    /// <summary>
    /// StructProperty: BonnetCamMin
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCamMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22000); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamAccelFOVFactor
    /// </summary>
    public unsafe float DrivingCamAccelFOVFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22012); }
    }

    /// <summary>
    /// StructProperty: CurrentBonnetCameraHead
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentBonnetCameraHead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22016); }
    }

    /// <summary>
    /// StructProperty: CurrentBonnetCameraHeadVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentBonnetCameraHeadVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22028); }
    }

    /// <summary>
    /// StructProperty: OculusPlayerCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OculusPlayerCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22040); }
    }

    /// <summary>
    /// StructProperty: OculusBattleModeCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OculusBattleModeCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22052); }
    }

    /// <summary>
    /// FloatProperty: DrivingHeadImpulseFactor
    /// </summary>
    public unsafe float DrivingHeadImpulseFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22064); }
    }

    /// <summary>
    /// StructProperty: CopSittingAtBarHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CopSittingAtBarHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22068); }
    }

    /// <summary>
    /// StructProperty: CopSittingAtBarPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CopSittingAtBarPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22080); }
    }

    /// <summary>
    /// StructProperty: CopSittingAtBarOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CopSittingAtBarOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22092); }
    }

    /// <summary>
    /// FloatProperty: CopSittingAtBarFov
    /// </summary>
    public unsafe float CopSittingAtBarFov
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22104); }
    }

    /// <summary>
    /// FloatProperty: CopCameraZoomFOV
    /// </summary>
    public unsafe float CopCameraZoomFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22108); }
    }

    /// <summary>
    /// StructProperty: FirstPersonCameraCopCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FirstPersonCameraCopCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22112); }
    }

    /// <summary>
    /// StructProperty: FirstPersonCameraCopCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FirstPersonCameraCopCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22124); }
    }

    /// <summary>
    /// StructProperty: FirstPersonCameraCopHeadOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FirstPersonCameraCopHeadOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22136); }
    }

    /// <summary>
    /// FloatProperty: RidingCarCamFOV
    /// </summary>
    public unsafe float RidingCarCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22148); }
    }

    /// <summary>
    /// FloatProperty: RidingCarSmoothingConfigStrength
    /// </summary>
    public unsafe float RidingCarSmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22152); }
    }

    /// <summary>
    /// StructProperty: DrivingCamConfig1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DrivingCamConfig1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22156); }
    }

    /// <summary>
    /// StructProperty: BoostingCamConfig1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BoostingCamConfig1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22324); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamFOVInterpMaxSpeed1
    /// </summary>
    public unsafe float DrivingCamFOVInterpMaxSpeed1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22492); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamFOV1
    /// </summary>
    public unsafe float DrivingCamFOV1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22496); }
    }

    /// <summary>
    /// FloatProperty: BoostingCamFOV1
    /// </summary>
    public unsafe float BoostingCamFOV1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22500); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamMaxExtraFOV1
    /// </summary>
    public unsafe float DrivingCamMaxExtraFOV1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22504); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamMaxExtraTranslation1
    /// </summary>
    public unsafe float DrivingCamMaxExtraTranslation1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22508); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamMaxExtraSpringStrength1
    /// </summary>
    public unsafe float DrivingCamMaxExtraSpringStrength1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22512); }
    }

    /// <summary>
    /// FloatProperty: BoostingCamSmoothingStrength1
    /// </summary>
    public unsafe float BoostingCamSmoothingStrength1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22516); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamSmoothingStrength1
    /// </summary>
    public unsafe float DrivingCamSmoothingStrength1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22520); }
    }

    /// <summary>
    /// FloatProperty: AirborneCamSmoothingStrength1
    /// </summary>
    public unsafe float AirborneCamSmoothingStrength1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22524); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraOffset1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraOffset1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22528); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraSpringDampingPower1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraSpringDampingPower1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22540); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraSpringDampingFactor1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraSpringDampingFactor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22552); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraSpringPower1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraSpringPower1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22564); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraSpringConst1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraSpringConst1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22576); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraAccelFactor1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraAccelFactor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22588); }
    }

    /// <summary>
    /// StructProperty: BonnetCamMax1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCamMax1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22600); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamAccelFOVFactor1
    /// </summary>
    public unsafe float DrivingCamAccelFOVFactor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22612); }
    }

    /// <summary>
    /// FloatProperty: DrivingCameraLeanFactor1
    /// </summary>
    public unsafe float DrivingCameraLeanFactor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22616); }
    }

    /// <summary>
    /// FloatProperty: DrivingCameraPitchFactor1
    /// </summary>
    public unsafe float DrivingCameraPitchFactor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22620); }
    }

    /// <summary>
    /// FloatProperty: DrivingHeadImpulseFactor1
    /// </summary>
    public unsafe float DrivingHeadImpulseFactor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22624); }
    }

    /// <summary>
    /// StructProperty: DrivingModeHeadOffset1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DrivingModeHeadOffset1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22628); }
    }

    /// <summary>
    /// FloatProperty: DrivingModeSteeringCamFactor1
    /// </summary>
    public unsafe float DrivingModeSteeringCamFactor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22640); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamDriftOrientationFactor1
    /// </summary>
    public unsafe float DrivingCamDriftOrientationFactor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 22644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22644); }
    }

    /// <summary>
    /// StructProperty: BatmobileBoostCameraShake1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmobileBoostCameraShake1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22648); }
    }

    /// <summary>
    /// StructProperty: BatmobileWheelSpinCameraShake1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmobileWheelSpinCameraShake1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22804); }
    }

    /// <summary>
    /// StructProperty: BatmobileWheelSpinCameraCamOffset1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmobileWheelSpinCameraCamOffset1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22960); }
    }

    /// <summary>
    /// StructProperty: DrivingCamConfig2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DrivingCamConfig2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 22972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22972); }
    }

    /// <summary>
    /// StructProperty: BoostingCamConfig2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BoostingCamConfig2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23140); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamFOVInterpMaxSpeed2
    /// </summary>
    public unsafe float DrivingCamFOVInterpMaxSpeed2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23308); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamFOV2
    /// </summary>
    public unsafe float DrivingCamFOV2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23312); }
    }

    /// <summary>
    /// FloatProperty: BoostingCamFOV2
    /// </summary>
    public unsafe float BoostingCamFOV2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23316); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamMaxExtraFOV2
    /// </summary>
    public unsafe float DrivingCamMaxExtraFOV2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23320); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamMaxExtraTranslation2
    /// </summary>
    public unsafe float DrivingCamMaxExtraTranslation2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23324); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamMaxExtraSpringStrength2
    /// </summary>
    public unsafe float DrivingCamMaxExtraSpringStrength2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23328); }
    }

    /// <summary>
    /// FloatProperty: BoostingCamSmoothingStrength2
    /// </summary>
    public unsafe float BoostingCamSmoothingStrength2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23332); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamSmoothingStrength2
    /// </summary>
    public unsafe float DrivingCamSmoothingStrength2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23336); }
    }

    /// <summary>
    /// FloatProperty: AirborneCamSmoothingStrength2
    /// </summary>
    public unsafe float AirborneCamSmoothingStrength2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23340); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraOffset2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraOffset2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23344); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraSpringDampingPower2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraSpringDampingPower2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23356); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraSpringDampingFactor2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraSpringDampingFactor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23368); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraSpringPower2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraSpringPower2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23380); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraSpringConst2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraSpringConst2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23392); }
    }

    /// <summary>
    /// StructProperty: BonnetCameraAccelFactor2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCameraAccelFactor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23404); }
    }

    /// <summary>
    /// StructProperty: BonnetCamMax2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BonnetCamMax2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23416); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamAccelFOVFactor2
    /// </summary>
    public unsafe float DrivingCamAccelFOVFactor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23428); }
    }

    /// <summary>
    /// FloatProperty: DrivingCameraLeanFactor2
    /// </summary>
    public unsafe float DrivingCameraLeanFactor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23432); }
    }

    /// <summary>
    /// FloatProperty: DrivingCameraPitchFactor2
    /// </summary>
    public unsafe float DrivingCameraPitchFactor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23436); }
    }

    /// <summary>
    /// FloatProperty: DrivingHeadImpulseFactor2
    /// </summary>
    public unsafe float DrivingHeadImpulseFactor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23440); }
    }

    /// <summary>
    /// StructProperty: DrivingModeHeadOffset2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DrivingModeHeadOffset2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23444); }
    }

    /// <summary>
    /// FloatProperty: DrivingModeSteeringCamFactor2
    /// </summary>
    public unsafe float DrivingModeSteeringCamFactor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23456); }
    }

    /// <summary>
    /// StructProperty: BatmobileBoostCameraShake2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmobileBoostCameraShake2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23460); }
    }

    /// <summary>
    /// FloatProperty: DrivingCamDriftOrientationFactor2
    /// </summary>
    public unsafe float DrivingCamDriftOrientationFactor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23616); }
    }

    /// <summary>
    /// StructProperty: BatmobileWheelSpinCameraShake2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmobileWheelSpinCameraShake2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23620); }
    }

    /// <summary>
    /// StructProperty: BatmobileWheelSpinCameraCamOffset2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatmobileWheelSpinCameraCamOffset2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23776); }
    }

    /// <summary>
    /// StructProperty: LastCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23788); }
    }

    /// <summary>
    /// StructProperty: VoiceSynthCornerStateOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VoiceSynthCornerStateOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23800); }
    }

    /// <summary>
    /// FloatProperty: VoiceSynthCornerStateFOVAngle
    /// </summary>
    public unsafe float VoiceSynthCornerStateFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23812); }
    }

    /// <summary>
    /// StructProperty: VoiceSynthCornerStateDefaultRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VoiceSynthCornerStateDefaultRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23816); }
    }

    /// <summary>
    /// StructProperty: VoiceSynthCornerStateCameraPivotOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VoiceSynthCornerStateCameraPivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23828); }
    }

    /// <summary>
    /// StructProperty: CurrentBonentCamSpring
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentBonentCamSpring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23840); }
    }

    /// <summary>
    /// FloatProperty: BonetCamSpringMax
    /// </summary>
    public unsafe float BonetCamSpringMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23852); }
    }

    /// <summary>
    /// FloatProperty: BonetCamSpringStrength
    /// </summary>
    public unsafe float BonetCamSpringStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23856); }
    }

    /// <summary>
    /// StructProperty: LastRailingRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastRailingRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 23860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23860); }
    }

    /// <summary>
    /// FloatProperty: FollowFullRotationInterpolant
    /// </summary>
    public unsafe float FollowFullRotationInterpolant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 23872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23872); }
    }

    /// <summary>
    /// Struct: FFreeCameraConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FFreeCameraConfig
    {
        /// <summary>
        /// StructProperty: StateFreeCameraSitOffsetMin
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateFreeCameraSitOffsetMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCameraSitOffsetMax
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateFreeCameraSitOffsetMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: UseStateFreeCameraSitOffsetUp
        /// </summary>
        public unsafe bool UseStateFreeCameraSitOffsetUp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCameraSitOffsetUp
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateFreeCameraSitOffsetUp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCameraPullOffset
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateFreeCameraPullOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: CameraPivotOffset
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraPivotOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// StructProperty: ZoomedOffset
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ZoomedOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: maxPitch
        /// </summary>
        public unsafe float maxPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// FloatProperty: MinPitch
        /// </summary>
        public unsafe float MinPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: MinFreeCameraDistance
        /// </summary>
        public unsafe float MinFreeCameraDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// FloatProperty: MaxFreeCameraDistance
        /// </summary>
        public unsafe float MaxFreeCameraDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// FloatProperty: ShortCamSpringConst
        /// </summary>
        public unsafe float ShortCamSpringConst
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// FloatProperty: LongCamSpringConst
        /// </summary>
        public unsafe float LongCamSpringConst
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// FloatProperty: DefaultCameraPitch
        /// </summary>
        public unsafe float DefaultCameraPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// FloatProperty: CameraSitOffsetPower
        /// </summary>
        public unsafe float CameraSitOffsetPower
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// FloatProperty: CameraSitOffsetMin
        /// </summary>
        public unsafe float CameraSitOffsetMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }

        /// <summary>
        /// FloatProperty: CameraSitOffsetMax
        /// </summary>
        public unsafe float CameraSitOffsetMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// BoolProperty: bUseSeparate43Settings
        /// </summary>
        public unsafe bool bUseSeparate43Settings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCamera43SitOffsetMax
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateFreeCamera43SitOffsetMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCamera43SitOffsetMin
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateFreeCamera43SitOffsetMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCamera43SitOffsetLookUp
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateFreeCamera43SitOffsetLookUp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }

        /// <summary>
        /// BoolProperty: bDontModifySitOffsetWhenLookingUp
        /// </summary>
        public unsafe bool bDontModifySitOffsetWhenLookingUp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }; }
        }

        /// <summary>
        /// FloatProperty: MinCameraSmoothingAngle
        /// </summary>
        public unsafe float MinCameraSmoothingAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }; }
        }

        /// <summary>
        /// FloatProperty: MaxCameraSmoothingAngle
        /// </summary>
        public unsafe float MaxCameraSmoothingAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }; }
        }
    }
}
