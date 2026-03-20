#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerConfig<br/>
/// (flags = 0)
/// </summary>
public partial class RPawnPlayerConfig : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerConfig() { }

    /// <summary>
    /// Constructs a new RPawnPlayerConfig
    /// </summary>
    public RPawnPlayerConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayerConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerConfig(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DefaultIdleOverlayAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet DefaultIdleOverlayAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: CrouchIdleOverlayAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CrouchIdleOverlayAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: CoverIdleOverlayAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CoverIdleOverlayAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: DangleIdleOverlayAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet DangleIdleOverlayAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: HangIdleOverlayAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet HangIdleOverlayAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: SilentPredatorIdleOverlayAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet SilentPredatorIdleOverlayAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: DefaultTurnAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet DefaultTurnAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: CrouchTurnAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CrouchTurnAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: GadgetTurnAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GadgetTurnAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: GrateWalkTurnAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GrateWalkTurnAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: RailingTurnAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RailingTurnAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: WireTurnAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet WireTurnAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ObjectProperty: StrikeAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet StrikeAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ObjectProperty: CombatAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CombatAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ObjectProperty: HitReactionAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet HitReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: DamagedAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet DamagedAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: DeathAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet DeathAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ObjectProperty: CombatIdlesAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CombatIdlesAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ObjectProperty: OverrideThugPredatorAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet OverrideThugPredatorAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ObjectProperty: SpecialMoveAnimsets
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet SpecialMoveAnimsets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }
    /// <summary>
    /// ObjectProperty: SpecialMoveAnimsets
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet SpecialMoveAnimsets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
    /// <summary>
    /// ObjectProperty: SpecialMoveAnimsets
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet SpecialMoveAnimsets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
    /// <summary>
    /// ObjectProperty: SpecialMoveAnimsets
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet SpecialMoveAnimsets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }
    /// <summary>
    /// ObjectProperty: SpecialMoveAnimsets
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet SpecialMoveAnimsets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }
    /// <summary>
    /// ObjectProperty: SpecialMoveAnimsets
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet SpecialMoveAnimsets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
    /// <summary>
    /// ObjectProperty: SpecialMoveAnimsets
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet SpecialMoveAnimsets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }
    /// <summary>
    /// ObjectProperty: SpecialMoveAnimsets
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet SpecialMoveAnimsets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: DiveFromVantagePointMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveFromVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ObjectProperty: GlideFromVantagePointMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideFromVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ObjectProperty: JumpOrGlideFromRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig JumpOrGlideFromRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideLandHardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideLandHardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideLandSkidMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideLandSkidMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideLandToRunMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideLandToRunMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// ObjectProperty: FastGlideSkidLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FastGlideSkidLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ObjectProperty: BoostGlideLandHardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BoostGlideLandHardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideWallHitMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideWallHitMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ObjectProperty: PounceOnThugFromEdgeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceOnThugFromEdgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// ObjectProperty: PounceOnThugFromVantageMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceOnThugFromVantageMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ObjectProperty: JumpForwardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig JumpForwardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ObjectProperty: SwingKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SwingKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonOpenGrateMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HarpoonOpenGrateMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// ObjectProperty: GlassSmashDownMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlassSmashDownMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ObjectProperty: RanOverByCarMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RanOverByCarMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickWithGadgetMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideKickWithGadgetMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ObjectProperty: ShockwaveUpgradeLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShockwaveUpgradeLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideWallRunMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideWallRunMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ObjectProperty: CapGlideWallPushOff
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapGlideWallPushOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ObjectProperty: PullThugDriverFromCar_FromAbove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PullThugDriverFromCar_FromAbove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ObjectProperty: PullThugDriverFromCar_FromInFront
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PullThugDriverFromCar_FromInFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideWallHitHardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideWallHitHardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// ObjectProperty: PounceToCeilingCrouchMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToCeilingCrouchMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ObjectProperty: PounceToCeilingStandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToCeilingStandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// ObjectProperty: DropFromCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DropFromCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// ObjectProperty: CeilingToDangleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CeilingToDangleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// ObjectProperty: DangleToCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DangleToCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// ObjectProperty: HitAndDropFromCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HitAndDropFromCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// ObjectProperty: VentCrouchToCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig VentCrouchToCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ObjectProperty: VentCeilingToCrouchMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig VentCeilingToCrouchMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: CatwalkToCeilingRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CatwalkToCeilingRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ObjectProperty: CatwalkToCeilingStandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CatwalkToCeilingStandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ObjectProperty: CatwalkToCeilingEdgeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CatwalkToCeilingEdgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ObjectProperty: CatwalkToCeilingFarMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CatwalkToCeilingFarMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ObjectProperty: CeilingToCatwalkRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CeilingToCatwalkRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ObjectProperty: CeilingToCatwalkEdgeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CeilingToCatwalkEdgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: CeilingToCatwalkEdgeShortLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CeilingToCatwalkEdgeShortLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ObjectProperty: CeilingFarToCatwalkRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CeilingFarToCatwalkRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ObjectProperty: PickPocketMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PickPocketMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ObjectProperty: GrateToCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrateToCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ObjectProperty: GrateFromCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrateFromCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallLandSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallLandSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallLandRunSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallLandRunSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallRailingLandSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallRailingLandSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallRailingWalkLandSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallRailingWalkLandSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ObjectProperty: OverrideVantageSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverrideVantageSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: OverrideVantageLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverrideVantageLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: OverrideLampSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverrideLampSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: WallClimbingClimbUpOntoSurfaceMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WallClimbingClimbUpOntoSurfaceMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: WallClimbingClimbUpOntoCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WallClimbingClimbUpOntoCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: WallClimbingTransitionFromLedgeHang
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WallClimbingTransitionFromLedgeHang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: WallClimbingTransitionFromJump
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WallClimbingTransitionFromJump
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: WallClimbingJumpBackwards
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WallClimbingJumpBackwards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: WhipRappelSpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WhipRappelSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: PredatorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PredatorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: ThugPredatorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ThugPredatorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: PredatorCameraAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PredatorCameraAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: FallbackPredatorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet FallbackPredatorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: FallbackThugPredatorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet FallbackThugPredatorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: FearTakedownAimingConfig
    /// </summary>
    public unsafe BmSDK.Engine.RAimingConfig FearTakedownAimingConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAimingConfig>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bHas2Evades
    /// </summary>
    public unsafe bool bHas2Evades
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bHasDirectionalEvades
    /// </summary>
    public unsafe bool bHasDirectionalEvades
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// ArrayProperty: MovementAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> MovementAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ArrayProperty: ClimbingAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> ClimbingAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ArrayProperty: GadgetAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> GadgetAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ArrayProperty: CharacterSpecificAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> CharacterSpecificAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ArrayProperty: PoseConfigs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPoseConfig> PoseConfigs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPoseConfig>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: RailingMovingOrientation
    /// </summary>
    public unsafe float RailingMovingOrientation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: RailingMovingUp
    /// </summary>
    public unsafe float RailingMovingUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: RailingMovingAlong
    /// </summary>
    public unsafe float RailingMovingAlong
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: RailingMovingDown
    /// </summary>
    public unsafe float RailingMovingDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// FloatProperty: RailingPredatorOrientation
    /// </summary>
    public unsafe float RailingPredatorOrientation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// FloatProperty: RailingPredatorUp
    /// </summary>
    public unsafe float RailingPredatorUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// FloatProperty: RailingPredatorAlong
    /// </summary>
    public unsafe float RailingPredatorAlong
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// FloatProperty: RailingPredatorDown
    /// </summary>
    public unsafe float RailingPredatorDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ArrayProperty: GadgetArchetypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RInventoryGadget> GadgetArchetypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }
}
