#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_CwPounceToTarget<br/>
/// (size = 700)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_CwPounceToTarget : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_CwPounceToTarget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_CwPounceToTarget() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_CwPounceToTarget
    /// </summary>
    public RSpecialMoveConfig_CwPounceToTarget(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_CwPounceToTarget Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_CwPounceToTarget(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: StandToLaunchAnim
    /// </summary>
    public unsafe BmSDK.FName StandToLaunchAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// NameProperty: RunToLaunchAnim
    /// </summary>
    public unsafe BmSDK.FName RunToLaunchAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// NameProperty: StandToLaunchPounceAnim
    /// </summary>
    public unsafe BmSDK.FName StandToLaunchPounceAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// NameProperty: RunToLaunchPounceAnim
    /// </summary>
    public unsafe BmSDK.FName RunToLaunchPounceAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// NameProperty: LaunchAnim
    /// </summary>
    public unsafe BmSDK.FName LaunchAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// NameProperty: LaunchFromRunAnim
    /// </summary>
    public unsafe BmSDK.FName LaunchFromRunAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// NameProperty: LandAnim
    /// </summary>
    public unsafe BmSDK.FName LandAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// NameProperty: LandNoWallAnim
    /// </summary>
    public unsafe BmSDK.FName LandNoWallAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// NameProperty: Land45Anim
    /// </summary>
    public unsafe BmSDK.FName Land45Anim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// NameProperty: LandRightAnim
    /// </summary>
    public unsafe BmSDK.FName LandRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// NameProperty: OverLedgeStandAnim
    /// </summary>
    public unsafe BmSDK.FName OverLedgeStandAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// NameProperty: OverLedgeRunAnim
    /// </summary>
    public unsafe BmSDK.FName OverLedgeRunAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// NameProperty: OverRailingStandAnim
    /// </summary>
    public unsafe BmSDK.FName OverRailingStandAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// NameProperty: OverRailingRunAnim
    /// </summary>
    public unsafe BmSDK.FName OverRailingRunAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// NameProperty: OverLedgeStandRightAnim
    /// </summary>
    public unsafe BmSDK.FName OverLedgeStandRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// NameProperty: OverLedgeRunRightAnim
    /// </summary>
    public unsafe BmSDK.FName OverLedgeRunRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// NameProperty: OverRailingStandRightAnim
    /// </summary>
    public unsafe BmSDK.FName OverRailingStandRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// NameProperty: OverRailingRunRightAnim
    /// </summary>
    public unsafe BmSDK.FName OverRailingRunRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// NameProperty: LandIdleAnim
    /// </summary>
    public unsafe BmSDK.FName LandIdleAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// NameProperty: MidAirAnim
    /// </summary>
    public unsafe BmSDK.FName MidAirAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// NameProperty: FallAnim
    /// </summary>
    public unsafe BmSDK.FName FallAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// NameProperty: ClimbLedgeAnim
    /// </summary>
    public unsafe BmSDK.FName ClimbLedgeAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// NameProperty: ClimbRailingAnim
    /// </summary>
    public unsafe BmSDK.FName ClimbRailingAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// NameProperty: ClimbLedgeCameraState
    /// </summary>
    public unsafe BmSDK.FName ClimbLedgeCameraState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// NameProperty: ClimbRailingCameraState
    /// </summary>
    public unsafe BmSDK.FName ClimbRailingCameraState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// NameProperty: ClimbLedgeEndMovementStance
    /// </summary>
    public unsafe BmSDK.FName ClimbLedgeEndMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// NameProperty: ClimbRailingEndMovementStance
    /// </summary>
    public unsafe BmSDK.FName ClimbRailingEndMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// NameProperty: ClimbLedgeEndControllerState
    /// </summary>
    public unsafe BmSDK.FName ClimbLedgeEndControllerState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// NameProperty: ClimbRailingEndControllerState
    /// </summary>
    public unsafe BmSDK.FName ClimbRailingEndControllerState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// NameProperty: EndCameraState
    /// </summary>
    public unsafe BmSDK.FName EndCameraState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// BoolProperty: UseVantagePointCamera
    /// </summary>
    public unsafe bool UseVantagePointCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: PounceToCeiling
    /// </summary>
    public unsafe bool PounceToCeiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bDetectLandingFeatures
    /// </summary>
    public unsafe bool bDetectLandingFeatures
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bLookInLandDirection
    /// </summary>
    public unsafe bool bLookInLandDirection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }
}
