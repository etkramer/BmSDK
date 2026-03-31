#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_RelativeAnimMove<br/>
/// (size = 348)
/// (flags = 134221970)
/// </summary>
public partial class RSpecialMoveConfig_RelativeAnimMove : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_RelativeAnimMove", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_RelativeAnimMove() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_RelativeAnimMove
    /// </summary>
    public RSpecialMoveConfig_RelativeAnimMove(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_RelativeAnimMove Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_RelativeAnimMove(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_RelativeAnimMove>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_RelativeAnimMove>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_RelativeAnimMove>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_RelativeAnimMove>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_RelativeAnimMove>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_RelativeAnimMove>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_RelativeAnimMove>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveConfig_RelativeAnimMove>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.RPlayerController Controller, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator MoveLocation, bool ForceReplicateToClient = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMoveConfig_RelativeAnimMove.TriggerSpecialMove", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Controller, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceReplicateToClient, paramsPtr + 116);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetFreeRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetFreeRotation(BmSDK.BmGame.RPlayerController Controller, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMoveConfig_RelativeAnimMove.GetFreeRotation", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Controller, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 116);
    }

    /// <summary>
    /// Function: GetPredictedEndLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPredictedEndLocation(BmSDK.BmGame.RPlayerController Controller, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMoveConfig_RelativeAnimMove.GetPredictedEndLocation", true);
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Controller, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 116);
    }

    /// <summary>
    /// Function: GetSpecialMoveIdealStartLoc
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetSpecialMoveIdealStartLoc(BmSDK.BmGame.RPlayerController Controller, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMoveConfig_RelativeAnimMove.GetSpecialMoveIdealStartLoc", true);
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Controller, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 116);
    }

    /// <summary>
    /// Enum: ERelativeAnimMoveExtraInfo
    /// </summary>
    public enum ERelativeAnimMoveExtraInfo
    {
        ERAMEI_FreeRotation = 0,
        ERAMEI_MAX = 1,
    }

    /// <summary>
    /// ArrayProperty: AnimName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// ByteProperty: EndCheckFuzziness
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil.EFuzziness EndCheckFuzziness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EFuzziness>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ByteProperty: AimAt
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc AimAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc>(Ptr + 309); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 309); }
    }

    /// <summary>
    /// ByteProperty: AnimationDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.EnvironmentAnimationDirection AnimationDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EnvironmentAnimationDirection>(Ptr + 310); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 310); }
    }

    /// <summary>
    /// BoolProperty: bFinishIfTransitionWillFinishNextFrame
    /// </summary>
    public unsafe bool bFinishIfTransitionWillFinishNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: FollowBase
    /// </summary>
    public unsafe bool FollowBase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bCrouchDuringAnim
    /// </summary>
    public unsafe bool bCrouchDuringAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bEarlyTunnelCamNotify
    /// </summary>
    public unsafe bool bEarlyTunnelCamNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bCanLandOnGargoyles
    /// </summary>
    public unsafe bool bCanLandOnGargoyles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bForceCollideActorsOff
    /// </summary>
    public unsafe bool bForceCollideActorsOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bAlignRotationWithNormal
    /// </summary>
    public unsafe bool bAlignRotationWithNormal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bCheckIfNeedToAlignWithNormal
    /// </summary>
    public unsafe bool bCheckIfNeedToAlignWithNormal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bAlignPosition
    /// </summary>
    public unsafe bool bAlignPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bAlignAnimPitch
    /// </summary>
    public unsafe bool bAlignAnimPitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bCancelByFalling
    /// </summary>
    public unsafe bool bCancelByFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bPressToOverride
    /// </summary>
    public unsafe bool bPressToOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: AllowWallEvade
    /// </summary>
    public unsafe bool AllowWallEvade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bMirror
    /// </summary>
    public unsafe bool bMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: UseZOffset
    /// </summary>
    public unsafe bool UseZOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bSwitchFinalPoseMirror
    /// </summary>
    public unsafe bool bSwitchFinalPoseMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bNormalFacesOutwards
    /// </summary>
    public unsafe bool bNormalFacesOutwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bStopPlayerFallingOffEdges
    /// </summary>
    public unsafe bool bStopPlayerFallingOffEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// NameProperty: EndMovementStance
    /// </summary>
    public unsafe BmSDK.FName EndMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// FloatProperty: KillXYVelocityScale
    /// </summary>
    public unsafe float KillXYVelocityScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// FloatProperty: OptimumDistance
    /// </summary>
    public unsafe float OptimumDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceCorrection
    /// </summary>
    public unsafe float MaxDistanceCorrection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// FloatProperty: MeetingTime
    /// </summary>
    public unsafe float MeetingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// FloatProperty: FallingAnimTime
    /// </summary>
    public unsafe float FallingAnimTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// FloatProperty: OverrideGlideSpeed
    /// </summary>
    public unsafe float OverrideGlideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }
}
