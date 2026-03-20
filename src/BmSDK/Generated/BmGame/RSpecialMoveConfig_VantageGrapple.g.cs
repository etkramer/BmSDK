#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_VantageGrapple<br/>
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_VantageGrapple : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_VantageGrapple", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_VantageGrapple() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_VantageGrapple
    /// </summary>
    public RSpecialMoveConfig_VantageGrapple(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_VantageGrapple Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_VantageGrapple(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AnimName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ByteProperty: EndCheckFuzziness
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil.EFuzziness EndCheckFuzziness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EFuzziness>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ByteProperty: AimAt
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc AimAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc>(Ptr + 417); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 417); }
    }

    /// <summary>
    /// ByteProperty: AnimationDirection
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.EnvironmentAnimationDirection AnimationDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.EnvironmentAnimationDirection>(Ptr + 418); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 418); }
    }

    /// <summary>
    /// BoolProperty: bFinishIfTransitionWillFinishNextFrame
    /// </summary>
    public unsafe bool bFinishIfTransitionWillFinishNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: FollowBase
    /// </summary>
    public unsafe bool FollowBase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: FollowBaseYawOnly
    /// </summary>
    public unsafe bool FollowBaseYawOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bCrouchDuringAnim
    /// </summary>
    public unsafe bool bCrouchDuringAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bEarlyTunnelCamNotify
    /// </summary>
    public unsafe bool bEarlyTunnelCamNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bCanLandOnGargoyles
    /// </summary>
    public unsafe bool bCanLandOnGargoyles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreCollisionWithLocator
    /// </summary>
    public unsafe bool bIgnoreCollisionWithLocator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bGoStraightToGauntletConversation
    /// </summary>
    public unsafe bool bGoStraightToGauntletConversation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bForceCollideActorsOff
    /// </summary>
    public unsafe bool bForceCollideActorsOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bAlignRotationWithNormal
    /// </summary>
    public unsafe bool bAlignRotationWithNormal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bAlignWithPlayerMovementNotRotation
    /// </summary>
    public unsafe bool bAlignWithPlayerMovementNotRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bCheckIfNeedToAlignWithNormal
    /// </summary>
    public unsafe bool bCheckIfNeedToAlignWithNormal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bAlignPosition
    /// </summary>
    public unsafe bool bAlignPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bAlignAnimPitch
    /// </summary>
    public unsafe bool bAlignAnimPitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bCancelByFalling
    /// </summary>
    public unsafe bool bCancelByFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bPressToOverride
    /// </summary>
    public unsafe bool bPressToOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: AllowWallEvade
    /// </summary>
    public unsafe bool AllowWallEvade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bMirror
    /// </summary>
    public unsafe bool bMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: UseZOffset
    /// </summary>
    public unsafe bool UseZOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bSwitchFinalPoseMirror
    /// </summary>
    public unsafe bool bSwitchFinalPoseMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bNormalFacesOutwards
    /// </summary>
    public unsafe bool bNormalFacesOutwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bStopPlayerFallingOffEdges
    /// </summary>
    public unsafe bool bStopPlayerFallingOffEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: UseBatmanAnimNameForCamera
    /// </summary>
    public unsafe bool UseBatmanAnimNameForCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// NameProperty: EndMovementStance
    /// </summary>
    public unsafe BmSDK.FName EndMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// FloatProperty: KillXYVelocityScale
    /// </summary>
    public unsafe float KillXYVelocityScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// FloatProperty: OptimumDistance
    /// </summary>
    public unsafe float OptimumDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceCorrection
    /// </summary>
    public unsafe float MaxDistanceCorrection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// FloatProperty: MeetingTime
    /// </summary>
    public unsafe float MeetingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// FloatProperty: FallingAnimTime
    /// </summary>
    public unsafe float FallingAnimTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// FloatProperty: OverrideGlideSpeed
    /// </summary>
    public unsafe float OverrideGlideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }
}
