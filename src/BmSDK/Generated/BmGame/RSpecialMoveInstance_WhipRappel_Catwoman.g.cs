#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveInstance_WhipRappel_Catwoman<br/>
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveInstance_WhipRappel_Catwoman : BmSDK.BmGame.RSpecialMoveInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveInstance_WhipRappel_Catwoman", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveInstance_WhipRappel_Catwoman() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_WhipRappel_Catwoman
    /// </summary>
    public RSpecialMoveInstance_WhipRappel_Catwoman(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveInstance_WhipRappel_Catwoman Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_WhipRappel_Catwoman(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_WhipRappel_Catwoman>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_WhipRappel_Catwoman>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_WhipRappel_Catwoman>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_WhipRappel_Catwoman>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_WhipRappel_Catwoman>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_WhipRappel_Catwoman>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_WhipRappel_Catwoman>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: CurrentTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CurrentTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// StructProperty: QueuedTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerBmBase Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerBmBase>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: Catwoman
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCatwomanBase Catwoman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCatwomanBase>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: MyConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig_WhipRappel_Catwoman MyConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig_WhipRappel_Catwoman>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: vJumpingDownCatwomanTargetPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 vJumpingDownCatwomanTargetPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// StructProperty: rJumpingDownCatwomanTargetRotation
    /// </summary>
    public unsafe BmSDK.Rotator rJumpingDownCatwomanTargetRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bStartFromTheRight
    /// </summary>
    public unsafe bool bStartFromTheRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bDangleAngleIsIncreasing
    /// </summary>
    public unsafe bool bDangleAngleIsIncreasing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bPendulumSwingHasStopped
    /// </summary>
    public unsafe bool bPendulumSwingHasStopped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bSwingHasStarted
    /// </summary>
    public unsafe bool bSwingHasStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bSwingHasFinishedStarting
    /// </summary>
    public unsafe bool bSwingHasFinishedStarting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bSwingIsSlowingDown
    /// </summary>
    public unsafe bool bSwingIsSlowingDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bPlayFastInAnimationToStart
    /// </summary>
    public unsafe bool bPlayFastInAnimationToStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForRestartWhileSlowlyComingToAHalt
    /// </summary>
    public unsafe bool bWaitingForRestartWhileSlowlyComingToAHalt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bResetIdleStartTimeHack
    /// </summary>
    public unsafe bool bResetIdleStartTimeHack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bMovingTowardsCentre
    /// </summary>
    public unsafe bool bMovingTowardsCentre
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bAimingBolas
    /// </summary>
    public unsafe bool bAimingBolas
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bCatwomanCanReserveJumpNow
    /// </summary>
    public unsafe bool bCatwomanCanReserveJumpNow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bCatwomanCanJumpNow
    /// </summary>
    public unsafe bool bCatwomanCanJumpNow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bPlayerHasReservedJump
    /// </summary>
    public unsafe bool bPlayerHasReservedJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// StructProperty: vDangleStartPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 vDangleStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: fLastDangleAngle
    /// </summary>
    public unsafe float fLastDangleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// StructProperty: vLastDangleMoveDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 vLastDangleMoveDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: fDangleMaxAngleDifference
    /// </summary>
    public unsafe float fDangleMaxAngleDifference
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: fCurrentSwingSpeedMultiplier
    /// </summary>
    public unsafe float fCurrentSwingSpeedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: fPendulumHeightOffset
    /// </summary>
    public unsafe float fPendulumHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: fClimbingAtMaximumHeighOffsetTimer
    /// </summary>
    public unsafe float fClimbingAtMaximumHeighOffsetTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: fPendulumMinimumHeightOffset
    /// </summary>
    public unsafe float fPendulumMinimumHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: fLastSwingLeftWeight
    /// </summary>
    public unsafe float fLastSwingLeftWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: fLastSwingRightWeight
    /// </summary>
    public unsafe float fLastSwingRightWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: fAmountOfLeftStickDeadTime
    /// </summary>
    public unsafe float fAmountOfLeftStickDeadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// StructProperty: rOriginalSwingStartRotation
    /// </summary>
    public unsafe BmSDK.Rotator rOriginalSwingStartRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// StructProperty: vCurrentCircleCentre
    /// </summary>
    public unsafe System.Numerics.Vector3 vCurrentCircleCentre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: fTimeSinceStartedAddingHorizontalTranslation
    /// </summary>
    public unsafe float fTimeSinceStartedAddingHorizontalTranslation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: fHorizontalTranslationAlreadyAdded
    /// </summary>
    public unsafe float fHorizontalTranslationAlreadyAdded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// DelegateProperty: __WhippingAnimFinished__Delegate
    /// </summary>
    public unsafe System.IntPtr __WhippingAnimFinished__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// DelegateProperty: __CartwheelingAnimFinished__Delegate
    /// </summary>
    public unsafe System.IntPtr __CartwheelingAnimFinished__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }
}
