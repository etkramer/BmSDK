#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_LineLauncher<br/>
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_LineLauncher : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_LineLauncher", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_LineLauncher() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_LineLauncher
    /// </summary>
    public RSpecialMoveConfig_LineLauncher(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_LineLauncher Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_LineLauncher(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: FireAnimationName
    /// </summary>
    public unsafe BmSDK.FName FireAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// NameProperty: CoverFireAnimationName
    /// </summary>
    public unsafe BmSDK.FName CoverFireAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// NameProperty: DropToZipLineFromWireWalkAnim
    /// </summary>
    public unsafe BmSDK.FName DropToZipLineFromWireWalkAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// NameProperty: ZipLineIdle
    /// </summary>
    public unsafe BmSDK.FName ZipLineIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// NameProperty: KickIdle
    /// </summary>
    public unsafe BmSDK.FName KickIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// NameProperty: KickIn
    /// </summary>
    public unsafe BmSDK.FName KickIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// NameProperty: KickOut
    /// </summary>
    public unsafe BmSDK.FName KickOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// NameProperty: ForwardKickAnim
    /// </summary>
    public unsafe BmSDK.FName ForwardKickAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// NameProperty: LeftKickAnim
    /// </summary>
    public unsafe BmSDK.FName LeftKickAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// NameProperty: RightKickAnim
    /// </summary>
    public unsafe BmSDK.FName RightKickAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// NameProperty: TakedownInAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownInAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// NameProperty: TakedownInRightAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownInRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// NameProperty: TakedownBackInAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownBackInAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// NameProperty: TakedownLoopAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownLoopAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// NameProperty: TakedownLoopRightAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownLoopRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// NameProperty: TakedownGunInAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownGunInAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// NameProperty: TakedownGunBackInAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownGunBackInAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// NameProperty: TakedownGunLoopAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownGunLoopAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// NameProperty: TakedownGunLoopRightAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownGunLoopRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// NameProperty: TakedownPipeInAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownPipeInAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// NameProperty: TakedownPipeBackInAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownPipeBackInAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// NameProperty: TakedownPipeLoopAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownPipeLoopAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// NameProperty: TakedownDropAnim
    /// </summary>
    public unsafe BmSDK.FName TakedownDropAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// NameProperty: RescueInAnim
    /// </summary>
    public unsafe BmSDK.FName RescueInAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// NameProperty: RescueBackInAnim
    /// </summary>
    public unsafe BmSDK.FName RescueBackInAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// NameProperty: RescueLoopAnim
    /// </summary>
    public unsafe BmSDK.FName RescueLoopAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// NameProperty: GrabCatwomanWhileStandingFireAnimationName
    /// </summary>
    public unsafe BmSDK.FName GrabCatwomanWhileStandingFireAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// NameProperty: DropCatwomanWhileZipLiningAnimationName
    /// </summary>
    public unsafe BmSDK.FName DropCatwomanWhileZipLiningAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// NameProperty: LaunchCatwomanOntoCeilingWhileZipLiningAnimationName
    /// </summary>
    public unsafe BmSDK.FName LaunchCatwomanOntoCeilingWhileZipLiningAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// ObjectProperty: WallDismountWithCatwoman
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WallDismountWithCatwoman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ObjectProperty: ShortLandAnimWithCatwoman
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShortLandAnimWithCatwoman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ObjectProperty: ZipLoopSound
    /// </summary>
    public unsafe BmSDK.Engine.SoundCue ZipLoopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SoundCue>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: ZipLoopEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZipLoopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: ZipLineEndSound
    /// </summary>
    public unsafe BmSDK.Engine.SoundCue ZipLineEndSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SoundCue>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ObjectProperty: ZipLineEndEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZipLineEndEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ObjectProperty: KickSound
    /// </summary>
    public unsafe BmSDK.Engine.SoundCue KickSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SoundCue>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// ObjectProperty: KickEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent KickEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: ShortLandAnim
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShortLandAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: WallDismount
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WallDismount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: WallFallDismount
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WallFallDismount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: TakedownWallDismount
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig TakedownWallDismount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: TakedownWallDismountRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig TakedownWallDismountRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: TakedownWallFallDismount
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig TakedownWallFallDismount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ObjectProperty: VictimTakeDownAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VictimTakeDownAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: fAcceptableHorizontalSlideDistanceForCatwomanOnACatch
    /// </summary>
    public unsafe float fAcceptableHorizontalSlideDistanceForCatwomanOnACatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// NameProperty: CatchDroppingCatwomanWhileZipLiningAnimationName
    /// </summary>
    public unsafe BmSDK.FName CatchDroppingCatwomanWhileZipLiningAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: fDistanceFromBatmanWhereCatwomanLetsGoForDropCatch
    /// </summary>
    public unsafe float fDistanceFromBatmanWhereCatwomanLetsGoForDropCatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// FloatProperty: fDistanceAboveBatmanToAllowCatwomanDropCatch
    /// </summary>
    public unsafe float fDistanceAboveBatmanToAllowCatwomanDropCatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// NameProperty: CatchJumpingCatwomanWhileZipLiningAnimationName
    /// </summary>
    public unsafe BmSDK.FName CatchJumpingCatwomanWhileZipLiningAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: fDistanceFromBatmanWhereCatwomanJumpsForCatch
    /// </summary>
    public unsafe float fDistanceFromBatmanWhereCatwomanJumpsForCatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: fDistanceBelowBatmanToAllowCatwomanJumpCatch
    /// </summary>
    public unsafe float fDistanceBelowBatmanToAllowCatwomanJumpCatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// NameProperty: ScoopingCatwomanFromBehindWhileZipLiningAnimationName
    /// </summary>
    public unsafe BmSDK.FName ScoopingCatwomanFromBehindWhileZipLiningAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// NameProperty: ScoopingCatwomanFromFrontWhileZipLiningAnimationName
    /// </summary>
    public unsafe BmSDK.FName ScoopingCatwomanFromFrontWhileZipLiningAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: fAcceptableHorizontalSlideDistanceForCatwomanScoop
    /// </summary>
    public unsafe float fAcceptableHorizontalSlideDistanceForCatwomanScoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: fDistanceFromBatmanWhereCatwomanGetsScoopedUp
    /// </summary>
    public unsafe float fDistanceFromBatmanWhereCatwomanGetsScoopedUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: Acceleration
    /// </summary>
    public unsafe float Acceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: MaxSpeed
    /// </summary>
    public unsafe float MaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: HorizontalSpeed
    /// </summary>
    public unsafe float HorizontalSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: MinLandAnimHeight
    /// </summary>
    public unsafe float MinLandAnimHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// FloatProperty: MaxLandAnimHeight
    /// </summary>
    public unsafe float MaxLandAnimHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// FloatProperty: KickTime
    /// </summary>
    public unsafe float KickTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// FloatProperty: LeftKickTime
    /// </summary>
    public unsafe float LeftKickTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: RightKickTime
    /// </summary>
    public unsafe float RightKickTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: FwdKickRange
    /// </summary>
    public unsafe float FwdKickRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// FloatProperty: KickForce
    /// </summary>
    public unsafe float KickForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// FloatProperty: KickRange
    /// </summary>
    public unsafe float KickRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: KickPitch
    /// </summary>
    public unsafe float KickPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: ImpactSpeedMod
    /// </summary>
    public unsafe float ImpactSpeedMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// FloatProperty: VictimGrabTime
    /// </summary>
    public unsafe float VictimGrabTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// FloatProperty: HostageGrabTime
    /// </summary>
    public unsafe float HostageGrabTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// FloatProperty: VictimGrabRange
    /// </summary>
    public unsafe float VictimGrabRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: HostageGrabRange
    /// </summary>
    public unsafe float HostageGrabRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ArrayProperty: ExtraAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bAlignFireAnimation
    /// </summary>
    public unsafe bool bAlignFireAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// FloatProperty: TakedownStartTime
    /// </summary>
    public unsafe float TakedownStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }
}
