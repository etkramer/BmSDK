#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_DisableSuperHeavyTankShield<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_DisableSuperHeavyTankShield : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_DisableSuperHeavyTankShield", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_DisableSuperHeavyTankShield() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_DisableSuperHeavyTankShield
    /// </summary>
    public RSpecialMoveConfig_DisableSuperHeavyTankShield(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_DisableSuperHeavyTankShield Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_DisableSuperHeavyTankShield(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AnimName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ByteProperty: EndCheckFuzziness
    /// </summary>
    public unsafe byte EndCheckFuzziness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ByteProperty: AimAt
    /// </summary>
    public unsafe byte AimAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 417); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 417); }
    }

    /// <summary>
    /// ByteProperty: AnimationDirection
    /// </summary>
    public unsafe byte AnimationDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 418); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 418); }
    }

    /// <summary>
    /// BoolProperty: bFinishIfTransitionWillFinishNextFrame
    /// </summary>
    public unsafe bool bFinishIfTransitionWillFinishNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: FollowBase
    /// </summary>
    public unsafe bool FollowBase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: FollowBaseYawOnly
    /// </summary>
    public unsafe bool FollowBaseYawOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bCrouchDuringAnim
    /// </summary>
    public unsafe bool bCrouchDuringAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bEarlyTunnelCamNotify
    /// </summary>
    public unsafe bool bEarlyTunnelCamNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bCanLandOnGargoyles
    /// </summary>
    public unsafe bool bCanLandOnGargoyles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreCollisionWithLocator
    /// </summary>
    public unsafe bool bIgnoreCollisionWithLocator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bGoStraightToGauntletConversation
    /// </summary>
    public unsafe bool bGoStraightToGauntletConversation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bForceCollideActorsOff
    /// </summary>
    public unsafe bool bForceCollideActorsOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bAlignRotationWithNormal
    /// </summary>
    public unsafe bool bAlignRotationWithNormal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bAlignWithPlayerMovementNotRotation
    /// </summary>
    public unsafe bool bAlignWithPlayerMovementNotRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bCheckIfNeedToAlignWithNormal
    /// </summary>
    public unsafe bool bCheckIfNeedToAlignWithNormal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bAlignPosition
    /// </summary>
    public unsafe bool bAlignPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bAlignAnimPitch
    /// </summary>
    public unsafe bool bAlignAnimPitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bCancelByFalling
    /// </summary>
    public unsafe bool bCancelByFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bPressToOverride
    /// </summary>
    public unsafe bool bPressToOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: AllowWallEvade
    /// </summary>
    public unsafe bool AllowWallEvade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bMirror
    /// </summary>
    public unsafe bool bMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: UseZOffset
    /// </summary>
    public unsafe bool UseZOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bSwitchFinalPoseMirror
    /// </summary>
    public unsafe bool bSwitchFinalPoseMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bNormalFacesOutwards
    /// </summary>
    public unsafe bool bNormalFacesOutwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bStopPlayerFallingOffEdges
    /// </summary>
    public unsafe bool bStopPlayerFallingOffEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: UseBatmanAnimNameForCamera
    /// </summary>
    public unsafe bool UseBatmanAnimNameForCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
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
